
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesGraphTypeBL
 表名:gs_KnowledgesGraphType(01120888)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:34
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
public static class  clsgs_KnowledgesGraphTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strGraphTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgesGraphTypeEN GetObj(this K_GraphTypeId_gs_KnowledgesGraphType myKey)
{
clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.GetObjByGraphTypeId(myKey.Value);
return objgs_KnowledgesGraphTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesGraphTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!图谱类型Id = [{0}]的数据已经存在!(in clsgs_KnowledgesGraphTypeBL.AddNewRecord)", objgs_KnowledgesGraphTypeEN.GraphTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true || clsgs_KnowledgesGraphTypeBL.IsExist(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
     objgs_KnowledgesGraphTypeEN.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.AddNewRecordBySQL2(objgs_KnowledgesGraphTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_KnowledgesGraphTypeBL.IsExist(objgs_KnowledgesGraphTypeEN.GraphTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_KnowledgesGraphTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesGraphTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(图谱类型Id(GraphTypeId)=[{0}])已经存在,不能重复!", objgs_KnowledgesGraphTypeEN.GraphTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true || clsgs_KnowledgesGraphTypeBL.IsExist(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
     objgs_KnowledgesGraphTypeEN.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_KnowledgesGraphTypeEN.AddNewRecord();
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesGraphTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!图谱类型Id = [{0}]的数据已经存在!(in clsgs_KnowledgesGraphTypeBL.AddNewRecordWithMaxId)", objgs_KnowledgesGraphTypeEN.GraphTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true || clsgs_KnowledgesGraphTypeBL.IsExist(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
     objgs_KnowledgesGraphTypeEN.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetMaxStrId_S();
 }
string strGraphTypeId = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesGraphTypeEN);
     objgs_KnowledgesGraphTypeEN.GraphTypeId = strGraphTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
}
return strGraphTypeId;
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesGraphTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!图谱类型Id = [{0}]的数据已经存在!(in clsgs_KnowledgesGraphTypeBL.AddNewRecordWithReturnKey)", objgs_KnowledgesGraphTypeEN.GraphTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true || clsgs_KnowledgesGraphTypeBL.IsExist(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
     objgs_KnowledgesGraphTypeEN.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetMaxStrId_S();
 }
