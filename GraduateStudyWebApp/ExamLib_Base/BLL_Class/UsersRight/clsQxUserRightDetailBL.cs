
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRightDetailBL
 表名:QxUserRightDetail(01120178)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
public static class  clsQxUserRightDetailBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRightDetailEN GetObj(this K_mId_QxUserRightDetail myKey)
{
clsQxUserRightDetailEN objQxUserRightDetailEN = clsQxUserRightDetailBL.QxUserRightDetailDA.GetObjBymId(myKey.Value);
return objQxUserRightDetailEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserRightDetailEN objQxUserRightDetailEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxUserRightDetailEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}],关键字Id = [{2}],授权人 = [{3}]的数据已经存在!(in clsQxUserRightDetailBL.AddNewRecord)", objQxUserRightDetailEN.UserId,objQxUserRightDetailEN.RightId,objQxUserRightDetailEN.mKeyId,objQxUserRightDetailEN.Authorizer);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxUserRightDetailBL.QxUserRightDetailDA.AddNewRecordBySQL2(objQxUserRightDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
public static bool AddRecordEx(this clsQxUserRightDetailEN objQxUserRightDetailEN, bool bolIsNeedCheckUniqueness = true)
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
objQxUserRightDetailEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQxUserRightDetailEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户ID(UserId)=[{0}],权限编号(RightId)=[{1}],关键字Id(mKeyId)=[{2}],授权人(Authorizer)=[{3}])已经存在,不能重复!", objQxUserRightDetailEN.UserId, objQxUserRightDetailEN.RightId, objQxUserRightDetailEN.mKeyId, objQxUserRightDetailEN.Authorizer);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxUserRightDetailEN.AddNewRecord();
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUserRightDetailEN objQxUserRightDetailEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxUserRightDetailEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}],关键字Id = [{2}],授权人 = [{3}]的数据已经存在!(in clsQxUserRightDetailBL.AddNewRecordWithReturnKey)", objQxUserRightDetailEN.UserId,objQxUserRightDetailEN.RightId,objQxUserRightDetailEN.mKeyId,objQxUserRightDetailEN.Authorizer);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxUserRightDetailBL.QxUserRightDetailDA.AddNewRecordBySQL2WithReturnKey(objQxUserRightDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetmId(this clsQxUserRightDetailEN objQxUserRightDetailEN, long lngmId, string strComparisonOp="")
	{
objQxUserRightDetailEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.mId) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.mId, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.mId] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetUserId(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserRightDetail.UserId);
}
objQxUserRightDetailEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.UserId) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.UserId, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.UserId] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetRightId(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, conQxUserRightDetail.RightId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, conQxUserRightDetail.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, conQxUserRightDetail.RightId);
}
objQxUserRightDetailEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.RightId) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.RightId, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.RightId] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetAuthorizer(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strAuthorizer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAuthorizer, conQxUserRightDetail.Authorizer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthorizer, 18, conQxUserRightDetail.Authorizer);
}
objQxUserRightDetailEN.Authorizer = strAuthorizer; //授权人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.Authorizer) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.Authorizer, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.Authorizer] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetmKeyId(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strmKeyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmKeyId, 10, conQxUserRightDetail.mKeyId);
}
objQxUserRightDetailEN.mKeyId = strmKeyId; //关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.mKeyId) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.mKeyId, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.mKeyId] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetUpdDate(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUserRightDetail.UpdDate);
}
objQxUserRightDetailEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.UpdDate) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.UpdDate, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.UpdDate] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetUpdUser(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUserRightDetail.UpdUser);
}
objQxUserRightDetailEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.UpdUser) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.UpdUser, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.UpdUser] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightDetailEN SetMemo(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserRightDetail.Memo);
}
objQxUserRightDetailEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(conQxUserRightDetail.Memo) == false)
{
objQxUserRightDetailEN.dicFldComparisonOp.Add(conQxUserRightDetail.Memo, strComparisonOp);
}
else
{
objQxUserRightDetailEN.dicFldComparisonOp[conQxUserRightDetail.Memo] = strComparisonOp;
}
}
return objQxUserRightDetailEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUserRightDetailEN objQxUserRightDetailEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUserRightDetailEN.CheckPropertyNew();
clsQxUserRightDetailEN objQxUserRightDetailCond = new clsQxUserRightDetailEN();
string strCondition = objQxUserRightDetailCond
.SetmId(objQxUserRightDetailEN.mId, "<>")
.SetUserId(objQxUserRightDetailEN.UserId, "=")
.SetRightId(objQxUserRightDetailEN.RightId, "=")
.SetmKeyId(objQxUserRightDetailEN.mKeyId, "=")
.SetAuthorizer(objQxUserRightDetailEN.Authorizer, "=")
.GetCombineCondition();
objQxUserRightDetailEN._IsCheckProperty = true;
bool bolIsExist = clsQxUserRightDetailBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_RightId_mKeyId_Authorizer)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUserRightDetailEN.Update();
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
 /// <param name = "objQxUserRightDetail">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxUserRightDetailEN objQxUserRightDetail)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxUserRightDetailEN objQxUserRightDetailCond = new clsQxUserRightDetailEN();
