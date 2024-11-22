
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubResBL
 表名:PaperSubRes(01120963)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsPaperSubResBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubResId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubResEN GetObj(this K_PaperSubResId_PaperSubRes myKey)
{
clsPaperSubResEN objPaperSubResEN = clsPaperSubResBL.PaperSubResDA.GetObjByPaperSubResId(myKey.Value);
return objPaperSubResEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperSubResEN objPaperSubResEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubResEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],子资源名称 = [{1}]的数据已经存在!(in clsPaperSubResBL.AddNewRecord)", objPaperSubResEN.IdCurrEduCls,objPaperSubResEN.PaperSubResName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPaperSubResBL.PaperSubResDA.AddNewRecordBySQL2(objPaperSubResEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
public static bool AddRecordEx(this clsPaperSubResEN objPaperSubResEN, bool bolIsNeedCheckUniqueness = true)
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
objPaperSubResEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPaperSubResEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],子资源名称(PaperSubResName)=[{1}])已经存在,不能重复!", objPaperSubResEN.IdCurrEduCls, objPaperSubResEN.PaperSubResName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPaperSubResEN.AddNewRecord();
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
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPaperSubResEN objPaperSubResEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPaperSubResEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],子资源名称 = [{1}]的数据已经存在!(in clsPaperSubResBL.AddNewRecordWithReturnKey)", objPaperSubResEN.IdCurrEduCls,objPaperSubResEN.PaperSubResName);
throw new Exception(strMsg);
}
try
{
string strKey = clsPaperSubResBL.PaperSubResDA.AddNewRecordBySQL2WithReturnKey(objPaperSubResEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetPaperSubResId(this clsPaperSubResEN objPaperSubResEN, long lngPaperSubResId, string strComparisonOp="")
	{
objPaperSubResEN.PaperSubResId = lngPaperSubResId; //论文子资源Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.PaperSubResId) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.PaperSubResId, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.PaperSubResId] = strComparisonOp;
}
}
return objPaperSubResEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetPaperSubResName(this clsPaperSubResEN objPaperSubResEN, string strPaperSubResName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperSubResName, 200, conPaperSubRes.PaperSubResName);
}
objPaperSubResEN.PaperSubResName = strPaperSubResName; //子资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.PaperSubResName) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.PaperSubResName, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.PaperSubResName] = strComparisonOp;
}
}
return objPaperSubResEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetPaperSubResTypeId(this clsPaperSubResEN objPaperSubResEN, string strPaperSubResTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperSubResTypeId, conPaperSubRes.PaperSubResTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperSubResTypeId, 4, conPaperSubRes.PaperSubResTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperSubResTypeId, 4, conPaperSubRes.PaperSubResTypeId);
}
objPaperSubResEN.PaperSubResTypeId = strPaperSubResTypeId; //论文子资源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.PaperSubResTypeId) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.PaperSubResTypeId, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.PaperSubResTypeId] = strComparisonOp;
}
}
return objPaperSubResEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetFilePath(this clsPaperSubResEN objPaperSubResEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conPaperSubRes.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conPaperSubRes.FilePath);
}
objPaperSubResEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.FilePath) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.FilePath, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.FilePath] = strComparisonOp;
}
}
return objPaperSubResEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetIdCurrEduCls(this clsPaperSubResEN objPaperSubResEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conPaperSubRes.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conPaperSubRes.IdCurrEduCls);
}
objPaperSubResEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.IdCurrEduCls) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.IdCurrEduCls, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.IdCurrEduCls] = strComparisonOp;
}
}
return objPaperSubResEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetUpdUserId(this clsPaperSubResEN objPaperSubResEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPaperSubRes.UpdUserId);
}
objPaperSubResEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.UpdUserId) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.UpdUserId, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.UpdUserId] = strComparisonOp;
}
}
return objPaperSubResEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetUpdDate(this clsPaperSubResEN objPaperSubResEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperSubRes.UpdDate);
}
objPaperSubResEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.UpdDate) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.UpdDate, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.UpdDate] = strComparisonOp;
}
}
return objPaperSubResEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPaperSubResEN SetMemo(this clsPaperSubResEN objPaperSubResEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPaperSubRes.Memo);
}
objPaperSubResEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubResEN.dicFldComparisonOp.ContainsKey(conPaperSubRes.Memo) == false)
{
objPaperSubResEN.dicFldComparisonOp.Add(conPaperSubRes.Memo, strComparisonOp);
}
else
{
objPaperSubResEN.dicFldComparisonOp[conPaperSubRes.Memo] = strComparisonOp;
}
}
return objPaperSubResEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPaperSubResEN objPaperSubResEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPaperSubResEN.CheckPropertyNew();
clsPaperSubResEN objPaperSubResCond = new clsPaperSubResEN();
string strCondition = objPaperSubResCond
.SetPaperSubResId(objPaperSubResEN.PaperSubResId, "<>")
.SetIdCurrEduCls(objPaperSubResEN.IdCurrEduCls, "=")
.SetPaperSubResName(objPaperSubResEN.PaperSubResName, "=")
.GetCombineCondition();
objPaperSubResEN._IsCheckProperty = true;
bool bolIsExist = clsPaperSubResBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPaperSubResEN.Update();
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
 /// <param name = "objPaperSubRes">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPaperSubResEN objPaperSubRes)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPaperSubResEN objPaperSubResCond = new clsPaperSubResEN();
