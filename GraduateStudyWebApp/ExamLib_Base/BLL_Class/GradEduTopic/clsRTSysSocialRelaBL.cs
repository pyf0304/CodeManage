
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTSysSocialRelaBL
 表名:RTSysSocialRela(01120657)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:11
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
public static class  clsRTSysSocialRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTSysSocialRelaEN GetObj(this K_mId_RTSysSocialRela myKey)
{
clsRTSysSocialRelaEN objRTSysSocialRelaEN = clsRTSysSocialRelaBL.RTSysSocialRelaDA.GetObjBymId(myKey.Value);
return objRTSysSocialRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTSysSocialRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTSysSocialRelaBL.AddNewRecord)", objRTSysSocialRelaEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsRTSysSocialRelaBL.RTSysSocialRelaDA.AddNewRecordBySQL2(objRTSysSocialRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objRTSysSocialRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objRTSysSocialRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objRTSysSocialRelaEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objRTSysSocialRelaEN.AddNewRecord();
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
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTSysSocialRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTSysSocialRelaBL.AddNewRecordWithReturnKey)", objRTSysSocialRelaEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsRTSysSocialRelaBL.RTSysSocialRelaDA.AddNewRecordBySQL2WithReturnKey(objRTSysSocialRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetmId(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, long lngmId, string strComparisonOp="")
	{
objRTSysSocialRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.mId) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.mId, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.mId] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetTopicId(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicId, conRTSysSocialRela.TopicId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conRTSysSocialRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conRTSysSocialRela.TopicId);
}
objRTSysSocialRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.TopicId) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.TopicId, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.TopicId] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetSocialId(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strSocialId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSocialId, conRTSysSocialRela.SocialId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialId, 10, conRTSysSocialRela.SocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSocialId, 10, conRTSysSocialRela.SocialId);
}
objRTSysSocialRelaEN.SocialId = strSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.SocialId) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.SocialId, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.SocialId] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetUpdDate(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conRTSysSocialRela.UpdDate);
}
objRTSysSocialRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.UpdDate) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.UpdDate, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.UpdDate] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetUpdUser(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conRTSysSocialRela.UpdUser);
}
objRTSysSocialRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.UpdUser) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.UpdUser, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.UpdUser] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetMemo(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRTSysSocialRela.Memo);
}
objRTSysSocialRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.Memo) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.Memo, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.Memo] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetClassificationId(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, long? lngClassificationId, string strComparisonOp="")
	{
objRTSysSocialRelaEN.ClassificationId = lngClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.ClassificationId) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.ClassificationId, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.ClassificationId] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTSysSocialRelaEN SetIdCurrEduCls(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conRTSysSocialRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conRTSysSocialRela.IdCurrEduCls);
}
objRTSysSocialRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(conRTSysSocialRela.IdCurrEduCls) == false)
{
objRTSysSocialRelaEN.dicFldComparisonOp.Add(conRTSysSocialRela.IdCurrEduCls, strComparisonOp);
}
else
{
objRTSysSocialRelaEN.dicFldComparisonOp[conRTSysSocialRela.IdCurrEduCls] = strComparisonOp;
}
}
return objRTSysSocialRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRTSysSocialRelaEN.CheckPropertyNew();
clsRTSysSocialRelaEN objRTSysSocialRelaCond = new clsRTSysSocialRelaEN();
string strCondition = objRTSysSocialRelaCond
.SetmId(objRTSysSocialRelaEN.mId, "<>")
.SetmId(objRTSysSocialRelaEN.mId, "=")
.GetCombineCondition();
objRTSysSocialRelaEN._IsCheckProperty = true;
bool bolIsExist = clsRTSysSocialRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRTSysSocialRelaEN.Update();
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
 /// <param name = "objRTSysSocialRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsRTSysSocialRelaEN objRTSysSocialRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsRTSysSocialRelaEN objRTSysSocialRelaCond = new clsRTSysSocialRelaEN();
