
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzUniZoneBL
 表名:vXzUniZone(01120332)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsvXzUniZoneBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdUniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzUniZoneEN GetObj(this K_IdUniZone_vXzUniZone myKey)
{
clsvXzUniZoneEN objvXzUniZoneEN = clsvXzUniZoneBL.vXzUniZoneDA.GetObjByIdUniZone(myKey.Value);
return objvXzUniZoneEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetIdUniZone(this clsvXzUniZoneEN objvXzUniZoneEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convXzUniZone.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convXzUniZone.IdUniZone);
}
objvXzUniZoneEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.IdUniZone) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.IdUniZone, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.IdUniZone] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetUniZoneID(this clsvXzUniZoneEN objvXzUniZoneEN, string strUniZoneID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneID, convXzUniZone.UniZoneID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneID, 4, convXzUniZone.UniZoneID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUniZoneID, 4, convXzUniZone.UniZoneID);
}
objvXzUniZoneEN.UniZoneID = strUniZoneID; //校区编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.UniZoneID) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.UniZoneID, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.UniZoneID] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetUniZoneDesc(this clsvXzUniZoneEN objvXzUniZoneEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneDesc, convXzUniZone.UniZoneDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convXzUniZone.UniZoneDesc);
}
objvXzUniZoneEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.UniZoneDesc) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.UniZoneDesc, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.UniZoneDesc] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetUniZoneDescA(this clsvXzUniZoneEN objvXzUniZoneEN, string strUniZoneDescA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDescA, 20, convXzUniZone.UniZoneDescA);
}
objvXzUniZoneEN.UniZoneDescA = strUniZoneDescA; //UniZoneDescA
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.UniZoneDescA) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.UniZoneDescA, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.UniZoneDescA] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetIdSchool(this clsvXzUniZoneEN objvXzUniZoneEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convXzUniZone.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convXzUniZone.IdSchool);
}
objvXzUniZoneEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.IdSchool) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.IdSchool, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.IdSchool] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetSchoolId(this clsvXzUniZoneEN objvXzUniZoneEN, string strSchoolId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzUniZone.SchoolId);
}
objvXzUniZoneEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.SchoolId) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.SchoolId, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.SchoolId] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetSchoolName(this clsvXzUniZoneEN objvXzUniZoneEN, string strSchoolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzUniZone.SchoolName);
}
objvXzUniZoneEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.SchoolName) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.SchoolName, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.SchoolName] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetSchoolNameA(this clsvXzUniZoneEN objvXzUniZoneEN, string strSchoolNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convXzUniZone.SchoolNameA);
}
objvXzUniZoneEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.SchoolNameA) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.SchoolNameA, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.SchoolNameA] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetIdUni(this clsvXzUniZoneEN objvXzUniZoneEN, string strIdUni, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUni, 4, convXzUniZone.IdUni);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUni, 4, convXzUniZone.IdUni);
}
objvXzUniZoneEN.IdUni = strIdUni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.IdUni) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.IdUni, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.IdUni] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetModifyDate(this clsvXzUniZoneEN objvXzUniZoneEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzUniZone.ModifyDate);
}
objvXzUniZoneEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.ModifyDate) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.ModifyDate, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.ModifyDate] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetModifyUserId(this clsvXzUniZoneEN objvXzUniZoneEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convXzUniZone.ModifyUserId);
}
objvXzUniZoneEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.ModifyUserId) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.ModifyUserId, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.ModifyUserId] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzUniZoneEN SetMemo(this clsvXzUniZoneEN objvXzUniZoneEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzUniZone.Memo);
}
objvXzUniZoneEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.Memo) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.Memo, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.Memo] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzUniZoneENS">源对象</param>
 /// <param name = "objvXzUniZoneENT">目标对象</param>
 public static void CopyTo(this clsvXzUniZoneEN objvXzUniZoneENS, clsvXzUniZoneEN objvXzUniZoneENT)
{
try
{
objvXzUniZoneENT.IdUniZone = objvXzUniZoneENS.IdUniZone; //校区流水号
objvXzUniZoneENT.UniZoneID = objvXzUniZoneENS.UniZoneID; //校区编号
objvXzUniZoneENT.UniZoneDesc = objvXzUniZoneENS.UniZoneDesc; //校区名称
objvXzUniZoneENT.UniZoneDescA = objvXzUniZoneENS.UniZoneDescA; //UniZoneDescA
objvXzUniZoneENT.IdSchool = objvXzUniZoneENS.IdSchool; //学校流水号
objvXzUniZoneENT.SchoolId = objvXzUniZoneENS.SchoolId; //学校编号
objvXzUniZoneENT.SchoolName = objvXzUniZoneENS.SchoolName; //学校名称
objvXzUniZoneENT.SchoolNameA = objvXzUniZoneENS.SchoolNameA; //学校简称
objvXzUniZoneENT.IdUni = objvXzUniZoneENS.IdUni; //id_Uni
objvXzUniZoneENT.ModifyDate = objvXzUniZoneENS.ModifyDate; //修改日期
objvXzUniZoneENT.ModifyUserId = objvXzUniZoneENS.ModifyUserId; //修改人
objvXzUniZoneENT.Memo = objvXzUniZoneENS.Memo; //备注
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
 /// <param name = "objvXzUniZoneENS">源对象</param>
 /// <returns>目标对象=>clsvXzUniZoneEN:objvXzUniZoneENT</returns>
 public static clsvXzUniZoneEN CopyTo(this clsvXzUniZoneEN objvXzUniZoneENS)
{
try
{
 clsvXzUniZoneEN objvXzUniZoneENT = new clsvXzUniZoneEN()
{
IdUniZone = objvXzUniZoneENS.IdUniZone, //校区流水号
UniZoneID = objvXzUniZoneENS.UniZoneID, //校区编号
UniZoneDesc = objvXzUniZoneENS.UniZoneDesc, //校区名称
UniZoneDescA = objvXzUniZoneENS.UniZoneDescA, //UniZoneDescA
IdSchool = objvXzUniZoneENS.IdSchool, //学校流水号
SchoolId = objvXzUniZoneENS.SchoolId, //学校编号
SchoolName = objvXzUniZoneENS.SchoolName, //学校名称
SchoolNameA = objvXzUniZoneENS.SchoolNameA, //学校简称
IdUni = objvXzUniZoneENS.IdUni, //id_Uni
ModifyDate = objvXzUniZoneENS.ModifyDate, //修改日期
ModifyUserId = objvXzUniZoneENS.ModifyUserId, //修改人
Memo = objvXzUniZoneENS.Memo, //备注
};
 return objvXzUniZoneENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvXzUniZoneEN objvXzUniZoneEN)
{
 clsvXzUniZoneBL.vXzUniZoneDA.CheckProperty4Condition(objvXzUniZoneEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzUniZoneEN objvXzUniZoneCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.IdUniZone, objvXzUniZoneCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.UniZoneID) == true)
{
string strComparisonOpUniZoneID = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.UniZoneID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.UniZoneID, objvXzUniZoneCond.UniZoneID, strComparisonOpUniZoneID);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.UniZoneDesc, objvXzUniZoneCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.UniZoneDescA) == true)
{
string strComparisonOpUniZoneDescA = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.UniZoneDescA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.UniZoneDescA, objvXzUniZoneCond.UniZoneDescA, strComparisonOpUniZoneDescA);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.IdSchool) == true)
{
string strComparisonOpIdSchool = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.IdSchool, objvXzUniZoneCond.IdSchool, strComparisonOpIdSchool);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.SchoolId) == true)
{
string strComparisonOpSchoolId = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.SchoolId, objvXzUniZoneCond.SchoolId, strComparisonOpSchoolId);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.SchoolName) == true)
{
string strComparisonOpSchoolName = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.SchoolName, objvXzUniZoneCond.SchoolName, strComparisonOpSchoolName);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.SchoolNameA) == true)
{
string strComparisonOpSchoolNameA = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.SchoolNameA, objvXzUniZoneCond.SchoolNameA, strComparisonOpSchoolNameA);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.IdUni) == true)
{
string strComparisonOpIdUni = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.IdUni];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.IdUni, objvXzUniZoneCond.IdUni, strComparisonOpIdUni);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.ModifyDate, objvXzUniZoneCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.ModifyUserId, objvXzUniZoneCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvXzUniZoneCond.IsUpdated(convXzUniZone.Memo) == true)
{
string strComparisonOpMemo = objvXzUniZoneCond.dicFldComparisonOp[convXzUniZone.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.Memo, objvXzUniZoneCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzUniZone
{
public virtual bool UpdRelaTabDate(string strIdUniZone, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v校区(vXzUniZone)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzUniZoneBL
{
public static RelatedActions_vXzUniZone relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzUniZoneDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzUniZoneDA vXzUniZoneDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzUniZoneDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzUniZoneBL()
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
if (string.IsNullOrEmpty(clsvXzUniZoneEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzUniZoneEN._ConnectString);
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
public static DataTable GetDataTable_vXzUniZone(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzUniZoneDA.GetDataTable_vXzUniZone(strWhereCond);
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
objDT = vXzUniZoneDA.GetDataTable(strWhereCond);
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
objDT = vXzUniZoneDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vXzUniZoneDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzUniZoneDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vXzUniZoneDA.GetDataTable_Top(objTopPara);
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
objDT = vXzUniZoneDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vXzUniZoneDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzUniZoneDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdUniZoneLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzUniZoneEN> GetObjLstByIdUniZoneLst(List<string> arrIdUniZoneLst)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdUniZoneLst, true);
 string strWhereCond = string.Format("IdUniZone in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdUniZoneLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzUniZoneEN> GetObjLstByIdUniZoneLstCache(List<string> arrIdUniZoneLst)
{
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLstCache = GetObjLstCache();
IEnumerable <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel =
arrvXzUniZoneObjLstCache
.Where(x => arrIdUniZoneLst.Contains(x.IdUniZone));
return arrvXzUniZoneObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzUniZoneEN> GetObjLst(string strWhereCond)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
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
public static List<clsvXzUniZoneEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzUniZoneCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzUniZoneEN> GetSubObjLstCache(clsvXzUniZoneEN objvXzUniZoneCond)
{
List<clsvXzUniZoneEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzUniZoneEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzUniZone.AttributeName)
{
if (objvXzUniZoneCond.IsUpdated(strFldName) == false) continue;
if (objvXzUniZoneCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzUniZoneCond[strFldName].ToString());
}
else
{
if (objvXzUniZoneCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzUniZoneCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzUniZoneCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzUniZoneCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzUniZoneCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzUniZoneCond[strFldName]));
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
public static List<clsvXzUniZoneEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
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
public static List<clsvXzUniZoneEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
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
List<clsvXzUniZoneEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzUniZoneEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzUniZoneEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzUniZoneEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
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
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
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
public static List<clsvXzUniZoneEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzUniZoneEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzUniZoneEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
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
public static List<clsvXzUniZoneEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzUniZoneEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzUniZoneEN> arrObjLst = new List<clsvXzUniZoneEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN();
try
{
objvXzUniZoneEN.IdUniZone = objRow[convXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objvXzUniZoneEN.UniZoneID = objRow[convXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objvXzUniZoneEN.UniZoneDesc = objRow[convXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objvXzUniZoneEN.UniZoneDescA = objRow[convXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[convXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objvXzUniZoneEN.IdSchool = objRow[convXzUniZone.IdSchool] == DBNull.Value ? null : objRow[convXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objvXzUniZoneEN.SchoolId = objRow[convXzUniZone.SchoolId] == DBNull.Value ? null : objRow[convXzUniZone.SchoolId].ToString().Trim(); //学校编号
objvXzUniZoneEN.SchoolName = objRow[convXzUniZone.SchoolName] == DBNull.Value ? null : objRow[convXzUniZone.SchoolName].ToString().Trim(); //学校名称
objvXzUniZoneEN.SchoolNameA = objRow[convXzUniZone.SchoolNameA] == DBNull.Value ? null : objRow[convXzUniZone.SchoolNameA].ToString().Trim(); //学校简称
objvXzUniZoneEN.IdUni = objRow[convXzUniZone.IdUni] == DBNull.Value ? null : objRow[convXzUniZone.IdUni].ToString().Trim(); //id_Uni
objvXzUniZoneEN.ModifyDate = objRow[convXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[convXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objvXzUniZoneEN.ModifyUserId = objRow[convXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[convXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objvXzUniZoneEN.Memo = objRow[convXzUniZone.Memo] == DBNull.Value ? null : objRow[convXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzUniZoneEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzUniZone(ref clsvXzUniZoneEN objvXzUniZoneEN)
{
bool bolResult = vXzUniZoneDA.GetvXzUniZone(ref objvXzUniZoneEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdUniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzUniZoneEN GetObjByIdUniZone(string strIdUniZone)
{
if (strIdUniZone.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdUniZone]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdUniZone) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdUniZone]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzUniZoneEN objvXzUniZoneEN = vXzUniZoneDA.GetObjByIdUniZone(strIdUniZone);
return objvXzUniZoneEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzUniZoneEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzUniZoneEN objvXzUniZoneEN = vXzUniZoneDA.GetFirstObj(strWhereCond);
 return objvXzUniZoneEN;
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
public static clsvXzUniZoneEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzUniZoneEN objvXzUniZoneEN = vXzUniZoneDA.GetObjByDataRow(objRow);
 return objvXzUniZoneEN;
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
public static clsvXzUniZoneEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzUniZoneEN objvXzUniZoneEN = vXzUniZoneDA.GetObjByDataRow(objRow);
 return objvXzUniZoneEN;
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
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <param name = "lstvXzUniZoneObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzUniZoneEN GetObjByIdUniZoneFromList(string strIdUniZone, List<clsvXzUniZoneEN> lstvXzUniZoneObjLst)
{
foreach (clsvXzUniZoneEN objvXzUniZoneEN in lstvXzUniZoneObjLst)
{
if (objvXzUniZoneEN.IdUniZone == strIdUniZone)
{
return objvXzUniZoneEN;
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
 string strIdUniZone;
 try
 {
 strIdUniZone = new clsvXzUniZoneDA().GetFirstID(strWhereCond);
 return strIdUniZone;
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
 arrList = vXzUniZoneDA.GetID(strWhereCond);
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
bool bolIsExist = vXzUniZoneDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdUniZone">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdUniZone]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzUniZoneDA.IsExist(strIdUniZone);
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
 bolIsExist = clsvXzUniZoneDA.IsExistTable();
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
 bolIsExist = vXzUniZoneDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvXzUniZoneENS">源对象</param>
 /// <param name = "objvXzUniZoneENT">目标对象</param>
 public static void CopyTo(clsvXzUniZoneEN objvXzUniZoneENS, clsvXzUniZoneEN objvXzUniZoneENT)
{
try
{
objvXzUniZoneENT.IdUniZone = objvXzUniZoneENS.IdUniZone; //校区流水号
objvXzUniZoneENT.UniZoneID = objvXzUniZoneENS.UniZoneID; //校区编号
objvXzUniZoneENT.UniZoneDesc = objvXzUniZoneENS.UniZoneDesc; //校区名称
objvXzUniZoneENT.UniZoneDescA = objvXzUniZoneENS.UniZoneDescA; //UniZoneDescA
objvXzUniZoneENT.IdSchool = objvXzUniZoneENS.IdSchool; //学校流水号
objvXzUniZoneENT.SchoolId = objvXzUniZoneENS.SchoolId; //学校编号
objvXzUniZoneENT.SchoolName = objvXzUniZoneENS.SchoolName; //学校名称
objvXzUniZoneENT.SchoolNameA = objvXzUniZoneENS.SchoolNameA; //学校简称
objvXzUniZoneENT.IdUni = objvXzUniZoneENS.IdUni; //id_Uni
objvXzUniZoneENT.ModifyDate = objvXzUniZoneENS.ModifyDate; //修改日期
objvXzUniZoneENT.ModifyUserId = objvXzUniZoneENS.ModifyUserId; //修改人
objvXzUniZoneENT.Memo = objvXzUniZoneENS.Memo; //备注
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
 /// <param name = "objvXzUniZoneEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzUniZoneEN objvXzUniZoneEN)
{
try
{
objvXzUniZoneEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzUniZoneEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzUniZone.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.IdUniZone = objvXzUniZoneEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convXzUniZone.UniZoneID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.UniZoneID = objvXzUniZoneEN.UniZoneID; //校区编号
}
if (arrFldSet.Contains(convXzUniZone.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.UniZoneDesc = objvXzUniZoneEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convXzUniZone.UniZoneDescA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.UniZoneDescA = objvXzUniZoneEN.UniZoneDescA == "[null]" ? null :  objvXzUniZoneEN.UniZoneDescA; //UniZoneDescA
}
if (arrFldSet.Contains(convXzUniZone.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.IdSchool = objvXzUniZoneEN.IdSchool == "[null]" ? null :  objvXzUniZoneEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convXzUniZone.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.SchoolId = objvXzUniZoneEN.SchoolId == "[null]" ? null :  objvXzUniZoneEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convXzUniZone.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.SchoolName = objvXzUniZoneEN.SchoolName == "[null]" ? null :  objvXzUniZoneEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convXzUniZone.SchoolNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.SchoolNameA = objvXzUniZoneEN.SchoolNameA == "[null]" ? null :  objvXzUniZoneEN.SchoolNameA; //学校简称
}
if (arrFldSet.Contains(convXzUniZone.IdUni, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.IdUni = objvXzUniZoneEN.IdUni == "[null]" ? null :  objvXzUniZoneEN.IdUni; //id_Uni
}
if (arrFldSet.Contains(convXzUniZone.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.ModifyDate = objvXzUniZoneEN.ModifyDate == "[null]" ? null :  objvXzUniZoneEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convXzUniZone.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.ModifyUserId = objvXzUniZoneEN.ModifyUserId == "[null]" ? null :  objvXzUniZoneEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convXzUniZone.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzUniZoneEN.Memo = objvXzUniZoneEN.Memo == "[null]" ? null :  objvXzUniZoneEN.Memo; //备注
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
 /// <param name = "objvXzUniZoneEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzUniZoneEN objvXzUniZoneEN)
{
try
{
if (objvXzUniZoneEN.UniZoneDescA == "[null]") objvXzUniZoneEN.UniZoneDescA = null; //UniZoneDescA
if (objvXzUniZoneEN.IdSchool == "[null]") objvXzUniZoneEN.IdSchool = null; //学校流水号
if (objvXzUniZoneEN.SchoolId == "[null]") objvXzUniZoneEN.SchoolId = null; //学校编号
if (objvXzUniZoneEN.SchoolName == "[null]") objvXzUniZoneEN.SchoolName = null; //学校名称
if (objvXzUniZoneEN.SchoolNameA == "[null]") objvXzUniZoneEN.SchoolNameA = null; //学校简称
if (objvXzUniZoneEN.IdUni == "[null]") objvXzUniZoneEN.IdUni = null; //id_Uni
if (objvXzUniZoneEN.ModifyDate == "[null]") objvXzUniZoneEN.ModifyDate = null; //修改日期
if (objvXzUniZoneEN.ModifyUserId == "[null]") objvXzUniZoneEN.ModifyUserId = null; //修改人
if (objvXzUniZoneEN.Memo == "[null]") objvXzUniZoneEN.Memo = null; //备注
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvXzUniZoneEN objvXzUniZoneEN)
{
 vXzUniZoneDA.CheckProperty4Condition(objvXzUniZoneEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdUniZone(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzUniZone.IdUniZone); 
List<clsvXzUniZoneEN> arrObjLst = clsvXzUniZoneBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN()
{
IdUniZone = "0",
UniZoneDesc = "选[v校区]..."
};
arrObjLst.Insert(0, objvXzUniZoneEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzUniZone.IdUniZone;
objComboBox.DisplayMember = convXzUniZone.UniZoneDesc;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdUniZone(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v校区]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convXzUniZone.IdUniZone); 
IEnumerable<clsvXzUniZoneEN> arrObjLst = clsvXzUniZoneBL.GetObjLst(strCondition);
objDDL.DataValueField = convXzUniZone.IdUniZone;
objDDL.DataTextField = convXzUniZone.UniZoneDesc;
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
public static void BindDdl_IdUniZoneCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v校区]...","0");
List<clsvXzUniZoneEN> arrvXzUniZoneObjLst = GetAllvXzUniZoneObjLstCache(); 
objDDL.DataValueField = convXzUniZone.IdUniZone;
objDDL.DataTextField = convXzUniZone.UniZoneDesc;
objDDL.DataSource = arrvXzUniZoneObjLst;
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
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdUniZone");
//if (arrvXzUniZoneObjLstCache == null)
//{
//arrvXzUniZoneObjLstCache = vXzUniZoneDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzUniZoneEN GetObjByIdUniZoneCache(string strIdUniZone)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLstCache = GetObjLstCache();
IEnumerable <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel =
arrvXzUniZoneObjLstCache
.Where(x=> x.IdUniZone == strIdUniZone 
);
if (arrvXzUniZoneObjLst_Sel.Count() == 0)
{
   clsvXzUniZoneEN obj = clsvXzUniZoneBL.GetObjByIdUniZone(strIdUniZone);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzUniZoneObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUniZoneDescByIdUniZoneCache(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true) return "";
//获取缓存中的对象列表
clsvXzUniZoneEN objvXzUniZone = GetObjByIdUniZoneCache(strIdUniZone);
if (objvXzUniZone == null) return "";
return objvXzUniZone.UniZoneDesc;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdUniZoneCache(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true) return "";
//获取缓存中的对象列表
clsvXzUniZoneEN objvXzUniZone = GetObjByIdUniZoneCache(strIdUniZone);
if (objvXzUniZone == null) return "";
return objvXzUniZone.UniZoneDesc;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzUniZoneEN> GetAllvXzUniZoneObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzUniZoneEN> arrvXzUniZoneObjLstCache = GetObjLstCache(); 
return arrvXzUniZoneObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzUniZoneEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzUniZoneObjLstCache;
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
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdUniZone)
{
if (strInFldName != convXzUniZone.IdUniZone)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzUniZone.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzUniZone.AttributeName));
throw new Exception(strMsg);
}
var objvXzUniZone = clsvXzUniZoneBL.GetObjByIdUniZoneCache(strIdUniZone);
if (objvXzUniZone == null) return "";
return objvXzUniZone[strOutFldName].ToString();
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
int intRecCount = clsvXzUniZoneDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzUniZoneDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzUniZoneDA.GetRecCount();
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
int intRecCount = clsvXzUniZoneDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzUniZoneCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzUniZoneEN objvXzUniZoneCond)
{
List<clsvXzUniZoneEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzUniZoneEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzUniZone.AttributeName)
{
if (objvXzUniZoneCond.IsUpdated(strFldName) == false) continue;
if (objvXzUniZoneCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzUniZoneCond[strFldName].ToString());
}
else
{
if (objvXzUniZoneCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzUniZoneCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzUniZoneCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzUniZoneCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzUniZoneCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzUniZoneCond[strFldName]));
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
 List<string> arrList = clsvXzUniZoneDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzUniZoneDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzUniZoneDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}