string strCondition = objPaperSubResCond
.SetIdCurrEduCls(objPaperSubRes.IdCurrEduCls, "=")
.SetPaperSubResName(objPaperSubRes.PaperSubResName, "=")
.GetCombineCondition();
objPaperSubRes._IsCheckProperty = true;
bool bolIsExist = clsPaperSubResBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPaperSubRes.PaperSubResId = clsPaperSubResBL.GetFirstID_S(strCondition);
objPaperSubRes.UpdateWithCondition(strCondition);
}
else
{
objPaperSubRes.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubResEN objPaperSubResEN)
{
 if (objPaperSubResEN.PaperSubResId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubResBL.PaperSubResDA.UpdateBySql2(objPaperSubResEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubResEN objPaperSubResEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperSubResEN.PaperSubResId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPaperSubResBL.PaperSubResDA.UpdateBySql2(objPaperSubResEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubResEN objPaperSubResEN, string strWhereCond)
{
try
{
bool bolResult = clsPaperSubResBL.PaperSubResDA.UpdateBySqlWithCondition(objPaperSubResEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubResEN objPaperSubResEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPaperSubResBL.PaperSubResDA.UpdateBySqlWithConditionTransaction(objPaperSubResEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "lngPaperSubResId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPaperSubResEN objPaperSubResEN)
{
try
{
int intRecNum = clsPaperSubResBL.PaperSubResDA.DelRecord(objPaperSubResEN.PaperSubResId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResENS">源对象</param>
 /// <param name = "objPaperSubResENT">目标对象</param>
 public static void CopyTo(this clsPaperSubResEN objPaperSubResENS, clsPaperSubResEN objPaperSubResENT)
{
try
{
objPaperSubResENT.PaperSubResId = objPaperSubResENS.PaperSubResId; //论文子资源Id
objPaperSubResENT.PaperSubResName = objPaperSubResENS.PaperSubResName; //子资源名称
objPaperSubResENT.PaperSubResTypeId = objPaperSubResENS.PaperSubResTypeId; //论文子资源类型Id
objPaperSubResENT.FilePath = objPaperSubResENS.FilePath; //文件路径
objPaperSubResENT.IdCurrEduCls = objPaperSubResENS.IdCurrEduCls; //教学班流水号
objPaperSubResENT.UpdUserId = objPaperSubResENS.UpdUserId; //修改用户Id
objPaperSubResENT.UpdDate = objPaperSubResENS.UpdDate; //修改日期
objPaperSubResENT.Memo = objPaperSubResENS.Memo; //备注
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
 /// <param name = "objPaperSubResENS">源对象</param>
 /// <returns>目标对象=>clsPaperSubResEN:objPaperSubResENT</returns>
 public static clsPaperSubResEN CopyTo(this clsPaperSubResEN objPaperSubResENS)
{
try
{
 clsPaperSubResEN objPaperSubResENT = new clsPaperSubResEN()
{
PaperSubResId = objPaperSubResENS.PaperSubResId, //论文子资源Id
PaperSubResName = objPaperSubResENS.PaperSubResName, //子资源名称
PaperSubResTypeId = objPaperSubResENS.PaperSubResTypeId, //论文子资源类型Id
FilePath = objPaperSubResENS.FilePath, //文件路径
IdCurrEduCls = objPaperSubResENS.IdCurrEduCls, //教学班流水号
UpdUserId = objPaperSubResENS.UpdUserId, //修改用户Id
UpdDate = objPaperSubResENS.UpdDate, //修改日期
Memo = objPaperSubResENS.Memo, //备注
};
 return objPaperSubResENT;
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
public static void CheckPropertyNew(this clsPaperSubResEN objPaperSubResEN)
{
 clsPaperSubResBL.PaperSubResDA.CheckPropertyNew(objPaperSubResEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPaperSubResEN objPaperSubResEN)
{
 clsPaperSubResBL.PaperSubResDA.CheckProperty4Condition(objPaperSubResEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperSubResEN objPaperSubResCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperSubResCond.IsUpdated(conPaperSubRes.PaperSubResId) == true)
{
string strComparisonOpPaperSubResId = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.PaperSubResId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubRes.PaperSubResId, objPaperSubResCond.PaperSubResId, strComparisonOpPaperSubResId);
}
if (objPaperSubResCond.IsUpdated(conPaperSubRes.PaperSubResName) == true)
{
string strComparisonOpPaperSubResName = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.PaperSubResName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubRes.PaperSubResName, objPaperSubResCond.PaperSubResName, strComparisonOpPaperSubResName);
}
if (objPaperSubResCond.IsUpdated(conPaperSubRes.PaperSubResTypeId) == true)
{
string strComparisonOpPaperSubResTypeId = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.PaperSubResTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubRes.PaperSubResTypeId, objPaperSubResCond.PaperSubResTypeId, strComparisonOpPaperSubResTypeId);
}
if (objPaperSubResCond.IsUpdated(conPaperSubRes.FilePath) == true)
{
string strComparisonOpFilePath = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubRes.FilePath, objPaperSubResCond.FilePath, strComparisonOpFilePath);
}
if (objPaperSubResCond.IsUpdated(conPaperSubRes.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubRes.IdCurrEduCls, objPaperSubResCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objPaperSubResCond.IsUpdated(conPaperSubRes.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubRes.UpdUserId, objPaperSubResCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPaperSubResCond.IsUpdated(conPaperSubRes.UpdDate) == true)
{
string strComparisonOpUpdDate = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubRes.UpdDate, objPaperSubResCond.UpdDate, strComparisonOpUpdDate);
}
if (objPaperSubResCond.IsUpdated(conPaperSubRes.Memo) == true)
{
string strComparisonOpMemo = objPaperSubResCond.dicFldComparisonOp[conPaperSubRes.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubRes.Memo, objPaperSubResCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PaperSubRes(论文子资源), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:IdCurrEduCls_PaperSubResName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPaperSubResEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPaperSubResEN objPaperSubResEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubResEN == null) return true;
if (objPaperSubResEN.PaperSubResId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperSubResEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objPaperSubResEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objPaperSubResEN.IdCurrEduCls);
}
 if (objPaperSubResEN.PaperSubResName == null)
{
 sbCondition.AppendFormat(" and PaperSubResName is null", objPaperSubResEN.PaperSubResName);
}
else
{
 sbCondition.AppendFormat(" and PaperSubResName = '{0}'", objPaperSubResEN.PaperSubResName);
}
if (clsPaperSubResBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperSubResId !=  {0}", objPaperSubResEN.PaperSubResId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objPaperSubResEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and PaperSubResName = '{0}'", objPaperSubResEN.PaperSubResName);
if (clsPaperSubResBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PaperSubRes(论文子资源), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:IdCurrEduCls_PaperSubResName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperSubResEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPaperSubResEN objPaperSubResEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubResEN == null) return "";
if (objPaperSubResEN.PaperSubResId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objPaperSubResEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objPaperSubResEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objPaperSubResEN.IdCurrEduCls);
}
 if (objPaperSubResEN.PaperSubResName == null)
{
 sbCondition.AppendFormat(" and PaperSubResName is null", objPaperSubResEN.PaperSubResName);
}
else
{
 sbCondition.AppendFormat(" and PaperSubResName = '{0}'", objPaperSubResEN.PaperSubResName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperSubResId !=  {0}", objPaperSubResEN.PaperSubResId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objPaperSubResEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and PaperSubResName = '{0}'", objPaperSubResEN.PaperSubResName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PaperSubRes
{
public virtual bool UpdRelaTabDate(long lngPaperSubResId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文子资源(PaperSubRes)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPaperSubResBL
{
public static RelatedActions_PaperSubRes relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPaperSubResDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPaperSubResDA PaperSubResDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPaperSubResDA();
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
 public clsPaperSubResBL()
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
if (string.IsNullOrEmpty(clsPaperSubResEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperSubResEN._ConnectString);
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
public static DataTable GetDataTable_PaperSubRes(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PaperSubResDA.GetDataTable_PaperSubRes(strWhereCond);
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
objDT = PaperSubResDA.GetDataTable(strWhereCond);
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
objDT = PaperSubResDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PaperSubResDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PaperSubResDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PaperSubResDA.GetDataTable_Top(objTopPara);
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
objDT = PaperSubResDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PaperSubResDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PaperSubResDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperSubResIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPaperSubResEN> GetObjLstByPaperSubResIdLst(List<long> arrPaperSubResIdLst)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperSubResIdLst);
 string strWhereCond = string.Format("PaperSubResId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperSubResIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPaperSubResEN> GetObjLstByPaperSubResIdLstCache(List<long> arrPaperSubResIdLst)
{
string strKey = string.Format("{0}", clsPaperSubResEN._CurrTabName);
List<clsPaperSubResEN> arrPaperSubResObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResEN> arrPaperSubResObjLst_Sel =
arrPaperSubResObjLstCache
.Where(x => arrPaperSubResIdLst.Contains(x.PaperSubResId));
return arrPaperSubResObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubResEN> GetObjLst(string strWhereCond)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
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
public static List<clsPaperSubResEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPaperSubResCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPaperSubResEN> GetSubObjLstCache(clsPaperSubResEN objPaperSubResCond)
{
List<clsPaperSubResEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubRes.AttributeName)
{
if (objPaperSubResCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubResCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResCond[strFldName].ToString());
}
else
{
if (objPaperSubResCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubResCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubResCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubResCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubResCond[strFldName]));
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
public static List<clsPaperSubResEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
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
public static List<clsPaperSubResEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
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
List<clsPaperSubResEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPaperSubResEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubResEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPaperSubResEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
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
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
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
public static List<clsPaperSubResEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPaperSubResEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPaperSubResEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
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
public static List<clsPaperSubResEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubResEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPaperSubResEN> arrObjLst = new List<clsPaperSubResEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubResEN objPaperSubResEN = new clsPaperSubResEN();
try
{
objPaperSubResEN.PaperSubResId = Int32.Parse(objRow[conPaperSubRes.PaperSubResId].ToString().Trim()); //论文子资源Id
objPaperSubResEN.PaperSubResName = objRow[conPaperSubRes.PaperSubResName] == DBNull.Value ? null : objRow[conPaperSubRes.PaperSubResName].ToString().Trim(); //子资源名称
objPaperSubResEN.PaperSubResTypeId = objRow[conPaperSubRes.PaperSubResTypeId].ToString().Trim(); //论文子资源类型Id
objPaperSubResEN.FilePath = objRow[conPaperSubRes.FilePath].ToString().Trim(); //文件路径
objPaperSubResEN.IdCurrEduCls = objRow[conPaperSubRes.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperSubRes.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperSubResEN.UpdUserId = objRow[conPaperSubRes.UpdUserId] == DBNull.Value ? null : objRow[conPaperSubRes.UpdUserId].ToString().Trim(); //修改用户Id
objPaperSubResEN.UpdDate = objRow[conPaperSubRes.UpdDate] == DBNull.Value ? null : objRow[conPaperSubRes.UpdDate].ToString().Trim(); //修改日期
objPaperSubResEN.Memo = objRow[conPaperSubRes.Memo] == DBNull.Value ? null : objRow[conPaperSubRes.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPaperSubResEN.PaperSubResId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPaperSubResEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPaperSubResEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPaperSubRes(ref clsPaperSubResEN objPaperSubResEN)
{
bool bolResult = PaperSubResDA.GetPaperSubRes(ref objPaperSubResEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubResId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubResEN GetObjByPaperSubResId(long lngPaperSubResId)
{
clsPaperSubResEN objPaperSubResEN = PaperSubResDA.GetObjByPaperSubResId(lngPaperSubResId);
return objPaperSubResEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPaperSubResEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPaperSubResEN objPaperSubResEN = PaperSubResDA.GetFirstObj(strWhereCond);
 return objPaperSubResEN;
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
public static clsPaperSubResEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPaperSubResEN objPaperSubResEN = PaperSubResDA.GetObjByDataRow(objRow);
 return objPaperSubResEN;
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
public static clsPaperSubResEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPaperSubResEN objPaperSubResEN = PaperSubResDA.GetObjByDataRow(objRow);
 return objPaperSubResEN;
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
 /// <param name = "lngPaperSubResId">所给的关键字</param>
 /// <param name = "lstPaperSubResObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubResEN GetObjByPaperSubResIdFromList(long lngPaperSubResId, List<clsPaperSubResEN> lstPaperSubResObjLst)
{
foreach (clsPaperSubResEN objPaperSubResEN in lstPaperSubResObjLst)
{
if (objPaperSubResEN.PaperSubResId == lngPaperSubResId)
{
return objPaperSubResEN;
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
 long lngPaperSubResId;
 try
 {
 lngPaperSubResId = new clsPaperSubResDA().GetFirstID(strWhereCond);
 return lngPaperSubResId;
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
 arrList = PaperSubResDA.GetID(strWhereCond);
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
bool bolIsExist = PaperSubResDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperSubResId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperSubResId)
{
//检测记录是否存在
bool bolIsExist = PaperSubResDA.IsExist(lngPaperSubResId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngPaperSubResId">论文子资源Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngPaperSubResId, string strOpUser)
{
clsPaperSubResEN objPaperSubResEN = clsPaperSubResBL.GetObjByPaperSubResId(lngPaperSubResId);
objPaperSubResEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPaperSubResEN.UpdUserId = strOpUser;
return clsPaperSubResBL.UpdateBySql2(objPaperSubResEN);
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
 bolIsExist = clsPaperSubResDA.IsExistTable();
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
 bolIsExist = PaperSubResDA.IsExistTable(strTabName);
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
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPaperSubResEN objPaperSubResEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubResEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],子资源名称 = [{1}]的数据已经存在!(in clsPaperSubResBL.AddNewRecordBySql2)", objPaperSubResEN.IdCurrEduCls,objPaperSubResEN.PaperSubResName);
throw new Exception(strMsg);
}
try
{
bool bolResult = PaperSubResDA.AddNewRecordBySQL2(objPaperSubResEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPaperSubResEN objPaperSubResEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPaperSubResEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],子资源名称 = [{1}]的数据已经存在!(in clsPaperSubResBL.AddNewRecordBySql2WithReturnKey)", objPaperSubResEN.IdCurrEduCls,objPaperSubResEN.PaperSubResName);
throw new Exception(strMsg);
}
try
{
string strKey = PaperSubResDA.AddNewRecordBySQL2WithReturnKey(objPaperSubResEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPaperSubResEN objPaperSubResEN)
{
try
{
bool bolResult = PaperSubResDA.Update(objPaperSubResEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "objPaperSubResEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPaperSubResEN objPaperSubResEN)
{
 if (objPaperSubResEN.PaperSubResId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PaperSubResDA.UpdateBySql2(objPaperSubResEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubResBL.ReFreshCache();

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
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
 /// <param name = "lngPaperSubResId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperSubResId)
{
try
{
 clsPaperSubResEN objPaperSubResEN = clsPaperSubResBL.GetObjByPaperSubResId(lngPaperSubResId);

if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(objPaperSubResEN.PaperSubResId, objPaperSubResEN.UpdUserId);
}
if (objPaperSubResEN != null)
{
int intRecNum = PaperSubResDA.DelRecord(lngPaperSubResId);
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
/// <param name="lngPaperSubResId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperSubResId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubResDA.GetSpecSQLObj();
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
//删除与表:[PaperSubRes]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPaperSubRes.PaperSubResId,
//lngPaperSubResId);
//        clsPaperSubResBL.DelPaperSubRessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubResBL.DelRecord(lngPaperSubResId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubResBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubResId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPaperSubResId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperSubResId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPaperSubResBL.relatedActions != null)
{
clsPaperSubResBL.relatedActions.UpdRelaTabDate(lngPaperSubResId, "UpdRelaTabDate");
}
bool bolResult = PaperSubResDA.DelRecord(lngPaperSubResId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperSubResIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPaperSubRess(List<string> arrPaperSubResIdLst)
{
if (arrPaperSubResIdLst.Count == 0) return 0;
try
{
if (clsPaperSubResBL.relatedActions != null)
{
foreach (var strPaperSubResId in arrPaperSubResIdLst)
{
long lngPaperSubResId = long.Parse(strPaperSubResId);
clsPaperSubResBL.relatedActions.UpdRelaTabDate(lngPaperSubResId, "UpdRelaTabDate");
}
}
int intDelRecNum = PaperSubResDA.DelPaperSubRes(arrPaperSubResIdLst);
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
public static int DelPaperSubRessByCond(string strWhereCond)
{
try
{
if (clsPaperSubResBL.relatedActions != null)
{
List<string> arrPaperSubResId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperSubResId in arrPaperSubResId)
{
long lngPaperSubResId = long.Parse(strPaperSubResId);
clsPaperSubResBL.relatedActions.UpdRelaTabDate(lngPaperSubResId, "UpdRelaTabDate");
}
}
int intRecNum = PaperSubResDA.DelPaperSubRes(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PaperSubRes]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperSubResId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperSubResId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPaperSubResDA.GetSpecSQLObj();
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
//删除与表:[PaperSubRes]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPaperSubResBL.DelRecord(lngPaperSubResId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPaperSubResBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubResId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPaperSubResENS">源对象</param>
 /// <param name = "objPaperSubResENT">目标对象</param>
 public static void CopyTo(clsPaperSubResEN objPaperSubResENS, clsPaperSubResEN objPaperSubResENT)
{
try
{
objPaperSubResENT.PaperSubResId = objPaperSubResENS.PaperSubResId; //论文子资源Id
objPaperSubResENT.PaperSubResName = objPaperSubResENS.PaperSubResName; //子资源名称
objPaperSubResENT.PaperSubResTypeId = objPaperSubResENS.PaperSubResTypeId; //论文子资源类型Id
objPaperSubResENT.FilePath = objPaperSubResENS.FilePath; //文件路径
objPaperSubResENT.IdCurrEduCls = objPaperSubResENS.IdCurrEduCls; //教学班流水号
objPaperSubResENT.UpdUserId = objPaperSubResENS.UpdUserId; //修改用户Id
objPaperSubResENT.UpdDate = objPaperSubResENS.UpdDate; //修改日期
objPaperSubResENT.Memo = objPaperSubResENS.Memo; //备注
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
 /// <param name = "objPaperSubResEN">源简化对象</param>
 public static void SetUpdFlag(clsPaperSubResEN objPaperSubResEN)
{
try
{
objPaperSubResEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPaperSubResEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPaperSubRes.PaperSubResId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.PaperSubResId = objPaperSubResEN.PaperSubResId; //论文子资源Id
}
if (arrFldSet.Contains(conPaperSubRes.PaperSubResName, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.PaperSubResName = objPaperSubResEN.PaperSubResName == "[null]" ? null :  objPaperSubResEN.PaperSubResName; //子资源名称
}
if (arrFldSet.Contains(conPaperSubRes.PaperSubResTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.PaperSubResTypeId = objPaperSubResEN.PaperSubResTypeId; //论文子资源类型Id
}
if (arrFldSet.Contains(conPaperSubRes.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.FilePath = objPaperSubResEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conPaperSubRes.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.IdCurrEduCls = objPaperSubResEN.IdCurrEduCls == "[null]" ? null :  objPaperSubResEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conPaperSubRes.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.UpdUserId = objPaperSubResEN.UpdUserId == "[null]" ? null :  objPaperSubResEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conPaperSubRes.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.UpdDate = objPaperSubResEN.UpdDate == "[null]" ? null :  objPaperSubResEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPaperSubRes.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPaperSubResEN.Memo = objPaperSubResEN.Memo == "[null]" ? null :  objPaperSubResEN.Memo; //备注
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
 /// <param name = "objPaperSubResEN">源简化对象</param>
 public static void AccessFldValueNull(clsPaperSubResEN objPaperSubResEN)
{
try
{
if (objPaperSubResEN.PaperSubResName == "[null]") objPaperSubResEN.PaperSubResName = null; //子资源名称
if (objPaperSubResEN.IdCurrEduCls == "[null]") objPaperSubResEN.IdCurrEduCls = null; //教学班流水号
if (objPaperSubResEN.UpdUserId == "[null]") objPaperSubResEN.UpdUserId = null; //修改用户Id
if (objPaperSubResEN.UpdDate == "[null]") objPaperSubResEN.UpdDate = null; //修改日期
if (objPaperSubResEN.Memo == "[null]") objPaperSubResEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPaperSubResEN objPaperSubResEN)
{
 PaperSubResDA.CheckPropertyNew(objPaperSubResEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPaperSubResEN objPaperSubResEN)
{
 PaperSubResDA.CheckProperty4Condition(objPaperSubResEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PaperSubResIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文子资源]...","0");
List<clsPaperSubResEN> arrPaperSubResObjLst = GetAllPaperSubResObjLstCache(); 
objDDL.DataValueField = conPaperSubRes.PaperSubResId;
objDDL.DataTextField = conPaperSubRes.PaperSubResName;
objDDL.DataSource = arrPaperSubResObjLst;
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
if (clsPaperSubResBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubResBL没有刷新缓存机制(clsPaperSubResBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubResId");
//if (arrPaperSubResObjLstCache == null)
//{
//arrPaperSubResObjLstCache = PaperSubResDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubResId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubResEN GetObjByPaperSubResIdCache(long lngPaperSubResId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPaperSubResEN._CurrTabName);
List<clsPaperSubResEN> arrPaperSubResObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResEN> arrPaperSubResObjLst_Sel =
arrPaperSubResObjLstCache
.Where(x=> x.PaperSubResId == lngPaperSubResId 
);
if (arrPaperSubResObjLst_Sel.Count() == 0)
{
   clsPaperSubResEN obj = clsPaperSubResBL.GetObjByPaperSubResId(lngPaperSubResId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPaperSubResObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubResId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPaperSubResNameByPaperSubResIdCache(long lngPaperSubResId)
{
//获取缓存中的对象列表
clsPaperSubResEN objPaperSubRes = GetObjByPaperSubResIdCache(lngPaperSubResId);
if (objPaperSubRes == null) return "";
return objPaperSubRes.PaperSubResName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubResId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPaperSubResIdCache(long lngPaperSubResId)
{
//获取缓存中的对象列表
clsPaperSubResEN objPaperSubRes = GetObjByPaperSubResIdCache(lngPaperSubResId);
if (objPaperSubRes == null) return "";
return objPaperSubRes.PaperSubResName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubResEN> GetAllPaperSubResObjLstCache()
{
//获取缓存中的对象列表
List<clsPaperSubResEN> arrPaperSubResObjLstCache = GetObjLstCache(); 
return arrPaperSubResObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubResEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPaperSubResEN._CurrTabName);
List<clsPaperSubResEN> arrPaperSubResObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPaperSubResObjLstCache;
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
string strKey = string.Format("{0}", clsPaperSubResEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubResEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPaperSubResEN._RefreshTimeLst.Count == 0) return "";
return clsPaperSubResEN._RefreshTimeLst[clsPaperSubResEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPaperSubResBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPaperSubResEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPaperSubResEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPaperSubResBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PaperSubRes(论文子资源)
 /// 唯一性条件:IdCurrEduCls_PaperSubResName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperSubResEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPaperSubResEN objPaperSubResEN)
{
//检测记录是否存在
string strResult = PaperSubResDA.GetUniCondStr(objPaperSubResEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperSubResId)
{
if (strInFldName != conPaperSubRes.PaperSubResId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPaperSubRes.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPaperSubRes.AttributeName));
throw new Exception(strMsg);
}
var objPaperSubRes = clsPaperSubResBL.GetObjByPaperSubResIdCache(lngPaperSubResId);
if (objPaperSubRes == null) return "";
return objPaperSubRes[strOutFldName].ToString();
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
int intRecCount = clsPaperSubResDA.GetRecCount(strTabName);
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
int intRecCount = clsPaperSubResDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPaperSubResDA.GetRecCount();
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
int intRecCount = clsPaperSubResDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPaperSubResCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPaperSubResEN objPaperSubResCond)
{
List<clsPaperSubResEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPaperSubResEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPaperSubRes.AttributeName)
{
if (objPaperSubResCond.IsUpdated(strFldName) == false) continue;
if (objPaperSubResCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResCond[strFldName].ToString());
}
else
{
if (objPaperSubResCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPaperSubResCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPaperSubResCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPaperSubResCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPaperSubResCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPaperSubResCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPaperSubResCond[strFldName]));
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
 List<string> arrList = clsPaperSubResDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PaperSubResDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PaperSubResDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PaperSubResDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubResDA.SetFldValue(clsPaperSubResEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PaperSubResDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubResDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPaperSubResDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPaperSubResDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PaperSubRes] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文子资源Id*/ 
 strCreateTabCode.Append(" PaperSubResId bigint primary key identity, "); 
 // /**子资源名称*/ 
 strCreateTabCode.Append(" PaperSubResName varchar(200) Null, "); 
 // /**论文子资源类型Id*/ 
 strCreateTabCode.Append(" PaperSubResTypeId char(4) not Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**论文子资源类型名*/ 
 strCreateTabCode.Append(" PaperSubResTypeName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文子资源(PaperSubRes)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PaperSubRes : clsCommFun4BL
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
clsPaperSubResBL.ReFreshThisCache();
}
}

}