
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRelationshipBL
 表名:Relationship(01120045)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:42:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
public static class  clsRelationshipBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRelationshipEN GetObj(this K_RelationshipId_Relationship myKey)
{
clsRelationshipEN objRelationshipEN = clsRelationshipBL.RelationshipDA.GetObjByRelationshipId(myKey.Value);
return objRelationshipEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRelationshipEN objRelationshipEN)
{
if (CheckUniqueness(objRelationshipEN) == false)
{
var strMsg = string.Format("记录已经存在!PictureId = [{0}],部门Id = [{1}]的数据已经存在!(in clsRelationshipBL.AddNewRecord)", objRelationshipEN.PictureId,objRelationshipEN.DepartmentId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsRelationshipBL.RelationshipDA.AddNewRecordBySQL2(objRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
public static bool AddRecordEx(this clsRelationshipEN objRelationshipEN)
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
objRelationshipEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objRelationshipEN.CheckUniqueness() == false)
{
strMsg = string.Format("(PictureId(PictureId)=[{0}],部门Id(DepartmentId)=[{1}])已经存在,不能重复!", objRelationshipEN.PictureId, objRelationshipEN.DepartmentId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objRelationshipEN.AddNewRecord();
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
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRelationshipEN objRelationshipEN)
{
if (CheckUniqueness(objRelationshipEN) == false)
{
var strMsg = string.Format("记录已经存在!PictureId = [{0}],部门Id = [{1}]的数据已经存在!(in clsRelationshipBL.AddNewRecordWithReturnKey)", objRelationshipEN.PictureId,objRelationshipEN.DepartmentId);
throw new Exception(strMsg);
}
try
{
string strKey = clsRelationshipBL.RelationshipDA.AddNewRecordBySQL2WithReturnKey(objRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetRelationshipId(this clsRelationshipEN objRelationshipEN, int intRelationshipId, string strComparisonOp="")
	{
objRelationshipEN.RelationshipId = intRelationshipId; //RelationshipId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.RelationshipId) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.RelationshipId, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.RelationshipId] = strComparisonOp;
}
}
return objRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetPictureId(this clsRelationshipEN objRelationshipEN, int intPictureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intPictureId, conRelationship.PictureId);
objRelationshipEN.PictureId = intPictureId; //PictureId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.PictureId) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.PictureId, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.PictureId] = strComparisonOp;
}
}
return objRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetLastModifyUserID(this clsRelationshipEN objRelationshipEN, string strLastModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLastModifyUserID, conRelationship.LastModifyUserID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastModifyUserID, 20, conRelationship.LastModifyUserID);
}
objRelationshipEN.LastModifyUserID = strLastModifyUserID; //最后修改用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.LastModifyUserID) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.LastModifyUserID, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.LastModifyUserID] = strComparisonOp;
}
}
return objRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetDepartmentId(this clsRelationshipEN objRelationshipEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, conRelationship.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, conRelationship.DepartmentId);
}
objRelationshipEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.DepartmentId) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.DepartmentId, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.DepartmentId] = strComparisonOp;
}
}
return objRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetCreateTime(this clsRelationshipEN objRelationshipEN, string strCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateTime, conRelationship.CreateTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateTime, 16, conRelationship.CreateTime);
}
objRelationshipEN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.CreateTime) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.CreateTime, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.CreateTime] = strComparisonOp;
}
}
return objRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetCreateUserID(this clsRelationshipEN objRelationshipEN, string strCreateUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserID, conRelationship.CreateUserID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, conRelationship.CreateUserID);
}
objRelationshipEN.CreateUserID = strCreateUserID; //建立用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.CreateUserID) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.CreateUserID, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.CreateUserID] = strComparisonOp;
}
}
return objRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetLastModifyTime(this clsRelationshipEN objRelationshipEN, string strLastModifyTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLastModifyTime, conRelationship.LastModifyTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastModifyTime, 16, conRelationship.LastModifyTime);
}
objRelationshipEN.LastModifyTime = strLastModifyTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.LastModifyTime) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.LastModifyTime, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.LastModifyTime] = strComparisonOp;
}
}
return objRelationshipEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationshipEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRelationshipEN SetMemo(this clsRelationshipEN objRelationshipEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRelationship.Memo);
}
objRelationshipEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationshipEN.dicFldComparisonOp.ContainsKey(conRelationship.Memo) == false)
{
objRelationshipEN.dicFldComparisonOp.Add(conRelationship.Memo, strComparisonOp);
}
else
{
objRelationshipEN.dicFldComparisonOp[conRelationship.Memo] = strComparisonOp;
}
}
return objRelationshipEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRelationshipEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRelationshipEN objRelationshipEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRelationshipEN.CheckPropertyNew();
clsRelationshipEN objRelationshipCond = new clsRelationshipEN();
string strCondition = objRelationshipCond
.SetRelationshipId(objRelationshipEN.RelationshipId, "<>")
.SetPictureId(objRelationshipEN.PictureId, "=")
.SetDepartmentId(objRelationshipEN.DepartmentId, "=")
.GetCombineCondition();
objRelationshipEN._IsCheckProperty = true;
bool bolIsExist = clsRelationshipBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PictureId_DepartmentId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRelationshipEN.Update();
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
 /// <param name = "objRelationship">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsRelationshipEN objRelationship)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsRelationshipEN objRelationshipCond = new clsRelationshipEN();
