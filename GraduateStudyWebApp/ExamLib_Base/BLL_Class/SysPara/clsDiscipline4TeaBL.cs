
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscipline4TeaBL
 表名:Discipline4Tea(01120517)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsDiscipline4TeaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdDiscipline">表关键字</param>
 /// <returns>表对象</returns>
public static clsDiscipline4TeaEN GetObj(this K_IdDiscipline_Discipline4Tea myKey)
{
clsDiscipline4TeaEN objDiscipline4TeaEN = clsDiscipline4TeaBL.Discipline4TeaDA.GetObjByIdDiscipline(myKey.Value);
return objDiscipline4TeaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDiscipline4TeaEN objDiscipline4TeaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscipline4TeaBL.IsExist(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscipline4TeaEN.IdDiscipline, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDiscipline4TeaBL.Discipline4TeaDA.AddNewRecordBySQL2(objDiscipline4TeaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
public static bool AddRecordEx(this clsDiscipline4TeaEN objDiscipline4TeaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDiscipline4TeaBL.IsExist(objDiscipline4TeaEN.IdDiscipline))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDiscipline4TeaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDiscipline4TeaEN.AddNewRecord();
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
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDiscipline4TeaEN objDiscipline4TeaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscipline4TeaBL.IsExist(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscipline4TeaEN.IdDiscipline, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDiscipline4TeaBL.Discipline4TeaDA.AddNewRecordBySQL2WithReturnKey(objDiscipline4TeaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscipline4TeaEN SetMemo(this clsDiscipline4TeaEN objDiscipline4TeaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDiscipline4Tea.Memo);
}
objDiscipline4TeaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscipline4TeaEN.dicFldComparisonOp.ContainsKey(conDiscipline4Tea.Memo) == false)
{
objDiscipline4TeaEN.dicFldComparisonOp.Add(conDiscipline4Tea.Memo, strComparisonOp);
}
else
{
objDiscipline4TeaEN.dicFldComparisonOp[conDiscipline4Tea.Memo] = strComparisonOp;
}
}
return objDiscipline4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscipline4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscipline4TeaEN SetIdDiscipline(this clsDiscipline4TeaEN objDiscipline4TeaEN, string strIdDiscipline, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, conDiscipline4Tea.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, conDiscipline4Tea.IdDiscipline);
}
objDiscipline4TeaEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscipline4TeaEN.dicFldComparisonOp.ContainsKey(conDiscipline4Tea.IdDiscipline) == false)
{
objDiscipline4TeaEN.dicFldComparisonOp.Add(conDiscipline4Tea.IdDiscipline, strComparisonOp);
}
else
{
objDiscipline4TeaEN.dicFldComparisonOp[conDiscipline4Tea.IdDiscipline] = strComparisonOp;
}
}
return objDiscipline4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscipline4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscipline4TeaEN SetDisciplineID(this clsDiscipline4TeaEN objDiscipline4TeaEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, conDiscipline4Tea.DisciplineID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, conDiscipline4Tea.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, conDiscipline4Tea.DisciplineID);
}
objDiscipline4TeaEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscipline4TeaEN.dicFldComparisonOp.ContainsKey(conDiscipline4Tea.DisciplineID) == false)
{
objDiscipline4TeaEN.dicFldComparisonOp.Add(conDiscipline4Tea.DisciplineID, strComparisonOp);
}
else
{
objDiscipline4TeaEN.dicFldComparisonOp[conDiscipline4Tea.DisciplineID] = strComparisonOp;
}
}
return objDiscipline4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscipline4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscipline4TeaEN SetDisciplineName(this clsDiscipline4TeaEN objDiscipline4TeaEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, conDiscipline4Tea.DisciplineName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, conDiscipline4Tea.DisciplineName);
}
objDiscipline4TeaEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscipline4TeaEN.dicFldComparisonOp.ContainsKey(conDiscipline4Tea.DisciplineName) == false)
{
objDiscipline4TeaEN.dicFldComparisonOp.Add(conDiscipline4Tea.DisciplineName, strComparisonOp);
}
else
{
objDiscipline4TeaEN.dicFldComparisonOp[conDiscipline4Tea.DisciplineName] = strComparisonOp;
}
}
return objDiscipline4TeaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscipline4TeaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscipline4TeaEN SetSequenceNumber(this clsDiscipline4TeaEN objDiscipline4TeaEN, int intSequenceNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSequenceNumber, conDiscipline4Tea.SequenceNumber);
objDiscipline4TeaEN.SequenceNumber = intSequenceNumber; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscipline4TeaEN.dicFldComparisonOp.ContainsKey(conDiscipline4Tea.SequenceNumber) == false)
{
objDiscipline4TeaEN.dicFldComparisonOp.Add(conDiscipline4Tea.SequenceNumber, strComparisonOp);
}
else
{
objDiscipline4TeaEN.dicFldComparisonOp[conDiscipline4Tea.SequenceNumber] = strComparisonOp;
}
}
return objDiscipline4TeaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDiscipline4TeaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDiscipline4TeaEN objDiscipline4TeaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDiscipline4TeaEN.CheckPropertyNew();
clsDiscipline4TeaEN objDiscipline4TeaCond = new clsDiscipline4TeaEN();
string strCondition = objDiscipline4TeaCond
.SetIdDiscipline(objDiscipline4TeaEN.IdDiscipline, "=")
.GetCombineCondition();
objDiscipline4TeaEN._IsCheckProperty = true;
bool bolIsExist = clsDiscipline4TeaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDiscipline4TeaEN.Update();
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
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDiscipline4TeaEN objDiscipline4TeaEN)
{
 if (string.IsNullOrEmpty(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDiscipline4TeaBL.Discipline4TeaDA.UpdateBySql2(objDiscipline4TeaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDiscipline4TeaEN objDiscipline4TeaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDiscipline4TeaBL.Discipline4TeaDA.UpdateBySql2(objDiscipline4TeaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDiscipline4TeaEN objDiscipline4TeaEN, string strWhereCond)
{
try
{
bool bolResult = clsDiscipline4TeaBL.Discipline4TeaDA.UpdateBySqlWithCondition(objDiscipline4TeaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDiscipline4TeaEN objDiscipline4TeaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDiscipline4TeaBL.Discipline4TeaDA.UpdateBySqlWithConditionTransaction(objDiscipline4TeaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "strIdDiscipline">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDiscipline4TeaEN objDiscipline4TeaEN)
{
try
{
int intRecNum = clsDiscipline4TeaBL.Discipline4TeaDA.DelRecord(objDiscipline4TeaEN.IdDiscipline);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaENS">源对象</param>
 /// <param name = "objDiscipline4TeaENT">目标对象</param>
 public static void CopyTo(this clsDiscipline4TeaEN objDiscipline4TeaENS, clsDiscipline4TeaEN objDiscipline4TeaENT)
{
try
{
objDiscipline4TeaENT.Memo = objDiscipline4TeaENS.Memo; //备注
objDiscipline4TeaENT.IdDiscipline = objDiscipline4TeaENS.IdDiscipline; //学科流水号
objDiscipline4TeaENT.DisciplineID = objDiscipline4TeaENS.DisciplineID; //学科ID
objDiscipline4TeaENT.DisciplineName = objDiscipline4TeaENS.DisciplineName; //学科名称
objDiscipline4TeaENT.SequenceNumber = objDiscipline4TeaENS.SequenceNumber; //序号
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
 /// <param name = "objDiscipline4TeaENS">源对象</param>
 /// <returns>目标对象=>clsDiscipline4TeaEN:objDiscipline4TeaENT</returns>
 public static clsDiscipline4TeaEN CopyTo(this clsDiscipline4TeaEN objDiscipline4TeaENS)
{
try
{
 clsDiscipline4TeaEN objDiscipline4TeaENT = new clsDiscipline4TeaEN()
{
Memo = objDiscipline4TeaENS.Memo, //备注
IdDiscipline = objDiscipline4TeaENS.IdDiscipline, //学科流水号
DisciplineID = objDiscipline4TeaENS.DisciplineID, //学科ID
DisciplineName = objDiscipline4TeaENS.DisciplineName, //学科名称
SequenceNumber = objDiscipline4TeaENS.SequenceNumber, //序号
};
 return objDiscipline4TeaENT;
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
public static void CheckPropertyNew(this clsDiscipline4TeaEN objDiscipline4TeaEN)
{
 clsDiscipline4TeaBL.Discipline4TeaDA.CheckPropertyNew(objDiscipline4TeaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDiscipline4TeaEN objDiscipline4TeaEN)
{
 clsDiscipline4TeaBL.Discipline4TeaDA.CheckProperty4Condition(objDiscipline4TeaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDiscipline4TeaEN objDiscipline4TeaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDiscipline4TeaCond.IsUpdated(conDiscipline4Tea.Memo) == true)
{
string strComparisonOpMemo = objDiscipline4TeaCond.dicFldComparisonOp[conDiscipline4Tea.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscipline4Tea.Memo, objDiscipline4TeaCond.Memo, strComparisonOpMemo);
}
if (objDiscipline4TeaCond.IsUpdated(conDiscipline4Tea.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objDiscipline4TeaCond.dicFldComparisonOp[conDiscipline4Tea.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscipline4Tea.IdDiscipline, objDiscipline4TeaCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objDiscipline4TeaCond.IsUpdated(conDiscipline4Tea.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objDiscipline4TeaCond.dicFldComparisonOp[conDiscipline4Tea.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscipline4Tea.DisciplineID, objDiscipline4TeaCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objDiscipline4TeaCond.IsUpdated(conDiscipline4Tea.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objDiscipline4TeaCond.dicFldComparisonOp[conDiscipline4Tea.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscipline4Tea.DisciplineName, objDiscipline4TeaCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objDiscipline4TeaCond.IsUpdated(conDiscipline4Tea.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objDiscipline4TeaCond.dicFldComparisonOp[conDiscipline4Tea.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conDiscipline4Tea.SequenceNumber, objDiscipline4TeaCond.SequenceNumber, strComparisonOpSequenceNumber);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Discipline4Tea
{
public virtual bool UpdRelaTabDate(string strIdDiscipline, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学科表4Tea(Discipline4Tea)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDiscipline4TeaBL
{
public static RelatedActions_Discipline4Tea relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDiscipline4TeaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDiscipline4TeaDA Discipline4TeaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDiscipline4TeaDA();
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
 public clsDiscipline4TeaBL()
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
if (string.IsNullOrEmpty(clsDiscipline4TeaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDiscipline4TeaEN._ConnectString);
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
public static DataTable GetDataTable_Discipline4Tea(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Discipline4TeaDA.GetDataTable_Discipline4Tea(strWhereCond);
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
objDT = Discipline4TeaDA.GetDataTable(strWhereCond);
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
objDT = Discipline4TeaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Discipline4TeaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Discipline4TeaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Discipline4TeaDA.GetDataTable_Top(objTopPara);
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
objDT = Discipline4TeaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Discipline4TeaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Discipline4TeaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdDisciplineLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDiscipline4TeaEN> GetObjLstByIdDisciplineLst(List<string> arrIdDisciplineLst)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdDisciplineLst, true);
 string strWhereCond = string.Format("IdDiscipline in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdDisciplineLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDiscipline4TeaEN> GetObjLstByIdDisciplineLstCache(List<string> arrIdDisciplineLst)
{
string strKey = string.Format("{0}", clsDiscipline4TeaEN._CurrTabName);
List<clsDiscipline4TeaEN> arrDiscipline4TeaObjLstCache = GetObjLstCache();
IEnumerable <clsDiscipline4TeaEN> arrDiscipline4TeaObjLst_Sel =
arrDiscipline4TeaObjLstCache
.Where(x => arrIdDisciplineLst.Contains(x.IdDiscipline));
return arrDiscipline4TeaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscipline4TeaEN> GetObjLst(string strWhereCond)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
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
public static List<clsDiscipline4TeaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDiscipline4TeaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDiscipline4TeaEN> GetSubObjLstCache(clsDiscipline4TeaEN objDiscipline4TeaCond)
{
List<clsDiscipline4TeaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDiscipline4TeaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDiscipline4Tea.AttributeName)
{
if (objDiscipline4TeaCond.IsUpdated(strFldName) == false) continue;
if (objDiscipline4TeaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscipline4TeaCond[strFldName].ToString());
}
else
{
if (objDiscipline4TeaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDiscipline4TeaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscipline4TeaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDiscipline4TeaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDiscipline4TeaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDiscipline4TeaCond[strFldName]));
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
public static List<clsDiscipline4TeaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
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
public static List<clsDiscipline4TeaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
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
List<clsDiscipline4TeaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDiscipline4TeaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscipline4TeaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDiscipline4TeaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
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
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
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
public static List<clsDiscipline4TeaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDiscipline4TeaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDiscipline4TeaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
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
public static List<clsDiscipline4TeaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscipline4TeaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDiscipline4TeaEN> arrObjLst = new List<clsDiscipline4TeaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscipline4TeaEN objDiscipline4TeaEN = new clsDiscipline4TeaEN();
try
{
objDiscipline4TeaEN.Memo = objRow[conDiscipline4Tea.Memo] == DBNull.Value ? null : objRow[conDiscipline4Tea.Memo].ToString().Trim(); //备注
objDiscipline4TeaEN.IdDiscipline = objRow[conDiscipline4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objDiscipline4TeaEN.DisciplineID = objRow[conDiscipline4Tea.DisciplineID].ToString().Trim(); //学科ID
objDiscipline4TeaEN.DisciplineName = objRow[conDiscipline4Tea.DisciplineName].ToString().Trim(); //学科名称
objDiscipline4TeaEN.SequenceNumber = Int32.Parse(objRow[conDiscipline4Tea.SequenceNumber].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscipline4TeaEN.IdDiscipline, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscipline4TeaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDiscipline4TeaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDiscipline4Tea(ref clsDiscipline4TeaEN objDiscipline4TeaEN)
{
bool bolResult = Discipline4TeaDA.GetDiscipline4Tea(ref objDiscipline4TeaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdDiscipline">表关键字</param>
 /// <returns>表对象</returns>
public static clsDiscipline4TeaEN GetObjByIdDiscipline(string strIdDiscipline)
{
if (strIdDiscipline.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdDiscipline]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdDiscipline) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdDiscipline]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDiscipline4TeaEN objDiscipline4TeaEN = Discipline4TeaDA.GetObjByIdDiscipline(strIdDiscipline);
return objDiscipline4TeaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDiscipline4TeaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDiscipline4TeaEN objDiscipline4TeaEN = Discipline4TeaDA.GetFirstObj(strWhereCond);
 return objDiscipline4TeaEN;
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
public static clsDiscipline4TeaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDiscipline4TeaEN objDiscipline4TeaEN = Discipline4TeaDA.GetObjByDataRow(objRow);
 return objDiscipline4TeaEN;
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
public static clsDiscipline4TeaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDiscipline4TeaEN objDiscipline4TeaEN = Discipline4TeaDA.GetObjByDataRow(objRow);
 return objDiscipline4TeaEN;
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
 /// <param name = "strIdDiscipline">所给的关键字</param>
 /// <param name = "lstDiscipline4TeaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDiscipline4TeaEN GetObjByIdDisciplineFromList(string strIdDiscipline, List<clsDiscipline4TeaEN> lstDiscipline4TeaObjLst)
{
foreach (clsDiscipline4TeaEN objDiscipline4TeaEN in lstDiscipline4TeaObjLst)
{
if (objDiscipline4TeaEN.IdDiscipline == strIdDiscipline)
{
return objDiscipline4TeaEN;
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
 string strIdDiscipline;
 try
 {
 strIdDiscipline = new clsDiscipline4TeaDA().GetFirstID(strWhereCond);
 return strIdDiscipline;
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
 arrList = Discipline4TeaDA.GetID(strWhereCond);
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
bool bolIsExist = Discipline4TeaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdDiscipline">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdDiscipline)
{
if (string.IsNullOrEmpty(strIdDiscipline) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdDiscipline]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = Discipline4TeaDA.IsExist(strIdDiscipline);
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
 bolIsExist = clsDiscipline4TeaDA.IsExistTable();
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
 bolIsExist = Discipline4TeaDA.IsExistTable(strTabName);
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
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDiscipline4TeaEN objDiscipline4TeaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscipline4TeaBL.IsExist(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscipline4TeaEN.IdDiscipline, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = Discipline4TeaDA.AddNewRecordBySQL2(objDiscipline4TeaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDiscipline4TeaEN objDiscipline4TeaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscipline4TeaBL.IsExist(objDiscipline4TeaEN.IdDiscipline) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscipline4TeaEN.IdDiscipline, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = Discipline4TeaDA.AddNewRecordBySQL2WithReturnKey(objDiscipline4TeaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDiscipline4TeaEN objDiscipline4TeaEN)
{
try
{
bool bolResult = Discipline4TeaDA.Update(objDiscipline4TeaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "objDiscipline4TeaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDiscipline4TeaEN objDiscipline4TeaEN)
{
 if (string.IsNullOrEmpty(objDiscipline4TeaEN.IdDiscipline) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Discipline4TeaDA.UpdateBySql2(objDiscipline4TeaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscipline4TeaBL.ReFreshCache();

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
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
 /// <param name = "strIdDiscipline">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdDiscipline)
{
try
{
 clsDiscipline4TeaEN objDiscipline4TeaEN = clsDiscipline4TeaBL.GetObjByIdDiscipline(strIdDiscipline);

if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(objDiscipline4TeaEN.IdDiscipline, "SetUpdDate");
}
if (objDiscipline4TeaEN != null)
{
int intRecNum = Discipline4TeaDA.DelRecord(strIdDiscipline);
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
/// <param name="strIdDiscipline">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdDiscipline )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDiscipline4TeaDA.GetSpecSQLObj();
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
//删除与表:[Discipline4Tea]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDiscipline4Tea.IdDiscipline,
//strIdDiscipline);
//        clsDiscipline4TeaBL.DelDiscipline4TeasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDiscipline4TeaBL.DelRecord(strIdDiscipline, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDiscipline4TeaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdDiscipline, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdDiscipline">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdDiscipline, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDiscipline4TeaBL.relatedActions != null)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(strIdDiscipline, "UpdRelaTabDate");
}
bool bolResult = Discipline4TeaDA.DelRecord(strIdDiscipline,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdDisciplineLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDiscipline4Teas(List<string> arrIdDisciplineLst)
{
if (arrIdDisciplineLst.Count == 0) return 0;
try
{
if (clsDiscipline4TeaBL.relatedActions != null)
{
foreach (var strIdDiscipline in arrIdDisciplineLst)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(strIdDiscipline, "UpdRelaTabDate");
}
}
int intDelRecNum = Discipline4TeaDA.DelDiscipline4Tea(arrIdDisciplineLst);
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
public static int DelDiscipline4TeasByCond(string strWhereCond)
{
try
{
if (clsDiscipline4TeaBL.relatedActions != null)
{
List<string> arrIdDiscipline = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdDiscipline in arrIdDiscipline)
{
clsDiscipline4TeaBL.relatedActions.UpdRelaTabDate(strIdDiscipline, "UpdRelaTabDate");
}
}
int intRecNum = Discipline4TeaDA.DelDiscipline4Tea(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Discipline4Tea]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdDiscipline">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdDiscipline)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDiscipline4TeaDA.GetSpecSQLObj();
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
//删除与表:[Discipline4Tea]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDiscipline4TeaBL.DelRecord(strIdDiscipline, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDiscipline4TeaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdDiscipline, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDiscipline4TeaENS">源对象</param>
 /// <param name = "objDiscipline4TeaENT">目标对象</param>
 public static void CopyTo(clsDiscipline4TeaEN objDiscipline4TeaENS, clsDiscipline4TeaEN objDiscipline4TeaENT)
{
try
{
objDiscipline4TeaENT.Memo = objDiscipline4TeaENS.Memo; //备注
objDiscipline4TeaENT.IdDiscipline = objDiscipline4TeaENS.IdDiscipline; //学科流水号
objDiscipline4TeaENT.DisciplineID = objDiscipline4TeaENS.DisciplineID; //学科ID
objDiscipline4TeaENT.DisciplineName = objDiscipline4TeaENS.DisciplineName; //学科名称
objDiscipline4TeaENT.SequenceNumber = objDiscipline4TeaENS.SequenceNumber; //序号
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
 /// <param name = "objDiscipline4TeaEN">源简化对象</param>
 public static void SetUpdFlag(clsDiscipline4TeaEN objDiscipline4TeaEN)
{
try
{
objDiscipline4TeaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDiscipline4TeaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDiscipline4Tea.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscipline4TeaEN.Memo = objDiscipline4TeaEN.Memo == "[null]" ? null :  objDiscipline4TeaEN.Memo; //备注
}
if (arrFldSet.Contains(conDiscipline4Tea.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscipline4TeaEN.IdDiscipline = objDiscipline4TeaEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(conDiscipline4Tea.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscipline4TeaEN.DisciplineID = objDiscipline4TeaEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(conDiscipline4Tea.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscipline4TeaEN.DisciplineName = objDiscipline4TeaEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(conDiscipline4Tea.SequenceNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscipline4TeaEN.SequenceNumber = objDiscipline4TeaEN.SequenceNumber; //序号
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
 /// <param name = "objDiscipline4TeaEN">源简化对象</param>
 public static void AccessFldValueNull(clsDiscipline4TeaEN objDiscipline4TeaEN)
{
try
{
if (objDiscipline4TeaEN.Memo == "[null]") objDiscipline4TeaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsDiscipline4TeaEN objDiscipline4TeaEN)
{
 Discipline4TeaDA.CheckPropertyNew(objDiscipline4TeaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDiscipline4TeaEN objDiscipline4TeaEN)
{
 Discipline4TeaDA.CheckProperty4Condition(objDiscipline4TeaEN);
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
if (clsDiscipline4TeaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline4TeaBL没有刷新缓存机制(clsDiscipline4TeaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdDiscipline");
//if (arrDiscipline4TeaObjLstCache == null)
//{
//arrDiscipline4TeaObjLstCache = Discipline4TeaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdDiscipline">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDiscipline4TeaEN GetObjByIdDisciplineCache(string strIdDiscipline)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDiscipline4TeaEN._CurrTabName);
List<clsDiscipline4TeaEN> arrDiscipline4TeaObjLstCache = GetObjLstCache();
IEnumerable <clsDiscipline4TeaEN> arrDiscipline4TeaObjLst_Sel =
arrDiscipline4TeaObjLstCache
.Where(x=> x.IdDiscipline == strIdDiscipline 
);
if (arrDiscipline4TeaObjLst_Sel.Count() == 0)
{
   clsDiscipline4TeaEN obj = clsDiscipline4TeaBL.GetObjByIdDiscipline(strIdDiscipline);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDiscipline4TeaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDiscipline4TeaEN> GetAllDiscipline4TeaObjLstCache()
{
//获取缓存中的对象列表
List<clsDiscipline4TeaEN> arrDiscipline4TeaObjLstCache = GetObjLstCache(); 
return arrDiscipline4TeaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDiscipline4TeaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDiscipline4TeaEN._CurrTabName);
List<clsDiscipline4TeaEN> arrDiscipline4TeaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDiscipline4TeaObjLstCache;
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
string strKey = string.Format("{0}", clsDiscipline4TeaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDiscipline4TeaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDiscipline4TeaEN._RefreshTimeLst.Count == 0) return "";
return clsDiscipline4TeaEN._RefreshTimeLst[clsDiscipline4TeaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDiscipline4TeaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDiscipline4TeaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDiscipline4TeaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDiscipline4TeaBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdDiscipline)
{
if (strInFldName != conDiscipline4Tea.IdDiscipline)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDiscipline4Tea.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDiscipline4Tea.AttributeName));
throw new Exception(strMsg);
}
var objDiscipline4Tea = clsDiscipline4TeaBL.GetObjByIdDisciplineCache(strIdDiscipline);
if (objDiscipline4Tea == null) return "";
return objDiscipline4Tea[strOutFldName].ToString();
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
int intRecCount = clsDiscipline4TeaDA.GetRecCount(strTabName);
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
int intRecCount = clsDiscipline4TeaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDiscipline4TeaDA.GetRecCount();
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
int intRecCount = clsDiscipline4TeaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDiscipline4TeaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDiscipline4TeaEN objDiscipline4TeaCond)
{
List<clsDiscipline4TeaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDiscipline4TeaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDiscipline4Tea.AttributeName)
{
if (objDiscipline4TeaCond.IsUpdated(strFldName) == false) continue;
if (objDiscipline4TeaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscipline4TeaCond[strFldName].ToString());
}
else
{
if (objDiscipline4TeaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDiscipline4TeaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscipline4TeaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDiscipline4TeaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDiscipline4TeaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDiscipline4TeaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDiscipline4TeaCond[strFldName]));
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
 List<string> arrList = clsDiscipline4TeaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Discipline4TeaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Discipline4TeaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Discipline4TeaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDiscipline4TeaDA.SetFldValue(clsDiscipline4TeaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Discipline4TeaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDiscipline4TeaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDiscipline4TeaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDiscipline4TeaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Discipline4Tea] "); 
 strCreateTabCode.Append(" ( "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**学科流水号*/ 
 strCreateTabCode.Append(" IdDiscipline char(4) primary key, "); 
 // /**学科ID*/ 
 strCreateTabCode.Append(" DisciplineID char(4) not Null, "); 
 // /**学科名称*/ 
 strCreateTabCode.Append(" DisciplineName varchar(50) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" SequenceNumber int not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 学科表4Tea(Discipline4Tea)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Discipline4Tea : clsCommFun4BL
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
clsDiscipline4TeaBL.ReFreshThisCache();
}
}

}