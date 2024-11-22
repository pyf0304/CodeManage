
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentInfoBL
 表名:StudentInfo(01120131)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
public static class  clsStudentInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentInfoEN GetObj(this K_IdStudentInfo_StudentInfo myKey)
{
clsStudentInfoEN objStudentInfoEN = clsStudentInfoBL.StudentInfoDA.GetObjByIdStudentInfo(myKey.Value);
return objStudentInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsStudentInfoEN objStudentInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objStudentInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentInfoBL.AddNewRecord)", objStudentInfoEN.StuId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true || clsStudentInfoBL.IsExist(objStudentInfoEN.IdStudentInfo) == true)
 {
     objStudentInfoEN.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
 }
bool bolResult = clsStudentInfoBL.StudentInfoDA.AddNewRecordBySQL2(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
public static bool AddRecordEx(this clsStudentInfoEN objStudentInfoEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsStudentInfoBL.IsExist(objStudentInfoEN.IdStudentInfo))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objStudentInfoEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objStudentInfoEN.CheckUniqueness() == false)
{
strMsg = string.Format("(学号(StuId)=[{0}])已经存在,不能重复!", objStudentInfoEN.StuId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true || clsStudentInfoBL.IsExist(objStudentInfoEN.IdStudentInfo) == true)
 {
     objStudentInfoEN.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objStudentInfoEN.AddNewRecord();
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsStudentInfoEN objStudentInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objStudentInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentInfoBL.AddNewRecordWithMaxId)", objStudentInfoEN.StuId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true || clsStudentInfoBL.IsExist(objStudentInfoEN.IdStudentInfo) == true)
 {
     objStudentInfoEN.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
 }
string strIdStudentInfo = clsStudentInfoBL.StudentInfoDA.AddNewRecordBySQL2WithReturnKey(objStudentInfoEN);
     objStudentInfoEN.IdStudentInfo = strIdStudentInfo;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
}
return strIdStudentInfo;
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsStudentInfoEN objStudentInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objStudentInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentInfoBL.AddNewRecordWithReturnKey)", objStudentInfoEN.StuId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true || clsStudentInfoBL.IsExist(objStudentInfoEN.IdStudentInfo) == true)
 {
     objStudentInfoEN.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
 }
