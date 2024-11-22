
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTConceptRelaBL
 表名:RTConceptRela(01120605)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:36
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
public static class  clsRTConceptRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTConceptRelaEN GetObj(this K_mId_RTConceptRela myKey)
{
clsRTConceptRelaEN objRTConceptRelaEN = clsRTConceptRelaBL.RTConceptRelaDA.GetObjBymId(myKey.Value);
return objRTConceptRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRTConceptRelaEN objRTConceptRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTConceptRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],主题Id = [{1}],概念Id = [{2}]的数据已经存在!(in clsRTConceptRelaBL.AddNewRecord)", objRTConceptRelaEN.mId,objRTConceptRelaEN.TopicId,objRTConceptRelaEN.ConceptId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsRTConceptRelaBL.RTConceptRelaDA.AddNewRecordBySQL2(objRTConceptRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsRTConceptRelaEN objRTConceptRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objRTConceptRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objRTConceptRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}],主题Id(TopicId)=[{1}],概念Id(ConceptId)=[{2}])已经存在,不能重复!", objRTConceptRelaEN.mId, objRTConceptRelaEN.TopicId, objRTConceptRelaEN.ConceptId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objRTConceptRelaEN.AddNewRecord();
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
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRTConceptRelaEN objRTConceptRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTConceptRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],主题Id = [{1}],概念Id = [{2}]的数据已经存在!(in clsRTConceptRelaBL.AddNewRecordWithReturnKey)", objRTConceptRelaEN.mId,objRTConceptRelaEN.TopicId,objRTConceptRelaEN.ConceptId);
throw new Exception(strMsg);
}
try
{
string strKey = clsRTConceptRelaBL.RTConceptRelaDA.AddNewRecordBySQL2WithReturnKey(objRTConceptRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetmId(this clsRTConceptRelaEN objRTConceptRelaEN, long lngmId, string strComparisonOp="")
	{
objRTConceptRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.mId) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.mId, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.mId] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetTopicId(this clsRTConceptRelaEN objRTConceptRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conRTConceptRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conRTConceptRela.TopicId);
}
objRTConceptRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.TopicId) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.TopicId, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.TopicId] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetConceptId(this clsRTConceptRelaEN objRTConceptRelaEN, string strConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConceptId, conRTConceptRela.ConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, conRTConceptRela.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, conRTConceptRela.ConceptId);
}
objRTConceptRelaEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.ConceptId) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.ConceptId, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.ConceptId] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetUpdDate(this clsRTConceptRelaEN objRTConceptRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conRTConceptRela.UpdDate);
}
objRTConceptRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.UpdDate) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.UpdDate, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.UpdDate] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetMemo(this clsRTConceptRelaEN objRTConceptRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRTConceptRela.Memo);
}
objRTConceptRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.Memo) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.Memo, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.Memo] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetUpdUser(this clsRTConceptRelaEN objRTConceptRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conRTConceptRela.UpdUser);
}
objRTConceptRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.UpdUser) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.UpdUser, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.UpdUser] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetClassificationId(this clsRTConceptRelaEN objRTConceptRelaEN, long? lngClassificationId, string strComparisonOp="")
	{
objRTConceptRelaEN.ClassificationId = lngClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.ClassificationId) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.ClassificationId, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.ClassificationId] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTConceptRelaEN SetIdCurrEduCls(this clsRTConceptRelaEN objRTConceptRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conRTConceptRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conRTConceptRela.IdCurrEduCls);
}
objRTConceptRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTConceptRelaEN.dicFldComparisonOp.ContainsKey(conRTConceptRela.IdCurrEduCls) == false)
{
objRTConceptRelaEN.dicFldComparisonOp.Add(conRTConceptRela.IdCurrEduCls, strComparisonOp);
}
else
{
objRTConceptRelaEN.dicFldComparisonOp[conRTConceptRela.IdCurrEduCls] = strComparisonOp;
}
}
return objRTConceptRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRTConceptRelaEN objRTConceptRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRTConceptRelaEN.CheckPropertyNew();
clsRTConceptRelaEN objRTConceptRelaCond = new clsRTConceptRelaEN();
string strCondition = objRTConceptRelaCond
.SetmId(objRTConceptRelaEN.mId, "<>")
.SetmId(objRTConceptRelaEN.mId, "=")
.SetTopicId(objRTConceptRelaEN.TopicId, "=")
.SetConceptId(objRTConceptRelaEN.ConceptId, "=")
.GetCombineCondition();
objRTConceptRelaEN._IsCheckProperty = true;
bool bolIsExist = clsRTConceptRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId_TopicId_ConceptId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRTConceptRelaEN.Update();
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
 /// <param name = "objRTConceptRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsRTConceptRelaEN objRTConceptRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsRTConceptRelaEN objRTConceptRelaCond = new clsRTConceptRelaEN();
