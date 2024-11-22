
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTPaperRelaBL
 表名:RTPaperRela(01120581)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsRTPaperRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTPaperRelaEN GetObj(this K_mId_RTPaperRela myKey)
{
clsRTPaperRelaEN objRTPaperRelaEN = clsRTPaperRelaBL.RTPaperRelaDA.GetObjBymId(myKey.Value);
return objRTPaperRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRTPaperRelaEN objRTPaperRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTPaperRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTPaperRelaBL.AddNewRecord)", objRTPaperRelaEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsRTPaperRelaBL.RTPaperRelaDA.AddNewRecordBySQL2(objRTPaperRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsRTPaperRelaEN objRTPaperRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objRTPaperRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objRTPaperRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objRTPaperRelaEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objRTPaperRelaEN.AddNewRecord();
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
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRTPaperRelaEN objRTPaperRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTPaperRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTPaperRelaBL.AddNewRecordWithReturnKey)", objRTPaperRelaEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsRTPaperRelaBL.RTPaperRelaDA.AddNewRecordBySQL2WithReturnKey(objRTPaperRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTPaperRelaEN SetmId(this clsRTPaperRelaEN objRTPaperRelaEN, long lngmId, string strComparisonOp="")
	{
objRTPaperRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTPaperRelaEN.dicFldComparisonOp.ContainsKey(conRTPaperRela.mId) == false)
{
objRTPaperRelaEN.dicFldComparisonOp.Add(conRTPaperRela.mId, strComparisonOp);
}
else
{
objRTPaperRelaEN.dicFldComparisonOp[conRTPaperRela.mId] = strComparisonOp;
}
}
return objRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTPaperRelaEN SetTopicId(this clsRTPaperRelaEN objRTPaperRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conRTPaperRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conRTPaperRela.TopicId);
}
objRTPaperRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTPaperRelaEN.dicFldComparisonOp.ContainsKey(conRTPaperRela.TopicId) == false)
{
objRTPaperRelaEN.dicFldComparisonOp.Add(conRTPaperRela.TopicId, strComparisonOp);
}
else
{
objRTPaperRelaEN.dicFldComparisonOp[conRTPaperRela.TopicId] = strComparisonOp;
}
}
return objRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTPaperRelaEN SetPaperId(this clsRTPaperRelaEN objRTPaperRelaEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, conRTPaperRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conRTPaperRela.PaperId);
}
objRTPaperRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTPaperRelaEN.dicFldComparisonOp.ContainsKey(conRTPaperRela.PaperId) == false)
{
objRTPaperRelaEN.dicFldComparisonOp.Add(conRTPaperRela.PaperId, strComparisonOp);
}
else
{
objRTPaperRelaEN.dicFldComparisonOp[conRTPaperRela.PaperId] = strComparisonOp;
}
}
return objRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTPaperRelaEN SetUpdDate(this clsRTPaperRelaEN objRTPaperRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conRTPaperRela.UpdDate);
}
objRTPaperRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTPaperRelaEN.dicFldComparisonOp.ContainsKey(conRTPaperRela.UpdDate) == false)
{
objRTPaperRelaEN.dicFldComparisonOp.Add(conRTPaperRela.UpdDate, strComparisonOp);
}
else
{
objRTPaperRelaEN.dicFldComparisonOp[conRTPaperRela.UpdDate] = strComparisonOp;
}
}
return objRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTPaperRelaEN SetUpdUser(this clsRTPaperRelaEN objRTPaperRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conRTPaperRela.UpdUser);
}
objRTPaperRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTPaperRelaEN.dicFldComparisonOp.ContainsKey(conRTPaperRela.UpdUser) == false)
{
objRTPaperRelaEN.dicFldComparisonOp.Add(conRTPaperRela.UpdUser, strComparisonOp);
}
else
{
objRTPaperRelaEN.dicFldComparisonOp[conRTPaperRela.UpdUser] = strComparisonOp;
}
}
return objRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTPaperRelaEN SetMemo(this clsRTPaperRelaEN objRTPaperRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRTPaperRela.Memo);
}
objRTPaperRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTPaperRelaEN.dicFldComparisonOp.ContainsKey(conRTPaperRela.Memo) == false)
{
objRTPaperRelaEN.dicFldComparisonOp.Add(conRTPaperRela.Memo, strComparisonOp);
}
else
{
objRTPaperRelaEN.dicFldComparisonOp[conRTPaperRela.Memo] = strComparisonOp;
}
}
return objRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTPaperRelaEN SetIdCurrEduCls(this clsRTPaperRelaEN objRTPaperRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conRTPaperRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conRTPaperRela.IdCurrEduCls);
}
objRTPaperRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTPaperRelaEN.dicFldComparisonOp.ContainsKey(conRTPaperRela.IdCurrEduCls) == false)
{
objRTPaperRelaEN.dicFldComparisonOp.Add(conRTPaperRela.IdCurrEduCls, strComparisonOp);
}
else
{
objRTPaperRelaEN.dicFldComparisonOp[conRTPaperRela.IdCurrEduCls] = strComparisonOp;
}
}
return objRTPaperRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRTPaperRelaEN objRTPaperRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRTPaperRelaEN.CheckPropertyNew();
clsRTPaperRelaEN objRTPaperRelaCond = new clsRTPaperRelaEN();
string strCondition = objRTPaperRelaCond
.SetmId(objRTPaperRelaEN.mId, "<>")
.SetmId(objRTPaperRelaEN.mId, "=")
.GetCombineCondition();
objRTPaperRelaEN._IsCheckProperty = true;
bool bolIsExist = clsRTPaperRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRTPaperRelaEN.Update();
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
 /// <param name = "objRTPaperRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsRTPaperRelaEN objRTPaperRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsRTPaperRelaEN objRTPaperRelaCond = new clsRTPaperRelaEN();
