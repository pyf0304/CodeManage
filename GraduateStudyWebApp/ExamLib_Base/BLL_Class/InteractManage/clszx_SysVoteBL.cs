
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysVoteBL
 表名:zx_SysVote(01120845)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:02:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clszx_SysVoteBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngzxVoteId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SysVoteEN GetObj(this K_zxVoteId_zx_SysVote myKey)
{
clszx_SysVoteEN objzx_SysVoteEN = clszx_SysVoteBL.zx_SysVoteDA.GetObjByzxVoteId(myKey.Value);
return objzx_SysVoteEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_SysVoteEN objzx_SysVoteEN)
{
if (CheckUniqueness(objzx_SysVoteEN) == false)
{
var strMsg = string.Format("记录已经存在!点赞Id = [{0}]的数据已经存在!(in clszx_SysVoteBL.AddNewRecord)", objzx_SysVoteEN.zxVoteId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_SysVoteBL.zx_SysVoteDA.AddNewRecordBySQL2(objzx_SysVoteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
public static bool AddRecordEx(this clszx_SysVoteEN objzx_SysVoteEN)
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
objzx_SysVoteEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_SysVoteEN.CheckUniqueness() == false)
{
strMsg = string.Format("(点赞Id(zxVoteId)=[{0}])已经存在,不能重复!", objzx_SysVoteEN.zxVoteId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_SysVoteEN.AddNewRecord();
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
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_SysVoteEN objzx_SysVoteEN)
{
if (CheckUniqueness(objzx_SysVoteEN) == false)
{
var strMsg = string.Format("记录已经存在!点赞Id = [{0}]的数据已经存在!(in clszx_SysVoteBL.AddNewRecordWithReturnKey)", objzx_SysVoteEN.zxVoteId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_SysVoteBL.zx_SysVoteDA.AddNewRecordBySQL2WithReturnKey(objzx_SysVoteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetzxVoteId(this clszx_SysVoteEN objzx_SysVoteEN, long lngzxVoteId, string strComparisonOp="")
	{
objzx_SysVoteEN.zxVoteId = lngzxVoteId; //点赞Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.zxVoteId) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.zxVoteId, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.zxVoteId] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetTableKey(this clszx_SysVoteEN objzx_SysVoteEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, conzx_SysVote.TableKey);
}
objzx_SysVoteEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.TableKey) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.TableKey, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.TableKey] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetPubParentId(this clszx_SysVoteEN objzx_SysVoteEN, string strPubParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubParentId, 20, conzx_SysVote.PubParentId);
}
objzx_SysVoteEN.PubParentId = strPubParentId; //公共父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.PubParentId) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.PubParentId, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.PubParentId] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetzxVoteTypeId(this clszx_SysVoteEN objzx_SysVoteEN, string strzxVoteTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxVoteTypeId, 2, conzx_SysVote.zxVoteTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxVoteTypeId, 2, conzx_SysVote.zxVoteTypeId);
}
objzx_SysVoteEN.zxVoteTypeId = strzxVoteTypeId; //点赞类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.zxVoteTypeId) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.zxVoteTypeId, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.zxVoteTypeId] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetUpdUser(this clszx_SysVoteEN objzx_SysVoteEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_SysVote.UpdUser);
}
objzx_SysVoteEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.UpdUser) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.UpdUser, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.UpdUser] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetUpdDate(this clszx_SysVoteEN objzx_SysVoteEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_SysVote.UpdDate);
}
objzx_SysVoteEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.UpdDate) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.UpdDate, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.UpdDate] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetMemo(this clszx_SysVoteEN objzx_SysVoteEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_SysVote.Memo);
}
objzx_SysVoteEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.Memo) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.Memo, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.Memo] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetIdCurrEduCls(this clszx_SysVoteEN objzx_SysVoteEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_SysVote.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_SysVote.IdCurrEduCls);
}
objzx_SysVoteEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.IdCurrEduCls) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysVoteEN SetUserId(this clszx_SysVoteEN objzx_SysVoteEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conzx_SysVote.UserId);
}
objzx_SysVoteEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysVoteEN.dicFldComparisonOp.ContainsKey(conzx_SysVote.UserId) == false)
{
objzx_SysVoteEN.dicFldComparisonOp.Add(conzx_SysVote.UserId, strComparisonOp);
}
else
{
objzx_SysVoteEN.dicFldComparisonOp[conzx_SysVote.UserId] = strComparisonOp;
}
}
return objzx_SysVoteEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_SysVoteEN objzx_SysVoteEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_SysVoteEN.CheckPropertyNew();
clszx_SysVoteEN objzx_SysVoteCond = new clszx_SysVoteEN();
string strCondition = objzx_SysVoteCond
.SetzxVoteId(objzx_SysVoteEN.zxVoteId, "<>")
.SetzxVoteId(objzx_SysVoteEN.zxVoteId, "=")
.GetCombineCondition();
objzx_SysVoteEN._IsCheckProperty = true;
bool bolIsExist = clszx_SysVoteBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxVoteId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_SysVoteEN.Update();
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
 /// <param name = "objzx_SysVote">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_SysVoteEN objzx_SysVote)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_SysVoteEN objzx_SysVoteCond = new clszx_SysVoteEN();
