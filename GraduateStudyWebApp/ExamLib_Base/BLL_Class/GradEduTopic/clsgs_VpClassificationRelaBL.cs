
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_VpClassificationRelaBL
 表名:gs_VpClassificationRela(01120777)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:22
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
public static class  clsgs_VpClassificationRelaBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_VpClassificationRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!分类Id = [{0}],主题Id = [{1}]的数据已经存在!(in clsgs_VpClassificationRelaBL.AddNewRecord)", objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.AddNewRecordBySQL2(objgs_VpClassificationRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsgs_VpClassificationRelaBL.IsExist(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objgs_VpClassificationRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_VpClassificationRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(分类Id(ClassificationId)=[{0}],主题Id(TopicId)=[{1}])已经存在,不能重复!", objgs_VpClassificationRelaEN.ClassificationId, objgs_VpClassificationRelaEN.TopicId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_VpClassificationRelaEN.AddNewRecord();
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
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_VpClassificationRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!分类Id = [{0}],主题Id = [{1}]的数据已经存在!(in clsgs_VpClassificationRelaBL.AddNewRecordWithReturnKey)", objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.AddNewRecordBySQL2WithReturnKey(objgs_VpClassificationRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationRelaEN SetClassificationId(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, long lngClassificationId, string strComparisonOp="")
	{
objgs_VpClassificationRelaEN.ClassificationId = lngClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationRelaEN.dicFldComparisonOp.ContainsKey(congs_VpClassificationRela.ClassificationId) == false)
{
objgs_VpClassificationRelaEN.dicFldComparisonOp.Add(congs_VpClassificationRela.ClassificationId, strComparisonOp);
}
else
{
objgs_VpClassificationRelaEN.dicFldComparisonOp[congs_VpClassificationRela.ClassificationId] = strComparisonOp;
}
}
return objgs_VpClassificationRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationRelaEN SetTopicId(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_VpClassificationRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_VpClassificationRela.TopicId);
}
objgs_VpClassificationRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationRelaEN.dicFldComparisonOp.ContainsKey(congs_VpClassificationRela.TopicId) == false)
{
objgs_VpClassificationRelaEN.dicFldComparisonOp.Add(congs_VpClassificationRela.TopicId, strComparisonOp);
}
else
{
objgs_VpClassificationRelaEN.dicFldComparisonOp[congs_VpClassificationRela.TopicId] = strComparisonOp;
}
}
return objgs_VpClassificationRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationRelaEN SetOrderNum(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objgs_VpClassificationRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationRelaEN.dicFldComparisonOp.ContainsKey(congs_VpClassificationRela.OrderNum) == false)
{
objgs_VpClassificationRelaEN.dicFldComparisonOp.Add(congs_VpClassificationRela.OrderNum, strComparisonOp);
}
else
{
objgs_VpClassificationRelaEN.dicFldComparisonOp[congs_VpClassificationRela.OrderNum] = strComparisonOp;
}
}
return objgs_VpClassificationRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationRelaEN SetUpdDate(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_VpClassificationRela.UpdDate);
}
objgs_VpClassificationRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationRelaEN.dicFldComparisonOp.ContainsKey(congs_VpClassificationRela.UpdDate) == false)
{
objgs_VpClassificationRelaEN.dicFldComparisonOp.Add(congs_VpClassificationRela.UpdDate, strComparisonOp);
}
else
{
objgs_VpClassificationRelaEN.dicFldComparisonOp[congs_VpClassificationRela.UpdDate] = strComparisonOp;
}
}
return objgs_VpClassificationRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationRelaEN SetUpdUser(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_VpClassificationRela.UpdUser);
}
objgs_VpClassificationRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationRelaEN.dicFldComparisonOp.ContainsKey(congs_VpClassificationRela.UpdUser) == false)
{
objgs_VpClassificationRelaEN.dicFldComparisonOp.Add(congs_VpClassificationRela.UpdUser, strComparisonOp);
}
else
{
objgs_VpClassificationRelaEN.dicFldComparisonOp[congs_VpClassificationRela.UpdUser] = strComparisonOp;
}
}
return objgs_VpClassificationRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_VpClassificationRelaEN SetMemo(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_VpClassificationRela.Memo);
}
objgs_VpClassificationRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_VpClassificationRelaEN.dicFldComparisonOp.ContainsKey(congs_VpClassificationRela.Memo) == false)
{
objgs_VpClassificationRelaEN.dicFldComparisonOp.Add(congs_VpClassificationRela.Memo, strComparisonOp);
}
else
{
objgs_VpClassificationRelaEN.dicFldComparisonOp[congs_VpClassificationRela.Memo] = strComparisonOp;
}
}
return objgs_VpClassificationRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_VpClassificationRelaEN.CheckPropertyNew();
clsgs_VpClassificationRelaEN objgs_VpClassificationRelaCond = new clsgs_VpClassificationRelaEN();
string strCondition = objgs_VpClassificationRelaCond
.SetClassificationId(objgs_VpClassificationRelaEN.ClassificationId, "<>")
.SetClassificationId(objgs_VpClassificationRelaEN.ClassificationId, "=")
.SetTopicId(objgs_VpClassificationRelaEN.TopicId, "=")
.GetCombineCondition();
objgs_VpClassificationRelaEN._IsCheckProperty = true;
bool bolIsExist = clsgs_VpClassificationRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ClassificationId_TopicId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_VpClassificationRelaEN.Update();
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
 /// <param name = "objgs_VpClassificationRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_VpClassificationRelaEN objgs_VpClassificationRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_VpClassificationRelaEN objgs_VpClassificationRelaCond = new clsgs_VpClassificationRelaEN();