string strCondition = objQxUserRightDetailCond
.SetUserId(objQxUserRightDetail.UserId, "=")
.SetRightId(objQxUserRightDetail.RightId, "=")
.SetmKeyId(objQxUserRightDetail.mKeyId, "=")
.SetAuthorizer(objQxUserRightDetail.Authorizer, "=")
.GetCombineCondition();
objQxUserRightDetail._IsCheckProperty = true;
bool bolIsExist = clsQxUserRightDetailBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxUserRightDetail.mId = clsQxUserRightDetailBL.GetFirstID_S(strCondition);
objQxUserRightDetail.UpdateWithCondition(strCondition);
}
else
{
objQxUserRightDetail.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 if (objQxUserRightDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRightDetailBL.QxUserRightDetailDA.UpdateBySql2(objQxUserRightDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRightDetailEN objQxUserRightDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserRightDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRightDetailBL.QxUserRightDetailDA.UpdateBySql2(objQxUserRightDetailEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUserRightDetailBL.QxUserRightDetailDA.UpdateBySqlWithCondition(objQxUserRightDetailEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRightDetailEN objQxUserRightDetailEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUserRightDetailBL.QxUserRightDetailDA.UpdateBySqlWithConditionTransaction(objQxUserRightDetailEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
public static int Delete(this clsQxUserRightDetailEN objQxUserRightDetailEN)
{
try
{
int intRecNum = clsQxUserRightDetailBL.QxUserRightDetailDA.DelRecord(objQxUserRightDetailEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailENS">源对象</param>
 /// <param name = "objQxUserRightDetailENT">目标对象</param>
 public static void CopyTo(this clsQxUserRightDetailEN objQxUserRightDetailENS, clsQxUserRightDetailEN objQxUserRightDetailENT)
{
try
{
objQxUserRightDetailENT.mId = objQxUserRightDetailENS.mId; //mId
objQxUserRightDetailENT.UserId = objQxUserRightDetailENS.UserId; //用户ID
objQxUserRightDetailENT.RightId = objQxUserRightDetailENS.RightId; //权限编号
objQxUserRightDetailENT.Authorizer = objQxUserRightDetailENS.Authorizer; //授权人
objQxUserRightDetailENT.mKeyId = objQxUserRightDetailENS.mKeyId; //关键字Id
objQxUserRightDetailENT.UpdDate = objQxUserRightDetailENS.UpdDate; //修改日期
objQxUserRightDetailENT.UpdUser = objQxUserRightDetailENS.UpdUser; //修改人
objQxUserRightDetailENT.Memo = objQxUserRightDetailENS.Memo; //备注
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
 /// <param name = "objQxUserRightDetailENS">源对象</param>
 /// <returns>目标对象=>clsQxUserRightDetailEN:objQxUserRightDetailENT</returns>
 public static clsQxUserRightDetailEN CopyTo(this clsQxUserRightDetailEN objQxUserRightDetailENS)
{
try
{
 clsQxUserRightDetailEN objQxUserRightDetailENT = new clsQxUserRightDetailEN()
{
mId = objQxUserRightDetailENS.mId, //mId
UserId = objQxUserRightDetailENS.UserId, //用户ID
RightId = objQxUserRightDetailENS.RightId, //权限编号
Authorizer = objQxUserRightDetailENS.Authorizer, //授权人
mKeyId = objQxUserRightDetailENS.mKeyId, //关键字Id
UpdDate = objQxUserRightDetailENS.UpdDate, //修改日期
UpdUser = objQxUserRightDetailENS.UpdUser, //修改人
Memo = objQxUserRightDetailENS.Memo, //备注
};
 return objQxUserRightDetailENT;
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
public static void CheckPropertyNew(this clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 clsQxUserRightDetailBL.QxUserRightDetailDA.CheckPropertyNew(objQxUserRightDetailEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 clsQxUserRightDetailBL.QxUserRightDetailDA.CheckProperty4Condition(objQxUserRightDetailEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserRightDetailEN objQxUserRightDetailCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.mId) == true)
{
string strComparisonOpmId = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserRightDetail.mId, objQxUserRightDetailCond.mId, strComparisonOpmId);
}
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.UserId) == true)
{
string strComparisonOpUserId = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightDetail.UserId, objQxUserRightDetailCond.UserId, strComparisonOpUserId);
}
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.RightId) == true)
{
string strComparisonOpRightId = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightDetail.RightId, objQxUserRightDetailCond.RightId, strComparisonOpRightId);
}
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.Authorizer) == true)
{
string strComparisonOpAuthorizer = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.Authorizer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightDetail.Authorizer, objQxUserRightDetailCond.Authorizer, strComparisonOpAuthorizer);
}
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.mKeyId) == true)
{
string strComparisonOpmKeyId = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.mKeyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightDetail.mKeyId, objQxUserRightDetailCond.mKeyId, strComparisonOpmKeyId);
}
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightDetail.UpdDate, objQxUserRightDetailCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightDetail.UpdUser, objQxUserRightDetailCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxUserRightDetailCond.IsUpdated(conQxUserRightDetail.Memo) == true)
{
string strComparisonOpMemo = objQxUserRightDetailCond.dicFldComparisonOp[conQxUserRightDetail.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightDetail.Memo, objQxUserRightDetailCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxUserRightDetail(用户权限详细关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_RightId_mKeyId_Authorizer
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxUserRightDetailEN objQxUserRightDetailEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxUserRightDetailEN == null) return true;
if (objQxUserRightDetailEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUserRightDetailEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objQxUserRightDetailEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightDetailEN.UserId);
}
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightDetailEN.RightId);
 if (objQxUserRightDetailEN.mKeyId == null)
{
 sbCondition.AppendFormat(" and mKeyId is null", objQxUserRightDetailEN.mKeyId);
}
else
{
 sbCondition.AppendFormat(" and mKeyId = '{0}'", objQxUserRightDetailEN.mKeyId);
}
 sbCondition.AppendFormat(" and Authorizer = '{0}'", objQxUserRightDetailEN.Authorizer);
