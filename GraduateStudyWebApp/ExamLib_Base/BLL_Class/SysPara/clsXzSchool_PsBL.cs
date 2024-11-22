
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchool_PsBL
 表名:XzSchool_Ps(01120102)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:15
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
public static class  clsXzSchool_PsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSchoolPs">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchool_PsEN GetObj(this K_IdSchoolPs_XzSchool_Ps myKey)
{
clsXzSchool_PsEN objXzSchool_PsEN = clsXzSchool_PsBL.XzSchool_PsDA.GetObjByIdSchoolPs(myKey.Value);
return objXzSchool_PsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzSchool_PsEN objXzSchool_PsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchool_PsBL.IsExist(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchool_PsEN.IdSchoolPs, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsXzSchool_PsBL.XzSchool_PsDA.AddNewRecordBySQL2(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
public static bool AddRecordEx(this clsXzSchool_PsEN objXzSchool_PsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsXzSchool_PsBL.IsExist(objXzSchool_PsEN.IdSchoolPs))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objXzSchool_PsEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objXzSchool_PsEN.AddNewRecord();
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzSchool_PsEN objXzSchool_PsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchool_PsBL.IsExist(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchool_PsEN.IdSchoolPs, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsXzSchool_PsBL.XzSchool_PsDA.AddNewRecordBySQL2WithReturnKey(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetIdSchoolPs(this clsXzSchool_PsEN objXzSchool_PsEN, string strIdSchoolPs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchoolPs, 4, conXzSchool_Ps.IdSchoolPs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchoolPs, 4, conXzSchool_Ps.IdSchoolPs);
}
objXzSchool_PsEN.IdSchoolPs = strIdSchoolPs; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.IdSchoolPs) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.IdSchoolPs, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.IdSchoolPs] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetSchoolId(this clsXzSchool_PsEN objXzSchool_PsEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, conXzSchool_Ps.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, conXzSchool_Ps.SchoolId);
}
objXzSchool_PsEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.SchoolId) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.SchoolId, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.SchoolId] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetSchoolName(this clsXzSchool_PsEN objXzSchool_PsEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, conXzSchool_Ps.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, conXzSchool_Ps.SchoolName);
}
objXzSchool_PsEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.SchoolName) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.SchoolName, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.SchoolName] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetOrderNum(this clsXzSchool_PsEN objXzSchool_PsEN, int? intOrderNum, string strComparisonOp="")
	{
objXzSchool_PsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.OrderNum) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.OrderNum, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.OrderNum] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetIsVisible(this clsXzSchool_PsEN objXzSchool_PsEN, bool bolIsVisible, string strComparisonOp="")
	{
objXzSchool_PsEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.IsVisible) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.IsVisible, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.IsVisible] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetUpdDate(this clsXzSchool_PsEN objXzSchool_PsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conXzSchool_Ps.UpdDate);
}
objXzSchool_PsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.UpdDate) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.UpdDate, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.UpdDate] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetUpdUserId(this clsXzSchool_PsEN objXzSchool_PsEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conXzSchool_Ps.UpdUserId);
}
objXzSchool_PsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.UpdUserId) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.UpdUserId, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.UpdUserId] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchool_PsEN SetMemo(this clsXzSchool_PsEN objXzSchool_PsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzSchool_Ps.Memo);
}
objXzSchool_PsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.Memo) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.Memo, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.Memo] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzSchool_PsEN objXzSchool_PsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzSchool_PsEN.CheckPropertyNew();
clsXzSchool_PsEN objXzSchool_PsCond = new clsXzSchool_PsEN();
string strCondition = objXzSchool_PsCond
.SetIdSchoolPs(objXzSchool_PsEN.IdSchoolPs, "=")
.GetCombineCondition();
objXzSchool_PsEN._IsCheckProperty = true;
bool bolIsExist = clsXzSchool_PsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzSchool_PsEN.Update();
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzSchool_PsEN objXzSchool_PsEN)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzSchool_PsBL.XzSchool_PsDA.UpdateBySql2(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzSchool_PsEN objXzSchool_PsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzSchool_PsBL.XzSchool_PsDA.UpdateBySql2(objXzSchool_PsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzSchool_PsEN objXzSchool_PsEN, string strWhereCond)
{
try
{
bool bolResult = clsXzSchool_PsBL.XzSchool_PsDA.UpdateBySqlWithCondition(objXzSchool_PsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzSchool_PsEN objXzSchool_PsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzSchool_PsBL.XzSchool_PsDA.UpdateBySqlWithConditionTransaction(objXzSchool_PsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "strIdSchoolPs">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzSchool_PsEN objXzSchool_PsEN)
{
try
{
int intRecNum = clsXzSchool_PsBL.XzSchool_PsDA.DelRecord(objXzSchool_PsEN.IdSchoolPs);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsENS">源对象</param>
 /// <param name = "objXzSchool_PsENT">目标对象</param>
 public static void CopyTo(this clsXzSchool_PsEN objXzSchool_PsENS, clsXzSchool_PsEN objXzSchool_PsENT)
{
try
{
objXzSchool_PsENT.IdSchoolPs = objXzSchool_PsENS.IdSchoolPs; //学校流水号
objXzSchool_PsENT.SchoolId = objXzSchool_PsENS.SchoolId; //学校编号
objXzSchool_PsENT.SchoolName = objXzSchool_PsENS.SchoolName; //学校名称
objXzSchool_PsENT.OrderNum = objXzSchool_PsENS.OrderNum; //序号
objXzSchool_PsENT.IsVisible = objXzSchool_PsENS.IsVisible; //是否显示
objXzSchool_PsENT.UpdDate = objXzSchool_PsENS.UpdDate; //修改日期
objXzSchool_PsENT.UpdUserId = objXzSchool_PsENS.UpdUserId; //修改用户Id
objXzSchool_PsENT.Memo = objXzSchool_PsENS.Memo; //备注
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
 /// <param name = "objXzSchool_PsENS">源对象</param>
 /// <returns>目标对象=>clsXzSchool_PsEN:objXzSchool_PsENT</returns>
 public static clsXzSchool_PsEN CopyTo(this clsXzSchool_PsEN objXzSchool_PsENS)
{
try
{
 clsXzSchool_PsEN objXzSchool_PsENT = new clsXzSchool_PsEN()
{
IdSchoolPs = objXzSchool_PsENS.IdSchoolPs, //学校流水号
SchoolId = objXzSchool_PsENS.SchoolId, //学校编号
SchoolName = objXzSchool_PsENS.SchoolName, //学校名称
OrderNum = objXzSchool_PsENS.OrderNum, //序号
IsVisible = objXzSchool_PsENS.IsVisible, //是否显示
UpdDate = objXzSchool_PsENS.UpdDate, //修改日期
UpdUserId = objXzSchool_PsENS.UpdUserId, //修改用户Id
Memo = objXzSchool_PsENS.Memo, //备注
};
 return objXzSchool_PsENT;
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
public static void CheckPropertyNew(this clsXzSchool_PsEN objXzSchool_PsEN)
{
 clsXzSchool_PsBL.XzSchool_PsDA.CheckPropertyNew(objXzSchool_PsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzSchool_PsEN objXzSchool_PsEN)
{
 clsXzSchool_PsBL.XzSchool_PsDA.CheckProperty4Condition(objXzSchool_PsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzSchool_PsEN objXzSchool_PsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.IdSchoolPs) == true)
{
string strComparisonOpIdSchoolPs = objXzSchool_PsCond.dicFldComparisonOp[conXzSchool_Ps.IdSchoolPs];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.IdSchoolPs, objXzSchool_PsCond.IdSchoolPs, strComparisonOpIdSchoolPs);
}
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.SchoolId) == true)
{
string strComparisonOpSchoolId = objXzSchool_PsCond.dicFldComparisonOp[conXzSchool_Ps.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.SchoolId, objXzSchool_PsCond.SchoolId, strComparisonOpSchoolId);
}
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.SchoolName) == true)
{
string strComparisonOpSchoolName = objXzSchool_PsCond.dicFldComparisonOp[conXzSchool_Ps.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.SchoolName, objXzSchool_PsCond.SchoolName, strComparisonOpSchoolName);
}
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.OrderNum) == true)
{
string strComparisonOpOrderNum = objXzSchool_PsCond.dicFldComparisonOp[conXzSchool_Ps.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conXzSchool_Ps.OrderNum, objXzSchool_PsCond.OrderNum, strComparisonOpOrderNum);
}
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.IsVisible) == true)
{
if (objXzSchool_PsCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzSchool_Ps.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzSchool_Ps.IsVisible);
}
}
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.UpdDate) == true)
{
string strComparisonOpUpdDate = objXzSchool_PsCond.dicFldComparisonOp[conXzSchool_Ps.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.UpdDate, objXzSchool_PsCond.UpdDate, strComparisonOpUpdDate);
}
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objXzSchool_PsCond.dicFldComparisonOp[conXzSchool_Ps.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.UpdUserId, objXzSchool_PsCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objXzSchool_PsCond.IsUpdated(conXzSchool_Ps.Memo) == true)
{
string strComparisonOpMemo = objXzSchool_PsCond.dicFldComparisonOp[conXzSchool_Ps.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.Memo, objXzSchool_PsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzSchool_Ps
{
public virtual bool UpdRelaTabDate(string strIdSchoolPs, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学校_Ps(XzSchool_Ps)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzSchool_PsBL
{
public static RelatedActions_XzSchool_Ps relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzSchool_PsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzSchool_PsDA XzSchool_PsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzSchool_PsDA();
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
 public clsXzSchool_PsBL()
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
if (string.IsNullOrEmpty(clsXzSchool_PsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzSchool_PsEN._ConnectString);
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
public static DataTable GetDataTable_XzSchool_Ps(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzSchool_PsDA.GetDataTable_XzSchool_Ps(strWhereCond);
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
objDT = XzSchool_PsDA.GetDataTable(strWhereCond);
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
objDT = XzSchool_PsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzSchool_PsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzSchool_PsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzSchool_PsDA.GetDataTable_Top(objTopPara);
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
objDT = XzSchool_PsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzSchool_PsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzSchool_PsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSchoolPsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLstByIdSchoolPsLst(List<string> arrIdSchoolPsLst)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSchoolPsLst, true);
 string strWhereCond = string.Format("IdSchoolPs in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSchoolPsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzSchool_PsEN> GetObjLstByIdSchoolPsLstCache(List<string> arrIdSchoolPsLst)
{
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel =
arrXzSchool_PsObjLstCache
.Where(x => arrIdSchoolPsLst.Contains(x.IdSchoolPs));
return arrXzSchool_PsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLst(string strWhereCond)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
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
public static List<clsXzSchool_PsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzSchool_PsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzSchool_PsEN> GetSubObjLstCache(clsXzSchool_PsEN objXzSchool_PsCond)
{
List<clsXzSchool_PsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchool_PsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzSchool_Ps.AttributeName)
{
if (objXzSchool_PsCond.IsUpdated(strFldName) == false) continue;
if (objXzSchool_PsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchool_PsCond[strFldName].ToString());
}
else
{
if (objXzSchool_PsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzSchool_PsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchool_PsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzSchool_PsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzSchool_PsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzSchool_PsCond[strFldName]));
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
public static List<clsXzSchool_PsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
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
public static List<clsXzSchool_PsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
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
List<clsXzSchool_PsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzSchool_PsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchool_PsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzSchool_PsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
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
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
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
public static List<clsXzSchool_PsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzSchool_PsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
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
public static List<clsXzSchool_PsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzSchool_PsEN> arrObjLst = new List<clsXzSchool_PsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN();
try
{
objXzSchool_PsEN.IdSchoolPs = objRow[conXzSchool_Ps.IdSchoolPs].ToString().Trim(); //学校流水号
objXzSchool_PsEN.SchoolId = objRow[conXzSchool_Ps.SchoolId].ToString().Trim(); //学校编号
objXzSchool_PsEN.SchoolName = objRow[conXzSchool_Ps.SchoolName].ToString().Trim(); //学校名称
objXzSchool_PsEN.OrderNum = objRow[conXzSchool_Ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzSchool_Ps.OrderNum].ToString().Trim()); //序号
objXzSchool_PsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzSchool_Ps.IsVisible].ToString().Trim()); //是否显示
objXzSchool_PsEN.UpdDate = objRow[conXzSchool_Ps.UpdDate] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdDate].ToString().Trim(); //修改日期
objXzSchool_PsEN.UpdUserId = objRow[conXzSchool_Ps.UpdUserId] == DBNull.Value ? null : objRow[conXzSchool_Ps.UpdUserId].ToString().Trim(); //修改用户Id
objXzSchool_PsEN.Memo = objRow[conXzSchool_Ps.Memo] == DBNull.Value ? null : objRow[conXzSchool_Ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzSchool_PsEN.IdSchoolPs, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzSchool_PsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzSchool_Ps(ref clsXzSchool_PsEN objXzSchool_PsEN)
{
bool bolResult = XzSchool_PsDA.GetXzSchool_Ps(ref objXzSchool_PsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSchoolPs">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchool_PsEN GetObjByIdSchoolPs(string strIdSchoolPs)
{
if (strIdSchoolPs.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSchoolPs]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSchoolPs) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSchoolPs]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzSchool_PsEN objXzSchool_PsEN = XzSchool_PsDA.GetObjByIdSchoolPs(strIdSchoolPs);
return objXzSchool_PsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzSchool_PsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzSchool_PsEN objXzSchool_PsEN = XzSchool_PsDA.GetFirstObj(strWhereCond);
 return objXzSchool_PsEN;
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
public static clsXzSchool_PsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzSchool_PsEN objXzSchool_PsEN = XzSchool_PsDA.GetObjByDataRow(objRow);
 return objXzSchool_PsEN;
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
public static clsXzSchool_PsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzSchool_PsEN objXzSchool_PsEN = XzSchool_PsDA.GetObjByDataRow(objRow);
 return objXzSchool_PsEN;
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
 /// <param name = "strIdSchoolPs">所给的关键字</param>
 /// <param name = "lstXzSchool_PsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchool_PsEN GetObjByIdSchoolPsFromList(string strIdSchoolPs, List<clsXzSchool_PsEN> lstXzSchool_PsObjLst)
{
foreach (clsXzSchool_PsEN objXzSchool_PsEN in lstXzSchool_PsObjLst)
{
if (objXzSchool_PsEN.IdSchoolPs == strIdSchoolPs)
{
return objXzSchool_PsEN;
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
 string strIdSchoolPs;
 try
 {
 strIdSchoolPs = new clsXzSchool_PsDA().GetFirstID(strWhereCond);
 return strIdSchoolPs;
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
 arrList = XzSchool_PsDA.GetID(strWhereCond);
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
bool bolIsExist = XzSchool_PsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSchoolPs">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSchoolPs)
{
if (string.IsNullOrEmpty(strIdSchoolPs) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSchoolPs]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzSchool_PsDA.IsExist(strIdSchoolPs);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdSchoolPs">学校流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdSchoolPs, string strOpUser)
{
clsXzSchool_PsEN objXzSchool_PsEN = clsXzSchool_PsBL.GetObjByIdSchoolPs(strIdSchoolPs);
objXzSchool_PsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objXzSchool_PsEN.UpdUserId = strOpUser;
return clsXzSchool_PsBL.UpdateBySql2(objXzSchool_PsEN);
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
 bolIsExist = clsXzSchool_PsDA.IsExistTable();
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
 bolIsExist = XzSchool_PsDA.IsExistTable(strTabName);
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzSchool_PsEN objXzSchool_PsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchool_PsBL.IsExist(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchool_PsEN.IdSchoolPs, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = XzSchool_PsDA.AddNewRecordBySQL2(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzSchool_PsEN objXzSchool_PsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchool_PsBL.IsExist(objXzSchool_PsEN.IdSchoolPs) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchool_PsEN.IdSchoolPs, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = XzSchool_PsDA.AddNewRecordBySQL2WithReturnKey(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzSchool_PsEN objXzSchool_PsEN)
{
try
{
bool bolResult = XzSchool_PsDA.Update(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzSchool_PsEN objXzSchool_PsEN)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.IdSchoolPs) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzSchool_PsDA.UpdateBySql2(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsBL.ReFreshCache();

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
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
 /// <param name = "strIdSchoolPs">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdSchoolPs)
{
try
{
 clsXzSchool_PsEN objXzSchool_PsEN = clsXzSchool_PsBL.GetObjByIdSchoolPs(strIdSchoolPs);

if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(objXzSchool_PsEN.IdSchoolPs, objXzSchool_PsEN.UpdUserId);
}
if (objXzSchool_PsEN != null)
{
int intRecNum = XzSchool_PsDA.DelRecord(strIdSchoolPs);
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
/// <param name="strIdSchoolPs">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdSchoolPs )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzSchool_PsDA.GetSpecSQLObj();
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
//删除与表:[XzSchool_Ps]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzSchool_Ps.IdSchoolPs,
//strIdSchoolPs);
//        clsXzSchool_PsBL.DelXzSchool_PssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzSchool_PsBL.DelRecord(strIdSchoolPs, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzSchool_PsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSchoolPs, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdSchoolPs">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdSchoolPs, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzSchool_PsBL.relatedActions != null)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(strIdSchoolPs, "UpdRelaTabDate");
}
bool bolResult = XzSchool_PsDA.DelRecord(strIdSchoolPs,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdSchoolPsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzSchool_Pss(List<string> arrIdSchoolPsLst)
{
if (arrIdSchoolPsLst.Count == 0) return 0;
try
{
if (clsXzSchool_PsBL.relatedActions != null)
{
foreach (var strIdSchoolPs in arrIdSchoolPsLst)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(strIdSchoolPs, "UpdRelaTabDate");
}
}
int intDelRecNum = XzSchool_PsDA.DelXzSchool_Ps(arrIdSchoolPsLst);
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
public static int DelXzSchool_PssByCond(string strWhereCond)
{
try
{
if (clsXzSchool_PsBL.relatedActions != null)
{
List<string> arrIdSchoolPs = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdSchoolPs in arrIdSchoolPs)
{
clsXzSchool_PsBL.relatedActions.UpdRelaTabDate(strIdSchoolPs, "UpdRelaTabDate");
}
}
int intRecNum = XzSchool_PsDA.DelXzSchool_Ps(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzSchool_Ps]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdSchoolPs">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdSchoolPs)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzSchool_PsDA.GetSpecSQLObj();
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
//删除与表:[XzSchool_Ps]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzSchool_PsBL.DelRecord(strIdSchoolPs, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzSchool_PsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSchoolPs, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzSchool_PsENS">源对象</param>
 /// <param name = "objXzSchool_PsENT">目标对象</param>
 public static void CopyTo(clsXzSchool_PsEN objXzSchool_PsENS, clsXzSchool_PsEN objXzSchool_PsENT)
{
try
{
objXzSchool_PsENT.IdSchoolPs = objXzSchool_PsENS.IdSchoolPs; //学校流水号
objXzSchool_PsENT.SchoolId = objXzSchool_PsENS.SchoolId; //学校编号
objXzSchool_PsENT.SchoolName = objXzSchool_PsENS.SchoolName; //学校名称
objXzSchool_PsENT.OrderNum = objXzSchool_PsENS.OrderNum; //序号
objXzSchool_PsENT.IsVisible = objXzSchool_PsENS.IsVisible; //是否显示
objXzSchool_PsENT.UpdDate = objXzSchool_PsENS.UpdDate; //修改日期
objXzSchool_PsENT.UpdUserId = objXzSchool_PsENS.UpdUserId; //修改用户Id
objXzSchool_PsENT.Memo = objXzSchool_PsENS.Memo; //备注
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
 /// <param name = "objXzSchool_PsEN">源简化对象</param>
 public static void SetUpdFlag(clsXzSchool_PsEN objXzSchool_PsEN)
{
try
{
objXzSchool_PsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzSchool_PsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzSchool_Ps.IdSchoolPs, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.IdSchoolPs = objXzSchool_PsEN.IdSchoolPs; //学校流水号
}
if (arrFldSet.Contains(conXzSchool_Ps.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.SchoolId = objXzSchool_PsEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(conXzSchool_Ps.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.SchoolName = objXzSchool_PsEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(conXzSchool_Ps.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.OrderNum = objXzSchool_PsEN.OrderNum; //序号
}
if (arrFldSet.Contains(conXzSchool_Ps.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.IsVisible = objXzSchool_PsEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conXzSchool_Ps.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.UpdDate = objXzSchool_PsEN.UpdDate == "[null]" ? null :  objXzSchool_PsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conXzSchool_Ps.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.UpdUserId = objXzSchool_PsEN.UpdUserId == "[null]" ? null :  objXzSchool_PsEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conXzSchool_Ps.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzSchool_PsEN.Memo = objXzSchool_PsEN.Memo == "[null]" ? null :  objXzSchool_PsEN.Memo; //备注
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
 /// <param name = "objXzSchool_PsEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzSchool_PsEN objXzSchool_PsEN)
{
try
{
if (objXzSchool_PsEN.UpdDate == "[null]") objXzSchool_PsEN.UpdDate = null; //修改日期
if (objXzSchool_PsEN.UpdUserId == "[null]") objXzSchool_PsEN.UpdUserId = null; //修改用户Id
if (objXzSchool_PsEN.Memo == "[null]") objXzSchool_PsEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzSchool_PsEN objXzSchool_PsEN)
{
 XzSchool_PsDA.CheckPropertyNew(objXzSchool_PsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzSchool_PsEN objXzSchool_PsEN)
{
 XzSchool_PsDA.CheckProperty4Condition(objXzSchool_PsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdSchoolPs(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzSchool_Ps.IdSchoolPs); 
List<clsXzSchool_PsEN> arrObjLst = clsXzSchool_PsBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN()
{
IdSchoolPs = "0",
SchoolName = "选[学校_Ps]..."
};
arrObjLst.Insert(0, objXzSchool_PsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzSchool_Ps.IdSchoolPs;
objComboBox.DisplayMember = conXzSchool_Ps.SchoolName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdSchoolPs(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学校_Ps]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conXzSchool_Ps.IdSchoolPs); 
IEnumerable<clsXzSchool_PsEN> arrObjLst = clsXzSchool_PsBL.GetObjLst(strCondition);
objDDL.DataValueField = conXzSchool_Ps.IdSchoolPs;
objDDL.DataTextField = conXzSchool_Ps.SchoolName;
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
public static void BindDdl_IdSchoolPsCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学校_Ps]...","0");
List<clsXzSchool_PsEN> arrXzSchool_PsObjLst = GetAllXzSchool_PsObjLstCache(); 
objDDL.DataValueField = conXzSchool_Ps.IdSchoolPs;
objDDL.DataTextField = conXzSchool_Ps.SchoolName;
objDDL.DataSource = arrXzSchool_PsObjLst;
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
if (clsXzSchool_PsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsBL没有刷新缓存机制(clsXzSchool_PsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSchoolPs");
//if (arrXzSchool_PsObjLstCache == null)
//{
//arrXzSchool_PsObjLstCache = XzSchool_PsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSchoolPs">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchool_PsEN GetObjByIdSchoolPsCache(string strIdSchoolPs)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel =
arrXzSchool_PsObjLstCache
.Where(x=> x.IdSchoolPs == strIdSchoolPs 
);
if (arrXzSchool_PsObjLst_Sel.Count() == 0)
{
   clsXzSchool_PsEN obj = clsXzSchool_PsBL.GetObjByIdSchoolPs(strIdSchoolPs);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzSchool_PsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchoolPs">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByIdSchoolPsCache(string strIdSchoolPs)
{
if (string.IsNullOrEmpty(strIdSchoolPs) == true) return "";
//获取缓存中的对象列表
clsXzSchool_PsEN objXzSchool_Ps = GetObjByIdSchoolPsCache(strIdSchoolPs);
if (objXzSchool_Ps == null) return "";
return objXzSchool_Ps.SchoolName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchoolPs">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSchoolPsCache(string strIdSchoolPs)
{
if (string.IsNullOrEmpty(strIdSchoolPs) == true) return "";
//获取缓存中的对象列表
clsXzSchool_PsEN objXzSchool_Ps = GetObjByIdSchoolPsCache(strIdSchoolPs);
if (objXzSchool_Ps == null) return "";
return objXzSchool_Ps.SchoolName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchool_PsEN> GetAllXzSchool_PsObjLstCache()
{
//获取缓存中的对象列表
List<clsXzSchool_PsEN> arrXzSchool_PsObjLstCache = GetObjLstCache(); 
return arrXzSchool_PsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzSchool_PsObjLstCache;
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
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzSchool_PsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzSchool_PsEN._RefreshTimeLst.Count == 0) return "";
return clsXzSchool_PsEN._RefreshTimeLst[clsXzSchool_PsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzSchool_PsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzSchool_PsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzSchool_PsBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdSchoolPs)
{
if (strInFldName != conXzSchool_Ps.IdSchoolPs)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzSchool_Ps.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzSchool_Ps.AttributeName));
throw new Exception(strMsg);
}
var objXzSchool_Ps = clsXzSchool_PsBL.GetObjByIdSchoolPsCache(strIdSchoolPs);
if (objXzSchool_Ps == null) return "";
return objXzSchool_Ps[strOutFldName].ToString();
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
int intRecCount = clsXzSchool_PsDA.GetRecCount(strTabName);
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
int intRecCount = clsXzSchool_PsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzSchool_PsDA.GetRecCount();
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
int intRecCount = clsXzSchool_PsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzSchool_PsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzSchool_PsEN objXzSchool_PsCond)
{
List<clsXzSchool_PsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchool_PsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzSchool_Ps.AttributeName)
{
if (objXzSchool_PsCond.IsUpdated(strFldName) == false) continue;
if (objXzSchool_PsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchool_PsCond[strFldName].ToString());
}
else
{
if (objXzSchool_PsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzSchool_PsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzSchool_PsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzSchool_PsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzSchool_PsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzSchool_PsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzSchool_PsCond[strFldName]));
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
 List<string> arrList = clsXzSchool_PsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzSchool_PsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzSchool_PsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzSchool_PsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzSchool_PsDA.SetFldValue(clsXzSchool_PsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzSchool_PsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzSchool_PsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzSchool_PsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzSchool_PsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzSchool_Ps] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchoolPs char(4) primary key, "); 
 // /**学校编号*/ 
 strCreateTabCode.Append(" SchoolId varchar(10) not Null, "); 
 // /**学校名称*/ 
 strCreateTabCode.Append(" SchoolName varchar(50) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
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
 /// 学校_Ps(XzSchool_Ps)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzSchool_Ps : clsCommFun4BL
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
clsXzSchool_PsBL.ReFreshThisCache();
}
}

}