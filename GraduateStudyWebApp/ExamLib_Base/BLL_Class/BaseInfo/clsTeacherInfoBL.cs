
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeacherInfoBL
 表名:TeacherInfo(01120093)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
public static class  clsTeacherInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeacherInfoEN GetObj(this K_IdTeacher_TeacherInfo myKey)
{
clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoBL.TeacherInfoDA.GetObjByIdTeacher(myKey.Value);
return objTeacherInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTeacherInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!教师工号 = [{0}]的数据已经存在!(in clsTeacherInfoBL.AddNewRecord)", objTeacherInfoEN.TeacherId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true || clsTeacherInfoBL.IsExist(objTeacherInfoEN.IdTeacher) == true)
 {
     objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
 }
bool bolResult = clsTeacherInfoBL.TeacherInfoDA.AddNewRecordBySQL2(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
public static bool AddRecordEx(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsTeacherInfoBL.IsExist(objTeacherInfoEN.IdTeacher))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objTeacherInfoEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTeacherInfoEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教师工号(TeacherId)=[{0}])已经存在,不能重复!", objTeacherInfoEN.TeacherId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true || clsTeacherInfoBL.IsExist(objTeacherInfoEN.IdTeacher) == true)
 {
     objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objTeacherInfoEN.AddNewRecord();
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTeacherInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!教师工号 = [{0}]的数据已经存在!(in clsTeacherInfoBL.AddNewRecordWithMaxId)", objTeacherInfoEN.TeacherId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true || clsTeacherInfoBL.IsExist(objTeacherInfoEN.IdTeacher) == true)
 {
     objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
 }
string strIdTeacher = clsTeacherInfoBL.TeacherInfoDA.AddNewRecordBySQL2WithReturnKey(objTeacherInfoEN);
     objTeacherInfoEN.IdTeacher = strIdTeacher;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
}
return strIdTeacher;
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTeacherInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!教师工号 = [{0}]的数据已经存在!(in clsTeacherInfoBL.AddNewRecordWithReturnKey)", objTeacherInfoEN.TeacherId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true || clsTeacherInfoBL.IsExist(objTeacherInfoEN.IdTeacher) == true)
 {
     objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
 }
string strKey = clsTeacherInfoBL.TeacherInfoDA.AddNewRecordBySQL2WithReturnKey(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdTeacher(this clsTeacherInfoEN objTeacherInfoEN, string strIdTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, conTeacherInfo.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, conTeacherInfo.IdTeacher);
}
objTeacherInfoEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdTeacher) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdTeacher, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdTeacher] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetTeacherId(this clsTeacherInfoEN objTeacherInfoEN, string strTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherId, conTeacherInfo.TeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, conTeacherInfo.TeacherId);
}
objTeacherInfoEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeacherId) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeacherId, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeacherId] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetTeacherName(this clsTeacherInfoEN objTeacherInfoEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, conTeacherInfo.TeacherName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, conTeacherInfo.TeacherName);
}
objTeacherInfoEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeacherName) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeacherName, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeacherName] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdSex(this clsTeacherInfoEN objTeacherInfoEN, string strIdSex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSex, conTeacherInfo.IdSex);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSex, 4, conTeacherInfo.IdSex);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSex, 4, conTeacherInfo.IdSex);
}
objTeacherInfoEN.IdSex = strIdSex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdSex) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdSex, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdSex] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdSchoolPs(this clsTeacherInfoEN objTeacherInfoEN, string strIdSchoolPs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchoolPs, 4, conTeacherInfo.IdSchoolPs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchoolPs, 4, conTeacherInfo.IdSchoolPs);
}
objTeacherInfoEN.IdSchoolPs = strIdSchoolPs; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdSchoolPs) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdSchoolPs, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdSchoolPs] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdDisciplinePs(this clsTeacherInfoEN objTeacherInfoEN, string strIdDisciplinePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDisciplinePs, 4, conTeacherInfo.IdDisciplinePs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDisciplinePs, 4, conTeacherInfo.IdDisciplinePs);
}
objTeacherInfoEN.IdDisciplinePs = strIdDisciplinePs; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdDisciplinePs) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdDisciplinePs, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdDisciplinePs] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdUniZone(this clsTeacherInfoEN objTeacherInfoEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, conTeacherInfo.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, conTeacherInfo.IdUniZone);
}
objTeacherInfoEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdUniZone) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdUniZone, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdUniZone] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdEthnic(this clsTeacherInfoEN objTeacherInfoEN, string strIdEthnic, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEthnic, 4, conTeacherInfo.IdEthnic);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEthnic, 4, conTeacherInfo.IdEthnic);
}
objTeacherInfoEN.IdEthnic = strIdEthnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdEthnic) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdEthnic, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdEthnic] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdPolitics(this clsTeacherInfoEN objTeacherInfoEN, string strIdPolitics, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPolitics, 4, conTeacherInfo.IdPolitics);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPolitics, 4, conTeacherInfo.IdPolitics);
}
objTeacherInfoEN.IdPolitics = strIdPolitics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdPolitics) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdPolitics, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdPolitics] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdAdminGrade(this clsTeacherInfoEN objTeacherInfoEN, string strIdAdminGrade, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminGrade, 4, conTeacherInfo.IdAdminGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminGrade, 4, conTeacherInfo.IdAdminGrade);
}
objTeacherInfoEN.IdAdminGrade = strIdAdminGrade; //行政职务流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdAdminGrade) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdAdminGrade, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdAdminGrade] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdProfGrade(this clsTeacherInfoEN objTeacherInfoEN, string strIdProfGrade, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdProfGrade, 4, conTeacherInfo.IdProfGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdProfGrade, 4, conTeacherInfo.IdProfGrade);
}
objTeacherInfoEN.IdProfGrade = strIdProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdProfGrade) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdProfGrade, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdProfGrade] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdQualif(this clsTeacherInfoEN objTeacherInfoEN, string strIdQualif, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdQualif, 4, conTeacherInfo.IdQualif);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdQualif, 4, conTeacherInfo.IdQualif);
}
objTeacherInfoEN.IdQualif = strIdQualif; //学历流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdQualif) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdQualif, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdQualif] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdDegree(this clsTeacherInfoEN objTeacherInfoEN, string strIdDegree, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDegree, 4, conTeacherInfo.IdDegree);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDegree, 4, conTeacherInfo.IdDegree);
}
objTeacherInfoEN.IdDegree = strIdDegree; //学位流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdDegree) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdDegree, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdDegree] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdStaffType(this clsTeacherInfoEN objTeacherInfoEN, string strIdStaffType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStaffType, 4, conTeacherInfo.IdStaffType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStaffType, 4, conTeacherInfo.IdStaffType);
}
objTeacherInfoEN.IdStaffType = strIdStaffType; //职工类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdStaffType) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdStaffType, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdStaffType] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdProvince(this clsTeacherInfoEN objTeacherInfoEN, string strIdProvince, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdProvince, 4, conTeacherInfo.IdProvince);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdProvince, 4, conTeacherInfo.IdProvince);
}
objTeacherInfoEN.IdProvince = strIdProvince; //省份流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdProvince) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdProvince, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdProvince] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetCitizenId(this clsTeacherInfoEN objTeacherInfoEN, string strCitizenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitizenId, 25, conTeacherInfo.CitizenId);
}
objTeacherInfoEN.CitizenId = strCitizenId; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.CitizenId) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.CitizenId, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.CitizenId] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetCardNo(this clsTeacherInfoEN objTeacherInfoEN, string strCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardNo, 18, conTeacherInfo.CardNo);
}
objTeacherInfoEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.CardNo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.CardNo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.CardNo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetBirthday(this clsTeacherInfoEN objTeacherInfoEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, conTeacherInfo.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, conTeacherInfo.Birthday);
}
objTeacherInfoEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Birthday) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Birthday, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Birthday] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetGraduationMajor(this clsTeacherInfoEN objTeacherInfoEN, string strGraduationMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGraduationMajor, 40, conTeacherInfo.GraduationMajor);
}
objTeacherInfoEN.GraduationMajor = strGraduationMajor; //毕业专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.GraduationMajor) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.GraduationMajor, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.GraduationMajor] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetTelNo(this clsTeacherInfoEN objTeacherInfoEN, string strTelNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTelNo, 50, conTeacherInfo.TelNo);
}
objTeacherInfoEN.TelNo = strTelNo; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TelNo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TelNo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TelNo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetEmail(this clsTeacherInfoEN objTeacherInfoEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, conTeacherInfo.Email);
}
objTeacherInfoEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Email) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Email, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Email] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetWebSite(this clsTeacherInfoEN objTeacherInfoEN, string strWebSite, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSite, 60, conTeacherInfo.WebSite);
}
objTeacherInfoEN.WebSite = strWebSite; //个人主页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.WebSite) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.WebSite, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.WebSite] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetPersonBlog(this clsTeacherInfoEN objTeacherInfoEN, string strPersonBlog, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPersonBlog, 60, conTeacherInfo.PersonBlog);
}
objTeacherInfoEN.PersonBlog = strPersonBlog; //个人博客
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.PersonBlog) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.PersonBlog, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.PersonBlog] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetEntryDate(this clsTeacherInfoEN objTeacherInfoEN, string strEntryDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryDate, 8, conTeacherInfo.EntryDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, conTeacherInfo.EntryDate);
}
objTeacherInfoEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.EntryDate) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.EntryDate, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.EntryDate] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetOffed(this clsTeacherInfoEN objTeacherInfoEN, bool bolOffed, string strComparisonOp="")
	{
objTeacherInfoEN.Offed = bolOffed; //是否离校
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Offed) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Offed, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Offed] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIsAvconUser(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsAvconUser, string strComparisonOp="")
	{
objTeacherInfoEN.IsAvconUser = bolIsAvconUser; //IsAvconUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsAvconUser) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsAvconUser, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsAvconUser] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIsGpUser(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsGpUser, string strComparisonOp="")
	{
objTeacherInfoEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsGpUser) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsGpUser, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsGpUser] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIsLocalUser(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsLocalUser, string strComparisonOp="")
	{
objTeacherInfoEN.IsLocalUser = bolIsLocalUser; //是否本地用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsLocalUser) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsLocalUser, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsLocalUser] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetFromUnit(this clsTeacherInfoEN objTeacherInfoEN, string strFromUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFromUnit, 100, conTeacherInfo.FromUnit);
}
objTeacherInfoEN.FromUnit = strFromUnit; //来自单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.FromUnit) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.FromUnit, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.FromUnit] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetMemo(this clsTeacherInfoEN objTeacherInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeacherInfo.Memo);
}
objTeacherInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Memo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Memo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Memo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdXzCollege(this clsTeacherInfoEN objTeacherInfoEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conTeacherInfo.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conTeacherInfo.IdXzCollege);
}
objTeacherInfoEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdXzCollege) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdXzCollege, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdXzCollege] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdXzMajor(this clsTeacherInfoEN objTeacherInfoEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conTeacherInfo.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conTeacherInfo.IdXzMajor);
}
objTeacherInfoEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdXzMajor) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdXzMajor, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdXzMajor] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetEntryDay(this clsTeacherInfoEN objTeacherInfoEN, string strEntryDay, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryDay, 8, conTeacherInfo.EntryDay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEntryDay, 8, conTeacherInfo.EntryDay);
}
objTeacherInfoEN.EntryDay = strEntryDay; //EntryDay
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.EntryDay) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.EntryDay, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.EntryDay] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdPhoto(this clsTeacherInfoEN objTeacherInfoEN, string strIdPhoto, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPhoto, 8, conTeacherInfo.IdPhoto);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPhoto, 8, conTeacherInfo.IdPhoto);
}
objTeacherInfoEN.IdPhoto = strIdPhoto; //id_Photo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdPhoto) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdPhoto, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdPhoto] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdReligion(this clsTeacherInfoEN objTeacherInfoEN, string strIdReligion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdReligion, 4, conTeacherInfo.IdReligion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdReligion, 4, conTeacherInfo.IdReligion);
}
objTeacherInfoEN.IdReligion = strIdReligion; //id_Religion
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdReligion) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdReligion, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdReligion] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIsMessage(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsMessage, string strComparisonOp="")
	{
objTeacherInfoEN.IsMessage = bolIsMessage; //IsMessage
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsMessage) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsMessage, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsMessage] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetMicroblog(this clsTeacherInfoEN objTeacherInfoEN, string strMicroblog, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroblog, 200, conTeacherInfo.Microblog);
}
objTeacherInfoEN.Microblog = strMicroblog; //Microblog
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Microblog) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Microblog, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Microblog] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetModifyUserId(this clsTeacherInfoEN objTeacherInfoEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conTeacherInfo.ModifyUserId);
}
objTeacherInfoEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.ModifyUserId) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.ModifyUserId, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.ModifyUserId] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetOffedBak(this clsTeacherInfoEN objTeacherInfoEN, bool bolOffedBak, string strComparisonOp="")
	{
objTeacherInfoEN.OffedBak = bolOffedBak; //OffedBak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.OffedBak) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.OffedBak, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.OffedBak] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetPhoneNumber(this clsTeacherInfoEN objTeacherInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conTeacherInfo.PhoneNumber);
}
objTeacherInfoEN.PhoneNumber = strPhoneNumber; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.PhoneNumber) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.PhoneNumber, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.PhoneNumber] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetQQ(this clsTeacherInfoEN objTeacherInfoEN, string strQQ, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQQ, 100, conTeacherInfo.QQ);
}
objTeacherInfoEN.QQ = strQQ; //QQ
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.QQ) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.QQ, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.QQ] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetTeachIdCollege(this clsTeacherInfoEN objTeacherInfoEN, string strTeachIdCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachIdCollege, 6, conTeacherInfo.TeachIdCollege);
}
objTeacherInfoEN.TeachIdCollege = strTeachIdCollege; //Teach_id_College
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeachIdCollege) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeachIdCollege, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeachIdCollege] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetTeachIdMajor(this clsTeacherInfoEN objTeacherInfoEN, string strTeachIdMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachIdMajor, 8, conTeacherInfo.TeachIdMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachIdMajor, 8, conTeacherInfo.TeachIdMajor);
}
objTeacherInfoEN.TeachIdMajor = strTeachIdMajor; //Teach_id_Major
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeachIdMajor) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeachIdMajor, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeachIdMajor] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetTel(this clsTeacherInfoEN objTeacherInfoEN, string strTel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTel, 50, conTeacherInfo.Tel);
}
objTeacherInfoEN.Tel = strTel; //Tel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Tel) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Tel, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Tel] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetHeadphoto(this clsTeacherInfoEN objTeacherInfoEN, string strHeadphoto, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHeadphoto, 500, conTeacherInfo.Headphoto);
}
objTeacherInfoEN.Headphoto = strHeadphoto; //Headphoto
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Headphoto) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Headphoto, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Headphoto] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetModifyDate(this clsTeacherInfoEN objTeacherInfoEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conTeacherInfo.ModifyDate);
}
objTeacherInfoEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.ModifyDate) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.ModifyDate, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.ModifyDate] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetRegisterPassword(this clsTeacherInfoEN objTeacherInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, conTeacherInfo.RegisterPassword);
}
objTeacherInfoEN.RegisterPassword = strRegisterPassword; //RegisterPassword
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.RegisterPassword) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.RegisterPassword, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.RegisterPassword] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetTeacherPhoto(this clsTeacherInfoEN objTeacherInfoEN, string strTeacherPhoto, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherPhoto, 500, conTeacherInfo.TeacherPhoto);
}
objTeacherInfoEN.TeacherPhoto = strTeacherPhoto; //TeacherPhoto
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeacherPhoto) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeacherPhoto, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeacherPhoto] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeacherInfoEN SetIdCardNo(this clsTeacherInfoEN objTeacherInfoEN, string strIdCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo, 20, conTeacherInfo.IdCardNo);
}
objTeacherInfoEN.IdCardNo = strIdCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IdCardNo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IdCardNo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IdCardNo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTeacherInfoEN objTeacherInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTeacherInfoEN.CheckPropertyNew();
clsTeacherInfoEN objTeacherInfoCond = new clsTeacherInfoEN();
string strCondition = objTeacherInfoCond
.SetIdTeacher(objTeacherInfoEN.IdTeacher, "<>")
.SetTeacherId(objTeacherInfoEN.TeacherId, "=")
.GetCombineCondition();
objTeacherInfoEN._IsCheckProperty = true;
bool bolIsExist = clsTeacherInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TeacherID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTeacherInfoEN.Update();
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
 /// <param name = "objTeacherInfo">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTeacherInfoEN objTeacherInfo)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTeacherInfoEN objTeacherInfoCond = new clsTeacherInfoEN();
