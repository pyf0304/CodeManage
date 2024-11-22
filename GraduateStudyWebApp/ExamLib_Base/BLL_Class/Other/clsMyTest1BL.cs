
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMyTest1BL
 表名:MyTest1(01120220)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
public static class  clsMyTest1BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strStrKey">表关键字</param>
 /// <returns>表对象</returns>
public static clsMyTest1EN GetObj(this K_StrKey_MyTest1 myKey)
{
clsMyTest1EN objMyTest1EN = clsMyTest1BL.MyTest1DA.GetObjByStrKey(myKey.Value);
return objMyTest1EN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMyTest1EN objMyTest1EN)
{
if (CheckUniqueness(objMyTest1EN) == false)
{
var strMsg = string.Format("记录已经存在!my整型 = [{0}]的数据已经存在!(in clsMyTest1BL.AddNewRecord)", objMyTest1EN.myInt);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true || clsMyTest1BL.IsExist(objMyTest1EN.StrKey) == true)
 {
     objMyTest1EN.StrKey = clsMyTest1BL.GetMaxStrId_S();
 }
bool bolResult = clsMyTest1BL.MyTest1DA.AddNewRecordBySQL2(objMyTest1EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
public static bool AddRecordEx(this clsMyTest1EN objMyTest1EN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsMyTest1BL.IsExist(objMyTest1EN.StrKey))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objMyTest1EN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objMyTest1EN.CheckUniqueness() == false)
{
strMsg = string.Format("(my整型(myInt)=[{0}])已经存在,不能重复!", objMyTest1EN.myInt);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true || clsMyTest1BL.IsExist(objMyTest1EN.StrKey) == true)
 {
     objMyTest1EN.StrKey = clsMyTest1BL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objMyTest1EN.AddNewRecord();
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsMyTest1EN objMyTest1EN)
{
if (CheckUniqueness(objMyTest1EN) == false)
{
var strMsg = string.Format("记录已经存在!my整型 = [{0}]的数据已经存在!(in clsMyTest1BL.AddNewRecordWithMaxId)", objMyTest1EN.myInt);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true || clsMyTest1BL.IsExist(objMyTest1EN.StrKey) == true)
 {
     objMyTest1EN.StrKey = clsMyTest1BL.GetMaxStrId_S();
 }
string strStrKey = clsMyTest1BL.MyTest1DA.AddNewRecordBySQL2WithReturnKey(objMyTest1EN);
     objMyTest1EN.StrKey = strStrKey;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
}
return strStrKey;
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMyTest1EN objMyTest1EN)
{
if (CheckUniqueness(objMyTest1EN) == false)
{
var strMsg = string.Format("记录已经存在!my整型 = [{0}]的数据已经存在!(in clsMyTest1BL.AddNewRecordWithReturnKey)", objMyTest1EN.myInt);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true || clsMyTest1BL.IsExist(objMyTest1EN.StrKey) == true)
 {
     objMyTest1EN.StrKey = clsMyTest1BL.GetMaxStrId_S();
 }
string strKey = clsMyTest1BL.MyTest1DA.AddNewRecordBySQL2WithReturnKey(objMyTest1EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMyTest1EN SetStrKey(this clsMyTest1EN objMyTest1EN, string strStrKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStrKey, 4, conMyTest1.StrKey);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStrKey, 4, conMyTest1.StrKey);
}
objMyTest1EN.StrKey = strStrKey; //s主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMyTest1EN.dicFldComparisonOp.ContainsKey(conMyTest1.StrKey) == false)
{
objMyTest1EN.dicFldComparisonOp.Add(conMyTest1.StrKey, strComparisonOp);
}
else
{
objMyTest1EN.dicFldComparisonOp[conMyTest1.StrKey] = strComparisonOp;
}
}
return objMyTest1EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMyTest1EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMyTest1EN SetmyInt(this clsMyTest1EN objMyTest1EN, int intmyInt, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intmyInt, conMyTest1.myInt);
objMyTest1EN.myInt = intmyInt; //my整型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMyTest1EN.dicFldComparisonOp.ContainsKey(conMyTest1.myInt) == false)
{
objMyTest1EN.dicFldComparisonOp.Add(conMyTest1.myInt, strComparisonOp);
}
else
{
objMyTest1EN.dicFldComparisonOp[conMyTest1.myInt] = strComparisonOp;
}
}
return objMyTest1EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMyTest1EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMyTest1EN SetmyLong(this clsMyTest1EN objMyTest1EN, long lngmyLong, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngmyLong, conMyTest1.myLong);
objMyTest1EN.myLong = lngmyLong; //my长整型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMyTest1EN.dicFldComparisonOp.ContainsKey(conMyTest1.myLong) == false)
{
objMyTest1EN.dicFldComparisonOp.Add(conMyTest1.myLong, strComparisonOp);
}
else
{
objMyTest1EN.dicFldComparisonOp[conMyTest1.myLong] = strComparisonOp;
}
}
return objMyTest1EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMyTest1EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMyTest1EN SetmyString(this clsMyTest1EN objMyTest1EN, string strmyString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strmyString, conMyTest1.myString);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmyString, 50, conMyTest1.myString);
}
objMyTest1EN.myString = strmyString; //my字符串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMyTest1EN.dicFldComparisonOp.ContainsKey(conMyTest1.myString) == false)
{
objMyTest1EN.dicFldComparisonOp.Add(conMyTest1.myString, strComparisonOp);
}
else
{
objMyTest1EN.dicFldComparisonOp[conMyTest1.myString] = strComparisonOp;
}
}
return objMyTest1EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMyTest1EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMyTest1EN SetmyBool(this clsMyTest1EN objMyTest1EN, bool bolmyBool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolmyBool, conMyTest1.myBool);
objMyTest1EN.myBool = bolmyBool; //my布尔型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMyTest1EN.dicFldComparisonOp.ContainsKey(conMyTest1.myBool) == false)
{
objMyTest1EN.dicFldComparisonOp.Add(conMyTest1.myBool, strComparisonOp);
}
else
{
objMyTest1EN.dicFldComparisonOp[conMyTest1.myBool] = strComparisonOp;
}
}
return objMyTest1EN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMyTest1EN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMyTest1EN objMyTest1EN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMyTest1EN.CheckPropertyNew();
clsMyTest1EN objMyTest1Cond = new clsMyTest1EN();
string strCondition = objMyTest1Cond
.SetStrKey(objMyTest1EN.StrKey, "<>")
.SetmyInt(objMyTest1EN.myInt, "=")
.GetCombineCondition();
objMyTest1EN._IsCheckProperty = true;
bool bolIsExist = clsMyTest1BL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(myInt)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMyTest1EN.Update();
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
 /// <param name = "objMyTest1">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsMyTest1EN objMyTest1)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsMyTest1EN objMyTest1Cond = new clsMyTest1EN();
