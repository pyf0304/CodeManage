
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGroupPicRelationBL
 表名:GroupPicRelation(01120036)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:16
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
public static class  clsGroupPicRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGroupPicRelationEN GetObj(this K_RelationshipId_GroupPicRelation myKey)
{
clsGroupPicRelationEN objGroupPicRelationEN = clsGroupPicRelationBL.GroupPicRelationDA.GetObjByRelationshipId(myKey.Value);
return objGroupPicRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGroupPicRelationEN objGroupPicRelationEN)
{
if (CheckUniqueness(objGroupPicRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!组Id = [{0}],PictureId = [{1}]的数据已经存在!(in clsGroupPicRelationBL.AddNewRecord)", objGroupPicRelationEN.GroupId,objGroupPicRelationEN.PictureId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsGroupPicRelationBL.GroupPicRelationDA.AddNewRecordBySQL2(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
public static bool AddRecordEx(this clsGroupPicRelationEN objGroupPicRelationEN)
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
objGroupPicRelationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objGroupPicRelationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(组Id(GroupId)=[{0}],PictureId(PictureId)=[{1}])已经存在,不能重复!", objGroupPicRelationEN.GroupId, objGroupPicRelationEN.PictureId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objGroupPicRelationEN.AddNewRecord();
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGroupPicRelationEN objGroupPicRelationEN)
{
if (CheckUniqueness(objGroupPicRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!组Id = [{0}],PictureId = [{1}]的数据已经存在!(in clsGroupPicRelationBL.AddNewRecordWithReturnKey)", objGroupPicRelationEN.GroupId,objGroupPicRelationEN.PictureId);
throw new Exception(strMsg);
}
try
{
string strKey = clsGroupPicRelationBL.GroupPicRelationDA.AddNewRecordBySQL2WithReturnKey(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetRelationshipId(this clsGroupPicRelationEN objGroupPicRelationEN, int intRelationshipId, string strComparisonOp="")
	{
objGroupPicRelationEN.RelationshipId = intRelationshipId; //RelationshipId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.RelationshipId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.RelationshipId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.RelationshipId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetGroupId(this clsGroupPicRelationEN objGroupPicRelationEN, string strGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupId, 8, conGroupPicRelation.GroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupId, 8, conGroupPicRelation.GroupId);
}
objGroupPicRelationEN.GroupId = strGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.GroupId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.GroupId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.GroupId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetPictureId(this clsGroupPicRelationEN objGroupPicRelationEN, int? intPictureId, string strComparisonOp="")
	{
objGroupPicRelationEN.PictureId = intPictureId; //PictureId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.PictureId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.PictureId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.PictureId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetCreateTime(this clsGroupPicRelationEN objGroupPicRelationEN, string strCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateTime, 16, conGroupPicRelation.CreateTime);
}
objGroupPicRelationEN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.CreateTime) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.CreateTime, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.CreateTime] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetCreateUserID(this clsGroupPicRelationEN objGroupPicRelationEN, string strCreateUserID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, conGroupPicRelation.CreateUserID);
}
objGroupPicRelationEN.CreateUserID = strCreateUserID; //建立用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.CreateUserID) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.CreateUserID, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.CreateUserID] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetLastModifyUserID(this clsGroupPicRelationEN objGroupPicRelationEN, string strLastModifyUserID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastModifyUserID, 20, conGroupPicRelation.LastModifyUserID);
}
objGroupPicRelationEN.LastModifyUserID = strLastModifyUserID; //最后修改用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.LastModifyUserID) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.LastModifyUserID, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.LastModifyUserID] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetLastModifyTime(this clsGroupPicRelationEN objGroupPicRelationEN, string strLastModifyTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastModifyTime, 16, conGroupPicRelation.LastModifyTime);
}
objGroupPicRelationEN.LastModifyTime = strLastModifyTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.LastModifyTime) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.LastModifyTime, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.LastModifyTime] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetPictureConfigerId(this clsGroupPicRelationEN objGroupPicRelationEN, string strPictureConfigerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, conGroupPicRelation.PictureConfigerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, conGroupPicRelation.PictureConfigerId);
}
objGroupPicRelationEN.PictureConfigerId = strPictureConfigerId; //PictureConfigerId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.PictureConfigerId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.PictureConfigerId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.PictureConfigerId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGroupPicRelationEN SetMemo(this clsGroupPicRelationEN objGroupPicRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGroupPicRelation.Memo);
}
objGroupPicRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.Memo) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.Memo, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.Memo] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGroupPicRelationEN objGroupPicRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGroupPicRelationEN.CheckPropertyNew();
clsGroupPicRelationEN objGroupPicRelationCond = new clsGroupPicRelationEN();
string strCondition = objGroupPicRelationCond
.SetRelationshipId(objGroupPicRelationEN.RelationshipId, "<>")
.SetGroupId(objGroupPicRelationEN.GroupId, "=")
.SetPictureId(objGroupPicRelationEN.PictureId, "=")
.GetCombineCondition();
objGroupPicRelationEN._IsCheckProperty = true;
bool bolIsExist = clsGroupPicRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(GroupId_PictureId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGroupPicRelationEN.Update();
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
 /// <param name = "objGroupPicRelation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGroupPicRelationEN objGroupPicRelation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGroupPicRelationEN objGroupPicRelationCond = new clsGroupPicRelationEN();
string strCondition = objGroupPicRelationCond
.SetGroupId(objGroupPicRelation.GroupId, "=")
.SetPictureId(objGroupPicRelation.PictureId, "=")
.GetCombineCondition();
objGroupPicRelation._IsCheckProperty = true;
bool bolIsExist = clsGroupPicRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGroupPicRelation.RelationshipId = clsGroupPicRelationBL.GetFirstID_S(strCondition);
objGroupPicRelation.UpdateWithCondition(strCondition);
}
else
{
objGroupPicRelation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGroupPicRelationEN objGroupPicRelationEN)
{
 if (objGroupPicRelationEN.RelationshipId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGroupPicRelationBL.GroupPicRelationDA.UpdateBySql2(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGroupPicRelationEN objGroupPicRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objGroupPicRelationEN.RelationshipId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGroupPicRelationBL.GroupPicRelationDA.UpdateBySql2(objGroupPicRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGroupPicRelationEN objGroupPicRelationEN, string strWhereCond)
{
try
{
bool bolResult = clsGroupPicRelationBL.GroupPicRelationDA.UpdateBySqlWithCondition(objGroupPicRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGroupPicRelationEN objGroupPicRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGroupPicRelationBL.GroupPicRelationDA.UpdateBySqlWithConditionTransaction(objGroupPicRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
public static int Delete(this clsGroupPicRelationEN objGroupPicRelationEN)
{
try
{
int intRecNum = clsGroupPicRelationBL.GroupPicRelationDA.DelRecord(objGroupPicRelationEN.RelationshipId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationENS">源对象</param>
 /// <param name = "objGroupPicRelationENT">目标对象</param>
 public static void CopyTo(this clsGroupPicRelationEN objGroupPicRelationENS, clsGroupPicRelationEN objGroupPicRelationENT)
{
try
{
objGroupPicRelationENT.RelationshipId = objGroupPicRelationENS.RelationshipId; //RelationshipId
objGroupPicRelationENT.GroupId = objGroupPicRelationENS.GroupId; //组Id
objGroupPicRelationENT.PictureId = objGroupPicRelationENS.PictureId; //PictureId
objGroupPicRelationENT.CreateTime = objGroupPicRelationENS.CreateTime; //建立时间
objGroupPicRelationENT.CreateUserID = objGroupPicRelationENS.CreateUserID; //建立用户ID
objGroupPicRelationENT.LastModifyUserID = objGroupPicRelationENS.LastModifyUserID; //最后修改用户ID
objGroupPicRelationENT.LastModifyTime = objGroupPicRelationENS.LastModifyTime; //最后修改时间
objGroupPicRelationENT.PictureConfigerId = objGroupPicRelationENS.PictureConfigerId; //PictureConfigerId
objGroupPicRelationENT.Memo = objGroupPicRelationENS.Memo; //备注
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
 /// <param name = "objGroupPicRelationENS">源对象</param>
 /// <returns>目标对象=>clsGroupPicRelationEN:objGroupPicRelationENT</returns>
 public static clsGroupPicRelationEN CopyTo(this clsGroupPicRelationEN objGroupPicRelationENS)
{
try
{
 clsGroupPicRelationEN objGroupPicRelationENT = new clsGroupPicRelationEN()
{
RelationshipId = objGroupPicRelationENS.RelationshipId, //RelationshipId
GroupId = objGroupPicRelationENS.GroupId, //组Id
PictureId = objGroupPicRelationENS.PictureId, //PictureId
CreateTime = objGroupPicRelationENS.CreateTime, //建立时间
CreateUserID = objGroupPicRelationENS.CreateUserID, //建立用户ID
LastModifyUserID = objGroupPicRelationENS.LastModifyUserID, //最后修改用户ID
LastModifyTime = objGroupPicRelationENS.LastModifyTime, //最后修改时间
PictureConfigerId = objGroupPicRelationENS.PictureConfigerId, //PictureConfigerId
Memo = objGroupPicRelationENS.Memo, //备注
};
 return objGroupPicRelationENT;
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
public static void CheckPropertyNew(this clsGroupPicRelationEN objGroupPicRelationEN)
{
 clsGroupPicRelationBL.GroupPicRelationDA.CheckPropertyNew(objGroupPicRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGroupPicRelationEN objGroupPicRelationEN)
{
 clsGroupPicRelationBL.GroupPicRelationDA.CheckProperty4Condition(objGroupPicRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGroupPicRelationEN objGroupPicRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.RelationshipId) == true)
{
string strComparisonOpRelationshipId = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.RelationshipId];
strWhereCond += string.Format(" And {0} {2} {1}", conGroupPicRelation.RelationshipId, objGroupPicRelationCond.RelationshipId, strComparisonOpRelationshipId);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.GroupId) == true)
{
string strComparisonOpGroupId = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.GroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.GroupId, objGroupPicRelationCond.GroupId, strComparisonOpGroupId);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.PictureId) == true)
{
string strComparisonOpPictureId = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.PictureId];
strWhereCond += string.Format(" And {0} {2} {1}", conGroupPicRelation.PictureId, objGroupPicRelationCond.PictureId, strComparisonOpPictureId);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.CreateTime) == true)
{
string strComparisonOpCreateTime = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.CreateTime, objGroupPicRelationCond.CreateTime, strComparisonOpCreateTime);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.CreateUserID) == true)
{
string strComparisonOpCreateUserID = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.CreateUserID, objGroupPicRelationCond.CreateUserID, strComparisonOpCreateUserID);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.LastModifyUserID) == true)
{
string strComparisonOpLastModifyUserID = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.LastModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.LastModifyUserID, objGroupPicRelationCond.LastModifyUserID, strComparisonOpLastModifyUserID);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.LastModifyTime) == true)
{
string strComparisonOpLastModifyTime = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.LastModifyTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.LastModifyTime, objGroupPicRelationCond.LastModifyTime, strComparisonOpLastModifyTime);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.PictureConfigerId) == true)
{
string strComparisonOpPictureConfigerId = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.PictureConfigerId, objGroupPicRelationCond.PictureConfigerId, strComparisonOpPictureConfigerId);
}
if (objGroupPicRelationCond.IsUpdated(conGroupPicRelation.Memo) == true)
{
string strComparisonOpMemo = objGroupPicRelationCond.dicFldComparisonOp[conGroupPicRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.Memo, objGroupPicRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GroupPicRelation(用户组图片关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:GroupId_PictureId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGroupPicRelationEN objGroupPicRelationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGroupPicRelationEN == null) return true;
if (objGroupPicRelationEN.RelationshipId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objGroupPicRelationEN.GroupId == null)
{
 sbCondition.AppendFormat(" and GroupId is null", objGroupPicRelationEN.GroupId);
}
else
{
 sbCondition.AppendFormat(" and GroupId = '{0}'", objGroupPicRelationEN.GroupId);
}
 if (objGroupPicRelationEN.PictureId == null)
{
 sbCondition.AppendFormat(" and PictureId is null", objGroupPicRelationEN.PictureId);
}
else
{
 sbCondition.AppendFormat(" and PictureId = '{0}'", objGroupPicRelationEN.PictureId);
}
if (clsGroupPicRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RelationshipId !=  {0}", objGroupPicRelationEN.RelationshipId);
 sbCondition.AppendFormat(" and GroupId = '{0}'", objGroupPicRelationEN.GroupId);
 sbCondition.AppendFormat(" and PictureId = '{0}'", objGroupPicRelationEN.PictureId);
if (clsGroupPicRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GroupPicRelation(用户组图片关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:GroupId_PictureId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGroupPicRelationEN objGroupPicRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGroupPicRelationEN == null) return "";
if (objGroupPicRelationEN.RelationshipId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objGroupPicRelationEN.GroupId == null)
{
 sbCondition.AppendFormat(" and GroupId is null", objGroupPicRelationEN.GroupId);
}
else
{
 sbCondition.AppendFormat(" and GroupId = '{0}'", objGroupPicRelationEN.GroupId);
}
 if (objGroupPicRelationEN.PictureId == null)
{
 sbCondition.AppendFormat(" and PictureId is null", objGroupPicRelationEN.PictureId);
}
else
{
 sbCondition.AppendFormat(" and PictureId = '{0}'", objGroupPicRelationEN.PictureId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelationshipId !=  {0}", objGroupPicRelationEN.RelationshipId);
 sbCondition.AppendFormat(" and GroupId = '{0}'", objGroupPicRelationEN.GroupId);
 sbCondition.AppendFormat(" and PictureId = '{0}'", objGroupPicRelationEN.PictureId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GroupPicRelation
{
public virtual bool UpdRelaTabDate(int intRelationshipId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户组图片关系(GroupPicRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGroupPicRelationBL
{
public static RelatedActions_GroupPicRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGroupPicRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGroupPicRelationDA GroupPicRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGroupPicRelationDA();
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
 public clsGroupPicRelationBL()
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
if (string.IsNullOrEmpty(clsGroupPicRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGroupPicRelationEN._ConnectString);
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
public static DataTable GetDataTable_GroupPicRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GroupPicRelationDA.GetDataTable_GroupPicRelation(strWhereCond);
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
objDT = GroupPicRelationDA.GetDataTable(strWhereCond);
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
objDT = GroupPicRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GroupPicRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GroupPicRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GroupPicRelationDA.GetDataTable_Top(objTopPara);
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
objDT = GroupPicRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GroupPicRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GroupPicRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsGroupPicRelationEN> GetObjLstByRelationshipIdLst(List<int> arrRelationshipIdLst)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
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
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelationshipIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGroupPicRelationEN> GetObjLstByRelationshipIdLstCache(List<int> arrRelationshipIdLst)
{
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName);
List<clsGroupPicRelationEN> arrGroupPicRelationObjLstCache = GetObjLstCache();
IEnumerable <clsGroupPicRelationEN> arrGroupPicRelationObjLst_Sel =
arrGroupPicRelationObjLstCache
.Where(x => arrRelationshipIdLst.Contains(x.RelationshipId));
return arrGroupPicRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGroupPicRelationEN> GetObjLst(string strWhereCond)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
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
public static List<clsGroupPicRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGroupPicRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGroupPicRelationEN> GetSubObjLstCache(clsGroupPicRelationEN objGroupPicRelationCond)
{
List<clsGroupPicRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGroupPicRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGroupPicRelation.AttributeName)
{
if (objGroupPicRelationCond.IsUpdated(strFldName) == false) continue;
if (objGroupPicRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGroupPicRelationCond[strFldName].ToString());
}
else
{
if (objGroupPicRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGroupPicRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGroupPicRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGroupPicRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGroupPicRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGroupPicRelationCond[strFldName]));
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
public static List<clsGroupPicRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
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
public static List<clsGroupPicRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
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
List<clsGroupPicRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGroupPicRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGroupPicRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGroupPicRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
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
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
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
public static List<clsGroupPicRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGroupPicRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGroupPicRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
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
public static List<clsGroupPicRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGroupPicRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGroupPicRelationEN> arrObjLst = new List<clsGroupPicRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGroupPicRelationEN objGroupPicRelationEN = new clsGroupPicRelationEN();
try
{
objGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[conGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objGroupPicRelationEN.GroupId = objRow[conGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[conGroupPicRelation.GroupId].ToString().Trim(); //组Id
objGroupPicRelationEN.PictureId = objRow[conGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objGroupPicRelationEN.CreateTime = objRow[conGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objGroupPicRelationEN.CreateUserID = objRow[conGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objGroupPicRelationEN.LastModifyUserID = objRow[conGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objGroupPicRelationEN.LastModifyTime = objRow[conGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[conGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objGroupPicRelationEN.PictureConfigerId = objRow[conGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[conGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objGroupPicRelationEN.Memo = objRow[conGroupPicRelation.Memo] == DBNull.Value ? null : objRow[conGroupPicRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGroupPicRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGroupPicRelation(ref clsGroupPicRelationEN objGroupPicRelationEN)
{
bool bolResult = GroupPicRelationDA.GetGroupPicRelation(ref objGroupPicRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGroupPicRelationEN GetObjByRelationshipId(int intRelationshipId)
{
clsGroupPicRelationEN objGroupPicRelationEN = GroupPicRelationDA.GetObjByRelationshipId(intRelationshipId);
return objGroupPicRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGroupPicRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGroupPicRelationEN objGroupPicRelationEN = GroupPicRelationDA.GetFirstObj(strWhereCond);
 return objGroupPicRelationEN;
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
public static clsGroupPicRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGroupPicRelationEN objGroupPicRelationEN = GroupPicRelationDA.GetObjByDataRow(objRow);
 return objGroupPicRelationEN;
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
public static clsGroupPicRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGroupPicRelationEN objGroupPicRelationEN = GroupPicRelationDA.GetObjByDataRow(objRow);
 return objGroupPicRelationEN;
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
 /// <param name = "lstGroupPicRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGroupPicRelationEN GetObjByRelationshipIdFromList(int intRelationshipId, List<clsGroupPicRelationEN> lstGroupPicRelationObjLst)
{
foreach (clsGroupPicRelationEN objGroupPicRelationEN in lstGroupPicRelationObjLst)
{
if (objGroupPicRelationEN.RelationshipId == intRelationshipId)
{
return objGroupPicRelationEN;
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
 intRelationshipId = new clsGroupPicRelationDA().GetFirstID(strWhereCond);
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
 arrList = GroupPicRelationDA.GetID(strWhereCond);
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
bool bolIsExist = GroupPicRelationDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = GroupPicRelationDA.IsExist(intRelationshipId);
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
 bolIsExist = clsGroupPicRelationDA.IsExistTable();
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
 bolIsExist = GroupPicRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGroupPicRelationEN objGroupPicRelationEN)
{
if (objGroupPicRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!组Id = [{0}],PictureId = [{1}]的数据已经存在!(in clsGroupPicRelationBL.AddNewRecordBySql2)", objGroupPicRelationEN.GroupId,objGroupPicRelationEN.PictureId);
throw new Exception(strMsg);
}
try
{
bool bolResult = GroupPicRelationDA.AddNewRecordBySQL2(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGroupPicRelationEN objGroupPicRelationEN)
{
if (objGroupPicRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!组Id = [{0}],PictureId = [{1}]的数据已经存在!(in clsGroupPicRelationBL.AddNewRecordBySql2WithReturnKey)", objGroupPicRelationEN.GroupId,objGroupPicRelationEN.PictureId);
throw new Exception(strMsg);
}
try
{
string strKey = GroupPicRelationDA.AddNewRecordBySQL2WithReturnKey(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGroupPicRelationEN objGroupPicRelationEN)
{
try
{
bool bolResult = GroupPicRelationDA.Update(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGroupPicRelationEN objGroupPicRelationEN)
{
 if (objGroupPicRelationEN.RelationshipId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GroupPicRelationDA.UpdateBySql2(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationBL.ReFreshCache();

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
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
 clsGroupPicRelationEN objGroupPicRelationEN = clsGroupPicRelationBL.GetObjByRelationshipId(intRelationshipId);

if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(objGroupPicRelationEN.RelationshipId, "SetUpdDate");
}
if (objGroupPicRelationEN != null)
{
int intRecNum = GroupPicRelationDA.DelRecord(intRelationshipId);
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
objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
//删除与表:[GroupPicRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGroupPicRelation.RelationshipId,
//intRelationshipId);
//        clsGroupPicRelationBL.DelGroupPicRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGroupPicRelationBL.DelRecord(intRelationshipId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGroupPicRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsGroupPicRelationBL.relatedActions != null)
{
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(intRelationshipId, "UpdRelaTabDate");
}
bool bolResult = GroupPicRelationDA.DelRecord(intRelationshipId,objSqlConnection,objSqlTransaction);
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
public static int DelGroupPicRelations(List<string> arrRelationshipIdLst)
{
if (arrRelationshipIdLst.Count == 0) return 0;
try
{
if (clsGroupPicRelationBL.relatedActions != null)
{
foreach (var strRelationshipId in arrRelationshipIdLst)
{
int intRelationshipId = int.Parse(strRelationshipId);
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(intRelationshipId, "UpdRelaTabDate");
}
}
int intDelRecNum = GroupPicRelationDA.DelGroupPicRelation(arrRelationshipIdLst);
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
public static int DelGroupPicRelationsByCond(string strWhereCond)
{
try
{
if (clsGroupPicRelationBL.relatedActions != null)
{
List<string> arrRelationshipId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRelationshipId in arrRelationshipId)
{
int intRelationshipId = int.Parse(strRelationshipId);
clsGroupPicRelationBL.relatedActions.UpdRelaTabDate(intRelationshipId, "UpdRelaTabDate");
}
}
int intRecNum = GroupPicRelationDA.DelGroupPicRelation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GroupPicRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intRelationshipId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intRelationshipId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGroupPicRelationDA.GetSpecSQLObj();
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
//删除与表:[GroupPicRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGroupPicRelationBL.DelRecord(intRelationshipId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGroupPicRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objGroupPicRelationENS">源对象</param>
 /// <param name = "objGroupPicRelationENT">目标对象</param>
 public static void CopyTo(clsGroupPicRelationEN objGroupPicRelationENS, clsGroupPicRelationEN objGroupPicRelationENT)
{
try
{
objGroupPicRelationENT.RelationshipId = objGroupPicRelationENS.RelationshipId; //RelationshipId
objGroupPicRelationENT.GroupId = objGroupPicRelationENS.GroupId; //组Id
objGroupPicRelationENT.PictureId = objGroupPicRelationENS.PictureId; //PictureId
objGroupPicRelationENT.CreateTime = objGroupPicRelationENS.CreateTime; //建立时间
objGroupPicRelationENT.CreateUserID = objGroupPicRelationENS.CreateUserID; //建立用户ID
objGroupPicRelationENT.LastModifyUserID = objGroupPicRelationENS.LastModifyUserID; //最后修改用户ID
objGroupPicRelationENT.LastModifyTime = objGroupPicRelationENS.LastModifyTime; //最后修改时间
objGroupPicRelationENT.PictureConfigerId = objGroupPicRelationENS.PictureConfigerId; //PictureConfigerId
objGroupPicRelationENT.Memo = objGroupPicRelationENS.Memo; //备注
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
 /// <param name = "objGroupPicRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsGroupPicRelationEN objGroupPicRelationEN)
{
try
{
objGroupPicRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGroupPicRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGroupPicRelation.RelationshipId, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.RelationshipId = objGroupPicRelationEN.RelationshipId; //RelationshipId
}
if (arrFldSet.Contains(conGroupPicRelation.GroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.GroupId = objGroupPicRelationEN.GroupId == "[null]" ? null :  objGroupPicRelationEN.GroupId; //组Id
}
if (arrFldSet.Contains(conGroupPicRelation.PictureId, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.PictureId = objGroupPicRelationEN.PictureId; //PictureId
}
if (arrFldSet.Contains(conGroupPicRelation.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.CreateTime = objGroupPicRelationEN.CreateTime == "[null]" ? null :  objGroupPicRelationEN.CreateTime; //建立时间
}
if (arrFldSet.Contains(conGroupPicRelation.CreateUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.CreateUserID = objGroupPicRelationEN.CreateUserID == "[null]" ? null :  objGroupPicRelationEN.CreateUserID; //建立用户ID
}
if (arrFldSet.Contains(conGroupPicRelation.LastModifyUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.LastModifyUserID = objGroupPicRelationEN.LastModifyUserID == "[null]" ? null :  objGroupPicRelationEN.LastModifyUserID; //最后修改用户ID
}
if (arrFldSet.Contains(conGroupPicRelation.LastModifyTime, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.LastModifyTime = objGroupPicRelationEN.LastModifyTime == "[null]" ? null :  objGroupPicRelationEN.LastModifyTime; //最后修改时间
}
if (arrFldSet.Contains(conGroupPicRelation.PictureConfigerId, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.PictureConfigerId = objGroupPicRelationEN.PictureConfigerId == "[null]" ? null :  objGroupPicRelationEN.PictureConfigerId; //PictureConfigerId
}
if (arrFldSet.Contains(conGroupPicRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGroupPicRelationEN.Memo = objGroupPicRelationEN.Memo == "[null]" ? null :  objGroupPicRelationEN.Memo; //备注
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
 /// <param name = "objGroupPicRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsGroupPicRelationEN objGroupPicRelationEN)
{
try
{
if (objGroupPicRelationEN.GroupId == "[null]") objGroupPicRelationEN.GroupId = null; //组Id
if (objGroupPicRelationEN.CreateTime == "[null]") objGroupPicRelationEN.CreateTime = null; //建立时间
if (objGroupPicRelationEN.CreateUserID == "[null]") objGroupPicRelationEN.CreateUserID = null; //建立用户ID
if (objGroupPicRelationEN.LastModifyUserID == "[null]") objGroupPicRelationEN.LastModifyUserID = null; //最后修改用户ID
if (objGroupPicRelationEN.LastModifyTime == "[null]") objGroupPicRelationEN.LastModifyTime = null; //最后修改时间
if (objGroupPicRelationEN.PictureConfigerId == "[null]") objGroupPicRelationEN.PictureConfigerId = null; //PictureConfigerId
if (objGroupPicRelationEN.Memo == "[null]") objGroupPicRelationEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsGroupPicRelationEN objGroupPicRelationEN)
{
 GroupPicRelationDA.CheckPropertyNew(objGroupPicRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGroupPicRelationEN objGroupPicRelationEN)
{
 GroupPicRelationDA.CheckProperty4Condition(objGroupPicRelationEN);
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
if (clsGroupPicRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGroupPicRelationBL没有刷新缓存机制(clsGroupPicRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationshipId");
//if (arrGroupPicRelationObjLstCache == null)
//{
//arrGroupPicRelationObjLstCache = GroupPicRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGroupPicRelationEN GetObjByRelationshipIdCache(int intRelationshipId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName);
List<clsGroupPicRelationEN> arrGroupPicRelationObjLstCache = GetObjLstCache();
IEnumerable <clsGroupPicRelationEN> arrGroupPicRelationObjLst_Sel =
arrGroupPicRelationObjLstCache
.Where(x=> x.RelationshipId == intRelationshipId 
);
if (arrGroupPicRelationObjLst_Sel.Count() == 0)
{
   clsGroupPicRelationEN obj = clsGroupPicRelationBL.GetObjByRelationshipId(intRelationshipId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGroupPicRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGroupPicRelationEN> GetAllGroupPicRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsGroupPicRelationEN> arrGroupPicRelationObjLstCache = GetObjLstCache(); 
return arrGroupPicRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGroupPicRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName);
List<clsGroupPicRelationEN> arrGroupPicRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGroupPicRelationObjLstCache;
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
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName);
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
if (clsGroupPicRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGroupPicRelationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GroupPicRelation(用户组图片关系)
 /// 唯一性条件:GroupId_PictureId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGroupPicRelationEN objGroupPicRelationEN)
{
//检测记录是否存在
string strResult = GroupPicRelationDA.GetUniCondStr(objGroupPicRelationEN);
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
if (strInFldName != conGroupPicRelation.RelationshipId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGroupPicRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGroupPicRelation.AttributeName));
throw new Exception(strMsg);
}
var objGroupPicRelation = clsGroupPicRelationBL.GetObjByRelationshipIdCache(intRelationshipId);
if (objGroupPicRelation == null) return "";
return objGroupPicRelation[strOutFldName].ToString();
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
int intRecCount = clsGroupPicRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsGroupPicRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGroupPicRelationDA.GetRecCount();
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
int intRecCount = clsGroupPicRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGroupPicRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGroupPicRelationEN objGroupPicRelationCond)
{
List<clsGroupPicRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGroupPicRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGroupPicRelation.AttributeName)
{
if (objGroupPicRelationCond.IsUpdated(strFldName) == false) continue;
if (objGroupPicRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGroupPicRelationCond[strFldName].ToString());
}
else
{
if (objGroupPicRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGroupPicRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGroupPicRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGroupPicRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGroupPicRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGroupPicRelationCond[strFldName]));
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
 List<string> arrList = clsGroupPicRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GroupPicRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GroupPicRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GroupPicRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGroupPicRelationDA.SetFldValue(clsGroupPicRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GroupPicRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGroupPicRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGroupPicRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGroupPicRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GroupPicRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**RelationshipId*/ 
 strCreateTabCode.Append(" RelationshipId int primary key identity, "); 
 // /**组Id*/ 
 strCreateTabCode.Append(" GroupId char(8) Null, "); 
 // /**PictureId*/ 
 strCreateTabCode.Append(" PictureId int Null, "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreateTime varchar(16) Null, "); 
 // /**建立用户ID*/ 
 strCreateTabCode.Append(" CreateUserID varchar(20) Null, "); 
 // /**最后修改用户ID*/ 
 strCreateTabCode.Append(" LastModifyUserID varchar(20) Null, "); 
 // /**最后修改时间*/ 
 strCreateTabCode.Append(" LastModifyTime varchar(16) Null, "); 
 // /**PictureConfigerId*/ 
 strCreateTabCode.Append(" PictureConfigerId char(4) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户组图片关系(GroupPicRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GroupPicRelation : clsCommFun4BL
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
clsGroupPicRelationBL.ReFreshThisCache();
}
}

}