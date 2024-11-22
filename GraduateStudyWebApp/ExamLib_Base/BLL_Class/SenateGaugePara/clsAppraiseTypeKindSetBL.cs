
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseTypeKindSetBL
 表名:AppraiseTypeKindSet(01120460)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
public static class  clsAppraiseTypeKindSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppraiseTypeKindSetEN GetObj(this K_mId_AppraiseTypeKindSet myKey)
{
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.GetObjBymId(myKey.Value);
return objAppraiseTypeKindSetEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAppraiseTypeKindSetEN) == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],功能模块Id = [{1}],评议类型流水号 = [{2}],评议种类Id = [{3}]的数据已经存在!(in clsAppraiseTypeKindSetBL.AddNewRecord)", objAppraiseTypeKindSetEN.IdSchool,objAppraiseTypeKindSetEN.FuncModuleId,objAppraiseTypeKindSetEN.IdAppraiseType,objAppraiseTypeKindSetEN.AppraiseKindId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.AddNewRecordBySQL2(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
public static bool AddRecordEx(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, bool bolIsNeedCheckUniqueness = true)
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
objAppraiseTypeKindSetEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objAppraiseTypeKindSetEN.CheckUniqueness() == false)
{
strMsg = string.Format("(学校流水号(IdSchool)=[{0}],功能模块Id(FuncModuleId)=[{1}],评议类型流水号(IdAppraiseType)=[{2}],评议种类Id(AppraiseKindId)=[{3}])已经存在,不能重复!", objAppraiseTypeKindSetEN.IdSchool, objAppraiseTypeKindSetEN.FuncModuleId, objAppraiseTypeKindSetEN.IdAppraiseType, objAppraiseTypeKindSetEN.AppraiseKindId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objAppraiseTypeKindSetEN.AddNewRecord();
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAppraiseTypeKindSetEN) == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],功能模块Id = [{1}],评议类型流水号 = [{2}],评议种类Id = [{3}]的数据已经存在!(in clsAppraiseTypeKindSetBL.AddNewRecordWithReturnKey)", objAppraiseTypeKindSetEN.IdSchool,objAppraiseTypeKindSetEN.FuncModuleId,objAppraiseTypeKindSetEN.IdAppraiseType,objAppraiseTypeKindSetEN.AppraiseKindId);
throw new Exception(strMsg);
}
try
{
string strKey = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.AddNewRecordBySQL2WithReturnKey(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetmId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, long lngmId, string strComparisonOp="")
	{
objAppraiseTypeKindSetEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.mId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.mId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.mId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetIdSchool(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strIdSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSchool, conAppraiseTypeKindSet.IdSchool);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conAppraiseTypeKindSet.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conAppraiseTypeKindSet.IdSchool);
}
objAppraiseTypeKindSetEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.IdSchool) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.IdSchool, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.IdSchool] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetFuncModuleId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conAppraiseTypeKindSet.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conAppraiseTypeKindSet.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conAppraiseTypeKindSet.FuncModuleId);
}
objAppraiseTypeKindSetEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.FuncModuleId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.FuncModuleId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.FuncModuleId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetIdAppraiseType(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, conAppraiseTypeKindSet.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, conAppraiseTypeKindSet.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, conAppraiseTypeKindSet.IdAppraiseType);
}
objAppraiseTypeKindSetEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.IdAppraiseType) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.IdAppraiseType, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.IdAppraiseType] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetAppraiseKindId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strAppraiseKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseKindId, conAppraiseTypeKindSet.AppraiseKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseKindId, 2, conAppraiseTypeKindSet.AppraiseKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseKindId, 2, conAppraiseTypeKindSet.AppraiseKindId);
}
objAppraiseTypeKindSetEN.AppraiseKindId = strAppraiseKindId; //评议种类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.AppraiseKindId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.AppraiseKindId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.AppraiseKindId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetInEffect(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, bool bolInEffect, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInEffect, conAppraiseTypeKindSet.InEffect);
objAppraiseTypeKindSetEN.InEffect = bolInEffect; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.InEffect) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.InEffect, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.InEffect] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetUpdDate(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAppraiseTypeKindSet.UpdDate);
}
objAppraiseTypeKindSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.UpdDate) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.UpdDate, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.UpdDate] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetUpdUserId(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conAppraiseTypeKindSet.UpdUserId);
}
objAppraiseTypeKindSetEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.UpdUserId) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.UpdUserId, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.UpdUserId] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeKindSetEN SetMemo(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAppraiseTypeKindSet.Memo);
}
objAppraiseTypeKindSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(conAppraiseTypeKindSet.Memo) == false)
{
objAppraiseTypeKindSetEN.dicFldComparisonOp.Add(conAppraiseTypeKindSet.Memo, strComparisonOp);
}
else
{
objAppraiseTypeKindSetEN.dicFldComparisonOp[conAppraiseTypeKindSet.Memo] = strComparisonOp;
}
}
return objAppraiseTypeKindSetEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAppraiseTypeKindSetEN.CheckPropertyNew();
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetCond = new clsAppraiseTypeKindSetEN();
string strCondition = objAppraiseTypeKindSetCond
.SetmId(objAppraiseTypeKindSetEN.mId, "<>")
.SetIdSchool(objAppraiseTypeKindSetEN.IdSchool, "=")
.SetFuncModuleId(objAppraiseTypeKindSetEN.FuncModuleId, "=")
.SetIdAppraiseType(objAppraiseTypeKindSetEN.IdAppraiseType, "=")
.SetAppraiseKindId(objAppraiseTypeKindSetEN.AppraiseKindId, "=")
.GetCombineCondition();
objAppraiseTypeKindSetEN._IsCheckProperty = true;
bool bolIsExist = clsAppraiseTypeKindSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_School_FuncModuleId_id_AppraiseType_AppraiseKindId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAppraiseTypeKindSetEN.Update();
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
 /// <param name = "objAppraiseTypeKindSet">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSet)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetCond = new clsAppraiseTypeKindSetEN();