string strKey = clsStudentInfoBL.StudentInfoDA.AddNewRecordBySQL2WithReturnKey(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdStudentInfo(this clsStudentInfoEN objStudentInfoEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, conStudentInfo.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, conStudentInfo.IdStudentInfo);
}
objStudentInfoEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdStudentInfo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdStudentInfo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdStudentInfo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetStuId(this clsStudentInfoEN objStudentInfoEN, string strStuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuId, conStudentInfo.StuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, conStudentInfo.StuId);
}
objStudentInfoEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.StuId) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.StuId, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.StuId] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetStuName(this clsStudentInfoEN objStudentInfoEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, conStudentInfo.StuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, conStudentInfo.StuName);
}
objStudentInfoEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.StuName) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.StuName, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.StuName] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdPolitics(this clsStudentInfoEN objStudentInfoEN, string strIdPolitics, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPolitics, 4, conStudentInfo.IdPolitics);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPolitics, 4, conStudentInfo.IdPolitics);
}
objStudentInfoEN.IdPolitics = strIdPolitics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdPolitics) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdPolitics, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdPolitics] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdSex(this clsStudentInfoEN objStudentInfoEN, string strIdSex, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSex, 4, conStudentInfo.IdSex);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSex, 4, conStudentInfo.IdSex);
}
objStudentInfoEN.IdSex = strIdSex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdSex) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdSex, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdSex] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdEthnic(this clsStudentInfoEN objStudentInfoEN, string strIdEthnic, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEthnic, 4, conStudentInfo.IdEthnic);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEthnic, 4, conStudentInfo.IdEthnic);
}
objStudentInfoEN.IdEthnic = strIdEthnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdEthnic) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdEthnic, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdEthnic] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdUniZone(this clsStudentInfoEN objStudentInfoEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, conStudentInfo.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, conStudentInfo.IdUniZone);
}
objStudentInfoEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdUniZone) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdUniZone, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdUniZone] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdStuType(this clsStudentInfoEN objStudentInfoEN, string strIdStuType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStuType, 4, conStudentInfo.IdStuType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStuType, 4, conStudentInfo.IdStuType);
}
objStudentInfoEN.IdStuType = strIdStuType; //学生类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdStuType) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdStuType, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdStuType] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdXzCollege(this clsStudentInfoEN objStudentInfoEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conStudentInfo.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conStudentInfo.IdXzCollege);
}
objStudentInfoEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdXzCollege) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdXzCollege, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdXzCollege] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdXzMajor(this clsStudentInfoEN objStudentInfoEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conStudentInfo.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conStudentInfo.IdXzMajor);
}
objStudentInfoEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdXzMajor) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdXzMajor, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdXzMajor] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdGradeBase(this clsStudentInfoEN objStudentInfoEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conStudentInfo.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conStudentInfo.IdGradeBase);
}
objStudentInfoEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdGradeBase) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdGradeBase, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdGradeBase] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdGrade(this clsStudentInfoEN objStudentInfoEN, string strIdGrade, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGrade, 4, conStudentInfo.IdGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGrade, 4, conStudentInfo.IdGrade);
}
objStudentInfoEN.IdGrade = strIdGrade; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdGrade) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdGrade, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdGrade] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdAdminCls(this clsStudentInfoEN objStudentInfoEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, conStudentInfo.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, conStudentInfo.IdAdminCls);
}
objStudentInfoEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdAdminCls) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdAdminCls, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdAdminCls] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetBirthday(this clsStudentInfoEN objStudentInfoEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, conStudentInfo.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, conStudentInfo.Birthday);
}
objStudentInfoEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Birthday) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Birthday, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Birthday] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetNativePlace(this clsStudentInfoEN objStudentInfoEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, conStudentInfo.NativePlace);
}
objStudentInfoEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.NativePlace) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.NativePlace, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.NativePlace] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetDuty(this clsStudentInfoEN objStudentInfoEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, conStudentInfo.Duty);
}
objStudentInfoEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Duty) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Duty, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Duty] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdCardNo(this clsStudentInfoEN objStudentInfoEN, string strIdCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo, 20, conStudentInfo.IdCardNo);
}
objStudentInfoEN.IdCardNo = strIdCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdCardNo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdCardNo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdCardNo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetStuCardNo(this clsStudentInfoEN objStudentInfoEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, conStudentInfo.StuCardNo);
}
objStudentInfoEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.StuCardNo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.StuCardNo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.StuCardNo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetLiveAddress(this clsStudentInfoEN objStudentInfoEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, conStudentInfo.LiveAddress);
}
objStudentInfoEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.LiveAddress) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.LiveAddress, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.LiveAddress] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetHomePhone(this clsStudentInfoEN objStudentInfoEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, conStudentInfo.HomePhone);
}
objStudentInfoEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.HomePhone) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.HomePhone, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.HomePhone] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIdCardNo2(this clsStudentInfoEN objStudentInfoEN, string strIdCardNo2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo2, 20, conStudentInfo.IdCardNo2);
}
objStudentInfoEN.IdCardNo2 = strIdCardNo2; //内卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IdCardNo2) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IdCardNo2, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IdCardNo2] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetCardNo(this clsStudentInfoEN objStudentInfoEN, string strCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardNo, 18, conStudentInfo.CardNo);
}
objStudentInfoEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.CardNo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.CardNo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.CardNo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIsGpUser(this clsStudentInfoEN objStudentInfoEN, bool bolIsGpUser, string strComparisonOp="")
	{
objStudentInfoEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsGpUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsGpUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsGpUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIsLocalUser(this clsStudentInfoEN objStudentInfoEN, bool bolIsLocalUser, string strComparisonOp="")
	{
objStudentInfoEN.IsLocalUser = bolIsLocalUser; //是否本地用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsLocalUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsLocalUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsLocalUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIsLeaved(this clsStudentInfoEN objStudentInfoEN, bool bolIsLeaved, string strComparisonOp="")
	{
objStudentInfoEN.IsLeaved = bolIsLeaved; //是否离开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsLeaved) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsLeaved, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsLeaved] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetUserId(this clsStudentInfoEN objStudentInfoEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conStudentInfo.UserId);
}
objStudentInfoEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UserId) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UserId, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UserId] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetUserType(this clsStudentInfoEN objStudentInfoEN, string strUserType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserType, 50, conStudentInfo.UserType);
}
objStudentInfoEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UserType) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UserType, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UserType] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetEnrollmentDate(this clsStudentInfoEN objStudentInfoEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, conStudentInfo.EnrollmentDate);
}
objStudentInfoEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.EnrollmentDate) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.EnrollmentDate, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.EnrollmentDate] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetPostCode(this clsStudentInfoEN objStudentInfoEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, conStudentInfo.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, conStudentInfo.PostCode);
}
objStudentInfoEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.PostCode) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.PostCode, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.PostCode] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetEmail(this clsStudentInfoEN objStudentInfoEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, conStudentInfo.Email);
}
objStudentInfoEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Email) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Email, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Email] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetIsMessage(this clsStudentInfoEN objStudentInfoEN, bool bolIsMessage, string strComparisonOp="")
	{
objStudentInfoEN.IsMessage = bolIsMessage; //IsMessage
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsMessage) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsMessage, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsMessage] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetMicroblog(this clsStudentInfoEN objStudentInfoEN, string strMicroblog, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroblog, 200, conStudentInfo.Microblog);
}
objStudentInfoEN.Microblog = strMicroblog; //Microblog
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Microblog) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Microblog, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Microblog] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetPhoneNumber(this clsStudentInfoEN objStudentInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conStudentInfo.PhoneNumber);
}
objStudentInfoEN.PhoneNumber = strPhoneNumber; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.PhoneNumber) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.PhoneNumber, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.PhoneNumber] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetHeadphoto(this clsStudentInfoEN objStudentInfoEN, string strHeadphoto, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHeadphoto, 500, conStudentInfo.Headphoto);
}
objStudentInfoEN.Headphoto = strHeadphoto; //Headphoto
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Headphoto) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Headphoto, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Headphoto] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetQQ(this clsStudentInfoEN objStudentInfoEN, string strQQ, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQQ, 100, conStudentInfo.QQ);
}
objStudentInfoEN.QQ = strQQ; //QQ
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.QQ) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.QQ, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.QQ] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetRegisterPassword(this clsStudentInfoEN objStudentInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, conStudentInfo.RegisterPassword);
}
objStudentInfoEN.RegisterPassword = strRegisterPassword; //RegisterPassword
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.RegisterPassword) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.RegisterPassword, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.RegisterPassword] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetUpdDate(this clsStudentInfoEN objStudentInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conStudentInfo.UpdDate);
}
objStudentInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UpdDate) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UpdDate, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UpdDate] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetUpdUser(this clsStudentInfoEN objStudentInfoEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conStudentInfo.UpdUser);
}
objStudentInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UpdUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UpdUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UpdUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsStudentInfoEN SetMemo(this clsStudentInfoEN objStudentInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conStudentInfo.Memo);
}
objStudentInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Memo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Memo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Memo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsStudentInfoEN objStudentInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objStudentInfoEN.CheckPropertyNew();
clsStudentInfoEN objStudentInfoCond = new clsStudentInfoEN();
string strCondition = objStudentInfoCond
.SetIdStudentInfo(objStudentInfoEN.IdStudentInfo, "<>")
.SetStuId(objStudentInfoEN.StuId, "=")
.GetCombineCondition();
objStudentInfoEN._IsCheckProperty = true;
bool bolIsExist = clsStudentInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(StuId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objStudentInfoEN.Update();
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
 /// <param name = "objStudentInfo">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsStudentInfoEN objStudentInfo)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsStudentInfoEN objStudentInfoCond = new clsStudentInfoEN();
string strCondition = objStudentInfoCond
.SetStuId(objStudentInfo.StuId, "=")
.GetCombineCondition();
objStudentInfo._IsCheckProperty = true;
bool bolIsExist = clsStudentInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objStudentInfo.IdStudentInfo = clsStudentInfoBL.GetFirstID_S(strCondition);
objStudentInfo.UpdateWithCondition(strCondition);
}
else
{
objStudentInfo.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
objStudentInfo.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsStudentInfoEN objStudentInfoEN)
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsStudentInfoBL.StudentInfoDA.UpdateBySql2(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsStudentInfoEN objStudentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsStudentInfoBL.StudentInfoDA.UpdateBySql2(objStudentInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsStudentInfoEN objStudentInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsStudentInfoBL.StudentInfoDA.UpdateBySqlWithCondition(objStudentInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsStudentInfoEN objStudentInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsStudentInfoBL.StudentInfoDA.UpdateBySqlWithConditionTransaction(objStudentInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsStudentInfoEN objStudentInfoEN)
{
try
{
int intRecNum = clsStudentInfoBL.StudentInfoDA.DelRecord(objStudentInfoEN.IdStudentInfo);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoENS">源对象</param>
 /// <param name = "objStudentInfoENT">目标对象</param>
 public static void CopyTo(this clsStudentInfoEN objStudentInfoENS, clsStudentInfoEN objStudentInfoENT)
{
try
{
objStudentInfoENT.IdStudentInfo = objStudentInfoENS.IdStudentInfo; //学生流水号
objStudentInfoENT.StuId = objStudentInfoENS.StuId; //学号
objStudentInfoENT.StuName = objStudentInfoENS.StuName; //姓名
objStudentInfoENT.IdPolitics = objStudentInfoENS.IdPolitics; //政治面貌流水号
objStudentInfoENT.IdSex = objStudentInfoENS.IdSex; //性别流水号
objStudentInfoENT.IdEthnic = objStudentInfoENS.IdEthnic; //民族流水号
objStudentInfoENT.IdUniZone = objStudentInfoENS.IdUniZone; //校区流水号
objStudentInfoENT.IdStuType = objStudentInfoENS.IdStuType; //学生类别流水号
objStudentInfoENT.IdXzCollege = objStudentInfoENS.IdXzCollege; //学院流水号
objStudentInfoENT.IdXzMajor = objStudentInfoENS.IdXzMajor; //专业流水号
objStudentInfoENT.IdGradeBase = objStudentInfoENS.IdGradeBase; //年级流水号
objStudentInfoENT.IdGrade = objStudentInfoENS.IdGrade; //年级流水号
objStudentInfoENT.IdAdminCls = objStudentInfoENS.IdAdminCls; //行政班流水号
objStudentInfoENT.Birthday = objStudentInfoENS.Birthday; //出生日期
objStudentInfoENT.NativePlace = objStudentInfoENS.NativePlace; //籍贯
objStudentInfoENT.Duty = objStudentInfoENS.Duty; //职位
objStudentInfoENT.IdCardNo = objStudentInfoENS.IdCardNo; //身份证号
objStudentInfoENT.StuCardNo = objStudentInfoENS.StuCardNo; //学生证号
objStudentInfoENT.LiveAddress = objStudentInfoENS.LiveAddress; //居住地址
objStudentInfoENT.HomePhone = objStudentInfoENS.HomePhone; //住宅电话
objStudentInfoENT.IdCardNo2 = objStudentInfoENS.IdCardNo2; //内卡号
objStudentInfoENT.CardNo = objStudentInfoENS.CardNo; //卡号
objStudentInfoENT.IsGpUser = objStudentInfoENS.IsGpUser; //是否Gp用户
objStudentInfoENT.IsLocalUser = objStudentInfoENS.IsLocalUser; //是否本地用户
objStudentInfoENT.IsLeaved = objStudentInfoENS.IsLeaved; //是否离开
objStudentInfoENT.UserId = objStudentInfoENS.UserId; //用户ID
objStudentInfoENT.UserType = objStudentInfoENS.UserType; //用户类型
objStudentInfoENT.EnrollmentDate = objStudentInfoENS.EnrollmentDate; //入校日期
objStudentInfoENT.PostCode = objStudentInfoENS.PostCode; //邮编
objStudentInfoENT.Email = objStudentInfoENS.Email; //电子邮箱
objStudentInfoENT.IsMessage = objStudentInfoENS.IsMessage; //IsMessage
objStudentInfoENT.Microblog = objStudentInfoENS.Microblog; //Microblog
objStudentInfoENT.PhoneNumber = objStudentInfoENS.PhoneNumber; //电话
objStudentInfoENT.Headphoto = objStudentInfoENS.Headphoto; //Headphoto
objStudentInfoENT.QQ = objStudentInfoENS.QQ; //QQ
objStudentInfoENT.RegisterPassword = objStudentInfoENS.RegisterPassword; //RegisterPassword
objStudentInfoENT.UpdDate = objStudentInfoENS.UpdDate; //修改日期
objStudentInfoENT.UpdUser = objStudentInfoENS.UpdUser; //修改人
objStudentInfoENT.Memo = objStudentInfoENS.Memo; //备注
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
 /// <param name = "objStudentInfoENS">源对象</param>
 /// <returns>目标对象=>clsStudentInfoEN:objStudentInfoENT</returns>
 public static clsStudentInfoEN CopyTo(this clsStudentInfoEN objStudentInfoENS)
{
try
{
 clsStudentInfoEN objStudentInfoENT = new clsStudentInfoEN()
{
IdStudentInfo = objStudentInfoENS.IdStudentInfo, //学生流水号
StuId = objStudentInfoENS.StuId, //学号
StuName = objStudentInfoENS.StuName, //姓名
IdPolitics = objStudentInfoENS.IdPolitics, //政治面貌流水号
IdSex = objStudentInfoENS.IdSex, //性别流水号
IdEthnic = objStudentInfoENS.IdEthnic, //民族流水号
IdUniZone = objStudentInfoENS.IdUniZone, //校区流水号
IdStuType = objStudentInfoENS.IdStuType, //学生类别流水号
IdXzCollege = objStudentInfoENS.IdXzCollege, //学院流水号
IdXzMajor = objStudentInfoENS.IdXzMajor, //专业流水号
IdGradeBase = objStudentInfoENS.IdGradeBase, //年级流水号
IdGrade = objStudentInfoENS.IdGrade, //年级流水号
IdAdminCls = objStudentInfoENS.IdAdminCls, //行政班流水号
Birthday = objStudentInfoENS.Birthday, //出生日期
NativePlace = objStudentInfoENS.NativePlace, //籍贯
Duty = objStudentInfoENS.Duty, //职位
IdCardNo = objStudentInfoENS.IdCardNo, //身份证号
StuCardNo = objStudentInfoENS.StuCardNo, //学生证号
LiveAddress = objStudentInfoENS.LiveAddress, //居住地址
HomePhone = objStudentInfoENS.HomePhone, //住宅电话
IdCardNo2 = objStudentInfoENS.IdCardNo2, //内卡号
CardNo = objStudentInfoENS.CardNo, //卡号
IsGpUser = objStudentInfoENS.IsGpUser, //是否Gp用户
IsLocalUser = objStudentInfoENS.IsLocalUser, //是否本地用户
IsLeaved = objStudentInfoENS.IsLeaved, //是否离开
UserId = objStudentInfoENS.UserId, //用户ID
UserType = objStudentInfoENS.UserType, //用户类型
EnrollmentDate = objStudentInfoENS.EnrollmentDate, //入校日期
PostCode = objStudentInfoENS.PostCode, //邮编
Email = objStudentInfoENS.Email, //电子邮箱
IsMessage = objStudentInfoENS.IsMessage, //IsMessage
Microblog = objStudentInfoENS.Microblog, //Microblog
PhoneNumber = objStudentInfoENS.PhoneNumber, //电话
Headphoto = objStudentInfoENS.Headphoto, //Headphoto
QQ = objStudentInfoENS.QQ, //QQ
RegisterPassword = objStudentInfoENS.RegisterPassword, //RegisterPassword
UpdDate = objStudentInfoENS.UpdDate, //修改日期
UpdUser = objStudentInfoENS.UpdUser, //修改人
Memo = objStudentInfoENS.Memo, //备注
};
 return objStudentInfoENT;
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
public static void CheckPropertyNew(this clsStudentInfoEN objStudentInfoEN)
{
 clsStudentInfoBL.StudentInfoDA.CheckPropertyNew(objStudentInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsStudentInfoEN objStudentInfoEN)
{
 clsStudentInfoBL.StudentInfoDA.CheckProperty4Condition(objStudentInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsStudentInfoEN objStudentInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdStudentInfo, objStudentInfoCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.StuId) == true)
{
string strComparisonOpStuId = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.StuId, objStudentInfoCond.StuId, strComparisonOpStuId);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.StuName) == true)
{
string strComparisonOpStuName = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.StuName, objStudentInfoCond.StuName, strComparisonOpStuName);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdPolitics) == true)
{
string strComparisonOpIdPolitics = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdPolitics];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdPolitics, objStudentInfoCond.IdPolitics, strComparisonOpIdPolitics);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdSex) == true)
{
string strComparisonOpIdSex = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdSex];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdSex, objStudentInfoCond.IdSex, strComparisonOpIdSex);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdEthnic) == true)
{
string strComparisonOpIdEthnic = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdEthnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdEthnic, objStudentInfoCond.IdEthnic, strComparisonOpIdEthnic);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdUniZone, objStudentInfoCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdStuType) == true)
{
string strComparisonOpIdStuType = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdStuType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdStuType, objStudentInfoCond.IdStuType, strComparisonOpIdStuType);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdXzCollege, objStudentInfoCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdXzMajor, objStudentInfoCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdGradeBase, objStudentInfoCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdGrade) == true)
{
string strComparisonOpIdGrade = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdGrade, objStudentInfoCond.IdGrade, strComparisonOpIdGrade);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdAdminCls, objStudentInfoCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.Birthday) == true)
{
string strComparisonOpBirthday = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Birthday, objStudentInfoCond.Birthday, strComparisonOpBirthday);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.NativePlace) == true)
{
string strComparisonOpNativePlace = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.NativePlace, objStudentInfoCond.NativePlace, strComparisonOpNativePlace);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.Duty) == true)
{
string strComparisonOpDuty = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Duty, objStudentInfoCond.Duty, strComparisonOpDuty);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdCardNo) == true)
{
string strComparisonOpIdCardNo = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdCardNo, objStudentInfoCond.IdCardNo, strComparisonOpIdCardNo);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.StuCardNo, objStudentInfoCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.LiveAddress, objStudentInfoCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.HomePhone) == true)
{
string strComparisonOpHomePhone = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.HomePhone, objStudentInfoCond.HomePhone, strComparisonOpHomePhone);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IdCardNo2) == true)
{
string strComparisonOpIdCardNo2 = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.IdCardNo2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IdCardNo2, objStudentInfoCond.IdCardNo2, strComparisonOpIdCardNo2);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.CardNo) == true)
{
string strComparisonOpCardNo = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.CardNo, objStudentInfoCond.CardNo, strComparisonOpCardNo);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IsGpUser) == true)
{
if (objStudentInfoCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsGpUser);
}
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IsLocalUser) == true)
{
if (objStudentInfoCond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsLocalUser);
}
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IsLeaved) == true)
{
if (objStudentInfoCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsLeaved);
}
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.UserId) == true)
{
string strComparisonOpUserId = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UserId, objStudentInfoCond.UserId, strComparisonOpUserId);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.UserType) == true)
{
string strComparisonOpUserType = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UserType, objStudentInfoCond.UserType, strComparisonOpUserType);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.EnrollmentDate, objStudentInfoCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.PostCode) == true)
{
string strComparisonOpPostCode = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.PostCode, objStudentInfoCond.PostCode, strComparisonOpPostCode);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.Email) == true)
{
string strComparisonOpEmail = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Email, objStudentInfoCond.Email, strComparisonOpEmail);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.IsMessage) == true)
{
if (objStudentInfoCond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsMessage);
}
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.Microblog) == true)
{
string strComparisonOpMicroblog = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Microblog, objStudentInfoCond.Microblog, strComparisonOpMicroblog);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.PhoneNumber, objStudentInfoCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.Headphoto) == true)
{
string strComparisonOpHeadphoto = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.Headphoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Headphoto, objStudentInfoCond.Headphoto, strComparisonOpHeadphoto);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.QQ) == true)
{
string strComparisonOpQQ = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.QQ, objStudentInfoCond.QQ, strComparisonOpQQ);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.RegisterPassword) == true)
{
string strComparisonOpRegisterPassword = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.RegisterPassword, objStudentInfoCond.RegisterPassword, strComparisonOpRegisterPassword);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UpdDate, objStudentInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.UpdUser) == true)
{
string strComparisonOpUpdUser = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UpdUser, objStudentInfoCond.UpdUser, strComparisonOpUpdUser);
}
if (objStudentInfoCond.IsUpdated(conStudentInfo.Memo) == true)
{
string strComparisonOpMemo = objStudentInfoCond.dicFldComparisonOp[conStudentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Memo, objStudentInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--StudentInfo(学生), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:StuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objStudentInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsStudentInfoEN objStudentInfoEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objStudentInfoEN == null) return true;
if (objStudentInfoEN.IdStudentInfo == null || objStudentInfoEN.IdStudentInfo == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StuId = '{0}'", objStudentInfoEN.StuId);
if (clsStudentInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdStudentInfo !=  '{0}'", objStudentInfoEN.IdStudentInfo);
 sbCondition.AppendFormat(" and StuId = '{0}'", objStudentInfoEN.StuId);
if (clsStudentInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--StudentInfo(学生), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:StuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objStudentInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsStudentInfoEN objStudentInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objStudentInfoEN == null) return "";
if (objStudentInfoEN.IdStudentInfo == null || objStudentInfoEN.IdStudentInfo == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StuId = '{0}'", objStudentInfoEN.StuId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdStudentInfo !=  '{0}'", objStudentInfoEN.IdStudentInfo);
 sbCondition.AppendFormat(" and StuId = '{0}'", objStudentInfoEN.StuId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_StudentInfo
{
public virtual bool UpdRelaTabDate(string strIdStudentInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生(StudentInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsStudentInfoBL
{
public static RelatedActions_StudentInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsStudentInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsStudentInfoDA StudentInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsStudentInfoDA();
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
 public clsStudentInfoBL()
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
if (string.IsNullOrEmpty(clsStudentInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsStudentInfoEN._ConnectString);
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
public static DataTable GetDataTable_StudentInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = StudentInfoDA.GetDataTable_StudentInfo(strWhereCond);
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
objDT = StudentInfoDA.GetDataTable(strWhereCond);
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
objDT = StudentInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = StudentInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = StudentInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = StudentInfoDA.GetDataTable_Top(objTopPara);
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
objDT = StudentInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = StudentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = StudentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdStudentInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsStudentInfoEN> GetObjLstByIdStudentInfoLst(List<string> arrIdStudentInfoLst)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdStudentInfoLst, true);
 string strWhereCond = string.Format("IdStudentInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdStudentInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsStudentInfoEN> GetObjLstByIdStudentInfoLstCache(List<string> arrIdStudentInfoLst)
{
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName);
List<clsStudentInfoEN> arrStudentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsStudentInfoEN> arrStudentInfoObjLst_Sel =
arrStudentInfoObjLstCache
.Where(x => arrIdStudentInfoLst.Contains(x.IdStudentInfo));
return arrStudentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentInfoEN> GetObjLst(string strWhereCond)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
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
public static List<clsStudentInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objStudentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsStudentInfoEN> GetSubObjLstCache(clsStudentInfoEN objStudentInfoCond)
{
List<clsStudentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsStudentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conStudentInfo.AttributeName)
{
if (objStudentInfoCond.IsUpdated(strFldName) == false) continue;
if (objStudentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objStudentInfoCond[strFldName].ToString());
}
else
{
if (objStudentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objStudentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objStudentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objStudentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objStudentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objStudentInfoCond[strFldName]));
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
public static List<clsStudentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
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
public static List<clsStudentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
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
List<clsStudentInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsStudentInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsStudentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
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
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
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
public static List<clsStudentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsStudentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsStudentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
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
public static List<clsStudentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objStudentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetStudentInfo(ref clsStudentInfoEN objStudentInfoEN)
{
bool bolResult = StudentInfoDA.GetStudentInfo(ref objStudentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentInfoEN GetObjByIdStudentInfo(string strIdStudentInfo)
{
if (strIdStudentInfo.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdStudentInfo]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdStudentInfo]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsStudentInfoEN objStudentInfoEN = StudentInfoDA.GetObjByIdStudentInfo(strIdStudentInfo);
return objStudentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsStudentInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsStudentInfoEN objStudentInfoEN = StudentInfoDA.GetFirstObj(strWhereCond);
 return objStudentInfoEN;
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
public static clsStudentInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsStudentInfoEN objStudentInfoEN = StudentInfoDA.GetObjByDataRow(objRow);
 return objStudentInfoEN;
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
public static clsStudentInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsStudentInfoEN objStudentInfoEN = StudentInfoDA.GetObjByDataRow(objRow);
 return objStudentInfoEN;
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
 /// <param name = "strIdStudentInfo">所给的关键字</param>
 /// <param name = "lstStudentInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsStudentInfoEN GetObjByIdStudentInfoFromList(string strIdStudentInfo, List<clsStudentInfoEN> lstStudentInfoObjLst)
{
foreach (clsStudentInfoEN objStudentInfoEN in lstStudentInfoObjLst)
{
if (objStudentInfoEN.IdStudentInfo == strIdStudentInfo)
{
return objStudentInfoEN;
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
 string strMaxIdStudentInfo;
 try
 {
 strMaxIdStudentInfo = clsStudentInfoDA.GetMaxStrId();
 return strMaxIdStudentInfo;
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
 string strIdStudentInfo;
 try
 {
 strIdStudentInfo = new clsStudentInfoDA().GetFirstID(strWhereCond);
 return strIdStudentInfo;
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
 arrList = StudentInfoDA.GetID(strWhereCond);
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
bool bolIsExist = StudentInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdStudentInfo)
{
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdStudentInfo]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = StudentInfoDA.IsExist(strIdStudentInfo);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdStudentInfo">学生流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdStudentInfo, string strOpUser)
{
clsStudentInfoEN objStudentInfoEN = clsStudentInfoBL.GetObjByIdStudentInfo(strIdStudentInfo);
objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objStudentInfoEN.UpdUser = strOpUser;
return clsStudentInfoBL.UpdateBySql2(objStudentInfoEN);
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
 bolIsExist = clsStudentInfoDA.IsExistTable();
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
 bolIsExist = StudentInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsStudentInfoEN objStudentInfoEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objStudentInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentInfoBL.AddNewRecordBySql2)", objStudentInfoEN.StuId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true || clsStudentInfoBL.IsExist(objStudentInfoEN.IdStudentInfo) == true)
 {
     objStudentInfoEN.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
 }
bool bolResult = StudentInfoDA.AddNewRecordBySQL2(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsStudentInfoEN objStudentInfoEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objStudentInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentInfoBL.AddNewRecordBySql2WithReturnKey)", objStudentInfoEN.StuId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true || clsStudentInfoBL.IsExist(objStudentInfoEN.IdStudentInfo) == true)
 {
     objStudentInfoEN.IdStudentInfo = clsStudentInfoBL.GetMaxStrId_S();
 }
string strKey = StudentInfoDA.AddNewRecordBySQL2WithReturnKey(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsStudentInfoEN objStudentInfoEN)
{
try
{
bool bolResult = StudentInfoDA.Update(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsStudentInfoEN objStudentInfoEN)
{
 if (string.IsNullOrEmpty(objStudentInfoEN.IdStudentInfo) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = StudentInfoDA.UpdateBySql2(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoBL.ReFreshCache();

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
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
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdStudentInfo)
{
try
{
 clsStudentInfoEN objStudentInfoEN = clsStudentInfoBL.GetObjByIdStudentInfo(strIdStudentInfo);

if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(objStudentInfoEN.IdStudentInfo, objStudentInfoEN.UpdUser);
}
if (objStudentInfoEN != null)
{
int intRecNum = StudentInfoDA.DelRecord(strIdStudentInfo);
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
/// <param name="strIdStudentInfo">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdStudentInfo )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
//删除与表:[StudentInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudentInfo.IdStudentInfo,
//strIdStudentInfo);
//        clsStudentInfoBL.DelStudentInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsStudentInfoBL.DelRecord(strIdStudentInfo, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsStudentInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdStudentInfo, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdStudentInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsStudentInfoBL.relatedActions != null)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(strIdStudentInfo, "UpdRelaTabDate");
}
bool bolResult = StudentInfoDA.DelRecord(strIdStudentInfo,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdStudentInfoLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelStudentInfos(List<string> arrIdStudentInfoLst)
{
if (arrIdStudentInfoLst.Count == 0) return 0;
try
{
if (clsStudentInfoBL.relatedActions != null)
{
foreach (var strIdStudentInfo in arrIdStudentInfoLst)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(strIdStudentInfo, "UpdRelaTabDate");
}
}
int intDelRecNum = StudentInfoDA.DelStudentInfo(arrIdStudentInfoLst);
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
public static int DelStudentInfosByCond(string strWhereCond)
{
try
{
if (clsStudentInfoBL.relatedActions != null)
{
List<string> arrIdStudentInfo = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdStudentInfo in arrIdStudentInfo)
{
clsStudentInfoBL.relatedActions.UpdRelaTabDate(strIdStudentInfo, "UpdRelaTabDate");
}
}
int intRecNum = StudentInfoDA.DelStudentInfo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[StudentInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdStudentInfo">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdStudentInfo)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
//删除与表:[StudentInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsStudentInfoBL.DelRecord(strIdStudentInfo, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsStudentInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdStudentInfo, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objStudentInfoENS">源对象</param>
 /// <param name = "objStudentInfoENT">目标对象</param>
 public static void CopyTo(clsStudentInfoEN objStudentInfoENS, clsStudentInfoEN objStudentInfoENT)
{
try
{
objStudentInfoENT.IdStudentInfo = objStudentInfoENS.IdStudentInfo; //学生流水号
objStudentInfoENT.StuId = objStudentInfoENS.StuId; //学号
objStudentInfoENT.StuName = objStudentInfoENS.StuName; //姓名
objStudentInfoENT.IdPolitics = objStudentInfoENS.IdPolitics; //政治面貌流水号
objStudentInfoENT.IdSex = objStudentInfoENS.IdSex; //性别流水号
objStudentInfoENT.IdEthnic = objStudentInfoENS.IdEthnic; //民族流水号
objStudentInfoENT.IdUniZone = objStudentInfoENS.IdUniZone; //校区流水号
objStudentInfoENT.IdStuType = objStudentInfoENS.IdStuType; //学生类别流水号
objStudentInfoENT.IdXzCollege = objStudentInfoENS.IdXzCollege; //学院流水号
objStudentInfoENT.IdXzMajor = objStudentInfoENS.IdXzMajor; //专业流水号
objStudentInfoENT.IdGradeBase = objStudentInfoENS.IdGradeBase; //年级流水号
objStudentInfoENT.IdGrade = objStudentInfoENS.IdGrade; //年级流水号
objStudentInfoENT.IdAdminCls = objStudentInfoENS.IdAdminCls; //行政班流水号
objStudentInfoENT.Birthday = objStudentInfoENS.Birthday; //出生日期
objStudentInfoENT.NativePlace = objStudentInfoENS.NativePlace; //籍贯
objStudentInfoENT.Duty = objStudentInfoENS.Duty; //职位
objStudentInfoENT.IdCardNo = objStudentInfoENS.IdCardNo; //身份证号
objStudentInfoENT.StuCardNo = objStudentInfoENS.StuCardNo; //学生证号
objStudentInfoENT.LiveAddress = objStudentInfoENS.LiveAddress; //居住地址
objStudentInfoENT.HomePhone = objStudentInfoENS.HomePhone; //住宅电话
objStudentInfoENT.IdCardNo2 = objStudentInfoENS.IdCardNo2; //内卡号
objStudentInfoENT.CardNo = objStudentInfoENS.CardNo; //卡号
objStudentInfoENT.IsGpUser = objStudentInfoENS.IsGpUser; //是否Gp用户
objStudentInfoENT.IsLocalUser = objStudentInfoENS.IsLocalUser; //是否本地用户
objStudentInfoENT.IsLeaved = objStudentInfoENS.IsLeaved; //是否离开
objStudentInfoENT.UserId = objStudentInfoENS.UserId; //用户ID
objStudentInfoENT.UserType = objStudentInfoENS.UserType; //用户类型
objStudentInfoENT.EnrollmentDate = objStudentInfoENS.EnrollmentDate; //入校日期
objStudentInfoENT.PostCode = objStudentInfoENS.PostCode; //邮编
objStudentInfoENT.Email = objStudentInfoENS.Email; //电子邮箱
objStudentInfoENT.IsMessage = objStudentInfoENS.IsMessage; //IsMessage
objStudentInfoENT.Microblog = objStudentInfoENS.Microblog; //Microblog
objStudentInfoENT.PhoneNumber = objStudentInfoENS.PhoneNumber; //电话
objStudentInfoENT.Headphoto = objStudentInfoENS.Headphoto; //Headphoto
objStudentInfoENT.QQ = objStudentInfoENS.QQ; //QQ
objStudentInfoENT.RegisterPassword = objStudentInfoENS.RegisterPassword; //RegisterPassword
objStudentInfoENT.UpdDate = objStudentInfoENS.UpdDate; //修改日期
objStudentInfoENT.UpdUser = objStudentInfoENS.UpdUser; //修改人
objStudentInfoENT.Memo = objStudentInfoENS.Memo; //备注
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
 /// <param name = "objStudentInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsStudentInfoEN objStudentInfoEN)
{
try
{
objStudentInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objStudentInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conStudentInfo.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdStudentInfo = objStudentInfoEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(conStudentInfo.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.StuId = objStudentInfoEN.StuId; //学号
}
if (arrFldSet.Contains(conStudentInfo.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.StuName = objStudentInfoEN.StuName; //姓名
}
if (arrFldSet.Contains(conStudentInfo.IdPolitics, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdPolitics = objStudentInfoEN.IdPolitics == "[null]" ? null :  objStudentInfoEN.IdPolitics; //政治面貌流水号
}
if (arrFldSet.Contains(conStudentInfo.IdSex, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdSex = objStudentInfoEN.IdSex == "[null]" ? null :  objStudentInfoEN.IdSex; //性别流水号
}
if (arrFldSet.Contains(conStudentInfo.IdEthnic, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdEthnic = objStudentInfoEN.IdEthnic == "[null]" ? null :  objStudentInfoEN.IdEthnic; //民族流水号
}
if (arrFldSet.Contains(conStudentInfo.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdUniZone = objStudentInfoEN.IdUniZone == "[null]" ? null :  objStudentInfoEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(conStudentInfo.IdStuType, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdStuType = objStudentInfoEN.IdStuType == "[null]" ? null :  objStudentInfoEN.IdStuType; //学生类别流水号
}
if (arrFldSet.Contains(conStudentInfo.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdXzCollege = objStudentInfoEN.IdXzCollege == "[null]" ? null :  objStudentInfoEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conStudentInfo.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdXzMajor = objStudentInfoEN.IdXzMajor == "[null]" ? null :  objStudentInfoEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conStudentInfo.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdGradeBase = objStudentInfoEN.IdGradeBase == "[null]" ? null :  objStudentInfoEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conStudentInfo.IdGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdGrade = objStudentInfoEN.IdGrade == "[null]" ? null :  objStudentInfoEN.IdGrade; //年级流水号
}
if (arrFldSet.Contains(conStudentInfo.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdAdminCls = objStudentInfoEN.IdAdminCls == "[null]" ? null :  objStudentInfoEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(conStudentInfo.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.Birthday = objStudentInfoEN.Birthday == "[null]" ? null :  objStudentInfoEN.Birthday; //出生日期
}
if (arrFldSet.Contains(conStudentInfo.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.NativePlace = objStudentInfoEN.NativePlace == "[null]" ? null :  objStudentInfoEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(conStudentInfo.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.Duty = objStudentInfoEN.Duty == "[null]" ? null :  objStudentInfoEN.Duty; //职位
}
if (arrFldSet.Contains(conStudentInfo.IdCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdCardNo = objStudentInfoEN.IdCardNo == "[null]" ? null :  objStudentInfoEN.IdCardNo; //身份证号
}
if (arrFldSet.Contains(conStudentInfo.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.StuCardNo = objStudentInfoEN.StuCardNo == "[null]" ? null :  objStudentInfoEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(conStudentInfo.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.LiveAddress = objStudentInfoEN.LiveAddress == "[null]" ? null :  objStudentInfoEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(conStudentInfo.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.HomePhone = objStudentInfoEN.HomePhone == "[null]" ? null :  objStudentInfoEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(conStudentInfo.IdCardNo2, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IdCardNo2 = objStudentInfoEN.IdCardNo2 == "[null]" ? null :  objStudentInfoEN.IdCardNo2; //内卡号
}
if (arrFldSet.Contains(conStudentInfo.CardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.CardNo = objStudentInfoEN.CardNo == "[null]" ? null :  objStudentInfoEN.CardNo; //卡号
}
if (arrFldSet.Contains(conStudentInfo.IsGpUser, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IsGpUser = objStudentInfoEN.IsGpUser; //是否Gp用户
}
if (arrFldSet.Contains(conStudentInfo.IsLocalUser, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IsLocalUser = objStudentInfoEN.IsLocalUser; //是否本地用户
}
if (arrFldSet.Contains(conStudentInfo.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IsLeaved = objStudentInfoEN.IsLeaved; //是否离开
}
if (arrFldSet.Contains(conStudentInfo.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.UserId = objStudentInfoEN.UserId == "[null]" ? null :  objStudentInfoEN.UserId; //用户ID
}
if (arrFldSet.Contains(conStudentInfo.UserType, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.UserType = objStudentInfoEN.UserType == "[null]" ? null :  objStudentInfoEN.UserType; //用户类型
}
if (arrFldSet.Contains(conStudentInfo.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.EnrollmentDate = objStudentInfoEN.EnrollmentDate == "[null]" ? null :  objStudentInfoEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(conStudentInfo.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.PostCode = objStudentInfoEN.PostCode == "[null]" ? null :  objStudentInfoEN.PostCode; //邮编
}
if (arrFldSet.Contains(conStudentInfo.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.Email = objStudentInfoEN.Email == "[null]" ? null :  objStudentInfoEN.Email; //电子邮箱
}
if (arrFldSet.Contains(conStudentInfo.IsMessage, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.IsMessage = objStudentInfoEN.IsMessage; //IsMessage
}
if (arrFldSet.Contains(conStudentInfo.Microblog, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.Microblog = objStudentInfoEN.Microblog == "[null]" ? null :  objStudentInfoEN.Microblog; //Microblog
}
if (arrFldSet.Contains(conStudentInfo.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.PhoneNumber = objStudentInfoEN.PhoneNumber == "[null]" ? null :  objStudentInfoEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(conStudentInfo.Headphoto, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.Headphoto = objStudentInfoEN.Headphoto == "[null]" ? null :  objStudentInfoEN.Headphoto; //Headphoto
}
if (arrFldSet.Contains(conStudentInfo.QQ, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.QQ = objStudentInfoEN.QQ == "[null]" ? null :  objStudentInfoEN.QQ; //QQ
}
if (arrFldSet.Contains(conStudentInfo.RegisterPassword, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.RegisterPassword = objStudentInfoEN.RegisterPassword == "[null]" ? null :  objStudentInfoEN.RegisterPassword; //RegisterPassword
}
if (arrFldSet.Contains(conStudentInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.UpdDate = objStudentInfoEN.UpdDate == "[null]" ? null :  objStudentInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conStudentInfo.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.UpdUser = objStudentInfoEN.UpdUser == "[null]" ? null :  objStudentInfoEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conStudentInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentInfoEN.Memo = objStudentInfoEN.Memo == "[null]" ? null :  objStudentInfoEN.Memo; //备注
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
 /// <param name = "objStudentInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsStudentInfoEN objStudentInfoEN)
{
try
{
if (objStudentInfoEN.IdPolitics == "[null]") objStudentInfoEN.IdPolitics = null; //政治面貌流水号
if (objStudentInfoEN.IdSex == "[null]") objStudentInfoEN.IdSex = null; //性别流水号
if (objStudentInfoEN.IdEthnic == "[null]") objStudentInfoEN.IdEthnic = null; //民族流水号
if (objStudentInfoEN.IdUniZone == "[null]") objStudentInfoEN.IdUniZone = null; //校区流水号
if (objStudentInfoEN.IdStuType == "[null]") objStudentInfoEN.IdStuType = null; //学生类别流水号
if (objStudentInfoEN.IdXzCollege == "[null]") objStudentInfoEN.IdXzCollege = null; //学院流水号
if (objStudentInfoEN.IdXzMajor == "[null]") objStudentInfoEN.IdXzMajor = null; //专业流水号
if (objStudentInfoEN.IdGradeBase == "[null]") objStudentInfoEN.IdGradeBase = null; //年级流水号
if (objStudentInfoEN.IdGrade == "[null]") objStudentInfoEN.IdGrade = null; //年级流水号
if (objStudentInfoEN.IdAdminCls == "[null]") objStudentInfoEN.IdAdminCls = null; //行政班流水号
if (objStudentInfoEN.Birthday == "[null]") objStudentInfoEN.Birthday = null; //出生日期
if (objStudentInfoEN.NativePlace == "[null]") objStudentInfoEN.NativePlace = null; //籍贯
if (objStudentInfoEN.Duty == "[null]") objStudentInfoEN.Duty = null; //职位
if (objStudentInfoEN.IdCardNo == "[null]") objStudentInfoEN.IdCardNo = null; //身份证号
if (objStudentInfoEN.StuCardNo == "[null]") objStudentInfoEN.StuCardNo = null; //学生证号
if (objStudentInfoEN.LiveAddress == "[null]") objStudentInfoEN.LiveAddress = null; //居住地址
if (objStudentInfoEN.HomePhone == "[null]") objStudentInfoEN.HomePhone = null; //住宅电话
if (objStudentInfoEN.IdCardNo2 == "[null]") objStudentInfoEN.IdCardNo2 = null; //内卡号
if (objStudentInfoEN.CardNo == "[null]") objStudentInfoEN.CardNo = null; //卡号
if (objStudentInfoEN.UserId == "[null]") objStudentInfoEN.UserId = null; //用户ID
if (objStudentInfoEN.UserType == "[null]") objStudentInfoEN.UserType = null; //用户类型
if (objStudentInfoEN.EnrollmentDate == "[null]") objStudentInfoEN.EnrollmentDate = null; //入校日期
if (objStudentInfoEN.PostCode == "[null]") objStudentInfoEN.PostCode = null; //邮编
if (objStudentInfoEN.Email == "[null]") objStudentInfoEN.Email = null; //电子邮箱
if (objStudentInfoEN.Microblog == "[null]") objStudentInfoEN.Microblog = null; //Microblog
if (objStudentInfoEN.PhoneNumber == "[null]") objStudentInfoEN.PhoneNumber = null; //电话
if (objStudentInfoEN.Headphoto == "[null]") objStudentInfoEN.Headphoto = null; //Headphoto
if (objStudentInfoEN.QQ == "[null]") objStudentInfoEN.QQ = null; //QQ
if (objStudentInfoEN.RegisterPassword == "[null]") objStudentInfoEN.RegisterPassword = null; //RegisterPassword
if (objStudentInfoEN.UpdDate == "[null]") objStudentInfoEN.UpdDate = null; //修改日期
if (objStudentInfoEN.UpdUser == "[null]") objStudentInfoEN.UpdUser = null; //修改人
if (objStudentInfoEN.Memo == "[null]") objStudentInfoEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsStudentInfoEN objStudentInfoEN)
{
 StudentInfoDA.CheckPropertyNew(objStudentInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsStudentInfoEN objStudentInfoEN)
{
 StudentInfoDA.CheckProperty4Condition(objStudentInfoEN);
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
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdStudentInfo");
//if (arrStudentInfoObjLstCache == null)
//{
//arrStudentInfoObjLstCache = StudentInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdStudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsStudentInfoEN GetObjByIdStudentInfoCache(string strIdStudentInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName);
List<clsStudentInfoEN> arrStudentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsStudentInfoEN> arrStudentInfoObjLst_Sel =
arrStudentInfoObjLstCache
.Where(x=> x.IdStudentInfo == strIdStudentInfo 
);
if (arrStudentInfoObjLst_Sel.Count() == 0)
{
   clsStudentInfoEN obj = clsStudentInfoBL.GetObjByIdStudentInfo(strIdStudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrStudentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsStudentInfoEN> GetAllStudentInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsStudentInfoEN> arrStudentInfoObjLstCache = GetObjLstCache(); 
return arrStudentInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsStudentInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName);
List<clsStudentInfoEN> arrStudentInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrStudentInfoObjLstCache;
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
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsStudentInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsStudentInfoEN._RefreshTimeLst.Count == 0) return "";
return clsStudentInfoEN._RefreshTimeLst[clsStudentInfoEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsStudentInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsStudentInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsStudentInfoBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--StudentInfo(学生)
 /// 唯一性条件:StuId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objStudentInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsStudentInfoEN objStudentInfoEN)
{
//检测记录是否存在
string strResult = StudentInfoDA.GetUniCondStr(objStudentInfoEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdStudentInfo)
{
if (strInFldName != conStudentInfo.IdStudentInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conStudentInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conStudentInfo.AttributeName));
throw new Exception(strMsg);
}
var objStudentInfo = clsStudentInfoBL.GetObjByIdStudentInfoCache(strIdStudentInfo);
if (objStudentInfo == null) return "";
return objStudentInfo[strOutFldName].ToString();
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
int intRecCount = clsStudentInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsStudentInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsStudentInfoDA.GetRecCount();
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
int intRecCount = clsStudentInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objStudentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsStudentInfoEN objStudentInfoCond)
{
List<clsStudentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsStudentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conStudentInfo.AttributeName)
{
if (objStudentInfoCond.IsUpdated(strFldName) == false) continue;
if (objStudentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objStudentInfoCond[strFldName].ToString());
}
else
{
if (objStudentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objStudentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objStudentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objStudentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objStudentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objStudentInfoCond[strFldName]));
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
 List<string> arrList = clsStudentInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = StudentInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = StudentInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = StudentInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsStudentInfoDA.SetFldValue(clsStudentInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = StudentInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsStudentInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsStudentInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsStudentInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[StudentInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) primary key, "); 
 // /**学号*/ 
 strCreateTabCode.Append(" StuId varchar(20) not Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) not Null, "); 
 // /**政治面貌流水号*/ 
 strCreateTabCode.Append(" IdPolitics char(4) Null, "); 
 // /**性别流水号*/ 
 strCreateTabCode.Append(" IdSex char(4) Null, "); 
 // /**民族流水号*/ 
 strCreateTabCode.Append(" IdEthnic char(4) Null, "); 
 // /**校区流水号*/ 
 strCreateTabCode.Append(" IdUniZone char(4) Null, "); 
 // /**学生类别流水号*/ 
 strCreateTabCode.Append(" IdStuType char(4) Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGrade char(4) Null, "); 
 // /**行政班流水号*/ 
 strCreateTabCode.Append(" IdAdminCls char(8) Null, "); 
 // /**出生日期*/ 
 strCreateTabCode.Append(" Birthday char(8) Null, "); 
 // /**籍贯*/ 
 strCreateTabCode.Append(" NativePlace varchar(200) Null, "); 
 // /**职位*/ 
 strCreateTabCode.Append(" Duty varchar(30) Null, "); 
 // /**身份证号*/ 
 strCreateTabCode.Append(" IdCardNo varchar(20) Null, "); 
 // /**学生证号*/ 
 strCreateTabCode.Append(" StuCardNo varchar(20) Null, "); 
 // /**居住地址*/ 
 strCreateTabCode.Append(" LiveAddress varchar(200) Null, "); 
 // /**住宅电话*/ 
 strCreateTabCode.Append(" HomePhone varchar(20) Null, "); 
 // /**内卡号*/ 
 strCreateTabCode.Append(" IdCardNo2 varchar(20) Null, "); 
 // /**卡号*/ 
 strCreateTabCode.Append(" CardNo varchar(18) Null, "); 
 // /**是否Gp用户*/ 
 strCreateTabCode.Append(" IsGpUser bit Null, "); 
 // /**是否本地用户*/ 
 strCreateTabCode.Append(" IsLocalUser bit Null, "); 
 // /**是否离开*/ 
 strCreateTabCode.Append(" IsLeaved bit Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**用户类型*/ 
 strCreateTabCode.Append(" UserType varchar(50) Null, "); 
 // /**入校日期*/ 
 strCreateTabCode.Append(" EnrollmentDate varchar(8) Null, "); 
 // /**邮编*/ 
 strCreateTabCode.Append(" PostCode char(6) Null, "); 
 // /**电子邮箱*/ 
 strCreateTabCode.Append(" Email varchar(100) Null, "); 
 // /**IsMessage*/ 
 strCreateTabCode.Append(" IsMessage bit Null, "); 
 // /**Microblog*/ 
 strCreateTabCode.Append(" Microblog varchar(200) Null, "); 
 // /**电话*/ 
 strCreateTabCode.Append(" PhoneNumber varchar(15) Null, "); 
 // /**Headphoto*/ 
 strCreateTabCode.Append(" Headphoto varchar(500) Null, "); 
 // /**QQ*/ 
 strCreateTabCode.Append(" QQ varchar(100) Null, "); 
 // /**RegisterPassword*/ 
 strCreateTabCode.Append(" RegisterPassword varchar(30) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeName varchar(50) Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeBaseName varchar(50) Null, "); 
 // /**校区名称*/ 
 strCreateTabCode.Append(" UniZoneDesc varchar(20) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
 // /**性别名称*/ 
 strCreateTabCode.Append(" SexDesc varchar(10) Null, "); 
 // /**姓名Ex*/ 
 strCreateTabCode.Append(" StuNameEx varchar(50) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 学生(StudentInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4StudentInfo : clsCommFun4BL
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
clsStudentInfoBL.ReFreshThisCache();
}
}

}