string strKey = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesGraphTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphTypeEN SetGraphTypeId(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, string strGraphTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGraphTypeId, 2, congs_KnowledgesGraphType.GraphTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGraphTypeId, 2, congs_KnowledgesGraphType.GraphTypeId);
}
objgs_KnowledgesGraphTypeEN.GraphTypeId = strGraphTypeId; //图谱类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraphType.GraphTypeId) == false)
{
objgs_KnowledgesGraphTypeEN.dicFldComparisonOp.Add(congs_KnowledgesGraphType.GraphTypeId, strComparisonOp);
}
else
{
objgs_KnowledgesGraphTypeEN.dicFldComparisonOp[congs_KnowledgesGraphType.GraphTypeId] = strComparisonOp;
}
}
return objgs_KnowledgesGraphTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphTypeEN SetGraphTypeName(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, string strGraphTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGraphTypeName, 50, congs_KnowledgesGraphType.GraphTypeName);
}
objgs_KnowledgesGraphTypeEN.GraphTypeName = strGraphTypeName; //图谱类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraphType.GraphTypeName) == false)
{
objgs_KnowledgesGraphTypeEN.dicFldComparisonOp.Add(congs_KnowledgesGraphType.GraphTypeName, strComparisonOp);
}
else
{
objgs_KnowledgesGraphTypeEN.dicFldComparisonOp[congs_KnowledgesGraphType.GraphTypeName] = strComparisonOp;
}
}
return objgs_KnowledgesGraphTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphTypeEN SetMemo(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_KnowledgesGraphType.Memo);
}
objgs_KnowledgesGraphTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraphType.Memo) == false)
{
objgs_KnowledgesGraphTypeEN.dicFldComparisonOp.Add(congs_KnowledgesGraphType.Memo, strComparisonOp);
}
else
{
objgs_KnowledgesGraphTypeEN.dicFldComparisonOp[congs_KnowledgesGraphType.Memo] = strComparisonOp;
}
}
return objgs_KnowledgesGraphTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_KnowledgesGraphTypeEN.CheckPropertyNew();
clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeCond = new clsgs_KnowledgesGraphTypeEN();
string strCondition = objgs_KnowledgesGraphTypeCond
.SetGraphTypeId(objgs_KnowledgesGraphTypeEN.GraphTypeId, "<>")
.SetGraphTypeId(objgs_KnowledgesGraphTypeEN.GraphTypeId, "=")
.GetCombineCondition();
objgs_KnowledgesGraphTypeEN._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgesGraphTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(GraphTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_KnowledgesGraphTypeEN.Update();
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
 /// <param name = "objgs_KnowledgesGraphType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeCond = new clsgs_KnowledgesGraphTypeEN();
string strCondition = objgs_KnowledgesGraphTypeCond
.SetGraphTypeId(objgs_KnowledgesGraphType.GraphTypeId, "=")
.GetCombineCondition();
objgs_KnowledgesGraphType._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgesGraphTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_KnowledgesGraphType.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetFirstID_S(strCondition);
objgs_KnowledgesGraphType.UpdateWithCondition(strCondition);
}
else
{
objgs_KnowledgesGraphType.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetMaxStrId_S();
objgs_KnowledgesGraphType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.UpdateBySql2(objgs_KnowledgesGraphTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.UpdateBySql2(objgs_KnowledgesGraphTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.UpdateBySqlWithCondition(objgs_KnowledgesGraphTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.UpdateBySqlWithConditionTransaction(objgs_KnowledgesGraphTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "strGraphTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
try
{
int intRecNum = clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.DelRecord(objgs_KnowledgesGraphTypeEN.GraphTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeENS">源对象</param>
 /// <param name = "objgs_KnowledgesGraphTypeENT">目标对象</param>
 public static void CopyTo(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENS, clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENT)
{
try
{
objgs_KnowledgesGraphTypeENT.GraphTypeId = objgs_KnowledgesGraphTypeENS.GraphTypeId; //图谱类型Id
objgs_KnowledgesGraphTypeENT.GraphTypeName = objgs_KnowledgesGraphTypeENS.GraphTypeName; //图谱类型名称
objgs_KnowledgesGraphTypeENT.Memo = objgs_KnowledgesGraphTypeENS.Memo; //备注
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
 /// <param name = "objgs_KnowledgesGraphTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesGraphTypeEN:objgs_KnowledgesGraphTypeENT</returns>
 public static clsgs_KnowledgesGraphTypeEN CopyTo(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENS)
{
try
{
 clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENT = new clsgs_KnowledgesGraphTypeEN()
{
GraphTypeId = objgs_KnowledgesGraphTypeENS.GraphTypeId, //图谱类型Id
GraphTypeName = objgs_KnowledgesGraphTypeENS.GraphTypeName, //图谱类型名称
Memo = objgs_KnowledgesGraphTypeENS.Memo, //备注
};
 return objgs_KnowledgesGraphTypeENT;
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
public static void CheckPropertyNew(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
 clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.CheckPropertyNew(objgs_KnowledgesGraphTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
 clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.CheckProperty4Condition(objgs_KnowledgesGraphTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_KnowledgesGraphTypeCond.IsUpdated(congs_KnowledgesGraphType.GraphTypeId) == true)
{
string strComparisonOpGraphTypeId = objgs_KnowledgesGraphTypeCond.dicFldComparisonOp[congs_KnowledgesGraphType.GraphTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraphType.GraphTypeId, objgs_KnowledgesGraphTypeCond.GraphTypeId, strComparisonOpGraphTypeId);
}
if (objgs_KnowledgesGraphTypeCond.IsUpdated(congs_KnowledgesGraphType.GraphTypeName) == true)
{
string strComparisonOpGraphTypeName = objgs_KnowledgesGraphTypeCond.dicFldComparisonOp[congs_KnowledgesGraphType.GraphTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraphType.GraphTypeName, objgs_KnowledgesGraphTypeCond.GraphTypeName, strComparisonOpGraphTypeName);
}
if (objgs_KnowledgesGraphTypeCond.IsUpdated(congs_KnowledgesGraphType.Memo) == true)
{
string strComparisonOpMemo = objgs_KnowledgesGraphTypeCond.dicFldComparisonOp[congs_KnowledgesGraphType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraphType.Memo, objgs_KnowledgesGraphTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_KnowledgesGraphType(知识点图谱类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:GraphTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgesGraphTypeEN == null) return true;
if (objgs_KnowledgesGraphTypeEN.GraphTypeId == null || objgs_KnowledgesGraphTypeEN.GraphTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GraphTypeId = '{0}'", objgs_KnowledgesGraphTypeEN.GraphTypeId);
if (clsgs_KnowledgesGraphTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("GraphTypeId !=  '{0}'", objgs_KnowledgesGraphTypeEN.GraphTypeId);
 sbCondition.AppendFormat(" and GraphTypeId = '{0}'", objgs_KnowledgesGraphTypeEN.GraphTypeId);
if (clsgs_KnowledgesGraphTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_KnowledgesGraphType(知识点图谱类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:GraphTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgesGraphTypeEN == null) return "";
if (objgs_KnowledgesGraphTypeEN.GraphTypeId == null || objgs_KnowledgesGraphTypeEN.GraphTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GraphTypeId = '{0}'", objgs_KnowledgesGraphTypeEN.GraphTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("GraphTypeId !=  '{0}'", objgs_KnowledgesGraphTypeEN.GraphTypeId);
 sbCondition.AppendFormat(" and GraphTypeId = '{0}'", objgs_KnowledgesGraphTypeEN.GraphTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_KnowledgesGraphType
{
public virtual bool UpdRelaTabDate(string strGraphTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点图谱类型(gs_KnowledgesGraphType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_KnowledgesGraphTypeBL
{
public static RelatedActions_gs_KnowledgesGraphType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_KnowledgesGraphTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_KnowledgesGraphTypeDA gs_KnowledgesGraphTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_KnowledgesGraphTypeDA();
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
 public clsgs_KnowledgesGraphTypeBL()
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
if (string.IsNullOrEmpty(clsgs_KnowledgesGraphTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_KnowledgesGraphTypeEN._ConnectString);
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
public static DataTable GetDataTable_gs_KnowledgesGraphType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_KnowledgesGraphTypeDA.GetDataTable_gs_KnowledgesGraphType(strWhereCond);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTable(strWhereCond);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTable_Top(objTopPara);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_KnowledgesGraphTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrGraphTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstByGraphTypeIdLst(List<string> arrGraphTypeIdLst)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrGraphTypeIdLst, true);
 string strWhereCond = string.Format("GraphTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrGraphTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_KnowledgesGraphTypeEN> GetObjLstByGraphTypeIdLstCache(List<string> arrGraphTypeIdLst)
{
string strKey = string.Format("{0}", clsgs_KnowledgesGraphTypeEN._CurrTabName);
List<clsgs_KnowledgesGraphTypeEN> arrgs_KnowledgesGraphTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgesGraphTypeEN> arrgs_KnowledgesGraphTypeObjLst_Sel =
arrgs_KnowledgesGraphTypeObjLstCache
.Where(x => arrGraphTypeIdLst.Contains(x.GraphTypeId));
return arrgs_KnowledgesGraphTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLst(string strWhereCond)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
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
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_KnowledgesGraphTypeEN> GetSubObjLstCache(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeCond)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgesGraphTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgesGraphType.AttributeName)
{
if (objgs_KnowledgesGraphTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgesGraphTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphTypeCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgesGraphTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgesGraphTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgesGraphTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphTypeCond[strFldName]));
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
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
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
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
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
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesGraphTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_KnowledgesGraphTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
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
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
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
public static List<clsgs_KnowledgesGraphTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
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
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLst = new List<clsgs_KnowledgesGraphTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN();
try
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objRow[congs_KnowledgesGraphType.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphTypeEN.GraphTypeName = objRow[congs_KnowledgesGraphType.GraphTypeName] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.GraphTypeName].ToString().Trim(); //图谱类型名称
objgs_KnowledgesGraphTypeEN.Memo = objRow[congs_KnowledgesGraphType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraphType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphTypeEN.GraphTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_KnowledgesGraphType(ref clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
bool bolResult = gs_KnowledgesGraphTypeDA.Getgs_KnowledgesGraphType(ref objgs_KnowledgesGraphTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strGraphTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgesGraphTypeEN GetObjByGraphTypeId(string strGraphTypeId)
{
if (strGraphTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strGraphTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strGraphTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strGraphTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = gs_KnowledgesGraphTypeDA.GetObjByGraphTypeId(strGraphTypeId);
return objgs_KnowledgesGraphTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_KnowledgesGraphTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = gs_KnowledgesGraphTypeDA.GetFirstObj(strWhereCond);
 return objgs_KnowledgesGraphTypeEN;
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
public static clsgs_KnowledgesGraphTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = gs_KnowledgesGraphTypeDA.GetObjByDataRow(objRow);
 return objgs_KnowledgesGraphTypeEN;
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
public static clsgs_KnowledgesGraphTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = gs_KnowledgesGraphTypeDA.GetObjByDataRow(objRow);
 return objgs_KnowledgesGraphTypeEN;
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
 /// <param name = "strGraphTypeId">所给的关键字</param>
 /// <param name = "lstgs_KnowledgesGraphTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgesGraphTypeEN GetObjByGraphTypeIdFromList(string strGraphTypeId, List<clsgs_KnowledgesGraphTypeEN> lstgs_KnowledgesGraphTypeObjLst)
{
foreach (clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN in lstgs_KnowledgesGraphTypeObjLst)
{
if (objgs_KnowledgesGraphTypeEN.GraphTypeId == strGraphTypeId)
{
return objgs_KnowledgesGraphTypeEN;
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
 string strMaxGraphTypeId;
 try
 {
 strMaxGraphTypeId = clsgs_KnowledgesGraphTypeDA.GetMaxStrId();
 return strMaxGraphTypeId;
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
 string strGraphTypeId;
 try
 {
 strGraphTypeId = new clsgs_KnowledgesGraphTypeDA().GetFirstID(strWhereCond);
 return strGraphTypeId;
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
 arrList = gs_KnowledgesGraphTypeDA.GetID(strWhereCond);
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
bool bolIsExist = gs_KnowledgesGraphTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strGraphTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strGraphTypeId)
{
if (string.IsNullOrEmpty(strGraphTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strGraphTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_KnowledgesGraphTypeDA.IsExist(strGraphTypeId);
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
 bolIsExist = clsgs_KnowledgesGraphTypeDA.IsExistTable();
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
 bolIsExist = gs_KnowledgesGraphTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesGraphTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!图谱类型Id = [{0}]的数据已经存在!(in clsgs_KnowledgesGraphTypeBL.AddNewRecordBySql2)", objgs_KnowledgesGraphTypeEN.GraphTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true || clsgs_KnowledgesGraphTypeBL.IsExist(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
     objgs_KnowledgesGraphTypeEN.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetMaxStrId_S();
 }
bool bolResult = gs_KnowledgesGraphTypeDA.AddNewRecordBySQL2(objgs_KnowledgesGraphTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesGraphTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!图谱类型Id = [{0}]的数据已经存在!(in clsgs_KnowledgesGraphTypeBL.AddNewRecordBySql2WithReturnKey)", objgs_KnowledgesGraphTypeEN.GraphTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true || clsgs_KnowledgesGraphTypeBL.IsExist(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
     objgs_KnowledgesGraphTypeEN.GraphTypeId = clsgs_KnowledgesGraphTypeBL.GetMaxStrId_S();
 }
string strKey = gs_KnowledgesGraphTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesGraphTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
try
{
bool bolResult = gs_KnowledgesGraphTypeDA.Update(objgs_KnowledgesGraphTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphTypeEN.GraphTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_KnowledgesGraphTypeDA.UpdateBySql2(objgs_KnowledgesGraphTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphTypeBL.ReFreshCache();

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
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
 /// <param name = "strGraphTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strGraphTypeId)
{
try
{
 clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = clsgs_KnowledgesGraphTypeBL.GetObjByGraphTypeId(strGraphTypeId);

if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphTypeEN.GraphTypeId, "SetUpdDate");
}
if (objgs_KnowledgesGraphTypeEN != null)
{
int intRecNum = gs_KnowledgesGraphTypeDA.DelRecord(strGraphTypeId);
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
/// <param name="strGraphTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strGraphTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgesGraphTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgesGraphType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_KnowledgesGraphType.GraphTypeId,
//strGraphTypeId);
//        clsgs_KnowledgesGraphTypeBL.Delgs_KnowledgesGraphTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgesGraphTypeBL.DelRecord(strGraphTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgesGraphTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGraphTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strGraphTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strGraphTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(strGraphTypeId, "UpdRelaTabDate");
}
bool bolResult = gs_KnowledgesGraphTypeDA.DelRecord(strGraphTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrGraphTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_KnowledgesGraphTypes(List<string> arrGraphTypeIdLst)
{
if (arrGraphTypeIdLst.Count == 0) return 0;
try
{
if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
foreach (var strGraphTypeId in arrGraphTypeIdLst)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(strGraphTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_KnowledgesGraphTypeDA.Delgs_KnowledgesGraphType(arrGraphTypeIdLst);
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
public static int Delgs_KnowledgesGraphTypesByCond(string strWhereCond)
{
try
{
if (clsgs_KnowledgesGraphTypeBL.relatedActions != null)
{
List<string> arrGraphTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strGraphTypeId in arrGraphTypeId)
{
clsgs_KnowledgesGraphTypeBL.relatedActions.UpdRelaTabDate(strGraphTypeId, "UpdRelaTabDate");
}
}
int intRecNum = gs_KnowledgesGraphTypeDA.Delgs_KnowledgesGraphType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_KnowledgesGraphType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strGraphTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strGraphTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgesGraphTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgesGraphType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgesGraphTypeBL.DelRecord(strGraphTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgesGraphTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGraphTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_KnowledgesGraphTypeENS">源对象</param>
 /// <param name = "objgs_KnowledgesGraphTypeENT">目标对象</param>
 public static void CopyTo(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENS, clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENT)
{
try
{
objgs_KnowledgesGraphTypeENT.GraphTypeId = objgs_KnowledgesGraphTypeENS.GraphTypeId; //图谱类型Id
objgs_KnowledgesGraphTypeENT.GraphTypeName = objgs_KnowledgesGraphTypeENS.GraphTypeName; //图谱类型名称
objgs_KnowledgesGraphTypeENT.Memo = objgs_KnowledgesGraphTypeENS.Memo; //备注
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
try
{
objgs_KnowledgesGraphTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_KnowledgesGraphTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_KnowledgesGraphType.GraphTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphTypeEN.GraphTypeId = objgs_KnowledgesGraphTypeEN.GraphTypeId; //图谱类型Id
}
if (arrFldSet.Contains(congs_KnowledgesGraphType.GraphTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphTypeEN.GraphTypeName = objgs_KnowledgesGraphTypeEN.GraphTypeName == "[null]" ? null :  objgs_KnowledgesGraphTypeEN.GraphTypeName; //图谱类型名称
}
if (arrFldSet.Contains(congs_KnowledgesGraphType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphTypeEN.Memo = objgs_KnowledgesGraphTypeEN.Memo == "[null]" ? null :  objgs_KnowledgesGraphTypeEN.Memo; //备注
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
 /// <param name = "objgs_KnowledgesGraphTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
try
{
if (objgs_KnowledgesGraphTypeEN.GraphTypeName == "[null]") objgs_KnowledgesGraphTypeEN.GraphTypeName = null; //图谱类型名称
if (objgs_KnowledgesGraphTypeEN.Memo == "[null]") objgs_KnowledgesGraphTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
 gs_KnowledgesGraphTypeDA.CheckPropertyNew(objgs_KnowledgesGraphTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
 gs_KnowledgesGraphTypeDA.CheckProperty4Condition(objgs_KnowledgesGraphTypeEN);
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
if (clsgs_KnowledgesGraphTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_KnowledgesGraphTypeBL没有刷新缓存机制(clsgs_KnowledgesGraphTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by GraphTypeId");
//if (arrgs_KnowledgesGraphTypeObjLstCache == null)
//{
//arrgs_KnowledgesGraphTypeObjLstCache = gs_KnowledgesGraphTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strGraphTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgesGraphTypeEN GetObjByGraphTypeIdCache(string strGraphTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_KnowledgesGraphTypeEN._CurrTabName);
List<clsgs_KnowledgesGraphTypeEN> arrgs_KnowledgesGraphTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgesGraphTypeEN> arrgs_KnowledgesGraphTypeObjLst_Sel =
arrgs_KnowledgesGraphTypeObjLstCache
.Where(x=> x.GraphTypeId == strGraphTypeId 
);
if (arrgs_KnowledgesGraphTypeObjLst_Sel.Count() == 0)
{
   clsgs_KnowledgesGraphTypeEN obj = clsgs_KnowledgesGraphTypeBL.GetObjByGraphTypeId(strGraphTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_KnowledgesGraphTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgesGraphTypeEN> GetAllgs_KnowledgesGraphTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_KnowledgesGraphTypeEN> arrgs_KnowledgesGraphTypeObjLstCache = GetObjLstCache(); 
return arrgs_KnowledgesGraphTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgesGraphTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_KnowledgesGraphTypeEN._CurrTabName);
List<clsgs_KnowledgesGraphTypeEN> arrgs_KnowledgesGraphTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_KnowledgesGraphTypeObjLstCache;
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
string strKey = string.Format("{0}", clsgs_KnowledgesGraphTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_KnowledgesGraphTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_KnowledgesGraphTypeEN._RefreshTimeLst.Count == 0) return "";
return clsgs_KnowledgesGraphTypeEN._RefreshTimeLst[clsgs_KnowledgesGraphTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_KnowledgesGraphTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_KnowledgesGraphTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_KnowledgesGraphTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_KnowledgesGraphTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_KnowledgesGraphType(知识点图谱类型)
 /// 唯一性条件:GraphTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN)
{
//检测记录是否存在
string strResult = gs_KnowledgesGraphTypeDA.GetUniCondStr(objgs_KnowledgesGraphTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strGraphTypeId)
{
if (strInFldName != congs_KnowledgesGraphType.GraphTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_KnowledgesGraphType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_KnowledgesGraphType.AttributeName));
throw new Exception(strMsg);
}
var objgs_KnowledgesGraphType = clsgs_KnowledgesGraphTypeBL.GetObjByGraphTypeIdCache(strGraphTypeId);
if (objgs_KnowledgesGraphType == null) return "";
return objgs_KnowledgesGraphType[strOutFldName].ToString();
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
int intRecCount = clsgs_KnowledgesGraphTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_KnowledgesGraphTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_KnowledgesGraphTypeDA.GetRecCount();
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
int intRecCount = clsgs_KnowledgesGraphTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeCond)
{
List<clsgs_KnowledgesGraphTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgesGraphTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgesGraphType.AttributeName)
{
if (objgs_KnowledgesGraphTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgesGraphTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphTypeCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgesGraphTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgesGraphTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgesGraphTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgesGraphTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphTypeCond[strFldName]));
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
 List<string> arrList = clsgs_KnowledgesGraphTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgesGraphTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgesGraphTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_KnowledgesGraphTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphTypeDA.SetFldValue(clsgs_KnowledgesGraphTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_KnowledgesGraphTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_KnowledgesGraphType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**图谱类型Id*/ 
 strCreateTabCode.Append(" GraphTypeId char(2) primary key, "); 
 // /**图谱类型名称*/ 
 strCreateTabCode.Append(" GraphTypeName varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 知识点图谱类型(gs_KnowledgesGraphType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_KnowledgesGraphType : clsCommFun4BL
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
clsgs_KnowledgesGraphTypeBL.ReFreshThisCache();
}
}

}