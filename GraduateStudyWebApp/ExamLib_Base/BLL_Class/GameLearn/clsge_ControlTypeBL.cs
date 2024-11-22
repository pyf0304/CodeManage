
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ControlTypeBL
 表名:ge_ControlType(01120900)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
public static class  clsge_ControlTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strControlTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ControlTypeEN GetObj(this K_ControlTypeId_ge_ControlType myKey)
{
clsge_ControlTypeEN objge_ControlTypeEN = clsge_ControlTypeBL.ge_ControlTypeDA.GetObjByControlTypeId(myKey.Value);
return objge_ControlTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_ControlTypeEN objge_ControlTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ControlTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!控件名称 = [{0}]的数据已经存在!(in clsge_ControlTypeBL.AddNewRecord)", objge_ControlTypeEN.ControlTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true || clsge_ControlTypeBL.IsExist(objge_ControlTypeEN.ControlTypeId) == true)
 {
     objge_ControlTypeEN.ControlTypeId = clsge_ControlTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsge_ControlTypeBL.ge_ControlTypeDA.AddNewRecordBySQL2(objge_ControlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_ControlTypeEN objge_ControlTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_ControlTypeBL.IsExist(objge_ControlTypeEN.ControlTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_ControlTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_ControlTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(控件名称(ControlTypeName)=[{0}])已经存在,不能重复!", objge_ControlTypeEN.ControlTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true || clsge_ControlTypeBL.IsExist(objge_ControlTypeEN.ControlTypeId) == true)
 {
     objge_ControlTypeEN.ControlTypeId = clsge_ControlTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_ControlTypeEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_ControlTypeEN objge_ControlTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ControlTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!控件名称 = [{0}]的数据已经存在!(in clsge_ControlTypeBL.AddNewRecordWithMaxId)", objge_ControlTypeEN.ControlTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true || clsge_ControlTypeBL.IsExist(objge_ControlTypeEN.ControlTypeId) == true)
 {
     objge_ControlTypeEN.ControlTypeId = clsge_ControlTypeBL.GetMaxStrId_S();
 }
string strControlTypeId = clsge_ControlTypeBL.ge_ControlTypeDA.AddNewRecordBySQL2WithReturnKey(objge_ControlTypeEN);
     objge_ControlTypeEN.ControlTypeId = strControlTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
}
return strControlTypeId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_ControlTypeEN objge_ControlTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ControlTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!控件名称 = [{0}]的数据已经存在!(in clsge_ControlTypeBL.AddNewRecordWithReturnKey)", objge_ControlTypeEN.ControlTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true || clsge_ControlTypeBL.IsExist(objge_ControlTypeEN.ControlTypeId) == true)
 {
     objge_ControlTypeEN.ControlTypeId = clsge_ControlTypeBL.GetMaxStrId_S();
 }
string strKey = clsge_ControlTypeBL.ge_ControlTypeDA.AddNewRecordBySQL2WithReturnKey(objge_ControlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ControlTypeEN SetControlTypeId(this clsge_ControlTypeEN objge_ControlTypeEN, string strControlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlTypeId, 4, conge_ControlType.ControlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strControlTypeId, 4, conge_ControlType.ControlTypeId);
}
objge_ControlTypeEN.ControlTypeId = strControlTypeId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ControlTypeEN.dicFldComparisonOp.ContainsKey(conge_ControlType.ControlTypeId) == false)
{
objge_ControlTypeEN.dicFldComparisonOp.Add(conge_ControlType.ControlTypeId, strComparisonOp);
}
else
{
objge_ControlTypeEN.dicFldComparisonOp[conge_ControlType.ControlTypeId] = strComparisonOp;
}
}
return objge_ControlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ControlTypeEN SetControlTypeName(this clsge_ControlTypeEN objge_ControlTypeEN, string strControlTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlTypeName, 100, conge_ControlType.ControlTypeName);
}
objge_ControlTypeEN.ControlTypeName = strControlTypeName; //控件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ControlTypeEN.dicFldComparisonOp.ContainsKey(conge_ControlType.ControlTypeName) == false)
{
objge_ControlTypeEN.dicFldComparisonOp.Add(conge_ControlType.ControlTypeName, strComparisonOp);
}
else
{
objge_ControlTypeEN.dicFldComparisonOp[conge_ControlType.ControlTypeName] = strComparisonOp;
}
}
return objge_ControlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ControlTypeEN SetControlTypeEnName(this clsge_ControlTypeEN objge_ControlTypeEN, string strControlTypeEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlTypeEnName, 100, conge_ControlType.ControlTypeEnName);
}
objge_ControlTypeEN.ControlTypeEnName = strControlTypeEnName; //控件英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ControlTypeEN.dicFldComparisonOp.ContainsKey(conge_ControlType.ControlTypeEnName) == false)
{
objge_ControlTypeEN.dicFldComparisonOp.Add(conge_ControlType.ControlTypeEnName, strComparisonOp);
}
else
{
objge_ControlTypeEN.dicFldComparisonOp[conge_ControlType.ControlTypeEnName] = strComparisonOp;
}
}
return objge_ControlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ControlTypeEN SetUpdDate(this clsge_ControlTypeEN objge_ControlTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_ControlType.UpdDate);
}
objge_ControlTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ControlTypeEN.dicFldComparisonOp.ContainsKey(conge_ControlType.UpdDate) == false)
{
objge_ControlTypeEN.dicFldComparisonOp.Add(conge_ControlType.UpdDate, strComparisonOp);
}
else
{
objge_ControlTypeEN.dicFldComparisonOp[conge_ControlType.UpdDate] = strComparisonOp;
}
}
return objge_ControlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ControlTypeEN SetUpdUser(this clsge_ControlTypeEN objge_ControlTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_ControlType.UpdUser);
}
objge_ControlTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ControlTypeEN.dicFldComparisonOp.ContainsKey(conge_ControlType.UpdUser) == false)
{
objge_ControlTypeEN.dicFldComparisonOp.Add(conge_ControlType.UpdUser, strComparisonOp);
}
else
{
objge_ControlTypeEN.dicFldComparisonOp[conge_ControlType.UpdUser] = strComparisonOp;
}
}
return objge_ControlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ControlTypeEN SetMemo(this clsge_ControlTypeEN objge_ControlTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_ControlType.Memo);
}
objge_ControlTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ControlTypeEN.dicFldComparisonOp.ContainsKey(conge_ControlType.Memo) == false)
{
objge_ControlTypeEN.dicFldComparisonOp.Add(conge_ControlType.Memo, strComparisonOp);
}
else
{
objge_ControlTypeEN.dicFldComparisonOp[conge_ControlType.Memo] = strComparisonOp;
}
}
return objge_ControlTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_ControlTypeEN objge_ControlTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_ControlTypeEN.CheckPropertyNew();
clsge_ControlTypeEN objge_ControlTypeCond = new clsge_ControlTypeEN();
string strCondition = objge_ControlTypeCond
.SetControlTypeId(objge_ControlTypeEN.ControlTypeId, "<>")
.SetControlTypeName(objge_ControlTypeEN.ControlTypeName, "=")
.GetCombineCondition();
objge_ControlTypeEN._IsCheckProperty = true;
bool bolIsExist = clsge_ControlTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ControlTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_ControlTypeEN.Update();
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
 /// <param name = "objge_ControlType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_ControlTypeEN objge_ControlType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_ControlTypeEN objge_ControlTypeCond = new clsge_ControlTypeEN();
