
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_QuestionsTypeBL
 表名:qa_QuestionsType(01120752)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsqa_QuestionsTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionsTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_QuestionsTypeEN GetObj(this K_QuestionsTypeId_qa_QuestionsType myKey)
{
clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.GetObjByQuestionsTypeId(myKey.Value);
return objqa_QuestionsTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsqa_QuestionsTypeBL.IsExist(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objqa_QuestionsTypeEN.QuestionsTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_QuestionsTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!问题类型Id = [{0}]的数据已经存在!(in clsqa_QuestionsTypeBL.AddNewRecord)", objqa_QuestionsTypeEN.QuestionsTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.AddNewRecordBySQL2(objqa_QuestionsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsqa_QuestionsTypeBL.IsExist(objqa_QuestionsTypeEN.QuestionsTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objqa_QuestionsTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objqa_QuestionsTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(问题类型Id(QuestionsTypeId)=[{0}])已经存在,不能重复!", objqa_QuestionsTypeEN.QuestionsTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objqa_QuestionsTypeEN.AddNewRecord();
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
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsqa_QuestionsTypeBL.IsExist(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objqa_QuestionsTypeEN.QuestionsTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_QuestionsTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!问题类型Id = [{0}]的数据已经存在!(in clsqa_QuestionsTypeBL.AddNewRecordWithReturnKey)", objqa_QuestionsTypeEN.QuestionsTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.AddNewRecordBySQL2WithReturnKey(objqa_QuestionsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_QuestionsTypeEN SetQuestionsTypeId(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, string strQuestionsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, conqa_QuestionsType.QuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, conqa_QuestionsType.QuestionsTypeId);
}
objqa_QuestionsTypeEN.QuestionsTypeId = strQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsTypeEN.dicFldComparisonOp.ContainsKey(conqa_QuestionsType.QuestionsTypeId) == false)
{
objqa_QuestionsTypeEN.dicFldComparisonOp.Add(conqa_QuestionsType.QuestionsTypeId, strComparisonOp);
}
else
{
objqa_QuestionsTypeEN.dicFldComparisonOp[conqa_QuestionsType.QuestionsTypeId] = strComparisonOp;
}
}
return objqa_QuestionsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_QuestionsTypeEN SetQuestionsTypeName(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, string strQuestionsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsTypeName, conqa_QuestionsType.QuestionsTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, conqa_QuestionsType.QuestionsTypeName);
}
objqa_QuestionsTypeEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsTypeEN.dicFldComparisonOp.ContainsKey(conqa_QuestionsType.QuestionsTypeName) == false)
{
objqa_QuestionsTypeEN.dicFldComparisonOp.Add(conqa_QuestionsType.QuestionsTypeName, strComparisonOp);
}
else
{
objqa_QuestionsTypeEN.dicFldComparisonOp[conqa_QuestionsType.QuestionsTypeName] = strComparisonOp;
}
}
return objqa_QuestionsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_QuestionsTypeEN SetQuestionsTypeEnName(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, string strQuestionsTypeEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeEnName, 50, conqa_QuestionsType.QuestionsTypeEnName);
}
objqa_QuestionsTypeEN.QuestionsTypeEnName = strQuestionsTypeEnName; //问题类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsTypeEN.dicFldComparisonOp.ContainsKey(conqa_QuestionsType.QuestionsTypeEnName) == false)
{
objqa_QuestionsTypeEN.dicFldComparisonOp.Add(conqa_QuestionsType.QuestionsTypeEnName, strComparisonOp);
}
else
{
objqa_QuestionsTypeEN.dicFldComparisonOp[conqa_QuestionsType.QuestionsTypeEnName] = strComparisonOp;
}
}
return objqa_QuestionsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_QuestionsTypeEN SetMemo(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_QuestionsType.Memo);
}
objqa_QuestionsTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_QuestionsTypeEN.dicFldComparisonOp.ContainsKey(conqa_QuestionsType.Memo) == false)
{
objqa_QuestionsTypeEN.dicFldComparisonOp.Add(conqa_QuestionsType.Memo, strComparisonOp);
}
else
{
objqa_QuestionsTypeEN.dicFldComparisonOp[conqa_QuestionsType.Memo] = strComparisonOp;
}
}
return objqa_QuestionsTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objqa_QuestionsTypeEN.CheckPropertyNew();
clsqa_QuestionsTypeEN objqa_QuestionsTypeCond = new clsqa_QuestionsTypeEN();
string strCondition = objqa_QuestionsTypeCond
.SetQuestionsTypeId(objqa_QuestionsTypeEN.QuestionsTypeId, "<>")
.SetQuestionsTypeId(objqa_QuestionsTypeEN.QuestionsTypeId, "=")
.GetCombineCondition();
objqa_QuestionsTypeEN._IsCheckProperty = true;
bool bolIsExist = clsqa_QuestionsTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionsTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objqa_QuestionsTypeEN.Update();
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
 /// <param name = "objqa_QuestionsType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsqa_QuestionsTypeEN objqa_QuestionsType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsqa_QuestionsTypeEN objqa_QuestionsTypeCond = new clsqa_QuestionsTypeEN();
