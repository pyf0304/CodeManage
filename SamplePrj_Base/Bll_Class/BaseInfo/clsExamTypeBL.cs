
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExamTypeBL
 表名:ExamType(01160053)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:48
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsExamTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strExamTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExamTypeEN GetObj(this K_ExamTypeId_ExamType myKey)
{
clsExamTypeEN objExamTypeEN = clsExamTypeBL.ExamTypeDA.GetObjByExamTypeId(myKey.Value);
return objExamTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsExamTypeEN objExamTypeEN)
{
if (CheckUniqueness_ExamTypeName(objExamTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!考试类型名 = [{0}]的数据已经存在!(in clsExamTypeBL.AddNewRecord)", objExamTypeEN.ExamTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true || clsExamTypeBL.IsExist(objExamTypeEN.ExamTypeId) == true)
 {
     objExamTypeEN.ExamTypeId = clsExamTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsExamTypeBL.ExamTypeDA.AddNewRecordBySQL2(objExamTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsExamTypeEN objExamTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
//if (clsExamTypeBL.IsExist(objExamTypeEN.ExamTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objExamTypeEN.CheckPropertyNew();
//因为是字符型自增主键，所以在添加时，自动获取主键值。
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true || clsExamTypeBL.IsExist(objExamTypeEN.ExamTypeId) == true)
 {
     objExamTypeEN.ExamTypeId = clsExamTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objExamTypeEN.AddNewRecord();
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
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsExamTypeEN objExamTypeEN)
{
if (CheckUniqueness_ExamTypeName(objExamTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!考试类型名 = [{0}]的数据已经存在!(in clsExamTypeBL.AddNewRecordWithMaxId)", objExamTypeEN.ExamTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true || clsExamTypeBL.IsExist(objExamTypeEN.ExamTypeId) == true)
 {
     objExamTypeEN.ExamTypeId = clsExamTypeBL.GetMaxStrId_S();
 }
string strExamTypeId = clsExamTypeBL.ExamTypeDA.AddNewRecordBySQL2WithReturnKey(objExamTypeEN);
     objExamTypeEN.ExamTypeId = strExamTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
}
return strExamTypeId;
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
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsExamTypeEN objExamTypeEN)
{
if (CheckUniqueness_ExamTypeName(objExamTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!考试类型名 = [{0}]的数据已经存在!(in clsExamTypeBL.AddNewRecordWithReturnKey)", objExamTypeEN.ExamTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true || clsExamTypeBL.IsExist(objExamTypeEN.ExamTypeId) == true)
 {
     objExamTypeEN.ExamTypeId = clsExamTypeBL.GetMaxStrId_S();
 }
string strKey = clsExamTypeBL.ExamTypeDA.AddNewRecordBySQL2WithReturnKey(objExamTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExamTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsExamTypeEN SetExamTypeId(this clsExamTypeEN objExamTypeEN, string strExamTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamTypeId, 2, conExamType.ExamTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamTypeId, 2, conExamType.ExamTypeId);
}
objExamTypeEN.ExamTypeId = strExamTypeId; //考试类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExamTypeEN.dicFldComparisonOp.ContainsKey(conExamType.ExamTypeId) == false)
{
objExamTypeEN.dicFldComparisonOp.Add(conExamType.ExamTypeId, strComparisonOp);
}
else
{
objExamTypeEN.dicFldComparisonOp[conExamType.ExamTypeId] = strComparisonOp;
}
}
return objExamTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExamTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsExamTypeEN SetExamTypeName(this clsExamTypeEN objExamTypeEN, string strExamTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamTypeName, conExamType.ExamTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamTypeName, 30, conExamType.ExamTypeName);
}
objExamTypeEN.ExamTypeName = strExamTypeName; //考试类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExamTypeEN.dicFldComparisonOp.ContainsKey(conExamType.ExamTypeName) == false)
{
objExamTypeEN.dicFldComparisonOp.Add(conExamType.ExamTypeName, strComparisonOp);
}
else
{
objExamTypeEN.dicFldComparisonOp[conExamType.ExamTypeName] = strComparisonOp;
}
}
return objExamTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExamTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsExamTypeEN Set_IsDeleted(this clsExamTypeEN objExamTypeEN, bool bol_IsDeleted, string strComparisonOp="")
	{
objExamTypeEN._IsDeleted = bol_IsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExamTypeEN.dicFldComparisonOp.ContainsKey(conExamType._IsDeleted) == false)
{
objExamTypeEN.dicFldComparisonOp.Add(conExamType._IsDeleted, strComparisonOp);
}
else
{
objExamTypeEN.dicFldComparisonOp[conExamType._IsDeleted] = strComparisonOp;
}
}
return objExamTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExamTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsExamTypeEN Set_DeletedDate(this clsExamTypeEN objExamTypeEN, string str_DeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(str_DeletedDate, 50, conExamType._DeletedDate);
}
objExamTypeEN._DeletedDate = str_DeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExamTypeEN.dicFldComparisonOp.ContainsKey(conExamType._DeletedDate) == false)
{
objExamTypeEN.dicFldComparisonOp.Add(conExamType._DeletedDate, strComparisonOp);
}
else
{
objExamTypeEN.dicFldComparisonOp[conExamType._DeletedDate] = strComparisonOp;
}
}
return objExamTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExamTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsExamTypeEN SetMemo(this clsExamTypeEN objExamTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conExamType.Memo);
}
objExamTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExamTypeEN.dicFldComparisonOp.ContainsKey(conExamType.Memo) == false)
{
objExamTypeEN.dicFldComparisonOp.Add(conExamType.Memo, strComparisonOp);
}
else
{
objExamTypeEN.dicFldComparisonOp[conExamType.Memo] = strComparisonOp;
}
}
return objExamTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objExamTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsExamTypeEN objExamTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objExamTypeEN.CheckPropertyNew();
clsExamTypeEN objExamType_Cond = new clsExamTypeEN();
string strCondition = objExamType_Cond
.SetExamTypeId(objExamTypeEN.ExamTypeId, "<>")
.SetExamTypeName(objExamTypeEN.ExamTypeName, "=")
.GetCombineCondition();
objExamTypeEN._IsCheckProperty = true;
bool bolIsExist = clsExamTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ExamTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objExamTypeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objExamType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsExamTypeEN objExamType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsExamTypeEN objExamType_Cond = new clsExamTypeEN();
string strCondition = objExamType_Cond
.SetExamTypeName(objExamType.ExamTypeName, "=")
.GetCombineCondition();
objExamType._IsCheckProperty = true;
bool bolIsExist = clsExamTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objExamType.ExamTypeId = clsExamTypeBL.GetFirstID_S(strCondition);
objExamType.UpdateWithCondition(strCondition);
}
else
{
objExamType.ExamTypeId = clsExamTypeBL.GetMaxStrId_S();
objExamType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExamTypeEN objExamTypeEN)
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExamTypeBL.ExamTypeDA.UpdateBySql2(objExamTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExamTypeEN objExamTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExamTypeBL.ExamTypeDA.UpdateBySql2(objExamTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "objExamTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExamTypeEN objExamTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsExamTypeBL.ExamTypeDA.UpdateBySqlWithCondition(objExamTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "objExamTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExamTypeEN objExamTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsExamTypeBL.ExamTypeDA.UpdateBySqlWithConditionTransaction(objExamTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "strExamTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsExamTypeEN objExamTypeEN)
{
try
{
int intRecNum = clsExamTypeBL.ExamTypeDA.DelRecord(objExamTypeEN.ExamTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "objExamTypeENS">源对象</param>
 /// <param name = "objExamTypeENT">目标对象</param>
 public static void CopyTo(this clsExamTypeEN objExamTypeENS, clsExamTypeEN objExamTypeENT)
{
try
{
objExamTypeENT.ExamTypeId = objExamTypeENS.ExamTypeId; //考试类型Id
objExamTypeENT.ExamTypeName = objExamTypeENS.ExamTypeName; //考试类型名
objExamTypeENT._IsDeleted = objExamTypeENS._IsDeleted; //是否删除
objExamTypeENT._DeletedDate = objExamTypeENS._DeletedDate; //删除日期
objExamTypeENT.Memo = objExamTypeENS.Memo; //备注
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
 /// <param name = "objExamTypeENS">源对象</param>
 /// <returns>目标对象=>clsExamTypeEN:objExamTypeENT</returns>
 public static clsExamTypeEN CopyTo(this clsExamTypeEN objExamTypeENS)
{
try
{
 clsExamTypeEN objExamTypeENT = new clsExamTypeEN()
{
ExamTypeId = objExamTypeENS.ExamTypeId, //考试类型Id
ExamTypeName = objExamTypeENS.ExamTypeName, //考试类型名
_IsDeleted = objExamTypeENS._IsDeleted, //是否删除
_DeletedDate = objExamTypeENS._DeletedDate, //删除日期
Memo = objExamTypeENS.Memo, //备注
};
 return objExamTypeENT;
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
public static void CheckPropertyNew(this clsExamTypeEN objExamTypeEN)
{
 clsExamTypeBL.ExamTypeDA.CheckPropertyNew(objExamTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsExamTypeEN objExamTypeEN)
{
 clsExamTypeBL.ExamTypeDA.CheckProperty4Condition(objExamTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsExamTypeEN objExamType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objExamType_Cond.IsUpdated(conExamType.ExamTypeId) == true)
{
string strComparisonOp_ExamTypeId = objExamType_Cond.dicFldComparisonOp[conExamType.ExamTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExamType.ExamTypeId, objExamType_Cond.ExamTypeId, strComparisonOp_ExamTypeId);
}
if (objExamType_Cond.IsUpdated(conExamType.ExamTypeName) == true)
{
string strComparisonOp_ExamTypeName = objExamType_Cond.dicFldComparisonOp[conExamType.ExamTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExamType.ExamTypeName, objExamType_Cond.ExamTypeName, strComparisonOp_ExamTypeName);
}
if (objExamType_Cond.IsUpdated(conExamType._IsDeleted) == true)
{
if (objExamType_Cond._IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExamType._IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExamType._IsDeleted);
}
}
if (objExamType_Cond.IsUpdated(conExamType._DeletedDate) == true)
{
string strComparisonOp__DeletedDate = objExamType_Cond.dicFldComparisonOp[conExamType._DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExamType._DeletedDate, objExamType_Cond._DeletedDate, strComparisonOp__DeletedDate);
}
if (objExamType_Cond.IsUpdated(conExamType.Memo) == true)
{
string strComparisonOp_Memo = objExamType_Cond.dicFldComparisonOp[conExamType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExamType.Memo, objExamType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ExamType(考试类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objExamTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckExamTypeUniqueness(this clsExamTypeEN objExamTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objExamTypeEN == null) return true;
if (objExamTypeEN.ExamTypeId == null || objExamTypeEN.ExamTypeId == "")
{
bolIsUniqueness = clsExamTypeBL.ExamTypeDA.CheckExamTypeUniqueness();
}
else
{
bolIsUniqueness = clsExamTypeBL.ExamTypeDA.CheckExamTypeUniqueness(objExamTypeEN.ExamTypeId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ExamType(考试类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objExamTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_ExamTypeName(this clsExamTypeEN objExamTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objExamTypeEN == null) return true;
if (objExamTypeEN.ExamTypeId == null || objExamTypeEN.ExamTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ExamTypeName = '{0}'", objExamTypeEN.ExamTypeName);
if (clsExamTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ExamTypeId !=  '{0}'", objExamTypeEN.ExamTypeId);
 sbCondition.AppendFormat(" and ExamTypeName = '{0}'", objExamTypeEN.ExamTypeName);
if (clsExamTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--ExamType(考试类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objExamTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_ExamTypeName(this clsExamTypeEN objExamTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objExamTypeEN == null) return "";
if (objExamTypeEN.ExamTypeId == null || objExamTypeEN.ExamTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ExamTypeName = '{0}'", objExamTypeEN.ExamTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ExamTypeId !=  '{0}'", objExamTypeEN.ExamTypeId);
 sbCondition.AppendFormat(" and ExamTypeName = '{0}'", objExamTypeEN.ExamTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ExamType
{
public virtual bool UpdRelaTabDate(string strExamTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 考试类型(ExamType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsExamTypeBL
{
public static RelatedActions_ExamType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsExamTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsExamTypeDA ExamTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsExamTypeDA();
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
 public clsExamTypeBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsExamTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsExamTypeEN._ConnectString);
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
public static DataTable GetDataTable_ExamType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ExamTypeDA.GetDataTable_ExamType(strWhereCond);
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
objDT = ExamTypeDA.GetDataTable(strWhereCond);
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
objDT = ExamTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ExamTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ExamTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ExamTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ExamTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ExamTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ExamTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrExamTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsExamTypeEN> GetObjLstByExamTypeIdLst(List<string> arrExamTypeIdLst)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrExamTypeIdLst, true);
 string strWhereCond = string.Format("ExamTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrExamTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsExamTypeEN> GetObjLstByExamTypeIdLst_Cache(List<string> arrExamTypeIdLst)
{
string strKey = string.Format("{0}", clsExamTypeEN._CurrTabName_S);
List<clsExamTypeEN> arrExamTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsExamTypeEN> arrExamTypeObjLst_Sel =
arrExamTypeObjLst_Cache
.Where(x => arrExamTypeIdLst.Contains(x.ExamTypeId));
return arrExamTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExamTypeEN> GetObjLst(string strWhereCond)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
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
public static List<clsExamTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objExamType_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsExamTypeEN> GetSubObjLst_Cache(clsExamTypeEN objExamType_Cond)
{
List<clsExamTypeEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsExamTypeEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conExamType.AttributeName)
{
if (objExamType_Cond.IsUpdated(strFldName) == false) continue;
if (objExamType_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objExamType_Cond[strFldName].ToString());
}
else
{
if (objExamType_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExamType_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objExamType_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExamType_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExamType_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExamType_Cond[strFldName]));
}
}
}
return arrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExamTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
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
public static List<clsExamTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
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
List<clsExamTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsExamTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsExamTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsExamTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
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
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
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
public static List<clsExamTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsExamTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsExamTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
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
public static List<clsExamTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsExamTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsExamTypeEN> arrObjLst = new List<clsExamTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExamTypeEN objExamTypeEN = new clsExamTypeEN();
try
{
objExamTypeEN.ExamTypeId = objRow[conExamType.ExamTypeId].ToString().Trim(); //考试类型Id
objExamTypeEN.ExamTypeName = objRow[conExamType.ExamTypeName].ToString().Trim(); //考试类型名
objExamTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conExamType._IsDeleted] == DBNull.Value ? null : objRow[conExamType._IsDeleted].ToString().Trim()); //是否删除
objExamTypeEN._DeletedDate = objRow[conExamType._DeletedDate] == DBNull.Value ? null : objRow[conExamType._DeletedDate].ToString().Trim(); //删除日期
objExamTypeEN.Memo = objRow[conExamType.Memo] == DBNull.Value ? null : objRow[conExamType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExamTypeEN.ExamTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExamTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objExamTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetExamType(ref clsExamTypeEN objExamTypeEN)
{
bool bolResult = ExamTypeDA.GetExamType(ref objExamTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strExamTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExamTypeEN GetObjByExamTypeId(string strExamTypeId)
{
if (strExamTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strExamTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strExamTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strExamTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsExamTypeEN objExamTypeEN = ExamTypeDA.GetObjByExamTypeId(strExamTypeId);
return objExamTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsExamTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsExamTypeEN objExamTypeEN = ExamTypeDA.GetFirstObj(strWhereCond);
 return objExamTypeEN;
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
public static clsExamTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsExamTypeEN objExamTypeEN = ExamTypeDA.GetObjByDataRow(objRow);
 return objExamTypeEN;
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
public static clsExamTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsExamTypeEN objExamTypeEN = ExamTypeDA.GetObjByDataRow(objRow);
 return objExamTypeEN;
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
 /// <param name = "strExamTypeId">所给的关键字</param>
 /// <param name = "lstExamTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExamTypeEN GetObjByExamTypeIdFromList(string strExamTypeId, List<clsExamTypeEN> lstExamTypeObjLst)
{
foreach (clsExamTypeEN objExamTypeEN in lstExamTypeObjLst)
{
if (objExamTypeEN.ExamTypeId == strExamTypeId)
{
return objExamTypeEN;
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
 string strMaxExamTypeId;
 try
 {
 strMaxExamTypeId = clsExamTypeDA.GetMaxStrId();
 return strMaxExamTypeId;
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
 string strExamTypeId;
 try
 {
 strExamTypeId = new clsExamTypeDA().GetFirstID(strWhereCond);
 return strExamTypeId;
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
 arrList = ExamTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ExamTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strExamTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strExamTypeId)
{
if (string.IsNullOrEmpty(strExamTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strExamTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ExamTypeDA.IsExist(strExamTypeId);
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
 bolIsExist = clsExamTypeDA.IsExistTable();
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
 bolIsExist = ExamTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsExamTypeEN objExamTypeEN)
{
if (objExamTypeEN.CheckUniqueness_ExamTypeName() == false)
{
var strMsg = string.Format("记录已经存在!考试类型名 = [{0}]的数据已经存在!(in clsExamTypeBL.AddNewRecordBySql2)", objExamTypeEN.ExamTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true || clsExamTypeBL.IsExist(objExamTypeEN.ExamTypeId) == true)
 {
     objExamTypeEN.ExamTypeId = clsExamTypeBL.GetMaxStrId_S();
 }
bool bolResult = ExamTypeDA.AddNewRecordBySQL2(objExamTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsExamTypeEN objExamTypeEN)
{
if (objExamTypeEN.CheckUniqueness_ExamTypeName() == false)
{
var strMsg = string.Format("记录已经存在!考试类型名 = [{0}]的数据已经存在!(in clsExamTypeBL.AddNewRecordBySql2WithReturnKey)", objExamTypeEN.ExamTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true || clsExamTypeBL.IsExist(objExamTypeEN.ExamTypeId) == true)
 {
     objExamTypeEN.ExamTypeId = clsExamTypeBL.GetMaxStrId_S();
 }
string strKey = ExamTypeDA.AddNewRecordBySQL2WithReturnKey(objExamTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsExamTypeEN objExamTypeEN)
{
try
{
bool bolResult = ExamTypeDA.Update(objExamTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "objExamTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsExamTypeEN objExamTypeEN)
{
 if (string.IsNullOrEmpty(objExamTypeEN.ExamTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ExamTypeDA.UpdateBySql2(objExamTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExamTypeBL.ReFreshCache();

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
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
 /// <param name = "strExamTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strExamTypeId)
{
try
{
 clsExamTypeEN objExamTypeEN = clsExamTypeBL.GetObjByExamTypeId(strExamTypeId);

if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(objExamTypeEN.ExamTypeId, "SetUpdDate");
}
if (objExamTypeEN != null)
{
int intRecNum = ExamTypeDA.DelRecord(strExamTypeId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strExamTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strExamTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsExamTypeDA.GetSpecSQLObj();
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
//删除与表:[ExamType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conExamType.ExamTypeId,
//strExamTypeId);
//        clsExamTypeBL.DelExamTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExamTypeBL.DelRecord(strExamTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExamTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strExamTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// 功能:根据标志删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DelRecordBySign)
 /// </summary>
 /// <param name = "arrExamTypeId">给定的关键字列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecordBySign(List<string> arrExamTypeId)
{
try
{
if (clsExamTypeBL.relatedActions != null)
{
foreach (var strExamTypeId in arrExamTypeId)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(strExamTypeId, "UpdRelaTabDate");
}
}
int intRecNum_Total = 0;
arrExamTypeId.ForEach((x) =>
{
int intRecNum = ExamTypeDA.DelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000077)根据标志删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:恢复被删除的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_UnDelRecordBySign)
 /// </summary>
 /// <param name = "arrExamTypeId">给定的关键字列表</param>
 /// <returns>返回恢复删除的记录数</returns>
public static int UnDelRecordBySign(List<string> arrExamTypeId)
{
try
{
int intRecNum_Total = 0;
arrExamTypeId.ForEach((x) =>
{
int intRecNum = ExamTypeDA.UnDelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
if (clsExamTypeBL.relatedActions != null)
{
foreach (var strExamTypeId in arrExamTypeId)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(strExamTypeId, "UpdRelaTabDate");
}
}
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000078)恢复被删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strExamTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strExamTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsExamTypeBL.relatedActions != null)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(strExamTypeId, "UpdRelaTabDate");
}
bool bolResult = ExamTypeDA.DelRecord(strExamTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrExamTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelExamTypes(List<string> arrExamTypeIdLst)
{
if (arrExamTypeIdLst.Count == 0) return 0;
try
{
if (clsExamTypeBL.relatedActions != null)
{
foreach (var strExamTypeId in arrExamTypeIdLst)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(strExamTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = ExamTypeDA.DelExamType(arrExamTypeIdLst);
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
public static int DelExamTypesByCond(string strWhereCond)
{
try
{
if (clsExamTypeBL.relatedActions != null)
{
List<string> arrExamTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strExamTypeId in arrExamTypeId)
{
clsExamTypeBL.relatedActions.UpdRelaTabDate(strExamTypeId, "UpdRelaTabDate");
}
}
int intRecNum = ExamTypeDA.DelExamType(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[ExamType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strExamTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strExamTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsExamTypeDA.GetSpecSQLObj();
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
//删除与表:[ExamType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExamTypeBL.DelRecord(strExamTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExamTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strExamTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objExamTypeENS">源对象</param>
 /// <param name = "objExamTypeENT">目标对象</param>
 public static void CopyTo(clsExamTypeEN objExamTypeENS, clsExamTypeEN objExamTypeENT)
{
try
{
objExamTypeENT.ExamTypeId = objExamTypeENS.ExamTypeId; //考试类型Id
objExamTypeENT.ExamTypeName = objExamTypeENS.ExamTypeName; //考试类型名
objExamTypeENT._IsDeleted = objExamTypeENS._IsDeleted; //是否删除
objExamTypeENT._DeletedDate = objExamTypeENS._DeletedDate; //删除日期
objExamTypeENT.Memo = objExamTypeENS.Memo; //备注
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
 /// <param name = "objExamTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsExamTypeEN objExamTypeEN)
{
try
{
objExamTypeEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objExamTypeEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conExamType.ExamTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objExamTypeEN.ExamTypeId = objExamTypeEN.ExamTypeId; //考试类型Id
}
if (arrFldSet.Contains(conExamType.ExamTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objExamTypeEN.ExamTypeName = objExamTypeEN.ExamTypeName; //考试类型名
}
if (arrFldSet.Contains(conExamType._IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objExamTypeEN._IsDeleted = objExamTypeEN._IsDeleted; //是否删除
}
if (arrFldSet.Contains(conExamType._DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objExamTypeEN._DeletedDate = objExamTypeEN._DeletedDate == "[null]" ? null :  objExamTypeEN._DeletedDate; //删除日期
}
if (arrFldSet.Contains(conExamType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objExamTypeEN.Memo = objExamTypeEN.Memo == "[null]" ? null :  objExamTypeEN.Memo; //备注
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objExamTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsExamTypeEN objExamTypeEN)
{
try
{
if (objExamTypeEN._DeletedDate == "[null]") objExamTypeEN._DeletedDate = null; //删除日期
if (objExamTypeEN.Memo == "[null]") objExamTypeEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsExamTypeEN objExamTypeEN)
{
 ExamTypeDA.CheckPropertyNew(objExamTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsExamTypeEN objExamTypeEN)
{
 ExamTypeDA.CheckProperty4Condition(objExamTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ExamTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conExamType.ExamTypeId); 
List<clsExamTypeEN> arrObjLst = clsExamTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsExamTypeEN objExamTypeEN = new clsExamTypeEN()
{
ExamTypeId = "0",
ExamTypeName = "选[考试类型]..."
};
arrObjLst.Insert(0, objExamTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conExamType.ExamTypeId;
objComboBox.DisplayMember = conExamType.ExamTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ExamTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[考试类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conExamType.ExamTypeId); 
IEnumerable<clsExamTypeEN> arrObjLst = clsExamTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conExamType.ExamTypeId;
objDDL.DataTextField = conExamType.ExamTypeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunction_Cache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ExamTypeId_Cache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[考试类型]...","0");
List<clsExamTypeEN> arrExamTypeObjLst = GetAllExamTypeObjLst_Cache(); 
objDDL.DataValueField = conExamType.ExamTypeId;
objDDL.DataTextField = conExamType.ExamTypeName;
objDDL.DataSource = arrExamTypeObjLst;
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
if (clsExamTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExamTypeBL没有刷新缓存机制(clsExamTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ExamTypeId");
//if (arrExamTypeObjLst_Cache == null)
//{
//arrExamTypeObjLst_Cache = ExamTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strExamTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExamTypeEN GetObjByExamTypeId_Cache(string strExamTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsExamTypeEN._CurrTabName_S);
List<clsExamTypeEN> arrExamTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsExamTypeEN> arrExamTypeObjLst_Sel =
arrExamTypeObjLst_Cache
.Where(x=> x.ExamTypeId == strExamTypeId 
);
if (arrExamTypeObjLst_Sel.Count() == 0)
{
   clsExamTypeEN obj = clsExamTypeBL.GetObjByExamTypeId(strExamTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrExamTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strExamTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetExamTypeNameByExamTypeId_Cache(string strExamTypeId)
{
if (string.IsNullOrEmpty(strExamTypeId) == true) return "";
//获取缓存中的对象列表
clsExamTypeEN objExamType = GetObjByExamTypeId_Cache(strExamTypeId);
if (objExamType == null) return "";
return objExamType.ExamTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strExamTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByExamTypeId_Cache(string strExamTypeId)
{
if (string.IsNullOrEmpty(strExamTypeId) == true) return "";
//获取缓存中的对象列表
clsExamTypeEN objExamType = GetObjByExamTypeId_Cache(strExamTypeId);
if (objExamType == null) return "";
return objExamType.ExamTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExamTypeEN> GetAllExamTypeObjLst_Cache()
{
//获取缓存中的对象列表
List<clsExamTypeEN> arrExamTypeObjLst_Cache = GetObjLst_Cache(); 
return arrExamTypeObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExamTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsExamTypeEN._CurrTabName_S);
List<clsExamTypeEN> arrExamTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrExamTypeObjLst_Cache;
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
string strKey = string.Format("{0}", clsExamTypeEN._CurrTabName_S);
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
if (clsExamTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsExamTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsExamTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--ExamType(考试类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objExamTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckExamTypeUniqueness(clsExamTypeEN objExamTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objExamTypeEN == null) return true;
if (objExamTypeEN.ExamTypeId == null || objExamTypeEN.ExamTypeId == "")
{
bolIsUniqueness = ExamTypeDA.CheckExamTypeUniqueness();
}
else
{
bolIsUniqueness = ExamTypeDA.CheckExamTypeUniqueness(objExamTypeEN.ExamTypeId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ExamType(考试类型)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objExamTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_ExamTypeName(clsExamTypeEN objExamTypeEN)
{
//检测记录是否存在
string strResult = ExamTypeDA.GetUniCondStr_ExamTypeName(objExamTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-03-11
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strExamTypeId)
{
if (strInFldName != conExamType.ExamTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conExamType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conExamType.AttributeName));
throw new Exception(strMsg);
}
var objExamType = clsExamTypeBL.GetObjByExamTypeId_Cache(strExamTypeId);
if (objExamType == null) return "";
return objExamType[strOutFldName].ToString();
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
int intRecCount = clsExamTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsExamTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsExamTypeDA.GetRecCount();
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
int intRecCount = clsExamTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objExamType_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsExamTypeEN objExamType_Cond)
{
List<clsExamTypeEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsExamTypeEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conExamType.AttributeName)
{
if (objExamType_Cond.IsUpdated(strFldName) == false) continue;
if (objExamType_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objExamType_Cond[strFldName].ToString());
}
else
{
if (objExamType_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExamType_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objExamType_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objExamType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExamType_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExamType_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExamType_Cond[strFldName]));
}
}
}
return arrObjLst_Sel.Count();
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
 List<string> arrList = clsExamTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ExamTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ExamTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ExamTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsExamTypeDA.SetFldValue(clsExamTypeEN._CurrTabName_S, strFldName, fltValue, strWhereCond);
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
int intRecCount = ExamTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsExamTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsExamTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsExamTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ExamType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**考试类型Id*/ 
 strCreateTabCode.Append(" ExamTypeId char(2) primary key, "); 
 // /**考试类型名*/ 
 strCreateTabCode.Append(" ExamTypeName varchar(30) not Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" _IsDeleted bit Null, "); 
 // /**删除日期*/ 
 strCreateTabCode.Append(" _DeletedDate varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 考试类型(ExamType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4ExamType : clsCommFun4BL
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
clsExamTypeBL.ReFreshThisCache();
}
}

}