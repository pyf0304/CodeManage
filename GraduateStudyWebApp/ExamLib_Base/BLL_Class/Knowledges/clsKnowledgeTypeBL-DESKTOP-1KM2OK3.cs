
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeTypeBL
 表名:KnowledgeType(01120890)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 17:17:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsKnowledgeTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeTypeEN GetObj(this K_KnowledgeTypeId_KnowledgeType myKey)
{
clsKnowledgeTypeEN objKnowledgeTypeEN = clsKnowledgeTypeBL.KnowledgeTypeDA.GetObjByKnowledgeTypeId(myKey.Value);
return objKnowledgeTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
if (CheckUniqueness(objKnowledgeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点类型名 = [{0}],课程Id = [{1}]的数据已经存在!(in clsKnowledgeTypeBL.AddNewRecord)", objKnowledgeTypeEN.KnowledgeTypeName,objKnowledgeTypeEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true || clsKnowledgeTypeBL.IsExist(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
     objKnowledgeTypeEN.KnowledgeTypeId = clsKnowledgeTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsKnowledgeTypeBL.KnowledgeTypeDA.AddNewRecordBySQL2(objKnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsKnowledgeTypeBL.IsExist(objKnowledgeTypeEN.KnowledgeTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objKnowledgeTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objKnowledgeTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(知识点类型名(KnowledgeTypeName)=[{0}],课程Id(CourseId)=[{1}])已经存在,不能重复!", objKnowledgeTypeEN.KnowledgeTypeName, objKnowledgeTypeEN.CourseId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true || clsKnowledgeTypeBL.IsExist(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
     objKnowledgeTypeEN.KnowledgeTypeId = clsKnowledgeTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objKnowledgeTypeEN.AddNewRecord();
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
if (CheckUniqueness(objKnowledgeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点类型名 = [{0}],课程Id = [{1}]的数据已经存在!(in clsKnowledgeTypeBL.AddNewRecordWithMaxId)", objKnowledgeTypeEN.KnowledgeTypeName,objKnowledgeTypeEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true || clsKnowledgeTypeBL.IsExist(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
     objKnowledgeTypeEN.KnowledgeTypeId = clsKnowledgeTypeBL.GetMaxStrId_S();
 }
string strKnowledgeTypeId = clsKnowledgeTypeBL.KnowledgeTypeDA.AddNewRecordBySQL2WithReturnKey(objKnowledgeTypeEN);
     objKnowledgeTypeEN.KnowledgeTypeId = strKnowledgeTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
}
return strKnowledgeTypeId;
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
if (CheckUniqueness(objKnowledgeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点类型名 = [{0}],课程Id = [{1}]的数据已经存在!(in clsKnowledgeTypeBL.AddNewRecordWithReturnKey)", objKnowledgeTypeEN.KnowledgeTypeName,objKnowledgeTypeEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true || clsKnowledgeTypeBL.IsExist(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
     objKnowledgeTypeEN.KnowledgeTypeId = clsKnowledgeTypeBL.GetMaxStrId_S();
 }
string strKey = clsKnowledgeTypeBL.KnowledgeTypeDA.AddNewRecordBySQL2WithReturnKey(objKnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeTypeEN SetKnowledgeTypeId(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strKnowledgeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTypeId, 4, conKnowledgeType.KnowledgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeTypeId, 4, conKnowledgeType.KnowledgeTypeId);
}
objKnowledgeTypeEN.KnowledgeTypeId = strKnowledgeTypeId; //知识点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeType.KnowledgeTypeId) == false)
{
objKnowledgeTypeEN.dicFldComparisonOp.Add(conKnowledgeType.KnowledgeTypeId, strComparisonOp);
}
else
{
objKnowledgeTypeEN.dicFldComparisonOp[conKnowledgeType.KnowledgeTypeId] = strComparisonOp;
}
}
return objKnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeTypeEN SetKnowledgeTypeName(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strKnowledgeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeTypeName, conKnowledgeType.KnowledgeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTypeName, 50, conKnowledgeType.KnowledgeTypeName);
}
objKnowledgeTypeEN.KnowledgeTypeName = strKnowledgeTypeName; //知识点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeType.KnowledgeTypeName) == false)
{
objKnowledgeTypeEN.dicFldComparisonOp.Add(conKnowledgeType.KnowledgeTypeName, strComparisonOp);
}
else
{
objKnowledgeTypeEN.dicFldComparisonOp[conKnowledgeType.KnowledgeTypeName] = strComparisonOp;
}
}
return objKnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeTypeEN SetCourseId(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conKnowledgeType.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conKnowledgeType.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conKnowledgeType.CourseId);
}
objKnowledgeTypeEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeType.CourseId) == false)
{
objKnowledgeTypeEN.dicFldComparisonOp.Add(conKnowledgeType.CourseId, strComparisonOp);
}
else
{
objKnowledgeTypeEN.dicFldComparisonOp[conKnowledgeType.CourseId] = strComparisonOp;
}
}
return objKnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeTypeEN SetOrderNum(this clsKnowledgeTypeEN objKnowledgeTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objKnowledgeTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeType.OrderNum) == false)
{
objKnowledgeTypeEN.dicFldComparisonOp.Add(conKnowledgeType.OrderNum, strComparisonOp);
}
else
{
objKnowledgeTypeEN.dicFldComparisonOp[conKnowledgeType.OrderNum] = strComparisonOp;
}
}
return objKnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeTypeEN SetUpdDate(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conKnowledgeType.UpdDate);
}
objKnowledgeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeType.UpdDate) == false)
{
objKnowledgeTypeEN.dicFldComparisonOp.Add(conKnowledgeType.UpdDate, strComparisonOp);
}
else
{
objKnowledgeTypeEN.dicFldComparisonOp[conKnowledgeType.UpdDate] = strComparisonOp;
}
}
return objKnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeTypeEN SetUpdUser(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conKnowledgeType.UpdUser);
}
objKnowledgeTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeType.UpdUser) == false)
{
objKnowledgeTypeEN.dicFldComparisonOp.Add(conKnowledgeType.UpdUser, strComparisonOp);
}
else
{
objKnowledgeTypeEN.dicFldComparisonOp[conKnowledgeType.UpdUser] = strComparisonOp;
}
}
return objKnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsKnowledgeTypeEN SetMemo(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conKnowledgeType.Memo);
}
objKnowledgeTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeType.Memo) == false)
{
objKnowledgeTypeEN.dicFldComparisonOp.Add(conKnowledgeType.Memo, strComparisonOp);
}
else
{
objKnowledgeTypeEN.dicFldComparisonOp[conKnowledgeType.Memo] = strComparisonOp;
}
}
return objKnowledgeTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objKnowledgeTypeEN.CheckPropertyNew();
clsKnowledgeTypeEN objKnowledgeTypeCond = new clsKnowledgeTypeEN();
string strCondition = objKnowledgeTypeCond
.SetKnowledgeTypeId(objKnowledgeTypeEN.KnowledgeTypeId, "<>")
.SetKnowledgeTypeName(objKnowledgeTypeEN.KnowledgeTypeName, "=")
.SetCourseId(objKnowledgeTypeEN.CourseId, "=")
.GetCombineCondition();
objKnowledgeTypeEN._IsCheckProperty = true;
bool bolIsExist = clsKnowledgeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(KnowledgeTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objKnowledgeTypeEN.Update();
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
 /// <param name = "objKnowledgeType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsKnowledgeTypeEN objKnowledgeType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsKnowledgeTypeEN objKnowledgeTypeCond = new clsKnowledgeTypeEN();
string strCondition = objKnowledgeTypeCond
.SetKnowledgeTypeName(objKnowledgeType.KnowledgeTypeName, "=")
.SetCourseId(objKnowledgeType.CourseId, "=")
.GetCombineCondition();
objKnowledgeType._IsCheckProperty = true;
bool bolIsExist = clsKnowledgeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objKnowledgeType.KnowledgeTypeId = clsKnowledgeTypeBL.GetFirstID_S(strCondition);
objKnowledgeType.UpdateWithCondition(strCondition);
}
else
{
objKnowledgeType.KnowledgeTypeId = clsKnowledgeTypeBL.GetMaxStrId_S();
objKnowledgeType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsKnowledgeTypeBL.KnowledgeTypeDA.UpdateBySql2(objKnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeTypeEN objKnowledgeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsKnowledgeTypeBL.KnowledgeTypeDA.UpdateBySql2(objKnowledgeTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsKnowledgeTypeBL.KnowledgeTypeDA.UpdateBySqlWithCondition(objKnowledgeTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeTypeEN objKnowledgeTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsKnowledgeTypeBL.KnowledgeTypeDA.UpdateBySqlWithConditionTransaction(objKnowledgeTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
try
{
int intRecNum = clsKnowledgeTypeBL.KnowledgeTypeDA.DelRecord(objKnowledgeTypeEN.KnowledgeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeENS">源对象</param>
 /// <param name = "objKnowledgeTypeENT">目标对象</param>
 public static void CopyTo(this clsKnowledgeTypeEN objKnowledgeTypeENS, clsKnowledgeTypeEN objKnowledgeTypeENT)
{
try
{
objKnowledgeTypeENT.KnowledgeTypeId = objKnowledgeTypeENS.KnowledgeTypeId; //知识点类型Id
objKnowledgeTypeENT.KnowledgeTypeName = objKnowledgeTypeENS.KnowledgeTypeName; //知识点类型名
objKnowledgeTypeENT.CourseId = objKnowledgeTypeENS.CourseId; //课程Id
objKnowledgeTypeENT.OrderNum = objKnowledgeTypeENS.OrderNum; //序号
objKnowledgeTypeENT.UpdDate = objKnowledgeTypeENS.UpdDate; //修改日期
objKnowledgeTypeENT.UpdUser = objKnowledgeTypeENS.UpdUser; //修改人
objKnowledgeTypeENT.Memo = objKnowledgeTypeENS.Memo; //备注
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
 /// <param name = "objKnowledgeTypeENS">源对象</param>
 /// <returns>目标对象=>clsKnowledgeTypeEN:objKnowledgeTypeENT</returns>
 public static clsKnowledgeTypeEN CopyTo(this clsKnowledgeTypeEN objKnowledgeTypeENS)
{
try
{
 clsKnowledgeTypeEN objKnowledgeTypeENT = new clsKnowledgeTypeEN()
{
KnowledgeTypeId = objKnowledgeTypeENS.KnowledgeTypeId, //知识点类型Id
KnowledgeTypeName = objKnowledgeTypeENS.KnowledgeTypeName, //知识点类型名
CourseId = objKnowledgeTypeENS.CourseId, //课程Id
OrderNum = objKnowledgeTypeENS.OrderNum, //序号
UpdDate = objKnowledgeTypeENS.UpdDate, //修改日期
UpdUser = objKnowledgeTypeENS.UpdUser, //修改人
Memo = objKnowledgeTypeENS.Memo, //备注
};
 return objKnowledgeTypeENT;
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
public static void CheckPropertyNew(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 clsKnowledgeTypeBL.KnowledgeTypeDA.CheckPropertyNew(objKnowledgeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 clsKnowledgeTypeBL.KnowledgeTypeDA.CheckProperty4Condition(objKnowledgeTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsKnowledgeTypeEN objKnowledgeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objKnowledgeTypeCond.IsUpdated(conKnowledgeType.KnowledgeTypeId) == true)
{
string strComparisonOpKnowledgeTypeId = objKnowledgeTypeCond.dicFldComparisonOp[conKnowledgeType.KnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeType.KnowledgeTypeId, objKnowledgeTypeCond.KnowledgeTypeId, strComparisonOpKnowledgeTypeId);
}
if (objKnowledgeTypeCond.IsUpdated(conKnowledgeType.KnowledgeTypeName) == true)
{
string strComparisonOpKnowledgeTypeName = objKnowledgeTypeCond.dicFldComparisonOp[conKnowledgeType.KnowledgeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeType.KnowledgeTypeName, objKnowledgeTypeCond.KnowledgeTypeName, strComparisonOpKnowledgeTypeName);
}
if (objKnowledgeTypeCond.IsUpdated(conKnowledgeType.CourseId) == true)
{
string strComparisonOpCourseId = objKnowledgeTypeCond.dicFldComparisonOp[conKnowledgeType.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeType.CourseId, objKnowledgeTypeCond.CourseId, strComparisonOpCourseId);
}
if (objKnowledgeTypeCond.IsUpdated(conKnowledgeType.OrderNum) == true)
{
string strComparisonOpOrderNum = objKnowledgeTypeCond.dicFldComparisonOp[conKnowledgeType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeType.OrderNum, objKnowledgeTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objKnowledgeTypeCond.IsUpdated(conKnowledgeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objKnowledgeTypeCond.dicFldComparisonOp[conKnowledgeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeType.UpdDate, objKnowledgeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objKnowledgeTypeCond.IsUpdated(conKnowledgeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objKnowledgeTypeCond.dicFldComparisonOp[conKnowledgeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeType.UpdUser, objKnowledgeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objKnowledgeTypeCond.IsUpdated(conKnowledgeType.Memo) == true)
{
string strComparisonOpMemo = objKnowledgeTypeCond.dicFldComparisonOp[conKnowledgeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeType.Memo, objKnowledgeTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--KnowledgeType(知识点类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseId_KnowledgeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeTypeEN == null) return true;
if (objKnowledgeTypeEN.KnowledgeTypeId == null || objKnowledgeTypeEN.KnowledgeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KnowledgeTypeName = '{0}'", objKnowledgeTypeEN.KnowledgeTypeName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objKnowledgeTypeEN.CourseId);
if (clsKnowledgeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("KnowledgeTypeId !=  '{0}'", objKnowledgeTypeEN.KnowledgeTypeId);
 sbCondition.AppendFormat(" and KnowledgeTypeName = '{0}'", objKnowledgeTypeEN.KnowledgeTypeName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objKnowledgeTypeEN.CourseId);
if (clsKnowledgeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--KnowledgeType(知识点类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseId_KnowledgeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeTypeEN == null) return "";
if (objKnowledgeTypeEN.KnowledgeTypeId == null || objKnowledgeTypeEN.KnowledgeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KnowledgeTypeName = '{0}'", objKnowledgeTypeEN.KnowledgeTypeName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objKnowledgeTypeEN.CourseId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("KnowledgeTypeId !=  '{0}'", objKnowledgeTypeEN.KnowledgeTypeId);
 sbCondition.AppendFormat(" and KnowledgeTypeName = '{0}'", objKnowledgeTypeEN.KnowledgeTypeName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objKnowledgeTypeEN.CourseId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_KnowledgeType
{
public virtual bool UpdRelaTabDate(string strKnowledgeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点类型(KnowledgeType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsKnowledgeTypeBL
{
public static RelatedActions_KnowledgeType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsKnowledgeTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsKnowledgeTypeDA KnowledgeTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsKnowledgeTypeDA();
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
 public clsKnowledgeTypeBL()
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
if (string.IsNullOrEmpty(clsKnowledgeTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsKnowledgeTypeEN._ConnectString);
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
public static DataTable GetDataTable_KnowledgeType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = KnowledgeTypeDA.GetDataTable_KnowledgeType(strWhereCond);
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
objDT = KnowledgeTypeDA.GetDataTable(strWhereCond);
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
objDT = KnowledgeTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = KnowledgeTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = KnowledgeTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = KnowledgeTypeDA.GetDataTable_Top(objTopPara);
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
objDT = KnowledgeTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = KnowledgeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = KnowledgeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrKnowledgeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsKnowledgeTypeEN> GetObjLstByKnowledgeTypeIdLst(List<string> arrKnowledgeTypeIdLst)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrKnowledgeTypeIdLst, true);
 string strWhereCond = string.Format("KnowledgeTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKnowledgeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsKnowledgeTypeEN> GetObjLstByKnowledgeTypeIdLstCache(List<string> arrKnowledgeTypeIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsKnowledgeTypeEN._CurrTabName, strCourseId);
List<clsKnowledgeTypeEN> arrKnowledgeTypeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeTypeEN> arrKnowledgeTypeObjLst_Sel =
arrKnowledgeTypeObjLstCache
.Where(x => arrKnowledgeTypeIdLst.Contains(x.KnowledgeTypeId));
return arrKnowledgeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeTypeEN> GetObjLst(string strWhereCond)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
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
public static List<clsKnowledgeTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objKnowledgeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsKnowledgeTypeEN> GetSubObjLstCache(clsKnowledgeTypeEN objKnowledgeTypeCond)
{
 string strCourseId = objKnowledgeTypeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsKnowledgeTypeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsKnowledgeTypeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conKnowledgeType.AttributeName)
{
if (objKnowledgeTypeCond.IsUpdated(strFldName) == false) continue;
if (objKnowledgeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeTypeCond[strFldName].ToString());
}
else
{
if (objKnowledgeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objKnowledgeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objKnowledgeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objKnowledgeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objKnowledgeTypeCond[strFldName]));
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
public static List<clsKnowledgeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
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
public static List<clsKnowledgeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
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
List<clsKnowledgeTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsKnowledgeTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsKnowledgeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
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
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
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
public static List<clsKnowledgeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsKnowledgeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsKnowledgeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
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
public static List<clsKnowledgeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsKnowledgeTypeEN> arrObjLst = new List<clsKnowledgeTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeTypeEN objKnowledgeTypeEN = new clsKnowledgeTypeEN();
try
{
objKnowledgeTypeEN.KnowledgeTypeId = objRow[conKnowledgeType.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objKnowledgeTypeEN.KnowledgeTypeName = objRow[conKnowledgeType.KnowledgeTypeName].ToString().Trim(); //知识点类型名
objKnowledgeTypeEN.CourseId = objRow[conKnowledgeType.CourseId].ToString().Trim(); //课程Id
objKnowledgeTypeEN.OrderNum = objRow[conKnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeType.OrderNum].ToString().Trim()); //序号
objKnowledgeTypeEN.UpdDate = objRow[conKnowledgeType.UpdDate] == DBNull.Value ? null : objRow[conKnowledgeType.UpdDate].ToString().Trim(); //修改日期
objKnowledgeTypeEN.UpdUser = objRow[conKnowledgeType.UpdUser] == DBNull.Value ? null : objRow[conKnowledgeType.UpdUser].ToString().Trim(); //修改人
objKnowledgeTypeEN.Memo = objRow[conKnowledgeType.Memo] == DBNull.Value ? null : objRow[conKnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objKnowledgeTypeEN.KnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objKnowledgeTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetKnowledgeType(ref clsKnowledgeTypeEN objKnowledgeTypeEN)
{
bool bolResult = KnowledgeTypeDA.GetKnowledgeType(ref objKnowledgeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeTypeEN GetObjByKnowledgeTypeId(string strKnowledgeTypeId)
{
if (strKnowledgeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strKnowledgeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strKnowledgeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strKnowledgeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsKnowledgeTypeEN objKnowledgeTypeEN = KnowledgeTypeDA.GetObjByKnowledgeTypeId(strKnowledgeTypeId);
return objKnowledgeTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsKnowledgeTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsKnowledgeTypeEN objKnowledgeTypeEN = KnowledgeTypeDA.GetFirstObj(strWhereCond);
 return objKnowledgeTypeEN;
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
public static clsKnowledgeTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsKnowledgeTypeEN objKnowledgeTypeEN = KnowledgeTypeDA.GetObjByDataRow(objRow);
 return objKnowledgeTypeEN;
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
public static clsKnowledgeTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsKnowledgeTypeEN objKnowledgeTypeEN = KnowledgeTypeDA.GetObjByDataRow(objRow);
 return objKnowledgeTypeEN;
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
 /// <param name = "strKnowledgeTypeId">所给的关键字</param>
 /// <param name = "lstKnowledgeTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsKnowledgeTypeEN GetObjByKnowledgeTypeIdFromList(string strKnowledgeTypeId, List<clsKnowledgeTypeEN> lstKnowledgeTypeObjLst)
{
foreach (clsKnowledgeTypeEN objKnowledgeTypeEN in lstKnowledgeTypeObjLst)
{
if (objKnowledgeTypeEN.KnowledgeTypeId == strKnowledgeTypeId)
{
return objKnowledgeTypeEN;
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
 string strMaxKnowledgeTypeId;
 try
 {
 strMaxKnowledgeTypeId = clsKnowledgeTypeDA.GetMaxStrId();
 return strMaxKnowledgeTypeId;
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
 string strKnowledgeTypeId;
 try
 {
 strKnowledgeTypeId = new clsKnowledgeTypeDA().GetFirstID(strWhereCond);
 return strKnowledgeTypeId;
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
 arrList = KnowledgeTypeDA.GetID(strWhereCond);
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
bool bolIsExist = KnowledgeTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strKnowledgeTypeId)
{
if (string.IsNullOrEmpty(strKnowledgeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strKnowledgeTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = KnowledgeTypeDA.IsExist(strKnowledgeTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strKnowledgeTypeId">知识点类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strKnowledgeTypeId, string strOpUser)
{
clsKnowledgeTypeEN objKnowledgeTypeEN = clsKnowledgeTypeBL.GetObjByKnowledgeTypeId(strKnowledgeTypeId);
objKnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objKnowledgeTypeEN.UpdUser = strOpUser;
return clsKnowledgeTypeBL.UpdateBySql2(objKnowledgeTypeEN);
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
 bolIsExist = clsKnowledgeTypeDA.IsExistTable();
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
 bolIsExist = KnowledgeTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
if (objKnowledgeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点类型名 = [{0}],课程Id = [{1}]的数据已经存在!(in clsKnowledgeTypeBL.AddNewRecordBySql2)", objKnowledgeTypeEN.KnowledgeTypeName,objKnowledgeTypeEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true || clsKnowledgeTypeBL.IsExist(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
     objKnowledgeTypeEN.KnowledgeTypeId = clsKnowledgeTypeBL.GetMaxStrId_S();
 }
bool bolResult = KnowledgeTypeDA.AddNewRecordBySQL2(objKnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
if (objKnowledgeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点类型名 = [{0}],课程Id = [{1}]的数据已经存在!(in clsKnowledgeTypeBL.AddNewRecordBySql2WithReturnKey)", objKnowledgeTypeEN.KnowledgeTypeName,objKnowledgeTypeEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true || clsKnowledgeTypeBL.IsExist(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
     objKnowledgeTypeEN.KnowledgeTypeId = clsKnowledgeTypeBL.GetMaxStrId_S();
 }
string strKey = KnowledgeTypeDA.AddNewRecordBySQL2WithReturnKey(objKnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
try
{
bool bolResult = KnowledgeTypeDA.Update(objKnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "objKnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 if (string.IsNullOrEmpty(objKnowledgeTypeEN.KnowledgeTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = KnowledgeTypeDA.UpdateBySql2(objKnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeTypeBL.ReFreshCache(objKnowledgeTypeEN.CourseId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
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
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strKnowledgeTypeId)
{
try
{
 clsKnowledgeTypeEN objKnowledgeTypeEN = clsKnowledgeTypeBL.GetObjByKnowledgeTypeId(strKnowledgeTypeId);

if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(objKnowledgeTypeEN.KnowledgeTypeId, objKnowledgeTypeEN.UpdUser);
}
if (objKnowledgeTypeEN != null)
{
int intRecNum = KnowledgeTypeDA.DelRecord(strKnowledgeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objKnowledgeTypeEN.CourseId);
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
/// <param name="strKnowledgeTypeId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strKnowledgeTypeId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
//删除与表:[KnowledgeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conKnowledgeType.KnowledgeTypeId,
//strKnowledgeTypeId);
//        clsKnowledgeTypeBL.DelKnowledgeTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsKnowledgeTypeBL.DelRecord(strKnowledgeTypeId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsKnowledgeTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKnowledgeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strKnowledgeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strKnowledgeTypeId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsKnowledgeTypeBL.relatedActions != null)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(strKnowledgeTypeId, "UpdRelaTabDate");
}
bool bolResult = KnowledgeTypeDA.DelRecord(strKnowledgeTypeId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrKnowledgeTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelKnowledgeTypes(List<string> arrKnowledgeTypeIdLst)
{
if (arrKnowledgeTypeIdLst.Count == 0) return 0;
try
{
if (clsKnowledgeTypeBL.relatedActions != null)
{
foreach (var strKnowledgeTypeId in arrKnowledgeTypeIdLst)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(strKnowledgeTypeId, "UpdRelaTabDate");
}
}
 clsKnowledgeTypeEN objKnowledgeTypeEN = clsKnowledgeTypeBL.GetObjByKnowledgeTypeId(arrKnowledgeTypeIdLst[0]);
int intDelRecNum = KnowledgeTypeDA.DelKnowledgeType(arrKnowledgeTypeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objKnowledgeTypeEN.CourseId);
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
public static int DelKnowledgeTypesByCond(string strWhereCond)
{
try
{
if (clsKnowledgeTypeBL.relatedActions != null)
{
List<string> arrKnowledgeTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strKnowledgeTypeId in arrKnowledgeTypeId)
{
clsKnowledgeTypeBL.relatedActions.UpdRelaTabDate(strKnowledgeTypeId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conKnowledgeType.CourseId, strWhereCond);
int intRecNum = KnowledgeTypeDA.DelKnowledgeType(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[KnowledgeType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strKnowledgeTypeId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strKnowledgeTypeId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsKnowledgeTypeDA.GetSpecSQLObj();
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
//删除与表:[KnowledgeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsKnowledgeTypeBL.DelRecord(strKnowledgeTypeId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsKnowledgeTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKnowledgeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objKnowledgeTypeENS">源对象</param>
 /// <param name = "objKnowledgeTypeENT">目标对象</param>
 public static void CopyTo(clsKnowledgeTypeEN objKnowledgeTypeENS, clsKnowledgeTypeEN objKnowledgeTypeENT)
{
try
{
objKnowledgeTypeENT.KnowledgeTypeId = objKnowledgeTypeENS.KnowledgeTypeId; //知识点类型Id
objKnowledgeTypeENT.KnowledgeTypeName = objKnowledgeTypeENS.KnowledgeTypeName; //知识点类型名
objKnowledgeTypeENT.CourseId = objKnowledgeTypeENS.CourseId; //课程Id
objKnowledgeTypeENT.OrderNum = objKnowledgeTypeENS.OrderNum; //序号
objKnowledgeTypeENT.UpdDate = objKnowledgeTypeENS.UpdDate; //修改日期
objKnowledgeTypeENT.UpdUser = objKnowledgeTypeENS.UpdUser; //修改人
objKnowledgeTypeENT.Memo = objKnowledgeTypeENS.Memo; //备注
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
 /// <param name = "objKnowledgeTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
try
{
objKnowledgeTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objKnowledgeTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conKnowledgeType.KnowledgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeTypeEN.KnowledgeTypeId = objKnowledgeTypeEN.KnowledgeTypeId; //知识点类型Id
}
if (arrFldSet.Contains(conKnowledgeType.KnowledgeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeTypeEN.KnowledgeTypeName = objKnowledgeTypeEN.KnowledgeTypeName; //知识点类型名
}
if (arrFldSet.Contains(conKnowledgeType.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeTypeEN.CourseId = objKnowledgeTypeEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conKnowledgeType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeTypeEN.OrderNum = objKnowledgeTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conKnowledgeType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeTypeEN.UpdDate = objKnowledgeTypeEN.UpdDate == "[null]" ? null :  objKnowledgeTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conKnowledgeType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeTypeEN.UpdUser = objKnowledgeTypeEN.UpdUser == "[null]" ? null :  objKnowledgeTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conKnowledgeType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objKnowledgeTypeEN.Memo = objKnowledgeTypeEN.Memo == "[null]" ? null :  objKnowledgeTypeEN.Memo; //备注
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
 /// <param name = "objKnowledgeTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
try
{
if (objKnowledgeTypeEN.UpdDate == "[null]") objKnowledgeTypeEN.UpdDate = null; //修改日期
if (objKnowledgeTypeEN.UpdUser == "[null]") objKnowledgeTypeEN.UpdUser = null; //修改人
if (objKnowledgeTypeEN.Memo == "[null]") objKnowledgeTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 KnowledgeTypeDA.CheckPropertyNew(objKnowledgeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
 KnowledgeTypeDA.CheckProperty4Condition(objKnowledgeTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_KnowledgeTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点类型]...","0");
List<clsKnowledgeTypeEN> arrKnowledgeTypeObjLst = GetAllKnowledgeTypeObjLstCache(strCourseId); 
objDDL.DataValueField = conKnowledgeType.KnowledgeTypeId;
objDDL.DataTextField = conKnowledgeType.KnowledgeTypeName;
objDDL.DataSource = arrKnowledgeTypeObjLst;
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
if (clsKnowledgeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeTypeBL没有刷新缓存机制(clsKnowledgeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by KnowledgeTypeId");
//if (arrKnowledgeTypeObjLstCache == null)
//{
//arrKnowledgeTypeObjLstCache = KnowledgeTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsKnowledgeTypeEN GetObjByKnowledgeTypeIdCache(string strKnowledgeTypeId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsKnowledgeTypeEN._CurrTabName, strCourseId);
List<clsKnowledgeTypeEN> arrKnowledgeTypeObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeTypeEN> arrKnowledgeTypeObjLst_Sel =
arrKnowledgeTypeObjLstCache
.Where(x=> x.KnowledgeTypeId == strKnowledgeTypeId 
);
if (arrKnowledgeTypeObjLst_Sel.Count() == 0)
{
   clsKnowledgeTypeEN obj = clsKnowledgeTypeBL.GetObjByKnowledgeTypeId(strKnowledgeTypeId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strKnowledgeTypeId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrKnowledgeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKnowledgeTypeNameByKnowledgeTypeIdCache(string strKnowledgeTypeId, string strCourseId)
{
if (string.IsNullOrEmpty(strKnowledgeTypeId) == true) return "";
//获取缓存中的对象列表
clsKnowledgeTypeEN objKnowledgeType = GetObjByKnowledgeTypeIdCache(strKnowledgeTypeId, strCourseId);
if (objKnowledgeType == null) return "";
return objKnowledgeType.KnowledgeTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByKnowledgeTypeIdCache(string strKnowledgeTypeId, string strCourseId)
{
if (string.IsNullOrEmpty(strKnowledgeTypeId) == true) return "";
//获取缓存中的对象列表
clsKnowledgeTypeEN objKnowledgeType = GetObjByKnowledgeTypeIdCache(strKnowledgeTypeId, strCourseId);
if (objKnowledgeType == null) return "";
return objKnowledgeType.KnowledgeTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeTypeEN> GetAllKnowledgeTypeObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsKnowledgeTypeEN> arrKnowledgeTypeObjLstCache = GetObjLstCache(strCourseId); 
return arrKnowledgeTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeTypeEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsKnowledgeTypeEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsKnowledgeTypeEN> arrKnowledgeTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrKnowledgeTypeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsKnowledgeTypeEN._CurrTabName, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsKnowledgeTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsKnowledgeTypeEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsKnowledgeTypeBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--KnowledgeType(知识点类型)
 /// 唯一性条件:CourseId_KnowledgeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objKnowledgeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsKnowledgeTypeEN objKnowledgeTypeEN)
{
//检测记录是否存在
string strResult = KnowledgeTypeDA.GetUniCondStr(objKnowledgeTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strKnowledgeTypeId, string strCourseId)
{
if (strInFldName != conKnowledgeType.KnowledgeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conKnowledgeType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conKnowledgeType.AttributeName));
throw new Exception(strMsg);
}
var objKnowledgeType = clsKnowledgeTypeBL.GetObjByKnowledgeTypeIdCache(strKnowledgeTypeId, strCourseId);
if (objKnowledgeType == null) return "";
return objKnowledgeType[strOutFldName].ToString();
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
int intRecCount = clsKnowledgeTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsKnowledgeTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsKnowledgeTypeDA.GetRecCount();
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
int intRecCount = clsKnowledgeTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objKnowledgeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsKnowledgeTypeEN objKnowledgeTypeCond)
{
 string strCourseId = objKnowledgeTypeCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsKnowledgeTypeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsKnowledgeTypeEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsKnowledgeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conKnowledgeType.AttributeName)
{
if (objKnowledgeTypeCond.IsUpdated(strFldName) == false) continue;
if (objKnowledgeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeTypeCond[strFldName].ToString());
}
else
{
if (objKnowledgeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objKnowledgeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objKnowledgeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objKnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objKnowledgeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objKnowledgeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objKnowledgeTypeCond[strFldName]));
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
 List<string> arrList = clsKnowledgeTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = KnowledgeTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = KnowledgeTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = KnowledgeTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsKnowledgeTypeDA.SetFldValue(clsKnowledgeTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = KnowledgeTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsKnowledgeTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsKnowledgeTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsKnowledgeTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[KnowledgeType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**知识点类型Id*/ 
 strCreateTabCode.Append(" KnowledgeTypeId char(4) primary key, "); 
 // /**知识点类型名*/ 
 strCreateTabCode.Append(" KnowledgeTypeName varchar(50) not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 知识点类型(KnowledgeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4KnowledgeType : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsKnowledgeTypeBL.ReFreshThisCache(strCourseId);
}
}

}