string strCondition = objqa_QuestionsTypeCond
.SetQuestionsTypeId(objqa_QuestionsType.QuestionsTypeId, "=")
.GetCombineCondition();
objqa_QuestionsType._IsCheckProperty = true;
bool bolIsExist = clsqa_QuestionsTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objqa_QuestionsType.QuestionsTypeId = clsqa_QuestionsTypeBL.GetFirstID_S(strCondition);
objqa_QuestionsType.UpdateWithCondition(strCondition);
}
else
{
objqa_QuestionsType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
 if (string.IsNullOrEmpty(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.UpdateBySql2(objqa_QuestionsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.UpdateBySql2(objqa_QuestionsTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.UpdateBySqlWithCondition(objqa_QuestionsTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.UpdateBySqlWithConditionTransaction(objqa_QuestionsTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "strQuestionsTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
try
{
int intRecNum = clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.DelRecord(objqa_QuestionsTypeEN.QuestionsTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeENS">源对象</param>
 /// <param name = "objqa_QuestionsTypeENT">目标对象</param>
 public static void CopyTo(this clsqa_QuestionsTypeEN objqa_QuestionsTypeENS, clsqa_QuestionsTypeEN objqa_QuestionsTypeENT)
{
try
{
objqa_QuestionsTypeENT.QuestionsTypeId = objqa_QuestionsTypeENS.QuestionsTypeId; //问题类型Id
objqa_QuestionsTypeENT.QuestionsTypeName = objqa_QuestionsTypeENS.QuestionsTypeName; //问题类型名称
objqa_QuestionsTypeENT.QuestionsTypeEnName = objqa_QuestionsTypeENS.QuestionsTypeEnName; //问题类型英文名
objqa_QuestionsTypeENT.Memo = objqa_QuestionsTypeENS.Memo; //备注
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
 /// <param name = "objqa_QuestionsTypeENS">源对象</param>
 /// <returns>目标对象=>clsqa_QuestionsTypeEN:objqa_QuestionsTypeENT</returns>
 public static clsqa_QuestionsTypeEN CopyTo(this clsqa_QuestionsTypeEN objqa_QuestionsTypeENS)
{
try
{
 clsqa_QuestionsTypeEN objqa_QuestionsTypeENT = new clsqa_QuestionsTypeEN()
{
QuestionsTypeId = objqa_QuestionsTypeENS.QuestionsTypeId, //问题类型Id
QuestionsTypeName = objqa_QuestionsTypeENS.QuestionsTypeName, //问题类型名称
QuestionsTypeEnName = objqa_QuestionsTypeENS.QuestionsTypeEnName, //问题类型英文名
Memo = objqa_QuestionsTypeENS.Memo, //备注
};
 return objqa_QuestionsTypeENT;
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
public static void CheckPropertyNew(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
 clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.CheckPropertyNew(objqa_QuestionsTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
 clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.CheckProperty4Condition(objqa_QuestionsTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_QuestionsTypeEN objqa_QuestionsTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_QuestionsTypeCond.IsUpdated(conqa_QuestionsType.QuestionsTypeId) == true)
{
string strComparisonOpQuestionsTypeId = objqa_QuestionsTypeCond.dicFldComparisonOp[conqa_QuestionsType.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_QuestionsType.QuestionsTypeId, objqa_QuestionsTypeCond.QuestionsTypeId, strComparisonOpQuestionsTypeId);
}
if (objqa_QuestionsTypeCond.IsUpdated(conqa_QuestionsType.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objqa_QuestionsTypeCond.dicFldComparisonOp[conqa_QuestionsType.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_QuestionsType.QuestionsTypeName, objqa_QuestionsTypeCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
if (objqa_QuestionsTypeCond.IsUpdated(conqa_QuestionsType.QuestionsTypeEnName) == true)
{
string strComparisonOpQuestionsTypeEnName = objqa_QuestionsTypeCond.dicFldComparisonOp[conqa_QuestionsType.QuestionsTypeEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_QuestionsType.QuestionsTypeEnName, objqa_QuestionsTypeCond.QuestionsTypeEnName, strComparisonOpQuestionsTypeEnName);
}
if (objqa_QuestionsTypeCond.IsUpdated(conqa_QuestionsType.Memo) == true)
{
string strComparisonOpMemo = objqa_QuestionsTypeCond.dicFldComparisonOp[conqa_QuestionsType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_QuestionsType.Memo, objqa_QuestionsTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--qa_QuestionsType(问题类型表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionsTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objqa_QuestionsTypeEN == null) return true;
if (objqa_QuestionsTypeEN.QuestionsTypeId == null || objqa_QuestionsTypeEN.QuestionsTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionsTypeId = '{0}'", objqa_QuestionsTypeEN.QuestionsTypeId);
if (clsqa_QuestionsTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QuestionsTypeId !=  '{0}'", objqa_QuestionsTypeEN.QuestionsTypeId);
 sbCondition.AppendFormat(" and QuestionsTypeId = '{0}'", objqa_QuestionsTypeEN.QuestionsTypeId);
if (clsqa_QuestionsTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--qa_QuestionsType(问题类型表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionsTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_QuestionsTypeEN == null) return "";
if (objqa_QuestionsTypeEN.QuestionsTypeId == null || objqa_QuestionsTypeEN.QuestionsTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionsTypeId = '{0}'", objqa_QuestionsTypeEN.QuestionsTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionsTypeId !=  '{0}'", objqa_QuestionsTypeEN.QuestionsTypeId);
 sbCondition.AppendFormat(" and QuestionsTypeId = '{0}'", objqa_QuestionsTypeEN.QuestionsTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_qa_QuestionsType
{
public virtual bool UpdRelaTabDate(string strQuestionsTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumqa_QuestionsType
{
 /// <summary>
 /// 论文答疑
 /// </summary>
public const string ThesisQuAndAnswer_01 = "01";
 /// <summary>
 /// 教师提问
 /// </summary>
public const string TeacherInquiry_02 = "02";
 /// <summary>
 /// 测试提问
 /// </summary>
public const string TestInquiry_03 = "03";
 /// <summary>
 /// Zx生僻字词
 /// </summary>
public const string UncommonWords_11 = "11";
 /// <summary>
 /// Zx课文疑问
 /// </summary>
public const string TextualQuestions_12 = "12";
 /// <summary>
 /// Zx基本问题
 /// </summary>
public const string FundamentalQuestions_15 = "15";
 /// <summary>
 /// Zx理解推理
 /// </summary>
public const string UnderstandingReasoning_16 = "16";
 /// <summary>
 /// Zx观点依据
 /// </summary>
public const string BasisOfOpinion_17 = "17";
 /// <summary>
 /// Zx阅读自问
 /// </summary>
public const string ReadingSelfQuestioning_18 = "18";
 /// <summary>
 /// Zx故事结尾
 /// </summary>
public const string StoryEnding_19 = "19";
 /// <summary>
 /// Zx思维导图
 /// </summary>
public const string MindMap_20 = "20";
 /// <summary>
 /// Zx相关资源
 /// </summary>
public const string RelatedResources_21 = "21";
}
 /// <summary>
 /// 问题类型表(qa_QuestionsType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsqa_QuestionsTypeBL
{
public static RelatedActions_qa_QuestionsType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsqa_QuestionsTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsqa_QuestionsTypeDA qa_QuestionsTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsqa_QuestionsTypeDA();
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
 public clsqa_QuestionsTypeBL()
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
if (string.IsNullOrEmpty(clsqa_QuestionsTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_QuestionsTypeEN._ConnectString);
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
public static DataTable GetDataTable_qa_QuestionsType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = qa_QuestionsTypeDA.GetDataTable_qa_QuestionsType(strWhereCond);
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
objDT = qa_QuestionsTypeDA.GetDataTable(strWhereCond);
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
objDT = qa_QuestionsTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = qa_QuestionsTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = qa_QuestionsTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = qa_QuestionsTypeDA.GetDataTable_Top(objTopPara);
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
objDT = qa_QuestionsTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = qa_QuestionsTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = qa_QuestionsTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionsTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsqa_QuestionsTypeEN> GetObjLstByQuestionsTypeIdLst(List<string> arrQuestionsTypeIdLst)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionsTypeIdLst, true);
 string strWhereCond = string.Format("QuestionsTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionsTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsqa_QuestionsTypeEN> GetObjLstByQuestionsTypeIdLstCache(List<string> arrQuestionsTypeIdLst)
{
string strKey = string.Format("{0}", clsqa_QuestionsTypeEN._CurrTabName);
List<clsqa_QuestionsTypeEN> arrqa_QuestionsTypeObjLstCache = GetObjLstCache();
IEnumerable <clsqa_QuestionsTypeEN> arrqa_QuestionsTypeObjLst_Sel =
arrqa_QuestionsTypeObjLstCache
.Where(x => arrQuestionsTypeIdLst.Contains(x.QuestionsTypeId));
return arrqa_QuestionsTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_QuestionsTypeEN> GetObjLst(string strWhereCond)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
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
public static List<clsqa_QuestionsTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsqa_QuestionsTypeEN> GetSubObjLstCache(clsqa_QuestionsTypeEN objqa_QuestionsTypeCond)
{
List<clsqa_QuestionsTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsqa_QuestionsTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_QuestionsType.AttributeName)
{
if (objqa_QuestionsTypeCond.IsUpdated(strFldName) == false) continue;
if (objqa_QuestionsTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_QuestionsTypeCond[strFldName].ToString());
}
else
{
if (objqa_QuestionsTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_QuestionsTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_QuestionsTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_QuestionsTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_QuestionsTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_QuestionsTypeCond[strFldName]));
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
public static List<clsqa_QuestionsTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
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
public static List<clsqa_QuestionsTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
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
List<clsqa_QuestionsTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsqa_QuestionsTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_QuestionsTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsqa_QuestionsTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
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
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
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
public static List<clsqa_QuestionsTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsqa_QuestionsTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsqa_QuestionsTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
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
public static List<clsqa_QuestionsTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_QuestionsTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsqa_QuestionsTypeEN> arrObjLst = new List<clsqa_QuestionsTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN();
try
{
objqa_QuestionsTypeEN.QuestionsTypeId = objRow[conqa_QuestionsType.QuestionsTypeId].ToString().Trim(); //问题类型Id
objqa_QuestionsTypeEN.QuestionsTypeName = objRow[conqa_QuestionsType.QuestionsTypeName].ToString().Trim(); //问题类型名称
objqa_QuestionsTypeEN.QuestionsTypeEnName = objRow[conqa_QuestionsType.QuestionsTypeEnName] == DBNull.Value ? null : objRow[conqa_QuestionsType.QuestionsTypeEnName].ToString().Trim(); //问题类型英文名
objqa_QuestionsTypeEN.Memo = objRow[conqa_QuestionsType.Memo] == DBNull.Value ? null : objRow[conqa_QuestionsType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_QuestionsTypeEN.QuestionsTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_QuestionsTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getqa_QuestionsType(ref clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
bool bolResult = qa_QuestionsTypeDA.Getqa_QuestionsType(ref objqa_QuestionsTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionsTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_QuestionsTypeEN GetObjByQuestionsTypeId(string strQuestionsTypeId)
{
if (strQuestionsTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionsTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionsTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionsTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = qa_QuestionsTypeDA.GetObjByQuestionsTypeId(strQuestionsTypeId);
return objqa_QuestionsTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsqa_QuestionsTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = qa_QuestionsTypeDA.GetFirstObj(strWhereCond);
 return objqa_QuestionsTypeEN;
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
public static clsqa_QuestionsTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = qa_QuestionsTypeDA.GetObjByDataRow(objRow);
 return objqa_QuestionsTypeEN;
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
public static clsqa_QuestionsTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = qa_QuestionsTypeDA.GetObjByDataRow(objRow);
 return objqa_QuestionsTypeEN;
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
 /// <param name = "strQuestionsTypeId">所给的关键字</param>
 /// <param name = "lstqa_QuestionsTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_QuestionsTypeEN GetObjByQuestionsTypeIdFromList(string strQuestionsTypeId, List<clsqa_QuestionsTypeEN> lstqa_QuestionsTypeObjLst)
{
foreach (clsqa_QuestionsTypeEN objqa_QuestionsTypeEN in lstqa_QuestionsTypeObjLst)
{
if (objqa_QuestionsTypeEN.QuestionsTypeId == strQuestionsTypeId)
{
return objqa_QuestionsTypeEN;
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
 string strQuestionsTypeId;
 try
 {
 strQuestionsTypeId = new clsqa_QuestionsTypeDA().GetFirstID(strWhereCond);
 return strQuestionsTypeId;
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
 arrList = qa_QuestionsTypeDA.GetID(strWhereCond);
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
bool bolIsExist = qa_QuestionsTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionsTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionsTypeId)
{
if (string.IsNullOrEmpty(strQuestionsTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionsTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = qa_QuestionsTypeDA.IsExist(strQuestionsTypeId);
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
 bolIsExist = clsqa_QuestionsTypeDA.IsExistTable();
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
 bolIsExist = qa_QuestionsTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsqa_QuestionsTypeBL.IsExist(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objqa_QuestionsTypeEN.QuestionsTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objqa_QuestionsTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问题类型Id = [{0}]的数据已经存在!(in clsqa_QuestionsTypeBL.AddNewRecordBySql2)", objqa_QuestionsTypeEN.QuestionsTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = qa_QuestionsTypeDA.AddNewRecordBySQL2(objqa_QuestionsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsqa_QuestionsTypeBL.IsExist(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objqa_QuestionsTypeEN.QuestionsTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objqa_QuestionsTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问题类型Id = [{0}]的数据已经存在!(in clsqa_QuestionsTypeBL.AddNewRecordBySql2WithReturnKey)", objqa_QuestionsTypeEN.QuestionsTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = qa_QuestionsTypeDA.AddNewRecordBySQL2WithReturnKey(objqa_QuestionsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
try
{
bool bolResult = qa_QuestionsTypeDA.Update(objqa_QuestionsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "objqa_QuestionsTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
 if (string.IsNullOrEmpty(objqa_QuestionsTypeEN.QuestionsTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = qa_QuestionsTypeDA.UpdateBySql2(objqa_QuestionsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_QuestionsTypeBL.ReFreshCache();

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
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
 /// <param name = "strQuestionsTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strQuestionsTypeId)
{
try
{
 clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = clsqa_QuestionsTypeBL.GetObjByQuestionsTypeId(strQuestionsTypeId);

if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(objqa_QuestionsTypeEN.QuestionsTypeId, "SetUpdDate");
}
if (objqa_QuestionsTypeEN != null)
{
int intRecNum = qa_QuestionsTypeDA.DelRecord(strQuestionsTypeId);
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
/// <param name="strQuestionsTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strQuestionsTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_QuestionsTypeDA.GetSpecSQLObj();
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
//删除与表:[qa_QuestionsType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conqa_QuestionsType.QuestionsTypeId,
//strQuestionsTypeId);
//        clsqa_QuestionsTypeBL.Delqa_QuestionsTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_QuestionsTypeBL.DelRecord(strQuestionsTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_QuestionsTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionsTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strQuestionsTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strQuestionsTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsqa_QuestionsTypeBL.relatedActions != null)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(strQuestionsTypeId, "UpdRelaTabDate");
}
bool bolResult = qa_QuestionsTypeDA.DelRecord(strQuestionsTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQuestionsTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delqa_QuestionsTypes(List<string> arrQuestionsTypeIdLst)
{
if (arrQuestionsTypeIdLst.Count == 0) return 0;
try
{
if (clsqa_QuestionsTypeBL.relatedActions != null)
{
foreach (var strQuestionsTypeId in arrQuestionsTypeIdLst)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(strQuestionsTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = qa_QuestionsTypeDA.Delqa_QuestionsType(arrQuestionsTypeIdLst);
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
public static int Delqa_QuestionsTypesByCond(string strWhereCond)
{
try
{
if (clsqa_QuestionsTypeBL.relatedActions != null)
{
List<string> arrQuestionsTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQuestionsTypeId in arrQuestionsTypeId)
{
clsqa_QuestionsTypeBL.relatedActions.UpdRelaTabDate(strQuestionsTypeId, "UpdRelaTabDate");
}
}
int intRecNum = qa_QuestionsTypeDA.Delqa_QuestionsType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[qa_QuestionsType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strQuestionsTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strQuestionsTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_QuestionsTypeDA.GetSpecSQLObj();
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
//删除与表:[qa_QuestionsType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_QuestionsTypeBL.DelRecord(strQuestionsTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_QuestionsTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionsTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objqa_QuestionsTypeENS">源对象</param>
 /// <param name = "objqa_QuestionsTypeENT">目标对象</param>
 public static void CopyTo(clsqa_QuestionsTypeEN objqa_QuestionsTypeENS, clsqa_QuestionsTypeEN objqa_QuestionsTypeENT)
{
try
{
objqa_QuestionsTypeENT.QuestionsTypeId = objqa_QuestionsTypeENS.QuestionsTypeId; //问题类型Id
objqa_QuestionsTypeENT.QuestionsTypeName = objqa_QuestionsTypeENS.QuestionsTypeName; //问题类型名称
objqa_QuestionsTypeENT.QuestionsTypeEnName = objqa_QuestionsTypeENS.QuestionsTypeEnName; //问题类型英文名
objqa_QuestionsTypeENT.Memo = objqa_QuestionsTypeENS.Memo; //备注
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
 /// <param name = "objqa_QuestionsTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
try
{
objqa_QuestionsTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objqa_QuestionsTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conqa_QuestionsType.QuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_QuestionsTypeEN.QuestionsTypeId = objqa_QuestionsTypeEN.QuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(conqa_QuestionsType.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_QuestionsTypeEN.QuestionsTypeName = objqa_QuestionsTypeEN.QuestionsTypeName; //问题类型名称
}
if (arrFldSet.Contains(conqa_QuestionsType.QuestionsTypeEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_QuestionsTypeEN.QuestionsTypeEnName = objqa_QuestionsTypeEN.QuestionsTypeEnName == "[null]" ? null :  objqa_QuestionsTypeEN.QuestionsTypeEnName; //问题类型英文名
}
if (arrFldSet.Contains(conqa_QuestionsType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_QuestionsTypeEN.Memo = objqa_QuestionsTypeEN.Memo == "[null]" ? null :  objqa_QuestionsTypeEN.Memo; //备注
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
 /// <param name = "objqa_QuestionsTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
try
{
if (objqa_QuestionsTypeEN.QuestionsTypeEnName == "[null]") objqa_QuestionsTypeEN.QuestionsTypeEnName = null; //问题类型英文名
if (objqa_QuestionsTypeEN.Memo == "[null]") objqa_QuestionsTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
 qa_QuestionsTypeDA.CheckPropertyNew(objqa_QuestionsTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
 qa_QuestionsTypeDA.CheckProperty4Condition(objqa_QuestionsTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionsTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[问题类型表]...","0");
List<clsqa_QuestionsTypeEN> arrqa_QuestionsTypeObjLst = GetAllqa_QuestionsTypeObjLstCache(); 
objDDL.DataValueField = conqa_QuestionsType.QuestionsTypeId;
objDDL.DataTextField = conqa_QuestionsType.QuestionsTypeName;
objDDL.DataSource = arrqa_QuestionsTypeObjLst;
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
if (clsqa_QuestionsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsTypeBL没有刷新缓存机制(clsqa_QuestionsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionsTypeId");
//if (arrqa_QuestionsTypeObjLstCache == null)
//{
//arrqa_QuestionsTypeObjLstCache = qa_QuestionsTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionsTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_QuestionsTypeEN GetObjByQuestionsTypeIdCache(string strQuestionsTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsqa_QuestionsTypeEN._CurrTabName);
List<clsqa_QuestionsTypeEN> arrqa_QuestionsTypeObjLstCache = GetObjLstCache();
IEnumerable <clsqa_QuestionsTypeEN> arrqa_QuestionsTypeObjLst_Sel =
arrqa_QuestionsTypeObjLstCache
.Where(x=> x.QuestionsTypeId == strQuestionsTypeId 
);
if (arrqa_QuestionsTypeObjLst_Sel.Count() == 0)
{
   clsqa_QuestionsTypeEN obj = clsqa_QuestionsTypeBL.GetObjByQuestionsTypeId(strQuestionsTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrqa_QuestionsTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionsTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionsTypeNameByQuestionsTypeIdCache(string strQuestionsTypeId)
{
if (string.IsNullOrEmpty(strQuestionsTypeId) == true) return "";
//获取缓存中的对象列表
clsqa_QuestionsTypeEN objqa_QuestionsType = GetObjByQuestionsTypeIdCache(strQuestionsTypeId);
if (objqa_QuestionsType == null) return "";
return objqa_QuestionsType.QuestionsTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionsTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionsTypeIdCache(string strQuestionsTypeId)
{
if (string.IsNullOrEmpty(strQuestionsTypeId) == true) return "";
//获取缓存中的对象列表
clsqa_QuestionsTypeEN objqa_QuestionsType = GetObjByQuestionsTypeIdCache(strQuestionsTypeId);
if (objqa_QuestionsType == null) return "";
return objqa_QuestionsType.QuestionsTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_QuestionsTypeEN> GetAllqa_QuestionsTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsqa_QuestionsTypeEN> arrqa_QuestionsTypeObjLstCache = GetObjLstCache(); 
return arrqa_QuestionsTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_QuestionsTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsqa_QuestionsTypeEN._CurrTabName);
List<clsqa_QuestionsTypeEN> arrqa_QuestionsTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrqa_QuestionsTypeObjLstCache;
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
string strKey = string.Format("{0}", clsqa_QuestionsTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsqa_QuestionsTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsqa_QuestionsTypeEN._RefreshTimeLst.Count == 0) return "";
return clsqa_QuestionsTypeEN._RefreshTimeLst[clsqa_QuestionsTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsqa_QuestionsTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsqa_QuestionsTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsqa_QuestionsTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsqa_QuestionsTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--qa_QuestionsType(问题类型表)
 /// 唯一性条件:QuestionsTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsqa_QuestionsTypeEN objqa_QuestionsTypeEN)
{
//检测记录是否存在
string strResult = qa_QuestionsTypeDA.GetUniCondStr(objqa_QuestionsTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionsTypeId)
{
if (strInFldName != conqa_QuestionsType.QuestionsTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conqa_QuestionsType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conqa_QuestionsType.AttributeName));
throw new Exception(strMsg);
}
var objqa_QuestionsType = clsqa_QuestionsTypeBL.GetObjByQuestionsTypeIdCache(strQuestionsTypeId);
if (objqa_QuestionsType == null) return "";
return objqa_QuestionsType[strOutFldName].ToString();
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
int intRecCount = clsqa_QuestionsTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsqa_QuestionsTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsqa_QuestionsTypeDA.GetRecCount();
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
int intRecCount = clsqa_QuestionsTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsqa_QuestionsTypeEN objqa_QuestionsTypeCond)
{
List<clsqa_QuestionsTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsqa_QuestionsTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_QuestionsType.AttributeName)
{
if (objqa_QuestionsTypeCond.IsUpdated(strFldName) == false) continue;
if (objqa_QuestionsTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_QuestionsTypeCond[strFldName].ToString());
}
else
{
if (objqa_QuestionsTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_QuestionsTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_QuestionsTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_QuestionsTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_QuestionsTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_QuestionsTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_QuestionsTypeCond[strFldName]));
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
 List<string> arrList = clsqa_QuestionsTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = qa_QuestionsTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = qa_QuestionsTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = qa_QuestionsTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_QuestionsTypeDA.SetFldValue(clsqa_QuestionsTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = qa_QuestionsTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_QuestionsTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_QuestionsTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_QuestionsTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[qa_QuestionsType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**问题类型Id*/ 
 strCreateTabCode.Append(" QuestionsTypeId char(2) primary key, "); 
 // /**问题类型名称*/ 
 strCreateTabCode.Append(" QuestionsTypeName varchar(50) not Null, "); 
 // /**问题类型英文名*/ 
 strCreateTabCode.Append(" QuestionsTypeEnName varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 问题类型表(qa_QuestionsType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4qa_QuestionsType : clsCommFun4BL
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
clsqa_QuestionsTypeBL.ReFreshThisCache();
}
}

}