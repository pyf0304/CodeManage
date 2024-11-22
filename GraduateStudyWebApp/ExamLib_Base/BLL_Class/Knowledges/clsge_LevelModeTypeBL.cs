
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_LevelModeTypeBL
 表名:ge_LevelModeType(01120907)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsge_LevelModeTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strLevelModeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_LevelModeTypeEN GetObj(this K_LevelModeTypeId_ge_LevelModeType myKey)
{
clsge_LevelModeTypeEN objge_LevelModeTypeEN = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.GetObjByLevelModeTypeId(myKey.Value);
return objge_LevelModeTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_LevelModeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!模式名 = [{0}]的数据已经存在!(in clsge_LevelModeTypeBL.AddNewRecord)", objge_LevelModeTypeEN.LevelModeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true || clsge_LevelModeTypeBL.IsExist(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
     objge_LevelModeTypeEN.LevelModeTypeId = clsge_LevelModeTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.AddNewRecordBySQL2(objge_LevelModeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_LevelModeTypeBL.IsExist(objge_LevelModeTypeEN.LevelModeTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_LevelModeTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_LevelModeTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(模式名(LevelModeTypeName)=[{0}])已经存在,不能重复!", objge_LevelModeTypeEN.LevelModeTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true || clsge_LevelModeTypeBL.IsExist(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
     objge_LevelModeTypeEN.LevelModeTypeId = clsge_LevelModeTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_LevelModeTypeEN.AddNewRecord();
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_LevelModeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!模式名 = [{0}]的数据已经存在!(in clsge_LevelModeTypeBL.AddNewRecordWithMaxId)", objge_LevelModeTypeEN.LevelModeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true || clsge_LevelModeTypeBL.IsExist(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
     objge_LevelModeTypeEN.LevelModeTypeId = clsge_LevelModeTypeBL.GetMaxStrId_S();
 }
string strLevelModeTypeId = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.AddNewRecordBySQL2WithReturnKey(objge_LevelModeTypeEN);
     objge_LevelModeTypeEN.LevelModeTypeId = strLevelModeTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
}
return strLevelModeTypeId;
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_LevelModeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!模式名 = [{0}]的数据已经存在!(in clsge_LevelModeTypeBL.AddNewRecordWithReturnKey)", objge_LevelModeTypeEN.LevelModeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true || clsge_LevelModeTypeBL.IsExist(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
     objge_LevelModeTypeEN.LevelModeTypeId = clsge_LevelModeTypeBL.GetMaxStrId_S();
 }
