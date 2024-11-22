
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectPrjTabBL
 表名:CMProjectPrjTab(00050530)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:59:55
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsCMProjectPrjTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectPrjTabEN GetObj(this K_mId_CMProjectPrjTab myKey)
{
clsCMProjectPrjTabEN objCMProjectPrjTabEN = clsCMProjectPrjTabBL.CMProjectPrjTabDA.GetObjBymId(myKey.Value);
return objCMProjectPrjTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMProjectPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],CM工程Id = [{1}]的数据已经存在!(in clsCMProjectPrjTabBL.AddNewRecord)", objCMProjectPrjTabEN.TabId,objCMProjectPrjTabEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMProjectPrjTabBL.CMProjectPrjTabDA.AddNewRecordBySQL2(objCMProjectPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
public static bool AddRecordEx(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, bool bolIsNeedCheckUniqueness = true)
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
objCMProjectPrjTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMProjectPrjTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],CM工程Id(CmPrjId)=[{1}])已经存在,不能重复!", objCMProjectPrjTabEN.TabId, objCMProjectPrjTabEN.CmPrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCMProjectPrjTabEN.AddNewRecord();
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
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMProjectPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],CM工程Id = [{1}]的数据已经存在!(in clsCMProjectPrjTabBL.AddNewRecordWithReturnKey)", objCMProjectPrjTabEN.TabId,objCMProjectPrjTabEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCMProjectPrjTabBL.CMProjectPrjTabDA.AddNewRecordBySQL2WithReturnKey(objCMProjectPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectPrjTabEN SetmId(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, long lngmId, string strComparisonOp="")
	{
objCMProjectPrjTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(conCMProjectPrjTab.mId) == false)
{
objCMProjectPrjTabEN.dicFldComparisonOp.Add(conCMProjectPrjTab.mId, strComparisonOp);
}
else
{
objCMProjectPrjTabEN.dicFldComparisonOp[conCMProjectPrjTab.mId] = strComparisonOp;
}
}
return objCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectPrjTabEN SetCmPrjId(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMProjectPrjTab.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMProjectPrjTab.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMProjectPrjTab.CmPrjId);
}
objCMProjectPrjTabEN.CmPrjId = strCmPrjId; //CM工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(conCMProjectPrjTab.CmPrjId) == false)
{
objCMProjectPrjTabEN.dicFldComparisonOp.Add(conCMProjectPrjTab.CmPrjId, strComparisonOp);
}
else
{
objCMProjectPrjTabEN.dicFldComparisonOp[conCMProjectPrjTab.CmPrjId] = strComparisonOp;
}
}
return objCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectPrjTabEN SetTabId(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conCMProjectPrjTab.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conCMProjectPrjTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conCMProjectPrjTab.TabId);
}
objCMProjectPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(conCMProjectPrjTab.TabId) == false)
{
objCMProjectPrjTabEN.dicFldComparisonOp.Add(conCMProjectPrjTab.TabId, strComparisonOp);
}
else
{
objCMProjectPrjTabEN.dicFldComparisonOp[conCMProjectPrjTab.TabId] = strComparisonOp;
}
}
return objCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectPrjTabEN SetOrderNum(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMProjectPrjTab.OrderNum);
objCMProjectPrjTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(conCMProjectPrjTab.OrderNum) == false)
{
objCMProjectPrjTabEN.dicFldComparisonOp.Add(conCMProjectPrjTab.OrderNum, strComparisonOp);
}
else
{
objCMProjectPrjTabEN.dicFldComparisonOp[conCMProjectPrjTab.OrderNum] = strComparisonOp;
}
}
return objCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectPrjTabEN SetUpdDate(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMProjectPrjTab.UpdDate);
}
objCMProjectPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(conCMProjectPrjTab.UpdDate) == false)
{
objCMProjectPrjTabEN.dicFldComparisonOp.Add(conCMProjectPrjTab.UpdDate, strComparisonOp);
}
else
{
objCMProjectPrjTabEN.dicFldComparisonOp[conCMProjectPrjTab.UpdDate] = strComparisonOp;
}
}
return objCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectPrjTabEN SetUpdUser(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMProjectPrjTab.UpdUser);
}
objCMProjectPrjTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(conCMProjectPrjTab.UpdUser) == false)
{
objCMProjectPrjTabEN.dicFldComparisonOp.Add(conCMProjectPrjTab.UpdUser, strComparisonOp);
}
else
{
objCMProjectPrjTabEN.dicFldComparisonOp[conCMProjectPrjTab.UpdUser] = strComparisonOp;
}
}
return objCMProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectPrjTabEN SetMemo(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMProjectPrjTab.Memo);
}
objCMProjectPrjTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectPrjTabEN.dicFldComparisonOp.ContainsKey(conCMProjectPrjTab.Memo) == false)
{
objCMProjectPrjTabEN.dicFldComparisonOp.Add(conCMProjectPrjTab.Memo, strComparisonOp);
}
else
{
objCMProjectPrjTabEN.dicFldComparisonOp[conCMProjectPrjTab.Memo] = strComparisonOp;
}
}
return objCMProjectPrjTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMProjectPrjTabEN.CheckPropertyNew();
clsCMProjectPrjTabEN objCMProjectPrjTabCond = new clsCMProjectPrjTabEN();
string strCondition = objCMProjectPrjTabCond
.SetmId(objCMProjectPrjTabEN.mId, "<>")
.SetTabId(objCMProjectPrjTabEN.TabId, "=")
.SetCmPrjId(objCMProjectPrjTabEN.CmPrjId, "=")
.GetCombineCondition();
objCMProjectPrjTabEN._IsCheckProperty = true;
bool bolIsExist = clsCMProjectPrjTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CMPrjId_TabId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMProjectPrjTabEN.Update();
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
 /// <param name = "objCMProjectPrjTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMProjectPrjTabEN objCMProjectPrjTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMProjectPrjTabEN objCMProjectPrjTabCond = new clsCMProjectPrjTabEN();
