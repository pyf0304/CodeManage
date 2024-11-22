
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewsClassificationBL
 表名:zx_ViewsClassification(01120806)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clszx_ViewsClassificationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxClassificationId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewsClassificationEN GetObj(this K_zxClassificationId_zx_ViewsClassification myKey)
{
clszx_ViewsClassificationEN objzx_ViewsClassificationEN = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.GetObjByzxClassificationId(myKey.Value);
return objzx_ViewsClassificationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 if (string.IsNullOrEmpty(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ViewsClassificationBL.IsExist(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ViewsClassificationEN.zxClassificationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objzx_ViewsClassificationEN) == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clszx_ViewsClassificationBL.AddNewRecord)", objzx_ViewsClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.AddNewRecordBySQL2(objzx_ViewsClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clszx_ViewsClassificationBL.IsExist(objzx_ViewsClassificationEN.zxClassificationId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objzx_ViewsClassificationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ViewsClassificationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(分类名称(ClassificationName)=[{0}])已经存在,不能重复!", objzx_ViewsClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_ViewsClassificationEN.AddNewRecord();
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
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 if (string.IsNullOrEmpty(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ViewsClassificationBL.IsExist(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ViewsClassificationEN.zxClassificationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (CheckUniqueness(objzx_ViewsClassificationEN) == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clszx_ViewsClassificationBL.AddNewRecordWithReturnKey)", objzx_ViewsClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewsClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewsClassificationEN SetzxClassificationId(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strzxClassificationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxClassificationId, 10, conzx_ViewsClassification.zxClassificationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxClassificationId, 10, conzx_ViewsClassification.zxClassificationId);
}
objzx_ViewsClassificationEN.zxClassificationId = strzxClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewsClassificationEN.dicFldComparisonOp.ContainsKey(conzx_ViewsClassification.zxClassificationId) == false)
{
objzx_ViewsClassificationEN.dicFldComparisonOp.Add(conzx_ViewsClassification.zxClassificationId, strComparisonOp);
}
else
{
objzx_ViewsClassificationEN.dicFldComparisonOp[conzx_ViewsClassification.zxClassificationId] = strComparisonOp;
}
}
return objzx_ViewsClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewsClassificationEN SetClassificationName(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strClassificationName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassificationName, 200, conzx_ViewsClassification.ClassificationName);
}
objzx_ViewsClassificationEN.ClassificationName = strClassificationName; //分类名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewsClassificationEN.dicFldComparisonOp.ContainsKey(conzx_ViewsClassification.ClassificationName) == false)
{
objzx_ViewsClassificationEN.dicFldComparisonOp.Add(conzx_ViewsClassification.ClassificationName, strComparisonOp);
}
else
{
objzx_ViewsClassificationEN.dicFldComparisonOp[conzx_ViewsClassification.ClassificationName] = strComparisonOp;
}
}
return objzx_ViewsClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewsClassificationEN SetGroupTextId(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_ViewsClassification.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_ViewsClassification.GroupTextId);
}
objzx_ViewsClassificationEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewsClassificationEN.dicFldComparisonOp.ContainsKey(conzx_ViewsClassification.GroupTextId) == false)
{
objzx_ViewsClassificationEN.dicFldComparisonOp.Add(conzx_ViewsClassification.GroupTextId, strComparisonOp);
}
else
{
objzx_ViewsClassificationEN.dicFldComparisonOp[conzx_ViewsClassification.GroupTextId] = strComparisonOp;
}
}
return objzx_ViewsClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewsClassificationEN SetUpdDate(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ViewsClassification.UpdDate);
}
objzx_ViewsClassificationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewsClassificationEN.dicFldComparisonOp.ContainsKey(conzx_ViewsClassification.UpdDate) == false)
{
objzx_ViewsClassificationEN.dicFldComparisonOp.Add(conzx_ViewsClassification.UpdDate, strComparisonOp);
}
else
{
objzx_ViewsClassificationEN.dicFldComparisonOp[conzx_ViewsClassification.UpdDate] = strComparisonOp;
}
}
return objzx_ViewsClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewsClassificationEN SetUpdUser(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_ViewsClassification.UpdUser);
}
objzx_ViewsClassificationEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewsClassificationEN.dicFldComparisonOp.ContainsKey(conzx_ViewsClassification.UpdUser) == false)
{
objzx_ViewsClassificationEN.dicFldComparisonOp.Add(conzx_ViewsClassification.UpdUser, strComparisonOp);
}
else
{
objzx_ViewsClassificationEN.dicFldComparisonOp[conzx_ViewsClassification.UpdUser] = strComparisonOp;
}
}
return objzx_ViewsClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewsClassificationEN SetMemo(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ViewsClassification.Memo);
}
objzx_ViewsClassificationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewsClassificationEN.dicFldComparisonOp.ContainsKey(conzx_ViewsClassification.Memo) == false)
{
objzx_ViewsClassificationEN.dicFldComparisonOp.Add(conzx_ViewsClassification.Memo, strComparisonOp);
}
else
{
objzx_ViewsClassificationEN.dicFldComparisonOp[conzx_ViewsClassification.Memo] = strComparisonOp;
}
}
return objzx_ViewsClassificationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewsClassificationEN SetOrderNum(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, int? intOrderNum, string strComparisonOp="")
	{
objzx_ViewsClassificationEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewsClassificationEN.dicFldComparisonOp.ContainsKey(conzx_ViewsClassification.OrderNum) == false)
{
objzx_ViewsClassificationEN.dicFldComparisonOp.Add(conzx_ViewsClassification.OrderNum, strComparisonOp);
}
else
{
objzx_ViewsClassificationEN.dicFldComparisonOp[conzx_ViewsClassification.OrderNum] = strComparisonOp;
}
}
return objzx_ViewsClassificationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ViewsClassificationEN.CheckPropertyNew();
clszx_ViewsClassificationEN objzx_ViewsClassificationCond = new clszx_ViewsClassificationEN();
string strCondition = objzx_ViewsClassificationCond
.SetzxClassificationId(objzx_ViewsClassificationEN.zxClassificationId, "<>")
.SetClassificationName(objzx_ViewsClassificationEN.ClassificationName, "=")
.GetCombineCondition();
objzx_ViewsClassificationEN._IsCheckProperty = true;
bool bolIsExist = clszx_ViewsClassificationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ClassificationName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ViewsClassificationEN.Update();
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
 /// <param name = "objzx_ViewsClassification">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ViewsClassificationEN objzx_ViewsClassification)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ViewsClassificationEN objzx_ViewsClassificationCond = new clszx_ViewsClassificationEN();