string strCondition = objRTSysSocialRelaCond
.SetmId(objRTSysSocialRela.mId, "=")
.GetCombineCondition();
objRTSysSocialRela._IsCheckProperty = true;
bool bolIsExist = clsRTSysSocialRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objRTSysSocialRela.mId = clsRTSysSocialRelaBL.GetFirstID_S(strCondition);
objRTSysSocialRela.UpdateWithCondition(strCondition);
}
else
{
objRTSysSocialRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
 if (objRTSysSocialRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTSysSocialRelaBL.RTSysSocialRelaDA.UpdateBySql2(objRTSysSocialRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRTSysSocialRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTSysSocialRelaBL.RTSysSocialRelaDA.UpdateBySql2(objRTSysSocialRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsRTSysSocialRelaBL.RTSysSocialRelaDA.UpdateBySqlWithCondition(objRTSysSocialRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTSysSocialRelaEN objRTSysSocialRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRTSysSocialRelaBL.RTSysSocialRelaDA.UpdateBySqlWithConditionTransaction(objRTSysSocialRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
public static int Delete(this clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
try
{
int intRecNum = clsRTSysSocialRelaBL.RTSysSocialRelaDA.DelRecord(objRTSysSocialRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaENS">源对象</param>
 /// <param name = "objRTSysSocialRelaENT">目标对象</param>
 public static void CopyTo(this clsRTSysSocialRelaEN objRTSysSocialRelaENS, clsRTSysSocialRelaEN objRTSysSocialRelaENT)
{
try
{
objRTSysSocialRelaENT.mId = objRTSysSocialRelaENS.mId; //mId
objRTSysSocialRelaENT.TopicId = objRTSysSocialRelaENS.TopicId; //主题Id
objRTSysSocialRelaENT.SocialId = objRTSysSocialRelaENS.SocialId; //社会Id
objRTSysSocialRelaENT.UpdDate = objRTSysSocialRelaENS.UpdDate; //修改日期
objRTSysSocialRelaENT.UpdUser = objRTSysSocialRelaENS.UpdUser; //修改人
objRTSysSocialRelaENT.Memo = objRTSysSocialRelaENS.Memo; //备注
objRTSysSocialRelaENT.ClassificationId = objRTSysSocialRelaENS.ClassificationId; //分类Id
objRTSysSocialRelaENT.IdCurrEduCls = objRTSysSocialRelaENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTSysSocialRelaENS">源对象</param>
 /// <returns>目标对象=>clsRTSysSocialRelaEN:objRTSysSocialRelaENT</returns>
 public static clsRTSysSocialRelaEN CopyTo(this clsRTSysSocialRelaEN objRTSysSocialRelaENS)
{
try
{
 clsRTSysSocialRelaEN objRTSysSocialRelaENT = new clsRTSysSocialRelaEN()
{
mId = objRTSysSocialRelaENS.mId, //mId
TopicId = objRTSysSocialRelaENS.TopicId, //主题Id
SocialId = objRTSysSocialRelaENS.SocialId, //社会Id
UpdDate = objRTSysSocialRelaENS.UpdDate, //修改日期
UpdUser = objRTSysSocialRelaENS.UpdUser, //修改人
Memo = objRTSysSocialRelaENS.Memo, //备注
ClassificationId = objRTSysSocialRelaENS.ClassificationId, //分类Id
IdCurrEduCls = objRTSysSocialRelaENS.IdCurrEduCls, //教学班流水号
};
 return objRTSysSocialRelaENT;
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
public static void CheckPropertyNew(this clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
 clsRTSysSocialRelaBL.RTSysSocialRelaDA.CheckPropertyNew(objRTSysSocialRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
 clsRTSysSocialRelaBL.RTSysSocialRelaDA.CheckProperty4Condition(objRTSysSocialRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRTSysSocialRelaEN objRTSysSocialRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.mId) == true)
{
string strComparisonOpmId = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conRTSysSocialRela.mId, objRTSysSocialRelaCond.mId, strComparisonOpmId);
}
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.TopicId) == true)
{
string strComparisonOpTopicId = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTSysSocialRela.TopicId, objRTSysSocialRelaCond.TopicId, strComparisonOpTopicId);
}
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.SocialId) == true)
{
string strComparisonOpSocialId = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.SocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTSysSocialRela.SocialId, objRTSysSocialRelaCond.SocialId, strComparisonOpSocialId);
}
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTSysSocialRela.UpdDate, objRTSysSocialRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTSysSocialRela.UpdUser, objRTSysSocialRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.Memo) == true)
{
string strComparisonOpMemo = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTSysSocialRela.Memo, objRTSysSocialRelaCond.Memo, strComparisonOpMemo);
}
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} {1}", conRTSysSocialRela.ClassificationId, objRTSysSocialRelaCond.ClassificationId, strComparisonOpClassificationId);
}
if (objRTSysSocialRelaCond.IsUpdated(conRTSysSocialRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objRTSysSocialRelaCond.dicFldComparisonOp[conRTSysSocialRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTSysSocialRela.IdCurrEduCls, objRTSysSocialRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--RTSysSocialRela(RTSysSocialRela), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objRTSysSocialRelaEN == null) return true;
if (objRTSysSocialRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objRTSysSocialRelaEN.mId);
if (clsRTSysSocialRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTSysSocialRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objRTSysSocialRelaEN.mId);
if (clsRTSysSocialRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--RTSysSocialRela(RTSysSocialRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objRTSysSocialRelaEN == null) return "";
if (objRTSysSocialRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objRTSysSocialRelaEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTSysSocialRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objRTSysSocialRelaEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_RTSysSocialRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// RTSysSocialRela(RTSysSocialRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRTSysSocialRelaBL
{
public static RelatedActions_RTSysSocialRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRTSysSocialRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRTSysSocialRelaDA RTSysSocialRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRTSysSocialRelaDA();
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
 public clsRTSysSocialRelaBL()
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
if (string.IsNullOrEmpty(clsRTSysSocialRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRTSysSocialRelaEN._ConnectString);
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
public static DataTable GetDataTable_RTSysSocialRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RTSysSocialRelaDA.GetDataTable_RTSysSocialRela(strWhereCond);
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
objDT = RTSysSocialRelaDA.GetDataTable(strWhereCond);
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
objDT = RTSysSocialRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RTSysSocialRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RTSysSocialRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RTSysSocialRelaDA.GetDataTable_Top(objTopPara);
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
objDT = RTSysSocialRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = RTSysSocialRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RTSysSocialRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsRTSysSocialRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
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
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRTSysSocialRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsRTSysSocialRelaEN._CurrTabName);
List<clsRTSysSocialRelaEN> arrRTSysSocialRelaObjLstCache = GetObjLstCache();
IEnumerable <clsRTSysSocialRelaEN> arrRTSysSocialRelaObjLst_Sel =
arrRTSysSocialRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrRTSysSocialRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTSysSocialRelaEN> GetObjLst(string strWhereCond)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
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
public static List<clsRTSysSocialRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRTSysSocialRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRTSysSocialRelaEN> GetSubObjLstCache(clsRTSysSocialRelaEN objRTSysSocialRelaCond)
{
List<clsRTSysSocialRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRTSysSocialRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTSysSocialRela.AttributeName)
{
if (objRTSysSocialRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTSysSocialRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTSysSocialRelaCond[strFldName].ToString());
}
else
{
if (objRTSysSocialRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTSysSocialRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTSysSocialRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTSysSocialRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTSysSocialRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTSysSocialRelaCond[strFldName]));
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
public static List<clsRTSysSocialRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
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
public static List<clsRTSysSocialRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
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
List<clsRTSysSocialRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRTSysSocialRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTSysSocialRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRTSysSocialRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
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
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
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
public static List<clsRTSysSocialRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRTSysSocialRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRTSysSocialRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
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
public static List<clsRTSysSocialRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTSysSocialRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRTSysSocialRelaEN> arrObjLst = new List<clsRTSysSocialRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTSysSocialRelaEN objRTSysSocialRelaEN = new clsRTSysSocialRelaEN();
try
{
objRTSysSocialRelaEN.mId = Int32.Parse(objRow[conRTSysSocialRela.mId].ToString().Trim()); //mId
objRTSysSocialRelaEN.TopicId = objRow[conRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objRTSysSocialRelaEN.SocialId = objRow[conRTSysSocialRela.SocialId].ToString().Trim(); //社会Id
objRTSysSocialRelaEN.UpdDate = objRow[conRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objRTSysSocialRelaEN.UpdUser = objRow[conRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[conRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objRTSysSocialRelaEN.Memo = objRow[conRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[conRTSysSocialRela.Memo].ToString().Trim(); //备注
objRTSysSocialRelaEN.ClassificationId = objRow[conRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objRTSysSocialRelaEN.IdCurrEduCls = objRow[conRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTSysSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTSysSocialRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRTSysSocialRela(ref clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
bool bolResult = RTSysSocialRelaDA.GetRTSysSocialRela(ref objRTSysSocialRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTSysSocialRelaEN GetObjBymId(long lngmId)
{
clsRTSysSocialRelaEN objRTSysSocialRelaEN = RTSysSocialRelaDA.GetObjBymId(lngmId);
return objRTSysSocialRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRTSysSocialRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRTSysSocialRelaEN objRTSysSocialRelaEN = RTSysSocialRelaDA.GetFirstObj(strWhereCond);
 return objRTSysSocialRelaEN;
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
public static clsRTSysSocialRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRTSysSocialRelaEN objRTSysSocialRelaEN = RTSysSocialRelaDA.GetObjByDataRow(objRow);
 return objRTSysSocialRelaEN;
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
public static clsRTSysSocialRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRTSysSocialRelaEN objRTSysSocialRelaEN = RTSysSocialRelaDA.GetObjByDataRow(objRow);
 return objRTSysSocialRelaEN;
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
 /// <param name = "lstRTSysSocialRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTSysSocialRelaEN GetObjBymIdFromList(long lngmId, List<clsRTSysSocialRelaEN> lstRTSysSocialRelaObjLst)
{
foreach (clsRTSysSocialRelaEN objRTSysSocialRelaEN in lstRTSysSocialRelaObjLst)
{
if (objRTSysSocialRelaEN.mId == lngmId)
{
return objRTSysSocialRelaEN;
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
 lngmId = new clsRTSysSocialRelaDA().GetFirstID(strWhereCond);
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
 arrList = RTSysSocialRelaDA.GetID(strWhereCond);
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
bool bolIsExist = RTSysSocialRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = RTSysSocialRelaDA.IsExist(lngmId);
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
 bolIsExist = clsRTSysSocialRelaDA.IsExistTable();
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
 bolIsExist = RTSysSocialRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRTSysSocialRelaEN objRTSysSocialRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTSysSocialRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTSysSocialRelaBL.AddNewRecordBySql2)", objRTSysSocialRelaEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = RTSysSocialRelaDA.AddNewRecordBySQL2(objRTSysSocialRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRTSysSocialRelaEN objRTSysSocialRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTSysSocialRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsRTSysSocialRelaBL.AddNewRecordBySql2WithReturnKey)", objRTSysSocialRelaEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = RTSysSocialRelaDA.AddNewRecordBySQL2WithReturnKey(objRTSysSocialRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
try
{
bool bolResult = RTSysSocialRelaDA.Update(objRTSysSocialRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objRTSysSocialRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
 if (objRTSysSocialRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RTSysSocialRelaDA.UpdateBySql2(objRTSysSocialRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTSysSocialRelaBL.ReFreshCache();

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
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
 clsRTSysSocialRelaEN objRTSysSocialRelaEN = clsRTSysSocialRelaBL.GetObjBymId(lngmId);

if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(objRTSysSocialRelaEN.mId, "SetUpdDate");
}
if (objRTSysSocialRelaEN != null)
{
int intRecNum = RTSysSocialRelaDA.DelRecord(lngmId);
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
objSQL = clsRTSysSocialRelaDA.GetSpecSQLObj();
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
//删除与表:[RTSysSocialRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRTSysSocialRela.mId,
//lngmId);
//        clsRTSysSocialRelaBL.DelRTSysSocialRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTSysSocialRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTSysSocialRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsRTSysSocialRelaBL.relatedActions != null)
{
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = RTSysSocialRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelRTSysSocialRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsRTSysSocialRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = RTSysSocialRelaDA.DelRTSysSocialRela(arrmIdLst);
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
public static int DelRTSysSocialRelasByCond(string strWhereCond)
{
try
{
if (clsRTSysSocialRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsRTSysSocialRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = RTSysSocialRelaDA.DelRTSysSocialRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[RTSysSocialRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRTSysSocialRelaDA.GetSpecSQLObj();
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
//删除与表:[RTSysSocialRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTSysSocialRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTSysSocialRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objRTSysSocialRelaENS">源对象</param>
 /// <param name = "objRTSysSocialRelaENT">目标对象</param>
 public static void CopyTo(clsRTSysSocialRelaEN objRTSysSocialRelaENS, clsRTSysSocialRelaEN objRTSysSocialRelaENT)
{
try
{
objRTSysSocialRelaENT.mId = objRTSysSocialRelaENS.mId; //mId
objRTSysSocialRelaENT.TopicId = objRTSysSocialRelaENS.TopicId; //主题Id
objRTSysSocialRelaENT.SocialId = objRTSysSocialRelaENS.SocialId; //社会Id
objRTSysSocialRelaENT.UpdDate = objRTSysSocialRelaENS.UpdDate; //修改日期
objRTSysSocialRelaENT.UpdUser = objRTSysSocialRelaENS.UpdUser; //修改人
objRTSysSocialRelaENT.Memo = objRTSysSocialRelaENS.Memo; //备注
objRTSysSocialRelaENT.ClassificationId = objRTSysSocialRelaENS.ClassificationId; //分类Id
objRTSysSocialRelaENT.IdCurrEduCls = objRTSysSocialRelaENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTSysSocialRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
try
{
objRTSysSocialRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objRTSysSocialRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRTSysSocialRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.mId = objRTSysSocialRelaEN.mId; //mId
}
if (arrFldSet.Contains(conRTSysSocialRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.TopicId = objRTSysSocialRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conRTSysSocialRela.SocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.SocialId = objRTSysSocialRelaEN.SocialId; //社会Id
}
if (arrFldSet.Contains(conRTSysSocialRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.UpdDate = objRTSysSocialRelaEN.UpdDate == "[null]" ? null :  objRTSysSocialRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conRTSysSocialRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.UpdUser = objRTSysSocialRelaEN.UpdUser == "[null]" ? null :  objRTSysSocialRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conRTSysSocialRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.Memo = objRTSysSocialRelaEN.Memo == "[null]" ? null :  objRTSysSocialRelaEN.Memo; //备注
}
if (arrFldSet.Contains(conRTSysSocialRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.ClassificationId = objRTSysSocialRelaEN.ClassificationId; //分类Id
}
if (arrFldSet.Contains(conRTSysSocialRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objRTSysSocialRelaEN.IdCurrEduCls = objRTSysSocialRelaEN.IdCurrEduCls == "[null]" ? null :  objRTSysSocialRelaEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objRTSysSocialRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
try
{
if (objRTSysSocialRelaEN.UpdDate == "[null]") objRTSysSocialRelaEN.UpdDate = null; //修改日期
if (objRTSysSocialRelaEN.UpdUser == "[null]") objRTSysSocialRelaEN.UpdUser = null; //修改人
if (objRTSysSocialRelaEN.Memo == "[null]") objRTSysSocialRelaEN.Memo = null; //备注
if (objRTSysSocialRelaEN.IdCurrEduCls == "[null]") objRTSysSocialRelaEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
 RTSysSocialRelaDA.CheckPropertyNew(objRTSysSocialRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
 RTSysSocialRelaDA.CheckProperty4Condition(objRTSysSocialRelaEN);
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
if (clsRTSysSocialRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTSysSocialRelaBL没有刷新缓存机制(clsRTSysSocialRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrRTSysSocialRelaObjLstCache == null)
//{
//arrRTSysSocialRelaObjLstCache = RTSysSocialRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTSysSocialRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsRTSysSocialRelaEN._CurrTabName);
List<clsRTSysSocialRelaEN> arrRTSysSocialRelaObjLstCache = GetObjLstCache();
IEnumerable <clsRTSysSocialRelaEN> arrRTSysSocialRelaObjLst_Sel =
arrRTSysSocialRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrRTSysSocialRelaObjLst_Sel.Count() == 0)
{
   clsRTSysSocialRelaEN obj = clsRTSysSocialRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrRTSysSocialRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTSysSocialRelaEN> GetAllRTSysSocialRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsRTSysSocialRelaEN> arrRTSysSocialRelaObjLstCache = GetObjLstCache(); 
return arrRTSysSocialRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTSysSocialRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsRTSysSocialRelaEN._CurrTabName);
List<clsRTSysSocialRelaEN> arrRTSysSocialRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRTSysSocialRelaObjLstCache;
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
string strKey = string.Format("{0}", clsRTSysSocialRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRTSysSocialRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsRTSysSocialRelaEN._RefreshTimeLst.Count == 0) return "";
return clsRTSysSocialRelaEN._RefreshTimeLst[clsRTSysSocialRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsRTSysSocialRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRTSysSocialRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRTSysSocialRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsRTSysSocialRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--RTSysSocialRela(RTSysSocialRela)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRTSysSocialRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsRTSysSocialRelaEN objRTSysSocialRelaEN)
{
//检测记录是否存在
string strResult = RTSysSocialRelaDA.GetUniCondStr(objRTSysSocialRelaEN);
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
if (strInFldName != conRTSysSocialRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRTSysSocialRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRTSysSocialRela.AttributeName));
throw new Exception(strMsg);
}
var objRTSysSocialRela = clsRTSysSocialRelaBL.GetObjBymIdCache(lngmId);
if (objRTSysSocialRela == null) return "";
return objRTSysSocialRela[strOutFldName].ToString();
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
int intRecCount = clsRTSysSocialRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsRTSysSocialRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRTSysSocialRelaDA.GetRecCount();
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
int intRecCount = clsRTSysSocialRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRTSysSocialRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRTSysSocialRelaEN objRTSysSocialRelaCond)
{
List<clsRTSysSocialRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRTSysSocialRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTSysSocialRela.AttributeName)
{
if (objRTSysSocialRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTSysSocialRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTSysSocialRelaCond[strFldName].ToString());
}
else
{
if (objRTSysSocialRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTSysSocialRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTSysSocialRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTSysSocialRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTSysSocialRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTSysSocialRelaCond[strFldName]));
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
 List<string> arrList = clsRTSysSocialRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RTSysSocialRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RTSysSocialRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RTSysSocialRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTSysSocialRelaDA.SetFldValue(clsRTSysSocialRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RTSysSocialRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTSysSocialRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTSysSocialRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTSysSocialRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[RTSysSocialRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) not Null, "); 
 // /**社会Id*/ 
 strCreateTabCode.Append(" SocialId char(10) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
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
 /// RTSysSocialRela(RTSysSocialRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4RTSysSocialRela : clsCommFun4BL
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
clsRTSysSocialRelaBL.ReFreshThisCache();
}
}

}