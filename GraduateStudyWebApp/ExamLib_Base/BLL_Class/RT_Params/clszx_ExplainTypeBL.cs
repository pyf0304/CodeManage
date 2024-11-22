
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ExplainTypeBL
 表名:zx_ExplainType(01120815)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
public static class  clszx_ExplainTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxExplainTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ExplainTypeEN GetObj(this K_zxExplainTypeId_zx_ExplainType myKey)
{
clszx_ExplainTypeEN objzx_ExplainTypeEN = clszx_ExplainTypeBL.zx_ExplainTypeDA.GetObjByzxExplainTypeId(myKey.Value);
return objzx_ExplainTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 if (string.IsNullOrEmpty(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ExplainTypeBL.IsExist(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ExplainTypeEN.zxExplainTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objzx_ExplainTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!说明类型名 = [{0}]的数据已经存在!(in clszx_ExplainTypeBL.AddNewRecord)", objzx_ExplainTypeEN.ExplainTypeName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_ExplainTypeBL.zx_ExplainTypeDA.AddNewRecordBySQL2(objzx_ExplainTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
public static bool AddRecordEx(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clszx_ExplainTypeBL.IsExist(objzx_ExplainTypeEN.zxExplainTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objzx_ExplainTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ExplainTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(说明类型名(ExplainTypeName)=[{0}])已经存在,不能重复!", objzx_ExplainTypeEN.ExplainTypeName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_ExplainTypeEN.AddNewRecord();
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
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 if (string.IsNullOrEmpty(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ExplainTypeBL.IsExist(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ExplainTypeEN.zxExplainTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objzx_ExplainTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!说明类型名 = [{0}]的数据已经存在!(in clszx_ExplainTypeBL.AddNewRecordWithReturnKey)", objzx_ExplainTypeEN.ExplainTypeName);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_ExplainTypeBL.zx_ExplainTypeDA.AddNewRecordBySQL2WithReturnKey(objzx_ExplainTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ExplainTypeEN SetzxExplainTypeId(this clszx_ExplainTypeEN objzx_ExplainTypeEN, string strzxExplainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxExplainTypeId, 2, conzx_ExplainType.zxExplainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxExplainTypeId, 2, conzx_ExplainType.zxExplainTypeId);
}
objzx_ExplainTypeEN.zxExplainTypeId = strzxExplainTypeId; //说明类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ExplainTypeEN.dicFldComparisonOp.ContainsKey(conzx_ExplainType.zxExplainTypeId) == false)
{
objzx_ExplainTypeEN.dicFldComparisonOp.Add(conzx_ExplainType.zxExplainTypeId, strComparisonOp);
}
else
{
objzx_ExplainTypeEN.dicFldComparisonOp[conzx_ExplainType.zxExplainTypeId] = strComparisonOp;
}
}
return objzx_ExplainTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ExplainTypeEN SetExplainTypeName(this clszx_ExplainTypeEN objzx_ExplainTypeEN, string strExplainTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainTypeName, 50, conzx_ExplainType.ExplainTypeName);
}
objzx_ExplainTypeEN.ExplainTypeName = strExplainTypeName; //说明类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ExplainTypeEN.dicFldComparisonOp.ContainsKey(conzx_ExplainType.ExplainTypeName) == false)
{
objzx_ExplainTypeEN.dicFldComparisonOp.Add(conzx_ExplainType.ExplainTypeName, strComparisonOp);
}
else
{
objzx_ExplainTypeEN.dicFldComparisonOp[conzx_ExplainType.ExplainTypeName] = strComparisonOp;
}
}
return objzx_ExplainTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ExplainTypeEN SetUpdDate(this clszx_ExplainTypeEN objzx_ExplainTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conzx_ExplainType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ExplainType.UpdDate);
}
objzx_ExplainTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ExplainTypeEN.dicFldComparisonOp.ContainsKey(conzx_ExplainType.UpdDate) == false)
{
objzx_ExplainTypeEN.dicFldComparisonOp.Add(conzx_ExplainType.UpdDate, strComparisonOp);
}
else
{
objzx_ExplainTypeEN.dicFldComparisonOp[conzx_ExplainType.UpdDate] = strComparisonOp;
}
}
return objzx_ExplainTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ExplainTypeEN SetUpdUserId(this clszx_ExplainTypeEN objzx_ExplainTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conzx_ExplainType.UpdUserId);
}
objzx_ExplainTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ExplainTypeEN.dicFldComparisonOp.ContainsKey(conzx_ExplainType.UpdUserId) == false)
{
objzx_ExplainTypeEN.dicFldComparisonOp.Add(conzx_ExplainType.UpdUserId, strComparisonOp);
}
else
{
objzx_ExplainTypeEN.dicFldComparisonOp[conzx_ExplainType.UpdUserId] = strComparisonOp;
}
}
return objzx_ExplainTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ExplainTypeEN SetMemo(this clszx_ExplainTypeEN objzx_ExplainTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ExplainType.Memo);
}
objzx_ExplainTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ExplainTypeEN.dicFldComparisonOp.ContainsKey(conzx_ExplainType.Memo) == false)
{
objzx_ExplainTypeEN.dicFldComparisonOp.Add(conzx_ExplainType.Memo, strComparisonOp);
}
else
{
objzx_ExplainTypeEN.dicFldComparisonOp[conzx_ExplainType.Memo] = strComparisonOp;
}
}
return objzx_ExplainTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ExplainTypeEN.CheckPropertyNew();
clszx_ExplainTypeEN objzx_ExplainTypeCond = new clszx_ExplainTypeEN();
string strCondition = objzx_ExplainTypeCond
.SetzxExplainTypeId(objzx_ExplainTypeEN.zxExplainTypeId, "<>")
.SetExplainTypeName(objzx_ExplainTypeEN.ExplainTypeName, "=")
.GetCombineCondition();
objzx_ExplainTypeEN._IsCheckProperty = true;
bool bolIsExist = clszx_ExplainTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ExplainTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ExplainTypeEN.Update();
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
 /// <param name = "objzx_ExplainType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ExplainTypeEN objzx_ExplainType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ExplainTypeEN objzx_ExplainTypeCond = new clszx_ExplainTypeEN();