string strCondition = objzx_SysVoteCond
.SetzxVoteId(objzx_SysVote.zxVoteId, "=")
.GetCombineCondition();
objzx_SysVote._IsCheckProperty = true;
bool bolIsExist = clszx_SysVoteBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_SysVote.zxVoteId = clszx_SysVoteBL.GetFirstID_S(strCondition);
objzx_SysVote.UpdateWithCondition(strCondition);
}
else
{
objzx_SysVote.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SysVoteEN objzx_SysVoteEN)
{
 if (objzx_SysVoteEN.zxVoteId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SysVoteBL.zx_SysVoteDA.UpdateBySql2(objzx_SysVoteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SysVoteEN objzx_SysVoteEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SysVoteEN.zxVoteId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SysVoteBL.zx_SysVoteDA.UpdateBySql2(objzx_SysVoteEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SysVoteEN objzx_SysVoteEN, string strWhereCond)
{
try
{
bool bolResult = clszx_SysVoteBL.zx_SysVoteDA.UpdateBySqlWithCondition(objzx_SysVoteEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SysVoteEN objzx_SysVoteEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_SysVoteBL.zx_SysVoteDA.UpdateBySqlWithConditionTransaction(objzx_SysVoteEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "lngzxVoteId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_SysVoteEN objzx_SysVoteEN)
{
try
{
int intRecNum = clszx_SysVoteBL.zx_SysVoteDA.DelRecord(objzx_SysVoteEN.zxVoteId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteENS">源对象</param>
 /// <param name = "objzx_SysVoteENT">目标对象</param>
 public static void CopyTo(this clszx_SysVoteEN objzx_SysVoteENS, clszx_SysVoteEN objzx_SysVoteENT)
{
try
{
objzx_SysVoteENT.zxVoteId = objzx_SysVoteENS.zxVoteId; //点赞Id
objzx_SysVoteENT.TableKey = objzx_SysVoteENS.TableKey; //表主键
objzx_SysVoteENT.PubParentId = objzx_SysVoteENS.PubParentId; //公共父Id
objzx_SysVoteENT.zxVoteTypeId = objzx_SysVoteENS.zxVoteTypeId; //点赞类型Id
objzx_SysVoteENT.UpdUser = objzx_SysVoteENS.UpdUser; //修改人
objzx_SysVoteENT.UpdDate = objzx_SysVoteENS.UpdDate; //修改日期
objzx_SysVoteENT.Memo = objzx_SysVoteENS.Memo; //备注
objzx_SysVoteENT.IdCurrEduCls = objzx_SysVoteENS.IdCurrEduCls; //教学班流水号
objzx_SysVoteENT.UserId = objzx_SysVoteENS.UserId; //用户ID
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
 /// <param name = "objzx_SysVoteENS">源对象</param>
 /// <returns>目标对象=>clszx_SysVoteEN:objzx_SysVoteENT</returns>
 public static clszx_SysVoteEN CopyTo(this clszx_SysVoteEN objzx_SysVoteENS)
{
try
{
 clszx_SysVoteEN objzx_SysVoteENT = new clszx_SysVoteEN()
{
zxVoteId = objzx_SysVoteENS.zxVoteId, //点赞Id
TableKey = objzx_SysVoteENS.TableKey, //表主键
PubParentId = objzx_SysVoteENS.PubParentId, //公共父Id
zxVoteTypeId = objzx_SysVoteENS.zxVoteTypeId, //点赞类型Id
UpdUser = objzx_SysVoteENS.UpdUser, //修改人
UpdDate = objzx_SysVoteENS.UpdDate, //修改日期
Memo = objzx_SysVoteENS.Memo, //备注
IdCurrEduCls = objzx_SysVoteENS.IdCurrEduCls, //教学班流水号
UserId = objzx_SysVoteENS.UserId, //用户ID
};
 return objzx_SysVoteENT;
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
public static void CheckPropertyNew(this clszx_SysVoteEN objzx_SysVoteEN)
{
 clszx_SysVoteBL.zx_SysVoteDA.CheckPropertyNew(objzx_SysVoteEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_SysVoteEN objzx_SysVoteEN)
{
 clszx_SysVoteBL.zx_SysVoteDA.CheckProperty4Condition(objzx_SysVoteEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_SysVoteEN objzx_SysVoteCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.zxVoteId) == true)
{
string strComparisonOpzxVoteId = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.zxVoteId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SysVote.zxVoteId, objzx_SysVoteCond.zxVoteId, strComparisonOpzxVoteId);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.TableKey) == true)
{
string strComparisonOpTableKey = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.TableKey, objzx_SysVoteCond.TableKey, strComparisonOpTableKey);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.PubParentId) == true)
{
string strComparisonOpPubParentId = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.PubParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.PubParentId, objzx_SysVoteCond.PubParentId, strComparisonOpPubParentId);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.zxVoteTypeId) == true)
{
string strComparisonOpzxVoteTypeId = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.zxVoteTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.zxVoteTypeId, objzx_SysVoteCond.zxVoteTypeId, strComparisonOpzxVoteTypeId);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.UpdUser, objzx_SysVoteCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.UpdDate, objzx_SysVoteCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.Memo) == true)
{
string strComparisonOpMemo = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.Memo, objzx_SysVoteCond.Memo, strComparisonOpMemo);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.IdCurrEduCls, objzx_SysVoteCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_SysVoteCond.IsUpdated(conzx_SysVote.UserId) == true)
{
string strComparisonOpUserId = objzx_SysVoteCond.dicFldComparisonOp[conzx_SysVote.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysVote.UserId, objzx_SysVoteCond.UserId, strComparisonOpUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_SysVote(中学系统点赞表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxVoteId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_SysVoteEN objzx_SysVoteEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_SysVoteEN == null) return true;
if (objzx_SysVoteEN.zxVoteId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxVoteId = '{0}'", objzx_SysVoteEN.zxVoteId);
if (clszx_SysVoteBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxVoteId !=  {0}", objzx_SysVoteEN.zxVoteId);
 sbCondition.AppendFormat(" and zxVoteId = '{0}'", objzx_SysVoteEN.zxVoteId);
if (clszx_SysVoteBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_SysVote(中学系统点赞表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxVoteId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_SysVoteEN objzx_SysVoteEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_SysVoteEN == null) return "";
if (objzx_SysVoteEN.zxVoteId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxVoteId = '{0}'", objzx_SysVoteEN.zxVoteId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxVoteId !=  {0}", objzx_SysVoteEN.zxVoteId);
 sbCondition.AppendFormat(" and zxVoteId = '{0}'", objzx_SysVoteEN.zxVoteId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_SysVote
{
public virtual bool UpdRelaTabDate(long lngzxVoteId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学系统点赞表(zx_SysVote)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_SysVoteBL
{
public static RelatedActions_zx_SysVote relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_SysVoteDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_SysVoteDA zx_SysVoteDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_SysVoteDA();
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
 public clszx_SysVoteBL()
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
if (string.IsNullOrEmpty(clszx_SysVoteEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SysVoteEN._ConnectString);
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
public static DataTable GetDataTable_zx_SysVote(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_SysVoteDA.GetDataTable_zx_SysVote(strWhereCond);
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
objDT = zx_SysVoteDA.GetDataTable(strWhereCond);
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
objDT = zx_SysVoteDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_SysVoteDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_SysVoteDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_SysVoteDA.GetDataTable_Top(objTopPara);
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
objDT = zx_SysVoteDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_SysVoteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_SysVoteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxVoteIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_SysVoteEN> GetObjLstByZxVoteIdLst(List<long> arrZxVoteIdLst)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxVoteIdLst);
 string strWhereCond = string.Format("zxVoteId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxVoteIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_SysVoteEN> GetObjLstByZxVoteIdLstCache(List<long> arrZxVoteIdLst)
{
string strKey = string.Format("{0}", clszx_SysVoteEN._CurrTabName);
List<clszx_SysVoteEN> arrzx_SysVoteObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysVoteEN> arrzx_SysVoteObjLst_Sel =
arrzx_SysVoteObjLstCache
.Where(x => arrZxVoteIdLst.Contains(x.zxVoteId));
return arrzx_SysVoteObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysVoteEN> GetObjLst(string strWhereCond)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
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
public static List<clszx_SysVoteEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_SysVoteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_SysVoteEN> GetSubObjLstCache(clszx_SysVoteEN objzx_SysVoteCond)
{
List<clszx_SysVoteEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysVoteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SysVote.AttributeName)
{
if (objzx_SysVoteCond.IsUpdated(strFldName) == false) continue;
if (objzx_SysVoteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysVoteCond[strFldName].ToString());
}
else
{
if (objzx_SysVoteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SysVoteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysVoteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SysVoteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SysVoteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SysVoteCond[strFldName]));
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
public static List<clszx_SysVoteEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
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
public static List<clszx_SysVoteEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
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
List<clszx_SysVoteEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_SysVoteEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysVoteEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_SysVoteEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
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
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
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
public static List<clszx_SysVoteEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_SysVoteEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_SysVoteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
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
public static List<clszx_SysVoteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysVoteEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_SysVoteEN> arrObjLst = new List<clszx_SysVoteEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysVoteEN objzx_SysVoteEN = new clszx_SysVoteEN();
try
{
objzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[conzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objzx_SysVoteEN.TableKey = objRow[conzx_SysVote.TableKey] == DBNull.Value ? null : objRow[conzx_SysVote.TableKey].ToString().Trim(); //表主键
objzx_SysVoteEN.PubParentId = objRow[conzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[conzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objzx_SysVoteEN.zxVoteTypeId = objRow[conzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[conzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
objzx_SysVoteEN.UpdUser = objRow[conzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[conzx_SysVote.UpdUser].ToString().Trim(); //修改人
objzx_SysVoteEN.UpdDate = objRow[conzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[conzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objzx_SysVoteEN.Memo = objRow[conzx_SysVote.Memo] == DBNull.Value ? null : objRow[conzx_SysVote.Memo].ToString().Trim(); //备注
objzx_SysVoteEN.IdCurrEduCls = objRow[conzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysVoteEN.UserId = objRow[conzx_SysVote.UserId] == DBNull.Value ? null : objRow[conzx_SysVote.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysVoteEN.zxVoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysVoteEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_SysVote(ref clszx_SysVoteEN objzx_SysVoteEN)
{
bool bolResult = zx_SysVoteDA.Getzx_SysVote(ref objzx_SysVoteEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngzxVoteId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SysVoteEN GetObjByzxVoteId(long lngzxVoteId)
{
clszx_SysVoteEN objzx_SysVoteEN = zx_SysVoteDA.GetObjByzxVoteId(lngzxVoteId);
return objzx_SysVoteEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_SysVoteEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_SysVoteEN objzx_SysVoteEN = zx_SysVoteDA.GetFirstObj(strWhereCond);
 return objzx_SysVoteEN;
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
public static clszx_SysVoteEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_SysVoteEN objzx_SysVoteEN = zx_SysVoteDA.GetObjByDataRow(objRow);
 return objzx_SysVoteEN;
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
public static clszx_SysVoteEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_SysVoteEN objzx_SysVoteEN = zx_SysVoteDA.GetObjByDataRow(objRow);
 return objzx_SysVoteEN;
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
 /// <param name = "lngzxVoteId">所给的关键字</param>
 /// <param name = "lstzx_SysVoteObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SysVoteEN GetObjByzxVoteIdFromList(long lngzxVoteId, List<clszx_SysVoteEN> lstzx_SysVoteObjLst)
{
foreach (clszx_SysVoteEN objzx_SysVoteEN in lstzx_SysVoteObjLst)
{
if (objzx_SysVoteEN.zxVoteId == lngzxVoteId)
{
return objzx_SysVoteEN;
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
 long lngzxVoteId;
 try
 {
 lngzxVoteId = new clszx_SysVoteDA().GetFirstID(strWhereCond);
 return lngzxVoteId;
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
 arrList = zx_SysVoteDA.GetID(strWhereCond);
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
bool bolIsExist = zx_SysVoteDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngzxVoteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngzxVoteId)
{
//检测记录是否存在
bool bolIsExist = zx_SysVoteDA.IsExist(lngzxVoteId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngzxVoteId">点赞Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngzxVoteId, string strOpUser)
{
clszx_SysVoteEN objzx_SysVoteEN = clszx_SysVoteBL.GetObjByzxVoteId(lngzxVoteId);
objzx_SysVoteEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objzx_SysVoteEN.UpdUser = strOpUser;
return clszx_SysVoteBL.UpdateBySql2(objzx_SysVoteEN);
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
 bolIsExist = clszx_SysVoteDA.IsExistTable();
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
 bolIsExist = zx_SysVoteDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_SysVoteEN objzx_SysVoteEN)
{
if (objzx_SysVoteEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!点赞Id = [{0}]的数据已经存在!(in clszx_SysVoteBL.AddNewRecordBySql2)", objzx_SysVoteEN.zxVoteId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_SysVoteDA.AddNewRecordBySQL2(objzx_SysVoteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_SysVoteEN objzx_SysVoteEN)
{
if (objzx_SysVoteEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!点赞Id = [{0}]的数据已经存在!(in clszx_SysVoteBL.AddNewRecordBySql2WithReturnKey)", objzx_SysVoteEN.zxVoteId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_SysVoteDA.AddNewRecordBySQL2WithReturnKey(objzx_SysVoteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_SysVoteEN objzx_SysVoteEN)
{
try
{
bool bolResult = zx_SysVoteDA.Update(objzx_SysVoteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "objzx_SysVoteEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_SysVoteEN objzx_SysVoteEN)
{
 if (objzx_SysVoteEN.zxVoteId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_SysVoteDA.UpdateBySql2(objzx_SysVoteEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysVoteBL.ReFreshCache();

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
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
 /// <param name = "lngzxVoteId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngzxVoteId)
{
try
{
 clszx_SysVoteEN objzx_SysVoteEN = clszx_SysVoteBL.GetObjByzxVoteId(lngzxVoteId);

if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(objzx_SysVoteEN.zxVoteId, objzx_SysVoteEN.UpdUser);
}
if (objzx_SysVoteEN != null)
{
int intRecNum = zx_SysVoteDA.DelRecord(lngzxVoteId);
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
/// <param name="lngzxVoteId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngzxVoteId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SysVoteDA.GetSpecSQLObj();
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
//删除与表:[zx_SysVote]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_SysVote.zxVoteId,
//lngzxVoteId);
//        clszx_SysVoteBL.Delzx_SysVotesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SysVoteBL.DelRecord(lngzxVoteId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SysVoteBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngzxVoteId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngzxVoteId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngzxVoteId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_SysVoteBL.relatedActions != null)
{
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(lngzxVoteId, "UpdRelaTabDate");
}
bool bolResult = zx_SysVoteDA.DelRecord(lngzxVoteId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxVoteIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_SysVotes(List<string> arrzxVoteIdLst)
{
if (arrzxVoteIdLst.Count == 0) return 0;
try
{
if (clszx_SysVoteBL.relatedActions != null)
{
foreach (var strzxVoteId in arrzxVoteIdLst)
{
long lngzxVoteId = long.Parse(strzxVoteId);
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(lngzxVoteId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_SysVoteDA.Delzx_SysVote(arrzxVoteIdLst);
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
public static int Delzx_SysVotesByCond(string strWhereCond)
{
try
{
if (clszx_SysVoteBL.relatedActions != null)
{
List<string> arrzxVoteId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxVoteId in arrzxVoteId)
{
long lngzxVoteId = long.Parse(strzxVoteId);
clszx_SysVoteBL.relatedActions.UpdRelaTabDate(lngzxVoteId, "UpdRelaTabDate");
}
}
int intRecNum = zx_SysVoteDA.Delzx_SysVote(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_SysVote]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngzxVoteId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngzxVoteId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SysVoteDA.GetSpecSQLObj();
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
//删除与表:[zx_SysVote]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SysVoteBL.DelRecord(lngzxVoteId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SysVoteBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngzxVoteId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_SysVoteENS">源对象</param>
 /// <param name = "objzx_SysVoteENT">目标对象</param>
 public static void CopyTo(clszx_SysVoteEN objzx_SysVoteENS, clszx_SysVoteEN objzx_SysVoteENT)
{
try
{
objzx_SysVoteENT.zxVoteId = objzx_SysVoteENS.zxVoteId; //点赞Id
objzx_SysVoteENT.TableKey = objzx_SysVoteENS.TableKey; //表主键
objzx_SysVoteENT.PubParentId = objzx_SysVoteENS.PubParentId; //公共父Id
objzx_SysVoteENT.zxVoteTypeId = objzx_SysVoteENS.zxVoteTypeId; //点赞类型Id
objzx_SysVoteENT.UpdUser = objzx_SysVoteENS.UpdUser; //修改人
objzx_SysVoteENT.UpdDate = objzx_SysVoteENS.UpdDate; //修改日期
objzx_SysVoteENT.Memo = objzx_SysVoteENS.Memo; //备注
objzx_SysVoteENT.IdCurrEduCls = objzx_SysVoteENS.IdCurrEduCls; //教学班流水号
objzx_SysVoteENT.UserId = objzx_SysVoteENS.UserId; //用户ID
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
 /// <param name = "objzx_SysVoteEN">源简化对象</param>
 public static void SetUpdFlag(clszx_SysVoteEN objzx_SysVoteEN)
{
try
{
objzx_SysVoteEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_SysVoteEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_SysVote.zxVoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.zxVoteId = objzx_SysVoteEN.zxVoteId; //点赞Id
}
if (arrFldSet.Contains(conzx_SysVote.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.TableKey = objzx_SysVoteEN.TableKey == "[null]" ? null :  objzx_SysVoteEN.TableKey; //表主键
}
if (arrFldSet.Contains(conzx_SysVote.PubParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.PubParentId = objzx_SysVoteEN.PubParentId == "[null]" ? null :  objzx_SysVoteEN.PubParentId; //公共父Id
}
if (arrFldSet.Contains(conzx_SysVote.zxVoteTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.zxVoteTypeId = objzx_SysVoteEN.zxVoteTypeId == "[null]" ? null :  objzx_SysVoteEN.zxVoteTypeId; //点赞类型Id
}
if (arrFldSet.Contains(conzx_SysVote.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.UpdUser = objzx_SysVoteEN.UpdUser == "[null]" ? null :  objzx_SysVoteEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_SysVote.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.UpdDate = objzx_SysVoteEN.UpdDate == "[null]" ? null :  objzx_SysVoteEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_SysVote.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.Memo = objzx_SysVoteEN.Memo == "[null]" ? null :  objzx_SysVoteEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_SysVote.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.IdCurrEduCls = objzx_SysVoteEN.IdCurrEduCls == "[null]" ? null :  objzx_SysVoteEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_SysVote.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysVoteEN.UserId = objzx_SysVoteEN.UserId == "[null]" ? null :  objzx_SysVoteEN.UserId; //用户ID
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
 /// <param name = "objzx_SysVoteEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_SysVoteEN objzx_SysVoteEN)
{
try
{
if (objzx_SysVoteEN.TableKey == "[null]") objzx_SysVoteEN.TableKey = null; //表主键
if (objzx_SysVoteEN.PubParentId == "[null]") objzx_SysVoteEN.PubParentId = null; //公共父Id
if (objzx_SysVoteEN.zxVoteTypeId == "[null]") objzx_SysVoteEN.zxVoteTypeId = null; //点赞类型Id
if (objzx_SysVoteEN.UpdUser == "[null]") objzx_SysVoteEN.UpdUser = null; //修改人
if (objzx_SysVoteEN.UpdDate == "[null]") objzx_SysVoteEN.UpdDate = null; //修改日期
if (objzx_SysVoteEN.Memo == "[null]") objzx_SysVoteEN.Memo = null; //备注
if (objzx_SysVoteEN.IdCurrEduCls == "[null]") objzx_SysVoteEN.IdCurrEduCls = null; //教学班流水号
if (objzx_SysVoteEN.UserId == "[null]") objzx_SysVoteEN.UserId = null; //用户ID
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
public static void CheckPropertyNew(clszx_SysVoteEN objzx_SysVoteEN)
{
 zx_SysVoteDA.CheckPropertyNew(objzx_SysVoteEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_SysVoteEN objzx_SysVoteEN)
{
 zx_SysVoteDA.CheckProperty4Condition(objzx_SysVoteEN);
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
if (clszx_SysVoteBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysVoteBL没有刷新缓存机制(clszx_SysVoteBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxVoteId");
//if (arrzx_SysVoteObjLstCache == null)
//{
//arrzx_SysVoteObjLstCache = zx_SysVoteDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngzxVoteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SysVoteEN GetObjByzxVoteIdCache(long lngzxVoteId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_SysVoteEN._CurrTabName);
List<clszx_SysVoteEN> arrzx_SysVoteObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysVoteEN> arrzx_SysVoteObjLst_Sel =
arrzx_SysVoteObjLstCache
.Where(x=> x.zxVoteId == lngzxVoteId 
);
if (arrzx_SysVoteObjLst_Sel.Count() == 0)
{
   clszx_SysVoteEN obj = clszx_SysVoteBL.GetObjByzxVoteId(lngzxVoteId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_SysVoteObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SysVoteEN> GetAllzx_SysVoteObjLstCache()
{
//获取缓存中的对象列表
List<clszx_SysVoteEN> arrzx_SysVoteObjLstCache = GetObjLstCache(); 
return arrzx_SysVoteObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SysVoteEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_SysVoteEN._CurrTabName);
List<clszx_SysVoteEN> arrzx_SysVoteObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_SysVoteObjLstCache;
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
string strKey = string.Format("{0}", clszx_SysVoteEN._CurrTabName);
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
if (clszx_SysVoteBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_SysVoteEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_SysVoteBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_SysVote(中学系统点赞表)
 /// 唯一性条件:zxVoteId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SysVoteEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_SysVoteEN objzx_SysVoteEN)
{
//检测记录是否存在
string strResult = zx_SysVoteDA.GetUniCondStr(objzx_SysVoteEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngzxVoteId)
{
if (strInFldName != conzx_SysVote.zxVoteId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_SysVote.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_SysVote.AttributeName));
throw new Exception(strMsg);
}
var objzx_SysVote = clszx_SysVoteBL.GetObjByzxVoteIdCache(lngzxVoteId);
if (objzx_SysVote == null) return "";
return objzx_SysVote[strOutFldName].ToString();
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
int intRecCount = clszx_SysVoteDA.GetRecCount(strTabName);
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
int intRecCount = clszx_SysVoteDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_SysVoteDA.GetRecCount();
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
int intRecCount = clszx_SysVoteDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_SysVoteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_SysVoteEN objzx_SysVoteCond)
{
List<clszx_SysVoteEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysVoteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SysVote.AttributeName)
{
if (objzx_SysVoteCond.IsUpdated(strFldName) == false) continue;
if (objzx_SysVoteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysVoteCond[strFldName].ToString());
}
else
{
if (objzx_SysVoteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SysVoteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysVoteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SysVoteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SysVoteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SysVoteCond[strFldName]));
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
 List<string> arrList = clszx_SysVoteDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_SysVoteDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_SysVoteDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_SysVoteDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SysVoteDA.SetFldValue(clszx_SysVoteEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_SysVoteDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SysVoteDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SysVoteDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SysVoteDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_SysVote] "); 
 strCreateTabCode.Append(" ( "); 
 // /**点赞Id*/ 
 strCreateTabCode.Append(" zxVoteId bigint primary key identity, "); 
 // /**表主键*/ 
 strCreateTabCode.Append(" TableKey varchar(20) Null, "); 
 // /**公共父Id*/ 
 strCreateTabCode.Append(" PubParentId varchar(20) Null, "); 
 // /**点赞类型Id*/ 
 strCreateTabCode.Append(" zxVoteTypeId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学系统点赞表(zx_SysVote)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_SysVote : clsCommFun4BL
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
clszx_SysVoteBL.ReFreshThisCache();
}
}

}