string strCondition = objRTPaperRelaCond
.SetmId(objRTPaperRela.mId, "=")
.GetCombineCondition();
objRTPaperRela._IsCheckProperty = true;
bool bolIsExist = clsRTPaperRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objRTPaperRela.mId = clsRTPaperRelaBL.GetFirstID_S(strCondition);
objRTPaperRela.UpdateWithCondition(strCondition);
}
else
{
objRTPaperRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTPaperRelaEN objRTPaperRelaEN)
{
 if (objRTPaperRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTPaperRelaBL.RTPaperRelaDA.UpdateBySql2(objRTPaperRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTPaperRelaEN objRTPaperRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRTPaperRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTPaperRelaBL.RTPaperRelaDA.UpdateBySql2(objRTPaperRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTPaperRelaEN objRTPaperRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsRTPaperRelaBL.RTPaperRelaDA.UpdateBySqlWithCondition(objRTPaperRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTPaperRelaEN objRTPaperRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRTPaperRelaBL.RTPaperRelaDA.UpdateBySqlWithConditionTransaction(objRTPaperRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
public static int Delete(this clsRTPaperRelaEN objRTPaperRelaEN)
{
try
{
int intRecNum = clsRTPaperRelaBL.RTPaperRelaDA.DelRecord(objRTPaperRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaENS">源对象</param>
 /// <param name = "objRTPaperRelaENT">目标对象</param>
 public static void CopyTo(this clsRTPaperRelaEN objRTPaperRelaENS, clsRTPaperRelaEN objRTPaperRelaENT)
{
try
{
objRTPaperRelaENT.mId = objRTPaperRelaENS.mId; //mId
objRTPaperRelaENT.TopicId = objRTPaperRelaENS.TopicId; //主题Id
objRTPaperRelaENT.PaperId = objRTPaperRelaENS.PaperId; //论文Id
objRTPaperRelaENT.UpdDate = objRTPaperRelaENS.UpdDate; //修改日期
objRTPaperRelaENT.UpdUser = objRTPaperRelaENS.UpdUser; //修改人
objRTPaperRelaENT.Memo = objRTPaperRelaENS.Memo; //备注
objRTPaperRelaENT.IdCurrEduCls = objRTPaperRelaENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTPaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsRTPaperRelaEN:objRTPaperRelaENT</returns>
 public static clsRTPaperRelaEN CopyTo(this clsRTPaperRelaEN objRTPaperRelaENS)
{
try
{
 clsRTPaperRelaEN objRTPaperRelaENT = new clsRTPaperRelaEN()
{
mId = objRTPaperRelaENS.mId, //mId
TopicId = objRTPaperRelaENS.TopicId, //主题Id
PaperId = objRTPaperRelaENS.PaperId, //论文Id
UpdDate = objRTPaperRelaENS.UpdDate, //修改日期
UpdUser = objRTPaperRelaENS.UpdUser, //修改人
Memo = objRTPaperRelaENS.Memo, //备注
IdCurrEduCls = objRTPaperRelaENS.IdCurrEduCls, //教学班流水号
};
 return objRTPaperRelaENT;
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
public static void CheckPropertyNew(this clsRTPaperRelaEN objRTPaperRelaEN)
{
 clsRTPaperRelaBL.RTPaperRelaDA.CheckPropertyNew(objRTPaperRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRTPaperRelaEN objRTPaperRelaEN)
{
 clsRTPaperRelaBL.RTPaperRelaDA.CheckProperty4Condition(objRTPaperRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRTPaperRelaEN objRTPaperRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRTPaperRelaCond.IsUpdated(conRTPaperRela.mId) == true)
{
string strComparisonOpmId = objRTPaperRelaCond.dicFldComparisonOp[conRTPaperRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conRTPaperRela.mId, objRTPaperRelaCond.mId, strComparisonOpmId);
}
if (objRTPaperRelaCond.IsUpdated(conRTPaperRela.TopicId) == true)
{
string strComparisonOpTopicId = objRTPaperRelaCond.dicFldComparisonOp[conRTPaperRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTPaperRela.TopicId, objRTPaperRelaCond.TopicId, strComparisonOpTopicId);
}
if (objRTPaperRelaCond.IsUpdated(conRTPaperRela.PaperId) == true)
{
string strComparisonOpPaperId = objRTPaperRelaCond.dicFldComparisonOp[conRTPaperRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTPaperRela.PaperId, objRTPaperRelaCond.PaperId, strComparisonOpPaperId);
}
if (objRTPaperRelaCond.IsUpdated(conRTPaperRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objRTPaperRelaCond.dicFldComparisonOp[conRTPaperRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTPaperRela.UpdDate, objRTPaperRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objRTPaperRelaCond.IsUpdated(conRTPaperRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objRTPaperRelaCond.dicFldComparisonOp[conRTPaperRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTPaperRela.UpdUser, objRTPaperRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objRTPaperRelaCond.IsUpdated(conRTPaperRela.Memo) == true)
{
string strComparisonOpMemo = objRTPaperRelaCond.dicFldComparisonOp[conRTPaperRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTPaperRela.Memo, objRTPaperRelaCond.Memo, strComparisonOpMemo);
}
if (objRTPaperRelaCond.IsUpdated(conRTPaperRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objRTPaperRelaCond.dicFldComparisonOp[conRTPaperRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTPaperRela.IdCurrEduCls, objRTPaperRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--RTPaperRela(RTPaperRela), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsRTPaperRelaEN objRTPaperRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objRTPaperRelaEN == null) return true;
if (objRTPaperRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objRTPaperRelaEN.mId);
if (clsRTPaperRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTPaperRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objRTPaperRelaEN.mId);
if (clsRTPaperRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--RTPaperRela(RTPaperRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsRTPaperRelaEN objRTPaperRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objRTPaperRelaEN == null) return "";
if (objRTPaperRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objRTPaperRelaEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTPaperRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objRTPaperRelaEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_RTPaperRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// RTPaperRela(RTPaperRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRTPaperRelaBL
{
public static RelatedActions_RTPaperRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRTPaperRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRTPaperRelaDA RTPaperRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRTPaperRelaDA();
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
 public clsRTPaperRelaBL()
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
if (string.IsNullOrEmpty(clsRTPaperRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRTPaperRelaEN._ConnectString);
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
public static DataTable GetDataTable_RTPaperRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RTPaperRelaDA.GetDataTable_RTPaperRela(strWhereCond);
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
objDT = RTPaperRelaDA.GetDataTable(strWhereCond);
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
objDT = RTPaperRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RTPaperRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RTPaperRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RTPaperRelaDA.GetDataTable_Top(objTopPara);
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
objDT = RTPaperRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = RTPaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RTPaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsRTPaperRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
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
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRTPaperRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsRTPaperRelaEN._CurrTabName);
List<clsRTPaperRelaEN> arrRTPaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsRTPaperRelaEN> arrRTPaperRelaObjLst_Sel =
arrRTPaperRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrRTPaperRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTPaperRelaEN> GetObjLst(string strWhereCond)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
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
public static List<clsRTPaperRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRTPaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRTPaperRelaEN> GetSubObjLstCache(clsRTPaperRelaEN objRTPaperRelaCond)
{
List<clsRTPaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRTPaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTPaperRela.AttributeName)
{
if (objRTPaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTPaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTPaperRelaCond[strFldName].ToString());
}
else
{
if (objRTPaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTPaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTPaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTPaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTPaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTPaperRelaCond[strFldName]));
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
public static List<clsRTPaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
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
public static List<clsRTPaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
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
List<clsRTPaperRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRTPaperRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTPaperRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRTPaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
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
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
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
public static List<clsRTPaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRTPaperRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRTPaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
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
public static List<clsRTPaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTPaperRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRTPaperRelaEN> arrObjLst = new List<clsRTPaperRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTPaperRelaEN objRTPaperRelaEN = new clsRTPaperRelaEN();
try
{
objRTPaperRelaEN.mId = Int32.Parse(objRow[conRTPaperRela.mId].ToString().Trim()); //mId
objRTPaperRelaEN.TopicId = objRow[conRTPaperRela.TopicId] == DBNull.Value ? null : objRow[conRTPaperRela.TopicId].ToString().Trim(); //主题Id
objRTPaperRelaEN.PaperId = objRow[conRTPaperRela.PaperId] == DBNull.Value ? null : objRow[conRTPaperRela.PaperId].ToString().Trim(); //论文Id
objRTPaperRelaEN.UpdDate = objRow[conRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[conRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objRTPaperRelaEN.UpdUser = objRow[conRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[conRTPaperRela.UpdUser].ToString().Trim(); //修改人
objRTPaperRelaEN.Memo = objRow[conRTPaperRela.Memo] == DBNull.Value ? null : objRow[conRTPaperRela.Memo].ToString().Trim(); //备注
objRTPaperRelaEN.IdCurrEduCls = objRow[conRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTPaperRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRTPaperRela(ref clsRTPaperRelaEN objRTPaperRelaEN)
{
bool bolResult = RTPaperRelaDA.GetRTPaperRela(ref objRTPaperRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTPaperRelaEN GetObjBymId(long lngmId)
{
clsRTPaperRelaEN objRTPaperRelaEN = RTPaperRelaDA.GetObjBymId(lngmId);
return objRTPaperRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRTPaperRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRTPaperRelaEN objRTPaperRelaEN = RTPaperRelaDA.GetFirstObj(strWhereCond);
 return objRTPaperRelaEN;
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
public static clsRTPaperRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRTPaperRelaEN objRTPaperRelaEN = RTPaperRelaDA.GetObjByDataRow(objRow);
 return objRTPaperRelaEN;
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
public static clsRTPaperRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRTPaperRelaEN objRTPaperRelaEN = RTPaperRelaDA.GetObjByDataRow(objRow);
 return objRTPaperRelaEN;
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
 /// <param name = "lstRTPaperRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTPaperRelaEN GetObjBymIdFromList(long lngmId, List<clsRTPaperRelaEN> lstRTPaperRelaObjLst)
{
foreach (clsRTPaperRelaEN objRTPaperRelaEN in lstRTPaperRelaObjLst)
{
if (objRTPaperRelaEN.mId == lngmId)
{
return objRTPaperRelaEN;
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
 lngmId = new clsRTPaperRelaDA().GetFirstID(strWhereCond);
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
 arrList = RTPaperRelaDA.GetID(strWhereCond);
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
bool bolIsExist = RTPaperRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = RTPaperRelaDA.IsExist(lngmId);
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
clsRTPaperRelaEN objRTPaperRelaEN = clsRTPaperRelaBL.GetObjBymId(lngmId);
objRTPaperRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objRTPaperRelaEN.UpdUser = strOpUser;
return clsRTPaperRelaBL.UpdateBySql2(objRTPaperRelaEN);
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
 bolIsExist = clsRTPaperRelaDA.IsExistTable();
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
 bolIsExist = RTPaperRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRTPaperRelaEN objRTPaperRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTPaperRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTPaperRelaBL.AddNewRecordBySql2)", objRTPaperRelaEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = RTPaperRelaDA.AddNewRecordBySQL2(objRTPaperRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRTPaperRelaEN objRTPaperRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTPaperRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTPaperRelaBL.AddNewRecordBySql2WithReturnKey)", objRTPaperRelaEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = RTPaperRelaDA.AddNewRecordBySQL2WithReturnKey(objRTPaperRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRTPaperRelaEN objRTPaperRelaEN)
{
try
{
bool bolResult = RTPaperRelaDA.Update(objRTPaperRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 /// <param name = "objRTPaperRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRTPaperRelaEN objRTPaperRelaEN)
{
 if (objRTPaperRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RTPaperRelaDA.UpdateBySql2(objRTPaperRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTPaperRelaBL.ReFreshCache();

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
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
 clsRTPaperRelaEN objRTPaperRelaEN = clsRTPaperRelaBL.GetObjBymId(lngmId);

if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(objRTPaperRelaEN.mId, objRTPaperRelaEN.UpdUser);
}
if (objRTPaperRelaEN != null)
{
int intRecNum = RTPaperRelaDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRTPaperRelaDA.GetSpecSQLObj();
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
//删除与表:[RTPaperRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRTPaperRela.mId,
//lngmId);
//        clsRTPaperRelaBL.DelRTPaperRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTPaperRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTPaperRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsRTPaperRelaBL.relatedActions != null)
{
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = RTPaperRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRTPaperRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsRTPaperRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = RTPaperRelaDA.DelRTPaperRela(arrmIdLst);
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
public static int DelRTPaperRelasByCond(string strWhereCond)
{
try
{
if (clsRTPaperRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsRTPaperRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = RTPaperRelaDA.DelRTPaperRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[RTPaperRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRTPaperRelaDA.GetSpecSQLObj();
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
//删除与表:[RTPaperRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTPaperRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTPaperRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objRTPaperRelaENS">源对象</param>
 /// <param name = "objRTPaperRelaENT">目标对象</param>
 public static void CopyTo(clsRTPaperRelaEN objRTPaperRelaENS, clsRTPaperRelaEN objRTPaperRelaENT)
{
try
{
objRTPaperRelaENT.mId = objRTPaperRelaENS.mId; //mId
objRTPaperRelaENT.TopicId = objRTPaperRelaENS.TopicId; //主题Id
objRTPaperRelaENT.PaperId = objRTPaperRelaENS.PaperId; //论文Id
objRTPaperRelaENT.UpdDate = objRTPaperRelaENS.UpdDate; //修改日期
objRTPaperRelaENT.UpdUser = objRTPaperRelaENS.UpdUser; //修改人
objRTPaperRelaENT.Memo = objRTPaperRelaENS.Memo; //备注
objRTPaperRelaENT.IdCurrEduCls = objRTPaperRelaENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTPaperRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsRTPaperRelaEN objRTPaperRelaEN)
{
try
{
objRTPaperRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objRTPaperRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRTPaperRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTPaperRelaEN.mId = objRTPaperRelaEN.mId; //mId
}
if (arrFldSet.Contains(conRTPaperRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTPaperRelaEN.TopicId = objRTPaperRelaEN.TopicId == "[null]" ? null :  objRTPaperRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conRTPaperRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTPaperRelaEN.PaperId = objRTPaperRelaEN.PaperId == "[null]" ? null :  objRTPaperRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(conRTPaperRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objRTPaperRelaEN.UpdDate = objRTPaperRelaEN.UpdDate == "[null]" ? null :  objRTPaperRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conRTPaperRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objRTPaperRelaEN.UpdUser = objRTPaperRelaEN.UpdUser == "[null]" ? null :  objRTPaperRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conRTPaperRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRTPaperRelaEN.Memo = objRTPaperRelaEN.Memo == "[null]" ? null :  objRTPaperRelaEN.Memo; //备注
}
if (arrFldSet.Contains(conRTPaperRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objRTPaperRelaEN.IdCurrEduCls = objRTPaperRelaEN.IdCurrEduCls == "[null]" ? null :  objRTPaperRelaEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTPaperRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsRTPaperRelaEN objRTPaperRelaEN)
{
try
{
if (objRTPaperRelaEN.TopicId == "[null]") objRTPaperRelaEN.TopicId = null; //主题Id
if (objRTPaperRelaEN.PaperId == "[null]") objRTPaperRelaEN.PaperId = null; //论文Id
if (objRTPaperRelaEN.UpdDate == "[null]") objRTPaperRelaEN.UpdDate = null; //修改日期
if (objRTPaperRelaEN.UpdUser == "[null]") objRTPaperRelaEN.UpdUser = null; //修改人
if (objRTPaperRelaEN.Memo == "[null]") objRTPaperRelaEN.Memo = null; //备注
if (objRTPaperRelaEN.IdCurrEduCls == "[null]") objRTPaperRelaEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsRTPaperRelaEN objRTPaperRelaEN)
{
 RTPaperRelaDA.CheckPropertyNew(objRTPaperRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRTPaperRelaEN objRTPaperRelaEN)
{
 RTPaperRelaDA.CheckProperty4Condition(objRTPaperRelaEN);
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
if (clsRTPaperRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTPaperRelaBL没有刷新缓存机制(clsRTPaperRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrRTPaperRelaObjLstCache == null)
//{
//arrRTPaperRelaObjLstCache = RTPaperRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTPaperRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsRTPaperRelaEN._CurrTabName);
List<clsRTPaperRelaEN> arrRTPaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsRTPaperRelaEN> arrRTPaperRelaObjLst_Sel =
arrRTPaperRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrRTPaperRelaObjLst_Sel.Count() == 0)
{
   clsRTPaperRelaEN obj = clsRTPaperRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrRTPaperRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTPaperRelaEN> GetAllRTPaperRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsRTPaperRelaEN> arrRTPaperRelaObjLstCache = GetObjLstCache(); 
return arrRTPaperRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTPaperRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsRTPaperRelaEN._CurrTabName);
List<clsRTPaperRelaEN> arrRTPaperRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRTPaperRelaObjLstCache;
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
string strKey = string.Format("{0}", clsRTPaperRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRTPaperRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsRTPaperRelaEN._RefreshTimeLst.Count == 0) return "";
return clsRTPaperRelaEN._RefreshTimeLst[clsRTPaperRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsRTPaperRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRTPaperRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRTPaperRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsRTPaperRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--RTPaperRela(RTPaperRela)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRTPaperRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsRTPaperRelaEN objRTPaperRelaEN)
{
//检测记录是否存在
string strResult = RTPaperRelaDA.GetUniCondStr(objRTPaperRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conRTPaperRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRTPaperRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRTPaperRela.AttributeName));
throw new Exception(strMsg);
}
var objRTPaperRela = clsRTPaperRelaBL.GetObjBymIdCache(lngmId);
if (objRTPaperRela == null) return "";
return objRTPaperRela[strOutFldName].ToString();
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
int intRecCount = clsRTPaperRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsRTPaperRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRTPaperRelaDA.GetRecCount();
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
int intRecCount = clsRTPaperRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRTPaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRTPaperRelaEN objRTPaperRelaCond)
{
List<clsRTPaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRTPaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTPaperRela.AttributeName)
{
if (objRTPaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTPaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTPaperRelaCond[strFldName].ToString());
}
else
{
if (objRTPaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTPaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTPaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTPaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTPaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTPaperRelaCond[strFldName]));
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
 List<string> arrList = clsRTPaperRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RTPaperRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RTPaperRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RTPaperRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTPaperRelaDA.SetFldValue(clsRTPaperRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RTPaperRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTPaperRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTPaperRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTPaperRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[RTPaperRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// RTPaperRela(RTPaperRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4RTPaperRela : clsCommFun4BL
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
clsRTPaperRelaBL.ReFreshThisCache();
}
}

}