string strCondition = objCMProjectPrjTabCond
.SetTabId(objCMProjectPrjTab.TabId, "=")
.SetCmPrjId(objCMProjectPrjTab.CmPrjId, "=")
.GetCombineCondition();
objCMProjectPrjTab._IsCheckProperty = true;
bool bolIsExist = clsCMProjectPrjTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMProjectPrjTab.mId = clsCMProjectPrjTabBL.GetFirstID_S(strCondition);
objCMProjectPrjTab.UpdateWithCondition(strCondition);
}
else
{
objCMProjectPrjTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
 if (objCMProjectPrjTabEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMProjectPrjTabBL.CMProjectPrjTabDA.UpdateBySql2(objCMProjectPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCMProjectPrjTabEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMProjectPrjTabBL.CMProjectPrjTabDA.UpdateBySql2(objCMProjectPrjTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, string strWhereCond)
{
try
{
bool bolResult = clsCMProjectPrjTabBL.CMProjectPrjTabDA.UpdateBySqlWithCondition(objCMProjectPrjTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectPrjTabEN objCMProjectPrjTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMProjectPrjTabBL.CMProjectPrjTabDA.UpdateBySqlWithConditionTransaction(objCMProjectPrjTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
public static int Delete(this clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
try
{
int intRecNum = clsCMProjectPrjTabBL.CMProjectPrjTabDA.DelRecord(objCMProjectPrjTabEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabENS">源对象</param>
 /// <param name = "objCMProjectPrjTabENT">目标对象</param>
 public static void CopyTo(this clsCMProjectPrjTabEN objCMProjectPrjTabENS, clsCMProjectPrjTabEN objCMProjectPrjTabENT)
{
try
{
objCMProjectPrjTabENT.mId = objCMProjectPrjTabENS.mId; //mId
objCMProjectPrjTabENT.CmPrjId = objCMProjectPrjTabENS.CmPrjId; //CM工程Id
objCMProjectPrjTabENT.TabId = objCMProjectPrjTabENS.TabId; //表ID
objCMProjectPrjTabENT.OrderNum = objCMProjectPrjTabENS.OrderNum; //序号
objCMProjectPrjTabENT.UpdDate = objCMProjectPrjTabENS.UpdDate; //修改日期
objCMProjectPrjTabENT.UpdUser = objCMProjectPrjTabENS.UpdUser; //修改者
objCMProjectPrjTabENT.Memo = objCMProjectPrjTabENS.Memo; //说明
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
 /// <param name = "objCMProjectPrjTabENS">源对象</param>
 /// <returns>目标对象=>clsCMProjectPrjTabEN:objCMProjectPrjTabENT</returns>
 public static clsCMProjectPrjTabEN CopyTo(this clsCMProjectPrjTabEN objCMProjectPrjTabENS)
{
try
{
 clsCMProjectPrjTabEN objCMProjectPrjTabENT = new clsCMProjectPrjTabEN()
{
mId = objCMProjectPrjTabENS.mId, //mId
CmPrjId = objCMProjectPrjTabENS.CmPrjId, //CM工程Id
TabId = objCMProjectPrjTabENS.TabId, //表ID
OrderNum = objCMProjectPrjTabENS.OrderNum, //序号
UpdDate = objCMProjectPrjTabENS.UpdDate, //修改日期
UpdUser = objCMProjectPrjTabENS.UpdUser, //修改者
Memo = objCMProjectPrjTabENS.Memo, //说明
};
 return objCMProjectPrjTabENT;
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
public static void CheckPropertyNew(this clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
 clsCMProjectPrjTabBL.CMProjectPrjTabDA.CheckPropertyNew(objCMProjectPrjTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
 clsCMProjectPrjTabBL.CMProjectPrjTabDA.CheckProperty4Condition(objCMProjectPrjTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMProjectPrjTabEN objCMProjectPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMProjectPrjTabCond.IsUpdated(conCMProjectPrjTab.mId) == true)
{
string strComparisonOpmId = objCMProjectPrjTabCond.dicFldComparisonOp[conCMProjectPrjTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectPrjTab.mId, objCMProjectPrjTabCond.mId, strComparisonOpmId);
}
if (objCMProjectPrjTabCond.IsUpdated(conCMProjectPrjTab.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMProjectPrjTabCond.dicFldComparisonOp[conCMProjectPrjTab.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectPrjTab.CmPrjId, objCMProjectPrjTabCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMProjectPrjTabCond.IsUpdated(conCMProjectPrjTab.TabId) == true)
{
string strComparisonOpTabId = objCMProjectPrjTabCond.dicFldComparisonOp[conCMProjectPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectPrjTab.TabId, objCMProjectPrjTabCond.TabId, strComparisonOpTabId);
}
if (objCMProjectPrjTabCond.IsUpdated(conCMProjectPrjTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMProjectPrjTabCond.dicFldComparisonOp[conCMProjectPrjTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectPrjTab.OrderNum, objCMProjectPrjTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMProjectPrjTabCond.IsUpdated(conCMProjectPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMProjectPrjTabCond.dicFldComparisonOp[conCMProjectPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectPrjTab.UpdDate, objCMProjectPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMProjectPrjTabCond.IsUpdated(conCMProjectPrjTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMProjectPrjTabCond.dicFldComparisonOp[conCMProjectPrjTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectPrjTab.UpdUser, objCMProjectPrjTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMProjectPrjTabCond.IsUpdated(conCMProjectPrjTab.Memo) == true)
{
string strComparisonOpMemo = objCMProjectPrjTabCond.dicFldComparisonOp[conCMProjectPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectPrjTab.Memo, objCMProjectPrjTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMProjectPrjTab(CM项目工程表关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CMPrjId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectPrjTabEN == null) return true;
if (objCMProjectPrjTabEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objCMProjectPrjTabEN.TabId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectPrjTabEN.CmPrjId);
if (clsCMProjectPrjTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMProjectPrjTabEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objCMProjectPrjTabEN.TabId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectPrjTabEN.CmPrjId);
if (clsCMProjectPrjTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMProjectPrjTab(CM项目工程表关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMPrjId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectPrjTabEN == null) return "";
if (objCMProjectPrjTabEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objCMProjectPrjTabEN.TabId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectPrjTabEN.CmPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMProjectPrjTabEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objCMProjectPrjTabEN.TabId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectPrjTabEN.CmPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMProjectPrjTab
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM项目工程表关系(CMProjectPrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMProjectPrjTabBL
{
public static RelatedActions_CMProjectPrjTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMProjectPrjTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMProjectPrjTabDA CMProjectPrjTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMProjectPrjTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsCMProjectPrjTabBL()
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
if (string.IsNullOrEmpty(clsCMProjectPrjTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMProjectPrjTabEN._ConnectString);
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
public static DataTable GetDataTable_CMProjectPrjTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMProjectPrjTabDA.GetDataTable_CMProjectPrjTab(strWhereCond);
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
objDT = CMProjectPrjTabDA.GetDataTable(strWhereCond);
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
objDT = CMProjectPrjTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMProjectPrjTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMProjectPrjTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMProjectPrjTabDA.GetDataTable_Top(objTopPara);
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
objDT = CMProjectPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMProjectPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMProjectPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsCMProjectPrjTabEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
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
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMProjectPrjTabEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCmPrjId)
{
string strKey = string.Format("{0}_{1}", clsCMProjectPrjTabEN._CurrTabName, strCmPrjId);
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMProjectPrjTabEN> arrCMProjectPrjTabObjLst_Sel =
arrCMProjectPrjTabObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrCMProjectPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectPrjTabEN> GetObjLst(string strWhereCond)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
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
public static List<clsCMProjectPrjTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMProjectPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMProjectPrjTabEN> GetSubObjLstCache(clsCMProjectPrjTabEN objCMProjectPrjTabCond)
{
 string strCmPrjId = objCMProjectPrjTabCond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCMProjectPrjTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCMProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMProjectPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMProjectPrjTab.AttributeName)
{
if (objCMProjectPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objCMProjectPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectPrjTabCond[strFldName].ToString());
}
else
{
if (objCMProjectPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMProjectPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMProjectPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMProjectPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMProjectPrjTabCond[strFldName]));
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
public static List<clsCMProjectPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
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
public static List<clsCMProjectPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
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
List<clsCMProjectPrjTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMProjectPrjTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMProjectPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
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
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
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
public static List<clsCMProjectPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMProjectPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMProjectPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
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
public static List<clsCMProjectPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectPrjTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMProjectPrjTabEN> arrObjLst = new List<clsCMProjectPrjTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectPrjTabEN objCMProjectPrjTabEN = new clsCMProjectPrjTabEN();
try
{
objCMProjectPrjTabEN.mId = Int32.Parse(objRow[conCMProjectPrjTab.mId].ToString().Trim()); //mId
objCMProjectPrjTabEN.CmPrjId = objRow[conCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objCMProjectPrjTabEN.TabId = objRow[conCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[conCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objCMProjectPrjTabEN.UpdDate = objRow[conCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objCMProjectPrjTabEN.UpdUser = objRow[conCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[conCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objCMProjectPrjTabEN.Memo = objRow[conCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[conCMProjectPrjTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectPrjTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMProjectPrjTab(ref clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
bool bolResult = CMProjectPrjTabDA.GetCMProjectPrjTab(ref objCMProjectPrjTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectPrjTabEN GetObjBymId(long lngmId)
{
clsCMProjectPrjTabEN objCMProjectPrjTabEN = CMProjectPrjTabDA.GetObjBymId(lngmId);
return objCMProjectPrjTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMProjectPrjTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMProjectPrjTabEN objCMProjectPrjTabEN = CMProjectPrjTabDA.GetFirstObj(strWhereCond);
 return objCMProjectPrjTabEN;
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
public static clsCMProjectPrjTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMProjectPrjTabEN objCMProjectPrjTabEN = CMProjectPrjTabDA.GetObjByDataRow(objRow);
 return objCMProjectPrjTabEN;
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
public static clsCMProjectPrjTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMProjectPrjTabEN objCMProjectPrjTabEN = CMProjectPrjTabDA.GetObjByDataRow(objRow);
 return objCMProjectPrjTabEN;
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
 /// <param name = "lstCMProjectPrjTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectPrjTabEN GetObjBymIdFromList(long lngmId, List<clsCMProjectPrjTabEN> lstCMProjectPrjTabObjLst)
{
foreach (clsCMProjectPrjTabEN objCMProjectPrjTabEN in lstCMProjectPrjTabObjLst)
{
if (objCMProjectPrjTabEN.mId == lngmId)
{
return objCMProjectPrjTabEN;
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
 lngmId = new clsCMProjectPrjTabDA().GetFirstID(strWhereCond);
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
 arrList = CMProjectPrjTabDA.GetID(strWhereCond);
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
bool bolIsExist = CMProjectPrjTabDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = CMProjectPrjTabDA.IsExist(lngmId);
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
clsCMProjectPrjTabEN objCMProjectPrjTabEN = clsCMProjectPrjTabBL.GetObjBymId(lngmId);
objCMProjectPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMProjectPrjTabEN.UpdUser = strOpUser;
return clsCMProjectPrjTabBL.UpdateBySql2(objCMProjectPrjTabEN);
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
 bolIsExist = clsCMProjectPrjTabDA.IsExistTable();
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
 bolIsExist = CMProjectPrjTabDA.IsExistTable(strTabName);
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
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMProjectPrjTabEN objCMProjectPrjTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMProjectPrjTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],CM工程Id = [{1}]的数据已经存在!(in clsCMProjectPrjTabBL.AddNewRecordBySql2)", objCMProjectPrjTabEN.TabId,objCMProjectPrjTabEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CMProjectPrjTabDA.AddNewRecordBySQL2(objCMProjectPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMProjectPrjTabEN objCMProjectPrjTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMProjectPrjTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],CM工程Id = [{1}]的数据已经存在!(in clsCMProjectPrjTabBL.AddNewRecordBySql2WithReturnKey)", objCMProjectPrjTabEN.TabId,objCMProjectPrjTabEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = CMProjectPrjTabDA.AddNewRecordBySQL2WithReturnKey(objCMProjectPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
try
{
bool bolResult = CMProjectPrjTabDA.Update(objCMProjectPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 /// <param name = "objCMProjectPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
 if (objCMProjectPrjTabEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMProjectPrjTabDA.UpdateBySql2(objCMProjectPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectPrjTabBL.ReFreshCache(objCMProjectPrjTabEN.CmPrjId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
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
 clsCMProjectPrjTabEN objCMProjectPrjTabEN = clsCMProjectPrjTabBL.GetObjBymId(lngmId);

if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(objCMProjectPrjTabEN.mId, objCMProjectPrjTabEN.UpdUser);
}
if (objCMProjectPrjTabEN != null)
{
int intRecNum = CMProjectPrjTabDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMProjectPrjTabEN.CmPrjId);
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
 /// <param name = "strCmPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCmPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMProjectPrjTabDA.GetSpecSQLObj();
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
//删除与表:[CMProjectPrjTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMProjectPrjTab.mId,
//lngmId);
//        clsCMProjectPrjTabBL.DelCMProjectPrjTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMProjectPrjTabBL.DelRecord(lngmId, strCmPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMProjectPrjTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strCmPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMProjectPrjTabBL.relatedActions != null)
{
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = CMProjectPrjTabDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCmPrjId);
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
public static int DelCMProjectPrjTabs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsCMProjectPrjTabBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsCMProjectPrjTabEN objCMProjectPrjTabEN = clsCMProjectPrjTabBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = CMProjectPrjTabDA.DelCMProjectPrjTab(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMProjectPrjTabEN.CmPrjId);
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
public static int DelCMProjectPrjTabsByCond(string strWhereCond)
{
try
{
if (clsCMProjectPrjTabBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsCMProjectPrjTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCmPrjId = GetFldValue(conCMProjectPrjTab.CmPrjId, strWhereCond);
int intRecNum = CMProjectPrjTabDA.DelCMProjectPrjTab(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCmPrjId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMProjectPrjTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCmPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMProjectPrjTabDA.GetSpecSQLObj();
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
//删除与表:[CMProjectPrjTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMProjectPrjTabBL.DelRecord(lngmId, strCmPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMProjectPrjTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objCMProjectPrjTabENS">源对象</param>
 /// <param name = "objCMProjectPrjTabENT">目标对象</param>
 public static void CopyTo(clsCMProjectPrjTabEN objCMProjectPrjTabENS, clsCMProjectPrjTabEN objCMProjectPrjTabENT)
{
try
{
objCMProjectPrjTabENT.mId = objCMProjectPrjTabENS.mId; //mId
objCMProjectPrjTabENT.CmPrjId = objCMProjectPrjTabENS.CmPrjId; //CM工程Id
objCMProjectPrjTabENT.TabId = objCMProjectPrjTabENS.TabId; //表ID
objCMProjectPrjTabENT.OrderNum = objCMProjectPrjTabENS.OrderNum; //序号
objCMProjectPrjTabENT.UpdDate = objCMProjectPrjTabENS.UpdDate; //修改日期
objCMProjectPrjTabENT.UpdUser = objCMProjectPrjTabENS.UpdUser; //修改者
objCMProjectPrjTabENT.Memo = objCMProjectPrjTabENS.Memo; //说明
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
 /// <param name = "objCMProjectPrjTabEN">源简化对象</param>
 public static void SetUpdFlag(clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
try
{
objCMProjectPrjTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMProjectPrjTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMProjectPrjTab.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectPrjTabEN.mId = objCMProjectPrjTabEN.mId; //mId
}
if (arrFldSet.Contains(conCMProjectPrjTab.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectPrjTabEN.CmPrjId = objCMProjectPrjTabEN.CmPrjId; //CM工程Id
}
if (arrFldSet.Contains(conCMProjectPrjTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectPrjTabEN.TabId = objCMProjectPrjTabEN.TabId; //表ID
}
if (arrFldSet.Contains(conCMProjectPrjTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectPrjTabEN.OrderNum = objCMProjectPrjTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCMProjectPrjTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectPrjTabEN.UpdDate = objCMProjectPrjTabEN.UpdDate == "[null]" ? null :  objCMProjectPrjTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMProjectPrjTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectPrjTabEN.UpdUser = objCMProjectPrjTabEN.UpdUser == "[null]" ? null :  objCMProjectPrjTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMProjectPrjTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectPrjTabEN.Memo = objCMProjectPrjTabEN.Memo == "[null]" ? null :  objCMProjectPrjTabEN.Memo; //说明
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
 /// <param name = "objCMProjectPrjTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
try
{
if (objCMProjectPrjTabEN.UpdDate == "[null]") objCMProjectPrjTabEN.UpdDate = null; //修改日期
if (objCMProjectPrjTabEN.UpdUser == "[null]") objCMProjectPrjTabEN.UpdUser = null; //修改者
if (objCMProjectPrjTabEN.Memo == "[null]") objCMProjectPrjTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
 CMProjectPrjTabDA.CheckPropertyNew(objCMProjectPrjTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
 CMProjectPrjTabDA.CheckProperty4Condition(objCMProjectPrjTabEN);
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
if (clsCMProjectPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectPrjTabBL没有刷新缓存机制(clsCMProjectPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCMProjectPrjTabObjLstCache == null)
//{
//arrCMProjectPrjTabObjLstCache = CMProjectPrjTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectPrjTabEN GetObjBymIdCache(long lngmId, string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsCMProjectPrjTabEN._CurrTabName, strCmPrjId);
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMProjectPrjTabEN> arrCMProjectPrjTabObjLst_Sel =
arrCMProjectPrjTabObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrCMProjectPrjTabObjLst_Sel.Count() == 0)
{
   clsCMProjectPrjTabEN obj = clsCMProjectPrjTabBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CmPrjId == strCmPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCmPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCMProjectPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectPrjTabEN> GetAllCMProjectPrjTabObjLstCache(string strCmPrjId)
{
//获取缓存中的对象列表
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabObjLstCache = GetObjLstCache(strCmPrjId); 
return arrCMProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectPrjTabEN> GetObjLstCache(string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCMProjectPrjTabEN._CurrTabName, strCmPrjId);
string strCondition = string.Format("CmPrjId='{0}'", strCmPrjId);
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCMProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCMProjectPrjTabEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsCMProjectPrjTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMProjectPrjTabEN._RefreshTimeLst.Count == 0) return "";
return clsCMProjectPrjTabEN._RefreshTimeLst[clsCMProjectPrjTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[CmPrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectPrjTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMProjectPrjTabEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsCMProjectPrjTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMProjectPrjTabBL.objCommFun4BL.ReFreshCache(strCmPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMProjectPrjTab(CM项目工程表关系)
 /// 唯一性条件:CMPrjId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMProjectPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMProjectPrjTabEN objCMProjectPrjTabEN)
{
//检测记录是否存在
string strResult = CMProjectPrjTabDA.GetUniCondStr(objCMProjectPrjTabEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-10-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCmPrjId)
{
if (strInFldName != conCMProjectPrjTab.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMProjectPrjTab.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMProjectPrjTab.AttributeName));
throw new Exception(strMsg);
}
var objCMProjectPrjTab = clsCMProjectPrjTabBL.GetObjBymIdCache(lngmId, strCmPrjId);
if (objCMProjectPrjTab == null) return "";
return objCMProjectPrjTab[strOutFldName].ToString();
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
int intRecCount = clsCMProjectPrjTabDA.GetRecCount(strTabName);
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
int intRecCount = clsCMProjectPrjTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMProjectPrjTabDA.GetRecCount();
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
int intRecCount = clsCMProjectPrjTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMProjectPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMProjectPrjTabEN objCMProjectPrjTabCond)
{
 string strCmPrjId = objCMProjectPrjTabCond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCMProjectPrjTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCMProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsCMProjectPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMProjectPrjTab.AttributeName)
{
if (objCMProjectPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objCMProjectPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectPrjTabCond[strFldName].ToString());
}
else
{
if (objCMProjectPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMProjectPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMProjectPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMProjectPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMProjectPrjTabCond[strFldName]));
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
 List<string> arrList = clsCMProjectPrjTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMProjectPrjTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMProjectPrjTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMProjectPrjTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMProjectPrjTabDA.SetFldValue(clsCMProjectPrjTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMProjectPrjTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMProjectPrjTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMProjectPrjTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMProjectPrjTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMProjectPrjTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**CM工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**CM工程名*/ 
 strCreateTabCode.Append(" CmPrjName varchar(50) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**工程ID*/ 
 strCreateTabCode.Append(" PrjId char(4) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strCmPrjId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strCmPrjId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMProjectPrjTab.CmPrjId, strCmPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabObjList = new clsCMProjectPrjTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMProjectPrjTabEN objCMProjectPrjTab in arrCMProjectPrjTabObjList)
{
objCMProjectPrjTab.OrderNum = intIndex;
UpdateBySql2(objCMProjectPrjTab);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="strCmPrjId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId, string strCmPrjId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsCMProjectPrjTabEN objCMProjectPrjTab = clsCMProjectPrjTabBL.GetObjBymId(lngmId);

intOrderNum = objCMProjectPrjTab.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMProjectPrjTab.CmPrjId, strCmPrjId);
intTabRecNum = clsCMProjectPrjTabBL.GetRecCountByCond(clsCMProjectPrjTabEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conCMProjectPrjTab.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conCMProjectPrjTab.CmPrjId, strCmPrjId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsCMProjectPrjTabBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsCMProjectPrjTabBL.SetFldValue(clsCMProjectPrjTabEN._CurrTabName, conCMProjectPrjTab.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conCMProjectPrjTab.mId, lngmId));
clsCMProjectPrjTabBL.SetFldValue(clsCMProjectPrjTabEN._CurrTabName, conCMProjectPrjTab.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCMProjectPrjTab.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
sbCondition.AppendFormat(" {0} = {1} ", conCMProjectPrjTab.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conCMProjectPrjTab.CmPrjId, strCmPrjId);

lngNextmId = clsCMProjectPrjTabBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsCMProjectPrjTabBL.SetFldValue(clsCMProjectPrjTabEN._CurrTabName, conCMProjectPrjTab.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCMProjectPrjTab.mId, lngmId));
clsCMProjectPrjTabBL.SetFldValue(clsCMProjectPrjTabEN._CurrTabName, conCMProjectPrjTab.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conCMProjectPrjTab.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId, string strCmPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conCMProjectPrjTab.mId, strKeyList);
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabLst = GetObjLst(strCondition);
foreach (clsCMProjectPrjTabEN objCMProjectPrjTab in arrCMProjectPrjTabLst)
{
objCMProjectPrjTab.OrderNum = objCMProjectPrjTab.OrderNum + 10000;
UpdateBySql2(objCMProjectPrjTab);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMProjectPrjTab.CmPrjId, strCmPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabObjList = new clsCMProjectPrjTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMProjectPrjTabEN objCMProjectPrjTab in arrCMProjectPrjTabObjList)
{
objCMProjectPrjTab.OrderNum = intIndex;
UpdateBySql2(objCMProjectPrjTab);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strCmPrjId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId, string strCmPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conCMProjectPrjTab.mId, strKeyList);
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabLst = GetObjLst(strCondition);
foreach (clsCMProjectPrjTabEN objCMProjectPrjTab in arrCMProjectPrjTabLst)
{
objCMProjectPrjTab.OrderNum = objCMProjectPrjTab.OrderNum - 10000;
UpdateBySql2(objCMProjectPrjTab);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMProjectPrjTab.CmPrjId, strCmPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsCMProjectPrjTabEN> arrCMProjectPrjTabObjList = new clsCMProjectPrjTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMProjectPrjTabEN objCMProjectPrjTab in arrCMProjectPrjTabObjList)
{
objCMProjectPrjTab.OrderNum = intIndex;
UpdateBySql2(objCMProjectPrjTab);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// CM项目工程表关系(CMProjectPrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMProjectPrjTab : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCmPrjId)
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
clsCMProjectPrjTabBL.ReFreshThisCache(strCmPrjId);
}
}

}