string strCondition = objTeacherInfoCond
.SetTeacherId(objTeacherInfo.TeacherId, "=")
.GetCombineCondition();
objTeacherInfo._IsCheckProperty = true;
bool bolIsExist = clsTeacherInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTeacherInfo.IdTeacher = clsTeacherInfoBL.GetFirstID_S(strCondition);
objTeacherInfo.UpdateWithCondition(strCondition);
}
else
{
objTeacherInfo.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
objTeacherInfo.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeacherInfoEN objTeacherInfoEN)
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeacherInfoBL.TeacherInfoDA.UpdateBySql2(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeacherInfoEN objTeacherInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeacherInfoBL.TeacherInfoDA.UpdateBySql2(objTeacherInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeacherInfoEN objTeacherInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsTeacherInfoBL.TeacherInfoDA.UpdateBySqlWithCondition(objTeacherInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeacherInfoEN objTeacherInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTeacherInfoBL.TeacherInfoDA.UpdateBySqlWithConditionTransaction(objTeacherInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTeacherInfoEN objTeacherInfoEN)
{
try
{
int intRecNum = clsTeacherInfoBL.TeacherInfoDA.DelRecord(objTeacherInfoEN.IdTeacher);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoENS">源对象</param>
 /// <param name = "objTeacherInfoENT">目标对象</param>
 public static void CopyTo(this clsTeacherInfoEN objTeacherInfoENS, clsTeacherInfoEN objTeacherInfoENT)
{
try
{
objTeacherInfoENT.IdTeacher = objTeacherInfoENS.IdTeacher; //教师流水号
objTeacherInfoENT.TeacherId = objTeacherInfoENS.TeacherId; //教师工号
objTeacherInfoENT.TeacherName = objTeacherInfoENS.TeacherName; //教师姓名
objTeacherInfoENT.IdSex = objTeacherInfoENS.IdSex; //性别流水号
objTeacherInfoENT.IdSchoolPs = objTeacherInfoENS.IdSchoolPs; //学校流水号
objTeacherInfoENT.IdDisciplinePs = objTeacherInfoENS.IdDisciplinePs; //学科流水号
objTeacherInfoENT.IdUniZone = objTeacherInfoENS.IdUniZone; //校区流水号
objTeacherInfoENT.IdEthnic = objTeacherInfoENS.IdEthnic; //民族流水号
objTeacherInfoENT.IdPolitics = objTeacherInfoENS.IdPolitics; //政治面貌流水号
objTeacherInfoENT.IdAdminGrade = objTeacherInfoENS.IdAdminGrade; //行政职务流水号
objTeacherInfoENT.IdProfGrade = objTeacherInfoENS.IdProfGrade; //专业职称流水号
objTeacherInfoENT.IdQualif = objTeacherInfoENS.IdQualif; //学历流水号
objTeacherInfoENT.IdDegree = objTeacherInfoENS.IdDegree; //学位流水号
objTeacherInfoENT.IdStaffType = objTeacherInfoENS.IdStaffType; //职工类型流水号
objTeacherInfoENT.IdProvince = objTeacherInfoENS.IdProvince; //省份流水号
objTeacherInfoENT.CitizenId = objTeacherInfoENS.CitizenId; //身份证号
objTeacherInfoENT.CardNo = objTeacherInfoENS.CardNo; //卡号
objTeacherInfoENT.Birthday = objTeacherInfoENS.Birthday; //出生日期
objTeacherInfoENT.GraduationMajor = objTeacherInfoENS.GraduationMajor; //毕业专业
objTeacherInfoENT.TelNo = objTeacherInfoENS.TelNo; //电话
objTeacherInfoENT.Email = objTeacherInfoENS.Email; //电子邮箱
objTeacherInfoENT.WebSite = objTeacherInfoENS.WebSite; //个人主页
objTeacherInfoENT.PersonBlog = objTeacherInfoENS.PersonBlog; //个人博客
objTeacherInfoENT.EntryDate = objTeacherInfoENS.EntryDate; //进校日期
objTeacherInfoENT.Offed = objTeacherInfoENS.Offed; //是否离校
objTeacherInfoENT.IsAvconUser = objTeacherInfoENS.IsAvconUser; //IsAvconUser
objTeacherInfoENT.IsGpUser = objTeacherInfoENS.IsGpUser; //是否Gp用户
objTeacherInfoENT.IsLocalUser = objTeacherInfoENS.IsLocalUser; //是否本地用户
objTeacherInfoENT.FromUnit = objTeacherInfoENS.FromUnit; //来自单位
objTeacherInfoENT.Memo = objTeacherInfoENS.Memo; //备注
objTeacherInfoENT.IdXzCollege = objTeacherInfoENS.IdXzCollege; //学院流水号
objTeacherInfoENT.IdXzMajor = objTeacherInfoENS.IdXzMajor; //专业流水号
objTeacherInfoENT.EntryDay = objTeacherInfoENS.EntryDay; //EntryDay
objTeacherInfoENT.IdPhoto = objTeacherInfoENS.IdPhoto; //id_Photo
objTeacherInfoENT.IdReligion = objTeacherInfoENS.IdReligion; //id_Religion
objTeacherInfoENT.IsMessage = objTeacherInfoENS.IsMessage; //IsMessage
objTeacherInfoENT.Microblog = objTeacherInfoENS.Microblog; //Microblog
objTeacherInfoENT.ModifyUserId = objTeacherInfoENS.ModifyUserId; //修改人
objTeacherInfoENT.OffedBak = objTeacherInfoENS.OffedBak; //OffedBak
objTeacherInfoENT.PhoneNumber = objTeacherInfoENS.PhoneNumber; //电话
objTeacherInfoENT.QQ = objTeacherInfoENS.QQ; //QQ
objTeacherInfoENT.TeachIdCollege = objTeacherInfoENS.TeachIdCollege; //Teach_id_College
objTeacherInfoENT.TeachIdMajor = objTeacherInfoENS.TeachIdMajor; //Teach_id_Major
objTeacherInfoENT.Tel = objTeacherInfoENS.Tel; //Tel
objTeacherInfoENT.Headphoto = objTeacherInfoENS.Headphoto; //Headphoto
objTeacherInfoENT.ModifyDate = objTeacherInfoENS.ModifyDate; //修改日期
objTeacherInfoENT.RegisterPassword = objTeacherInfoENS.RegisterPassword; //RegisterPassword
objTeacherInfoENT.TeacherPhoto = objTeacherInfoENS.TeacherPhoto; //TeacherPhoto
objTeacherInfoENT.IdCardNo = objTeacherInfoENS.IdCardNo; //身份证号
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
 /// <param name = "objTeacherInfoENS">源对象</param>
 /// <returns>目标对象=>clsTeacherInfoEN:objTeacherInfoENT</returns>
 public static clsTeacherInfoEN CopyTo(this clsTeacherInfoEN objTeacherInfoENS)
{
try
{
 clsTeacherInfoEN objTeacherInfoENT = new clsTeacherInfoEN()
{
IdTeacher = objTeacherInfoENS.IdTeacher, //教师流水号
TeacherId = objTeacherInfoENS.TeacherId, //教师工号
TeacherName = objTeacherInfoENS.TeacherName, //教师姓名
IdSex = objTeacherInfoENS.IdSex, //性别流水号
IdSchoolPs = objTeacherInfoENS.IdSchoolPs, //学校流水号
IdDisciplinePs = objTeacherInfoENS.IdDisciplinePs, //学科流水号
IdUniZone = objTeacherInfoENS.IdUniZone, //校区流水号
IdEthnic = objTeacherInfoENS.IdEthnic, //民族流水号
IdPolitics = objTeacherInfoENS.IdPolitics, //政治面貌流水号
IdAdminGrade = objTeacherInfoENS.IdAdminGrade, //行政职务流水号
IdProfGrade = objTeacherInfoENS.IdProfGrade, //专业职称流水号
IdQualif = objTeacherInfoENS.IdQualif, //学历流水号
IdDegree = objTeacherInfoENS.IdDegree, //学位流水号
IdStaffType = objTeacherInfoENS.IdStaffType, //职工类型流水号
IdProvince = objTeacherInfoENS.IdProvince, //省份流水号
CitizenId = objTeacherInfoENS.CitizenId, //身份证号
CardNo = objTeacherInfoENS.CardNo, //卡号
Birthday = objTeacherInfoENS.Birthday, //出生日期
GraduationMajor = objTeacherInfoENS.GraduationMajor, //毕业专业
TelNo = objTeacherInfoENS.TelNo, //电话
Email = objTeacherInfoENS.Email, //电子邮箱
WebSite = objTeacherInfoENS.WebSite, //个人主页
PersonBlog = objTeacherInfoENS.PersonBlog, //个人博客
EntryDate = objTeacherInfoENS.EntryDate, //进校日期
Offed = objTeacherInfoENS.Offed, //是否离校
IsAvconUser = objTeacherInfoENS.IsAvconUser, //IsAvconUser
IsGpUser = objTeacherInfoENS.IsGpUser, //是否Gp用户
IsLocalUser = objTeacherInfoENS.IsLocalUser, //是否本地用户
FromUnit = objTeacherInfoENS.FromUnit, //来自单位
Memo = objTeacherInfoENS.Memo, //备注
IdXzCollege = objTeacherInfoENS.IdXzCollege, //学院流水号
IdXzMajor = objTeacherInfoENS.IdXzMajor, //专业流水号
EntryDay = objTeacherInfoENS.EntryDay, //EntryDay
IdPhoto = objTeacherInfoENS.IdPhoto, //id_Photo
IdReligion = objTeacherInfoENS.IdReligion, //id_Religion
IsMessage = objTeacherInfoENS.IsMessage, //IsMessage
Microblog = objTeacherInfoENS.Microblog, //Microblog
ModifyUserId = objTeacherInfoENS.ModifyUserId, //修改人
OffedBak = objTeacherInfoENS.OffedBak, //OffedBak
PhoneNumber = objTeacherInfoENS.PhoneNumber, //电话
QQ = objTeacherInfoENS.QQ, //QQ
TeachIdCollege = objTeacherInfoENS.TeachIdCollege, //Teach_id_College
TeachIdMajor = objTeacherInfoENS.TeachIdMajor, //Teach_id_Major
Tel = objTeacherInfoENS.Tel, //Tel
Headphoto = objTeacherInfoENS.Headphoto, //Headphoto
ModifyDate = objTeacherInfoENS.ModifyDate, //修改日期
RegisterPassword = objTeacherInfoENS.RegisterPassword, //RegisterPassword
TeacherPhoto = objTeacherInfoENS.TeacherPhoto, //TeacherPhoto
IdCardNo = objTeacherInfoENS.IdCardNo, //身份证号
};
 return objTeacherInfoENT;
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
public static void CheckPropertyNew(this clsTeacherInfoEN objTeacherInfoEN)
{
 clsTeacherInfoBL.TeacherInfoDA.CheckPropertyNew(objTeacherInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTeacherInfoEN objTeacherInfoEN)
{
 clsTeacherInfoBL.TeacherInfoDA.CheckProperty4Condition(objTeacherInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeacherInfoEN objTeacherInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdTeacher, objTeacherInfoCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.TeacherId) == true)
{
string strComparisonOpTeacherId = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeacherId, objTeacherInfoCond.TeacherId, strComparisonOpTeacherId);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.TeacherName) == true)
{
string strComparisonOpTeacherName = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeacherName, objTeacherInfoCond.TeacherName, strComparisonOpTeacherName);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdSex) == true)
{
string strComparisonOpIdSex = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdSex];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdSex, objTeacherInfoCond.IdSex, strComparisonOpIdSex);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdSchoolPs) == true)
{
string strComparisonOpIdSchoolPs = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdSchoolPs];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdSchoolPs, objTeacherInfoCond.IdSchoolPs, strComparisonOpIdSchoolPs);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdDisciplinePs) == true)
{
string strComparisonOpIdDisciplinePs = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdDisciplinePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdDisciplinePs, objTeacherInfoCond.IdDisciplinePs, strComparisonOpIdDisciplinePs);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdUniZone, objTeacherInfoCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdEthnic) == true)
{
string strComparisonOpIdEthnic = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdEthnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdEthnic, objTeacherInfoCond.IdEthnic, strComparisonOpIdEthnic);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdPolitics) == true)
{
string strComparisonOpIdPolitics = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdPolitics];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdPolitics, objTeacherInfoCond.IdPolitics, strComparisonOpIdPolitics);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdAdminGrade) == true)
{
string strComparisonOpIdAdminGrade = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdAdminGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdAdminGrade, objTeacherInfoCond.IdAdminGrade, strComparisonOpIdAdminGrade);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdProfGrade) == true)
{
string strComparisonOpIdProfGrade = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdProfGrade, objTeacherInfoCond.IdProfGrade, strComparisonOpIdProfGrade);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdQualif) == true)
{
string strComparisonOpIdQualif = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdQualif];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdQualif, objTeacherInfoCond.IdQualif, strComparisonOpIdQualif);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdDegree) == true)
{
string strComparisonOpIdDegree = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdDegree];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdDegree, objTeacherInfoCond.IdDegree, strComparisonOpIdDegree);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdStaffType) == true)
{
string strComparisonOpIdStaffType = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdStaffType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdStaffType, objTeacherInfoCond.IdStaffType, strComparisonOpIdStaffType);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdProvince) == true)
{
string strComparisonOpIdProvince = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdProvince];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdProvince, objTeacherInfoCond.IdProvince, strComparisonOpIdProvince);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.CitizenId) == true)
{
string strComparisonOpCitizenId = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.CitizenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.CitizenId, objTeacherInfoCond.CitizenId, strComparisonOpCitizenId);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.CardNo) == true)
{
string strComparisonOpCardNo = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.CardNo, objTeacherInfoCond.CardNo, strComparisonOpCardNo);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.Birthday) == true)
{
string strComparisonOpBirthday = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Birthday, objTeacherInfoCond.Birthday, strComparisonOpBirthday);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.GraduationMajor) == true)
{
string strComparisonOpGraduationMajor = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.GraduationMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.GraduationMajor, objTeacherInfoCond.GraduationMajor, strComparisonOpGraduationMajor);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.TelNo) == true)
{
string strComparisonOpTelNo = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.TelNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TelNo, objTeacherInfoCond.TelNo, strComparisonOpTelNo);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.Email) == true)
{
string strComparisonOpEmail = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Email, objTeacherInfoCond.Email, strComparisonOpEmail);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.WebSite) == true)
{
string strComparisonOpWebSite = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.WebSite, objTeacherInfoCond.WebSite, strComparisonOpWebSite);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.PersonBlog) == true)
{
string strComparisonOpPersonBlog = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.PersonBlog];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.PersonBlog, objTeacherInfoCond.PersonBlog, strComparisonOpPersonBlog);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.EntryDate) == true)
{
string strComparisonOpEntryDate = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.EntryDate, objTeacherInfoCond.EntryDate, strComparisonOpEntryDate);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.Offed) == true)
{
if (objTeacherInfoCond.Offed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.Offed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.Offed);
}
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IsAvconUser) == true)
{
if (objTeacherInfoCond.IsAvconUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsAvconUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsAvconUser);
}
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IsGpUser) == true)
{
if (objTeacherInfoCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsGpUser);
}
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IsLocalUser) == true)
{
if (objTeacherInfoCond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsLocalUser);
}
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.FromUnit) == true)
{
string strComparisonOpFromUnit = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.FromUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.FromUnit, objTeacherInfoCond.FromUnit, strComparisonOpFromUnit);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.Memo) == true)
{
string strComparisonOpMemo = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Memo, objTeacherInfoCond.Memo, strComparisonOpMemo);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdXzCollege, objTeacherInfoCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdXzMajor, objTeacherInfoCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.EntryDay) == true)
{
string strComparisonOpEntryDay = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.EntryDay];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.EntryDay, objTeacherInfoCond.EntryDay, strComparisonOpEntryDay);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdPhoto) == true)
{
string strComparisonOpIdPhoto = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdPhoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdPhoto, objTeacherInfoCond.IdPhoto, strComparisonOpIdPhoto);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdReligion) == true)
{
string strComparisonOpIdReligion = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdReligion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdReligion, objTeacherInfoCond.IdReligion, strComparisonOpIdReligion);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IsMessage) == true)
{
if (objTeacherInfoCond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsMessage);
}
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.Microblog) == true)
{
string strComparisonOpMicroblog = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Microblog, objTeacherInfoCond.Microblog, strComparisonOpMicroblog);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.ModifyUserId, objTeacherInfoCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.OffedBak) == true)
{
if (objTeacherInfoCond.OffedBak == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.OffedBak);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.OffedBak);
}
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.PhoneNumber, objTeacherInfoCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.QQ) == true)
{
string strComparisonOpQQ = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.QQ, objTeacherInfoCond.QQ, strComparisonOpQQ);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.TeachIdCollege) == true)
{
string strComparisonOpTeachIdCollege = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.TeachIdCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeachIdCollege, objTeacherInfoCond.TeachIdCollege, strComparisonOpTeachIdCollege);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.TeachIdMajor) == true)
{
string strComparisonOpTeachIdMajor = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.TeachIdMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeachIdMajor, objTeacherInfoCond.TeachIdMajor, strComparisonOpTeachIdMajor);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.Tel) == true)
{
string strComparisonOpTel = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.Tel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Tel, objTeacherInfoCond.Tel, strComparisonOpTel);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.Headphoto) == true)
{
string strComparisonOpHeadphoto = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.Headphoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Headphoto, objTeacherInfoCond.Headphoto, strComparisonOpHeadphoto);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.ModifyDate) == true)
{
string strComparisonOpModifyDate = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.ModifyDate, objTeacherInfoCond.ModifyDate, strComparisonOpModifyDate);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.RegisterPassword) == true)
{
string strComparisonOpRegisterPassword = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.RegisterPassword, objTeacherInfoCond.RegisterPassword, strComparisonOpRegisterPassword);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.TeacherPhoto) == true)
{
string strComparisonOpTeacherPhoto = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.TeacherPhoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeacherPhoto, objTeacherInfoCond.TeacherPhoto, strComparisonOpTeacherPhoto);
}
if (objTeacherInfoCond.IsUpdated(conTeacherInfo.IdCardNo) == true)
{
string strComparisonOpIdCardNo = objTeacherInfoCond.dicFldComparisonOp[conTeacherInfo.IdCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.IdCardNo, objTeacherInfoCond.IdCardNo, strComparisonOpIdCardNo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TeacherInfo(教师), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TeacherID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTeacherInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTeacherInfoEN objTeacherInfoEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTeacherInfoEN == null) return true;
if (objTeacherInfoEN.IdTeacher == null || objTeacherInfoEN.IdTeacher == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeacherId = '{0}'", objTeacherInfoEN.TeacherId);
if (clsTeacherInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdTeacher !=  '{0}'", objTeacherInfoEN.IdTeacher);
 sbCondition.AppendFormat(" and TeacherId = '{0}'", objTeacherInfoEN.TeacherId);
if (clsTeacherInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TeacherInfo(教师), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TeacherID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTeacherInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTeacherInfoEN objTeacherInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTeacherInfoEN == null) return "";
if (objTeacherInfoEN.IdTeacher == null || objTeacherInfoEN.IdTeacher == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeacherId = '{0}'", objTeacherInfoEN.TeacherId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdTeacher !=  '{0}'", objTeacherInfoEN.IdTeacher);
 sbCondition.AppendFormat(" and TeacherId = '{0}'", objTeacherInfoEN.TeacherId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TeacherInfo
{
public virtual bool UpdRelaTabDate(string strIdTeacher, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教师(TeacherInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTeacherInfoBL
{
public static RelatedActions_TeacherInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTeacherInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTeacherInfoDA TeacherInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTeacherInfoDA();
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
 public clsTeacherInfoBL()
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
if (string.IsNullOrEmpty(clsTeacherInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeacherInfoEN._ConnectString);
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
public static DataTable GetDataTable_TeacherInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TeacherInfoDA.GetDataTable_TeacherInfo(strWhereCond);
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
objDT = TeacherInfoDA.GetDataTable(strWhereCond);
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
objDT = TeacherInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TeacherInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TeacherInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TeacherInfoDA.GetDataTable_Top(objTopPara);
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
objDT = TeacherInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TeacherInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TeacherInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLstByIdTeacherLst(List<string> arrIdTeacherLst)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeacherLst, true);
 string strWhereCond = string.Format("IdTeacher in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTeacherInfoEN> GetObjLstByIdTeacherLstCache(List<string> arrIdTeacherLst)
{
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName);
List<clsTeacherInfoEN> arrTeacherInfoObjLstCache = GetObjLstCache();
IEnumerable <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel =
arrTeacherInfoObjLstCache
.Where(x => arrIdTeacherLst.Contains(x.IdTeacher));
return arrTeacherInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLst(string strWhereCond)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
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
public static List<clsTeacherInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTeacherInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTeacherInfoEN> GetSubObjLstCache(clsTeacherInfoEN objTeacherInfoCond)
{
List<clsTeacherInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeacherInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeacherInfo.AttributeName)
{
if (objTeacherInfoCond.IsUpdated(strFldName) == false) continue;
if (objTeacherInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeacherInfoCond[strFldName].ToString());
}
else
{
if (objTeacherInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeacherInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeacherInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeacherInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeacherInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeacherInfoCond[strFldName]));
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
public static List<clsTeacherInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
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
public static List<clsTeacherInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
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
List<clsTeacherInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTeacherInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeacherInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTeacherInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
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
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
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
public static List<clsTeacherInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTeacherInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
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
public static List<clsTeacherInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeacherInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTeacherInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTeacherInfo(ref clsTeacherInfoEN objTeacherInfoEN)
{
bool bolResult = TeacherInfoDA.GetTeacherInfo(ref objTeacherInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeacherInfoEN GetObjByIdTeacher(string strIdTeacher)
{
if (strIdTeacher.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeacher]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeacher) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeacher]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTeacherInfoEN objTeacherInfoEN = TeacherInfoDA.GetObjByIdTeacher(strIdTeacher);
return objTeacherInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTeacherInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTeacherInfoEN objTeacherInfoEN = TeacherInfoDA.GetFirstObj(strWhereCond);
 return objTeacherInfoEN;
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
public static clsTeacherInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTeacherInfoEN objTeacherInfoEN = TeacherInfoDA.GetObjByDataRow(objRow);
 return objTeacherInfoEN;
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
public static clsTeacherInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTeacherInfoEN objTeacherInfoEN = TeacherInfoDA.GetObjByDataRow(objRow);
 return objTeacherInfoEN;
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
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <param name = "lstTeacherInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeacherInfoEN GetObjByIdTeacherFromList(string strIdTeacher, List<clsTeacherInfoEN> lstTeacherInfoObjLst)
{
foreach (clsTeacherInfoEN objTeacherInfoEN in lstTeacherInfoObjLst)
{
if (objTeacherInfoEN.IdTeacher == strIdTeacher)
{
return objTeacherInfoEN;
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
 string strMaxIdTeacher;
 try
 {
 strMaxIdTeacher = clsTeacherInfoDA.GetMaxStrId();
 return strMaxIdTeacher;
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
 string strIdTeacher;
 try
 {
 strIdTeacher = new clsTeacherInfoDA().GetFirstID(strWhereCond);
 return strIdTeacher;
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
 arrList = TeacherInfoDA.GetID(strWhereCond);
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
bool bolIsExist = TeacherInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeacher)
{
if (string.IsNullOrEmpty(strIdTeacher) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeacher]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TeacherInfoDA.IsExist(strIdTeacher);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdTeacher">教师流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdTeacher, string strOpUser)
{
clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoBL.GetObjByIdTeacher(strIdTeacher);
objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
objTeacherInfoEN.ModifyUserId = strOpUser;
return clsTeacherInfoBL.UpdateBySql2(objTeacherInfoEN);
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
 bolIsExist = clsTeacherInfoDA.IsExistTable();
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
 bolIsExist = TeacherInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTeacherInfoEN objTeacherInfoEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTeacherInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教师工号 = [{0}]的数据已经存在!(in clsTeacherInfoBL.AddNewRecordBySql2)", objTeacherInfoEN.TeacherId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true || clsTeacherInfoBL.IsExist(objTeacherInfoEN.IdTeacher) == true)
 {
     objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
 }
bool bolResult = TeacherInfoDA.AddNewRecordBySQL2(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTeacherInfoEN objTeacherInfoEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTeacherInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教师工号 = [{0}]的数据已经存在!(in clsTeacherInfoBL.AddNewRecordBySql2WithReturnKey)", objTeacherInfoEN.TeacherId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true || clsTeacherInfoBL.IsExist(objTeacherInfoEN.IdTeacher) == true)
 {
     objTeacherInfoEN.IdTeacher = clsTeacherInfoBL.GetMaxStrId_S();
 }
string strKey = TeacherInfoDA.AddNewRecordBySQL2WithReturnKey(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTeacherInfoEN objTeacherInfoEN)
{
try
{
bool bolResult = TeacherInfoDA.Update(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTeacherInfoEN objTeacherInfoEN)
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.IdTeacher) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TeacherInfoDA.UpdateBySql2(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoBL.ReFreshCache();

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
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
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdTeacher)
{
try
{
 clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoBL.GetObjByIdTeacher(strIdTeacher);

if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(objTeacherInfoEN.IdTeacher, objTeacherInfoEN.ModifyUserId);
}
if (objTeacherInfoEN != null)
{
int intRecNum = TeacherInfoDA.DelRecord(strIdTeacher);
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
/// <param name="strIdTeacher">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdTeacher )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
//删除与表:[TeacherInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTeacherInfo.IdTeacher,
//strIdTeacher);
//        clsTeacherInfoBL.DelTeacherInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeacherInfoBL.DelRecord(strIdTeacher, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeacherInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeacher, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdTeacher, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTeacherInfoBL.relatedActions != null)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(strIdTeacher, "UpdRelaTabDate");
}
bool bolResult = TeacherInfoDA.DelRecord(strIdTeacher,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdTeacherLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTeacherInfos(List<string> arrIdTeacherLst)
{
if (arrIdTeacherLst.Count == 0) return 0;
try
{
if (clsTeacherInfoBL.relatedActions != null)
{
foreach (var strIdTeacher in arrIdTeacherLst)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(strIdTeacher, "UpdRelaTabDate");
}
}
int intDelRecNum = TeacherInfoDA.DelTeacherInfo(arrIdTeacherLst);
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
public static int DelTeacherInfosByCond(string strWhereCond)
{
try
{
if (clsTeacherInfoBL.relatedActions != null)
{
List<string> arrIdTeacher = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdTeacher in arrIdTeacher)
{
clsTeacherInfoBL.relatedActions.UpdRelaTabDate(strIdTeacher, "UpdRelaTabDate");
}
}
int intRecNum = TeacherInfoDA.DelTeacherInfo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TeacherInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdTeacher">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdTeacher)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
//删除与表:[TeacherInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeacherInfoBL.DelRecord(strIdTeacher, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeacherInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeacher, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTeacherInfoENS">源对象</param>
 /// <param name = "objTeacherInfoENT">目标对象</param>
 public static void CopyTo(clsTeacherInfoEN objTeacherInfoENS, clsTeacherInfoEN objTeacherInfoENT)
{
try
{
objTeacherInfoENT.IdTeacher = objTeacherInfoENS.IdTeacher; //教师流水号
objTeacherInfoENT.TeacherId = objTeacherInfoENS.TeacherId; //教师工号
objTeacherInfoENT.TeacherName = objTeacherInfoENS.TeacherName; //教师姓名
objTeacherInfoENT.IdSex = objTeacherInfoENS.IdSex; //性别流水号
objTeacherInfoENT.IdSchoolPs = objTeacherInfoENS.IdSchoolPs; //学校流水号
objTeacherInfoENT.IdDisciplinePs = objTeacherInfoENS.IdDisciplinePs; //学科流水号
objTeacherInfoENT.IdUniZone = objTeacherInfoENS.IdUniZone; //校区流水号
objTeacherInfoENT.IdEthnic = objTeacherInfoENS.IdEthnic; //民族流水号
objTeacherInfoENT.IdPolitics = objTeacherInfoENS.IdPolitics; //政治面貌流水号
objTeacherInfoENT.IdAdminGrade = objTeacherInfoENS.IdAdminGrade; //行政职务流水号
objTeacherInfoENT.IdProfGrade = objTeacherInfoENS.IdProfGrade; //专业职称流水号
objTeacherInfoENT.IdQualif = objTeacherInfoENS.IdQualif; //学历流水号
objTeacherInfoENT.IdDegree = objTeacherInfoENS.IdDegree; //学位流水号
objTeacherInfoENT.IdStaffType = objTeacherInfoENS.IdStaffType; //职工类型流水号
objTeacherInfoENT.IdProvince = objTeacherInfoENS.IdProvince; //省份流水号
objTeacherInfoENT.CitizenId = objTeacherInfoENS.CitizenId; //身份证号
objTeacherInfoENT.CardNo = objTeacherInfoENS.CardNo; //卡号
objTeacherInfoENT.Birthday = objTeacherInfoENS.Birthday; //出生日期
objTeacherInfoENT.GraduationMajor = objTeacherInfoENS.GraduationMajor; //毕业专业
objTeacherInfoENT.TelNo = objTeacherInfoENS.TelNo; //电话
objTeacherInfoENT.Email = objTeacherInfoENS.Email; //电子邮箱
objTeacherInfoENT.WebSite = objTeacherInfoENS.WebSite; //个人主页
objTeacherInfoENT.PersonBlog = objTeacherInfoENS.PersonBlog; //个人博客
objTeacherInfoENT.EntryDate = objTeacherInfoENS.EntryDate; //进校日期
objTeacherInfoENT.Offed = objTeacherInfoENS.Offed; //是否离校
objTeacherInfoENT.IsAvconUser = objTeacherInfoENS.IsAvconUser; //IsAvconUser
objTeacherInfoENT.IsGpUser = objTeacherInfoENS.IsGpUser; //是否Gp用户
objTeacherInfoENT.IsLocalUser = objTeacherInfoENS.IsLocalUser; //是否本地用户
objTeacherInfoENT.FromUnit = objTeacherInfoENS.FromUnit; //来自单位
objTeacherInfoENT.Memo = objTeacherInfoENS.Memo; //备注
objTeacherInfoENT.IdXzCollege = objTeacherInfoENS.IdXzCollege; //学院流水号
objTeacherInfoENT.IdXzMajor = objTeacherInfoENS.IdXzMajor; //专业流水号
objTeacherInfoENT.EntryDay = objTeacherInfoENS.EntryDay; //EntryDay
objTeacherInfoENT.IdPhoto = objTeacherInfoENS.IdPhoto; //id_Photo
objTeacherInfoENT.IdReligion = objTeacherInfoENS.IdReligion; //id_Religion
objTeacherInfoENT.IsMessage = objTeacherInfoENS.IsMessage; //IsMessage
objTeacherInfoENT.Microblog = objTeacherInfoENS.Microblog; //Microblog
objTeacherInfoENT.ModifyUserId = objTeacherInfoENS.ModifyUserId; //修改人
objTeacherInfoENT.OffedBak = objTeacherInfoENS.OffedBak; //OffedBak
objTeacherInfoENT.PhoneNumber = objTeacherInfoENS.PhoneNumber; //电话
objTeacherInfoENT.QQ = objTeacherInfoENS.QQ; //QQ
objTeacherInfoENT.TeachIdCollege = objTeacherInfoENS.TeachIdCollege; //Teach_id_College
objTeacherInfoENT.TeachIdMajor = objTeacherInfoENS.TeachIdMajor; //Teach_id_Major
objTeacherInfoENT.Tel = objTeacherInfoENS.Tel; //Tel
objTeacherInfoENT.Headphoto = objTeacherInfoENS.Headphoto; //Headphoto
objTeacherInfoENT.ModifyDate = objTeacherInfoENS.ModifyDate; //修改日期
objTeacherInfoENT.RegisterPassword = objTeacherInfoENS.RegisterPassword; //RegisterPassword
objTeacherInfoENT.TeacherPhoto = objTeacherInfoENS.TeacherPhoto; //TeacherPhoto
objTeacherInfoENT.IdCardNo = objTeacherInfoENS.IdCardNo; //身份证号
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
 /// <param name = "objTeacherInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsTeacherInfoEN objTeacherInfoEN)
{
try
{
objTeacherInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTeacherInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTeacherInfo.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdTeacher = objTeacherInfoEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(conTeacherInfo.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.TeacherId = objTeacherInfoEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(conTeacherInfo.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.TeacherName = objTeacherInfoEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(conTeacherInfo.IdSex, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdSex = objTeacherInfoEN.IdSex; //性别流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdSchoolPs, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdSchoolPs = objTeacherInfoEN.IdSchoolPs == "[null]" ? null :  objTeacherInfoEN.IdSchoolPs; //学校流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdDisciplinePs, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdDisciplinePs = objTeacherInfoEN.IdDisciplinePs == "[null]" ? null :  objTeacherInfoEN.IdDisciplinePs; //学科流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdUniZone = objTeacherInfoEN.IdUniZone == "[null]" ? null :  objTeacherInfoEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdEthnic, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdEthnic = objTeacherInfoEN.IdEthnic == "[null]" ? null :  objTeacherInfoEN.IdEthnic; //民族流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdPolitics, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdPolitics = objTeacherInfoEN.IdPolitics == "[null]" ? null :  objTeacherInfoEN.IdPolitics; //政治面貌流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdAdminGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdAdminGrade = objTeacherInfoEN.IdAdminGrade == "[null]" ? null :  objTeacherInfoEN.IdAdminGrade; //行政职务流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdProfGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdProfGrade = objTeacherInfoEN.IdProfGrade == "[null]" ? null :  objTeacherInfoEN.IdProfGrade; //专业职称流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdQualif, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdQualif = objTeacherInfoEN.IdQualif == "[null]" ? null :  objTeacherInfoEN.IdQualif; //学历流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdDegree = objTeacherInfoEN.IdDegree == "[null]" ? null :  objTeacherInfoEN.IdDegree; //学位流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdStaffType, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdStaffType = objTeacherInfoEN.IdStaffType == "[null]" ? null :  objTeacherInfoEN.IdStaffType; //职工类型流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdProvince, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdProvince = objTeacherInfoEN.IdProvince == "[null]" ? null :  objTeacherInfoEN.IdProvince; //省份流水号
}
if (arrFldSet.Contains(conTeacherInfo.CitizenId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.CitizenId = objTeacherInfoEN.CitizenId == "[null]" ? null :  objTeacherInfoEN.CitizenId; //身份证号
}
if (arrFldSet.Contains(conTeacherInfo.CardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.CardNo = objTeacherInfoEN.CardNo == "[null]" ? null :  objTeacherInfoEN.CardNo; //卡号
}
if (arrFldSet.Contains(conTeacherInfo.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.Birthday = objTeacherInfoEN.Birthday == "[null]" ? null :  objTeacherInfoEN.Birthday; //出生日期
}
if (arrFldSet.Contains(conTeacherInfo.GraduationMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.GraduationMajor = objTeacherInfoEN.GraduationMajor == "[null]" ? null :  objTeacherInfoEN.GraduationMajor; //毕业专业
}
if (arrFldSet.Contains(conTeacherInfo.TelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.TelNo = objTeacherInfoEN.TelNo == "[null]" ? null :  objTeacherInfoEN.TelNo; //电话
}
if (arrFldSet.Contains(conTeacherInfo.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.Email = objTeacherInfoEN.Email == "[null]" ? null :  objTeacherInfoEN.Email; //电子邮箱
}
if (arrFldSet.Contains(conTeacherInfo.WebSite, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.WebSite = objTeacherInfoEN.WebSite == "[null]" ? null :  objTeacherInfoEN.WebSite; //个人主页
}
if (arrFldSet.Contains(conTeacherInfo.PersonBlog, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.PersonBlog = objTeacherInfoEN.PersonBlog == "[null]" ? null :  objTeacherInfoEN.PersonBlog; //个人博客
}
if (arrFldSet.Contains(conTeacherInfo.EntryDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.EntryDate = objTeacherInfoEN.EntryDate == "[null]" ? null :  objTeacherInfoEN.EntryDate; //进校日期
}
if (arrFldSet.Contains(conTeacherInfo.Offed, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.Offed = objTeacherInfoEN.Offed; //是否离校
}
if (arrFldSet.Contains(conTeacherInfo.IsAvconUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IsAvconUser = objTeacherInfoEN.IsAvconUser; //IsAvconUser
}
if (arrFldSet.Contains(conTeacherInfo.IsGpUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IsGpUser = objTeacherInfoEN.IsGpUser; //是否Gp用户
}
if (arrFldSet.Contains(conTeacherInfo.IsLocalUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IsLocalUser = objTeacherInfoEN.IsLocalUser; //是否本地用户
}
if (arrFldSet.Contains(conTeacherInfo.FromUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.FromUnit = objTeacherInfoEN.FromUnit == "[null]" ? null :  objTeacherInfoEN.FromUnit; //来自单位
}
if (arrFldSet.Contains(conTeacherInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.Memo = objTeacherInfoEN.Memo == "[null]" ? null :  objTeacherInfoEN.Memo; //备注
}
if (arrFldSet.Contains(conTeacherInfo.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdXzCollege = objTeacherInfoEN.IdXzCollege == "[null]" ? null :  objTeacherInfoEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conTeacherInfo.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdXzMajor = objTeacherInfoEN.IdXzMajor == "[null]" ? null :  objTeacherInfoEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conTeacherInfo.EntryDay, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.EntryDay = objTeacherInfoEN.EntryDay == "[null]" ? null :  objTeacherInfoEN.EntryDay; //EntryDay
}
if (arrFldSet.Contains(conTeacherInfo.IdPhoto, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdPhoto = objTeacherInfoEN.IdPhoto == "[null]" ? null :  objTeacherInfoEN.IdPhoto; //id_Photo
}
if (arrFldSet.Contains(conTeacherInfo.IdReligion, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdReligion = objTeacherInfoEN.IdReligion == "[null]" ? null :  objTeacherInfoEN.IdReligion; //id_Religion
}
if (arrFldSet.Contains(conTeacherInfo.IsMessage, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IsMessage = objTeacherInfoEN.IsMessage; //IsMessage
}
if (arrFldSet.Contains(conTeacherInfo.Microblog, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.Microblog = objTeacherInfoEN.Microblog == "[null]" ? null :  objTeacherInfoEN.Microblog; //Microblog
}
if (arrFldSet.Contains(conTeacherInfo.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.ModifyUserId = objTeacherInfoEN.ModifyUserId == "[null]" ? null :  objTeacherInfoEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conTeacherInfo.OffedBak, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.OffedBak = objTeacherInfoEN.OffedBak; //OffedBak
}
if (arrFldSet.Contains(conTeacherInfo.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.PhoneNumber = objTeacherInfoEN.PhoneNumber == "[null]" ? null :  objTeacherInfoEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(conTeacherInfo.QQ, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.QQ = objTeacherInfoEN.QQ == "[null]" ? null :  objTeacherInfoEN.QQ; //QQ
}
if (arrFldSet.Contains(conTeacherInfo.TeachIdCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.TeachIdCollege = objTeacherInfoEN.TeachIdCollege == "[null]" ? null :  objTeacherInfoEN.TeachIdCollege; //Teach_id_College
}
if (arrFldSet.Contains(conTeacherInfo.TeachIdMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.TeachIdMajor = objTeacherInfoEN.TeachIdMajor == "[null]" ? null :  objTeacherInfoEN.TeachIdMajor; //Teach_id_Major
}
if (arrFldSet.Contains(conTeacherInfo.Tel, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.Tel = objTeacherInfoEN.Tel == "[null]" ? null :  objTeacherInfoEN.Tel; //Tel
}
if (arrFldSet.Contains(conTeacherInfo.Headphoto, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.Headphoto = objTeacherInfoEN.Headphoto == "[null]" ? null :  objTeacherInfoEN.Headphoto; //Headphoto
}
if (arrFldSet.Contains(conTeacherInfo.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.ModifyDate = objTeacherInfoEN.ModifyDate == "[null]" ? null :  objTeacherInfoEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conTeacherInfo.RegisterPassword, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.RegisterPassword = objTeacherInfoEN.RegisterPassword == "[null]" ? null :  objTeacherInfoEN.RegisterPassword; //RegisterPassword
}
if (arrFldSet.Contains(conTeacherInfo.TeacherPhoto, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.TeacherPhoto = objTeacherInfoEN.TeacherPhoto == "[null]" ? null :  objTeacherInfoEN.TeacherPhoto; //TeacherPhoto
}
if (arrFldSet.Contains(conTeacherInfo.IdCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeacherInfoEN.IdCardNo = objTeacherInfoEN.IdCardNo == "[null]" ? null :  objTeacherInfoEN.IdCardNo; //身份证号
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
 /// <param name = "objTeacherInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsTeacherInfoEN objTeacherInfoEN)
{
try
{
if (objTeacherInfoEN.IdSchoolPs == "[null]") objTeacherInfoEN.IdSchoolPs = null; //学校流水号
if (objTeacherInfoEN.IdDisciplinePs == "[null]") objTeacherInfoEN.IdDisciplinePs = null; //学科流水号
if (objTeacherInfoEN.IdUniZone == "[null]") objTeacherInfoEN.IdUniZone = null; //校区流水号
if (objTeacherInfoEN.IdEthnic == "[null]") objTeacherInfoEN.IdEthnic = null; //民族流水号
if (objTeacherInfoEN.IdPolitics == "[null]") objTeacherInfoEN.IdPolitics = null; //政治面貌流水号
if (objTeacherInfoEN.IdAdminGrade == "[null]") objTeacherInfoEN.IdAdminGrade = null; //行政职务流水号
if (objTeacherInfoEN.IdProfGrade == "[null]") objTeacherInfoEN.IdProfGrade = null; //专业职称流水号
if (objTeacherInfoEN.IdQualif == "[null]") objTeacherInfoEN.IdQualif = null; //学历流水号
if (objTeacherInfoEN.IdDegree == "[null]") objTeacherInfoEN.IdDegree = null; //学位流水号
if (objTeacherInfoEN.IdStaffType == "[null]") objTeacherInfoEN.IdStaffType = null; //职工类型流水号
if (objTeacherInfoEN.IdProvince == "[null]") objTeacherInfoEN.IdProvince = null; //省份流水号
if (objTeacherInfoEN.CitizenId == "[null]") objTeacherInfoEN.CitizenId = null; //身份证号
if (objTeacherInfoEN.CardNo == "[null]") objTeacherInfoEN.CardNo = null; //卡号
if (objTeacherInfoEN.Birthday == "[null]") objTeacherInfoEN.Birthday = null; //出生日期
if (objTeacherInfoEN.GraduationMajor == "[null]") objTeacherInfoEN.GraduationMajor = null; //毕业专业
if (objTeacherInfoEN.TelNo == "[null]") objTeacherInfoEN.TelNo = null; //电话
if (objTeacherInfoEN.Email == "[null]") objTeacherInfoEN.Email = null; //电子邮箱
if (objTeacherInfoEN.WebSite == "[null]") objTeacherInfoEN.WebSite = null; //个人主页
if (objTeacherInfoEN.PersonBlog == "[null]") objTeacherInfoEN.PersonBlog = null; //个人博客
if (objTeacherInfoEN.EntryDate == "[null]") objTeacherInfoEN.EntryDate = null; //进校日期
if (objTeacherInfoEN.FromUnit == "[null]") objTeacherInfoEN.FromUnit = null; //来自单位
if (objTeacherInfoEN.Memo == "[null]") objTeacherInfoEN.Memo = null; //备注
if (objTeacherInfoEN.IdXzCollege == "[null]") objTeacherInfoEN.IdXzCollege = null; //学院流水号
if (objTeacherInfoEN.IdXzMajor == "[null]") objTeacherInfoEN.IdXzMajor = null; //专业流水号
if (objTeacherInfoEN.EntryDay == "[null]") objTeacherInfoEN.EntryDay = null; //EntryDay
if (objTeacherInfoEN.IdPhoto == "[null]") objTeacherInfoEN.IdPhoto = null; //id_Photo
if (objTeacherInfoEN.IdReligion == "[null]") objTeacherInfoEN.IdReligion = null; //id_Religion
if (objTeacherInfoEN.Microblog == "[null]") objTeacherInfoEN.Microblog = null; //Microblog
if (objTeacherInfoEN.ModifyUserId == "[null]") objTeacherInfoEN.ModifyUserId = null; //修改人
if (objTeacherInfoEN.PhoneNumber == "[null]") objTeacherInfoEN.PhoneNumber = null; //电话
if (objTeacherInfoEN.QQ == "[null]") objTeacherInfoEN.QQ = null; //QQ
if (objTeacherInfoEN.TeachIdCollege == "[null]") objTeacherInfoEN.TeachIdCollege = null; //Teach_id_College
if (objTeacherInfoEN.TeachIdMajor == "[null]") objTeacherInfoEN.TeachIdMajor = null; //Teach_id_Major
if (objTeacherInfoEN.Tel == "[null]") objTeacherInfoEN.Tel = null; //Tel
if (objTeacherInfoEN.Headphoto == "[null]") objTeacherInfoEN.Headphoto = null; //Headphoto
if (objTeacherInfoEN.ModifyDate == "[null]") objTeacherInfoEN.ModifyDate = null; //修改日期
if (objTeacherInfoEN.RegisterPassword == "[null]") objTeacherInfoEN.RegisterPassword = null; //RegisterPassword
if (objTeacherInfoEN.TeacherPhoto == "[null]") objTeacherInfoEN.TeacherPhoto = null; //TeacherPhoto
if (objTeacherInfoEN.IdCardNo == "[null]") objTeacherInfoEN.IdCardNo = null; //身份证号
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
public static void CheckPropertyNew(clsTeacherInfoEN objTeacherInfoEN)
{
 TeacherInfoDA.CheckPropertyNew(objTeacherInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTeacherInfoEN objTeacherInfoEN)
{
 TeacherInfoDA.CheckProperty4Condition(objTeacherInfoEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdTeacher(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTeacherInfo.IdTeacher); 
List<clsTeacherInfoEN> arrObjLst = clsTeacherInfoBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN()
{
IdTeacher = "0",
TeacherName = "选[教师]..."
};
arrObjLst.Insert(0, objTeacherInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTeacherInfo.IdTeacher;
objComboBox.DisplayMember = conTeacherInfo.TeacherName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdTeacher(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[教师]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conTeacherInfo.IdTeacher); 
IEnumerable<clsTeacherInfoEN> arrObjLst = clsTeacherInfoBL.GetObjLst(strCondition);
objDDL.DataValueField = conTeacherInfo.IdTeacher;
objDDL.DataTextField = conTeacherInfo.TeacherName;
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
public static void BindDdl_IdTeacherCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[教师]...","0");
List<clsTeacherInfoEN> arrTeacherInfoObjLst = GetAllTeacherInfoObjLstCache(); 
objDDL.DataValueField = conTeacherInfo.IdTeacher;
objDDL.DataTextField = conTeacherInfo.TeacherName;
objDDL.DataSource = arrTeacherInfoObjLst;
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
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeacher");
//if (arrTeacherInfoObjLstCache == null)
//{
//arrTeacherInfoObjLstCache = TeacherInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeacherInfoEN GetObjByIdTeacherCache(string strIdTeacher)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName);
List<clsTeacherInfoEN> arrTeacherInfoObjLstCache = GetObjLstCache();
IEnumerable <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel =
arrTeacherInfoObjLstCache
.Where(x=> x.IdTeacher == strIdTeacher 
);
if (arrTeacherInfoObjLst_Sel.Count() == 0)
{
   clsTeacherInfoEN obj = clsTeacherInfoBL.GetObjByIdTeacher(strIdTeacher);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTeacherInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeacherNameByIdTeacherCache(string strIdTeacher)
{
if (string.IsNullOrEmpty(strIdTeacher) == true) return "";
//获取缓存中的对象列表
clsTeacherInfoEN objTeacherInfo = GetObjByIdTeacherCache(strIdTeacher);
if (objTeacherInfo == null) return "";
return objTeacherInfo.TeacherName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdTeacherCache(string strIdTeacher)
{
if (string.IsNullOrEmpty(strIdTeacher) == true) return "";
//获取缓存中的对象列表
clsTeacherInfoEN objTeacherInfo = GetObjByIdTeacherCache(strIdTeacher);
if (objTeacherInfo == null) return "";
return objTeacherInfo.TeacherName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeacherInfoEN> GetAllTeacherInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsTeacherInfoEN> arrTeacherInfoObjLstCache = GetObjLstCache(); 
return arrTeacherInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName);
List<clsTeacherInfoEN> arrTeacherInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeacherInfoObjLstCache;
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
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTeacherInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTeacherInfoEN._RefreshTimeLst.Count == 0) return "";
return clsTeacherInfoEN._RefreshTimeLst[clsTeacherInfoEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsTeacherInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTeacherInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTeacherInfoBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TeacherInfo(教师)
 /// 唯一性条件:TeacherID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeacherInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTeacherInfoEN objTeacherInfoEN)
{
//检测记录是否存在
string strResult = TeacherInfoDA.GetUniCondStr(objTeacherInfoEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdTeacher)
{
if (strInFldName != conTeacherInfo.IdTeacher)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTeacherInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTeacherInfo.AttributeName));
throw new Exception(strMsg);
}
var objTeacherInfo = clsTeacherInfoBL.GetObjByIdTeacherCache(strIdTeacher);
if (objTeacherInfo == null) return "";
return objTeacherInfo[strOutFldName].ToString();
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
int intRecCount = clsTeacherInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsTeacherInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTeacherInfoDA.GetRecCount();
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
int intRecCount = clsTeacherInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTeacherInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTeacherInfoEN objTeacherInfoCond)
{
List<clsTeacherInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeacherInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeacherInfo.AttributeName)
{
if (objTeacherInfoCond.IsUpdated(strFldName) == false) continue;
if (objTeacherInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeacherInfoCond[strFldName].ToString());
}
else
{
if (objTeacherInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeacherInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeacherInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeacherInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeacherInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeacherInfoCond[strFldName]));
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
 List<string> arrList = clsTeacherInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TeacherInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TeacherInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TeacherInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeacherInfoDA.SetFldValue(clsTeacherInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TeacherInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeacherInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeacherInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeacherInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TeacherInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教师流水号*/ 
 strCreateTabCode.Append(" IdTeacher char(8) primary key, "); 
 // /**教师工号*/ 
 strCreateTabCode.Append(" TeacherId varchar(12) not Null, "); 
 // /**教师姓名*/ 
 strCreateTabCode.Append(" TeacherName varchar(50) not Null, "); 
 // /**性别流水号*/ 
 strCreateTabCode.Append(" IdSex char(4) not Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchoolPs char(4) Null, "); 
 // /**学科流水号*/ 
 strCreateTabCode.Append(" IdDisciplinePs char(4) Null, "); 
 // /**校区流水号*/ 
 strCreateTabCode.Append(" IdUniZone char(4) Null, "); 
 // /**民族流水号*/ 
 strCreateTabCode.Append(" IdEthnic char(4) Null, "); 
 // /**政治面貌流水号*/ 
 strCreateTabCode.Append(" IdPolitics char(4) Null, "); 
 // /**行政职务流水号*/ 
 strCreateTabCode.Append(" IdAdminGrade char(4) Null, "); 
 // /**专业职称流水号*/ 
 strCreateTabCode.Append(" IdProfGrade char(4) Null, "); 
 // /**学历流水号*/ 
 strCreateTabCode.Append(" IdQualif char(4) Null, "); 
 // /**学位流水号*/ 
 strCreateTabCode.Append(" IdDegree char(4) Null, "); 
 // /**职工类型流水号*/ 
 strCreateTabCode.Append(" IdStaffType char(4) Null, "); 
 // /**省份流水号*/ 
 strCreateTabCode.Append(" IdProvince char(4) Null, "); 
 // /**身份证号*/ 
 strCreateTabCode.Append(" CitizenId varchar(25) Null, "); 
 // /**卡号*/ 
 strCreateTabCode.Append(" CardNo varchar(18) Null, "); 
 // /**出生日期*/ 
 strCreateTabCode.Append(" Birthday char(8) Null, "); 
 // /**毕业专业*/ 
 strCreateTabCode.Append(" GraduationMajor varchar(40) Null, "); 
 // /**电话*/ 
 strCreateTabCode.Append(" TelNo varchar(50) Null, "); 
 // /**电子邮箱*/ 
 strCreateTabCode.Append(" Email varchar(100) Null, "); 
 // /**个人主页*/ 
 strCreateTabCode.Append(" WebSite varchar(60) Null, "); 
 // /**个人博客*/ 
 strCreateTabCode.Append(" PersonBlog varchar(60) Null, "); 
 // /**进校日期*/ 
 strCreateTabCode.Append(" EntryDate char(8) Null, "); 
 // /**是否离校*/ 
 strCreateTabCode.Append(" Offed bit Null, "); 
 // /**IsAvconUser*/ 
 strCreateTabCode.Append(" IsAvconUser bit Null, "); 
 // /**是否Gp用户*/ 
 strCreateTabCode.Append(" IsGpUser bit Null, "); 
 // /**是否本地用户*/ 
 strCreateTabCode.Append(" IsLocalUser bit Null, "); 
 // /**来自单位*/ 
 strCreateTabCode.Append(" FromUnit varchar(100) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**EntryDay*/ 
 strCreateTabCode.Append(" EntryDay char(8) Null, "); 
 // /**id_Photo*/ 
 strCreateTabCode.Append(" IdPhoto char(8) Null, "); 
 // /**id_Religion*/ 
 strCreateTabCode.Append(" IdReligion char(4) Null, "); 
 // /**IsMessage*/ 
 strCreateTabCode.Append(" IsMessage bit Null, "); 
 // /**Microblog*/ 
 strCreateTabCode.Append(" Microblog varchar(200) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**OffedBak*/ 
 strCreateTabCode.Append(" OffedBak bit Null, "); 
 // /**电话*/ 
 strCreateTabCode.Append(" PhoneNumber varchar(15) Null, "); 
 // /**QQ*/ 
 strCreateTabCode.Append(" QQ varchar(100) Null, "); 
 // /**Teach_id_College*/ 
 strCreateTabCode.Append(" TeachIdCollege varchar(6) Null, "); 
 // /**Teach_id_Major*/ 
 strCreateTabCode.Append(" TeachIdMajor char(8) Null, "); 
 // /**Tel*/ 
 strCreateTabCode.Append(" Tel varchar(50) Null, "); 
 // /**Headphoto*/ 
 strCreateTabCode.Append(" Headphoto varchar(500) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**RegisterPassword*/ 
 strCreateTabCode.Append(" RegisterPassword varchar(30) Null, "); 
 // /**TeacherPhoto*/ 
 strCreateTabCode.Append(" TeacherPhoto varchar(500) Null, "); 
 // /**身份证号*/ 
 strCreateTabCode.Append(" IdCardNo varchar(20) Null, "); 
 // /**性别名称*/ 
 strCreateTabCode.Append(" SexDesc varchar(10) Null, "); 
 // /**校区名称*/ 
 strCreateTabCode.Append(" UniZoneDesc varchar(20) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**民族名称*/ 
 strCreateTabCode.Append(" EthnicName varchar(30) Null, "); 
 // /**政治面貌*/ 
 strCreateTabCode.Append(" PoliticsName varchar(30) Null, "); 
 // /**专业职称*/ 
 strCreateTabCode.Append(" ProfenssionalGradeName varchar(30) Null, "); 
 // /**职工类型名称*/ 
 strCreateTabCode.Append(" StaffTypeName varchar(30) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null, "); 
 // /**行政职务描述*/ 
 strCreateTabCode.Append(" AdminGradeDesc varchar(30) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 教师(TeacherInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TeacherInfo : clsCommFun4BL
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
clsTeacherInfoBL.ReFreshThisCache();
}
}

}