string strKey = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.AddNewRecordBySQL2WithReturnKey(objge_LevelModeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LevelModeTypeEN SetLevelModeTypeId(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strLevelModeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelModeTypeId, 2, conge_LevelModeType.LevelModeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelModeTypeId, 2, conge_LevelModeType.LevelModeTypeId);
}
objge_LevelModeTypeEN.LevelModeTypeId = strLevelModeTypeId; //模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LevelModeTypeEN.dicFldComparisonOp.ContainsKey(conge_LevelModeType.LevelModeTypeId) == false)
{
objge_LevelModeTypeEN.dicFldComparisonOp.Add(conge_LevelModeType.LevelModeTypeId, strComparisonOp);
}
else
{
objge_LevelModeTypeEN.dicFldComparisonOp[conge_LevelModeType.LevelModeTypeId] = strComparisonOp;
}
}
return objge_LevelModeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LevelModeTypeEN SetLevelModeTypeName(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strLevelModeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelModeTypeName, 100, conge_LevelModeType.LevelModeTypeName);
}
objge_LevelModeTypeEN.LevelModeTypeName = strLevelModeTypeName; //模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LevelModeTypeEN.dicFldComparisonOp.ContainsKey(conge_LevelModeType.LevelModeTypeName) == false)
{
objge_LevelModeTypeEN.dicFldComparisonOp.Add(conge_LevelModeType.LevelModeTypeName, strComparisonOp);
}
else
{
objge_LevelModeTypeEN.dicFldComparisonOp[conge_LevelModeType.LevelModeTypeName] = strComparisonOp;
}
}
return objge_LevelModeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LevelModeTypeEN SetLevelModeTypeENName(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strLevelModeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelModeTypeENName, 100, conge_LevelModeType.LevelModeTypeENName);
}
objge_LevelModeTypeEN.LevelModeTypeENName = strLevelModeTypeENName; //模式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LevelModeTypeEN.dicFldComparisonOp.ContainsKey(conge_LevelModeType.LevelModeTypeENName) == false)
{
objge_LevelModeTypeEN.dicFldComparisonOp.Add(conge_LevelModeType.LevelModeTypeENName, strComparisonOp);
}
else
{
objge_LevelModeTypeEN.dicFldComparisonOp[conge_LevelModeType.LevelModeTypeENName] = strComparisonOp;
}
}
return objge_LevelModeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LevelModeTypeEN SetUpdUser(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_LevelModeType.UpdUser);
}
objge_LevelModeTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LevelModeTypeEN.dicFldComparisonOp.ContainsKey(conge_LevelModeType.UpdUser) == false)
{
objge_LevelModeTypeEN.dicFldComparisonOp.Add(conge_LevelModeType.UpdUser, strComparisonOp);
}
else
{
objge_LevelModeTypeEN.dicFldComparisonOp[conge_LevelModeType.UpdUser] = strComparisonOp;
}
}
return objge_LevelModeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LevelModeTypeEN SetUpdDate(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_LevelModeType.UpdDate);
}
objge_LevelModeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LevelModeTypeEN.dicFldComparisonOp.ContainsKey(conge_LevelModeType.UpdDate) == false)
{
objge_LevelModeTypeEN.dicFldComparisonOp.Add(conge_LevelModeType.UpdDate, strComparisonOp);
}
else
{
objge_LevelModeTypeEN.dicFldComparisonOp[conge_LevelModeType.UpdDate] = strComparisonOp;
}
}
return objge_LevelModeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LevelModeTypeEN SetMemo(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_LevelModeType.Memo);
}
objge_LevelModeTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LevelModeTypeEN.dicFldComparisonOp.ContainsKey(conge_LevelModeType.Memo) == false)
{
objge_LevelModeTypeEN.dicFldComparisonOp.Add(conge_LevelModeType.Memo, strComparisonOp);
}
else
{
objge_LevelModeTypeEN.dicFldComparisonOp[conge_LevelModeType.Memo] = strComparisonOp;
}
}
return objge_LevelModeTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_LevelModeTypeEN.CheckPropertyNew();
clsge_LevelModeTypeEN objge_LevelModeTypeCond = new clsge_LevelModeTypeEN();
string strCondition = objge_LevelModeTypeCond
.SetLevelModeTypeId(objge_LevelModeTypeEN.LevelModeTypeId, "<>")
.SetLevelModeTypeName(objge_LevelModeTypeEN.LevelModeTypeName, "=")
.GetCombineCondition();
objge_LevelModeTypeEN._IsCheckProperty = true;
bool bolIsExist = clsge_LevelModeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(LevelModeTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_LevelModeTypeEN.Update();
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
 /// <param name = "objge_LevelModeType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_LevelModeTypeEN objge_LevelModeType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_LevelModeTypeEN objge_LevelModeTypeCond = new clsge_LevelModeTypeEN();
string strCondition = objge_LevelModeTypeCond
.SetLevelModeTypeName(objge_LevelModeType.LevelModeTypeName, "=")
.GetCombineCondition();
objge_LevelModeType._IsCheckProperty = true;
bool bolIsExist = clsge_LevelModeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_LevelModeType.LevelModeTypeId = clsge_LevelModeTypeBL.GetFirstID_S(strCondition);
objge_LevelModeType.UpdateWithCondition(strCondition);
}
else
{
objge_LevelModeType.LevelModeTypeId = clsge_LevelModeTypeBL.GetMaxStrId_S();
objge_LevelModeType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.UpdateBySql2(objge_LevelModeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.UpdateBySql2(objge_LevelModeTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.UpdateBySqlWithCondition(objge_LevelModeTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_LevelModeTypeEN objge_LevelModeTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.UpdateBySqlWithConditionTransaction(objge_LevelModeTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
try
{
int intRecNum = clsge_LevelModeTypeBL.ge_LevelModeTypeDA.DelRecord(objge_LevelModeTypeEN.LevelModeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeENS">源对象</param>
 /// <param name = "objge_LevelModeTypeENT">目标对象</param>
 public static void CopyTo(this clsge_LevelModeTypeEN objge_LevelModeTypeENS, clsge_LevelModeTypeEN objge_LevelModeTypeENT)
{
try
{
objge_LevelModeTypeENT.LevelModeTypeId = objge_LevelModeTypeENS.LevelModeTypeId; //模式Id
objge_LevelModeTypeENT.LevelModeTypeName = objge_LevelModeTypeENS.LevelModeTypeName; //模式名
objge_LevelModeTypeENT.LevelModeTypeENName = objge_LevelModeTypeENS.LevelModeTypeENName; //模式英文名
objge_LevelModeTypeENT.UpdUser = objge_LevelModeTypeENS.UpdUser; //修改人
objge_LevelModeTypeENT.UpdDate = objge_LevelModeTypeENS.UpdDate; //修改日期
objge_LevelModeTypeENT.Memo = objge_LevelModeTypeENS.Memo; //备注
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
 /// <param name = "objge_LevelModeTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_LevelModeTypeEN:objge_LevelModeTypeENT</returns>
 public static clsge_LevelModeTypeEN CopyTo(this clsge_LevelModeTypeEN objge_LevelModeTypeENS)
{
try
{
 clsge_LevelModeTypeEN objge_LevelModeTypeENT = new clsge_LevelModeTypeEN()
{
LevelModeTypeId = objge_LevelModeTypeENS.LevelModeTypeId, //模式Id
LevelModeTypeName = objge_LevelModeTypeENS.LevelModeTypeName, //模式名
LevelModeTypeENName = objge_LevelModeTypeENS.LevelModeTypeENName, //模式英文名
UpdUser = objge_LevelModeTypeENS.UpdUser, //修改人
UpdDate = objge_LevelModeTypeENS.UpdDate, //修改日期
Memo = objge_LevelModeTypeENS.Memo, //备注
};
 return objge_LevelModeTypeENT;
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
public static void CheckPropertyNew(this clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 clsge_LevelModeTypeBL.ge_LevelModeTypeDA.CheckPropertyNew(objge_LevelModeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 clsge_LevelModeTypeBL.ge_LevelModeTypeDA.CheckProperty4Condition(objge_LevelModeTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_LevelModeTypeEN objge_LevelModeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_LevelModeTypeCond.IsUpdated(conge_LevelModeType.LevelModeTypeId) == true)
{
string strComparisonOpLevelModeTypeId = objge_LevelModeTypeCond.dicFldComparisonOp[conge_LevelModeType.LevelModeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LevelModeType.LevelModeTypeId, objge_LevelModeTypeCond.LevelModeTypeId, strComparisonOpLevelModeTypeId);
}
if (objge_LevelModeTypeCond.IsUpdated(conge_LevelModeType.LevelModeTypeName) == true)
{
string strComparisonOpLevelModeTypeName = objge_LevelModeTypeCond.dicFldComparisonOp[conge_LevelModeType.LevelModeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LevelModeType.LevelModeTypeName, objge_LevelModeTypeCond.LevelModeTypeName, strComparisonOpLevelModeTypeName);
}
if (objge_LevelModeTypeCond.IsUpdated(conge_LevelModeType.LevelModeTypeENName) == true)
{
string strComparisonOpLevelModeTypeENName = objge_LevelModeTypeCond.dicFldComparisonOp[conge_LevelModeType.LevelModeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LevelModeType.LevelModeTypeENName, objge_LevelModeTypeCond.LevelModeTypeENName, strComparisonOpLevelModeTypeENName);
}
if (objge_LevelModeTypeCond.IsUpdated(conge_LevelModeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_LevelModeTypeCond.dicFldComparisonOp[conge_LevelModeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LevelModeType.UpdUser, objge_LevelModeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_LevelModeTypeCond.IsUpdated(conge_LevelModeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_LevelModeTypeCond.dicFldComparisonOp[conge_LevelModeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LevelModeType.UpdDate, objge_LevelModeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_LevelModeTypeCond.IsUpdated(conge_LevelModeType.Memo) == true)
{
string strComparisonOpMemo = objge_LevelModeTypeCond.dicFldComparisonOp[conge_LevelModeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LevelModeType.Memo, objge_LevelModeTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_LevelModeType(关卡模式类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:LevelModeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_LevelModeTypeEN == null) return true;
if (objge_LevelModeTypeEN.LevelModeTypeId == null || objge_LevelModeTypeEN.LevelModeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objge_LevelModeTypeEN.LevelModeTypeName == null)
{
 sbCondition.AppendFormat(" and LevelModeTypeName is null", objge_LevelModeTypeEN.LevelModeTypeName);
}
else
{
 sbCondition.AppendFormat(" and LevelModeTypeName = '{0}'", objge_LevelModeTypeEN.LevelModeTypeName);
}
if (clsge_LevelModeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("LevelModeTypeId !=  '{0}'", objge_LevelModeTypeEN.LevelModeTypeId);
 sbCondition.AppendFormat(" and LevelModeTypeName = '{0}'", objge_LevelModeTypeEN.LevelModeTypeName);
if (clsge_LevelModeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_LevelModeType(关卡模式类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:LevelModeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_LevelModeTypeEN == null) return "";
if (objge_LevelModeTypeEN.LevelModeTypeId == null || objge_LevelModeTypeEN.LevelModeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objge_LevelModeTypeEN.LevelModeTypeName == null)
{
 sbCondition.AppendFormat(" and LevelModeTypeName is null", objge_LevelModeTypeEN.LevelModeTypeName);
}
else
{
 sbCondition.AppendFormat(" and LevelModeTypeName = '{0}'", objge_LevelModeTypeEN.LevelModeTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("LevelModeTypeId !=  '{0}'", objge_LevelModeTypeEN.LevelModeTypeId);
 sbCondition.AppendFormat(" and LevelModeTypeName = '{0}'", objge_LevelModeTypeEN.LevelModeTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_LevelModeType
{
public virtual bool UpdRelaTabDate(string strLevelModeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumge_LevelModeType
{
 /// <summary>
 /// 练习
 /// </summary>
public const string Practice_01 = "01";
 /// <summary>
 /// 考试
 /// </summary>
public const string Examination_02 = "02";
 /// <summary>
 /// 所有
 /// </summary>
public const string All_03 = "03";
}
 /// <summary>
 /// 关卡模式类型(ge_LevelModeType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_LevelModeTypeBL
{
public static RelatedActions_ge_LevelModeType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_LevelModeTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_LevelModeTypeDA ge_LevelModeTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_LevelModeTypeDA();
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
 public clsge_LevelModeTypeBL()
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
if (string.IsNullOrEmpty(clsge_LevelModeTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_LevelModeTypeEN._ConnectString);
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
public static DataTable GetDataTable_ge_LevelModeType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_LevelModeTypeDA.GetDataTable_ge_LevelModeType(strWhereCond);
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
objDT = ge_LevelModeTypeDA.GetDataTable(strWhereCond);
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
objDT = ge_LevelModeTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_LevelModeTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_LevelModeTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_LevelModeTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ge_LevelModeTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_LevelModeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_LevelModeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrLevelModeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_LevelModeTypeEN> GetObjLstByLevelModeTypeIdLst(List<string> arrLevelModeTypeIdLst)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrLevelModeTypeIdLst, true);
 string strWhereCond = string.Format("LevelModeTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrLevelModeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_LevelModeTypeEN> GetObjLstByLevelModeTypeIdLstCache(List<string> arrLevelModeTypeIdLst)
{
string strKey = string.Format("{0}", clsge_LevelModeTypeEN._CurrTabName);
List<clsge_LevelModeTypeEN> arrge_LevelModeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_LevelModeTypeEN> arrge_LevelModeTypeObjLst_Sel =
arrge_LevelModeTypeObjLstCache
.Where(x => arrLevelModeTypeIdLst.Contains(x.LevelModeTypeId));
return arrge_LevelModeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_LevelModeTypeEN> GetObjLst(string strWhereCond)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
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
public static List<clsge_LevelModeTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_LevelModeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_LevelModeTypeEN> GetSubObjLstCache(clsge_LevelModeTypeEN objge_LevelModeTypeCond)
{
List<clsge_LevelModeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_LevelModeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_LevelModeType.AttributeName)
{
if (objge_LevelModeTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_LevelModeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LevelModeTypeCond[strFldName].ToString());
}
else
{
if (objge_LevelModeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_LevelModeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LevelModeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_LevelModeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_LevelModeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_LevelModeTypeCond[strFldName]));
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
public static List<clsge_LevelModeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
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
public static List<clsge_LevelModeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
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
List<clsge_LevelModeTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_LevelModeTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_LevelModeTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_LevelModeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
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
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
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
public static List<clsge_LevelModeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_LevelModeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_LevelModeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
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
public static List<clsge_LevelModeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_LevelModeTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_LevelModeTypeEN> arrObjLst = new List<clsge_LevelModeTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LevelModeTypeEN objge_LevelModeTypeEN = new clsge_LevelModeTypeEN();
try
{
objge_LevelModeTypeEN.LevelModeTypeId = objRow[conge_LevelModeType.LevelModeTypeId].ToString().Trim(); //模式Id
objge_LevelModeTypeEN.LevelModeTypeName = objRow[conge_LevelModeType.LevelModeTypeName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeName].ToString().Trim(); //模式名
objge_LevelModeTypeEN.LevelModeTypeENName = objRow[conge_LevelModeType.LevelModeTypeENName] == DBNull.Value ? null : objRow[conge_LevelModeType.LevelModeTypeENName].ToString().Trim(); //模式英文名
objge_LevelModeTypeEN.UpdUser = objRow[conge_LevelModeType.UpdUser] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdUser].ToString().Trim(); //修改人
objge_LevelModeTypeEN.UpdDate = objRow[conge_LevelModeType.UpdDate] == DBNull.Value ? null : objRow[conge_LevelModeType.UpdDate].ToString().Trim(); //修改日期
objge_LevelModeTypeEN.Memo = objRow[conge_LevelModeType.Memo] == DBNull.Value ? null : objRow[conge_LevelModeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LevelModeTypeEN.LevelModeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LevelModeTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_LevelModeType(ref clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
bool bolResult = ge_LevelModeTypeDA.Getge_LevelModeType(ref objge_LevelModeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strLevelModeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_LevelModeTypeEN GetObjByLevelModeTypeId(string strLevelModeTypeId)
{
if (strLevelModeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strLevelModeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strLevelModeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strLevelModeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_LevelModeTypeEN objge_LevelModeTypeEN = ge_LevelModeTypeDA.GetObjByLevelModeTypeId(strLevelModeTypeId);
return objge_LevelModeTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_LevelModeTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_LevelModeTypeEN objge_LevelModeTypeEN = ge_LevelModeTypeDA.GetFirstObj(strWhereCond);
 return objge_LevelModeTypeEN;
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
public static clsge_LevelModeTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_LevelModeTypeEN objge_LevelModeTypeEN = ge_LevelModeTypeDA.GetObjByDataRow(objRow);
 return objge_LevelModeTypeEN;
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
public static clsge_LevelModeTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_LevelModeTypeEN objge_LevelModeTypeEN = ge_LevelModeTypeDA.GetObjByDataRow(objRow);
 return objge_LevelModeTypeEN;
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
 /// <param name = "strLevelModeTypeId">所给的关键字</param>
 /// <param name = "lstge_LevelModeTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_LevelModeTypeEN GetObjByLevelModeTypeIdFromList(string strLevelModeTypeId, List<clsge_LevelModeTypeEN> lstge_LevelModeTypeObjLst)
{
foreach (clsge_LevelModeTypeEN objge_LevelModeTypeEN in lstge_LevelModeTypeObjLst)
{
if (objge_LevelModeTypeEN.LevelModeTypeId == strLevelModeTypeId)
{
return objge_LevelModeTypeEN;
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
 string strMaxLevelModeTypeId;
 try
 {
 strMaxLevelModeTypeId = clsge_LevelModeTypeDA.GetMaxStrId();
 return strMaxLevelModeTypeId;
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
 string strLevelModeTypeId;
 try
 {
 strLevelModeTypeId = new clsge_LevelModeTypeDA().GetFirstID(strWhereCond);
 return strLevelModeTypeId;
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
 arrList = ge_LevelModeTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ge_LevelModeTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strLevelModeTypeId)
{
if (string.IsNullOrEmpty(strLevelModeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strLevelModeTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_LevelModeTypeDA.IsExist(strLevelModeTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strLevelModeTypeId">模式Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strLevelModeTypeId, string strOpUser)
{
clsge_LevelModeTypeEN objge_LevelModeTypeEN = clsge_LevelModeTypeBL.GetObjByLevelModeTypeId(strLevelModeTypeId);
objge_LevelModeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objge_LevelModeTypeEN.UpdUser = strOpUser;
return clsge_LevelModeTypeBL.UpdateBySql2(objge_LevelModeTypeEN);
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
 bolIsExist = clsge_LevelModeTypeDA.IsExistTable();
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
 bolIsExist = ge_LevelModeTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_LevelModeTypeEN objge_LevelModeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_LevelModeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!模式名 = [{0}]的数据已经存在!(in clsge_LevelModeTypeBL.AddNewRecordBySql2)", objge_LevelModeTypeEN.LevelModeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true || clsge_LevelModeTypeBL.IsExist(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
     objge_LevelModeTypeEN.LevelModeTypeId = clsge_LevelModeTypeBL.GetMaxStrId_S();
 }
bool bolResult = ge_LevelModeTypeDA.AddNewRecordBySQL2(objge_LevelModeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_LevelModeTypeEN objge_LevelModeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_LevelModeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!模式名 = [{0}]的数据已经存在!(in clsge_LevelModeTypeBL.AddNewRecordBySql2WithReturnKey)", objge_LevelModeTypeEN.LevelModeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true || clsge_LevelModeTypeBL.IsExist(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
     objge_LevelModeTypeEN.LevelModeTypeId = clsge_LevelModeTypeBL.GetMaxStrId_S();
 }
string strKey = ge_LevelModeTypeDA.AddNewRecordBySQL2WithReturnKey(objge_LevelModeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
try
{
bool bolResult = ge_LevelModeTypeDA.Update(objge_LevelModeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "objge_LevelModeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 if (string.IsNullOrEmpty(objge_LevelModeTypeEN.LevelModeTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_LevelModeTypeDA.UpdateBySql2(objge_LevelModeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LevelModeTypeBL.ReFreshCache();

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
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
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strLevelModeTypeId)
{
try
{
 clsge_LevelModeTypeEN objge_LevelModeTypeEN = clsge_LevelModeTypeBL.GetObjByLevelModeTypeId(strLevelModeTypeId);

if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(objge_LevelModeTypeEN.LevelModeTypeId, objge_LevelModeTypeEN.UpdUser);
}
if (objge_LevelModeTypeEN != null)
{
int intRecNum = ge_LevelModeTypeDA.DelRecord(strLevelModeTypeId);
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
/// <param name="strLevelModeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strLevelModeTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_LevelModeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_LevelModeType.LevelModeTypeId,
//strLevelModeTypeId);
//        clsge_LevelModeTypeBL.Delge_LevelModeTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_LevelModeTypeBL.DelRecord(strLevelModeTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_LevelModeTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLevelModeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strLevelModeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strLevelModeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_LevelModeTypeBL.relatedActions != null)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(strLevelModeTypeId, "UpdRelaTabDate");
}
bool bolResult = ge_LevelModeTypeDA.DelRecord(strLevelModeTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrLevelModeTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_LevelModeTypes(List<string> arrLevelModeTypeIdLst)
{
if (arrLevelModeTypeIdLst.Count == 0) return 0;
try
{
if (clsge_LevelModeTypeBL.relatedActions != null)
{
foreach (var strLevelModeTypeId in arrLevelModeTypeIdLst)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(strLevelModeTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = ge_LevelModeTypeDA.Delge_LevelModeType(arrLevelModeTypeIdLst);
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
public static int Delge_LevelModeTypesByCond(string strWhereCond)
{
try
{
if (clsge_LevelModeTypeBL.relatedActions != null)
{
List<string> arrLevelModeTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strLevelModeTypeId in arrLevelModeTypeId)
{
clsge_LevelModeTypeBL.relatedActions.UpdRelaTabDate(strLevelModeTypeId, "UpdRelaTabDate");
}
}
int intRecNum = ge_LevelModeTypeDA.Delge_LevelModeType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_LevelModeType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strLevelModeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strLevelModeTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_LevelModeTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_LevelModeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_LevelModeTypeBL.DelRecord(strLevelModeTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_LevelModeTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLevelModeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_LevelModeTypeENS">源对象</param>
 /// <param name = "objge_LevelModeTypeENT">目标对象</param>
 public static void CopyTo(clsge_LevelModeTypeEN objge_LevelModeTypeENS, clsge_LevelModeTypeEN objge_LevelModeTypeENT)
{
try
{
objge_LevelModeTypeENT.LevelModeTypeId = objge_LevelModeTypeENS.LevelModeTypeId; //模式Id
objge_LevelModeTypeENT.LevelModeTypeName = objge_LevelModeTypeENS.LevelModeTypeName; //模式名
objge_LevelModeTypeENT.LevelModeTypeENName = objge_LevelModeTypeENS.LevelModeTypeENName; //模式英文名
objge_LevelModeTypeENT.UpdUser = objge_LevelModeTypeENS.UpdUser; //修改人
objge_LevelModeTypeENT.UpdDate = objge_LevelModeTypeENS.UpdDate; //修改日期
objge_LevelModeTypeENT.Memo = objge_LevelModeTypeENS.Memo; //备注
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
 /// <param name = "objge_LevelModeTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
try
{
objge_LevelModeTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_LevelModeTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_LevelModeType.LevelModeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LevelModeTypeEN.LevelModeTypeId = objge_LevelModeTypeEN.LevelModeTypeId; //模式Id
}
if (arrFldSet.Contains(conge_LevelModeType.LevelModeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LevelModeTypeEN.LevelModeTypeName = objge_LevelModeTypeEN.LevelModeTypeName == "[null]" ? null :  objge_LevelModeTypeEN.LevelModeTypeName; //模式名
}
if (arrFldSet.Contains(conge_LevelModeType.LevelModeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LevelModeTypeEN.LevelModeTypeENName = objge_LevelModeTypeEN.LevelModeTypeENName == "[null]" ? null :  objge_LevelModeTypeEN.LevelModeTypeENName; //模式英文名
}
if (arrFldSet.Contains(conge_LevelModeType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LevelModeTypeEN.UpdUser = objge_LevelModeTypeEN.UpdUser == "[null]" ? null :  objge_LevelModeTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_LevelModeType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LevelModeTypeEN.UpdDate = objge_LevelModeTypeEN.UpdDate == "[null]" ? null :  objge_LevelModeTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_LevelModeType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LevelModeTypeEN.Memo = objge_LevelModeTypeEN.Memo == "[null]" ? null :  objge_LevelModeTypeEN.Memo; //备注
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
 /// <param name = "objge_LevelModeTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
try
{
if (objge_LevelModeTypeEN.LevelModeTypeName == "[null]") objge_LevelModeTypeEN.LevelModeTypeName = null; //模式名
if (objge_LevelModeTypeEN.LevelModeTypeENName == "[null]") objge_LevelModeTypeEN.LevelModeTypeENName = null; //模式英文名
if (objge_LevelModeTypeEN.UpdUser == "[null]") objge_LevelModeTypeEN.UpdUser = null; //修改人
if (objge_LevelModeTypeEN.UpdDate == "[null]") objge_LevelModeTypeEN.UpdDate = null; //修改日期
if (objge_LevelModeTypeEN.Memo == "[null]") objge_LevelModeTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 ge_LevelModeTypeDA.CheckPropertyNew(objge_LevelModeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
 ge_LevelModeTypeDA.CheckProperty4Condition(objge_LevelModeTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_LevelModeTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[关卡模式类型]...","0");
List<clsge_LevelModeTypeEN> arrge_LevelModeTypeObjLst = GetAllge_LevelModeTypeObjLstCache(); 
objDDL.DataValueField = conge_LevelModeType.LevelModeTypeId;
objDDL.DataTextField = conge_LevelModeType.LevelModeTypeName;
objDDL.DataSource = arrge_LevelModeTypeObjLst;
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
if (clsge_LevelModeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_LevelModeTypeBL没有刷新缓存机制(clsge_LevelModeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by LevelModeTypeId");
//if (arrge_LevelModeTypeObjLstCache == null)
//{
//arrge_LevelModeTypeObjLstCache = ge_LevelModeTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strLevelModeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_LevelModeTypeEN GetObjByLevelModeTypeIdCache(string strLevelModeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsge_LevelModeTypeEN._CurrTabName);
List<clsge_LevelModeTypeEN> arrge_LevelModeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_LevelModeTypeEN> arrge_LevelModeTypeObjLst_Sel =
arrge_LevelModeTypeObjLstCache
.Where(x=> x.LevelModeTypeId == strLevelModeTypeId 
);
if (arrge_LevelModeTypeObjLst_Sel.Count() == 0)
{
   clsge_LevelModeTypeEN obj = clsge_LevelModeTypeBL.GetObjByLevelModeTypeId(strLevelModeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrge_LevelModeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strLevelModeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetLevelModeTypeNameByLevelModeTypeIdCache(string strLevelModeTypeId)
{
if (string.IsNullOrEmpty(strLevelModeTypeId) == true) return "";
//获取缓存中的对象列表
clsge_LevelModeTypeEN objge_LevelModeType = GetObjByLevelModeTypeIdCache(strLevelModeTypeId);
if (objge_LevelModeType == null) return "";
return objge_LevelModeType.LevelModeTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strLevelModeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByLevelModeTypeIdCache(string strLevelModeTypeId)
{
if (string.IsNullOrEmpty(strLevelModeTypeId) == true) return "";
//获取缓存中的对象列表
clsge_LevelModeTypeEN objge_LevelModeType = GetObjByLevelModeTypeIdCache(strLevelModeTypeId);
if (objge_LevelModeType == null) return "";
return objge_LevelModeType.LevelModeTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_LevelModeTypeEN> GetAllge_LevelModeTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsge_LevelModeTypeEN> arrge_LevelModeTypeObjLstCache = GetObjLstCache(); 
return arrge_LevelModeTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_LevelModeTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsge_LevelModeTypeEN._CurrTabName);
List<clsge_LevelModeTypeEN> arrge_LevelModeTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrge_LevelModeTypeObjLstCache;
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
string strKey = string.Format("{0}", clsge_LevelModeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_LevelModeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_LevelModeTypeEN._RefreshTimeLst.Count == 0) return "";
return clsge_LevelModeTypeEN._RefreshTimeLst[clsge_LevelModeTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsge_LevelModeTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsge_LevelModeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_LevelModeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_LevelModeTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_LevelModeType(关卡模式类型)
 /// 唯一性条件:LevelModeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_LevelModeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_LevelModeTypeEN objge_LevelModeTypeEN)
{
//检测记录是否存在
string strResult = ge_LevelModeTypeDA.GetUniCondStr(objge_LevelModeTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strLevelModeTypeId)
{
if (strInFldName != conge_LevelModeType.LevelModeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_LevelModeType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_LevelModeType.AttributeName));
throw new Exception(strMsg);
}
var objge_LevelModeType = clsge_LevelModeTypeBL.GetObjByLevelModeTypeIdCache(strLevelModeTypeId);
if (objge_LevelModeType == null) return "";
return objge_LevelModeType[strOutFldName].ToString();
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
int intRecCount = clsge_LevelModeTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsge_LevelModeTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_LevelModeTypeDA.GetRecCount();
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
int intRecCount = clsge_LevelModeTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_LevelModeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_LevelModeTypeEN objge_LevelModeTypeCond)
{
List<clsge_LevelModeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_LevelModeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_LevelModeType.AttributeName)
{
if (objge_LevelModeTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_LevelModeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LevelModeTypeCond[strFldName].ToString());
}
else
{
if (objge_LevelModeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_LevelModeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LevelModeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_LevelModeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_LevelModeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_LevelModeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_LevelModeTypeCond[strFldName]));
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
 List<string> arrList = clsge_LevelModeTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_LevelModeTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_LevelModeTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_LevelModeTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_LevelModeTypeDA.SetFldValue(clsge_LevelModeTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_LevelModeTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_LevelModeTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_LevelModeTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_LevelModeTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_LevelModeType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**模式Id*/ 
 strCreateTabCode.Append(" LevelModeTypeId char(2) primary key, "); 
 // /**模式名*/ 
 strCreateTabCode.Append(" LevelModeTypeName varchar(100) Null, "); 
 // /**模式英文名*/ 
 strCreateTabCode.Append(" LevelModeTypeENName varchar(100) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 关卡模式类型(ge_LevelModeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_LevelModeType : clsCommFun4BL
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
clsge_LevelModeTypeBL.ReFreshThisCache();
}
}

}