string strCondition = objgs_VpClassificationRelaCond
.SetClassificationId(objgs_VpClassificationRela.ClassificationId, "=")
.SetTopicId(objgs_VpClassificationRela.TopicId, "=")
.GetCombineCondition();
objgs_VpClassificationRela._IsCheckProperty = true;
bool bolIsExist = clsgs_VpClassificationRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_VpClassificationRela.ClassificationId = clsgs_VpClassificationRelaBL.GetFirstID_S(strCondition);
objgs_VpClassificationRela.UpdateWithCondition(strCondition);
}
else
{
objgs_VpClassificationRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
 if (objgs_VpClassificationRelaEN.ClassificationId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.UpdateBySql2(objgs_VpClassificationRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_VpClassificationRelaEN.ClassificationId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.UpdateBySql2(objgs_VpClassificationRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.UpdateBySqlWithCondition(objgs_VpClassificationRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.UpdateBySqlWithConditionTransaction(objgs_VpClassificationRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
try
{
int intRecNum = clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.DelRecord(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaENS">源对象</param>
 /// <param name = "objgs_VpClassificationRelaENT">目标对象</param>
 public static void CopyTo(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaENS, clsgs_VpClassificationRelaEN objgs_VpClassificationRelaENT)
{
try
{
objgs_VpClassificationRelaENT.ClassificationId = objgs_VpClassificationRelaENS.ClassificationId; //分类Id
objgs_VpClassificationRelaENT.TopicId = objgs_VpClassificationRelaENS.TopicId; //主题Id
objgs_VpClassificationRelaENT.OrderNum = objgs_VpClassificationRelaENS.OrderNum; //序号
objgs_VpClassificationRelaENT.UpdDate = objgs_VpClassificationRelaENS.UpdDate; //修改日期
objgs_VpClassificationRelaENT.UpdUser = objgs_VpClassificationRelaENS.UpdUser; //修改人
objgs_VpClassificationRelaENT.Memo = objgs_VpClassificationRelaENS.Memo; //备注
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
 /// <param name = "objgs_VpClassificationRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_VpClassificationRelaEN:objgs_VpClassificationRelaENT</returns>
 public static clsgs_VpClassificationRelaEN CopyTo(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaENS)
{
try
{
 clsgs_VpClassificationRelaEN objgs_VpClassificationRelaENT = new clsgs_VpClassificationRelaEN()
{
ClassificationId = objgs_VpClassificationRelaENS.ClassificationId, //分类Id
TopicId = objgs_VpClassificationRelaENS.TopicId, //主题Id
OrderNum = objgs_VpClassificationRelaENS.OrderNum, //序号
UpdDate = objgs_VpClassificationRelaENS.UpdDate, //修改日期
UpdUser = objgs_VpClassificationRelaENS.UpdUser, //修改人
Memo = objgs_VpClassificationRelaENS.Memo, //备注
};
 return objgs_VpClassificationRelaENT;
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
public static void CheckPropertyNew(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
 clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.CheckPropertyNew(objgs_VpClassificationRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
 clsgs_VpClassificationRelaBL.gs_VpClassificationRelaDA.CheckProperty4Condition(objgs_VpClassificationRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_VpClassificationRelaCond.IsUpdated(congs_VpClassificationRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objgs_VpClassificationRelaCond.dicFldComparisonOp[congs_VpClassificationRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_VpClassificationRela.ClassificationId, objgs_VpClassificationRelaCond.ClassificationId, strComparisonOpClassificationId);
}
if (objgs_VpClassificationRelaCond.IsUpdated(congs_VpClassificationRela.TopicId) == true)
{
string strComparisonOpTopicId = objgs_VpClassificationRelaCond.dicFldComparisonOp[congs_VpClassificationRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassificationRela.TopicId, objgs_VpClassificationRelaCond.TopicId, strComparisonOpTopicId);
}
if (objgs_VpClassificationRelaCond.IsUpdated(congs_VpClassificationRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objgs_VpClassificationRelaCond.dicFldComparisonOp[congs_VpClassificationRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_VpClassificationRela.OrderNum, objgs_VpClassificationRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objgs_VpClassificationRelaCond.IsUpdated(congs_VpClassificationRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_VpClassificationRelaCond.dicFldComparisonOp[congs_VpClassificationRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassificationRela.UpdDate, objgs_VpClassificationRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_VpClassificationRelaCond.IsUpdated(congs_VpClassificationRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_VpClassificationRelaCond.dicFldComparisonOp[congs_VpClassificationRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassificationRela.UpdUser, objgs_VpClassificationRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_VpClassificationRelaCond.IsUpdated(congs_VpClassificationRela.Memo) == true)
{
string strComparisonOpMemo = objgs_VpClassificationRelaCond.dicFldComparisonOp[congs_VpClassificationRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_VpClassificationRela.Memo, objgs_VpClassificationRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_VpClassificationRela(观点分类主题关系表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ClassificationId_TopicId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_VpClassificationRelaEN == null) return true;
if (objgs_VpClassificationRelaEN.ClassificationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClassificationId = '{0}'", objgs_VpClassificationRelaEN.ClassificationId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_VpClassificationRelaEN.TopicId);
if (clsgs_VpClassificationRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ClassificationId !=  {0}", objgs_VpClassificationRelaEN.ClassificationId);
 sbCondition.AppendFormat(" and ClassificationId = '{0}'", objgs_VpClassificationRelaEN.ClassificationId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_VpClassificationRelaEN.TopicId);
if (clsgs_VpClassificationRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_VpClassificationRela(观点分类主题关系表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ClassificationId_TopicId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_VpClassificationRelaEN == null) return "";
if (objgs_VpClassificationRelaEN.ClassificationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClassificationId = '{0}'", objgs_VpClassificationRelaEN.ClassificationId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_VpClassificationRelaEN.TopicId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ClassificationId !=  {0}", objgs_VpClassificationRelaEN.ClassificationId);
 sbCondition.AppendFormat(" and ClassificationId = '{0}'", objgs_VpClassificationRelaEN.ClassificationId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_VpClassificationRelaEN.TopicId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_VpClassificationRela
{
public virtual bool UpdRelaTabDate(long lngClassificationId,string strTopicId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 观点分类主题关系表(gs_VpClassificationRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_VpClassificationRelaBL
{
public static RelatedActions_gs_VpClassificationRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_VpClassificationRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_VpClassificationRelaDA gs_VpClassificationRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_VpClassificationRelaDA();
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
 public clsgs_VpClassificationRelaBL()
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
if (string.IsNullOrEmpty(clsgs_VpClassificationRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_VpClassificationRelaEN._ConnectString);
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
public static DataTable GetDataTable_gs_VpClassificationRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_VpClassificationRelaDA.GetDataTable_gs_VpClassificationRela(strWhereCond);
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
objDT = gs_VpClassificationRelaDA.GetDataTable(strWhereCond);
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
objDT = gs_VpClassificationRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_VpClassificationRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_VpClassificationRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_VpClassificationRelaDA.GetDataTable_Top(objTopPara);
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
objDT = gs_VpClassificationRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_VpClassificationRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_VpClassificationRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--gs_VpClassificationRela(观点分类主题关系表)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
//检测记录是否存在
string strResult = "";
strResult += objgs_VpClassificationRelaEN.ClassificationId;
strResult += "|" + objgs_VpClassificationRelaEN.TopicId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_VpClassificationRelaEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsgs_VpClassificationRelaEN._CurrTabName);
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjLst_Sel =
arrgs_VpClassificationRelaObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrgs_VpClassificationRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_VpClassificationRelaEN> GetObjLst(string strWhereCond)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
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
public static List<clsgs_VpClassificationRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_VpClassificationRelaEN> GetSubObjLstCache(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaCond)
{
List<clsgs_VpClassificationRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_VpClassificationRela.AttributeName)
{
if (objgs_VpClassificationRelaCond.IsUpdated(strFldName) == false) continue;
if (objgs_VpClassificationRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationRelaCond[strFldName].ToString());
}
else
{
if (objgs_VpClassificationRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_VpClassificationRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_VpClassificationRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationRelaCond[strFldName]));
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
public static List<clsgs_VpClassificationRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
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
public static List<clsgs_VpClassificationRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
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
List<clsgs_VpClassificationRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_VpClassificationRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_VpClassificationRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_VpClassificationRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
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
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
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
public static List<clsgs_VpClassificationRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_VpClassificationRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_VpClassificationRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
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
public static List<clsgs_VpClassificationRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_VpClassificationRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_VpClassificationRelaEN> arrObjLst = new List<clsgs_VpClassificationRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = new clsgs_VpClassificationRelaEN();
try
{
objgs_VpClassificationRelaEN.ClassificationId = Int32.Parse(objRow[congs_VpClassificationRela.ClassificationId].ToString().Trim()); //分类Id
objgs_VpClassificationRelaEN.TopicId = objRow[congs_VpClassificationRela.TopicId].ToString().Trim(); //主题Id
objgs_VpClassificationRelaEN.OrderNum = objRow[congs_VpClassificationRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_VpClassificationRela.OrderNum].ToString().Trim()); //序号
objgs_VpClassificationRelaEN.UpdDate = objRow[congs_VpClassificationRela.UpdDate] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdDate].ToString().Trim(); //修改日期
objgs_VpClassificationRelaEN.UpdUser = objRow[congs_VpClassificationRela.UpdUser] == DBNull.Value ? null : objRow[congs_VpClassificationRela.UpdUser].ToString().Trim(); //修改人
objgs_VpClassificationRelaEN.Memo = objRow[congs_VpClassificationRela.Memo] == DBNull.Value ? null : objRow[congs_VpClassificationRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_VpClassificationRelaEN.ClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_VpClassificationRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_VpClassificationRela(ref clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
bool bolResult = gs_VpClassificationRelaDA.Getgs_VpClassificationRela(ref objgs_VpClassificationRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngClassificationId">表关键字</param>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_VpClassificationRelaEN GetObjByKeyLst(long lngClassificationId,string strTopicId)
{
if (strTopicId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[lngClassificationId,strTopicId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (lngClassificationId == 0)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[lngClassificationId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strTopicId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = gs_VpClassificationRelaDA.GetObjByKeyLst(lngClassificationId,strTopicId);
return objgs_VpClassificationRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_VpClassificationRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = gs_VpClassificationRelaDA.GetFirstObj(strWhereCond);
 return objgs_VpClassificationRelaEN;
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
public static clsgs_VpClassificationRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = gs_VpClassificationRelaDA.GetObjByDataRow(objRow);
 return objgs_VpClassificationRelaEN;
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
public static clsgs_VpClassificationRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = gs_VpClassificationRelaDA.GetObjByDataRow(objRow);
 return objgs_VpClassificationRelaEN;
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
 /// <param name = "lngClassificationId">表关键字</param>
 /// <param name = "strTopicId">表关键字</param>
 /// <param name = "lstgs_VpClassificationRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_VpClassificationRelaEN GetObjByKeyLstFromList(long lngClassificationId,string strTopicId, List<clsgs_VpClassificationRelaEN> lstgs_VpClassificationRelaObjLst)
{
foreach (clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN in lstgs_VpClassificationRelaObjLst)
{
if (objgs_VpClassificationRelaEN.ClassificationId == lngClassificationId 
 && objgs_VpClassificationRelaEN.TopicId == strTopicId 
)
{
return objgs_VpClassificationRelaEN;
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
 long lngClassificationId;
 try
 {
 lngClassificationId = new clsgs_VpClassificationRelaDA().GetFirstID(strWhereCond);
 return lngClassificationId;
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
 arrList = gs_VpClassificationRelaDA.GetID(strWhereCond);
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
bool bolIsExist = gs_VpClassificationRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngClassificationId,string strTopicId)
{
//检测记录是否存在
bool bolIsExist = gs_VpClassificationRelaDA.IsExist(lngClassificationId,strTopicId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngClassificationId">分类Id</param>
/// <param name = "strTopicId">主题Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngClassificationId , string strTopicId, string strOpUser)
{
clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = clsgs_VpClassificationRelaBL.GetObjByKeyLst(lngClassificationId,strTopicId);
objgs_VpClassificationRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objgs_VpClassificationRelaEN.UpdUser = strOpUser;
return clsgs_VpClassificationRelaBL.UpdateBySql2(objgs_VpClassificationRelaEN);
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
 bolIsExist = clsgs_VpClassificationRelaDA.IsExistTable();
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
 bolIsExist = gs_VpClassificationRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_VpClassificationRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类Id = [{0}],主题Id = [{1}]的数据已经存在!(in clsgs_VpClassificationRelaBL.AddNewRecordBySql2)", objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_VpClassificationRelaDA.AddNewRecordBySQL2(objgs_VpClassificationRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_VpClassificationRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类Id = [{0}],主题Id = [{1}]的数据已经存在!(in clsgs_VpClassificationRelaBL.AddNewRecordBySql2WithReturnKey)", objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_VpClassificationRelaDA.AddNewRecordBySQL2WithReturnKey(objgs_VpClassificationRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
try
{
bool bolResult = gs_VpClassificationRelaDA.Update(objgs_VpClassificationRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "objgs_VpClassificationRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
 if (objgs_VpClassificationRelaEN.ClassificationId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_VpClassificationRelaDA.UpdateBySql2(objgs_VpClassificationRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_VpClassificationRelaBL.ReFreshCache();

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
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
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngClassificationId,string strTopicId)
{
try
{
 clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN = clsgs_VpClassificationRelaBL.GetObjByKeyLst(lngClassificationId,strTopicId);

if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(objgs_VpClassificationRelaEN.ClassificationId,objgs_VpClassificationRelaEN.TopicId, objgs_VpClassificationRelaEN.UpdUser);
}
if (objgs_VpClassificationRelaEN != null)
{
int intRecNum = gs_VpClassificationRelaDA.DelRecord(lngClassificationId,strTopicId);
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
/// <param name="lngClassificationId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngClassificationId,string strTopicId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_VpClassificationRelaDA.GetSpecSQLObj();
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
//删除与表:[gs_VpClassificationRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_VpClassificationRela.ClassificationId,
//lngClassificationId);
//        clsgs_VpClassificationRelaBL.Delgs_VpClassificationRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_VpClassificationRelaBL.DelRecord(lngClassificationId,strTopicId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_VpClassificationRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngClassificationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngClassificationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngClassificationId,string strTopicId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(lngClassificationId,strTopicId, "UpdRelaTabDate");
}
bool bolResult = gs_VpClassificationRelaDA.DelRecord(lngClassificationId,strTopicId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrClassificationIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
long lngClassificationId;
string strTopicId;
if (clsgs_VpClassificationRelaBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
lngClassificationId = long.Parse(sstrKey[0]);
strTopicId = sstrKey[1];
clsgs_VpClassificationRelaBL.relatedActions.UpdRelaTabDate(lngClassificationId,strTopicId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
lngClassificationId = long.Parse(sstrKey[0]);
strTopicId = sstrKey[1];
int intDelRecNum = gs_VpClassificationRelaDA.DelRecKeyLsts(arrKeyLsts);
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
public static int Delgs_VpClassificationRelasByCond(string strWhereCond)
{
try
{
int intRecNum = gs_VpClassificationRelaDA.Delgs_VpClassificationRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_VpClassificationRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngClassificationId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngClassificationId,string strTopicId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_VpClassificationRelaDA.GetSpecSQLObj();
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
//删除与表:[gs_VpClassificationRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_VpClassificationRelaBL.DelRecord(lngClassificationId,strTopicId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_VpClassificationRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngClassificationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_VpClassificationRelaENS">源对象</param>
 /// <param name = "objgs_VpClassificationRelaENT">目标对象</param>
 public static void CopyTo(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaENS, clsgs_VpClassificationRelaEN objgs_VpClassificationRelaENT)
{
try
{
objgs_VpClassificationRelaENT.ClassificationId = objgs_VpClassificationRelaENS.ClassificationId; //分类Id
objgs_VpClassificationRelaENT.TopicId = objgs_VpClassificationRelaENS.TopicId; //主题Id
objgs_VpClassificationRelaENT.OrderNum = objgs_VpClassificationRelaENS.OrderNum; //序号
objgs_VpClassificationRelaENT.UpdDate = objgs_VpClassificationRelaENS.UpdDate; //修改日期
objgs_VpClassificationRelaENT.UpdUser = objgs_VpClassificationRelaENS.UpdUser; //修改人
objgs_VpClassificationRelaENT.Memo = objgs_VpClassificationRelaENS.Memo; //备注
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
 /// <param name = "objgs_VpClassificationRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
try
{
objgs_VpClassificationRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_VpClassificationRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_VpClassificationRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationRelaEN.ClassificationId = objgs_VpClassificationRelaEN.ClassificationId; //分类Id
}
if (arrFldSet.Contains(congs_VpClassificationRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationRelaEN.TopicId = objgs_VpClassificationRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_VpClassificationRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationRelaEN.OrderNum = objgs_VpClassificationRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(congs_VpClassificationRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationRelaEN.UpdDate = objgs_VpClassificationRelaEN.UpdDate == "[null]" ? null :  objgs_VpClassificationRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_VpClassificationRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationRelaEN.UpdUser = objgs_VpClassificationRelaEN.UpdUser == "[null]" ? null :  objgs_VpClassificationRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_VpClassificationRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_VpClassificationRelaEN.Memo = objgs_VpClassificationRelaEN.Memo == "[null]" ? null :  objgs_VpClassificationRelaEN.Memo; //备注
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
 /// <param name = "objgs_VpClassificationRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
try
{
if (objgs_VpClassificationRelaEN.UpdDate == "[null]") objgs_VpClassificationRelaEN.UpdDate = null; //修改日期
if (objgs_VpClassificationRelaEN.UpdUser == "[null]") objgs_VpClassificationRelaEN.UpdUser = null; //修改人
if (objgs_VpClassificationRelaEN.Memo == "[null]") objgs_VpClassificationRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
 gs_VpClassificationRelaDA.CheckPropertyNew(objgs_VpClassificationRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
 gs_VpClassificationRelaDA.CheckProperty4Condition(objgs_VpClassificationRelaEN);
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
if (clsgs_VpClassificationRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_VpClassificationRelaBL没有刷新缓存机制(clsgs_VpClassificationRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClassificationId");
//if (arrgs_VpClassificationRelaObjLstCache == null)
//{
//arrgs_VpClassificationRelaObjLstCache = gs_VpClassificationRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngClassificationId">表关键字</param>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_VpClassificationRelaEN GetObjByKeyLstCache(long lngClassificationId,string strTopicId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_VpClassificationRelaEN._CurrTabName);
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjLst_Sel =
arrgs_VpClassificationRelaObjLstCache
.Where(x=> x.ClassificationId == lngClassificationId 
 && x.TopicId == strTopicId 
);
if (arrgs_VpClassificationRelaObjLst_Sel.Count() == 0)
{
   clsgs_VpClassificationRelaEN obj = clsgs_VpClassificationRelaBL.GetObjByKeyLst(lngClassificationId,strTopicId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_VpClassificationRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_VpClassificationRelaEN> GetAllgs_VpClassificationRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjLstCache = GetObjLstCache(); 
return arrgs_VpClassificationRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_VpClassificationRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_VpClassificationRelaEN._CurrTabName);
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_VpClassificationRelaObjLstCache;
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
string strKey = string.Format("{0}", clsgs_VpClassificationRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_VpClassificationRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_VpClassificationRelaEN._RefreshTimeLst.Count == 0) return "";
return clsgs_VpClassificationRelaEN._RefreshTimeLst[clsgs_VpClassificationRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_VpClassificationRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_VpClassificationRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_VpClassificationRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_VpClassificationRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_VpClassificationRela(观点分类主题关系表)
 /// 唯一性条件:ClassificationId_TopicId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaEN)
{
//检测记录是否存在
string strResult = gs_VpClassificationRelaDA.GetUniCondStr(objgs_VpClassificationRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngClassificationId,string strTopicId)
{
if (strInFldName != congs_VpClassificationRela.ClassificationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_VpClassificationRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_VpClassificationRela.AttributeName));
throw new Exception(strMsg);
}
var objgs_VpClassificationRela = clsgs_VpClassificationRelaBL.GetObjByKeyLstCache(lngClassificationId,strTopicId);
if (objgs_VpClassificationRela == null) return "";
return objgs_VpClassificationRela[strOutFldName].ToString();
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
int intRecCount = clsgs_VpClassificationRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_VpClassificationRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_VpClassificationRelaDA.GetRecCount();
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
int intRecCount = clsgs_VpClassificationRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_VpClassificationRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_VpClassificationRelaEN objgs_VpClassificationRelaCond)
{
List<clsgs_VpClassificationRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_VpClassificationRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_VpClassificationRela.AttributeName)
{
if (objgs_VpClassificationRelaCond.IsUpdated(strFldName) == false) continue;
if (objgs_VpClassificationRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationRelaCond[strFldName].ToString());
}
else
{
if (objgs_VpClassificationRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_VpClassificationRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_VpClassificationRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_VpClassificationRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_VpClassificationRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_VpClassificationRelaCond[strFldName]));
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
 List<string> arrList = clsgs_VpClassificationRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_VpClassificationRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_VpClassificationRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_VpClassificationRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationRelaDA.SetFldValue(clsgs_VpClassificationRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_VpClassificationRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_VpClassificationRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_VpClassificationRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**分类Id*/ 
 strCreateTabCode.Append(" ClassificationId bigint primary key, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) primary key, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**分类名称*/ 
 strCreateTabCode.Append(" ClassificationName varchar(200) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
 // /**栏目主题*/ 
 strCreateTabCode.Append(" TopicName varchar(200) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：TopicId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strTopicId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strTopicId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", congs_VpClassificationRela.TopicId, strTopicId);
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjList = new clsgs_VpClassificationRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_VpClassificationRelaEN objgs_VpClassificationRela in arrgs_VpClassificationRelaObjList)
{
objgs_VpClassificationRela.OrderNum = intIndex;
UpdateBySql2(objgs_VpClassificationRela);
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
		/// 调整所给关键字记录的序号。根据分类字段：TopicId单独排序
		/// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
		/// </summary>
		/// <param name="strDirect">方向：用"Up","Down"表示</param>
		/// <param name="lngClassificationId">所给的关键字</param>
		/// <param name="strTopicId">分类字段</param>
		/// <returns>是否成功?</returns>
		public static bool AdjustOrderNum(string strDirect, long lngClassificationId, string strTopicId)
		{
			try
			{
				//操作步骤：
				//1、根据所给定的关键字[ClassificationId],获取相应的序号[OrderNum]；
				//2、如果当前序号是否是末端序号；
				//3、如果是末端序号,就退出；
				//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
				//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
				//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
				//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
				//4、获取下(上)一个序号记录的关键字ClassificationId
				//5、把当前关键字ClassificationId所对应记录的序号加(减)1
				//6、把下(上)一个序号关键字ClassificationId所对应的记录序号减(加)1
				string strMsg;
				int intOrderNum;    //当前记录的序号
				int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
				long lngPrevClassificationId = 0;    //上一条序号的关键字ClassificationId
				long lngNextClassificationId = 0;    //下一条序号的关键字ClassificationId
				int intTabRecNum;       //当前表中字段的记录数
				StringBuilder sbCondition = new StringBuilder();
				//1、根据所给定的关键字[ClassificationId],获取相应的序号[OrderNum]。

				clsgs_VpClassificationRelaEN objgs_VpClassificationRela = clsgs_VpClassificationRelaBL.GetObjByKeyLst(lngClassificationId,strTopicId);

				intOrderNum = objgs_VpClassificationRela.OrderNum ?? 0;//当前序号
				intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
				intNextOrderNum = intOrderNum + 1;//后一条记录的序号
												  //3、如果当前序号是否是末端序号,
												  //		3.1 如果是末端序号,就退出,

				string strCondition = " 1=1 ";
				strCondition += string.Format(" And {0} = '{1}' ", congs_VpClassificationRela.TopicId, strTopicId);
				intTabRecNum = clsgs_VpClassificationRelaBL.GetRecCountByCond(clsgs_VpClassificationRelaEN._CurrTabName, strCondition);    //获取当前表的记录数
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
						sbCondition.AppendFormat(" {0} = {1} ", congs_VpClassificationRela.OrderNum, intOrderNum - 1);
						sbCondition.AppendFormat(" And {0} = '{1}' ", congs_VpClassificationRela.TopicId, strTopicId);
						//4、获取上一个序号字段的关键字ClassificationId
						lngPrevClassificationId = clsgs_VpClassificationRelaBL.GetFirstID_S(sbCondition.ToString());
						if (lngPrevClassificationId == 0)
						{
							strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
							throw new Exception(strMsg);
						}
						//5、把当前关键字ClassificationId所对应记录的序号减1
						//6、把下(上)一个序号关键字ClassificationId所对应的记录序号加1
						clsgs_VpClassificationRelaBL.SetFldValue(clsgs_VpClassificationRelaEN._CurrTabName, congs_VpClassificationRela.OrderNum,
								  intOrderNum - 1,
								   string.Format("{0} = '{1}'", congs_VpClassificationRela.ClassificationId, lngClassificationId));
						clsgs_VpClassificationRelaBL.SetFldValue(clsgs_VpClassificationRelaEN._CurrTabName, congs_VpClassificationRela.OrderNum,
								  intPrevOrderNum + 1,
								  string.Format("{0} = '{1}'", congs_VpClassificationRela.ClassificationId, lngPrevClassificationId));
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

						//4、获取下一个序号字段的关键字ClassificationId
						sbCondition.AppendFormat(" {0} = {1} ", congs_VpClassificationRela.OrderNum, intOrderNum + 1);
						sbCondition.AppendFormat(" And {0} = '{1}' ", congs_VpClassificationRela.TopicId, strTopicId);

						lngNextClassificationId = clsgs_VpClassificationRelaBL.GetFirstID_S(sbCondition.ToString());
						if (lngNextClassificationId == 0)
						{
							strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

							throw new Exception(strMsg);
						}
						//5、把当前关键字ClassificationId所对应记录的序号加1
						//6、把下(上)一个序号关键字ClassificationId所对应的记录序号减1
						clsgs_VpClassificationRelaBL.SetFldValue(clsgs_VpClassificationRelaEN._CurrTabName, congs_VpClassificationRela.OrderNum,
								  intOrderNum + 1,
								  string.Format("{0} = '{1}'", congs_VpClassificationRela.ClassificationId, lngClassificationId));
						clsgs_VpClassificationRelaBL.SetFldValue(clsgs_VpClassificationRelaEN._CurrTabName, congs_VpClassificationRela.OrderNum,
								  intNextOrderNum - 1,
								  string.Format("{0} = '{1}'", congs_VpClassificationRela.ClassificationId, lngNextClassificationId));
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
		/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TopicId单独排序
		/// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
		/// </summary>
		/// <param name="arrKeyId">所给的关键字列表</param>
		/// <returns></returns>
		public static bool GoBottom(List<long> arrKeyId ,string strTopicId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", congs_VpClassificationRela.ClassificationId, strKeyList);
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaLst = GetObjLst(strCondition);
foreach (clsgs_VpClassificationRelaEN objgs_VpClassificationRela in arrgs_VpClassificationRelaLst)
{
objgs_VpClassificationRela.OrderNum = objgs_VpClassificationRela.OrderNum + 10000;
UpdateBySql2(objgs_VpClassificationRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", congs_VpClassificationRela.TopicId, strTopicId);
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjList = new clsgs_VpClassificationRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_VpClassificationRelaEN objgs_VpClassificationRela in arrgs_VpClassificationRelaObjList)
{
objgs_VpClassificationRela.OrderNum = intIndex;
UpdateBySql2(objgs_VpClassificationRela);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TopicId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strTopicId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strTopicId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", congs_VpClassificationRela.ClassificationId, strKeyList);
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaLst = GetObjLst(strCondition);
foreach (clsgs_VpClassificationRelaEN objgs_VpClassificationRela in arrgs_VpClassificationRelaLst)
{
objgs_VpClassificationRela.OrderNum = objgs_VpClassificationRela.OrderNum - 10000;
UpdateBySql2(objgs_VpClassificationRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", congs_VpClassificationRela.TopicId, strTopicId);
 strCondition += string.Format(" order by OrderNum ");
List<clsgs_VpClassificationRelaEN> arrgs_VpClassificationRelaObjList = new clsgs_VpClassificationRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsgs_VpClassificationRelaEN objgs_VpClassificationRela in arrgs_VpClassificationRelaObjList)
{
objgs_VpClassificationRela.OrderNum = intIndex;
UpdateBySql2(objgs_VpClassificationRela);
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
 /// 观点分类主题关系表(gs_VpClassificationRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_VpClassificationRela : clsCommFun4BL
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
clsgs_VpClassificationRelaBL.ReFreshThisCache();
}
}

}