string strCondition = objRTConceptRelaCond
.SetmId(objRTConceptRela.mId, "=")
.SetTopicId(objRTConceptRela.TopicId, "=")
.SetConceptId(objRTConceptRela.ConceptId, "=")
.GetCombineCondition();
objRTConceptRela._IsCheckProperty = true;
bool bolIsExist = clsRTConceptRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objRTConceptRela.mId = clsRTConceptRelaBL.GetFirstID_S(strCondition);
objRTConceptRela.UpdateWithCondition(strCondition);
}
else
{
objRTConceptRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTConceptRelaEN objRTConceptRelaEN)
{
 if (objRTConceptRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTConceptRelaBL.RTConceptRelaDA.UpdateBySql2(objRTConceptRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTConceptRelaEN objRTConceptRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRTConceptRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTConceptRelaBL.RTConceptRelaDA.UpdateBySql2(objRTConceptRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTConceptRelaEN objRTConceptRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsRTConceptRelaBL.RTConceptRelaDA.UpdateBySqlWithCondition(objRTConceptRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTConceptRelaEN objRTConceptRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRTConceptRelaBL.RTConceptRelaDA.UpdateBySqlWithConditionTransaction(objRTConceptRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
public static int Delete(this clsRTConceptRelaEN objRTConceptRelaEN)
{
try
{
int intRecNum = clsRTConceptRelaBL.RTConceptRelaDA.DelRecord(objRTConceptRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaENS">源对象</param>
 /// <param name = "objRTConceptRelaENT">目标对象</param>
 public static void CopyTo(this clsRTConceptRelaEN objRTConceptRelaENS, clsRTConceptRelaEN objRTConceptRelaENT)
{
try
{
objRTConceptRelaENT.mId = objRTConceptRelaENS.mId; //mId
objRTConceptRelaENT.TopicId = objRTConceptRelaENS.TopicId; //主题Id
objRTConceptRelaENT.ConceptId = objRTConceptRelaENS.ConceptId; //概念Id
objRTConceptRelaENT.UpdDate = objRTConceptRelaENS.UpdDate; //修改日期
objRTConceptRelaENT.Memo = objRTConceptRelaENS.Memo; //备注
objRTConceptRelaENT.UpdUser = objRTConceptRelaENS.UpdUser; //修改人
objRTConceptRelaENT.ClassificationId = objRTConceptRelaENS.ClassificationId; //分类Id
objRTConceptRelaENT.IdCurrEduCls = objRTConceptRelaENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTConceptRelaENS">源对象</param>
 /// <returns>目标对象=>clsRTConceptRelaEN:objRTConceptRelaENT</returns>
 public static clsRTConceptRelaEN CopyTo(this clsRTConceptRelaEN objRTConceptRelaENS)
{
try
{
 clsRTConceptRelaEN objRTConceptRelaENT = new clsRTConceptRelaEN()
{
mId = objRTConceptRelaENS.mId, //mId
TopicId = objRTConceptRelaENS.TopicId, //主题Id
ConceptId = objRTConceptRelaENS.ConceptId, //概念Id
UpdDate = objRTConceptRelaENS.UpdDate, //修改日期
Memo = objRTConceptRelaENS.Memo, //备注
UpdUser = objRTConceptRelaENS.UpdUser, //修改人
ClassificationId = objRTConceptRelaENS.ClassificationId, //分类Id
IdCurrEduCls = objRTConceptRelaENS.IdCurrEduCls, //教学班流水号
};
 return objRTConceptRelaENT;
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
public static void CheckPropertyNew(this clsRTConceptRelaEN objRTConceptRelaEN)
{
 clsRTConceptRelaBL.RTConceptRelaDA.CheckPropertyNew(objRTConceptRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRTConceptRelaEN objRTConceptRelaEN)
{
 clsRTConceptRelaBL.RTConceptRelaDA.CheckProperty4Condition(objRTConceptRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRTConceptRelaEN objRTConceptRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.mId) == true)
{
string strComparisonOpmId = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conRTConceptRela.mId, objRTConceptRelaCond.mId, strComparisonOpmId);
}
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.TopicId) == true)
{
string strComparisonOpTopicId = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTConceptRela.TopicId, objRTConceptRelaCond.TopicId, strComparisonOpTopicId);
}
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.ConceptId) == true)
{
string strComparisonOpConceptId = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTConceptRela.ConceptId, objRTConceptRelaCond.ConceptId, strComparisonOpConceptId);
}
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTConceptRela.UpdDate, objRTConceptRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.Memo) == true)
{
string strComparisonOpMemo = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTConceptRela.Memo, objRTConceptRelaCond.Memo, strComparisonOpMemo);
}
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTConceptRela.UpdUser, objRTConceptRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} {1}", conRTConceptRela.ClassificationId, objRTConceptRelaCond.ClassificationId, strComparisonOpClassificationId);
}
if (objRTConceptRelaCond.IsUpdated(conRTConceptRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objRTConceptRelaCond.dicFldComparisonOp[conRTConceptRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTConceptRela.IdCurrEduCls, objRTConceptRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--RTConceptRela(主题概念关系表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId_TopicId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsRTConceptRelaEN objRTConceptRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objRTConceptRelaEN == null) return true;
if (objRTConceptRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objRTConceptRelaEN.mId);
 if (objRTConceptRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objRTConceptRelaEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTConceptRelaEN.TopicId);
}
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objRTConceptRelaEN.ConceptId);
if (clsRTConceptRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTConceptRelaEN.TopicId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objRTConceptRelaEN.ConceptId);
if (clsRTConceptRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--RTConceptRela(主题概念关系表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId_TopicId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsRTConceptRelaEN objRTConceptRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objRTConceptRelaEN == null) return "";
if (objRTConceptRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objRTConceptRelaEN.mId);
 if (objRTConceptRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objRTConceptRelaEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTConceptRelaEN.TopicId);
}
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objRTConceptRelaEN.ConceptId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTConceptRelaEN.TopicId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objRTConceptRelaEN.ConceptId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_RTConceptRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题概念关系表(RTConceptRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRTConceptRelaBL
{
public static RelatedActions_RTConceptRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRTConceptRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRTConceptRelaDA RTConceptRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRTConceptRelaDA();
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
 public clsRTConceptRelaBL()
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
if (string.IsNullOrEmpty(clsRTConceptRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRTConceptRelaEN._ConnectString);
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
public static DataTable GetDataTable_RTConceptRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RTConceptRelaDA.GetDataTable_RTConceptRela(strWhereCond);
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
objDT = RTConceptRelaDA.GetDataTable(strWhereCond);
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
objDT = RTConceptRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RTConceptRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RTConceptRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RTConceptRelaDA.GetDataTable_Top(objTopPara);
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
objDT = RTConceptRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = RTConceptRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RTConceptRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsRTConceptRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
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
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRTConceptRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsRTConceptRelaEN._CurrTabName);
List<clsRTConceptRelaEN> arrRTConceptRelaObjLstCache = GetObjLstCache();
IEnumerable <clsRTConceptRelaEN> arrRTConceptRelaObjLst_Sel =
arrRTConceptRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrRTConceptRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTConceptRelaEN> GetObjLst(string strWhereCond)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
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
public static List<clsRTConceptRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRTConceptRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRTConceptRelaEN> GetSubObjLstCache(clsRTConceptRelaEN objRTConceptRelaCond)
{
List<clsRTConceptRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRTConceptRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTConceptRela.AttributeName)
{
if (objRTConceptRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTConceptRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTConceptRelaCond[strFldName].ToString());
}
else
{
if (objRTConceptRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTConceptRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTConceptRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTConceptRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTConceptRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTConceptRelaCond[strFldName]));
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
public static List<clsRTConceptRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
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
public static List<clsRTConceptRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
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
List<clsRTConceptRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRTConceptRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTConceptRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRTConceptRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
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
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
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
public static List<clsRTConceptRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRTConceptRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRTConceptRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
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
public static List<clsRTConceptRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTConceptRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRTConceptRelaEN> arrObjLst = new List<clsRTConceptRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTConceptRelaEN objRTConceptRelaEN = new clsRTConceptRelaEN();
try
{
objRTConceptRelaEN.mId = Int32.Parse(objRow[conRTConceptRela.mId].ToString().Trim()); //mId
objRTConceptRelaEN.TopicId = objRow[conRTConceptRela.TopicId] == DBNull.Value ? null : objRow[conRTConceptRela.TopicId].ToString().Trim(); //主题Id
objRTConceptRelaEN.ConceptId = objRow[conRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objRTConceptRelaEN.UpdDate = objRow[conRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[conRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objRTConceptRelaEN.Memo = objRow[conRTConceptRela.Memo] == DBNull.Value ? null : objRow[conRTConceptRela.Memo].ToString().Trim(); //备注
objRTConceptRelaEN.UpdUser = objRow[conRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[conRTConceptRela.UpdUser].ToString().Trim(); //修改人
objRTConceptRelaEN.ClassificationId = objRow[conRTConceptRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTConceptRela.ClassificationId].ToString().Trim()); //分类Id
objRTConceptRelaEN.IdCurrEduCls = objRow[conRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTConceptRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRTConceptRela(ref clsRTConceptRelaEN objRTConceptRelaEN)
{
bool bolResult = RTConceptRelaDA.GetRTConceptRela(ref objRTConceptRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTConceptRelaEN GetObjBymId(long lngmId)
{
clsRTConceptRelaEN objRTConceptRelaEN = RTConceptRelaDA.GetObjBymId(lngmId);
return objRTConceptRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRTConceptRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRTConceptRelaEN objRTConceptRelaEN = RTConceptRelaDA.GetFirstObj(strWhereCond);
 return objRTConceptRelaEN;
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
public static clsRTConceptRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRTConceptRelaEN objRTConceptRelaEN = RTConceptRelaDA.GetObjByDataRow(objRow);
 return objRTConceptRelaEN;
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
public static clsRTConceptRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRTConceptRelaEN objRTConceptRelaEN = RTConceptRelaDA.GetObjByDataRow(objRow);
 return objRTConceptRelaEN;
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
 /// <param name = "lstRTConceptRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTConceptRelaEN GetObjBymIdFromList(long lngmId, List<clsRTConceptRelaEN> lstRTConceptRelaObjLst)
{
foreach (clsRTConceptRelaEN objRTConceptRelaEN in lstRTConceptRelaObjLst)
{
if (objRTConceptRelaEN.mId == lngmId)
{
return objRTConceptRelaEN;
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
 lngmId = new clsRTConceptRelaDA().GetFirstID(strWhereCond);
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
 arrList = RTConceptRelaDA.GetID(strWhereCond);
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
bool bolIsExist = RTConceptRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = RTConceptRelaDA.IsExist(lngmId);
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
clsRTConceptRelaEN objRTConceptRelaEN = clsRTConceptRelaBL.GetObjBymId(lngmId);
objRTConceptRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsRTConceptRelaBL.UpdateBySql2(objRTConceptRelaEN);
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
 bolIsExist = clsRTConceptRelaDA.IsExistTable();
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
 bolIsExist = RTConceptRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRTConceptRelaEN objRTConceptRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTConceptRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],主题Id = [{1}],概念Id = [{2}]的数据已经存在!(in clsRTConceptRelaBL.AddNewRecordBySql2)", objRTConceptRelaEN.mId,objRTConceptRelaEN.TopicId,objRTConceptRelaEN.ConceptId);
throw new Exception(strMsg);
}
try
{
bool bolResult = RTConceptRelaDA.AddNewRecordBySQL2(objRTConceptRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRTConceptRelaEN objRTConceptRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTConceptRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],主题Id = [{1}],概念Id = [{2}]的数据已经存在!(in clsRTConceptRelaBL.AddNewRecordBySql2WithReturnKey)", objRTConceptRelaEN.mId,objRTConceptRelaEN.TopicId,objRTConceptRelaEN.ConceptId);
throw new Exception(strMsg);
}
try
{
string strKey = RTConceptRelaDA.AddNewRecordBySQL2WithReturnKey(objRTConceptRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRTConceptRelaEN objRTConceptRelaEN)
{
try
{
bool bolResult = RTConceptRelaDA.Update(objRTConceptRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTConceptRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRTConceptRelaEN objRTConceptRelaEN)
{
 if (objRTConceptRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RTConceptRelaDA.UpdateBySql2(objRTConceptRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTConceptRelaBL.ReFreshCache();

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
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
 clsRTConceptRelaEN objRTConceptRelaEN = clsRTConceptRelaBL.GetObjBymId(lngmId);

if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(objRTConceptRelaEN.mId, "SetUpdDate");
}
if (objRTConceptRelaEN != null)
{
int intRecNum = RTConceptRelaDA.DelRecord(lngmId);
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
objSQL = clsRTConceptRelaDA.GetSpecSQLObj();
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
//删除与表:[RTConceptRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRTConceptRela.mId,
//lngmId);
//        clsRTConceptRelaBL.DelRTConceptRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTConceptRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTConceptRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsRTConceptRelaBL.relatedActions != null)
{
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = RTConceptRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelRTConceptRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsRTConceptRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = RTConceptRelaDA.DelRTConceptRela(arrmIdLst);
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
public static int DelRTConceptRelasByCond(string strWhereCond)
{
try
{
if (clsRTConceptRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsRTConceptRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = RTConceptRelaDA.DelRTConceptRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[RTConceptRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRTConceptRelaDA.GetSpecSQLObj();
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
//删除与表:[RTConceptRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTConceptRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTConceptRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objRTConceptRelaENS">源对象</param>
 /// <param name = "objRTConceptRelaENT">目标对象</param>
 public static void CopyTo(clsRTConceptRelaEN objRTConceptRelaENS, clsRTConceptRelaEN objRTConceptRelaENT)
{
try
{
objRTConceptRelaENT.mId = objRTConceptRelaENS.mId; //mId
objRTConceptRelaENT.TopicId = objRTConceptRelaENS.TopicId; //主题Id
objRTConceptRelaENT.ConceptId = objRTConceptRelaENS.ConceptId; //概念Id
objRTConceptRelaENT.UpdDate = objRTConceptRelaENS.UpdDate; //修改日期
objRTConceptRelaENT.Memo = objRTConceptRelaENS.Memo; //备注
objRTConceptRelaENT.UpdUser = objRTConceptRelaENS.UpdUser; //修改人
objRTConceptRelaENT.ClassificationId = objRTConceptRelaENS.ClassificationId; //分类Id
objRTConceptRelaENT.IdCurrEduCls = objRTConceptRelaENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTConceptRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsRTConceptRelaEN objRTConceptRelaEN)
{
try
{
objRTConceptRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objRTConceptRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRTConceptRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.mId = objRTConceptRelaEN.mId; //mId
}
if (arrFldSet.Contains(conRTConceptRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.TopicId = objRTConceptRelaEN.TopicId == "[null]" ? null :  objRTConceptRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conRTConceptRela.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.ConceptId = objRTConceptRelaEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(conRTConceptRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.UpdDate = objRTConceptRelaEN.UpdDate == "[null]" ? null :  objRTConceptRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conRTConceptRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.Memo = objRTConceptRelaEN.Memo == "[null]" ? null :  objRTConceptRelaEN.Memo; //备注
}
if (arrFldSet.Contains(conRTConceptRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.UpdUser = objRTConceptRelaEN.UpdUser == "[null]" ? null :  objRTConceptRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conRTConceptRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.ClassificationId = objRTConceptRelaEN.ClassificationId; //分类Id
}
if (arrFldSet.Contains(conRTConceptRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objRTConceptRelaEN.IdCurrEduCls = objRTConceptRelaEN.IdCurrEduCls == "[null]" ? null :  objRTConceptRelaEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTConceptRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsRTConceptRelaEN objRTConceptRelaEN)
{
try
{
if (objRTConceptRelaEN.TopicId == "[null]") objRTConceptRelaEN.TopicId = null; //主题Id
if (objRTConceptRelaEN.UpdDate == "[null]") objRTConceptRelaEN.UpdDate = null; //修改日期
if (objRTConceptRelaEN.Memo == "[null]") objRTConceptRelaEN.Memo = null; //备注
if (objRTConceptRelaEN.UpdUser == "[null]") objRTConceptRelaEN.UpdUser = null; //修改人
if (objRTConceptRelaEN.IdCurrEduCls == "[null]") objRTConceptRelaEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsRTConceptRelaEN objRTConceptRelaEN)
{
 RTConceptRelaDA.CheckPropertyNew(objRTConceptRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRTConceptRelaEN objRTConceptRelaEN)
{
 RTConceptRelaDA.CheckProperty4Condition(objRTConceptRelaEN);
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
if (clsRTConceptRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTConceptRelaBL没有刷新缓存机制(clsRTConceptRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrRTConceptRelaObjLstCache == null)
//{
//arrRTConceptRelaObjLstCache = RTConceptRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTConceptRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsRTConceptRelaEN._CurrTabName);
List<clsRTConceptRelaEN> arrRTConceptRelaObjLstCache = GetObjLstCache();
IEnumerable <clsRTConceptRelaEN> arrRTConceptRelaObjLst_Sel =
arrRTConceptRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrRTConceptRelaObjLst_Sel.Count() == 0)
{
   clsRTConceptRelaEN obj = clsRTConceptRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrRTConceptRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTConceptRelaEN> GetAllRTConceptRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsRTConceptRelaEN> arrRTConceptRelaObjLstCache = GetObjLstCache(); 
return arrRTConceptRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTConceptRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsRTConceptRelaEN._CurrTabName);
List<clsRTConceptRelaEN> arrRTConceptRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRTConceptRelaObjLstCache;
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
string strKey = string.Format("{0}", clsRTConceptRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRTConceptRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsRTConceptRelaEN._RefreshTimeLst.Count == 0) return "";
return clsRTConceptRelaEN._RefreshTimeLst[clsRTConceptRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsRTConceptRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRTConceptRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRTConceptRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsRTConceptRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--RTConceptRela(主题概念关系表)
 /// 唯一性条件:mId_TopicId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRTConceptRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsRTConceptRelaEN objRTConceptRelaEN)
{
//检测记录是否存在
string strResult = RTConceptRelaDA.GetUniCondStr(objRTConceptRelaEN);
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
if (strInFldName != conRTConceptRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRTConceptRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRTConceptRela.AttributeName));
throw new Exception(strMsg);
}
var objRTConceptRela = clsRTConceptRelaBL.GetObjBymIdCache(lngmId);
if (objRTConceptRela == null) return "";
return objRTConceptRela[strOutFldName].ToString();
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
int intRecCount = clsRTConceptRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsRTConceptRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRTConceptRelaDA.GetRecCount();
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
int intRecCount = clsRTConceptRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRTConceptRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRTConceptRelaEN objRTConceptRelaCond)
{
List<clsRTConceptRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRTConceptRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTConceptRela.AttributeName)
{
if (objRTConceptRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTConceptRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTConceptRelaCond[strFldName].ToString());
}
else
{
if (objRTConceptRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTConceptRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTConceptRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTConceptRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTConceptRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTConceptRelaCond[strFldName]));
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
 List<string> arrList = clsRTConceptRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RTConceptRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RTConceptRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RTConceptRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTConceptRelaDA.SetFldValue(clsRTConceptRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RTConceptRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTConceptRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTConceptRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTConceptRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[RTConceptRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**概念Id*/ 
 strCreateTabCode.Append(" ConceptId char(8) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**分类Id*/ 
 strCreateTabCode.Append(" ClassificationId bigint Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 主题概念关系表(RTConceptRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4RTConceptRela : clsCommFun4BL
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
clsRTConceptRelaBL.ReFreshThisCache();
}
}

}