if (clsQxUserRightDetailBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserRightDetailEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightDetailEN.UserId);
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightDetailEN.RightId);
 sbCondition.AppendFormat(" and mKeyId = '{0}'", objQxUserRightDetailEN.mKeyId);
 sbCondition.AppendFormat(" and Authorizer = '{0}'", objQxUserRightDetailEN.Authorizer);
if (clsQxUserRightDetailBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxUserRightDetail(用户权限详细关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_RightId_mKeyId_Authorizer
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxUserRightDetailEN objQxUserRightDetailEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUserRightDetailEN == null) return "";
if (objQxUserRightDetailEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUserRightDetailEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objQxUserRightDetailEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightDetailEN.UserId);
}
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightDetailEN.RightId);
 if (objQxUserRightDetailEN.mKeyId == null)
{
 sbCondition.AppendFormat(" and mKeyId is null", objQxUserRightDetailEN.mKeyId);
}
else
{
 sbCondition.AppendFormat(" and mKeyId = '{0}'", objQxUserRightDetailEN.mKeyId);
}
 sbCondition.AppendFormat(" and Authorizer = '{0}'", objQxUserRightDetailEN.Authorizer);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserRightDetailEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightDetailEN.UserId);
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightDetailEN.RightId);
 sbCondition.AppendFormat(" and mKeyId = '{0}'", objQxUserRightDetailEN.mKeyId);
 sbCondition.AppendFormat(" and Authorizer = '{0}'", objQxUserRightDetailEN.Authorizer);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUserRightDetail
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户权限详细关系(QxUserRightDetail)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRightDetailBL
{
public static RelatedActions_QxUserRightDetail relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUserRightDetailDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUserRightDetailDA QxUserRightDetailDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUserRightDetailDA();
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
 public clsQxUserRightDetailBL()
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
if (string.IsNullOrEmpty(clsQxUserRightDetailEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserRightDetailEN._ConnectString);
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
public static DataTable GetDataTable_QxUserRightDetail(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUserRightDetailDA.GetDataTable_QxUserRightDetail(strWhereCond);
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
objDT = QxUserRightDetailDA.GetDataTable(strWhereCond);
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
objDT = QxUserRightDetailDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUserRightDetailDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUserRightDetailDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUserRightDetailDA.GetDataTable_Top(objTopPara);
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
objDT = QxUserRightDetailDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUserRightDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUserRightDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsQxUserRightDetailEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
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
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUserRightDetailEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxUserRightDetailEN._CurrTabName);
List<clsQxUserRightDetailEN> arrQxUserRightDetailObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightDetailEN> arrQxUserRightDetailObjLst_Sel =
arrQxUserRightDetailObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxUserRightDetailObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRightDetailEN> GetObjLst(string strWhereCond)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
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
public static List<clsQxUserRightDetailEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUserRightDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUserRightDetailEN> GetSubObjLstCache(clsQxUserRightDetailEN objQxUserRightDetailCond)
{
List<clsQxUserRightDetailEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRightDetail.AttributeName)
{
if (objQxUserRightDetailCond.IsUpdated(strFldName) == false) continue;
if (objQxUserRightDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightDetailCond[strFldName].ToString());
}
else
{
if (objQxUserRightDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRightDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRightDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRightDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRightDetailCond[strFldName]));
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
public static List<clsQxUserRightDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
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
public static List<clsQxUserRightDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
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
List<clsQxUserRightDetailEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUserRightDetailEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRightDetailEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUserRightDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
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
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
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
public static List<clsQxUserRightDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUserRightDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUserRightDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
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
public static List<clsQxUserRightDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRightDetailEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUserRightDetailEN> arrObjLst = new List<clsQxUserRightDetailEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightDetailEN objQxUserRightDetailEN = new clsQxUserRightDetailEN();
try
{
objQxUserRightDetailEN.mId = Int32.Parse(objRow[conQxUserRightDetail.mId].ToString().Trim()); //mId
objQxUserRightDetailEN.UserId = objRow[conQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[conQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objQxUserRightDetailEN.RightId = objRow[conQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objQxUserRightDetailEN.Authorizer = objRow[conQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objQxUserRightDetailEN.mKeyId = objRow[conQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[conQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objQxUserRightDetailEN.UpdDate = objRow[conQxUserRightDetail.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objQxUserRightDetailEN.UpdUser = objRow[conQxUserRightDetail.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objQxUserRightDetailEN.Memo = objRow[conQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[conQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightDetailEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserRightDetail(ref clsQxUserRightDetailEN objQxUserRightDetailEN)
{
bool bolResult = QxUserRightDetailDA.GetQxUserRightDetail(ref objQxUserRightDetailEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRightDetailEN GetObjBymId(long lngmId)
{
clsQxUserRightDetailEN objQxUserRightDetailEN = QxUserRightDetailDA.GetObjBymId(lngmId);
return objQxUserRightDetailEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUserRightDetailEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUserRightDetailEN objQxUserRightDetailEN = QxUserRightDetailDA.GetFirstObj(strWhereCond);
 return objQxUserRightDetailEN;
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
public static clsQxUserRightDetailEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUserRightDetailEN objQxUserRightDetailEN = QxUserRightDetailDA.GetObjByDataRow(objRow);
 return objQxUserRightDetailEN;
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
public static clsQxUserRightDetailEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUserRightDetailEN objQxUserRightDetailEN = QxUserRightDetailDA.GetObjByDataRow(objRow);
 return objQxUserRightDetailEN;
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
 /// <param name = "lstQxUserRightDetailObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRightDetailEN GetObjBymIdFromList(long lngmId, List<clsQxUserRightDetailEN> lstQxUserRightDetailObjLst)
{
foreach (clsQxUserRightDetailEN objQxUserRightDetailEN in lstQxUserRightDetailObjLst)
{
if (objQxUserRightDetailEN.mId == lngmId)
{
return objQxUserRightDetailEN;
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
 lngmId = new clsQxUserRightDetailDA().GetFirstID(strWhereCond);
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
 arrList = QxUserRightDetailDA.GetID(strWhereCond);
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
bool bolIsExist = QxUserRightDetailDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxUserRightDetailDA.IsExist(lngmId);
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
clsQxUserRightDetailEN objQxUserRightDetailEN = clsQxUserRightDetailBL.GetObjBymId(lngmId);
objQxUserRightDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUserRightDetailEN.UpdUser = strOpUser;
return clsQxUserRightDetailBL.UpdateBySql2(objQxUserRightDetailEN);
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
 bolIsExist = clsQxUserRightDetailDA.IsExistTable();
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
 bolIsExist = QxUserRightDetailDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUserRightDetailEN objQxUserRightDetailEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxUserRightDetailEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}],关键字Id = [{2}],授权人 = [{3}]的数据已经存在!(in clsQxUserRightDetailBL.AddNewRecordBySql2)", objQxUserRightDetailEN.UserId,objQxUserRightDetailEN.RightId,objQxUserRightDetailEN.mKeyId,objQxUserRightDetailEN.Authorizer);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxUserRightDetailDA.AddNewRecordBySQL2(objQxUserRightDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserRightDetailEN objQxUserRightDetailEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxUserRightDetailEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}],关键字Id = [{2}],授权人 = [{3}]的数据已经存在!(in clsQxUserRightDetailBL.AddNewRecordBySql2WithReturnKey)", objQxUserRightDetailEN.UserId,objQxUserRightDetailEN.RightId,objQxUserRightDetailEN.mKeyId,objQxUserRightDetailEN.Authorizer);
throw new Exception(strMsg);
}
try
{
string strKey = QxUserRightDetailDA.AddNewRecordBySQL2WithReturnKey(objQxUserRightDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
try
{
bool bolResult = QxUserRightDetailDA.Update(objQxUserRightDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 /// <param name = "objQxUserRightDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 if (objQxUserRightDetailEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUserRightDetailDA.UpdateBySql2(objQxUserRightDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightDetailBL.ReFreshCache();

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
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
 clsQxUserRightDetailEN objQxUserRightDetailEN = clsQxUserRightDetailBL.GetObjBymId(lngmId);

if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(objQxUserRightDetailEN.mId, objQxUserRightDetailEN.UpdUser);
}
if (objQxUserRightDetailEN != null)
{
int intRecNum = QxUserRightDetailDA.DelRecord(lngmId);
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
objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
//删除与表:[QxUserRightDetail]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUserRightDetail.mId,
//lngmId);
//        clsQxUserRightDetailBL.DelQxUserRightDetailsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRightDetailBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRightDetailBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQxUserRightDetailBL.relatedActions != null)
{
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUserRightDetailDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelQxUserRightDetails(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxUserRightDetailBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUserRightDetailDA.DelQxUserRightDetail(arrmIdLst);
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
public static int DelQxUserRightDetailsByCond(string strWhereCond)
{
try
{
if (clsQxUserRightDetailBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxUserRightDetailBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxUserRightDetailDA.DelQxUserRightDetail(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUserRightDetail]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserRightDetailDA.GetSpecSQLObj();
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
//删除与表:[QxUserRightDetail]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRightDetailBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRightDetailBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQxUserRightDetailENS">源对象</param>
 /// <param name = "objQxUserRightDetailENT">目标对象</param>
 public static void CopyTo(clsQxUserRightDetailEN objQxUserRightDetailENS, clsQxUserRightDetailEN objQxUserRightDetailENT)
{
try
{
objQxUserRightDetailENT.mId = objQxUserRightDetailENS.mId; //mId
objQxUserRightDetailENT.UserId = objQxUserRightDetailENS.UserId; //用户ID
objQxUserRightDetailENT.RightId = objQxUserRightDetailENS.RightId; //权限编号
objQxUserRightDetailENT.Authorizer = objQxUserRightDetailENS.Authorizer; //授权人
objQxUserRightDetailENT.mKeyId = objQxUserRightDetailENS.mKeyId; //关键字Id
objQxUserRightDetailENT.UpdDate = objQxUserRightDetailENS.UpdDate; //修改日期
objQxUserRightDetailENT.UpdUser = objQxUserRightDetailENS.UpdUser; //修改人
objQxUserRightDetailENT.Memo = objQxUserRightDetailENS.Memo; //备注
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
 /// <param name = "objQxUserRightDetailEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
try
{
objQxUserRightDetailEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUserRightDetailEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUserRightDetail.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.mId = objQxUserRightDetailEN.mId; //mId
}
if (arrFldSet.Contains(conQxUserRightDetail.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.UserId = objQxUserRightDetailEN.UserId == "[null]" ? null :  objQxUserRightDetailEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUserRightDetail.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.RightId = objQxUserRightDetailEN.RightId; //权限编号
}
if (arrFldSet.Contains(conQxUserRightDetail.Authorizer, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.Authorizer = objQxUserRightDetailEN.Authorizer; //授权人
}
if (arrFldSet.Contains(conQxUserRightDetail.mKeyId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.mKeyId = objQxUserRightDetailEN.mKeyId == "[null]" ? null :  objQxUserRightDetailEN.mKeyId; //关键字Id
}
if (arrFldSet.Contains(conQxUserRightDetail.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.UpdDate = objQxUserRightDetailEN.UpdDate == "[null]" ? null :  objQxUserRightDetailEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUserRightDetail.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.UpdUser = objQxUserRightDetailEN.UpdUser == "[null]" ? null :  objQxUserRightDetailEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQxUserRightDetail.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightDetailEN.Memo = objQxUserRightDetailEN.Memo == "[null]" ? null :  objQxUserRightDetailEN.Memo; //备注
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
 /// <param name = "objQxUserRightDetailEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
try
{
if (objQxUserRightDetailEN.UserId == "[null]") objQxUserRightDetailEN.UserId = null; //用户ID
if (objQxUserRightDetailEN.mKeyId == "[null]") objQxUserRightDetailEN.mKeyId = null; //关键字Id
if (objQxUserRightDetailEN.UpdDate == "[null]") objQxUserRightDetailEN.UpdDate = null; //修改日期
if (objQxUserRightDetailEN.UpdUser == "[null]") objQxUserRightDetailEN.UpdUser = null; //修改人
if (objQxUserRightDetailEN.Memo == "[null]") objQxUserRightDetailEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 QxUserRightDetailDA.CheckPropertyNew(objQxUserRightDetailEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
 QxUserRightDetailDA.CheckProperty4Condition(objQxUserRightDetailEN);
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
if (clsQxUserRightDetailBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRightDetailBL没有刷新缓存机制(clsQxUserRightDetailBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxUserRightDetailObjLstCache == null)
//{
//arrQxUserRightDetailObjLstCache = QxUserRightDetailDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRightDetailEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUserRightDetailEN._CurrTabName);
List<clsQxUserRightDetailEN> arrQxUserRightDetailObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightDetailEN> arrQxUserRightDetailObjLst_Sel =
arrQxUserRightDetailObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxUserRightDetailObjLst_Sel.Count() == 0)
{
   clsQxUserRightDetailEN obj = clsQxUserRightDetailBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUserRightDetailObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRightDetailEN> GetAllQxUserRightDetailObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUserRightDetailEN> arrQxUserRightDetailObjLstCache = GetObjLstCache(); 
return arrQxUserRightDetailObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRightDetailEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUserRightDetailEN._CurrTabName);
List<clsQxUserRightDetailEN> arrQxUserRightDetailObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserRightDetailObjLstCache;
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
string strKey = string.Format("{0}", clsQxUserRightDetailEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserRightDetailEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQxUserRightDetailEN._RefreshTimeLst.Count == 0) return "";
return clsQxUserRightDetailEN._RefreshTimeLst[clsQxUserRightDetailEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQxUserRightDetailBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserRightDetailEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserRightDetailEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQxUserRightDetailBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxUserRightDetail(用户权限详细关系)
 /// 唯一性条件:UserId_RightId_mKeyId_Authorizer
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserRightDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxUserRightDetailEN objQxUserRightDetailEN)
{
//检测记录是否存在
string strResult = QxUserRightDetailDA.GetUniCondStr(objQxUserRightDetailEN);
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
if (strInFldName != conQxUserRightDetail.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUserRightDetail.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUserRightDetail.AttributeName));
throw new Exception(strMsg);
}
var objQxUserRightDetail = clsQxUserRightDetailBL.GetObjBymIdCache(lngmId);
if (objQxUserRightDetail == null) return "";
return objQxUserRightDetail[strOutFldName].ToString();
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
int intRecCount = clsQxUserRightDetailDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUserRightDetailDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUserRightDetailDA.GetRecCount();
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
int intRecCount = clsQxUserRightDetailDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUserRightDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUserRightDetailEN objQxUserRightDetailCond)
{
List<clsQxUserRightDetailEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRightDetail.AttributeName)
{
if (objQxUserRightDetailCond.IsUpdated(strFldName) == false) continue;
if (objQxUserRightDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightDetailCond[strFldName].ToString());
}
else
{
if (objQxUserRightDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRightDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRightDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRightDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRightDetailCond[strFldName]));
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
 List<string> arrList = clsQxUserRightDetailDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUserRightDetailDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUserRightDetailDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUserRightDetailDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRightDetailDA.SetFldValue(clsQxUserRightDetailEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUserRightDetailDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRightDetailDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRightDetailDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRightDetailDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUserRightDetail] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**权限编号*/ 
 strCreateTabCode.Append(" RightId char(8) not Null, "); 
 // /**授权人*/ 
 strCreateTabCode.Append(" Authorizer varchar(18) not Null, "); 
 // /**关键字Id*/ 
 strCreateTabCode.Append(" mKeyId varchar(10) Null, "); 
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
 /// 用户权限详细关系(QxUserRightDetail)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUserRightDetail : clsCommFun4BL
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
clsQxUserRightDetailBL.ReFreshThisCache();
}
}

}