string strCondition = objge_ControlTypeCond
.SetControlTypeName(objge_ControlType.ControlTypeName, "=")
.GetCombineCondition();
objge_ControlType._IsCheckProperty = true;
bool bolIsExist = clsge_ControlTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_ControlType.ControlTypeId = clsge_ControlTypeBL.GetFirstID_S(strCondition);
objge_ControlType.UpdateWithCondition(strCondition);
}
else
{
objge_ControlType.ControlTypeId = clsge_ControlTypeBL.GetMaxStrId_S();
objge_ControlType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ControlTypeEN objge_ControlTypeEN)
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ControlTypeBL.ge_ControlTypeDA.UpdateBySql2(objge_ControlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ControlTypeEN objge_ControlTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ControlTypeBL.ge_ControlTypeDA.UpdateBySql2(objge_ControlTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ControlTypeEN objge_ControlTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsge_ControlTypeBL.ge_ControlTypeDA.UpdateBySqlWithCondition(objge_ControlTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ControlTypeEN objge_ControlTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_ControlTypeBL.ge_ControlTypeDA.UpdateBySqlWithConditionTransaction(objge_ControlTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "strControlTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_ControlTypeEN objge_ControlTypeEN)
{
try
{
int intRecNum = clsge_ControlTypeBL.ge_ControlTypeDA.DelRecord(objge_ControlTypeEN.ControlTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeENS">源对象</param>
 /// <param name = "objge_ControlTypeENT">目标对象</param>
 public static void CopyTo(this clsge_ControlTypeEN objge_ControlTypeENS, clsge_ControlTypeEN objge_ControlTypeENT)
{
try
{
objge_ControlTypeENT.ControlTypeId = objge_ControlTypeENS.ControlTypeId; //控件Id
objge_ControlTypeENT.ControlTypeName = objge_ControlTypeENS.ControlTypeName; //控件名称
objge_ControlTypeENT.ControlTypeEnName = objge_ControlTypeENS.ControlTypeEnName; //控件英文名称
objge_ControlTypeENT.UpdDate = objge_ControlTypeENS.UpdDate; //修改日期
objge_ControlTypeENT.UpdUser = objge_ControlTypeENS.UpdUser; //修改人
objge_ControlTypeENT.Memo = objge_ControlTypeENS.Memo; //备注
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
 /// <param name = "objge_ControlTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_ControlTypeEN:objge_ControlTypeENT</returns>
 public static clsge_ControlTypeEN CopyTo(this clsge_ControlTypeEN objge_ControlTypeENS)
{
try
{
 clsge_ControlTypeEN objge_ControlTypeENT = new clsge_ControlTypeEN()
{
ControlTypeId = objge_ControlTypeENS.ControlTypeId, //控件Id
ControlTypeName = objge_ControlTypeENS.ControlTypeName, //控件名称
ControlTypeEnName = objge_ControlTypeENS.ControlTypeEnName, //控件英文名称
UpdDate = objge_ControlTypeENS.UpdDate, //修改日期
UpdUser = objge_ControlTypeENS.UpdUser, //修改人
Memo = objge_ControlTypeENS.Memo, //备注
};
 return objge_ControlTypeENT;
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
public static void CheckPropertyNew(this clsge_ControlTypeEN objge_ControlTypeEN)
{
 clsge_ControlTypeBL.ge_ControlTypeDA.CheckPropertyNew(objge_ControlTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_ControlTypeEN objge_ControlTypeEN)
{
 clsge_ControlTypeBL.ge_ControlTypeDA.CheckProperty4Condition(objge_ControlTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_ControlTypeEN objge_ControlTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_ControlTypeCond.IsUpdated(conge_ControlType.ControlTypeId) == true)
{
string strComparisonOpControlTypeId = objge_ControlTypeCond.dicFldComparisonOp[conge_ControlType.ControlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ControlType.ControlTypeId, objge_ControlTypeCond.ControlTypeId, strComparisonOpControlTypeId);
}
if (objge_ControlTypeCond.IsUpdated(conge_ControlType.ControlTypeName) == true)
{
string strComparisonOpControlTypeName = objge_ControlTypeCond.dicFldComparisonOp[conge_ControlType.ControlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ControlType.ControlTypeName, objge_ControlTypeCond.ControlTypeName, strComparisonOpControlTypeName);
}
if (objge_ControlTypeCond.IsUpdated(conge_ControlType.ControlTypeEnName) == true)
{
string strComparisonOpControlTypeEnName = objge_ControlTypeCond.dicFldComparisonOp[conge_ControlType.ControlTypeEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ControlType.ControlTypeEnName, objge_ControlTypeCond.ControlTypeEnName, strComparisonOpControlTypeEnName);
}
if (objge_ControlTypeCond.IsUpdated(conge_ControlType.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_ControlTypeCond.dicFldComparisonOp[conge_ControlType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ControlType.UpdDate, objge_ControlTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_ControlTypeCond.IsUpdated(conge_ControlType.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_ControlTypeCond.dicFldComparisonOp[conge_ControlType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ControlType.UpdUser, objge_ControlTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_ControlTypeCond.IsUpdated(conge_ControlType.Memo) == true)
{
string strComparisonOpMemo = objge_ControlTypeCond.dicFldComparisonOp[conge_ControlType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ControlType.Memo, objge_ControlTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_ControlType(控件类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ControlTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_ControlTypeEN objge_ControlTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_ControlTypeEN == null) return true;
if (objge_ControlTypeEN.ControlTypeId == null || objge_ControlTypeEN.ControlTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objge_ControlTypeEN.ControlTypeName == null)
{
 sbCondition.AppendFormat(" and ControlTypeName is null", objge_ControlTypeEN.ControlTypeName);
}
else
{
 sbCondition.AppendFormat(" and ControlTypeName = '{0}'", objge_ControlTypeEN.ControlTypeName);
}
if (clsge_ControlTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ControlTypeId !=  '{0}'", objge_ControlTypeEN.ControlTypeId);
 sbCondition.AppendFormat(" and ControlTypeName = '{0}'", objge_ControlTypeEN.ControlTypeName);
if (clsge_ControlTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_ControlType(控件类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ControlTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_ControlTypeEN objge_ControlTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_ControlTypeEN == null) return "";
if (objge_ControlTypeEN.ControlTypeId == null || objge_ControlTypeEN.ControlTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objge_ControlTypeEN.ControlTypeName == null)
{
 sbCondition.AppendFormat(" and ControlTypeName is null", objge_ControlTypeEN.ControlTypeName);
}
else
{
 sbCondition.AppendFormat(" and ControlTypeName = '{0}'", objge_ControlTypeEN.ControlTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ControlTypeId !=  '{0}'", objge_ControlTypeEN.ControlTypeId);
 sbCondition.AppendFormat(" and ControlTypeName = '{0}'", objge_ControlTypeEN.ControlTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_ControlType
{
public virtual bool UpdRelaTabDate(string strControlTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 控件类型(ge_ControlType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_ControlTypeBL
{
public static RelatedActions_ge_ControlType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_ControlTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_ControlTypeDA ge_ControlTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_ControlTypeDA();
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
 public clsge_ControlTypeBL()
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
if (string.IsNullOrEmpty(clsge_ControlTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_ControlTypeEN._ConnectString);
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
public static DataTable GetDataTable_ge_ControlType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_ControlTypeDA.GetDataTable_ge_ControlType(strWhereCond);
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
objDT = ge_ControlTypeDA.GetDataTable(strWhereCond);
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
objDT = ge_ControlTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_ControlTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_ControlTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_ControlTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ge_ControlTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_ControlTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_ControlTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrControlTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_ControlTypeEN> GetObjLstByControlTypeIdLst(List<string> arrControlTypeIdLst)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrControlTypeIdLst, true);
 string strWhereCond = string.Format("ControlTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrControlTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_ControlTypeEN> GetObjLstByControlTypeIdLstCache(List<string> arrControlTypeIdLst)
{
string strKey = string.Format("{0}", clsge_ControlTypeEN._CurrTabName);
List<clsge_ControlTypeEN> arrge_ControlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_ControlTypeEN> arrge_ControlTypeObjLst_Sel =
arrge_ControlTypeObjLstCache
.Where(x => arrControlTypeIdLst.Contains(x.ControlTypeId));
return arrge_ControlTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ControlTypeEN> GetObjLst(string strWhereCond)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
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
public static List<clsge_ControlTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_ControlTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_ControlTypeEN> GetSubObjLstCache(clsge_ControlTypeEN objge_ControlTypeCond)
{
List<clsge_ControlTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_ControlTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ControlType.AttributeName)
{
if (objge_ControlTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_ControlTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ControlTypeCond[strFldName].ToString());
}
else
{
if (objge_ControlTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ControlTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ControlTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ControlTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ControlTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ControlTypeCond[strFldName]));
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
public static List<clsge_ControlTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
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
public static List<clsge_ControlTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
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
List<clsge_ControlTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_ControlTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ControlTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_ControlTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
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
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
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
public static List<clsge_ControlTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_ControlTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_ControlTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
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
public static List<clsge_ControlTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ControlTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_ControlTypeEN> arrObjLst = new List<clsge_ControlTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ControlTypeEN objge_ControlTypeEN = new clsge_ControlTypeEN();
try
{
objge_ControlTypeEN.ControlTypeId = objRow[conge_ControlType.ControlTypeId].ToString().Trim(); //控件Id
objge_ControlTypeEN.ControlTypeName = objRow[conge_ControlType.ControlTypeName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeName].ToString().Trim(); //控件名称
objge_ControlTypeEN.ControlTypeEnName = objRow[conge_ControlType.ControlTypeEnName] == DBNull.Value ? null : objRow[conge_ControlType.ControlTypeEnName].ToString().Trim(); //控件英文名称
objge_ControlTypeEN.UpdDate = objRow[conge_ControlType.UpdDate] == DBNull.Value ? null : objRow[conge_ControlType.UpdDate].ToString().Trim(); //修改日期
objge_ControlTypeEN.UpdUser = objRow[conge_ControlType.UpdUser] == DBNull.Value ? null : objRow[conge_ControlType.UpdUser].ToString().Trim(); //修改人
objge_ControlTypeEN.Memo = objRow[conge_ControlType.Memo] == DBNull.Value ? null : objRow[conge_ControlType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ControlTypeEN.ControlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ControlTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_ControlType(ref clsge_ControlTypeEN objge_ControlTypeEN)
{
bool bolResult = ge_ControlTypeDA.Getge_ControlType(ref objge_ControlTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strControlTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ControlTypeEN GetObjByControlTypeId(string strControlTypeId)
{
if (strControlTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strControlTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strControlTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strControlTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_ControlTypeEN objge_ControlTypeEN = ge_ControlTypeDA.GetObjByControlTypeId(strControlTypeId);
return objge_ControlTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_ControlTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_ControlTypeEN objge_ControlTypeEN = ge_ControlTypeDA.GetFirstObj(strWhereCond);
 return objge_ControlTypeEN;
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
public static clsge_ControlTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_ControlTypeEN objge_ControlTypeEN = ge_ControlTypeDA.GetObjByDataRow(objRow);
 return objge_ControlTypeEN;
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
public static clsge_ControlTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_ControlTypeEN objge_ControlTypeEN = ge_ControlTypeDA.GetObjByDataRow(objRow);
 return objge_ControlTypeEN;
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
 /// <param name = "strControlTypeId">所给的关键字</param>
 /// <param name = "lstge_ControlTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ControlTypeEN GetObjByControlTypeIdFromList(string strControlTypeId, List<clsge_ControlTypeEN> lstge_ControlTypeObjLst)
{
foreach (clsge_ControlTypeEN objge_ControlTypeEN in lstge_ControlTypeObjLst)
{
if (objge_ControlTypeEN.ControlTypeId == strControlTypeId)
{
return objge_ControlTypeEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxControlTypeId;
 try
 {
 strMaxControlTypeId = clsge_ControlTypeDA.GetMaxStrId();
 return strMaxControlTypeId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strControlTypeId;
 try
 {
 strControlTypeId = new clsge_ControlTypeDA().GetFirstID(strWhereCond);
 return strControlTypeId;
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
 arrList = ge_ControlTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ge_ControlTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strControlTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strControlTypeId)
{
if (string.IsNullOrEmpty(strControlTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strControlTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_ControlTypeDA.IsExist(strControlTypeId);
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
 bolIsExist = clsge_ControlTypeDA.IsExistTable();
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
 bolIsExist = ge_ControlTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_ControlTypeEN objge_ControlTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_ControlTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!控件名称 = [{0}]的数据已经存在!(in clsge_ControlTypeBL.AddNewRecordBySql2)", objge_ControlTypeEN.ControlTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true || clsge_ControlTypeBL.IsExist(objge_ControlTypeEN.ControlTypeId) == true)
 {
     objge_ControlTypeEN.ControlTypeId = clsge_ControlTypeBL.GetMaxStrId_S();
 }
bool bolResult = ge_ControlTypeDA.AddNewRecordBySQL2(objge_ControlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_ControlTypeEN objge_ControlTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_ControlTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!控件名称 = [{0}]的数据已经存在!(in clsge_ControlTypeBL.AddNewRecordBySql2WithReturnKey)", objge_ControlTypeEN.ControlTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true || clsge_ControlTypeBL.IsExist(objge_ControlTypeEN.ControlTypeId) == true)
 {
     objge_ControlTypeEN.ControlTypeId = clsge_ControlTypeBL.GetMaxStrId_S();
 }
string strKey = ge_ControlTypeDA.AddNewRecordBySQL2WithReturnKey(objge_ControlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_ControlTypeEN objge_ControlTypeEN)
{
try
{
bool bolResult = ge_ControlTypeDA.Update(objge_ControlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "objge_ControlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_ControlTypeEN objge_ControlTypeEN)
{
 if (string.IsNullOrEmpty(objge_ControlTypeEN.ControlTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_ControlTypeDA.UpdateBySql2(objge_ControlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ControlTypeBL.ReFreshCache();

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
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
 /// <param name = "strControlTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strControlTypeId)
{
try
{
 clsge_ControlTypeEN objge_ControlTypeEN = clsge_ControlTypeBL.GetObjByControlTypeId(strControlTypeId);

if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(objge_ControlTypeEN.ControlTypeId, "SetUpdDate");
}
if (objge_ControlTypeEN != null)
{
int intRecNum = ge_ControlTypeDA.DelRecord(strControlTypeId);
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
/// <param name="strControlTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strControlTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ControlTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_ControlType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_ControlType.ControlTypeId,
//strControlTypeId);
//        clsge_ControlTypeBL.Delge_ControlTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ControlTypeBL.DelRecord(strControlTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ControlTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strControlTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strControlTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strControlTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_ControlTypeBL.relatedActions != null)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(strControlTypeId, "UpdRelaTabDate");
}
bool bolResult = ge_ControlTypeDA.DelRecord(strControlTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrControlTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_ControlTypes(List<string> arrControlTypeIdLst)
{
if (arrControlTypeIdLst.Count == 0) return 0;
try
{
if (clsge_ControlTypeBL.relatedActions != null)
{
foreach (var strControlTypeId in arrControlTypeIdLst)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(strControlTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = ge_ControlTypeDA.Delge_ControlType(arrControlTypeIdLst);
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
public static int Delge_ControlTypesByCond(string strWhereCond)
{
try
{
if (clsge_ControlTypeBL.relatedActions != null)
{
List<string> arrControlTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strControlTypeId in arrControlTypeId)
{
clsge_ControlTypeBL.relatedActions.UpdRelaTabDate(strControlTypeId, "UpdRelaTabDate");
}
}
int intRecNum = ge_ControlTypeDA.Delge_ControlType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_ControlType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strControlTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strControlTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ControlTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_ControlType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ControlTypeBL.DelRecord(strControlTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ControlTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strControlTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_ControlTypeENS">源对象</param>
 /// <param name = "objge_ControlTypeENT">目标对象</param>
 public static void CopyTo(clsge_ControlTypeEN objge_ControlTypeENS, clsge_ControlTypeEN objge_ControlTypeENT)
{
try
{
objge_ControlTypeENT.ControlTypeId = objge_ControlTypeENS.ControlTypeId; //控件Id
objge_ControlTypeENT.ControlTypeName = objge_ControlTypeENS.ControlTypeName; //控件名称
objge_ControlTypeENT.ControlTypeEnName = objge_ControlTypeENS.ControlTypeEnName; //控件英文名称
objge_ControlTypeENT.UpdDate = objge_ControlTypeENS.UpdDate; //修改日期
objge_ControlTypeENT.UpdUser = objge_ControlTypeENS.UpdUser; //修改人
objge_ControlTypeENT.Memo = objge_ControlTypeENS.Memo; //备注
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
 /// <param name = "objge_ControlTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsge_ControlTypeEN objge_ControlTypeEN)
{
try
{
objge_ControlTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_ControlTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_ControlType.ControlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ControlTypeEN.ControlTypeId = objge_ControlTypeEN.ControlTypeId; //控件Id
}
if (arrFldSet.Contains(conge_ControlType.ControlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ControlTypeEN.ControlTypeName = objge_ControlTypeEN.ControlTypeName == "[null]" ? null :  objge_ControlTypeEN.ControlTypeName; //控件名称
}
if (arrFldSet.Contains(conge_ControlType.ControlTypeEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ControlTypeEN.ControlTypeEnName = objge_ControlTypeEN.ControlTypeEnName == "[null]" ? null :  objge_ControlTypeEN.ControlTypeEnName; //控件英文名称
}
if (arrFldSet.Contains(conge_ControlType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ControlTypeEN.UpdDate = objge_ControlTypeEN.UpdDate == "[null]" ? null :  objge_ControlTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_ControlType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ControlTypeEN.UpdUser = objge_ControlTypeEN.UpdUser == "[null]" ? null :  objge_ControlTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_ControlType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ControlTypeEN.Memo = objge_ControlTypeEN.Memo == "[null]" ? null :  objge_ControlTypeEN.Memo; //备注
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
 /// <param name = "objge_ControlTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_ControlTypeEN objge_ControlTypeEN)
{
try
{
if (objge_ControlTypeEN.ControlTypeName == "[null]") objge_ControlTypeEN.ControlTypeName = null; //控件名称
if (objge_ControlTypeEN.ControlTypeEnName == "[null]") objge_ControlTypeEN.ControlTypeEnName = null; //控件英文名称
if (objge_ControlTypeEN.UpdDate == "[null]") objge_ControlTypeEN.UpdDate = null; //修改日期
if (objge_ControlTypeEN.UpdUser == "[null]") objge_ControlTypeEN.UpdUser = null; //修改人
if (objge_ControlTypeEN.Memo == "[null]") objge_ControlTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_ControlTypeEN objge_ControlTypeEN)
{
 ge_ControlTypeDA.CheckPropertyNew(objge_ControlTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_ControlTypeEN objge_ControlTypeEN)
{
 ge_ControlTypeDA.CheckProperty4Condition(objge_ControlTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ControlTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[控件类型]...","0");
List<clsge_ControlTypeEN> arrge_ControlTypeObjLst = GetAllge_ControlTypeObjLstCache(); 
objDDL.DataValueField = conge_ControlType.ControlTypeId;
objDDL.DataTextField = conge_ControlType.ControlTypeName;
objDDL.DataSource = arrge_ControlTypeObjLst;
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
if (clsge_ControlTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_ControlTypeBL没有刷新缓存机制(clsge_ControlTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ControlTypeId");
//if (arrge_ControlTypeObjLstCache == null)
//{
//arrge_ControlTypeObjLstCache = ge_ControlTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strControlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ControlTypeEN GetObjByControlTypeIdCache(string strControlTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsge_ControlTypeEN._CurrTabName);
List<clsge_ControlTypeEN> arrge_ControlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_ControlTypeEN> arrge_ControlTypeObjLst_Sel =
arrge_ControlTypeObjLstCache
.Where(x=> x.ControlTypeId == strControlTypeId 
);
if (arrge_ControlTypeObjLst_Sel.Count() == 0)
{
   clsge_ControlTypeEN obj = clsge_ControlTypeBL.GetObjByControlTypeId(strControlTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrge_ControlTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strControlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetControlTypeNameByControlTypeIdCache(string strControlTypeId)
{
if (string.IsNullOrEmpty(strControlTypeId) == true) return "";
//获取缓存中的对象列表
clsge_ControlTypeEN objge_ControlType = GetObjByControlTypeIdCache(strControlTypeId);
if (objge_ControlType == null) return "";
return objge_ControlType.ControlTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strControlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByControlTypeIdCache(string strControlTypeId)
{
if (string.IsNullOrEmpty(strControlTypeId) == true) return "";
//获取缓存中的对象列表
clsge_ControlTypeEN objge_ControlType = GetObjByControlTypeIdCache(strControlTypeId);
if (objge_ControlType == null) return "";
return objge_ControlType.ControlTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ControlTypeEN> GetAllge_ControlTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsge_ControlTypeEN> arrge_ControlTypeObjLstCache = GetObjLstCache(); 
return arrge_ControlTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ControlTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsge_ControlTypeEN._CurrTabName);
List<clsge_ControlTypeEN> arrge_ControlTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrge_ControlTypeObjLstCache;
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
string strKey = string.Format("{0}", clsge_ControlTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_ControlTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_ControlTypeEN._RefreshTimeLst.Count == 0) return "";
return clsge_ControlTypeEN._RefreshTimeLst[clsge_ControlTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsge_ControlTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsge_ControlTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_ControlTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_ControlTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_ControlType(控件类型)
 /// 唯一性条件:ControlTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_ControlTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_ControlTypeEN objge_ControlTypeEN)
{
//检测记录是否存在
string strResult = ge_ControlTypeDA.GetUniCondStr(objge_ControlTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strControlTypeId)
{
if (strInFldName != conge_ControlType.ControlTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_ControlType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_ControlType.AttributeName));
throw new Exception(strMsg);
}
var objge_ControlType = clsge_ControlTypeBL.GetObjByControlTypeIdCache(strControlTypeId);
if (objge_ControlType == null) return "";
return objge_ControlType[strOutFldName].ToString();
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
int intRecCount = clsge_ControlTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsge_ControlTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_ControlTypeDA.GetRecCount();
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
int intRecCount = clsge_ControlTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_ControlTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_ControlTypeEN objge_ControlTypeCond)
{
List<clsge_ControlTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_ControlTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ControlType.AttributeName)
{
if (objge_ControlTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_ControlTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ControlTypeCond[strFldName].ToString());
}
else
{
if (objge_ControlTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ControlTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ControlTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ControlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ControlTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ControlTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ControlTypeCond[strFldName]));
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
 List<string> arrList = clsge_ControlTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_ControlTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_ControlTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_ControlTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ControlTypeDA.SetFldValue(clsge_ControlTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_ControlTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ControlTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ControlTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ControlTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_ControlType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" ControlTypeId char(4) primary key, "); 
 // /**控件名称*/ 
 strCreateTabCode.Append(" ControlTypeName varchar(100) Null, "); 
 // /**控件英文名称*/ 
 strCreateTabCode.Append(" ControlTypeEnName varchar(100) Null, "); 
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
 /// 控件类型(ge_ControlType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_ControlType : clsCommFun4BL
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
clsge_ControlTypeBL.ReFreshThisCache();
}
}

}