string strCondition = objzx_ExplainTypeCond
.SetExplainTypeName(objzx_ExplainType.ExplainTypeName, "=")
.GetCombineCondition();
objzx_ExplainType._IsCheckProperty = true;
bool bolIsExist = clszx_ExplainTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ExplainType.zxExplainTypeId = clszx_ExplainTypeBL.GetFirstID_S(strCondition);
objzx_ExplainType.UpdateWithCondition(strCondition);
}
else
{
objzx_ExplainType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 if (string.IsNullOrEmpty(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ExplainTypeBL.zx_ExplainTypeDA.UpdateBySql2(objzx_ExplainTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ExplainTypeEN objzx_ExplainTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ExplainTypeBL.zx_ExplainTypeDA.UpdateBySql2(objzx_ExplainTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ExplainTypeEN objzx_ExplainTypeEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ExplainTypeBL.zx_ExplainTypeDA.UpdateBySqlWithCondition(objzx_ExplainTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ExplainTypeEN objzx_ExplainTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ExplainTypeBL.zx_ExplainTypeDA.UpdateBySqlWithConditionTransaction(objzx_ExplainTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "strzxExplainTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
try
{
int intRecNum = clszx_ExplainTypeBL.zx_ExplainTypeDA.DelRecord(objzx_ExplainTypeEN.zxExplainTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeENS">源对象</param>
 /// <param name = "objzx_ExplainTypeENT">目标对象</param>
 public static void CopyTo(this clszx_ExplainTypeEN objzx_ExplainTypeENS, clszx_ExplainTypeEN objzx_ExplainTypeENT)
{
try
{
objzx_ExplainTypeENT.zxExplainTypeId = objzx_ExplainTypeENS.zxExplainTypeId; //说明类型Id
objzx_ExplainTypeENT.ExplainTypeName = objzx_ExplainTypeENS.ExplainTypeName; //说明类型名
objzx_ExplainTypeENT.UpdDate = objzx_ExplainTypeENS.UpdDate; //修改日期
objzx_ExplainTypeENT.UpdUserId = objzx_ExplainTypeENS.UpdUserId; //修改用户Id
objzx_ExplainTypeENT.Memo = objzx_ExplainTypeENS.Memo; //备注
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
 /// <param name = "objzx_ExplainTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ExplainTypeEN:objzx_ExplainTypeENT</returns>
 public static clszx_ExplainTypeEN CopyTo(this clszx_ExplainTypeEN objzx_ExplainTypeENS)
{
try
{
 clszx_ExplainTypeEN objzx_ExplainTypeENT = new clszx_ExplainTypeEN()
{
zxExplainTypeId = objzx_ExplainTypeENS.zxExplainTypeId, //说明类型Id
ExplainTypeName = objzx_ExplainTypeENS.ExplainTypeName, //说明类型名
UpdDate = objzx_ExplainTypeENS.UpdDate, //修改日期
UpdUserId = objzx_ExplainTypeENS.UpdUserId, //修改用户Id
Memo = objzx_ExplainTypeENS.Memo, //备注
};
 return objzx_ExplainTypeENT;
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
public static void CheckPropertyNew(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 clszx_ExplainTypeBL.zx_ExplainTypeDA.CheckPropertyNew(objzx_ExplainTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 clszx_ExplainTypeBL.zx_ExplainTypeDA.CheckProperty4Condition(objzx_ExplainTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ExplainTypeEN objzx_ExplainTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ExplainTypeCond.IsUpdated(conzx_ExplainType.zxExplainTypeId) == true)
{
string strComparisonOpzxExplainTypeId = objzx_ExplainTypeCond.dicFldComparisonOp[conzx_ExplainType.zxExplainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ExplainType.zxExplainTypeId, objzx_ExplainTypeCond.zxExplainTypeId, strComparisonOpzxExplainTypeId);
}
if (objzx_ExplainTypeCond.IsUpdated(conzx_ExplainType.ExplainTypeName) == true)
{
string strComparisonOpExplainTypeName = objzx_ExplainTypeCond.dicFldComparisonOp[conzx_ExplainType.ExplainTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ExplainType.ExplainTypeName, objzx_ExplainTypeCond.ExplainTypeName, strComparisonOpExplainTypeName);
}
if (objzx_ExplainTypeCond.IsUpdated(conzx_ExplainType.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ExplainTypeCond.dicFldComparisonOp[conzx_ExplainType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ExplainType.UpdDate, objzx_ExplainTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ExplainTypeCond.IsUpdated(conzx_ExplainType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objzx_ExplainTypeCond.dicFldComparisonOp[conzx_ExplainType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ExplainType.UpdUserId, objzx_ExplainTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objzx_ExplainTypeCond.IsUpdated(conzx_ExplainType.Memo) == true)
{
string strComparisonOpMemo = objzx_ExplainTypeCond.dicFldComparisonOp[conzx_ExplainType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ExplainType.Memo, objzx_ExplainTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ExplainType(中学说明类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ExplainTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ExplainTypeEN == null) return true;
if (objzx_ExplainTypeEN.zxExplainTypeId == null || objzx_ExplainTypeEN.zxExplainTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ExplainTypeEN.ExplainTypeName == null)
{
 sbCondition.AppendFormat(" and ExplainTypeName is null", objzx_ExplainTypeEN.ExplainTypeName);
}
else
{
 sbCondition.AppendFormat(" and ExplainTypeName = '{0}'", objzx_ExplainTypeEN.ExplainTypeName);
}
if (clszx_ExplainTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxExplainTypeId !=  '{0}'", objzx_ExplainTypeEN.zxExplainTypeId);
 sbCondition.AppendFormat(" and ExplainTypeName = '{0}'", objzx_ExplainTypeEN.ExplainTypeName);
if (clszx_ExplainTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ExplainType(中学说明类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ExplainTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ExplainTypeEN == null) return "";
if (objzx_ExplainTypeEN.zxExplainTypeId == null || objzx_ExplainTypeEN.zxExplainTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ExplainTypeEN.ExplainTypeName == null)
{
 sbCondition.AppendFormat(" and ExplainTypeName is null", objzx_ExplainTypeEN.ExplainTypeName);
}
else
{
 sbCondition.AppendFormat(" and ExplainTypeName = '{0}'", objzx_ExplainTypeEN.ExplainTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxExplainTypeId !=  '{0}'", objzx_ExplainTypeEN.zxExplainTypeId);
 sbCondition.AppendFormat(" and ExplainTypeName = '{0}'", objzx_ExplainTypeEN.ExplainTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ExplainType
{
public virtual bool UpdRelaTabDate(string strzxExplainTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学说明类型(zx_ExplainType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ExplainTypeBL
{
public static RelatedActions_zx_ExplainType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ExplainTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ExplainTypeDA zx_ExplainTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ExplainTypeDA();
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
 public clszx_ExplainTypeBL()
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
if (string.IsNullOrEmpty(clszx_ExplainTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ExplainTypeEN._ConnectString);
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
public static DataTable GetDataTable_zx_ExplainType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ExplainTypeDA.GetDataTable_zx_ExplainType(strWhereCond);
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
objDT = zx_ExplainTypeDA.GetDataTable(strWhereCond);
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
objDT = zx_ExplainTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ExplainTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ExplainTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ExplainTypeDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ExplainTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ExplainTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ExplainTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxExplainTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ExplainTypeEN> GetObjLstByZxExplainTypeIdLst(List<string> arrZxExplainTypeIdLst)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxExplainTypeIdLst, true);
 string strWhereCond = string.Format("zxExplainTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxExplainTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ExplainTypeEN> GetObjLstByZxExplainTypeIdLstCache(List<string> arrZxExplainTypeIdLst)
{
string strKey = string.Format("{0}", clszx_ExplainTypeEN._CurrTabName);
List<clszx_ExplainTypeEN> arrzx_ExplainTypeObjLstCache = GetObjLstCache();
IEnumerable <clszx_ExplainTypeEN> arrzx_ExplainTypeObjLst_Sel =
arrzx_ExplainTypeObjLstCache
.Where(x => arrZxExplainTypeIdLst.Contains(x.zxExplainTypeId));
return arrzx_ExplainTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ExplainTypeEN> GetObjLst(string strWhereCond)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
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
public static List<clszx_ExplainTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ExplainTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ExplainTypeEN> GetSubObjLstCache(clszx_ExplainTypeEN objzx_ExplainTypeCond)
{
List<clszx_ExplainTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ExplainTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ExplainType.AttributeName)
{
if (objzx_ExplainTypeCond.IsUpdated(strFldName) == false) continue;
if (objzx_ExplainTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ExplainTypeCond[strFldName].ToString());
}
else
{
if (objzx_ExplainTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ExplainTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ExplainTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ExplainTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ExplainTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ExplainTypeCond[strFldName]));
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
public static List<clszx_ExplainTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
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
public static List<clszx_ExplainTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
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
List<clszx_ExplainTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ExplainTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ExplainTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ExplainTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
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
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
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
public static List<clszx_ExplainTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ExplainTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ExplainTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
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
public static List<clszx_ExplainTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ExplainTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ExplainTypeEN> arrObjLst = new List<clszx_ExplainTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN();
try
{
objzx_ExplainTypeEN.zxExplainTypeId = objRow[conzx_ExplainType.zxExplainTypeId].ToString().Trim(); //说明类型Id
objzx_ExplainTypeEN.ExplainTypeName = objRow[conzx_ExplainType.ExplainTypeName] == DBNull.Value ? null : objRow[conzx_ExplainType.ExplainTypeName].ToString().Trim(); //说明类型名
objzx_ExplainTypeEN.UpdDate = objRow[conzx_ExplainType.UpdDate].ToString().Trim(); //修改日期
objzx_ExplainTypeEN.UpdUserId = objRow[conzx_ExplainType.UpdUserId] == DBNull.Value ? null : objRow[conzx_ExplainType.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ExplainTypeEN.Memo = objRow[conzx_ExplainType.Memo] == DBNull.Value ? null : objRow[conzx_ExplainType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ExplainTypeEN.zxExplainTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ExplainTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ExplainType(ref clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
bool bolResult = zx_ExplainTypeDA.Getzx_ExplainType(ref objzx_ExplainTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxExplainTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ExplainTypeEN GetObjByzxExplainTypeId(string strzxExplainTypeId)
{
if (strzxExplainTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxExplainTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxExplainTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxExplainTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_ExplainTypeEN objzx_ExplainTypeEN = zx_ExplainTypeDA.GetObjByzxExplainTypeId(strzxExplainTypeId);
return objzx_ExplainTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ExplainTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ExplainTypeEN objzx_ExplainTypeEN = zx_ExplainTypeDA.GetFirstObj(strWhereCond);
 return objzx_ExplainTypeEN;
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
public static clszx_ExplainTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ExplainTypeEN objzx_ExplainTypeEN = zx_ExplainTypeDA.GetObjByDataRow(objRow);
 return objzx_ExplainTypeEN;
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
public static clszx_ExplainTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ExplainTypeEN objzx_ExplainTypeEN = zx_ExplainTypeDA.GetObjByDataRow(objRow);
 return objzx_ExplainTypeEN;
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
 /// <param name = "strzxExplainTypeId">所给的关键字</param>
 /// <param name = "lstzx_ExplainTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ExplainTypeEN GetObjByzxExplainTypeIdFromList(string strzxExplainTypeId, List<clszx_ExplainTypeEN> lstzx_ExplainTypeObjLst)
{
foreach (clszx_ExplainTypeEN objzx_ExplainTypeEN in lstzx_ExplainTypeObjLst)
{
if (objzx_ExplainTypeEN.zxExplainTypeId == strzxExplainTypeId)
{
return objzx_ExplainTypeEN;
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
 string strzxExplainTypeId;
 try
 {
 strzxExplainTypeId = new clszx_ExplainTypeDA().GetFirstID(strWhereCond);
 return strzxExplainTypeId;
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
 arrList = zx_ExplainTypeDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ExplainTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxExplainTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxExplainTypeId)
{
if (string.IsNullOrEmpty(strzxExplainTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxExplainTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_ExplainTypeDA.IsExist(strzxExplainTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strzxExplainTypeId">说明类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strzxExplainTypeId, string strOpUser)
{
clszx_ExplainTypeEN objzx_ExplainTypeEN = clszx_ExplainTypeBL.GetObjByzxExplainTypeId(strzxExplainTypeId);
objzx_ExplainTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objzx_ExplainTypeEN.UpdUserId = strOpUser;
return clszx_ExplainTypeBL.UpdateBySql2(objzx_ExplainTypeEN);
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
 bolIsExist = clszx_ExplainTypeDA.IsExistTable();
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
 bolIsExist = zx_ExplainTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 if (string.IsNullOrEmpty(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ExplainTypeBL.IsExist(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ExplainTypeEN.zxExplainTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objzx_ExplainTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!说明类型名 = [{0}]的数据已经存在!(in clszx_ExplainTypeBL.AddNewRecordBySql2)", objzx_ExplainTypeEN.ExplainTypeName);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_ExplainTypeDA.AddNewRecordBySQL2(objzx_ExplainTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 if (string.IsNullOrEmpty(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ExplainTypeBL.IsExist(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ExplainTypeEN.zxExplainTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objzx_ExplainTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!说明类型名 = [{0}]的数据已经存在!(in clszx_ExplainTypeBL.AddNewRecordBySql2WithReturnKey)", objzx_ExplainTypeEN.ExplainTypeName);
throw new Exception(strMsg);
}
try
{
string strKey = zx_ExplainTypeDA.AddNewRecordBySQL2WithReturnKey(objzx_ExplainTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
try
{
bool bolResult = zx_ExplainTypeDA.Update(objzx_ExplainTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "objzx_ExplainTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 if (string.IsNullOrEmpty(objzx_ExplainTypeEN.zxExplainTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ExplainTypeDA.UpdateBySql2(objzx_ExplainTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ExplainTypeBL.ReFreshCache();

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
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
 /// <param name = "strzxExplainTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxExplainTypeId)
{
try
{
 clszx_ExplainTypeEN objzx_ExplainTypeEN = clszx_ExplainTypeBL.GetObjByzxExplainTypeId(strzxExplainTypeId);

if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(objzx_ExplainTypeEN.zxExplainTypeId, objzx_ExplainTypeEN.UpdUserId);
}
if (objzx_ExplainTypeEN != null)
{
int intRecNum = zx_ExplainTypeDA.DelRecord(strzxExplainTypeId);
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
/// <param name="strzxExplainTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxExplainTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ExplainTypeDA.GetSpecSQLObj();
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
//删除与表:[zx_ExplainType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ExplainType.zxExplainTypeId,
//strzxExplainTypeId);
//        clszx_ExplainTypeBL.Delzx_ExplainTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ExplainTypeBL.DelRecord(strzxExplainTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ExplainTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxExplainTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxExplainTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxExplainTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ExplainTypeBL.relatedActions != null)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(strzxExplainTypeId, "UpdRelaTabDate");
}
bool bolResult = zx_ExplainTypeDA.DelRecord(strzxExplainTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxExplainTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ExplainTypes(List<string> arrzxExplainTypeIdLst)
{
if (arrzxExplainTypeIdLst.Count == 0) return 0;
try
{
if (clszx_ExplainTypeBL.relatedActions != null)
{
foreach (var strzxExplainTypeId in arrzxExplainTypeIdLst)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(strzxExplainTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ExplainTypeDA.Delzx_ExplainType(arrzxExplainTypeIdLst);
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
public static int Delzx_ExplainTypesByCond(string strWhereCond)
{
try
{
if (clszx_ExplainTypeBL.relatedActions != null)
{
List<string> arrzxExplainTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxExplainTypeId in arrzxExplainTypeId)
{
clszx_ExplainTypeBL.relatedActions.UpdRelaTabDate(strzxExplainTypeId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ExplainTypeDA.Delzx_ExplainType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ExplainType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxExplainTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxExplainTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ExplainTypeDA.GetSpecSQLObj();
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
//删除与表:[zx_ExplainType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ExplainTypeBL.DelRecord(strzxExplainTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ExplainTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxExplainTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ExplainTypeENS">源对象</param>
 /// <param name = "objzx_ExplainTypeENT">目标对象</param>
 public static void CopyTo(clszx_ExplainTypeEN objzx_ExplainTypeENS, clszx_ExplainTypeEN objzx_ExplainTypeENT)
{
try
{
objzx_ExplainTypeENT.zxExplainTypeId = objzx_ExplainTypeENS.zxExplainTypeId; //说明类型Id
objzx_ExplainTypeENT.ExplainTypeName = objzx_ExplainTypeENS.ExplainTypeName; //说明类型名
objzx_ExplainTypeENT.UpdDate = objzx_ExplainTypeENS.UpdDate; //修改日期
objzx_ExplainTypeENT.UpdUserId = objzx_ExplainTypeENS.UpdUserId; //修改用户Id
objzx_ExplainTypeENT.Memo = objzx_ExplainTypeENS.Memo; //备注
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
 /// <param name = "objzx_ExplainTypeEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
try
{
objzx_ExplainTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ExplainTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ExplainType.zxExplainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ExplainTypeEN.zxExplainTypeId = objzx_ExplainTypeEN.zxExplainTypeId; //说明类型Id
}
if (arrFldSet.Contains(conzx_ExplainType.ExplainTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ExplainTypeEN.ExplainTypeName = objzx_ExplainTypeEN.ExplainTypeName == "[null]" ? null :  objzx_ExplainTypeEN.ExplainTypeName; //说明类型名
}
if (arrFldSet.Contains(conzx_ExplainType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ExplainTypeEN.UpdDate = objzx_ExplainTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ExplainType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ExplainTypeEN.UpdUserId = objzx_ExplainTypeEN.UpdUserId == "[null]" ? null :  objzx_ExplainTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conzx_ExplainType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ExplainTypeEN.Memo = objzx_ExplainTypeEN.Memo == "[null]" ? null :  objzx_ExplainTypeEN.Memo; //备注
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
 /// <param name = "objzx_ExplainTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
try
{
if (objzx_ExplainTypeEN.ExplainTypeName == "[null]") objzx_ExplainTypeEN.ExplainTypeName = null; //说明类型名
if (objzx_ExplainTypeEN.UpdUserId == "[null]") objzx_ExplainTypeEN.UpdUserId = null; //修改用户Id
if (objzx_ExplainTypeEN.Memo == "[null]") objzx_ExplainTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 zx_ExplainTypeDA.CheckPropertyNew(objzx_ExplainTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
 zx_ExplainTypeDA.CheckProperty4Condition(objzx_ExplainTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_zxExplainTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_ExplainType.zxExplainTypeId); 
List<clszx_ExplainTypeEN> arrObjLst = clszx_ExplainTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_ExplainTypeEN objzx_ExplainTypeEN = new clszx_ExplainTypeEN()
{
zxExplainTypeId = "0",
ExplainTypeName = "选[中学说明类型]..."
};
arrObjLst.Insert(0, objzx_ExplainTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_ExplainType.zxExplainTypeId;
objComboBox.DisplayMember = conzx_ExplainType.ExplainTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_zxExplainTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学说明类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_ExplainType.zxExplainTypeId); 
IEnumerable<clszx_ExplainTypeEN> arrObjLst = clszx_ExplainTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conzx_ExplainType.zxExplainTypeId;
objDDL.DataTextField = conzx_ExplainType.ExplainTypeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_zxExplainTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学说明类型]...","0");
List<clszx_ExplainTypeEN> arrzx_ExplainTypeObjLst = GetAllzx_ExplainTypeObjLstCache(); 
objDDL.DataValueField = conzx_ExplainType.zxExplainTypeId;
objDDL.DataTextField = conzx_ExplainType.ExplainTypeName;
objDDL.DataSource = arrzx_ExplainTypeObjLst;
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
if (clszx_ExplainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ExplainTypeBL没有刷新缓存机制(clszx_ExplainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxExplainTypeId");
//if (arrzx_ExplainTypeObjLstCache == null)
//{
//arrzx_ExplainTypeObjLstCache = zx_ExplainTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxExplainTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ExplainTypeEN GetObjByzxExplainTypeIdCache(string strzxExplainTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ExplainTypeEN._CurrTabName);
List<clszx_ExplainTypeEN> arrzx_ExplainTypeObjLstCache = GetObjLstCache();
IEnumerable <clszx_ExplainTypeEN> arrzx_ExplainTypeObjLst_Sel =
arrzx_ExplainTypeObjLstCache
.Where(x=> x.zxExplainTypeId == strzxExplainTypeId 
);
if (arrzx_ExplainTypeObjLst_Sel.Count() == 0)
{
   clszx_ExplainTypeEN obj = clszx_ExplainTypeBL.GetObjByzxExplainTypeId(strzxExplainTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ExplainTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxExplainTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetExplainTypeNameByzxExplainTypeIdCache(string strzxExplainTypeId)
{
if (string.IsNullOrEmpty(strzxExplainTypeId) == true) return "";
//获取缓存中的对象列表
clszx_ExplainTypeEN objzx_ExplainType = GetObjByzxExplainTypeIdCache(strzxExplainTypeId);
if (objzx_ExplainType == null) return "";
return objzx_ExplainType.ExplainTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxExplainTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByzxExplainTypeIdCache(string strzxExplainTypeId)
{
if (string.IsNullOrEmpty(strzxExplainTypeId) == true) return "";
//获取缓存中的对象列表
clszx_ExplainTypeEN objzx_ExplainType = GetObjByzxExplainTypeIdCache(strzxExplainTypeId);
if (objzx_ExplainType == null) return "";
return objzx_ExplainType.ExplainTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ExplainTypeEN> GetAllzx_ExplainTypeObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ExplainTypeEN> arrzx_ExplainTypeObjLstCache = GetObjLstCache(); 
return arrzx_ExplainTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ExplainTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ExplainTypeEN._CurrTabName);
List<clszx_ExplainTypeEN> arrzx_ExplainTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ExplainTypeObjLstCache;
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
string strKey = string.Format("{0}", clszx_ExplainTypeEN._CurrTabName);
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
if (clszx_ExplainTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ExplainTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ExplainTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ExplainType(中学说明类型)
 /// 唯一性条件:ExplainTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ExplainTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ExplainTypeEN objzx_ExplainTypeEN)
{
//检测记录是否存在
string strResult = zx_ExplainTypeDA.GetUniCondStr(objzx_ExplainTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxExplainTypeId)
{
if (strInFldName != conzx_ExplainType.zxExplainTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ExplainType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ExplainType.AttributeName));
throw new Exception(strMsg);
}
var objzx_ExplainType = clszx_ExplainTypeBL.GetObjByzxExplainTypeIdCache(strzxExplainTypeId);
if (objzx_ExplainType == null) return "";
return objzx_ExplainType[strOutFldName].ToString();
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
int intRecCount = clszx_ExplainTypeDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ExplainTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ExplainTypeDA.GetRecCount();
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
int intRecCount = clszx_ExplainTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ExplainTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ExplainTypeEN objzx_ExplainTypeCond)
{
List<clszx_ExplainTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ExplainTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ExplainType.AttributeName)
{
if (objzx_ExplainTypeCond.IsUpdated(strFldName) == false) continue;
if (objzx_ExplainTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ExplainTypeCond[strFldName].ToString());
}
else
{
if (objzx_ExplainTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ExplainTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ExplainTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ExplainTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ExplainTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ExplainTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ExplainTypeCond[strFldName]));
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
 List<string> arrList = clszx_ExplainTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ExplainTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ExplainTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ExplainTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ExplainTypeDA.SetFldValue(clszx_ExplainTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ExplainTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ExplainTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ExplainTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ExplainTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ExplainType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**说明类型Id*/ 
 strCreateTabCode.Append(" zxExplainTypeId char(2) primary key, "); 
 // /**说明类型名*/ 
 strCreateTabCode.Append(" ExplainTypeName varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
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
 /// 中学说明类型(zx_ExplainType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ExplainType : clsCommFun4BL
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
clszx_ExplainTypeBL.ReFreshThisCache();
}
}

}