string strCondition = objMyTest1Cond
.SetmyInt(objMyTest1.myInt, "=")
.GetCombineCondition();
objMyTest1._IsCheckProperty = true;
bool bolIsExist = clsMyTest1BL.IsExistRecord(strCondition);
if (bolIsExist)
{
objMyTest1.StrKey = clsMyTest1BL.GetFirstID_S(strCondition);
objMyTest1.UpdateWithCondition(strCondition);
}
else
{
objMyTest1.StrKey = clsMyTest1BL.GetMaxStrId_S();
objMyTest1.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMyTest1EN objMyTest1EN)
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMyTest1BL.MyTest1DA.UpdateBySql2(objMyTest1EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMyTest1EN objMyTest1EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMyTest1BL.MyTest1DA.UpdateBySql2(objMyTest1EN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMyTest1EN objMyTest1EN, string strWhereCond)
{
try
{
bool bolResult = clsMyTest1BL.MyTest1DA.UpdateBySqlWithCondition(objMyTest1EN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1EN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMyTest1EN objMyTest1EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMyTest1BL.MyTest1DA.UpdateBySqlWithConditionTransaction(objMyTest1EN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMyTest1EN objMyTest1EN)
{
try
{
int intRecNum = clsMyTest1BL.MyTest1DA.DelRecord(objMyTest1EN.StrKey);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1ENS">源对象</param>
 /// <param name = "objMyTest1ENT">目标对象</param>
 public static void CopyTo(this clsMyTest1EN objMyTest1ENS, clsMyTest1EN objMyTest1ENT)
{
try
{
objMyTest1ENT.StrKey = objMyTest1ENS.StrKey; //s主键
objMyTest1ENT.myInt = objMyTest1ENS.myInt; //my整型
objMyTest1ENT.myLong = objMyTest1ENS.myLong; //my长整型
objMyTest1ENT.myString = objMyTest1ENS.myString; //my字符串
objMyTest1ENT.myBool = objMyTest1ENS.myBool; //my布尔型
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
 /// <param name = "objMyTest1ENS">源对象</param>
 /// <returns>目标对象=>clsMyTest1EN:objMyTest1ENT</returns>
 public static clsMyTest1EN CopyTo(this clsMyTest1EN objMyTest1ENS)
{
try
{
 clsMyTest1EN objMyTest1ENT = new clsMyTest1EN()
{
StrKey = objMyTest1ENS.StrKey, //s主键
myInt = objMyTest1ENS.myInt, //my整型
myLong = objMyTest1ENS.myLong, //my长整型
myString = objMyTest1ENS.myString, //my字符串
myBool = objMyTest1ENS.myBool, //my布尔型
};
 return objMyTest1ENT;
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
public static void CheckPropertyNew(this clsMyTest1EN objMyTest1EN)
{
 clsMyTest1BL.MyTest1DA.CheckPropertyNew(objMyTest1EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMyTest1EN objMyTest1EN)
{
 clsMyTest1BL.MyTest1DA.CheckProperty4Condition(objMyTest1EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMyTest1EN objMyTest1Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMyTest1Cond.IsUpdated(conMyTest1.StrKey) == true)
{
string strComparisonOpStrKey = objMyTest1Cond.dicFldComparisonOp[conMyTest1.StrKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMyTest1.StrKey, objMyTest1Cond.StrKey, strComparisonOpStrKey);
}
if (objMyTest1Cond.IsUpdated(conMyTest1.myInt) == true)
{
string strComparisonOpmyInt = objMyTest1Cond.dicFldComparisonOp[conMyTest1.myInt];
strWhereCond += string.Format(" And {0} {2} {1}", conMyTest1.myInt, objMyTest1Cond.myInt, strComparisonOpmyInt);
}
if (objMyTest1Cond.IsUpdated(conMyTest1.myLong) == true)
{
string strComparisonOpmyLong = objMyTest1Cond.dicFldComparisonOp[conMyTest1.myLong];
strWhereCond += string.Format(" And {0} {2} {1}", conMyTest1.myLong, objMyTest1Cond.myLong, strComparisonOpmyLong);
}
if (objMyTest1Cond.IsUpdated(conMyTest1.myString) == true)
{
string strComparisonOpmyString = objMyTest1Cond.dicFldComparisonOp[conMyTest1.myString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMyTest1.myString, objMyTest1Cond.myString, strComparisonOpmyString);
}
if (objMyTest1Cond.IsUpdated(conMyTest1.myBool) == true)
{
if (objMyTest1Cond.myBool == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMyTest1.myBool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMyTest1.myBool);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--MyTest1(测试表1), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:myInt
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objMyTest1EN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsMyTest1EN objMyTest1EN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objMyTest1EN == null) return true;
if (objMyTest1EN.StrKey == null || objMyTest1EN.StrKey == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and myInt = '{0}'", objMyTest1EN.myInt);
if (clsMyTest1BL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("StrKey !=  '{0}'", objMyTest1EN.StrKey);
 sbCondition.AppendFormat(" and myInt = '{0}'", objMyTest1EN.myInt);
if (clsMyTest1BL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--MyTest1(测试表1), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:myInt
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMyTest1EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsMyTest1EN objMyTest1EN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMyTest1EN == null) return "";
if (objMyTest1EN.StrKey == null || objMyTest1EN.StrKey == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and myInt = '{0}'", objMyTest1EN.myInt);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("StrKey !=  '{0}'", objMyTest1EN.StrKey);
 sbCondition.AppendFormat(" and myInt = '{0}'", objMyTest1EN.myInt);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MyTest1
{
public virtual bool UpdRelaTabDate(string strStrKey, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 测试表1(MyTest1)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMyTest1BL
{
public static RelatedActions_MyTest1 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMyTest1DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMyTest1DA MyTest1DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMyTest1DA();
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
 public clsMyTest1BL()
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
if (string.IsNullOrEmpty(clsMyTest1EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMyTest1EN._ConnectString);
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
public static DataTable GetDataTable_MyTest1(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MyTest1DA.GetDataTable_MyTest1(strWhereCond);
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
objDT = MyTest1DA.GetDataTable(strWhereCond);
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
objDT = MyTest1DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MyTest1DA.GetDataTable(strWhereCond, strTabName);
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
objDT = MyTest1DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MyTest1DA.GetDataTable_Top(objTopPara);
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
objDT = MyTest1DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MyTest1DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MyTest1DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrStrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMyTest1EN> GetObjLstByStrKeyLst(List<string> arrStrKeyLst)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrStrKeyLst, true);
 string strWhereCond = string.Format("StrKey in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrStrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMyTest1EN> GetObjLstByStrKeyLstCache(List<string> arrStrKeyLst)
{
string strKey = string.Format("{0}", clsMyTest1EN._CurrTabName);
List<clsMyTest1EN> arrMyTest1ObjLstCache = GetObjLstCache();
IEnumerable <clsMyTest1EN> arrMyTest1ObjLst_Sel =
arrMyTest1ObjLstCache
.Where(x => arrStrKeyLst.Contains(x.StrKey));
return arrMyTest1ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMyTest1EN> GetObjLst(string strWhereCond)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
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
public static List<clsMyTest1EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMyTest1Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMyTest1EN> GetSubObjLstCache(clsMyTest1EN objMyTest1Cond)
{
List<clsMyTest1EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMyTest1EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMyTest1.AttributeName)
{
if (objMyTest1Cond.IsUpdated(strFldName) == false) continue;
if (objMyTest1Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMyTest1Cond[strFldName].ToString());
}
else
{
if (objMyTest1Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMyTest1Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMyTest1Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMyTest1Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMyTest1Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMyTest1Cond[strFldName]));
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
public static List<clsMyTest1EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
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
public static List<clsMyTest1EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
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
List<clsMyTest1EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMyTest1EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMyTest1EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMyTest1EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
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
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
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
public static List<clsMyTest1EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMyTest1EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMyTest1EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
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
public static List<clsMyTest1EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMyTest1EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMyTest1EN> arrObjLst = new List<clsMyTest1EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMyTest1EN objMyTest1EN = new clsMyTest1EN();
try
{
objMyTest1EN.StrKey = objRow[conMyTest1.StrKey].ToString().Trim(); //s主键
objMyTest1EN.myInt = Int32.Parse(objRow[conMyTest1.myInt].ToString().Trim()); //my整型
objMyTest1EN.myLong = Int32.Parse(objRow[conMyTest1.myLong].ToString().Trim()); //my长整型
objMyTest1EN.myString = objRow[conMyTest1.myString].ToString().Trim(); //my字符串
objMyTest1EN.myBool = clsEntityBase2.TransNullToBool_S(objRow[conMyTest1.myBool].ToString().Trim()); //my布尔型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMyTest1EN.StrKey, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMyTest1EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMyTest1EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMyTest1(ref clsMyTest1EN objMyTest1EN)
{
bool bolResult = MyTest1DA.GetMyTest1(ref objMyTest1EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strStrKey">表关键字</param>
 /// <returns>表对象</returns>
public static clsMyTest1EN GetObjByStrKey(string strStrKey)
{
if (strStrKey.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strStrKey]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strStrKey) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strStrKey]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsMyTest1EN objMyTest1EN = MyTest1DA.GetObjByStrKey(strStrKey);
return objMyTest1EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMyTest1EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMyTest1EN objMyTest1EN = MyTest1DA.GetFirstObj(strWhereCond);
 return objMyTest1EN;
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
public static clsMyTest1EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMyTest1EN objMyTest1EN = MyTest1DA.GetObjByDataRow(objRow);
 return objMyTest1EN;
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
public static clsMyTest1EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMyTest1EN objMyTest1EN = MyTest1DA.GetObjByDataRow(objRow);
 return objMyTest1EN;
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
 /// <param name = "strStrKey">所给的关键字</param>
 /// <param name = "lstMyTest1ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMyTest1EN GetObjByStrKeyFromList(string strStrKey, List<clsMyTest1EN> lstMyTest1ObjLst)
{
foreach (clsMyTest1EN objMyTest1EN in lstMyTest1ObjLst)
{
if (objMyTest1EN.StrKey == strStrKey)
{
return objMyTest1EN;
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
 string strMaxStrKey;
 try
 {
 strMaxStrKey = clsMyTest1DA.GetMaxStrId();
 return strMaxStrKey;
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
 string strStrKey;
 try
 {
 strStrKey = new clsMyTest1DA().GetFirstID(strWhereCond);
 return strStrKey;
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
 arrList = MyTest1DA.GetID(strWhereCond);
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
bool bolIsExist = MyTest1DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strStrKey)
{
if (string.IsNullOrEmpty(strStrKey) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strStrKey]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = MyTest1DA.IsExist(strStrKey);
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
 bolIsExist = clsMyTest1DA.IsExistTable();
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
 bolIsExist = MyTest1DA.IsExistTable(strTabName);
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMyTest1EN objMyTest1EN)
{
if (objMyTest1EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!my整型 = [{0}]的数据已经存在!(in clsMyTest1BL.AddNewRecordBySql2)", objMyTest1EN.myInt);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true || clsMyTest1BL.IsExist(objMyTest1EN.StrKey) == true)
 {
     objMyTest1EN.StrKey = clsMyTest1BL.GetMaxStrId_S();
 }
bool bolResult = MyTest1DA.AddNewRecordBySQL2(objMyTest1EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMyTest1EN objMyTest1EN)
{
if (objMyTest1EN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!my整型 = [{0}]的数据已经存在!(in clsMyTest1BL.AddNewRecordBySql2WithReturnKey)", objMyTest1EN.myInt);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true || clsMyTest1BL.IsExist(objMyTest1EN.StrKey) == true)
 {
     objMyTest1EN.StrKey = clsMyTest1BL.GetMaxStrId_S();
 }
string strKey = MyTest1DA.AddNewRecordBySQL2WithReturnKey(objMyTest1EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMyTest1EN objMyTest1EN)
{
try
{
bool bolResult = MyTest1DA.Update(objMyTest1EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "objMyTest1EN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMyTest1EN objMyTest1EN)
{
 if (string.IsNullOrEmpty(objMyTest1EN.StrKey) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MyTest1DA.UpdateBySql2(objMyTest1EN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMyTest1BL.ReFreshCache();

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
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
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strStrKey)
{
try
{
 clsMyTest1EN objMyTest1EN = clsMyTest1BL.GetObjByStrKey(strStrKey);

if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(objMyTest1EN.StrKey, "SetUpdDate");
}
if (objMyTest1EN != null)
{
int intRecNum = MyTest1DA.DelRecord(strStrKey);
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
/// <param name="strStrKey">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strStrKey )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMyTest1DA.GetSpecSQLObj();
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
//删除与表:[MyTest1]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMyTest1.StrKey,
//strStrKey);
//        clsMyTest1BL.DelMyTest1sByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMyTest1BL.DelRecord(strStrKey, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMyTest1BLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStrKey, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strStrKey">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strStrKey, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMyTest1BL.relatedActions != null)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(strStrKey, "UpdRelaTabDate");
}
bool bolResult = MyTest1DA.DelRecord(strStrKey,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrStrKeyLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMyTest1s(List<string> arrStrKeyLst)
{
if (arrStrKeyLst.Count == 0) return 0;
try
{
if (clsMyTest1BL.relatedActions != null)
{
foreach (var strStrKey in arrStrKeyLst)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(strStrKey, "UpdRelaTabDate");
}
}
int intDelRecNum = MyTest1DA.DelMyTest1(arrStrKeyLst);
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
public static int DelMyTest1sByCond(string strWhereCond)
{
try
{
if (clsMyTest1BL.relatedActions != null)
{
List<string> arrStrKey = GetPrimaryKeyID_S(strWhereCond);
foreach (var strStrKey in arrStrKey)
{
clsMyTest1BL.relatedActions.UpdRelaTabDate(strStrKey, "UpdRelaTabDate");
}
}
int intRecNum = MyTest1DA.DelMyTest1(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MyTest1]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strStrKey">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strStrKey)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMyTest1DA.GetSpecSQLObj();
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
//删除与表:[MyTest1]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMyTest1BL.DelRecord(strStrKey, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMyTest1BL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStrKey, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMyTest1ENS">源对象</param>
 /// <param name = "objMyTest1ENT">目标对象</param>
 public static void CopyTo(clsMyTest1EN objMyTest1ENS, clsMyTest1EN objMyTest1ENT)
{
try
{
objMyTest1ENT.StrKey = objMyTest1ENS.StrKey; //s主键
objMyTest1ENT.myInt = objMyTest1ENS.myInt; //my整型
objMyTest1ENT.myLong = objMyTest1ENS.myLong; //my长整型
objMyTest1ENT.myString = objMyTest1ENS.myString; //my字符串
objMyTest1ENT.myBool = objMyTest1ENS.myBool; //my布尔型
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
 /// <param name = "objMyTest1EN">源简化对象</param>
 public static void SetUpdFlag(clsMyTest1EN objMyTest1EN)
{
try
{
objMyTest1EN.ClearUpdateState();
   string strsfUpdFldSetStr = objMyTest1EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMyTest1.StrKey, new clsStrCompareIgnoreCase())  ==  true)
{
objMyTest1EN.StrKey = objMyTest1EN.StrKey; //s主键
}
if (arrFldSet.Contains(conMyTest1.myInt, new clsStrCompareIgnoreCase())  ==  true)
{
objMyTest1EN.myInt = objMyTest1EN.myInt; //my整型
}
if (arrFldSet.Contains(conMyTest1.myLong, new clsStrCompareIgnoreCase())  ==  true)
{
objMyTest1EN.myLong = objMyTest1EN.myLong; //my长整型
}
if (arrFldSet.Contains(conMyTest1.myString, new clsStrCompareIgnoreCase())  ==  true)
{
objMyTest1EN.myString = objMyTest1EN.myString; //my字符串
}
if (arrFldSet.Contains(conMyTest1.myBool, new clsStrCompareIgnoreCase())  ==  true)
{
objMyTest1EN.myBool = objMyTest1EN.myBool; //my布尔型
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
 /// <param name = "objMyTest1EN">源简化对象</param>
 public static void AccessFldValueNull(clsMyTest1EN objMyTest1EN)
{
try
{
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
public static void CheckPropertyNew(clsMyTest1EN objMyTest1EN)
{
 MyTest1DA.CheckPropertyNew(objMyTest1EN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMyTest1EN objMyTest1EN)
{
 MyTest1DA.CheckProperty4Condition(objMyTest1EN);
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
if (clsMyTest1BL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMyTest1BL没有刷新缓存机制(clsMyTest1BL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by StrKey");
//if (arrMyTest1ObjLstCache == null)
//{
//arrMyTest1ObjLstCache = MyTest1DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strStrKey">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMyTest1EN GetObjByStrKeyCache(string strStrKey)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMyTest1EN._CurrTabName);
List<clsMyTest1EN> arrMyTest1ObjLstCache = GetObjLstCache();
IEnumerable <clsMyTest1EN> arrMyTest1ObjLst_Sel =
arrMyTest1ObjLstCache
.Where(x=> x.StrKey == strStrKey 
);
if (arrMyTest1ObjLst_Sel.Count() == 0)
{
   clsMyTest1EN obj = clsMyTest1BL.GetObjByStrKey(strStrKey);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMyTest1ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMyTest1EN> GetAllMyTest1ObjLstCache()
{
//获取缓存中的对象列表
List<clsMyTest1EN> arrMyTest1ObjLstCache = GetObjLstCache(); 
return arrMyTest1ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMyTest1EN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMyTest1EN._CurrTabName);
List<clsMyTest1EN> arrMyTest1ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMyTest1ObjLstCache;
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
string strKey = string.Format("{0}", clsMyTest1EN._CurrTabName);
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
if (clsMyTest1BL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMyTest1EN._CurrTabName);
CacheHelper.Remove(strKey);
clsMyTest1BL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--MyTest1(测试表1)
 /// 唯一性条件:myInt
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMyTest1EN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsMyTest1EN objMyTest1EN)
{
//检测记录是否存在
string strResult = MyTest1DA.GetUniCondStr(objMyTest1EN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strStrKey)
{
if (strInFldName != conMyTest1.StrKey)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMyTest1.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMyTest1.AttributeName));
throw new Exception(strMsg);
}
var objMyTest1 = clsMyTest1BL.GetObjByStrKeyCache(strStrKey);
if (objMyTest1 == null) return "";
return objMyTest1[strOutFldName].ToString();
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
int intRecCount = clsMyTest1DA.GetRecCount(strTabName);
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
int intRecCount = clsMyTest1DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMyTest1DA.GetRecCount();
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
int intRecCount = clsMyTest1DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMyTest1Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMyTest1EN objMyTest1Cond)
{
List<clsMyTest1EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMyTest1EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMyTest1.AttributeName)
{
if (objMyTest1Cond.IsUpdated(strFldName) == false) continue;
if (objMyTest1Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMyTest1Cond[strFldName].ToString());
}
else
{
if (objMyTest1Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMyTest1Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMyTest1Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMyTest1Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMyTest1Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMyTest1Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMyTest1Cond[strFldName]));
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
 List<string> arrList = clsMyTest1DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MyTest1DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MyTest1DA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MyTest1DA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMyTest1DA.SetFldValue(clsMyTest1EN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MyTest1DA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMyTest1DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMyTest1DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMyTest1DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MyTest1] "); 
 strCreateTabCode.Append(" ( "); 
 // /**s主键*/ 
 strCreateTabCode.Append(" StrKey char(4) primary key, "); 
 // /**my整型*/ 
 strCreateTabCode.Append(" myInt int not Null, "); 
 // /**my长整型*/ 
 strCreateTabCode.Append(" myLong bigint not Null, "); 
 // /**my字符串*/ 
 strCreateTabCode.Append(" myString varchar(50) not Null, "); 
 // /**my布尔型*/ 
 strCreateTabCode.Append(" myBool bit not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 测试表1(MyTest1)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MyTest1 : clsCommFun4BL
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
clsMyTest1BL.ReFreshThisCache();
}
}

}