string strCondition = objRelationshipCond
.SetPictureId(objRelationship.PictureId, "=")
.SetDepartmentId(objRelationship.DepartmentId, "=")
.GetCombineCondition();
objRelationship._IsCheckProperty = true;
bool bolIsExist = clsRelationshipBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objRelationship.RelationshipId = clsRelationshipBL.GetFirstID_S(strCondition);
objRelationship.UpdateWithCondition(strCondition);
}
else
{
objRelationship.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRelationshipEN objRelationshipEN)
{
 if (objRelationshipEN.RelationshipId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRelationshipBL.RelationshipDA.UpdateBySql2(objRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRelationshipEN objRelationshipEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRelationshipEN.RelationshipId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRelationshipBL.RelationshipDA.UpdateBySql2(objRelationshipEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRelationshipEN objRelationshipEN, string strWhereCond)
{
try
{
bool bolResult = clsRelationshipBL.RelationshipDA.UpdateBySqlWithCondition(objRelationshipEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRelationshipEN objRelationshipEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRelationshipBL.RelationshipDA.UpdateBySqlWithConditionTransaction(objRelationshipEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsRelationshipEN objRelationshipEN)
{
try
{
int intRecNum = clsRelationshipBL.RelationshipDA.DelRecord(objRelationshipEN.RelationshipId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipENS">源对象</param>
 /// <param name = "objRelationshipENT">目标对象</param>
 public static void CopyTo(this clsRelationshipEN objRelationshipENS, clsRelationshipEN objRelationshipENT)
{
try
{
objRelationshipENT.RelationshipId = objRelationshipENS.RelationshipId; //RelationshipId
objRelationshipENT.PictureId = objRelationshipENS.PictureId; //PictureId
objRelationshipENT.LastModifyUserID = objRelationshipENS.LastModifyUserID; //最后修改用户ID
objRelationshipENT.DepartmentId = objRelationshipENS.DepartmentId; //部门Id
objRelationshipENT.CreateTime = objRelationshipENS.CreateTime; //建立时间
objRelationshipENT.CreateUserID = objRelationshipENS.CreateUserID; //建立用户ID
objRelationshipENT.LastModifyTime = objRelationshipENS.LastModifyTime; //最后修改时间
objRelationshipENT.Memo = objRelationshipENS.Memo; //备注
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
 /// <param name = "objRelationshipENS">源对象</param>
 /// <returns>目标对象=>clsRelationshipEN:objRelationshipENT</returns>
 public static clsRelationshipEN CopyTo(this clsRelationshipEN objRelationshipENS)
{
try
{
 clsRelationshipEN objRelationshipENT = new clsRelationshipEN()
{
RelationshipId = objRelationshipENS.RelationshipId, //RelationshipId
PictureId = objRelationshipENS.PictureId, //PictureId
LastModifyUserID = objRelationshipENS.LastModifyUserID, //最后修改用户ID
DepartmentId = objRelationshipENS.DepartmentId, //部门Id
CreateTime = objRelationshipENS.CreateTime, //建立时间
CreateUserID = objRelationshipENS.CreateUserID, //建立用户ID
LastModifyTime = objRelationshipENS.LastModifyTime, //最后修改时间
Memo = objRelationshipENS.Memo, //备注
};
 return objRelationshipENT;
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
public static void CheckPropertyNew(this clsRelationshipEN objRelationshipEN)
{
 clsRelationshipBL.RelationshipDA.CheckPropertyNew(objRelationshipEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRelationshipEN objRelationshipEN)
{
 clsRelationshipBL.RelationshipDA.CheckProperty4Condition(objRelationshipEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRelationshipEN objRelationshipCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRelationshipCond.IsUpdated(conRelationship.RelationshipId) == true)
{
string strComparisonOpRelationshipId = objRelationshipCond.dicFldComparisonOp[conRelationship.RelationshipId];
strWhereCond += string.Format(" And {0} {2} {1}", conRelationship.RelationshipId, objRelationshipCond.RelationshipId, strComparisonOpRelationshipId);
}
if (objRelationshipCond.IsUpdated(conRelationship.PictureId) == true)
{
string strComparisonOpPictureId = objRelationshipCond.dicFldComparisonOp[conRelationship.PictureId];
strWhereCond += string.Format(" And {0} {2} {1}", conRelationship.PictureId, objRelationshipCond.PictureId, strComparisonOpPictureId);
}
if (objRelationshipCond.IsUpdated(conRelationship.LastModifyUserID) == true)
{
string strComparisonOpLastModifyUserID = objRelationshipCond.dicFldComparisonOp[conRelationship.LastModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationship.LastModifyUserID, objRelationshipCond.LastModifyUserID, strComparisonOpLastModifyUserID);
}
if (objRelationshipCond.IsUpdated(conRelationship.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objRelationshipCond.dicFldComparisonOp[conRelationship.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationship.DepartmentId, objRelationshipCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objRelationshipCond.IsUpdated(conRelationship.CreateTime) == true)
{
string strComparisonOpCreateTime = objRelationshipCond.dicFldComparisonOp[conRelationship.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationship.CreateTime, objRelationshipCond.CreateTime, strComparisonOpCreateTime);
}
if (objRelationshipCond.IsUpdated(conRelationship.CreateUserID) == true)
{
string strComparisonOpCreateUserID = objRelationshipCond.dicFldComparisonOp[conRelationship.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationship.CreateUserID, objRelationshipCond.CreateUserID, strComparisonOpCreateUserID);
}
if (objRelationshipCond.IsUpdated(conRelationship.LastModifyTime) == true)
{
string strComparisonOpLastModifyTime = objRelationshipCond.dicFldComparisonOp[conRelationship.LastModifyTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationship.LastModifyTime, objRelationshipCond.LastModifyTime, strComparisonOpLastModifyTime);
}
if (objRelationshipCond.IsUpdated(conRelationship.Memo) == true)
{
string strComparisonOpMemo = objRelationshipCond.dicFldComparisonOp[conRelationship.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationship.Memo, objRelationshipCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Relationship(关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PictureId_DepartmentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objRelationshipEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsRelationshipEN objRelationshipEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objRelationshipEN == null) return true;
if (objRelationshipEN.RelationshipId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PictureId = '{0}'", objRelationshipEN.PictureId);
 sbCondition.AppendFormat(" and DepartmentId = '{0}'", objRelationshipEN.DepartmentId);
if (clsRelationshipBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RelationshipId !=  {0}", objRelationshipEN.RelationshipId);
 sbCondition.AppendFormat(" and PictureId = '{0}'", objRelationshipEN.PictureId);
 sbCondition.AppendFormat(" and DepartmentId = '{0}'", objRelationshipEN.DepartmentId);
if (clsRelationshipBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Relationship(关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PictureId_DepartmentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objRelationshipEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsRelationshipEN objRelationshipEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objRelationshipEN == null) return "";
if (objRelationshipEN.RelationshipId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PictureId = '{0}'", objRelationshipEN.PictureId);
 sbCondition.AppendFormat(" and DepartmentId = '{0}'", objRelationshipEN.DepartmentId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelationshipId !=  {0}", objRelationshipEN.RelationshipId);
 sbCondition.AppendFormat(" and PictureId = '{0}'", objRelationshipEN.PictureId);
 sbCondition.AppendFormat(" and DepartmentId = '{0}'", objRelationshipEN.DepartmentId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Relationship
{
public virtual bool UpdRelaTabDate(int intRelationshipId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 关系(Relationship)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRelationshipBL
{
public static RelatedActions_Relationship relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRelationshipDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRelationshipDA RelationshipDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRelationshipDA();
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
 public clsRelationshipBL()
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
if (string.IsNullOrEmpty(clsRelationshipEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRelationshipEN._ConnectString);
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
public static DataTable GetDataTable_Relationship(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RelationshipDA.GetDataTable_Relationship(strWhereCond);
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
objDT = RelationshipDA.GetDataTable(strWhereCond);
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
objDT = RelationshipDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RelationshipDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RelationshipDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RelationshipDA.GetDataTable_Top(objTopPara);
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
objDT = RelationshipDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = RelationshipDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RelationshipDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRelationshipIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsRelationshipEN> GetObjLstByRelationshipIdLst(List<int> arrRelationshipIdLst)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRelationshipIdLst);
 string strWhereCond = string.Format("RelationshipId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelationshipIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRelationshipEN> GetObjLstByRelationshipIdLstCache(List<int> arrRelationshipIdLst)
{
string strKey = string.Format("{0}", clsRelationshipEN._CurrTabName);
List<clsRelationshipEN> arrRelationshipObjLstCache = GetObjLstCache();
IEnumerable <clsRelationshipEN> arrRelationshipObjLst_Sel =
arrRelationshipObjLstCache
.Where(x => arrRelationshipIdLst.Contains(x.RelationshipId));
return arrRelationshipObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRelationshipEN> GetObjLst(string strWhereCond)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
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
public static List<clsRelationshipEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRelationshipCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRelationshipEN> GetSubObjLstCache(clsRelationshipEN objRelationshipCond)
{
List<clsRelationshipEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRelationshipEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRelationship.AttributeName)
{
if (objRelationshipCond.IsUpdated(strFldName) == false) continue;
if (objRelationshipCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRelationshipCond[strFldName].ToString());
}
else
{
if (objRelationshipCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRelationshipCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRelationshipCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRelationshipCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRelationshipCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRelationshipCond[strFldName]));
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
public static List<clsRelationshipEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
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
public static List<clsRelationshipEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
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
List<clsRelationshipEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRelationshipEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRelationshipEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRelationshipEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
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
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
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
public static List<clsRelationshipEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRelationshipEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRelationshipEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
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
public static List<clsRelationshipEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRelationshipEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRelationshipEN> arrObjLst = new List<clsRelationshipEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRelationshipEN objRelationshipEN = new clsRelationshipEN();
try
{
objRelationshipEN.RelationshipId = Int32.Parse(objRow[conRelationship.RelationshipId].ToString().Trim()); //RelationshipId
objRelationshipEN.PictureId = Int32.Parse(objRow[conRelationship.PictureId].ToString().Trim()); //PictureId
objRelationshipEN.LastModifyUserID = objRow[conRelationship.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objRelationshipEN.DepartmentId = objRow[conRelationship.DepartmentId].ToString().Trim(); //部门Id
objRelationshipEN.CreateTime = objRow[conRelationship.CreateTime].ToString().Trim(); //建立时间
objRelationshipEN.CreateUserID = objRow[conRelationship.CreateUserID].ToString().Trim(); //建立用户ID
objRelationshipEN.LastModifyTime = objRow[conRelationship.LastModifyTime].ToString().Trim(); //最后修改时间
objRelationshipEN.Memo = objRow[conRelationship.Memo] == DBNull.Value ? null : objRow[conRelationship.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRelationshipEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRelationshipEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRelationshipEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRelationship(ref clsRelationshipEN objRelationshipEN)
{
bool bolResult = RelationshipDA.GetRelationship(ref objRelationshipEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRelationshipEN GetObjByRelationshipId(int intRelationshipId)
{
clsRelationshipEN objRelationshipEN = RelationshipDA.GetObjByRelationshipId(intRelationshipId);
return objRelationshipEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRelationshipEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRelationshipEN objRelationshipEN = RelationshipDA.GetFirstObj(strWhereCond);
 return objRelationshipEN;
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
public static clsRelationshipEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRelationshipEN objRelationshipEN = RelationshipDA.GetObjByDataRow(objRow);
 return objRelationshipEN;
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
public static clsRelationshipEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRelationshipEN objRelationshipEN = RelationshipDA.GetObjByDataRow(objRow);
 return objRelationshipEN;
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
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <param name = "lstRelationshipObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRelationshipEN GetObjByRelationshipIdFromList(int intRelationshipId, List<clsRelationshipEN> lstRelationshipObjLst)
{
foreach (clsRelationshipEN objRelationshipEN in lstRelationshipObjLst)
{
if (objRelationshipEN.RelationshipId == intRelationshipId)
{
return objRelationshipEN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intRelationshipId;
 try
 {
 intRelationshipId = new clsRelationshipDA().GetFirstID(strWhereCond);
 return intRelationshipId;
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
 arrList = RelationshipDA.GetID(strWhereCond);
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
bool bolIsExist = RelationshipDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intRelationshipId)
{
//检测记录是否存在
bool bolIsExist = RelationshipDA.IsExist(intRelationshipId);
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
 bolIsExist = clsRelationshipDA.IsExistTable();
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
 bolIsExist = RelationshipDA.IsExistTable(strTabName);
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
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRelationshipEN objRelationshipEN)
{
if (objRelationshipEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PictureId = [{0}],部门Id = [{1}]的数据已经存在!(in clsRelationshipBL.AddNewRecordBySql2)", objRelationshipEN.PictureId,objRelationshipEN.DepartmentId);
throw new Exception(strMsg);
}
try
{
bool bolResult = RelationshipDA.AddNewRecordBySQL2(objRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRelationshipEN objRelationshipEN)
{
if (objRelationshipEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!PictureId = [{0}],部门Id = [{1}]的数据已经存在!(in clsRelationshipBL.AddNewRecordBySql2WithReturnKey)", objRelationshipEN.PictureId,objRelationshipEN.DepartmentId);
throw new Exception(strMsg);
}
try
{
string strKey = RelationshipDA.AddNewRecordBySQL2WithReturnKey(objRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRelationshipEN objRelationshipEN)
{
try
{
bool bolResult = RelationshipDA.Update(objRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objRelationshipEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRelationshipEN objRelationshipEN)
{
 if (objRelationshipEN.RelationshipId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RelationshipDA.UpdateBySql2(objRelationshipEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationshipBL.ReFreshCache();

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intRelationshipId)
{
try
{
 clsRelationshipEN objRelationshipEN = clsRelationshipBL.GetObjByRelationshipId(intRelationshipId);

if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(objRelationshipEN.RelationshipId, "SetUpdDate");
}
if (objRelationshipEN != null)
{
int intRecNum = RelationshipDA.DelRecord(intRelationshipId);
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
/// <param name="intRelationshipId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(int intRelationshipId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRelationshipDA.GetSpecSQLObj();
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
//删除与表:[Relationship]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRelationship.RelationshipId,
//intRelationshipId);
//        clsRelationshipBL.DelRelationshipsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRelationshipBL.DelRecord(intRelationshipId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRelationshipBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intRelationshipId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intRelationshipId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsRelationshipBL.relatedActions != null)
{
clsRelationshipBL.relatedActions.UpdRelaTabDate(intRelationshipId, "UpdRelaTabDate");
}
bool bolResult = RelationshipDA.DelRecord(intRelationshipId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRelationshipIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRelationships(List<string> arrRelationshipIdLst)
{
if (arrRelationshipIdLst.Count == 0) return 0;
try
{
if (clsRelationshipBL.relatedActions != null)
{
foreach (var strRelationshipId in arrRelationshipIdLst)
{
int intRelationshipId = int.Parse(strRelationshipId);
clsRelationshipBL.relatedActions.UpdRelaTabDate(intRelationshipId, "UpdRelaTabDate");
}
}
int intDelRecNum = RelationshipDA.DelRelationship(arrRelationshipIdLst);
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
public static int DelRelationshipsByCond(string strWhereCond)
{
try
{
if (clsRelationshipBL.relatedActions != null)
{
List<string> arrRelationshipId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRelationshipId in arrRelationshipId)
{
int intRelationshipId = int.Parse(strRelationshipId);
clsRelationshipBL.relatedActions.UpdRelaTabDate(intRelationshipId, "UpdRelaTabDate");
}
}
int intRecNum = RelationshipDA.DelRelationship(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Relationship]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intRelationshipId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intRelationshipId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRelationshipDA.GetSpecSQLObj();
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
//删除与表:[Relationship]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRelationshipBL.DelRecord(intRelationshipId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRelationshipBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intRelationshipId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objRelationshipENS">源对象</param>
 /// <param name = "objRelationshipENT">目标对象</param>
 public static void CopyTo(clsRelationshipEN objRelationshipENS, clsRelationshipEN objRelationshipENT)
{
try
{
objRelationshipENT.RelationshipId = objRelationshipENS.RelationshipId; //RelationshipId
objRelationshipENT.PictureId = objRelationshipENS.PictureId; //PictureId
objRelationshipENT.LastModifyUserID = objRelationshipENS.LastModifyUserID; //最后修改用户ID
objRelationshipENT.DepartmentId = objRelationshipENS.DepartmentId; //部门Id
objRelationshipENT.CreateTime = objRelationshipENS.CreateTime; //建立时间
objRelationshipENT.CreateUserID = objRelationshipENS.CreateUserID; //建立用户ID
objRelationshipENT.LastModifyTime = objRelationshipENS.LastModifyTime; //最后修改时间
objRelationshipENT.Memo = objRelationshipENS.Memo; //备注
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
 /// <param name = "objRelationshipEN">源简化对象</param>
 public static void SetUpdFlag(clsRelationshipEN objRelationshipEN)
{
try
{
objRelationshipEN.ClearUpdateState();
   string strsfUpdFldSetStr = objRelationshipEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRelationship.RelationshipId, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.RelationshipId = objRelationshipEN.RelationshipId; //RelationshipId
}
if (arrFldSet.Contains(conRelationship.PictureId, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.PictureId = objRelationshipEN.PictureId; //PictureId
}
if (arrFldSet.Contains(conRelationship.LastModifyUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.LastModifyUserID = objRelationshipEN.LastModifyUserID; //最后修改用户ID
}
if (arrFldSet.Contains(conRelationship.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.DepartmentId = objRelationshipEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(conRelationship.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.CreateTime = objRelationshipEN.CreateTime; //建立时间
}
if (arrFldSet.Contains(conRelationship.CreateUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.CreateUserID = objRelationshipEN.CreateUserID; //建立用户ID
}
if (arrFldSet.Contains(conRelationship.LastModifyTime, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.LastModifyTime = objRelationshipEN.LastModifyTime; //最后修改时间
}
if (arrFldSet.Contains(conRelationship.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRelationshipEN.Memo = objRelationshipEN.Memo == "[null]" ? null :  objRelationshipEN.Memo; //备注
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
 /// <param name = "objRelationshipEN">源简化对象</param>
 public static void AccessFldValueNull(clsRelationshipEN objRelationshipEN)
{
try
{
if (objRelationshipEN.Memo == "[null]") objRelationshipEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsRelationshipEN objRelationshipEN)
{
 RelationshipDA.CheckPropertyNew(objRelationshipEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRelationshipEN objRelationshipEN)
{
 RelationshipDA.CheckProperty4Condition(objRelationshipEN);
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
if (clsRelationshipBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRelationshipBL没有刷新缓存机制(clsRelationshipBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationshipId");
//if (arrRelationshipObjLstCache == null)
//{
//arrRelationshipObjLstCache = RelationshipDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRelationshipEN GetObjByRelationshipIdCache(int intRelationshipId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsRelationshipEN._CurrTabName);
List<clsRelationshipEN> arrRelationshipObjLstCache = GetObjLstCache();
IEnumerable <clsRelationshipEN> arrRelationshipObjLst_Sel =
arrRelationshipObjLstCache
.Where(x=> x.RelationshipId == intRelationshipId 
);
if (arrRelationshipObjLst_Sel.Count() == 0)
{
   clsRelationshipEN obj = clsRelationshipBL.GetObjByRelationshipId(intRelationshipId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrRelationshipObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRelationshipEN> GetAllRelationshipObjLstCache()
{
//获取缓存中的对象列表
List<clsRelationshipEN> arrRelationshipObjLstCache = GetObjLstCache(); 
return arrRelationshipObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRelationshipEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsRelationshipEN._CurrTabName);
List<clsRelationshipEN> arrRelationshipObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRelationshipObjLstCache;
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
string strKey = string.Format("{0}", clsRelationshipEN._CurrTabName);
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
if (clsRelationshipBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRelationshipEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRelationshipBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Relationship(关系)
 /// 唯一性条件:PictureId_DepartmentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRelationshipEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsRelationshipEN objRelationshipEN)
{
//检测记录是否存在
string strResult = RelationshipDA.GetUniCondStr(objRelationshipEN);
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
public static string Func(string strInFldName, string strOutFldName, int intRelationshipId)
{
if (strInFldName != conRelationship.RelationshipId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRelationship.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRelationship.AttributeName));
throw new Exception(strMsg);
}
var objRelationship = clsRelationshipBL.GetObjByRelationshipIdCache(intRelationshipId);
if (objRelationship == null) return "";
return objRelationship[strOutFldName].ToString();
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
int intRecCount = clsRelationshipDA.GetRecCount(strTabName);
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
int intRecCount = clsRelationshipDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRelationshipDA.GetRecCount();
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
int intRecCount = clsRelationshipDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRelationshipCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRelationshipEN objRelationshipCond)
{
List<clsRelationshipEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRelationshipEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRelationship.AttributeName)
{
if (objRelationshipCond.IsUpdated(strFldName) == false) continue;
if (objRelationshipCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRelationshipCond[strFldName].ToString());
}
else
{
if (objRelationshipCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRelationshipCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRelationshipCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRelationshipCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRelationshipCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRelationshipCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRelationshipCond[strFldName]));
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
 List<string> arrList = clsRelationshipDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RelationshipDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RelationshipDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RelationshipDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRelationshipDA.SetFldValue(clsRelationshipEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RelationshipDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRelationshipDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRelationshipDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRelationshipDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Relationship] "); 
 strCreateTabCode.Append(" ( "); 
 // /**RelationshipId*/ 
 strCreateTabCode.Append(" RelationshipId int primary key identity, "); 
 // /**PictureId*/ 
 strCreateTabCode.Append(" PictureId int not Null, "); 
 // /**最后修改用户ID*/ 
 strCreateTabCode.Append(" LastModifyUserID varchar(20) not Null, "); 
 // /**部门Id*/ 
 strCreateTabCode.Append(" DepartmentId varchar(8) not Null, "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreateTime varchar(16) not Null, "); 
 // /**建立用户ID*/ 
 strCreateTabCode.Append(" CreateUserID varchar(20) not Null, "); 
 // /**最后修改时间*/ 
 strCreateTabCode.Append(" LastModifyTime varchar(16) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 关系(Relationship)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Relationship : clsCommFun4BL
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
clsRelationshipBL.ReFreshThisCache();
}
}

}