string strCondition = objAppraiseTypeKindSetCond
.SetIdSchool(objAppraiseTypeKindSet.IdSchool, "=")
.SetFuncModuleId(objAppraiseTypeKindSet.FuncModuleId, "=")
.SetIdAppraiseType(objAppraiseTypeKindSet.IdAppraiseType, "=")
.SetAppraiseKindId(objAppraiseTypeKindSet.AppraiseKindId, "=")
.GetCombineCondition();
objAppraiseTypeKindSet._IsCheckProperty = true;
bool bolIsExist = clsAppraiseTypeKindSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objAppraiseTypeKindSet.mId = clsAppraiseTypeKindSetBL.GetFirstID_S(strCondition);
objAppraiseTypeKindSet.UpdateWithCondition(strCondition);
}
else
{
objAppraiseTypeKindSet.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 if (objAppraiseTypeKindSetEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.UpdateBySql2(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAppraiseTypeKindSetEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.UpdateBySql2(objAppraiseTypeKindSetEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strWhereCond)
{
try
{
bool bolResult = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.UpdateBySqlWithCondition(objAppraiseTypeKindSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.UpdateBySqlWithConditionTransaction(objAppraiseTypeKindSetEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
public static int Delete(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
try
{
int intRecNum = clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.DelRecord(objAppraiseTypeKindSetEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetENS">源对象</param>
 /// <param name = "objAppraiseTypeKindSetENT">目标对象</param>
 public static void CopyTo(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENS, clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENT)
{
try
{
objAppraiseTypeKindSetENT.mId = objAppraiseTypeKindSetENS.mId; //mId
objAppraiseTypeKindSetENT.IdSchool = objAppraiseTypeKindSetENS.IdSchool; //学校流水号
objAppraiseTypeKindSetENT.FuncModuleId = objAppraiseTypeKindSetENS.FuncModuleId; //功能模块Id
objAppraiseTypeKindSetENT.IdAppraiseType = objAppraiseTypeKindSetENS.IdAppraiseType; //评议类型流水号
objAppraiseTypeKindSetENT.AppraiseKindId = objAppraiseTypeKindSetENS.AppraiseKindId; //评议种类Id
objAppraiseTypeKindSetENT.InEffect = objAppraiseTypeKindSetENS.InEffect; //是否有效
objAppraiseTypeKindSetENT.UpdDate = objAppraiseTypeKindSetENS.UpdDate; //修改日期
objAppraiseTypeKindSetENT.UpdUserId = objAppraiseTypeKindSetENS.UpdUserId; //修改用户Id
objAppraiseTypeKindSetENT.Memo = objAppraiseTypeKindSetENS.Memo; //备注
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
 /// <param name = "objAppraiseTypeKindSetENS">源对象</param>
 /// <returns>目标对象=>clsAppraiseTypeKindSetEN:objAppraiseTypeKindSetENT</returns>
 public static clsAppraiseTypeKindSetEN CopyTo(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENS)
{
try
{
 clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENT = new clsAppraiseTypeKindSetEN()
{
mId = objAppraiseTypeKindSetENS.mId, //mId
IdSchool = objAppraiseTypeKindSetENS.IdSchool, //学校流水号
FuncModuleId = objAppraiseTypeKindSetENS.FuncModuleId, //功能模块Id
IdAppraiseType = objAppraiseTypeKindSetENS.IdAppraiseType, //评议类型流水号
AppraiseKindId = objAppraiseTypeKindSetENS.AppraiseKindId, //评议种类Id
InEffect = objAppraiseTypeKindSetENS.InEffect, //是否有效
UpdDate = objAppraiseTypeKindSetENS.UpdDate, //修改日期
UpdUserId = objAppraiseTypeKindSetENS.UpdUserId, //修改用户Id
Memo = objAppraiseTypeKindSetENS.Memo, //备注
};
 return objAppraiseTypeKindSetENT;
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
public static void CheckPropertyNew(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.CheckPropertyNew(objAppraiseTypeKindSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 clsAppraiseTypeKindSetBL.AppraiseTypeKindSetDA.CheckProperty4Condition(objAppraiseTypeKindSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.mId) == true)
{
string strComparisonOpmId = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conAppraiseTypeKindSet.mId, objAppraiseTypeKindSetCond.mId, strComparisonOpmId);
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.IdSchool) == true)
{
string strComparisonOpIdSchool = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.IdSchool, objAppraiseTypeKindSetCond.IdSchool, strComparisonOpIdSchool);
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.FuncModuleId, objAppraiseTypeKindSetCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.IdAppraiseType, objAppraiseTypeKindSetCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.AppraiseKindId) == true)
{
string strComparisonOpAppraiseKindId = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.AppraiseKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.AppraiseKindId, objAppraiseTypeKindSetCond.AppraiseKindId, strComparisonOpAppraiseKindId);
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.InEffect) == true)
{
if (objAppraiseTypeKindSetCond.InEffect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAppraiseTypeKindSet.InEffect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAppraiseTypeKindSet.InEffect);
}
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.UpdDate) == true)
{
string strComparisonOpUpdDate = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.UpdDate, objAppraiseTypeKindSetCond.UpdDate, strComparisonOpUpdDate);
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.UpdUserId, objAppraiseTypeKindSetCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objAppraiseTypeKindSetCond.IsUpdated(conAppraiseTypeKindSet.Memo) == true)
{
string strComparisonOpMemo = objAppraiseTypeKindSetCond.dicFldComparisonOp[conAppraiseTypeKindSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseTypeKindSet.Memo, objAppraiseTypeKindSetCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--AppraiseTypeKindSet(评议类型种类设置), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_School_FuncModuleId_id_AppraiseType_AppraiseKindId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objAppraiseTypeKindSetEN == null) return true;
if (objAppraiseTypeKindSetEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objAppraiseTypeKindSetEN.IdSchool);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objAppraiseTypeKindSetEN.FuncModuleId);
 sbCondition.AppendFormat(" and IdAppraiseType = '{0}'", objAppraiseTypeKindSetEN.IdAppraiseType);
 sbCondition.AppendFormat(" and AppraiseKindId = '{0}'", objAppraiseTypeKindSetEN.AppraiseKindId);
if (clsAppraiseTypeKindSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAppraiseTypeKindSetEN.mId);
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objAppraiseTypeKindSetEN.IdSchool);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objAppraiseTypeKindSetEN.FuncModuleId);
 sbCondition.AppendFormat(" and IdAppraiseType = '{0}'", objAppraiseTypeKindSetEN.IdAppraiseType);
 sbCondition.AppendFormat(" and AppraiseKindId = '{0}'", objAppraiseTypeKindSetEN.AppraiseKindId);
if (clsAppraiseTypeKindSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--AppraiseTypeKindSet(评议类型种类设置), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_School_FuncModuleId_id_AppraiseType_AppraiseKindId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAppraiseTypeKindSetEN == null) return "";
if (objAppraiseTypeKindSetEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objAppraiseTypeKindSetEN.IdSchool);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objAppraiseTypeKindSetEN.FuncModuleId);
 sbCondition.AppendFormat(" and IdAppraiseType = '{0}'", objAppraiseTypeKindSetEN.IdAppraiseType);
 sbCondition.AppendFormat(" and AppraiseKindId = '{0}'", objAppraiseTypeKindSetEN.AppraiseKindId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAppraiseTypeKindSetEN.mId);
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objAppraiseTypeKindSetEN.IdSchool);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objAppraiseTypeKindSetEN.FuncModuleId);
 sbCondition.AppendFormat(" and IdAppraiseType = '{0}'", objAppraiseTypeKindSetEN.IdAppraiseType);
 sbCondition.AppendFormat(" and AppraiseKindId = '{0}'", objAppraiseTypeKindSetEN.AppraiseKindId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_AppraiseTypeKindSet
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 评议类型种类设置(AppraiseTypeKindSet)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAppraiseTypeKindSetBL
{
public static RelatedActions_AppraiseTypeKindSet relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAppraiseTypeKindSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAppraiseTypeKindSetDA AppraiseTypeKindSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAppraiseTypeKindSetDA();
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
 public clsAppraiseTypeKindSetBL()
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
if (string.IsNullOrEmpty(clsAppraiseTypeKindSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAppraiseTypeKindSetEN._ConnectString);
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
public static DataTable GetDataTable_AppraiseTypeKindSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = AppraiseTypeKindSetDA.GetDataTable_AppraiseTypeKindSet(strWhereCond);
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
objDT = AppraiseTypeKindSetDA.GetDataTable(strWhereCond);
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
objDT = AppraiseTypeKindSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = AppraiseTypeKindSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = AppraiseTypeKindSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = AppraiseTypeKindSetDA.GetDataTable_Top(objTopPara);
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
objDT = AppraiseTypeKindSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = AppraiseTypeKindSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = AppraiseTypeKindSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
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
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsAppraiseTypeKindSetEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName);
List<clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLst_Sel =
arrAppraiseTypeKindSetObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrAppraiseTypeKindSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetObjLst(string strWhereCond)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsAppraiseTypeKindSetEN> GetSubObjLstCache(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetCond)
{
List<clsAppraiseTypeKindSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeKindSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAppraiseTypeKindSet.AttributeName)
{
if (objAppraiseTypeKindSetCond.IsUpdated(strFldName) == false) continue;
if (objAppraiseTypeKindSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeKindSetCond[strFldName].ToString());
}
else
{
if (objAppraiseTypeKindSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAppraiseTypeKindSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeKindSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAppraiseTypeKindSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeKindSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeKindSetCond[strFldName]));
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
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
List<clsAppraiseTypeKindSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAppraiseTypeKindSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAppraiseTypeKindSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
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
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
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
public static List<clsAppraiseTypeKindSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
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
public static List<clsAppraiseTypeKindSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeKindSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAppraiseTypeKindSet(ref clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
bool bolResult = AppraiseTypeKindSetDA.GetAppraiseTypeKindSet(ref objAppraiseTypeKindSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppraiseTypeKindSetEN GetObjBymId(long lngmId)
{
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = AppraiseTypeKindSetDA.GetObjBymId(lngmId);
return objAppraiseTypeKindSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAppraiseTypeKindSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = AppraiseTypeKindSetDA.GetFirstObj(strWhereCond);
 return objAppraiseTypeKindSetEN;
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
public static clsAppraiseTypeKindSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = AppraiseTypeKindSetDA.GetObjByDataRow(objRow);
 return objAppraiseTypeKindSetEN;
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
public static clsAppraiseTypeKindSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = AppraiseTypeKindSetDA.GetObjByDataRow(objRow);
 return objAppraiseTypeKindSetEN;
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
 /// <param name = "lstAppraiseTypeKindSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAppraiseTypeKindSetEN GetObjBymIdFromList(long lngmId, List<clsAppraiseTypeKindSetEN> lstAppraiseTypeKindSetObjLst)
{
foreach (clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN in lstAppraiseTypeKindSetObjLst)
{
if (objAppraiseTypeKindSetEN.mId == lngmId)
{
return objAppraiseTypeKindSetEN;
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
 lngmId = new clsAppraiseTypeKindSetDA().GetFirstID(strWhereCond);
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
 arrList = AppraiseTypeKindSetDA.GetID(strWhereCond);
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
bool bolIsExist = AppraiseTypeKindSetDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = AppraiseTypeKindSetDA.IsExist(lngmId);
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
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = clsAppraiseTypeKindSetBL.GetObjBymId(lngmId);
objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objAppraiseTypeKindSetEN.UpdUserId = strOpUser;
return clsAppraiseTypeKindSetBL.UpdateBySql2(objAppraiseTypeKindSetEN);
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
 bolIsExist = clsAppraiseTypeKindSetDA.IsExistTable();
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
 bolIsExist = AppraiseTypeKindSetDA.IsExistTable(strTabName);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAppraiseTypeKindSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],功能模块Id = [{1}],评议类型流水号 = [{2}],评议种类Id = [{3}]的数据已经存在!(in clsAppraiseTypeKindSetBL.AddNewRecordBySql2)", objAppraiseTypeKindSetEN.IdSchool,objAppraiseTypeKindSetEN.FuncModuleId,objAppraiseTypeKindSetEN.IdAppraiseType,objAppraiseTypeKindSetEN.AppraiseKindId);
throw new Exception(strMsg);
}
try
{
bool bolResult = AppraiseTypeKindSetDA.AddNewRecordBySQL2(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAppraiseTypeKindSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],功能模块Id = [{1}],评议类型流水号 = [{2}],评议种类Id = [{3}]的数据已经存在!(in clsAppraiseTypeKindSetBL.AddNewRecordBySql2WithReturnKey)", objAppraiseTypeKindSetEN.IdSchool,objAppraiseTypeKindSetEN.FuncModuleId,objAppraiseTypeKindSetEN.IdAppraiseType,objAppraiseTypeKindSetEN.AppraiseKindId);
throw new Exception(strMsg);
}
try
{
string strKey = AppraiseTypeKindSetDA.AddNewRecordBySQL2WithReturnKey(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
try
{
bool bolResult = AppraiseTypeKindSetDA.Update(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 if (objAppraiseTypeKindSetEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = AppraiseTypeKindSetDA.UpdateBySql2(objAppraiseTypeKindSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeKindSetBL.ReFreshCache();

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
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
 clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = clsAppraiseTypeKindSetBL.GetObjBymId(lngmId);

if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(objAppraiseTypeKindSetEN.mId, objAppraiseTypeKindSetEN.UpdUserId);
}
if (objAppraiseTypeKindSetEN != null)
{
int intRecNum = AppraiseTypeKindSetDA.DelRecord(lngmId);
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
objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
//删除与表:[AppraiseTypeKindSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAppraiseTypeKindSet.mId,
//lngmId);
//        clsAppraiseTypeKindSetBL.DelAppraiseTypeKindSetsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAppraiseTypeKindSetBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAppraiseTypeKindSetBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = AppraiseTypeKindSetDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelAppraiseTypeKindSets(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = AppraiseTypeKindSetDA.DelAppraiseTypeKindSet(arrmIdLst);
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
public static int DelAppraiseTypeKindSetsByCond(string strWhereCond)
{
try
{
if (clsAppraiseTypeKindSetBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsAppraiseTypeKindSetBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = AppraiseTypeKindSetDA.DelAppraiseTypeKindSet(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[AppraiseTypeKindSet]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
//删除与表:[AppraiseTypeKindSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAppraiseTypeKindSetBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAppraiseTypeKindSetBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objAppraiseTypeKindSetENS">源对象</param>
 /// <param name = "objAppraiseTypeKindSetENT">目标对象</param>
 public static void CopyTo(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENS, clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENT)
{
try
{
objAppraiseTypeKindSetENT.mId = objAppraiseTypeKindSetENS.mId; //mId
objAppraiseTypeKindSetENT.IdSchool = objAppraiseTypeKindSetENS.IdSchool; //学校流水号
objAppraiseTypeKindSetENT.FuncModuleId = objAppraiseTypeKindSetENS.FuncModuleId; //功能模块Id
objAppraiseTypeKindSetENT.IdAppraiseType = objAppraiseTypeKindSetENS.IdAppraiseType; //评议类型流水号
objAppraiseTypeKindSetENT.AppraiseKindId = objAppraiseTypeKindSetENS.AppraiseKindId; //评议种类Id
objAppraiseTypeKindSetENT.InEffect = objAppraiseTypeKindSetENS.InEffect; //是否有效
objAppraiseTypeKindSetENT.UpdDate = objAppraiseTypeKindSetENS.UpdDate; //修改日期
objAppraiseTypeKindSetENT.UpdUserId = objAppraiseTypeKindSetENS.UpdUserId; //修改用户Id
objAppraiseTypeKindSetENT.Memo = objAppraiseTypeKindSetENS.Memo; //备注
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
 /// <param name = "objAppraiseTypeKindSetEN">源简化对象</param>
 public static void SetUpdFlag(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
try
{
objAppraiseTypeKindSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objAppraiseTypeKindSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAppraiseTypeKindSet.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.mId = objAppraiseTypeKindSetEN.mId; //mId
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.IdSchool = objAppraiseTypeKindSetEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.FuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.IdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.AppraiseKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.AppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId; //评议种类Id
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.InEffect, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.InEffect = objAppraiseTypeKindSetEN.InEffect; //是否有效
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.UpdDate = objAppraiseTypeKindSetEN.UpdDate == "[null]" ? null :  objAppraiseTypeKindSetEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.UpdUserId = objAppraiseTypeKindSetEN.UpdUserId == "[null]" ? null :  objAppraiseTypeKindSetEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conAppraiseTypeKindSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeKindSetEN.Memo = objAppraiseTypeKindSetEN.Memo == "[null]" ? null :  objAppraiseTypeKindSetEN.Memo; //备注
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
 /// <param name = "objAppraiseTypeKindSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
try
{
if (objAppraiseTypeKindSetEN.UpdDate == "[null]") objAppraiseTypeKindSetEN.UpdDate = null; //修改日期
if (objAppraiseTypeKindSetEN.UpdUserId == "[null]") objAppraiseTypeKindSetEN.UpdUserId = null; //修改用户Id
if (objAppraiseTypeKindSetEN.Memo == "[null]") objAppraiseTypeKindSetEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 AppraiseTypeKindSetDA.CheckPropertyNew(objAppraiseTypeKindSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 AppraiseTypeKindSetDA.CheckProperty4Condition(objAppraiseTypeKindSetEN);
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
if (clsAppraiseTypeKindSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeKindSetBL没有刷新缓存机制(clsAppraiseTypeKindSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrAppraiseTypeKindSetObjLstCache == null)
//{
//arrAppraiseTypeKindSetObjLstCache = AppraiseTypeKindSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAppraiseTypeKindSetEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName);
List<clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLst_Sel =
arrAppraiseTypeKindSetObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrAppraiseTypeKindSetObjLst_Sel.Count() == 0)
{
   clsAppraiseTypeKindSetEN obj = clsAppraiseTypeKindSetBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrAppraiseTypeKindSetObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetAllAppraiseTypeKindSetObjLstCache()
{
//获取缓存中的对象列表
List<clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLstCache = GetObjLstCache(); 
return arrAppraiseTypeKindSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppraiseTypeKindSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName);
List<clsAppraiseTypeKindSetEN> arrAppraiseTypeKindSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAppraiseTypeKindSetObjLstCache;
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
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAppraiseTypeKindSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsAppraiseTypeKindSetEN._RefreshTimeLst.Count == 0) return "";
return clsAppraiseTypeKindSetEN._RefreshTimeLst[clsAppraiseTypeKindSetEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsAppraiseTypeKindSetBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAppraiseTypeKindSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAppraiseTypeKindSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsAppraiseTypeKindSetBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--AppraiseTypeKindSet(评议类型种类设置)
 /// 唯一性条件:id_School_FuncModuleId_id_AppraiseType_AppraiseKindId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//检测记录是否存在
string strResult = AppraiseTypeKindSetDA.GetUniCondStr(objAppraiseTypeKindSetEN);
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
if (strInFldName != conAppraiseTypeKindSet.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conAppraiseTypeKindSet.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conAppraiseTypeKindSet.AttributeName));
throw new Exception(strMsg);
}
var objAppraiseTypeKindSet = clsAppraiseTypeKindSetBL.GetObjBymIdCache(lngmId);
if (objAppraiseTypeKindSet == null) return "";
return objAppraiseTypeKindSet[strOutFldName].ToString();
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
int intRecCount = clsAppraiseTypeKindSetDA.GetRecCount(strTabName);
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
int intRecCount = clsAppraiseTypeKindSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAppraiseTypeKindSetDA.GetRecCount();
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
int intRecCount = clsAppraiseTypeKindSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetCond)
{
List<clsAppraiseTypeKindSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeKindSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAppraiseTypeKindSet.AttributeName)
{
if (objAppraiseTypeKindSetCond.IsUpdated(strFldName) == false) continue;
if (objAppraiseTypeKindSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeKindSetCond[strFldName].ToString());
}
else
{
if (objAppraiseTypeKindSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAppraiseTypeKindSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeKindSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAppraiseTypeKindSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeKindSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeKindSetCond[strFldName]));
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
 List<string> arrList = clsAppraiseTypeKindSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = AppraiseTypeKindSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = AppraiseTypeKindSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = AppraiseTypeKindSetDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeKindSetDA.SetFldValue(clsAppraiseTypeKindSetEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = AppraiseTypeKindSetDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeKindSetDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeKindSetDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeKindSetDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[AppraiseTypeKindSet] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) not Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**评议类型流水号*/ 
 strCreateTabCode.Append(" IdAppraiseType char(4) not Null, "); 
 // /**评议种类Id*/ 
 strCreateTabCode.Append(" AppraiseKindId char(2) not Null, "); 
 // /**是否有效*/ 
 strCreateTabCode.Append(" InEffect bit not Null, "); 
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
 /// 评议类型种类设置(AppraiseTypeKindSet)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4AppraiseTypeKindSet : clsCommFun4BL
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
clsAppraiseTypeKindSetBL.ReFreshThisCache();
}
}

}