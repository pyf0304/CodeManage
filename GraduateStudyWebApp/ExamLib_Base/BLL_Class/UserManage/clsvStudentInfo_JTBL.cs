
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentInfo_JTBL
 表名:vStudentInfo_JT(01120246)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
public static class  clsvStudentInfo_JTBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentInfo_JTEN GetObj(this K_IdStudentInfo_vStudentInfo_JT myKey)
{
clsvStudentInfo_JTEN objvStudentInfo_JTEN = clsvStudentInfo_JTBL.vStudentInfo_JTDA.GetObjByIdStudentInfo(myKey.Value);
return objvStudentInfo_JTEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetIdStudentInfo(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convStudentInfo_JT.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convStudentInfo_JT.IdStudentInfo);
}
objvStudentInfo_JTEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.IdStudentInfo) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.IdStudentInfo, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.IdStudentInfo] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetSiteName(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSiteName, convStudentInfo_JT.SiteName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteName, 100, convStudentInfo_JT.SiteName);
}
objvStudentInfo_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.SiteName) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.SiteName, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.SiteName] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetManagedDepartmentId(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentId, convStudentInfo_JT.ManagedDepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convStudentInfo_JT.ManagedDepartmentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convStudentInfo_JT.ManagedDepartmentId);
}
objvStudentInfo_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.ManagedDepartmentId) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetManagedDepartmentName(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentName, convStudentInfo_JT.ManagedDepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convStudentInfo_JT.ManagedDepartmentName);
}
objvStudentInfo_JTEN.ManagedDepartmentName = strManagedDepartmentName; //管理的部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.ManagedDepartmentName) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.ManagedDepartmentName, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentName] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetJobCategoryId(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryId, convStudentInfo_JT.JobCategoryId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convStudentInfo_JT.JobCategoryId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convStudentInfo_JT.JobCategoryId);
}
objvStudentInfo_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.JobCategoryId) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.JobCategoryId, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.JobCategoryId] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetUserId(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convStudentInfo_JT.UserId);
}
objvStudentInfo_JTEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.UserId) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.UserId, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.UserId] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetJobCategoryName(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryName, convStudentInfo_JT.JobCategoryName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convStudentInfo_JT.JobCategoryName);
}
objvStudentInfo_JTEN.JobCategoryName = strJobCategoryName; //岗位类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.JobCategoryName) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.JobCategoryName, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.JobCategoryName] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetUpdDate(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convStudentInfo_JT.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convStudentInfo_JT.UpdDate);
}
objvStudentInfo_JTEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.UpdDate) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.UpdDate, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.UpdDate] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetUpdUser(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convStudentInfo_JT.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convStudentInfo_JT.UpdUser);
}
objvStudentInfo_JTEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.UpdUser) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.UpdUser, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.UpdUser] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfo_JTEN SetMemo(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convStudentInfo_JT.Memo);
}
objvStudentInfo_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.Memo) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.Memo, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.Memo] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvStudentInfo_JTENS">源对象</param>
 /// <param name = "objvStudentInfo_JTENT">目标对象</param>
 public static void CopyTo(this clsvStudentInfo_JTEN objvStudentInfo_JTENS, clsvStudentInfo_JTEN objvStudentInfo_JTENT)
{
try
{
objvStudentInfo_JTENT.IdStudentInfo = objvStudentInfo_JTENS.IdStudentInfo; //学生流水号
objvStudentInfo_JTENT.SiteName = objvStudentInfo_JTENS.SiteName; //工地名称
objvStudentInfo_JTENT.ManagedDepartmentId = objvStudentInfo_JTENS.ManagedDepartmentId; //管理的部门Id
objvStudentInfo_JTENT.ManagedDepartmentName = objvStudentInfo_JTENS.ManagedDepartmentName; //管理的部门名
objvStudentInfo_JTENT.JobCategoryId = objvStudentInfo_JTENS.JobCategoryId; //岗位类别Id
objvStudentInfo_JTENT.UserId = objvStudentInfo_JTENS.UserId; //用户ID
objvStudentInfo_JTENT.JobCategoryName = objvStudentInfo_JTENS.JobCategoryName; //岗位类别名
objvStudentInfo_JTENT.UpdDate = objvStudentInfo_JTENS.UpdDate; //修改日期
objvStudentInfo_JTENT.UpdUser = objvStudentInfo_JTENS.UpdUser; //修改人
objvStudentInfo_JTENT.Memo = objvStudentInfo_JTENS.Memo; //备注
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
 /// <param name = "objvStudentInfo_JTENS">源对象</param>
 /// <returns>目标对象=>clsvStudentInfo_JTEN:objvStudentInfo_JTENT</returns>
 public static clsvStudentInfo_JTEN CopyTo(this clsvStudentInfo_JTEN objvStudentInfo_JTENS)
{
try
{
 clsvStudentInfo_JTEN objvStudentInfo_JTENT = new clsvStudentInfo_JTEN()
{
IdStudentInfo = objvStudentInfo_JTENS.IdStudentInfo, //学生流水号
SiteName = objvStudentInfo_JTENS.SiteName, //工地名称
ManagedDepartmentId = objvStudentInfo_JTENS.ManagedDepartmentId, //管理的部门Id
ManagedDepartmentName = objvStudentInfo_JTENS.ManagedDepartmentName, //管理的部门名
JobCategoryId = objvStudentInfo_JTENS.JobCategoryId, //岗位类别Id
UserId = objvStudentInfo_JTENS.UserId, //用户ID
JobCategoryName = objvStudentInfo_JTENS.JobCategoryName, //岗位类别名
UpdDate = objvStudentInfo_JTENS.UpdDate, //修改日期
UpdUser = objvStudentInfo_JTENS.UpdUser, //修改人
Memo = objvStudentInfo_JTENS.Memo, //备注
};
 return objvStudentInfo_JTENT;
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
public static void CheckProperty4Condition(this clsvStudentInfo_JTEN objvStudentInfo_JTEN)
{
 clsvStudentInfo_JTBL.vStudentInfo_JTDA.CheckProperty4Condition(objvStudentInfo_JTEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvStudentInfo_JTEN objvStudentInfo_JTCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.IdStudentInfo, objvStudentInfo_JTCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.SiteName) == true)
{
string strComparisonOpSiteName = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.SiteName, objvStudentInfo_JTCond.SiteName, strComparisonOpSiteName);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.ManagedDepartmentId) == true)
{
string strComparisonOpManagedDepartmentId = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.ManagedDepartmentId, objvStudentInfo_JTCond.ManagedDepartmentId, strComparisonOpManagedDepartmentId);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.ManagedDepartmentName) == true)
{
string strComparisonOpManagedDepartmentName = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.ManagedDepartmentName, objvStudentInfo_JTCond.ManagedDepartmentName, strComparisonOpManagedDepartmentName);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.JobCategoryId) == true)
{
string strComparisonOpJobCategoryId = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.JobCategoryId, objvStudentInfo_JTCond.JobCategoryId, strComparisonOpJobCategoryId);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.UserId) == true)
{
string strComparisonOpUserId = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.UserId, objvStudentInfo_JTCond.UserId, strComparisonOpUserId);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.JobCategoryName) == true)
{
string strComparisonOpJobCategoryName = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.JobCategoryName, objvStudentInfo_JTCond.JobCategoryName, strComparisonOpJobCategoryName);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.UpdDate) == true)
{
string strComparisonOpUpdDate = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.UpdDate, objvStudentInfo_JTCond.UpdDate, strComparisonOpUpdDate);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.UpdUser) == true)
{
string strComparisonOpUpdUser = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.UpdUser, objvStudentInfo_JTCond.UpdUser, strComparisonOpUpdUser);
}
if (objvStudentInfo_JTCond.IsUpdated(convStudentInfo_JT.Memo) == true)
{
string strComparisonOpMemo = objvStudentInfo_JTCond.dicFldComparisonOp[convStudentInfo_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.Memo, objvStudentInfo_JTCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vStudentInfo_JT
{
public virtual bool UpdRelaTabDate(string strIdStudentInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v学生_JT(vStudentInfo_JT)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvStudentInfo_JTBL
{
public static RelatedActions_vStudentInfo_JT relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvStudentInfo_JTDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvStudentInfo_JTDA vStudentInfo_JTDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvStudentInfo_JTDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvStudentInfo_JTBL()
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
if (string.IsNullOrEmpty(clsvStudentInfo_JTEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvStudentInfo_JTEN._ConnectString);
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
public static DataTable GetDataTable_vStudentInfo_JT(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vStudentInfo_JTDA.GetDataTable_vStudentInfo_JT(strWhereCond);
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
objDT = vStudentInfo_JTDA.GetDataTable(strWhereCond);
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
objDT = vStudentInfo_JTDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vStudentInfo_JTDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vStudentInfo_JTDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vStudentInfo_JTDA.GetDataTable_Top(objTopPara);
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
objDT = vStudentInfo_JTDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vStudentInfo_JTDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vStudentInfo_JTDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvStudentInfo_JTEN> GetObjLstByIdStudentInfoLst(List<string> arrIdStudentInfoLst)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
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
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdStudentInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvStudentInfo_JTEN> GetObjLstByIdStudentInfoLstCache(List<string> arrIdStudentInfoLst)
{
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName);
List<clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLst_Sel =
arrvStudentInfo_JTObjLstCache
.Where(x => arrIdStudentInfoLst.Contains(x.IdStudentInfo));
return arrvStudentInfo_JTObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetObjLst(string strWhereCond)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
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
public static List<clsvStudentInfo_JTEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvStudentInfo_JTCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvStudentInfo_JTEN> GetSubObjLstCache(clsvStudentInfo_JTEN objvStudentInfo_JTCond)
{
List<clsvStudentInfo_JTEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfo_JTEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convStudentInfo_JT.AttributeName)
{
if (objvStudentInfo_JTCond.IsUpdated(strFldName) == false) continue;
if (objvStudentInfo_JTCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfo_JTCond[strFldName].ToString());
}
else
{
if (objvStudentInfo_JTCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvStudentInfo_JTCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfo_JTCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvStudentInfo_JTCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvStudentInfo_JTCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvStudentInfo_JTCond[strFldName]));
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
public static List<clsvStudentInfo_JTEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
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
public static List<clsvStudentInfo_JTEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
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
List<clsvStudentInfo_JTEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvStudentInfo_JTEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvStudentInfo_JTEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
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
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
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
public static List<clsvStudentInfo_JTEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvStudentInfo_JTEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
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
public static List<clsvStudentInfo_JTEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvStudentInfo_JTEN> arrObjLst = new List<clsvStudentInfo_JTEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfo_JTEN objvStudentInfo_JTEN = new clsvStudentInfo_JTEN();
try
{
objvStudentInfo_JTEN.IdStudentInfo = objRow[convStudentInfo_JT.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfo_JTEN.SiteName = objRow[convStudentInfo_JT.SiteName].ToString().Trim(); //工地名称
objvStudentInfo_JTEN.ManagedDepartmentId = objRow[convStudentInfo_JT.ManagedDepartmentId].ToString().Trim(); //管理的部门Id
objvStudentInfo_JTEN.ManagedDepartmentName = objRow[convStudentInfo_JT.ManagedDepartmentName].ToString().Trim(); //管理的部门名
objvStudentInfo_JTEN.JobCategoryId = objRow[convStudentInfo_JT.JobCategoryId].ToString().Trim(); //岗位类别Id
objvStudentInfo_JTEN.UserId = objRow[convStudentInfo_JT.UserId] == DBNull.Value ? null : objRow[convStudentInfo_JT.UserId].ToString().Trim(); //用户ID
objvStudentInfo_JTEN.JobCategoryName = objRow[convStudentInfo_JT.JobCategoryName].ToString().Trim(); //岗位类别名
objvStudentInfo_JTEN.UpdDate = objRow[convStudentInfo_JT.UpdDate].ToString().Trim(); //修改日期
objvStudentInfo_JTEN.UpdUser = objRow[convStudentInfo_JT.UpdUser].ToString().Trim(); //修改人
objvStudentInfo_JTEN.Memo = objRow[convStudentInfo_JT.Memo] == DBNull.Value ? null : objRow[convStudentInfo_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfo_JTEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfo_JTEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvStudentInfo_JT(ref clsvStudentInfo_JTEN objvStudentInfo_JTEN)
{
bool bolResult = vStudentInfo_JTDA.GetvStudentInfo_JT(ref objvStudentInfo_JTEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentInfo_JTEN GetObjByIdStudentInfo(string strIdStudentInfo)
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
clsvStudentInfo_JTEN objvStudentInfo_JTEN = vStudentInfo_JTDA.GetObjByIdStudentInfo(strIdStudentInfo);
return objvStudentInfo_JTEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvStudentInfo_JTEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvStudentInfo_JTEN objvStudentInfo_JTEN = vStudentInfo_JTDA.GetFirstObj(strWhereCond);
 return objvStudentInfo_JTEN;
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
public static clsvStudentInfo_JTEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvStudentInfo_JTEN objvStudentInfo_JTEN = vStudentInfo_JTDA.GetObjByDataRow(objRow);
 return objvStudentInfo_JTEN;
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
public static clsvStudentInfo_JTEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvStudentInfo_JTEN objvStudentInfo_JTEN = vStudentInfo_JTDA.GetObjByDataRow(objRow);
 return objvStudentInfo_JTEN;
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
 /// <param name = "lstvStudentInfo_JTObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvStudentInfo_JTEN GetObjByIdStudentInfoFromList(string strIdStudentInfo, List<clsvStudentInfo_JTEN> lstvStudentInfo_JTObjLst)
{
foreach (clsvStudentInfo_JTEN objvStudentInfo_JTEN in lstvStudentInfo_JTObjLst)
{
if (objvStudentInfo_JTEN.IdStudentInfo == strIdStudentInfo)
{
return objvStudentInfo_JTEN;
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
 string strIdStudentInfo;
 try
 {
 strIdStudentInfo = new clsvStudentInfo_JTDA().GetFirstID(strWhereCond);
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
 arrList = vStudentInfo_JTDA.GetID(strWhereCond);
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
bool bolIsExist = vStudentInfo_JTDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vStudentInfo_JTDA.IsExist(strIdStudentInfo);
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
 bolIsExist = clsvStudentInfo_JTDA.IsExistTable();
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
 bolIsExist = vStudentInfo_JTDA.IsExistTable(strTabName);
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
 /// <param name = "objvStudentInfo_JTENS">源对象</param>
 /// <param name = "objvStudentInfo_JTENT">目标对象</param>
 public static void CopyTo(clsvStudentInfo_JTEN objvStudentInfo_JTENS, clsvStudentInfo_JTEN objvStudentInfo_JTENT)
{
try
{
objvStudentInfo_JTENT.IdStudentInfo = objvStudentInfo_JTENS.IdStudentInfo; //学生流水号
objvStudentInfo_JTENT.SiteName = objvStudentInfo_JTENS.SiteName; //工地名称
objvStudentInfo_JTENT.ManagedDepartmentId = objvStudentInfo_JTENS.ManagedDepartmentId; //管理的部门Id
objvStudentInfo_JTENT.ManagedDepartmentName = objvStudentInfo_JTENS.ManagedDepartmentName; //管理的部门名
objvStudentInfo_JTENT.JobCategoryId = objvStudentInfo_JTENS.JobCategoryId; //岗位类别Id
objvStudentInfo_JTENT.UserId = objvStudentInfo_JTENS.UserId; //用户ID
objvStudentInfo_JTENT.JobCategoryName = objvStudentInfo_JTENS.JobCategoryName; //岗位类别名
objvStudentInfo_JTENT.UpdDate = objvStudentInfo_JTENS.UpdDate; //修改日期
objvStudentInfo_JTENT.UpdUser = objvStudentInfo_JTENS.UpdUser; //修改人
objvStudentInfo_JTENT.Memo = objvStudentInfo_JTENS.Memo; //备注
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
 /// <param name = "objvStudentInfo_JTEN">源简化对象</param>
 public static void SetUpdFlag(clsvStudentInfo_JTEN objvStudentInfo_JTEN)
{
try
{
objvStudentInfo_JTEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvStudentInfo_JTEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convStudentInfo_JT.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.IdStudentInfo = objvStudentInfo_JTEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convStudentInfo_JT.SiteName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.SiteName = objvStudentInfo_JTEN.SiteName; //工地名称
}
if (arrFldSet.Contains(convStudentInfo_JT.ManagedDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.ManagedDepartmentId = objvStudentInfo_JTEN.ManagedDepartmentId; //管理的部门Id
}
if (arrFldSet.Contains(convStudentInfo_JT.ManagedDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.ManagedDepartmentName = objvStudentInfo_JTEN.ManagedDepartmentName; //管理的部门名
}
if (arrFldSet.Contains(convStudentInfo_JT.JobCategoryId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.JobCategoryId = objvStudentInfo_JTEN.JobCategoryId; //岗位类别Id
}
if (arrFldSet.Contains(convStudentInfo_JT.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.UserId = objvStudentInfo_JTEN.UserId == "[null]" ? null :  objvStudentInfo_JTEN.UserId; //用户ID
}
if (arrFldSet.Contains(convStudentInfo_JT.JobCategoryName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.JobCategoryName = objvStudentInfo_JTEN.JobCategoryName; //岗位类别名
}
if (arrFldSet.Contains(convStudentInfo_JT.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.UpdDate = objvStudentInfo_JTEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convStudentInfo_JT.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.UpdUser = objvStudentInfo_JTEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convStudentInfo_JT.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfo_JTEN.Memo = objvStudentInfo_JTEN.Memo == "[null]" ? null :  objvStudentInfo_JTEN.Memo; //备注
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
 /// <param name = "objvStudentInfo_JTEN">源简化对象</param>
 public static void AccessFldValueNull(clsvStudentInfo_JTEN objvStudentInfo_JTEN)
{
try
{
if (objvStudentInfo_JTEN.UserId == "[null]") objvStudentInfo_JTEN.UserId = null; //用户ID
if (objvStudentInfo_JTEN.Memo == "[null]") objvStudentInfo_JTEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvStudentInfo_JTEN objvStudentInfo_JTEN)
{
 vStudentInfo_JTDA.CheckProperty4Condition(objvStudentInfo_JTEN);
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
if (clsManagedDepartmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsManagedDepartmentBL没有刷新缓存机制(clsManagedDepartmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsJobCategoryBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsJobCategoryBL没有刷新缓存机制(clsJobCategoryBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfo_JTBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfo_JTBL没有刷新缓存机制(clsStudentInfo_JTBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdStudentInfo");
//if (arrvStudentInfo_JTObjLstCache == null)
//{
//arrvStudentInfo_JTObjLstCache = vStudentInfo_JTDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdStudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvStudentInfo_JTEN GetObjByIdStudentInfoCache(string strIdStudentInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName);
List<clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLst_Sel =
arrvStudentInfo_JTObjLstCache
.Where(x=> x.IdStudentInfo == strIdStudentInfo 
);
if (arrvStudentInfo_JTObjLst_Sel.Count() == 0)
{
   clsvStudentInfo_JTEN obj = clsvStudentInfo_JTBL.GetObjByIdStudentInfo(strIdStudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvStudentInfo_JTObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetAllvStudentInfo_JTObjLstCache()
{
//获取缓存中的对象列表
List<clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLstCache = GetObjLstCache(); 
return arrvStudentInfo_JTObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName);
List<clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvStudentInfo_JTObjLstCache;
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
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdStudentInfo)
{
if (strInFldName != convStudentInfo_JT.IdStudentInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convStudentInfo_JT.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convStudentInfo_JT.AttributeName));
throw new Exception(strMsg);
}
var objvStudentInfo_JT = clsvStudentInfo_JTBL.GetObjByIdStudentInfoCache(strIdStudentInfo);
if (objvStudentInfo_JT == null) return "";
return objvStudentInfo_JT[strOutFldName].ToString();
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
int intRecCount = clsvStudentInfo_JTDA.GetRecCount(strTabName);
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
int intRecCount = clsvStudentInfo_JTDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvStudentInfo_JTDA.GetRecCount();
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
int intRecCount = clsvStudentInfo_JTDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvStudentInfo_JTCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvStudentInfo_JTEN objvStudentInfo_JTCond)
{
List<clsvStudentInfo_JTEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfo_JTEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convStudentInfo_JT.AttributeName)
{
if (objvStudentInfo_JTCond.IsUpdated(strFldName) == false) continue;
if (objvStudentInfo_JTCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfo_JTCond[strFldName].ToString());
}
else
{
if (objvStudentInfo_JTCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvStudentInfo_JTCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfo_JTCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvStudentInfo_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvStudentInfo_JTCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvStudentInfo_JTCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvStudentInfo_JTCond[strFldName]));
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
 List<string> arrList = clsvStudentInfo_JTDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vStudentInfo_JTDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vStudentInfo_JTDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}