string strCondition = objzx_ViewsClassificationCond
.SetClassificationName(objzx_ViewsClassification.ClassificationName, "=")
.GetCombineCondition();
objzx_ViewsClassification._IsCheckProperty = true;
bool bolIsExist = clszx_ViewsClassificationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ViewsClassification.zxClassificationId = clszx_ViewsClassificationBL.GetFirstID_S(strCondition);
objzx_ViewsClassification.UpdateWithCondition(strCondition);
}
else
{
objzx_ViewsClassification.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 if (string.IsNullOrEmpty(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.UpdateBySql2(objzx_ViewsClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.UpdateBySql2(objzx_ViewsClassificationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.UpdateBySqlWithCondition(objzx_ViewsClassificationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.UpdateBySqlWithConditionTransaction(objzx_ViewsClassificationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "strzxClassificationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
try
{
int intRecNum = clszx_ViewsClassificationBL.zx_ViewsClassificationDA.DelRecord(objzx_ViewsClassificationEN.zxClassificationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationENS">源对象</param>
 /// <param name = "objzx_ViewsClassificationENT">目标对象</param>
 public static void CopyTo(this clszx_ViewsClassificationEN objzx_ViewsClassificationENS, clszx_ViewsClassificationEN objzx_ViewsClassificationENT)
{
try
{
objzx_ViewsClassificationENT.zxClassificationId = objzx_ViewsClassificationENS.zxClassificationId; //分类Id
objzx_ViewsClassificationENT.ClassificationName = objzx_ViewsClassificationENS.ClassificationName; //分类名称
objzx_ViewsClassificationENT.GroupTextId = objzx_ViewsClassificationENS.GroupTextId; //小组Id
objzx_ViewsClassificationENT.UpdDate = objzx_ViewsClassificationENS.UpdDate; //修改日期
objzx_ViewsClassificationENT.UpdUser = objzx_ViewsClassificationENS.UpdUser; //修改人
objzx_ViewsClassificationENT.Memo = objzx_ViewsClassificationENS.Memo; //备注
objzx_ViewsClassificationENT.OrderNum = objzx_ViewsClassificationENS.OrderNum; //序号
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
 /// <param name = "objzx_ViewsClassificationENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewsClassificationEN:objzx_ViewsClassificationENT</returns>
 public static clszx_ViewsClassificationEN CopyTo(this clszx_ViewsClassificationEN objzx_ViewsClassificationENS)
{
try
{
 clszx_ViewsClassificationEN objzx_ViewsClassificationENT = new clszx_ViewsClassificationEN()
{
zxClassificationId = objzx_ViewsClassificationENS.zxClassificationId, //分类Id
ClassificationName = objzx_ViewsClassificationENS.ClassificationName, //分类名称
GroupTextId = objzx_ViewsClassificationENS.GroupTextId, //小组Id
UpdDate = objzx_ViewsClassificationENS.UpdDate, //修改日期
UpdUser = objzx_ViewsClassificationENS.UpdUser, //修改人
Memo = objzx_ViewsClassificationENS.Memo, //备注
OrderNum = objzx_ViewsClassificationENS.OrderNum, //序号
};
 return objzx_ViewsClassificationENT;
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
public static void CheckPropertyNew(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 clszx_ViewsClassificationBL.zx_ViewsClassificationDA.CheckPropertyNew(objzx_ViewsClassificationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 clszx_ViewsClassificationBL.zx_ViewsClassificationDA.CheckProperty4Condition(objzx_ViewsClassificationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ViewsClassificationEN objzx_ViewsClassificationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ViewsClassificationCond.IsUpdated(conzx_ViewsClassification.zxClassificationId) == true)
{
string strComparisonOpzxClassificationId = objzx_ViewsClassificationCond.dicFldComparisonOp[conzx_ViewsClassification.zxClassificationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewsClassification.zxClassificationId, objzx_ViewsClassificationCond.zxClassificationId, strComparisonOpzxClassificationId);
}
if (objzx_ViewsClassificationCond.IsUpdated(conzx_ViewsClassification.ClassificationName) == true)
{
string strComparisonOpClassificationName = objzx_ViewsClassificationCond.dicFldComparisonOp[conzx_ViewsClassification.ClassificationName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewsClassification.ClassificationName, objzx_ViewsClassificationCond.ClassificationName, strComparisonOpClassificationName);
}
if (objzx_ViewsClassificationCond.IsUpdated(conzx_ViewsClassification.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_ViewsClassificationCond.dicFldComparisonOp[conzx_ViewsClassification.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewsClassification.GroupTextId, objzx_ViewsClassificationCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objzx_ViewsClassificationCond.IsUpdated(conzx_ViewsClassification.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ViewsClassificationCond.dicFldComparisonOp[conzx_ViewsClassification.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewsClassification.UpdDate, objzx_ViewsClassificationCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ViewsClassificationCond.IsUpdated(conzx_ViewsClassification.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_ViewsClassificationCond.dicFldComparisonOp[conzx_ViewsClassification.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewsClassification.UpdUser, objzx_ViewsClassificationCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_ViewsClassificationCond.IsUpdated(conzx_ViewsClassification.Memo) == true)
{
string strComparisonOpMemo = objzx_ViewsClassificationCond.dicFldComparisonOp[conzx_ViewsClassification.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewsClassification.Memo, objzx_ViewsClassificationCond.Memo, strComparisonOpMemo);
}
if (objzx_ViewsClassificationCond.IsUpdated(conzx_ViewsClassification.OrderNum) == true)
{
string strComparisonOpOrderNum = objzx_ViewsClassificationCond.dicFldComparisonOp[conzx_ViewsClassification.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewsClassification.OrderNum, objzx_ViewsClassificationCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ViewsClassification(中学各观点分类表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ClassificationName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewsClassificationEN == null) return true;
if (objzx_ViewsClassificationEN.zxClassificationId == null || objzx_ViewsClassificationEN.zxClassificationId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ViewsClassificationEN.ClassificationName == null)
{
 sbCondition.AppendFormat(" and ClassificationName is null", objzx_ViewsClassificationEN.ClassificationName);
}
else
{
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objzx_ViewsClassificationEN.ClassificationName);
}
if (clszx_ViewsClassificationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxClassificationId !=  '{0}'", objzx_ViewsClassificationEN.zxClassificationId);
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objzx_ViewsClassificationEN.ClassificationName);
if (clszx_ViewsClassificationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ViewsClassification(中学各观点分类表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ClassificationName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewsClassificationEN == null) return "";
if (objzx_ViewsClassificationEN.zxClassificationId == null || objzx_ViewsClassificationEN.zxClassificationId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ViewsClassificationEN.ClassificationName == null)
{
 sbCondition.AppendFormat(" and ClassificationName is null", objzx_ViewsClassificationEN.ClassificationName);
}
else
{
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objzx_ViewsClassificationEN.ClassificationName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxClassificationId !=  '{0}'", objzx_ViewsClassificationEN.zxClassificationId);
 sbCondition.AppendFormat(" and ClassificationName = '{0}'", objzx_ViewsClassificationEN.ClassificationName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ViewsClassification
{
public virtual bool UpdRelaTabDate(string strzxClassificationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学各观点分类表(zx_ViewsClassification)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ViewsClassificationBL
{
public static RelatedActions_zx_ViewsClassification relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ViewsClassificationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ViewsClassificationDA zx_ViewsClassificationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ViewsClassificationDA();
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
 public clszx_ViewsClassificationBL()
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
if (string.IsNullOrEmpty(clszx_ViewsClassificationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewsClassificationEN._ConnectString);
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
public static DataTable GetDataTable_zx_ViewsClassification(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ViewsClassificationDA.GetDataTable_zx_ViewsClassification(strWhereCond);
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
objDT = zx_ViewsClassificationDA.GetDataTable(strWhereCond);
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
objDT = zx_ViewsClassificationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ViewsClassificationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ViewsClassificationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ViewsClassificationDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ViewsClassificationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ViewsClassificationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ViewsClassificationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxClassificationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ViewsClassificationEN> GetObjLstByZxClassificationIdLst(List<string> arrZxClassificationIdLst)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxClassificationIdLst, true);
 string strWhereCond = string.Format("zxClassificationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxClassificationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ViewsClassificationEN> GetObjLstByZxClassificationIdLstCache(List<string> arrZxClassificationIdLst)
{
string strKey = string.Format("{0}", clszx_ViewsClassificationEN._CurrTabName);
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjLst_Sel =
arrzx_ViewsClassificationObjLstCache
.Where(x => arrZxClassificationIdLst.Contains(x.zxClassificationId));
return arrzx_ViewsClassificationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewsClassificationEN> GetObjLst(string strWhereCond)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
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
public static List<clszx_ViewsClassificationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ViewsClassificationEN> GetSubObjLstCache(clszx_ViewsClassificationEN objzx_ViewsClassificationCond)
{
List<clszx_ViewsClassificationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewsClassificationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewsClassification.AttributeName)
{
if (objzx_ViewsClassificationCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewsClassificationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewsClassificationCond[strFldName].ToString());
}
else
{
if (objzx_ViewsClassificationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewsClassificationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewsClassificationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewsClassificationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewsClassificationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewsClassificationCond[strFldName]));
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
public static List<clszx_ViewsClassificationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
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
public static List<clszx_ViewsClassificationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
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
List<clszx_ViewsClassificationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ViewsClassificationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewsClassificationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ViewsClassificationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
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
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
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
public static List<clszx_ViewsClassificationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ViewsClassificationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ViewsClassificationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
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
public static List<clszx_ViewsClassificationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewsClassificationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ViewsClassificationEN> arrObjLst = new List<clszx_ViewsClassificationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewsClassificationEN objzx_ViewsClassificationEN = new clszx_ViewsClassificationEN();
try
{
objzx_ViewsClassificationEN.zxClassificationId = objRow[conzx_ViewsClassification.zxClassificationId].ToString().Trim(); //分类Id
objzx_ViewsClassificationEN.ClassificationName = objRow[conzx_ViewsClassification.ClassificationName] == DBNull.Value ? null : objRow[conzx_ViewsClassification.ClassificationName].ToString().Trim(); //分类名称
objzx_ViewsClassificationEN.GroupTextId = objRow[conzx_ViewsClassification.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewsClassification.GroupTextId].ToString().Trim(); //小组Id
objzx_ViewsClassificationEN.UpdDate = objRow[conzx_ViewsClassification.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdDate].ToString().Trim(); //修改日期
objzx_ViewsClassificationEN.UpdUser = objRow[conzx_ViewsClassification.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewsClassification.UpdUser].ToString().Trim(); //修改人
objzx_ViewsClassificationEN.Memo = objRow[conzx_ViewsClassification.Memo] == DBNull.Value ? null : objRow[conzx_ViewsClassification.Memo].ToString().Trim(); //备注
objzx_ViewsClassificationEN.OrderNum = objRow[conzx_ViewsClassification.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewsClassification.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewsClassificationEN.zxClassificationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewsClassificationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ViewsClassification(ref clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
bool bolResult = zx_ViewsClassificationDA.Getzx_ViewsClassification(ref objzx_ViewsClassificationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxClassificationId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewsClassificationEN GetObjByzxClassificationId(string strzxClassificationId)
{
if (strzxClassificationId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxClassificationId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxClassificationId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxClassificationId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_ViewsClassificationEN objzx_ViewsClassificationEN = zx_ViewsClassificationDA.GetObjByzxClassificationId(strzxClassificationId);
return objzx_ViewsClassificationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ViewsClassificationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ViewsClassificationEN objzx_ViewsClassificationEN = zx_ViewsClassificationDA.GetFirstObj(strWhereCond);
 return objzx_ViewsClassificationEN;
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
public static clszx_ViewsClassificationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ViewsClassificationEN objzx_ViewsClassificationEN = zx_ViewsClassificationDA.GetObjByDataRow(objRow);
 return objzx_ViewsClassificationEN;
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
public static clszx_ViewsClassificationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ViewsClassificationEN objzx_ViewsClassificationEN = zx_ViewsClassificationDA.GetObjByDataRow(objRow);
 return objzx_ViewsClassificationEN;
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
 /// <param name = "strzxClassificationId">所给的关键字</param>
 /// <param name = "lstzx_ViewsClassificationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewsClassificationEN GetObjByzxClassificationIdFromList(string strzxClassificationId, List<clszx_ViewsClassificationEN> lstzx_ViewsClassificationObjLst)
{
foreach (clszx_ViewsClassificationEN objzx_ViewsClassificationEN in lstzx_ViewsClassificationObjLst)
{
if (objzx_ViewsClassificationEN.zxClassificationId == strzxClassificationId)
{
return objzx_ViewsClassificationEN;
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
 string strzxClassificationId;
 try
 {
 strzxClassificationId = new clszx_ViewsClassificationDA().GetFirstID(strWhereCond);
 return strzxClassificationId;
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
 arrList = zx_ViewsClassificationDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ViewsClassificationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxClassificationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxClassificationId)
{
if (string.IsNullOrEmpty(strzxClassificationId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxClassificationId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_ViewsClassificationDA.IsExist(strzxClassificationId);
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
 bolIsExist = clszx_ViewsClassificationDA.IsExistTable();
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
 bolIsExist = zx_ViewsClassificationDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 if (string.IsNullOrEmpty(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ViewsClassificationBL.IsExist(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ViewsClassificationEN.zxClassificationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objzx_ViewsClassificationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clszx_ViewsClassificationBL.AddNewRecordBySql2)", objzx_ViewsClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_ViewsClassificationDA.AddNewRecordBySQL2(objzx_ViewsClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 if (string.IsNullOrEmpty(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_ViewsClassificationBL.IsExist(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_ViewsClassificationEN.zxClassificationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (objzx_ViewsClassificationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类名称 = [{0}]的数据已经存在!(in clszx_ViewsClassificationBL.AddNewRecordBySql2WithReturnKey)", objzx_ViewsClassificationEN.ClassificationName);
throw new Exception(strMsg);
}
try
{
string strKey = zx_ViewsClassificationDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewsClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
try
{
bool bolResult = zx_ViewsClassificationDA.Update(objzx_ViewsClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "objzx_ViewsClassificationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 if (string.IsNullOrEmpty(objzx_ViewsClassificationEN.zxClassificationId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ViewsClassificationDA.UpdateBySql2(objzx_ViewsClassificationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewsClassificationBL.ReFreshCache();

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
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
 /// <param name = "strzxClassificationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxClassificationId)
{
try
{
 clszx_ViewsClassificationEN objzx_ViewsClassificationEN = clszx_ViewsClassificationBL.GetObjByzxClassificationId(strzxClassificationId);

if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassificationEN.zxClassificationId, "SetUpdDate");
}
if (objzx_ViewsClassificationEN != null)
{
int intRecNum = zx_ViewsClassificationDA.DelRecord(strzxClassificationId);
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
/// <param name="strzxClassificationId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxClassificationId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewsClassificationDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewsClassification]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ViewsClassification.zxClassificationId,
//strzxClassificationId);
//        clszx_ViewsClassificationBL.Delzx_ViewsClassificationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewsClassificationBL.DelRecord(strzxClassificationId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewsClassificationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxClassificationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxClassificationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxClassificationId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(strzxClassificationId, "UpdRelaTabDate");
}
bool bolResult = zx_ViewsClassificationDA.DelRecord(strzxClassificationId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxClassificationIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ViewsClassifications(List<string> arrzxClassificationIdLst)
{
if (arrzxClassificationIdLst.Count == 0) return 0;
try
{
if (clszx_ViewsClassificationBL.relatedActions != null)
{
foreach (var strzxClassificationId in arrzxClassificationIdLst)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(strzxClassificationId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ViewsClassificationDA.Delzx_ViewsClassification(arrzxClassificationIdLst);
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
public static int Delzx_ViewsClassificationsByCond(string strWhereCond)
{
try
{
if (clszx_ViewsClassificationBL.relatedActions != null)
{
List<string> arrzxClassificationId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxClassificationId in arrzxClassificationId)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(strzxClassificationId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ViewsClassificationDA.Delzx_ViewsClassification(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ViewsClassification]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxClassificationId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxClassificationId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewsClassificationDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewsClassification]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewsClassificationBL.DelRecord(strzxClassificationId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewsClassificationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxClassificationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ViewsClassificationENS">源对象</param>
 /// <param name = "objzx_ViewsClassificationENT">目标对象</param>
 public static void CopyTo(clszx_ViewsClassificationEN objzx_ViewsClassificationENS, clszx_ViewsClassificationEN objzx_ViewsClassificationENT)
{
try
{
objzx_ViewsClassificationENT.zxClassificationId = objzx_ViewsClassificationENS.zxClassificationId; //分类Id
objzx_ViewsClassificationENT.ClassificationName = objzx_ViewsClassificationENS.ClassificationName; //分类名称
objzx_ViewsClassificationENT.GroupTextId = objzx_ViewsClassificationENS.GroupTextId; //小组Id
objzx_ViewsClassificationENT.UpdDate = objzx_ViewsClassificationENS.UpdDate; //修改日期
objzx_ViewsClassificationENT.UpdUser = objzx_ViewsClassificationENS.UpdUser; //修改人
objzx_ViewsClassificationENT.Memo = objzx_ViewsClassificationENS.Memo; //备注
objzx_ViewsClassificationENT.OrderNum = objzx_ViewsClassificationENS.OrderNum; //序号
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
 /// <param name = "objzx_ViewsClassificationEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
try
{
objzx_ViewsClassificationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ViewsClassificationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ViewsClassification.zxClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewsClassificationEN.zxClassificationId = objzx_ViewsClassificationEN.zxClassificationId; //分类Id
}
if (arrFldSet.Contains(conzx_ViewsClassification.ClassificationName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewsClassificationEN.ClassificationName = objzx_ViewsClassificationEN.ClassificationName == "[null]" ? null :  objzx_ViewsClassificationEN.ClassificationName; //分类名称
}
if (arrFldSet.Contains(conzx_ViewsClassification.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewsClassificationEN.GroupTextId = objzx_ViewsClassificationEN.GroupTextId == "[null]" ? null :  objzx_ViewsClassificationEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(conzx_ViewsClassification.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewsClassificationEN.UpdDate = objzx_ViewsClassificationEN.UpdDate == "[null]" ? null :  objzx_ViewsClassificationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ViewsClassification.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewsClassificationEN.UpdUser = objzx_ViewsClassificationEN.UpdUser == "[null]" ? null :  objzx_ViewsClassificationEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_ViewsClassification.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewsClassificationEN.Memo = objzx_ViewsClassificationEN.Memo == "[null]" ? null :  objzx_ViewsClassificationEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_ViewsClassification.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewsClassificationEN.OrderNum = objzx_ViewsClassificationEN.OrderNum; //序号
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
 /// <param name = "objzx_ViewsClassificationEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
try
{
if (objzx_ViewsClassificationEN.ClassificationName == "[null]") objzx_ViewsClassificationEN.ClassificationName = null; //分类名称
if (objzx_ViewsClassificationEN.GroupTextId == "[null]") objzx_ViewsClassificationEN.GroupTextId = null; //小组Id
if (objzx_ViewsClassificationEN.UpdDate == "[null]") objzx_ViewsClassificationEN.UpdDate = null; //修改日期
if (objzx_ViewsClassificationEN.UpdUser == "[null]") objzx_ViewsClassificationEN.UpdUser = null; //修改人
if (objzx_ViewsClassificationEN.Memo == "[null]") objzx_ViewsClassificationEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 zx_ViewsClassificationDA.CheckPropertyNew(objzx_ViewsClassificationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
 zx_ViewsClassificationDA.CheckProperty4Condition(objzx_ViewsClassificationEN);
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
if (clszx_ViewsClassificationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ViewsClassificationBL没有刷新缓存机制(clszx_ViewsClassificationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxClassificationId");
//if (arrzx_ViewsClassificationObjLstCache == null)
//{
//arrzx_ViewsClassificationObjLstCache = zx_ViewsClassificationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxClassificationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewsClassificationEN GetObjByzxClassificationIdCache(string strzxClassificationId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ViewsClassificationEN._CurrTabName);
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjLst_Sel =
arrzx_ViewsClassificationObjLstCache
.Where(x=> x.zxClassificationId == strzxClassificationId 
);
if (arrzx_ViewsClassificationObjLst_Sel.Count() == 0)
{
   clszx_ViewsClassificationEN obj = clszx_ViewsClassificationBL.GetObjByzxClassificationId(strzxClassificationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ViewsClassificationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewsClassificationEN> GetAllzx_ViewsClassificationObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjLstCache = GetObjLstCache(); 
return arrzx_ViewsClassificationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewsClassificationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ViewsClassificationEN._CurrTabName);
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ViewsClassificationObjLstCache;
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
string strKey = string.Format("{0}", clszx_ViewsClassificationEN._CurrTabName);
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
if (clszx_ViewsClassificationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ViewsClassificationEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ViewsClassificationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ViewsClassification(中学各观点分类表)
 /// 唯一性条件:ClassificationName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ViewsClassificationEN objzx_ViewsClassificationEN)
{
//检测记录是否存在
string strResult = zx_ViewsClassificationDA.GetUniCondStr(objzx_ViewsClassificationEN);
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
public static string Func(string strInFldName, string strOutFldName, string strzxClassificationId)
{
if (strInFldName != conzx_ViewsClassification.zxClassificationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ViewsClassification.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ViewsClassification.AttributeName));
throw new Exception(strMsg);
}
var objzx_ViewsClassification = clszx_ViewsClassificationBL.GetObjByzxClassificationIdCache(strzxClassificationId);
if (objzx_ViewsClassification == null) return "";
return objzx_ViewsClassification[strOutFldName].ToString();
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
int intRecCount = clszx_ViewsClassificationDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ViewsClassificationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ViewsClassificationDA.GetRecCount();
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
int intRecCount = clszx_ViewsClassificationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ViewsClassificationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ViewsClassificationEN objzx_ViewsClassificationCond)
{
List<clszx_ViewsClassificationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewsClassificationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewsClassification.AttributeName)
{
if (objzx_ViewsClassificationCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewsClassificationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewsClassificationCond[strFldName].ToString());
}
else
{
if (objzx_ViewsClassificationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewsClassificationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewsClassificationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewsClassificationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewsClassificationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewsClassificationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewsClassificationCond[strFldName]));
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
 List<string> arrList = clszx_ViewsClassificationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewsClassificationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewsClassificationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ViewsClassificationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewsClassificationDA.SetFldValue(clszx_ViewsClassificationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ViewsClassificationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewsClassificationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewsClassificationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewsClassificationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ViewsClassification] "); 
 strCreateTabCode.Append(" ( "); 
 // /**分类Id*/ 
 strCreateTabCode.Append(" zxClassificationId char(10) primary key, "); 
 // /**分类名称*/ 
 strCreateTabCode.Append(" ClassificationName varchar(200) Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conzx_ViewsClassification.OrderNum); 
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjList = new clszx_ViewsClassificationDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_ViewsClassificationEN objzx_ViewsClassification in arrzx_ViewsClassificationObjList)
{
objzx_ViewsClassification.OrderNum = intIndex;
UpdateBySql2(objzx_ViewsClassification);
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
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strzxClassificationId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strzxClassificationId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[zxClassificationId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字zxClassificationId
//5、把当前关键字zxClassificationId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字zxClassificationId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevzxClassificationId = "";    //上一条序号的关键字zxClassificationId
string strNextzxClassificationId = "";    //下一条序号的关键字zxClassificationId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[zxClassificationId],获取相应的序号[OrderNum]。

clszx_ViewsClassificationEN objzx_ViewsClassification = clszx_ViewsClassificationBL.GetObjByzxClassificationId(strzxClassificationId);

intOrderNum = objzx_ViewsClassification.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clszx_ViewsClassificationBL.GetRecCountByCond(clszx_ViewsClassificationEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conzx_ViewsClassification.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字zxClassificationId
strPrevzxClassificationId = clszx_ViewsClassificationBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevzxClassificationId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字zxClassificationId所对应记录的序号减1
//6、把下(上)一个序号关键字zxClassificationId所对应的记录序号加1
clszx_ViewsClassificationBL.SetFldValue(clszx_ViewsClassificationEN._CurrTabName, conzx_ViewsClassification.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conzx_ViewsClassification.zxClassificationId, strzxClassificationId));
clszx_ViewsClassificationBL.SetFldValue(clszx_ViewsClassificationEN._CurrTabName, conzx_ViewsClassification.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conzx_ViewsClassification.zxClassificationId, strPrevzxClassificationId));
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

//4、获取下一个序号字段的关键字zxClassificationId
strCondition.AppendFormat(" {0} = {1}", conzx_ViewsClassification.OrderNum, intOrderNum + 1);

strNextzxClassificationId = clszx_ViewsClassificationBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextzxClassificationId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字zxClassificationId所对应记录的序号加1
//6、把下(上)一个序号关键字zxClassificationId所对应的记录序号减1
clszx_ViewsClassificationBL.SetFldValue(clszx_ViewsClassificationEN._CurrTabName, conzx_ViewsClassification.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conzx_ViewsClassification.zxClassificationId, strzxClassificationId));
clszx_ViewsClassificationBL.SetFldValue(clszx_ViewsClassificationEN._CurrTabName, conzx_ViewsClassification.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conzx_ViewsClassification.zxClassificationId, strNextzxClassificationId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clszx_ViewsClassificationBL.ReFreshCache();
if (clszx_ViewsClassificationBL.relatedActions != null)
{
clszx_ViewsClassificationBL.relatedActions.UpdRelaTabDate(objzx_ViewsClassification.zxClassificationId, "UpdRelaTabDate");
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
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conzx_ViewsClassification.zxClassificationId, strKeyList);
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationLst = GetObjLst(strCondition);
foreach (clszx_ViewsClassificationEN objzx_ViewsClassification in arrzx_ViewsClassificationLst)
{
objzx_ViewsClassification.OrderNum = objzx_ViewsClassification.OrderNum + 10000;
UpdateBySql2(objzx_ViewsClassification);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_ViewsClassification.OrderNum); 
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjList = new clszx_ViewsClassificationDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_ViewsClassificationEN objzx_ViewsClassification in arrzx_ViewsClassificationObjList)
{
objzx_ViewsClassification.OrderNum = intIndex;
UpdateBySql2(objzx_ViewsClassification);
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
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conzx_ViewsClassification.zxClassificationId, strKeyList);
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationLst = GetObjLst(strCondition);
foreach (clszx_ViewsClassificationEN objzx_ViewsClassification in arrzx_ViewsClassificationLst)
{
objzx_ViewsClassification.OrderNum = objzx_ViewsClassification.OrderNum - 10000;
UpdateBySql2(objzx_ViewsClassification);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_ViewsClassification.OrderNum); 
List<clszx_ViewsClassificationEN> arrzx_ViewsClassificationObjList = new clszx_ViewsClassificationDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_ViewsClassificationEN objzx_ViewsClassification in arrzx_ViewsClassificationObjList)
{
objzx_ViewsClassification.OrderNum = intIndex;
UpdateBySql2(objzx_ViewsClassification);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 中学各观点分类表(zx_ViewsClassification)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ViewsClassification : clsCommFun4BL
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
clszx_ViewsClassificationBL.ReFreshThisCache();
}
}

}