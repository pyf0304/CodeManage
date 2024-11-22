
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TeamMemberBL
 表名:zx_TeamMember(01120718)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clszx_TeamMemberBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTeammenberId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TeamMemberEN GetObj(this K_TeammenberId_zx_TeamMember myKey)
{
clszx_TeamMemberEN objzx_TeamMemberEN = clszx_TeamMemberBL.zx_TeamMemberDA.GetObjByTeammenberId(myKey.Value);
return objzx_TeamMemberEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
if (CheckUniqueness(objzx_TeamMemberEN) == false)
{
var strMsg = string.Format("记录已经存在!主键 = [{0}]的数据已经存在!(in clszx_TeamMemberBL.AddNewRecord)", objzx_TeamMemberEN.TeammenberId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true || clszx_TeamMemberBL.IsExist(objzx_TeamMemberEN.TeammenberId) == true)
 {
     objzx_TeamMemberEN.TeammenberId = clszx_TeamMemberBL.GetMaxStrId_S();
 }
bool bolResult = clszx_TeamMemberBL.zx_TeamMemberDA.AddNewRecordBySQL2(objzx_TeamMemberEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_TeamMemberBL.IsExist(objzx_TeamMemberEN.TeammenberId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TeamMemberEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TeamMemberEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主键(TeammenberId)=[{0}])已经存在,不能重复!", objzx_TeamMemberEN.TeammenberId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true || clszx_TeamMemberBL.IsExist(objzx_TeamMemberEN.TeammenberId) == true)
 {
     objzx_TeamMemberEN.TeammenberId = clszx_TeamMemberBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_TeamMemberEN.AddNewRecord();
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
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
if (CheckUniqueness(objzx_TeamMemberEN) == false)
{
var strMsg = string.Format("记录已经存在!主键 = [{0}]的数据已经存在!(in clszx_TeamMemberBL.AddNewRecordWithMaxId)", objzx_TeamMemberEN.TeammenberId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true || clszx_TeamMemberBL.IsExist(objzx_TeamMemberEN.TeammenberId) == true)
 {
     objzx_TeamMemberEN.TeammenberId = clszx_TeamMemberBL.GetMaxStrId_S();
 }
string strTeammenberId = clszx_TeamMemberBL.zx_TeamMemberDA.AddNewRecordBySQL2WithReturnKey(objzx_TeamMemberEN);
     objzx_TeamMemberEN.TeammenberId = strTeammenberId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
}
return strTeammenberId;
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
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
if (CheckUniqueness(objzx_TeamMemberEN) == false)
{
var strMsg = string.Format("记录已经存在!主键 = [{0}]的数据已经存在!(in clszx_TeamMemberBL.AddNewRecordWithReturnKey)", objzx_TeamMemberEN.TeammenberId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true || clszx_TeamMemberBL.IsExist(objzx_TeamMemberEN.TeammenberId) == true)
 {
     objzx_TeamMemberEN.TeammenberId = clszx_TeamMemberBL.GetMaxStrId_S();
 }
string strKey = clszx_TeamMemberBL.zx_TeamMemberDA.AddNewRecordBySQL2WithReturnKey(objzx_TeamMemberEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TeamMemberEN SetTeammenberId(this clszx_TeamMemberEN objzx_TeamMemberEN, string strTeammenberId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeammenberId, 8, conzx_TeamMember.TeammenberId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeammenberId, 8, conzx_TeamMember.TeammenberId);
}
objzx_TeamMemberEN.TeammenberId = strTeammenberId; //主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TeamMemberEN.dicFldComparisonOp.ContainsKey(conzx_TeamMember.TeammenberId) == false)
{
objzx_TeamMemberEN.dicFldComparisonOp.Add(conzx_TeamMember.TeammenberId, strComparisonOp);
}
else
{
objzx_TeamMemberEN.dicFldComparisonOp[conzx_TeamMember.TeammenberId] = strComparisonOp;
}
}
return objzx_TeamMemberEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TeamMemberEN SetTeamName(this clszx_TeamMemberEN objzx_TeamMemberEN, string strTeamName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeamName, 100, conzx_TeamMember.TeamName);
}
objzx_TeamMemberEN.TeamName = strTeamName; //团队名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TeamMemberEN.dicFldComparisonOp.ContainsKey(conzx_TeamMember.TeamName) == false)
{
objzx_TeamMemberEN.dicFldComparisonOp.Add(conzx_TeamMember.TeamName, strComparisonOp);
}
else
{
objzx_TeamMemberEN.dicFldComparisonOp[conzx_TeamMember.TeamName] = strComparisonOp;
}
}
return objzx_TeamMemberEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TeamMemberEN SetUpdDate(this clszx_TeamMemberEN objzx_TeamMemberEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TeamMember.UpdDate);
}
objzx_TeamMemberEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TeamMemberEN.dicFldComparisonOp.ContainsKey(conzx_TeamMember.UpdDate) == false)
{
objzx_TeamMemberEN.dicFldComparisonOp.Add(conzx_TeamMember.UpdDate, strComparisonOp);
}
else
{
objzx_TeamMemberEN.dicFldComparisonOp[conzx_TeamMember.UpdDate] = strComparisonOp;
}
}
return objzx_TeamMemberEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TeamMemberEN SetUpdUser(this clszx_TeamMemberEN objzx_TeamMemberEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_TeamMember.UpdUser);
}
objzx_TeamMemberEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TeamMemberEN.dicFldComparisonOp.ContainsKey(conzx_TeamMember.UpdUser) == false)
{
objzx_TeamMemberEN.dicFldComparisonOp.Add(conzx_TeamMember.UpdUser, strComparisonOp);
}
else
{
objzx_TeamMemberEN.dicFldComparisonOp[conzx_TeamMember.UpdUser] = strComparisonOp;
}
}
return objzx_TeamMemberEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TeamMemberEN SetMemo(this clszx_TeamMemberEN objzx_TeamMemberEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TeamMember.Memo);
}
objzx_TeamMemberEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TeamMemberEN.dicFldComparisonOp.ContainsKey(conzx_TeamMember.Memo) == false)
{
objzx_TeamMemberEN.dicFldComparisonOp.Add(conzx_TeamMember.Memo, strComparisonOp);
}
else
{
objzx_TeamMemberEN.dicFldComparisonOp[conzx_TeamMember.Memo] = strComparisonOp;
}
}
return objzx_TeamMemberEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TeamMemberEN.CheckPropertyNew();
clszx_TeamMemberEN objzx_TeamMemberCond = new clszx_TeamMemberEN();
string strCondition = objzx_TeamMemberCond
.SetTeammenberId(objzx_TeamMemberEN.TeammenberId, "<>")
.SetTeammenberId(objzx_TeamMemberEN.TeammenberId, "=")
.GetCombineCondition();
objzx_TeamMemberEN._IsCheckProperty = true;
bool bolIsExist = clszx_TeamMemberBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TeammenberId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TeamMemberEN.Update();
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
 /// <param name = "objzx_TeamMember">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TeamMemberEN objzx_TeamMember)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TeamMemberEN objzx_TeamMemberCond = new clszx_TeamMemberEN();
