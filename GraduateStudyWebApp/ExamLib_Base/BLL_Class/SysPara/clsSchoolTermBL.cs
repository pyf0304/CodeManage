
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSchoolTermBL
 表名:SchoolTerm(01120135)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsSchoolTermBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSchoolTerm">表关键字</param>
 /// <returns>表对象</returns>
public static clsSchoolTermEN GetObj(this K_SchoolTerm_SchoolTerm myKey)
{
clsSchoolTermEN objSchoolTermEN = clsSchoolTermBL.SchoolTermDA.GetObjBySchoolTerm(myKey.Value);
return objSchoolTermEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSchoolTermEN objSchoolTermEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSchoolTermBL.IsExist(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSchoolTermEN.SchoolTerm, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSchoolTermBL.SchoolTermDA.AddNewRecordBySQL2(objSchoolTermEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
public static bool AddRecordEx(this clsSchoolTermEN objSchoolTermEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSchoolTermBL.IsExist(objSchoolTermEN.SchoolTerm))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSchoolTermEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSchoolTermEN.AddNewRecord();
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
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSchoolTermEN objSchoolTermEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSchoolTermBL.IsExist(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSchoolTermEN.SchoolTerm, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSchoolTermBL.SchoolTermDA.AddNewRecordBySQL2WithReturnKey(objSchoolTermEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSchoolTermEN SetSchoolTerm(this clsSchoolTermEN objSchoolTermEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conSchoolTerm.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conSchoolTerm.SchoolTerm);
}
objSchoolTermEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSchoolTermEN.dicFldComparisonOp.ContainsKey(conSchoolTerm.SchoolTerm) == false)
{
objSchoolTermEN.dicFldComparisonOp.Add(conSchoolTerm.SchoolTerm, strComparisonOp);
}
else
{
objSchoolTermEN.dicFldComparisonOp[conSchoolTerm.SchoolTerm] = strComparisonOp;
}
}
return objSchoolTermEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSchoolTermEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSchoolTermEN SetSchoolTermName(this clsSchoolTermEN objSchoolTermEN, string strSchoolTermName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTermName, 1, conSchoolTerm.SchoolTermName);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTermName, 1, conSchoolTerm.SchoolTermName);
}
objSchoolTermEN.SchoolTermName = strSchoolTermName; //学期名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSchoolTermEN.dicFldComparisonOp.ContainsKey(conSchoolTerm.SchoolTermName) == false)
{
objSchoolTermEN.dicFldComparisonOp.Add(conSchoolTerm.SchoolTermName, strComparisonOp);
}
else
{
objSchoolTermEN.dicFldComparisonOp[conSchoolTerm.SchoolTermName] = strComparisonOp;
}
}
return objSchoolTermEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSchoolTermEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSchoolTermEN SetIsCurrentSchoolTerm(this clsSchoolTermEN objSchoolTermEN, bool bolIsCurrentSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCurrentSchoolTerm, conSchoolTerm.IsCurrentSchoolTerm);
objSchoolTermEN.IsCurrentSchoolTerm = bolIsCurrentSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSchoolTermEN.dicFldComparisonOp.ContainsKey(conSchoolTerm.IsCurrentSchoolTerm) == false)
{
objSchoolTermEN.dicFldComparisonOp.Add(conSchoolTerm.IsCurrentSchoolTerm, strComparisonOp);
}
else
{
objSchoolTermEN.dicFldComparisonOp[conSchoolTerm.IsCurrentSchoolTerm] = strComparisonOp;
}
}
return objSchoolTermEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSchoolTermEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSchoolTermEN objSchoolTermEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSchoolTermEN.CheckPropertyNew();
clsSchoolTermEN objSchoolTermCond = new clsSchoolTermEN();
string strCondition = objSchoolTermCond
.SetSchoolTerm(objSchoolTermEN.SchoolTerm, "=")
.GetCombineCondition();
objSchoolTermEN._IsCheckProperty = true;
bool bolIsExist = clsSchoolTermBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSchoolTermEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSchoolTermEN objSchoolTermEN)
{
 if (string.IsNullOrEmpty(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSchoolTermBL.SchoolTermDA.UpdateBySql2(objSchoolTermEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSchoolTermEN objSchoolTermEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSchoolTermBL.SchoolTermDA.UpdateBySql2(objSchoolTermEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSchoolTermEN objSchoolTermEN, string strWhereCond)
{
try
{
bool bolResult = clsSchoolTermBL.SchoolTermDA.UpdateBySqlWithCondition(objSchoolTermEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSchoolTermEN objSchoolTermEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSchoolTermBL.SchoolTermDA.UpdateBySqlWithConditionTransaction(objSchoolTermEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "strSchoolTerm">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSchoolTermEN objSchoolTermEN)
{
try
{
int intRecNum = clsSchoolTermBL.SchoolTermDA.DelRecord(objSchoolTermEN.SchoolTerm);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermENS">源对象</param>
 /// <param name = "objSchoolTermENT">目标对象</param>
 public static void CopyTo(this clsSchoolTermEN objSchoolTermENS, clsSchoolTermEN objSchoolTermENT)
{
try
{
objSchoolTermENT.SchoolTerm = objSchoolTermENS.SchoolTerm; //学期
objSchoolTermENT.SchoolTermName = objSchoolTermENS.SchoolTermName; //学期名
objSchoolTermENT.IsCurrentSchoolTerm = objSchoolTermENS.IsCurrentSchoolTerm; //学期
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
 /// <param name = "objSchoolTermENS">源对象</param>
 /// <returns>目标对象=>clsSchoolTermEN:objSchoolTermENT</returns>
 public static clsSchoolTermEN CopyTo(this clsSchoolTermEN objSchoolTermENS)
{
try
{
 clsSchoolTermEN objSchoolTermENT = new clsSchoolTermEN()
{
SchoolTerm = objSchoolTermENS.SchoolTerm, //学期
SchoolTermName = objSchoolTermENS.SchoolTermName, //学期名
IsCurrentSchoolTerm = objSchoolTermENS.IsCurrentSchoolTerm, //学期
};
 return objSchoolTermENT;
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
public static void CheckPropertyNew(this clsSchoolTermEN objSchoolTermEN)
{
 clsSchoolTermBL.SchoolTermDA.CheckPropertyNew(objSchoolTermEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSchoolTermEN objSchoolTermEN)
{
 clsSchoolTermBL.SchoolTermDA.CheckProperty4Condition(objSchoolTermEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSchoolTermEN objSchoolTermCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSchoolTermCond.IsUpdated(conSchoolTerm.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objSchoolTermCond.dicFldComparisonOp[conSchoolTerm.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSchoolTerm.SchoolTerm, objSchoolTermCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objSchoolTermCond.IsUpdated(conSchoolTerm.SchoolTermName) == true)
{
string strComparisonOpSchoolTermName = objSchoolTermCond.dicFldComparisonOp[conSchoolTerm.SchoolTermName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSchoolTerm.SchoolTermName, objSchoolTermCond.SchoolTermName, strComparisonOpSchoolTermName);
}
if (objSchoolTermCond.IsUpdated(conSchoolTerm.IsCurrentSchoolTerm) == true)
{
if (objSchoolTermCond.IsCurrentSchoolTerm == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSchoolTerm.IsCurrentSchoolTerm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSchoolTerm.IsCurrentSchoolTerm);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SchoolTerm
{
public virtual bool UpdRelaTabDate(string strSchoolTerm, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学期(SchoolTerm)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSchoolTermBL
{
public static RelatedActions_SchoolTerm relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSchoolTermDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSchoolTermDA SchoolTermDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSchoolTermDA();
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
 public clsSchoolTermBL()
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
if (string.IsNullOrEmpty(clsSchoolTermEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSchoolTermEN._ConnectString);
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
public static DataTable GetDataTable_SchoolTerm(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SchoolTermDA.GetDataTable_SchoolTerm(strWhereCond);
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
objDT = SchoolTermDA.GetDataTable(strWhereCond);
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
objDT = SchoolTermDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SchoolTermDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SchoolTermDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SchoolTermDA.GetDataTable_Top(objTopPara);
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
objDT = SchoolTermDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SchoolTermDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SchoolTermDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSchoolTermLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSchoolTermEN> GetObjLstBySchoolTermLst(List<string> arrSchoolTermLst)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSchoolTermLst, true);
 string strWhereCond = string.Format("SchoolTerm in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSchoolTermLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSchoolTermEN> GetObjLstBySchoolTermLstCache(List<string> arrSchoolTermLst)
{
string strKey = string.Format("{0}", clsSchoolTermEN._CurrTabName);
List<clsSchoolTermEN> arrSchoolTermObjLstCache = GetObjLstCache();
IEnumerable <clsSchoolTermEN> arrSchoolTermObjLst_Sel =
arrSchoolTermObjLstCache
.Where(x => arrSchoolTermLst.Contains(x.SchoolTerm));
return arrSchoolTermObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSchoolTermEN> GetObjLst(string strWhereCond)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
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
public static List<clsSchoolTermEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSchoolTermCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSchoolTermEN> GetSubObjLstCache(clsSchoolTermEN objSchoolTermCond)
{
List<clsSchoolTermEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSchoolTermEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSchoolTerm.AttributeName)
{
if (objSchoolTermCond.IsUpdated(strFldName) == false) continue;
if (objSchoolTermCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSchoolTermCond[strFldName].ToString());
}
else
{
if (objSchoolTermCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSchoolTermCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSchoolTermCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSchoolTermCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSchoolTermCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSchoolTermCond[strFldName]));
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
public static List<clsSchoolTermEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
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
public static List<clsSchoolTermEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
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
List<clsSchoolTermEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSchoolTermEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSchoolTermEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSchoolTermEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
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
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
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
public static List<clsSchoolTermEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSchoolTermEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSchoolTermEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
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
public static List<clsSchoolTermEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSchoolTermEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSchoolTermEN> arrObjLst = new List<clsSchoolTermEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN();
try
{
objSchoolTermEN.SchoolTerm = objRow[conSchoolTerm.SchoolTerm].ToString().Trim(); //学期
objSchoolTermEN.SchoolTermName = objRow[conSchoolTerm.SchoolTermName] == DBNull.Value ? null : objRow[conSchoolTerm.SchoolTermName].ToString().Trim(); //学期名
objSchoolTermEN.IsCurrentSchoolTerm = clsEntityBase2.TransNullToBool_S(objRow[conSchoolTerm.IsCurrentSchoolTerm].ToString().Trim()); //学期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSchoolTermEN.SchoolTerm, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSchoolTermEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSchoolTermEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSchoolTerm(ref clsSchoolTermEN objSchoolTermEN)
{
bool bolResult = SchoolTermDA.GetSchoolTerm(ref objSchoolTermEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSchoolTerm">表关键字</param>
 /// <returns>表对象</returns>
public static clsSchoolTermEN GetObjBySchoolTerm(string strSchoolTerm)
{
if (strSchoolTerm.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSchoolTerm]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSchoolTerm) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSchoolTerm]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSchoolTermEN objSchoolTermEN = SchoolTermDA.GetObjBySchoolTerm(strSchoolTerm);
return objSchoolTermEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSchoolTermEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSchoolTermEN objSchoolTermEN = SchoolTermDA.GetFirstObj(strWhereCond);
 return objSchoolTermEN;
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
public static clsSchoolTermEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSchoolTermEN objSchoolTermEN = SchoolTermDA.GetObjByDataRow(objRow);
 return objSchoolTermEN;
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
public static clsSchoolTermEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSchoolTermEN objSchoolTermEN = SchoolTermDA.GetObjByDataRow(objRow);
 return objSchoolTermEN;
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
 /// <param name = "strSchoolTerm">所给的关键字</param>
 /// <param name = "lstSchoolTermObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSchoolTermEN GetObjBySchoolTermFromList(string strSchoolTerm, List<clsSchoolTermEN> lstSchoolTermObjLst)
{
foreach (clsSchoolTermEN objSchoolTermEN in lstSchoolTermObjLst)
{
if (objSchoolTermEN.SchoolTerm == strSchoolTerm)
{
return objSchoolTermEN;
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
 string strSchoolTerm;
 try
 {
 strSchoolTerm = new clsSchoolTermDA().GetFirstID(strWhereCond);
 return strSchoolTerm;
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
 arrList = SchoolTermDA.GetID(strWhereCond);
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
bool bolIsExist = SchoolTermDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSchoolTerm">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSchoolTerm)
{
if (string.IsNullOrEmpty(strSchoolTerm) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSchoolTerm]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SchoolTermDA.IsExist(strSchoolTerm);
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
 bolIsExist = clsSchoolTermDA.IsExistTable();
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
 bolIsExist = SchoolTermDA.IsExistTable(strTabName);
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
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSchoolTermEN objSchoolTermEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSchoolTermBL.IsExist(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSchoolTermEN.SchoolTerm, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SchoolTermDA.AddNewRecordBySQL2(objSchoolTermEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSchoolTermEN objSchoolTermEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSchoolTermBL.IsExist(objSchoolTermEN.SchoolTerm) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSchoolTermEN.SchoolTerm, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SchoolTermDA.AddNewRecordBySQL2WithReturnKey(objSchoolTermEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSchoolTermEN objSchoolTermEN)
{
try
{
bool bolResult = SchoolTermDA.Update(objSchoolTermEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "objSchoolTermEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSchoolTermEN objSchoolTermEN)
{
 if (string.IsNullOrEmpty(objSchoolTermEN.SchoolTerm) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SchoolTermDA.UpdateBySql2(objSchoolTermEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSchoolTermBL.ReFreshCache();

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
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
 /// <param name = "strSchoolTerm">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSchoolTerm)
{
try
{
 clsSchoolTermEN objSchoolTermEN = clsSchoolTermBL.GetObjBySchoolTerm(strSchoolTerm);

if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(objSchoolTermEN.SchoolTerm, "SetUpdDate");
}
if (objSchoolTermEN != null)
{
int intRecNum = SchoolTermDA.DelRecord(strSchoolTerm);
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
/// <param name="strSchoolTerm">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strSchoolTerm )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSchoolTermDA.GetSpecSQLObj();
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
//删除与表:[SchoolTerm]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSchoolTerm.SchoolTerm,
//strSchoolTerm);
//        clsSchoolTermBL.DelSchoolTermsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSchoolTermBL.DelRecord(strSchoolTerm, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSchoolTermBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSchoolTerm, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSchoolTerm">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSchoolTerm, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSchoolTermBL.relatedActions != null)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(strSchoolTerm, "UpdRelaTabDate");
}
bool bolResult = SchoolTermDA.DelRecord(strSchoolTerm,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSchoolTermLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSchoolTerms(List<string> arrSchoolTermLst)
{
if (arrSchoolTermLst.Count == 0) return 0;
try
{
if (clsSchoolTermBL.relatedActions != null)
{
foreach (var strSchoolTerm in arrSchoolTermLst)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(strSchoolTerm, "UpdRelaTabDate");
}
}
int intDelRecNum = SchoolTermDA.DelSchoolTerm(arrSchoolTermLst);
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
public static int DelSchoolTermsByCond(string strWhereCond)
{
try
{
if (clsSchoolTermBL.relatedActions != null)
{
List<string> arrSchoolTerm = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSchoolTerm in arrSchoolTerm)
{
clsSchoolTermBL.relatedActions.UpdRelaTabDate(strSchoolTerm, "UpdRelaTabDate");
}
}
int intRecNum = SchoolTermDA.DelSchoolTerm(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SchoolTerm]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSchoolTerm">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSchoolTerm)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSchoolTermDA.GetSpecSQLObj();
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
//删除与表:[SchoolTerm]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSchoolTermBL.DelRecord(strSchoolTerm, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSchoolTermBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSchoolTerm, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSchoolTermENS">源对象</param>
 /// <param name = "objSchoolTermENT">目标对象</param>
 public static void CopyTo(clsSchoolTermEN objSchoolTermENS, clsSchoolTermEN objSchoolTermENT)
{
try
{
objSchoolTermENT.SchoolTerm = objSchoolTermENS.SchoolTerm; //学期
objSchoolTermENT.SchoolTermName = objSchoolTermENS.SchoolTermName; //学期名
objSchoolTermENT.IsCurrentSchoolTerm = objSchoolTermENS.IsCurrentSchoolTerm; //学期
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
 /// <param name = "objSchoolTermEN">源简化对象</param>
 public static void SetUpdFlag(clsSchoolTermEN objSchoolTermEN)
{
try
{
objSchoolTermEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSchoolTermEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSchoolTerm.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objSchoolTermEN.SchoolTerm = objSchoolTermEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conSchoolTerm.SchoolTermName, new clsStrCompareIgnoreCase())  ==  true)
{
objSchoolTermEN.SchoolTermName = objSchoolTermEN.SchoolTermName == "[null]" ? null :  objSchoolTermEN.SchoolTermName; //学期名
}
if (arrFldSet.Contains(conSchoolTerm.IsCurrentSchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objSchoolTermEN.IsCurrentSchoolTerm = objSchoolTermEN.IsCurrentSchoolTerm; //学期
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
 /// <param name = "objSchoolTermEN">源简化对象</param>
 public static void AccessFldValueNull(clsSchoolTermEN objSchoolTermEN)
{
try
{
if (objSchoolTermEN.SchoolTermName == "[null]") objSchoolTermEN.SchoolTermName = null; //学期名
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
public static void CheckPropertyNew(clsSchoolTermEN objSchoolTermEN)
{
 SchoolTermDA.CheckPropertyNew(objSchoolTermEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSchoolTermEN objSchoolTermEN)
{
 SchoolTermDA.CheckProperty4Condition(objSchoolTermEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_SchoolTerm(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSchoolTerm.SchoolTerm); 
List<clsSchoolTermEN> arrObjLst = clsSchoolTermBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSchoolTermEN objSchoolTermEN = new clsSchoolTermEN()
{
SchoolTerm = "0",
SchoolTermName = "选[学期]..."
};
arrObjLst.Insert(0, objSchoolTermEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSchoolTerm.SchoolTerm;
objComboBox.DisplayMember = conSchoolTerm.SchoolTermName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_SchoolTerm(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学期]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSchoolTerm.SchoolTerm); 
IEnumerable<clsSchoolTermEN> arrObjLst = clsSchoolTermBL.GetObjLst(strCondition);
objDDL.DataValueField = conSchoolTerm.SchoolTerm;
objDDL.DataTextField = conSchoolTerm.SchoolTermName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SchoolTermCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学期]...","0");
List<clsSchoolTermEN> arrSchoolTermObjLst = GetAllSchoolTermObjLstCache(); 
objDDL.DataValueField = conSchoolTerm.SchoolTerm;
objDDL.DataTextField = conSchoolTerm.SchoolTermName;
objDDL.DataSource = arrSchoolTermObjLst;
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
if (clsSchoolTermBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSchoolTermBL没有刷新缓存机制(clsSchoolTermBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SchoolTerm");
//if (arrSchoolTermObjLstCache == null)
//{
//arrSchoolTermObjLstCache = SchoolTermDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSchoolTerm">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSchoolTermEN GetObjBySchoolTermCache(string strSchoolTerm)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSchoolTermEN._CurrTabName);
List<clsSchoolTermEN> arrSchoolTermObjLstCache = GetObjLstCache();
IEnumerable <clsSchoolTermEN> arrSchoolTermObjLst_Sel =
arrSchoolTermObjLstCache
.Where(x=> x.SchoolTerm == strSchoolTerm 
);
if (arrSchoolTermObjLst_Sel.Count() == 0)
{
   clsSchoolTermEN obj = clsSchoolTermBL.GetObjBySchoolTerm(strSchoolTerm);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSchoolTermObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSchoolTerm">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolTermNameBySchoolTermCache(string strSchoolTerm)
{
if (string.IsNullOrEmpty(strSchoolTerm) == true) return "";
//获取缓存中的对象列表
clsSchoolTermEN objSchoolTerm = GetObjBySchoolTermCache(strSchoolTerm);
if (objSchoolTerm == null) return "";
return objSchoolTerm.SchoolTermName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSchoolTerm">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySchoolTermCache(string strSchoolTerm)
{
if (string.IsNullOrEmpty(strSchoolTerm) == true) return "";
//获取缓存中的对象列表
clsSchoolTermEN objSchoolTerm = GetObjBySchoolTermCache(strSchoolTerm);
if (objSchoolTerm == null) return "";
return objSchoolTerm.SchoolTermName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSchoolTermEN> GetAllSchoolTermObjLstCache()
{
//获取缓存中的对象列表
List<clsSchoolTermEN> arrSchoolTermObjLstCache = GetObjLstCache(); 
return arrSchoolTermObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSchoolTermEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSchoolTermEN._CurrTabName);
List<clsSchoolTermEN> arrSchoolTermObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSchoolTermObjLstCache;
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
string strKey = string.Format("{0}", clsSchoolTermEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSchoolTermEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSchoolTermEN._RefreshTimeLst.Count == 0) return "";
return clsSchoolTermEN._RefreshTimeLst[clsSchoolTermEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSchoolTermBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSchoolTermEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSchoolTermEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSchoolTermBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strSchoolTerm)
{
if (strInFldName != conSchoolTerm.SchoolTerm)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSchoolTerm.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSchoolTerm.AttributeName));
throw new Exception(strMsg);
}
var objSchoolTerm = clsSchoolTermBL.GetObjBySchoolTermCache(strSchoolTerm);
if (objSchoolTerm == null) return "";
return objSchoolTerm[strOutFldName].ToString();
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
int intRecCount = clsSchoolTermDA.GetRecCount(strTabName);
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
int intRecCount = clsSchoolTermDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSchoolTermDA.GetRecCount();
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
int intRecCount = clsSchoolTermDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSchoolTermCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSchoolTermEN objSchoolTermCond)
{
List<clsSchoolTermEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSchoolTermEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSchoolTerm.AttributeName)
{
if (objSchoolTermCond.IsUpdated(strFldName) == false) continue;
if (objSchoolTermCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSchoolTermCond[strFldName].ToString());
}
else
{
if (objSchoolTermCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSchoolTermCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSchoolTermCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSchoolTermCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSchoolTermCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSchoolTermCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSchoolTermCond[strFldName]));
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
 List<string> arrList = clsSchoolTermDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SchoolTermDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SchoolTermDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SchoolTermDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSchoolTermDA.SetFldValue(clsSchoolTermEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SchoolTermDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSchoolTermDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSchoolTermDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSchoolTermDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SchoolTerm] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) primary key, "); 
 // /**学期名*/ 
 strCreateTabCode.Append(" SchoolTermName char(1) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" IsCurrentSchoolTerm bit not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 学期(SchoolTerm)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SchoolTerm : clsCommFun4BL
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
clsSchoolTermBL.ReFreshThisCache();
}
}

}