string strCondition = objzx_TeamMemberCond
.SetTeammenberId(objzx_TeamMember.TeammenberId, "=")
.GetCombineCondition();
objzx_TeamMember._IsCheckProperty = true;
bool bolIsExist = clszx_TeamMemberBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_TeamMember.TeammenberId = clszx_TeamMemberBL.GetFirstID_S(strCondition);
objzx_TeamMember.UpdateWithCondition(strCondition);
}
else
{
objzx_TeamMember.TeammenberId = clszx_TeamMemberBL.GetMaxStrId_S();
objzx_TeamMember.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TeamMemberBL.zx_TeamMemberDA.UpdateBySql2(objzx_TeamMemberEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TeamMemberEN objzx_TeamMemberEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TeamMemberBL.zx_TeamMemberDA.UpdateBySql2(objzx_TeamMemberEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TeamMemberEN objzx_TeamMemberEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TeamMemberBL.zx_TeamMemberDA.UpdateBySqlWithCondition(objzx_TeamMemberEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TeamMemberEN objzx_TeamMemberEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TeamMemberBL.zx_TeamMemberDA.UpdateBySqlWithConditionTransaction(objzx_TeamMemberEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "strTeammenberId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
try
{
int intRecNum = clszx_TeamMemberBL.zx_TeamMemberDA.DelRecord(objzx_TeamMemberEN.TeammenberId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberENS">源对象</param>
 /// <param name = "objzx_TeamMemberENT">目标对象</param>
 public static void CopyTo(this clszx_TeamMemberEN objzx_TeamMemberENS, clszx_TeamMemberEN objzx_TeamMemberENT)
{
try
{
objzx_TeamMemberENT.TeammenberId = objzx_TeamMemberENS.TeammenberId; //主键
objzx_TeamMemberENT.TeamName = objzx_TeamMemberENS.TeamName; //团队名称
objzx_TeamMemberENT.UpdDate = objzx_TeamMemberENS.UpdDate; //修改日期
objzx_TeamMemberENT.UpdUser = objzx_TeamMemberENS.UpdUser; //修改人
objzx_TeamMemberENT.Memo = objzx_TeamMemberENS.Memo; //备注
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
 /// <param name = "objzx_TeamMemberENS">源对象</param>
 /// <returns>目标对象=>clszx_TeamMemberEN:objzx_TeamMemberENT</returns>
 public static clszx_TeamMemberEN CopyTo(this clszx_TeamMemberEN objzx_TeamMemberENS)
{
try
{
 clszx_TeamMemberEN objzx_TeamMemberENT = new clszx_TeamMemberEN()
{
TeammenberId = objzx_TeamMemberENS.TeammenberId, //主键
TeamName = objzx_TeamMemberENS.TeamName, //团队名称
UpdDate = objzx_TeamMemberENS.UpdDate, //修改日期
UpdUser = objzx_TeamMemberENS.UpdUser, //修改人
Memo = objzx_TeamMemberENS.Memo, //备注
};
 return objzx_TeamMemberENT;
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
public static void CheckPropertyNew(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
 clszx_TeamMemberBL.zx_TeamMemberDA.CheckPropertyNew(objzx_TeamMemberEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
 clszx_TeamMemberBL.zx_TeamMemberDA.CheckProperty4Condition(objzx_TeamMemberEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TeamMemberEN objzx_TeamMemberCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TeamMemberCond.IsUpdated(conzx_TeamMember.TeammenberId) == true)
{
string strComparisonOpTeammenberId = objzx_TeamMemberCond.dicFldComparisonOp[conzx_TeamMember.TeammenberId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TeamMember.TeammenberId, objzx_TeamMemberCond.TeammenberId, strComparisonOpTeammenberId);
}
if (objzx_TeamMemberCond.IsUpdated(conzx_TeamMember.TeamName) == true)
{
string strComparisonOpTeamName = objzx_TeamMemberCond.dicFldComparisonOp[conzx_TeamMember.TeamName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TeamMember.TeamName, objzx_TeamMemberCond.TeamName, strComparisonOpTeamName);
}
if (objzx_TeamMemberCond.IsUpdated(conzx_TeamMember.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TeamMemberCond.dicFldComparisonOp[conzx_TeamMember.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TeamMember.UpdDate, objzx_TeamMemberCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TeamMemberCond.IsUpdated(conzx_TeamMember.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TeamMemberCond.dicFldComparisonOp[conzx_TeamMember.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TeamMember.UpdUser, objzx_TeamMemberCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TeamMemberCond.IsUpdated(conzx_TeamMember.Memo) == true)
{
string strComparisonOpMemo = objzx_TeamMemberCond.dicFldComparisonOp[conzx_TeamMember.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TeamMember.Memo, objzx_TeamMemberCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_TeamMember(小组成员), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TeammenberId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TeamMemberEN == null) return true;
if (objzx_TeamMemberEN.TeammenberId == null || objzx_TeamMemberEN.TeammenberId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeammenberId = '{0}'", objzx_TeamMemberEN.TeammenberId);
if (clszx_TeamMemberBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TeammenberId !=  '{0}'", objzx_TeamMemberEN.TeammenberId);
 sbCondition.AppendFormat(" and TeammenberId = '{0}'", objzx_TeamMemberEN.TeammenberId);
if (clszx_TeamMemberBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_TeamMember(小组成员), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TeammenberId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TeamMemberEN objzx_TeamMemberEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TeamMemberEN == null) return "";
if (objzx_TeamMemberEN.TeammenberId == null || objzx_TeamMemberEN.TeammenberId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeammenberId = '{0}'", objzx_TeamMemberEN.TeammenberId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TeammenberId !=  '{0}'", objzx_TeamMemberEN.TeammenberId);
 sbCondition.AppendFormat(" and TeammenberId = '{0}'", objzx_TeamMemberEN.TeammenberId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TeamMember
{
public virtual bool UpdRelaTabDate(string strTeammenberId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 小组成员(zx_TeamMember)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TeamMemberBL
{
public static RelatedActions_zx_TeamMember relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TeamMemberDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TeamMemberDA zx_TeamMemberDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TeamMemberDA();
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
 public clszx_TeamMemberBL()
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
if (string.IsNullOrEmpty(clszx_TeamMemberEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TeamMemberEN._ConnectString);
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
public static DataTable GetDataTable_zx_TeamMember(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TeamMemberDA.GetDataTable_zx_TeamMember(strWhereCond);
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
objDT = zx_TeamMemberDA.GetDataTable(strWhereCond);
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
objDT = zx_TeamMemberDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TeamMemberDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TeamMemberDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TeamMemberDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TeamMemberDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TeamMemberDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TeamMemberDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTeammenberIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TeamMemberEN> GetObjLstByTeammenberIdLst(List<string> arrTeammenberIdLst)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTeammenberIdLst, true);
 string strWhereCond = string.Format("TeammenberId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTeammenberIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TeamMemberEN> GetObjLstByTeammenberIdLstCache(List<string> arrTeammenberIdLst)
{
string strKey = string.Format("{0}", clszx_TeamMemberEN._CurrTabName);
List<clszx_TeamMemberEN> arrzx_TeamMemberObjLstCache = GetObjLstCache();
IEnumerable <clszx_TeamMemberEN> arrzx_TeamMemberObjLst_Sel =
arrzx_TeamMemberObjLstCache
.Where(x => arrTeammenberIdLst.Contains(x.TeammenberId));
return arrzx_TeamMemberObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TeamMemberEN> GetObjLst(string strWhereCond)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
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
public static List<clszx_TeamMemberEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TeamMemberCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TeamMemberEN> GetSubObjLstCache(clszx_TeamMemberEN objzx_TeamMemberCond)
{
List<clszx_TeamMemberEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TeamMemberEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TeamMember.AttributeName)
{
if (objzx_TeamMemberCond.IsUpdated(strFldName) == false) continue;
if (objzx_TeamMemberCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TeamMemberCond[strFldName].ToString());
}
else
{
if (objzx_TeamMemberCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TeamMemberCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TeamMemberCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TeamMemberCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TeamMemberCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TeamMemberCond[strFldName]));
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
public static List<clszx_TeamMemberEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
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
public static List<clszx_TeamMemberEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
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
List<clszx_TeamMemberEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TeamMemberEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TeamMemberEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TeamMemberEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
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
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
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
public static List<clszx_TeamMemberEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TeamMemberEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TeamMemberEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
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
public static List<clszx_TeamMemberEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TeamMemberEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TeamMemberEN> arrObjLst = new List<clszx_TeamMemberEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TeamMemberEN objzx_TeamMemberEN = new clszx_TeamMemberEN();
try
{
objzx_TeamMemberEN.TeammenberId = objRow[conzx_TeamMember.TeammenberId].ToString().Trim(); //主键
objzx_TeamMemberEN.TeamName = objRow[conzx_TeamMember.TeamName] == DBNull.Value ? null : objRow[conzx_TeamMember.TeamName].ToString().Trim(); //团队名称
objzx_TeamMemberEN.UpdDate = objRow[conzx_TeamMember.UpdDate] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdDate].ToString().Trim(); //修改日期
objzx_TeamMemberEN.UpdUser = objRow[conzx_TeamMember.UpdUser] == DBNull.Value ? null : objRow[conzx_TeamMember.UpdUser].ToString().Trim(); //修改人
objzx_TeamMemberEN.Memo = objRow[conzx_TeamMember.Memo] == DBNull.Value ? null : objRow[conzx_TeamMember.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TeamMemberEN.TeammenberId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TeamMemberEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TeamMember(ref clszx_TeamMemberEN objzx_TeamMemberEN)
{
bool bolResult = zx_TeamMemberDA.Getzx_TeamMember(ref objzx_TeamMemberEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTeammenberId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TeamMemberEN GetObjByTeammenberId(string strTeammenberId)
{
if (strTeammenberId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTeammenberId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTeammenberId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTeammenberId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TeamMemberEN objzx_TeamMemberEN = zx_TeamMemberDA.GetObjByTeammenberId(strTeammenberId);
return objzx_TeamMemberEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TeamMemberEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TeamMemberEN objzx_TeamMemberEN = zx_TeamMemberDA.GetFirstObj(strWhereCond);
 return objzx_TeamMemberEN;
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
public static clszx_TeamMemberEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TeamMemberEN objzx_TeamMemberEN = zx_TeamMemberDA.GetObjByDataRow(objRow);
 return objzx_TeamMemberEN;
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
public static clszx_TeamMemberEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TeamMemberEN objzx_TeamMemberEN = zx_TeamMemberDA.GetObjByDataRow(objRow);
 return objzx_TeamMemberEN;
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
 /// <param name = "strTeammenberId">所给的关键字</param>
 /// <param name = "lstzx_TeamMemberObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TeamMemberEN GetObjByTeammenberIdFromList(string strTeammenberId, List<clszx_TeamMemberEN> lstzx_TeamMemberObjLst)
{
foreach (clszx_TeamMemberEN objzx_TeamMemberEN in lstzx_TeamMemberObjLst)
{
if (objzx_TeamMemberEN.TeammenberId == strTeammenberId)
{
return objzx_TeamMemberEN;
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
 string strMaxTeammenberId;
 try
 {
 strMaxTeammenberId = clszx_TeamMemberDA.GetMaxStrId();
 return strMaxTeammenberId;
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
 string strTeammenberId;
 try
 {
 strTeammenberId = new clszx_TeamMemberDA().GetFirstID(strWhereCond);
 return strTeammenberId;
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
 arrList = zx_TeamMemberDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TeamMemberDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTeammenberId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTeammenberId)
{
if (string.IsNullOrEmpty(strTeammenberId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTeammenberId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TeamMemberDA.IsExist(strTeammenberId);
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
 bolIsExist = clszx_TeamMemberDA.IsExistTable();
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
 bolIsExist = zx_TeamMemberDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TeamMemberEN objzx_TeamMemberEN)
{
if (objzx_TeamMemberEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主键 = [{0}]的数据已经存在!(in clszx_TeamMemberBL.AddNewRecordBySql2)", objzx_TeamMemberEN.TeammenberId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true || clszx_TeamMemberBL.IsExist(objzx_TeamMemberEN.TeammenberId) == true)
 {
     objzx_TeamMemberEN.TeammenberId = clszx_TeamMemberBL.GetMaxStrId_S();
 }
bool bolResult = zx_TeamMemberDA.AddNewRecordBySQL2(objzx_TeamMemberEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TeamMemberEN objzx_TeamMemberEN)
{
if (objzx_TeamMemberEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主键 = [{0}]的数据已经存在!(in clszx_TeamMemberBL.AddNewRecordBySql2WithReturnKey)", objzx_TeamMemberEN.TeammenberId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true || clszx_TeamMemberBL.IsExist(objzx_TeamMemberEN.TeammenberId) == true)
 {
     objzx_TeamMemberEN.TeammenberId = clszx_TeamMemberBL.GetMaxStrId_S();
 }
string strKey = zx_TeamMemberDA.AddNewRecordBySQL2WithReturnKey(objzx_TeamMemberEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TeamMemberEN objzx_TeamMemberEN)
{
try
{
bool bolResult = zx_TeamMemberDA.Update(objzx_TeamMemberEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "objzx_TeamMemberEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TeamMemberEN objzx_TeamMemberEN)
{
 if (string.IsNullOrEmpty(objzx_TeamMemberEN.TeammenberId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TeamMemberDA.UpdateBySql2(objzx_TeamMemberEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TeamMemberBL.ReFreshCache();

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
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
 /// <param name = "strTeammenberId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTeammenberId)
{
try
{
 clszx_TeamMemberEN objzx_TeamMemberEN = clszx_TeamMemberBL.GetObjByTeammenberId(strTeammenberId);

if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(objzx_TeamMemberEN.TeammenberId, "SetUpdDate");
}
if (objzx_TeamMemberEN != null)
{
int intRecNum = zx_TeamMemberDA.DelRecord(strTeammenberId);
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
/// <param name="strTeammenberId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTeammenberId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TeamMemberDA.GetSpecSQLObj();
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
//删除与表:[zx_TeamMember]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TeamMember.TeammenberId,
//strTeammenberId);
//        clszx_TeamMemberBL.Delzx_TeamMembersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TeamMemberBL.DelRecord(strTeammenberId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TeamMemberBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTeammenberId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTeammenberId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTeammenberId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TeamMemberBL.relatedActions != null)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(strTeammenberId, "UpdRelaTabDate");
}
bool bolResult = zx_TeamMemberDA.DelRecord(strTeammenberId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTeammenberIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TeamMembers(List<string> arrTeammenberIdLst)
{
if (arrTeammenberIdLst.Count == 0) return 0;
try
{
if (clszx_TeamMemberBL.relatedActions != null)
{
foreach (var strTeammenberId in arrTeammenberIdLst)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(strTeammenberId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_TeamMemberDA.Delzx_TeamMember(arrTeammenberIdLst);
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
public static int Delzx_TeamMembersByCond(string strWhereCond)
{
try
{
if (clszx_TeamMemberBL.relatedActions != null)
{
List<string> arrTeammenberId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTeammenberId in arrTeammenberId)
{
clszx_TeamMemberBL.relatedActions.UpdRelaTabDate(strTeammenberId, "UpdRelaTabDate");
}
}
int intRecNum = zx_TeamMemberDA.Delzx_TeamMember(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TeamMember]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTeammenberId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTeammenberId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TeamMemberDA.GetSpecSQLObj();
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
//删除与表:[zx_TeamMember]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TeamMemberBL.DelRecord(strTeammenberId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TeamMemberBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTeammenberId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TeamMemberENS">源对象</param>
 /// <param name = "objzx_TeamMemberENT">目标对象</param>
 public static void CopyTo(clszx_TeamMemberEN objzx_TeamMemberENS, clszx_TeamMemberEN objzx_TeamMemberENT)
{
try
{
objzx_TeamMemberENT.TeammenberId = objzx_TeamMemberENS.TeammenberId; //主键
objzx_TeamMemberENT.TeamName = objzx_TeamMemberENS.TeamName; //团队名称
objzx_TeamMemberENT.UpdDate = objzx_TeamMemberENS.UpdDate; //修改日期
objzx_TeamMemberENT.UpdUser = objzx_TeamMemberENS.UpdUser; //修改人
objzx_TeamMemberENT.Memo = objzx_TeamMemberENS.Memo; //备注
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
 /// <param name = "objzx_TeamMemberEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TeamMemberEN objzx_TeamMemberEN)
{
try
{
objzx_TeamMemberEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TeamMemberEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TeamMember.TeammenberId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TeamMemberEN.TeammenberId = objzx_TeamMemberEN.TeammenberId; //主键
}
if (arrFldSet.Contains(conzx_TeamMember.TeamName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TeamMemberEN.TeamName = objzx_TeamMemberEN.TeamName == "[null]" ? null :  objzx_TeamMemberEN.TeamName; //团队名称
}
if (arrFldSet.Contains(conzx_TeamMember.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TeamMemberEN.UpdDate = objzx_TeamMemberEN.UpdDate == "[null]" ? null :  objzx_TeamMemberEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TeamMember.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TeamMemberEN.UpdUser = objzx_TeamMemberEN.UpdUser == "[null]" ? null :  objzx_TeamMemberEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_TeamMember.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TeamMemberEN.Memo = objzx_TeamMemberEN.Memo == "[null]" ? null :  objzx_TeamMemberEN.Memo; //备注
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
 /// <param name = "objzx_TeamMemberEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TeamMemberEN objzx_TeamMemberEN)
{
try
{
if (objzx_TeamMemberEN.TeamName == "[null]") objzx_TeamMemberEN.TeamName = null; //团队名称
if (objzx_TeamMemberEN.UpdDate == "[null]") objzx_TeamMemberEN.UpdDate = null; //修改日期
if (objzx_TeamMemberEN.UpdUser == "[null]") objzx_TeamMemberEN.UpdUser = null; //修改人
if (objzx_TeamMemberEN.Memo == "[null]") objzx_TeamMemberEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_TeamMemberEN objzx_TeamMemberEN)
{
 zx_TeamMemberDA.CheckPropertyNew(objzx_TeamMemberEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TeamMemberEN objzx_TeamMemberEN)
{
 zx_TeamMemberDA.CheckProperty4Condition(objzx_TeamMemberEN);
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
if (clszx_TeamMemberBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TeamMemberBL没有刷新缓存机制(clszx_TeamMemberBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TeammenberId");
//if (arrzx_TeamMemberObjLstCache == null)
//{
//arrzx_TeamMemberObjLstCache = zx_TeamMemberDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTeammenberId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TeamMemberEN GetObjByTeammenberIdCache(string strTeammenberId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_TeamMemberEN._CurrTabName);
List<clszx_TeamMemberEN> arrzx_TeamMemberObjLstCache = GetObjLstCache();
IEnumerable <clszx_TeamMemberEN> arrzx_TeamMemberObjLst_Sel =
arrzx_TeamMemberObjLstCache
.Where(x=> x.TeammenberId == strTeammenberId 
);
if (arrzx_TeamMemberObjLst_Sel.Count() == 0)
{
   clszx_TeamMemberEN obj = clszx_TeamMemberBL.GetObjByTeammenberId(strTeammenberId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_TeamMemberObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TeamMemberEN> GetAllzx_TeamMemberObjLstCache()
{
//获取缓存中的对象列表
List<clszx_TeamMemberEN> arrzx_TeamMemberObjLstCache = GetObjLstCache(); 
return arrzx_TeamMemberObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TeamMemberEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_TeamMemberEN._CurrTabName);
List<clszx_TeamMemberEN> arrzx_TeamMemberObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_TeamMemberObjLstCache;
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
string strKey = string.Format("{0}", clszx_TeamMemberEN._CurrTabName);
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
if (clszx_TeamMemberBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_TeamMemberEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_TeamMemberBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_TeamMember(小组成员)
 /// 唯一性条件:TeammenberId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TeamMemberEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TeamMemberEN objzx_TeamMemberEN)
{
//检测记录是否存在
string strResult = zx_TeamMemberDA.GetUniCondStr(objzx_TeamMemberEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTeammenberId)
{
if (strInFldName != conzx_TeamMember.TeammenberId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TeamMember.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TeamMember.AttributeName));
throw new Exception(strMsg);
}
var objzx_TeamMember = clszx_TeamMemberBL.GetObjByTeammenberIdCache(strTeammenberId);
if (objzx_TeamMember == null) return "";
return objzx_TeamMember[strOutFldName].ToString();
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
int intRecCount = clszx_TeamMemberDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TeamMemberDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TeamMemberDA.GetRecCount();
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
int intRecCount = clszx_TeamMemberDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TeamMemberCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TeamMemberEN objzx_TeamMemberCond)
{
List<clszx_TeamMemberEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TeamMemberEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TeamMember.AttributeName)
{
if (objzx_TeamMemberCond.IsUpdated(strFldName) == false) continue;
if (objzx_TeamMemberCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TeamMemberCond[strFldName].ToString());
}
else
{
if (objzx_TeamMemberCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TeamMemberCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TeamMemberCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TeamMemberCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TeamMemberCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TeamMemberCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TeamMemberCond[strFldName]));
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
 List<string> arrList = clszx_TeamMemberDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TeamMemberDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TeamMemberDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TeamMemberDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TeamMemberDA.SetFldValue(clszx_TeamMemberEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TeamMemberDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TeamMemberDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TeamMemberDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TeamMemberDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TeamMember] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主键*/ 
 strCreateTabCode.Append(" TeammenberId char(8) primary key, "); 
 // /**团队名称*/ 
 strCreateTabCode.Append(" TeamName varchar(100) Null, "); 
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
 /// 小组成员(zx_TeamMember)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TeamMember : clsCommFun4BL
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
clszx_TeamMemberBL.ReFreshThisCache();
}
}

}