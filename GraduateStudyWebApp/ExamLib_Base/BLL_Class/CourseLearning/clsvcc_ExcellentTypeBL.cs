
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExcellentTypeBL
 表名:vcc_ExcellentType(01120063)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:10:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvcc_ExcellentTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strExcellentTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExcellentTypeEN GetObj(this K_ExcellentTypeId_vcc_ExcellentType myKey)
{
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = clsvcc_ExcellentTypeBL.vcc_ExcellentTypeDA.GetObjByExcellentTypeId(myKey.Value);
return objvcc_ExcellentTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetExcellentTypeId(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strExcellentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_ExcellentType.ExcellentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_ExcellentType.ExcellentTypeId);
}
objvcc_ExcellentTypeEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.ExcellentTypeId) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.ExcellentTypeId, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeId] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetExcellentTypeName(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strExcellentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeName, 30, convcc_ExcellentType.ExcellentTypeName);
}
objvcc_ExcellentTypeEN.ExcellentTypeName = strExcellentTypeName; //精品课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.ExcellentTypeName) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.ExcellentTypeName, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeName] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetIdSchool(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convcc_ExcellentType.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convcc_ExcellentType.IdSchool);
}
objvcc_ExcellentTypeEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.IdSchool) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.IdSchool, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.IdSchool] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetSchoolId(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convcc_ExcellentType.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convcc_ExcellentType.SchoolId);
}
objvcc_ExcellentTypeEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.SchoolId) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.SchoolId, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.SchoolId] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetSchoolName(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convcc_ExcellentType.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convcc_ExcellentType.SchoolName);
}
objvcc_ExcellentTypeEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.SchoolName) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.SchoolName, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.SchoolName] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetIsUse(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objvcc_ExcellentTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.IsUse) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.IsUse, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.IsUse] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetUpdDate(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExcellentType.UpdDate);
}
objvcc_ExcellentTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.UpdDate) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.UpdDate, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.UpdDate] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetUpdUserId(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExcellentType.UpdUserId);
}
objvcc_ExcellentTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.UpdUserId) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExcellentTypeEN SetMemo(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExcellentType.Memo);
}
objvcc_ExcellentTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExcellentTypeEN.dicFldComparisonOp.ContainsKey(convcc_ExcellentType.Memo) == false)
{
objvcc_ExcellentTypeEN.dicFldComparisonOp.Add(convcc_ExcellentType.Memo, strComparisonOp);
}
else
{
objvcc_ExcellentTypeEN.dicFldComparisonOp[convcc_ExcellentType.Memo] = strComparisonOp;
}
}
return objvcc_ExcellentTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeENS">源对象</param>
 /// <param name = "objvcc_ExcellentTypeENT">目标对象</param>
 public static void CopyTo(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENS, clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENT)
{
try
{
objvcc_ExcellentTypeENT.ExcellentTypeId = objvcc_ExcellentTypeENS.ExcellentTypeId; //精品课程类型Id
objvcc_ExcellentTypeENT.ExcellentTypeName = objvcc_ExcellentTypeENS.ExcellentTypeName; //精品课程类型名称
objvcc_ExcellentTypeENT.IdSchool = objvcc_ExcellentTypeENS.IdSchool; //学校流水号
objvcc_ExcellentTypeENT.SchoolId = objvcc_ExcellentTypeENS.SchoolId; //学校编号
objvcc_ExcellentTypeENT.SchoolName = objvcc_ExcellentTypeENS.SchoolName; //学校名称
objvcc_ExcellentTypeENT.IsUse = objvcc_ExcellentTypeENS.IsUse; //是否使用
objvcc_ExcellentTypeENT.UpdDate = objvcc_ExcellentTypeENS.UpdDate; //修改日期
objvcc_ExcellentTypeENT.UpdUserId = objvcc_ExcellentTypeENS.UpdUserId; //修改用户Id
objvcc_ExcellentTypeENT.Memo = objvcc_ExcellentTypeENS.Memo; //备注
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
 /// <param name = "objvcc_ExcellentTypeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_ExcellentTypeEN:objvcc_ExcellentTypeENT</returns>
 public static clsvcc_ExcellentTypeEN CopyTo(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENS)
{
try
{
 clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENT = new clsvcc_ExcellentTypeEN()
{
ExcellentTypeId = objvcc_ExcellentTypeENS.ExcellentTypeId, //精品课程类型Id
ExcellentTypeName = objvcc_ExcellentTypeENS.ExcellentTypeName, //精品课程类型名称
IdSchool = objvcc_ExcellentTypeENS.IdSchool, //学校流水号
SchoolId = objvcc_ExcellentTypeENS.SchoolId, //学校编号
SchoolName = objvcc_ExcellentTypeENS.SchoolName, //学校名称
IsUse = objvcc_ExcellentTypeENS.IsUse, //是否使用
UpdDate = objvcc_ExcellentTypeENS.UpdDate, //修改日期
UpdUserId = objvcc_ExcellentTypeENS.UpdUserId, //修改用户Id
Memo = objvcc_ExcellentTypeENS.Memo, //备注
};
 return objvcc_ExcellentTypeENT;
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
public static void CheckProperty4Condition(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN)
{
 clsvcc_ExcellentTypeBL.vcc_ExcellentTypeDA.CheckProperty4Condition(objvcc_ExcellentTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.ExcellentTypeId) == true)
{
string strComparisonOpExcellentTypeId = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.ExcellentTypeId, objvcc_ExcellentTypeCond.ExcellentTypeId, strComparisonOpExcellentTypeId);
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.ExcellentTypeName) == true)
{
string strComparisonOpExcellentTypeName = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.ExcellentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.ExcellentTypeName, objvcc_ExcellentTypeCond.ExcellentTypeName, strComparisonOpExcellentTypeName);
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.IdSchool) == true)
{
string strComparisonOpIdSchool = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.IdSchool, objvcc_ExcellentTypeCond.IdSchool, strComparisonOpIdSchool);
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.SchoolId) == true)
{
string strComparisonOpSchoolId = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.SchoolId, objvcc_ExcellentTypeCond.SchoolId, strComparisonOpSchoolId);
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.SchoolName) == true)
{
string strComparisonOpSchoolName = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.SchoolName, objvcc_ExcellentTypeCond.SchoolName, strComparisonOpSchoolName);
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.IsUse) == true)
{
if (objvcc_ExcellentTypeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExcellentType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExcellentType.IsUse);
}
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.UpdDate, objvcc_ExcellentTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.UpdUserId, objvcc_ExcellentTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_ExcellentTypeCond.IsUpdated(convcc_ExcellentType.Memo) == true)
{
string strComparisonOpMemo = objvcc_ExcellentTypeCond.dicFldComparisonOp[convcc_ExcellentType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExcellentType.Memo, objvcc_ExcellentTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_ExcellentType
{
public virtual bool UpdRelaTabDate(string strExcellentTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v精品课程类型(vcc_ExcellentType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExcellentTypeBL
{
public static RelatedActions_vcc_ExcellentType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_ExcellentTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_ExcellentTypeDA vcc_ExcellentTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_ExcellentTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_ExcellentTypeBL()
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
if (string.IsNullOrEmpty(clsvcc_ExcellentTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_ExcellentTypeEN._ConnectString);
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
public static DataTable GetDataTable_vcc_ExcellentType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_ExcellentTypeDA.GetDataTable_vcc_ExcellentType(strWhereCond);
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
objDT = vcc_ExcellentTypeDA.GetDataTable(strWhereCond);
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
objDT = vcc_ExcellentTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_ExcellentTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_ExcellentTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_ExcellentTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_ExcellentTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_ExcellentTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_ExcellentTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrExcellentTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetObjLstByExcellentTypeIdLst(List<string> arrExcellentTypeIdLst)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrExcellentTypeIdLst, true);
 string strWhereCond = string.Format("ExcellentTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrExcellentTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_ExcellentTypeEN> GetObjLstByExcellentTypeIdLstCache(List<string> arrExcellentTypeIdLst)
{
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel =
arrvcc_ExcellentTypeObjLstCache
.Where(x => arrExcellentTypeIdLst.Contains(x.ExcellentTypeId));
return arrvcc_ExcellentTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetObjLst(string strWhereCond)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_ExcellentTypeEN> GetSubObjLstCache(clsvcc_ExcellentTypeEN objvcc_ExcellentTypeCond)
{
List<clsvcc_ExcellentTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_ExcellentTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_ExcellentType.AttributeName)
{
if (objvcc_ExcellentTypeCond.IsUpdated(strFldName) == false) continue;
if (objvcc_ExcellentTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExcellentTypeCond[strFldName].ToString());
}
else
{
if (objvcc_ExcellentTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_ExcellentTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExcellentTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_ExcellentTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_ExcellentTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_ExcellentTypeCond[strFldName]));
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
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
List<clsvcc_ExcellentTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_ExcellentTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_ExcellentTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
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
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
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
public static List<clsvcc_ExcellentTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
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
public static List<clsvcc_ExcellentTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_ExcellentTypeEN> arrObjLst = new List<clsvcc_ExcellentTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN();
try
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objRow[convcc_ExcellentType.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_ExcellentTypeEN.ExcellentTypeName = objRow[convcc_ExcellentType.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_ExcellentType.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_ExcellentTypeEN.IdSchool = objRow[convcc_ExcellentType.IdSchool] == DBNull.Value ? null : objRow[convcc_ExcellentType.IdSchool].ToString().Trim(); //学校流水号
objvcc_ExcellentTypeEN.SchoolId = objRow[convcc_ExcellentType.SchoolId].ToString().Trim(); //学校编号
objvcc_ExcellentTypeEN.SchoolName = objRow[convcc_ExcellentType.SchoolName].ToString().Trim(); //学校名称
objvcc_ExcellentTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExcellentType.IsUse].ToString().Trim()); //是否使用
objvcc_ExcellentTypeEN.UpdDate = objRow[convcc_ExcellentType.UpdDate] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdDate].ToString().Trim(); //修改日期
objvcc_ExcellentTypeEN.UpdUserId = objRow[convcc_ExcellentType.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExcellentType.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExcellentTypeEN.Memo = objRow[convcc_ExcellentType.Memo] == DBNull.Value ? null : objRow[convcc_ExcellentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExcellentTypeEN.ExcellentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExcellentTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_ExcellentType(ref clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN)
{
bool bolResult = vcc_ExcellentTypeDA.Getvcc_ExcellentType(ref objvcc_ExcellentTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strExcellentTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExcellentTypeEN GetObjByExcellentTypeId(string strExcellentTypeId)
{
if (strExcellentTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strExcellentTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strExcellentTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strExcellentTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = vcc_ExcellentTypeDA.GetObjByExcellentTypeId(strExcellentTypeId);
return objvcc_ExcellentTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_ExcellentTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = vcc_ExcellentTypeDA.GetFirstObj(strWhereCond);
 return objvcc_ExcellentTypeEN;
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
public static clsvcc_ExcellentTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = vcc_ExcellentTypeDA.GetObjByDataRow(objRow);
 return objvcc_ExcellentTypeEN;
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
public static clsvcc_ExcellentTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = vcc_ExcellentTypeDA.GetObjByDataRow(objRow);
 return objvcc_ExcellentTypeEN;
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
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <param name = "lstvcc_ExcellentTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExcellentTypeEN GetObjByExcellentTypeIdFromList(string strExcellentTypeId, List<clsvcc_ExcellentTypeEN> lstvcc_ExcellentTypeObjLst)
{
foreach (clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN in lstvcc_ExcellentTypeObjLst)
{
if (objvcc_ExcellentTypeEN.ExcellentTypeId == strExcellentTypeId)
{
return objvcc_ExcellentTypeEN;
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
 string strExcellentTypeId;
 try
 {
 strExcellentTypeId = new clsvcc_ExcellentTypeDA().GetFirstID(strWhereCond);
 return strExcellentTypeId;
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
 arrList = vcc_ExcellentTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_ExcellentTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strExcellentTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strExcellentTypeId)
{
if (string.IsNullOrEmpty(strExcellentTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strExcellentTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_ExcellentTypeDA.IsExist(strExcellentTypeId);
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
 bolIsExist = clsvcc_ExcellentTypeDA.IsExistTable();
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
 bolIsExist = vcc_ExcellentTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_ExcellentTypeENS">源对象</param>
 /// <param name = "objvcc_ExcellentTypeENT">目标对象</param>
 public static void CopyTo(clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENS, clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENT)
{
try
{
objvcc_ExcellentTypeENT.ExcellentTypeId = objvcc_ExcellentTypeENS.ExcellentTypeId; //精品课程类型Id
objvcc_ExcellentTypeENT.ExcellentTypeName = objvcc_ExcellentTypeENS.ExcellentTypeName; //精品课程类型名称
objvcc_ExcellentTypeENT.IdSchool = objvcc_ExcellentTypeENS.IdSchool; //学校流水号
objvcc_ExcellentTypeENT.SchoolId = objvcc_ExcellentTypeENS.SchoolId; //学校编号
objvcc_ExcellentTypeENT.SchoolName = objvcc_ExcellentTypeENS.SchoolName; //学校名称
objvcc_ExcellentTypeENT.IsUse = objvcc_ExcellentTypeENS.IsUse; //是否使用
objvcc_ExcellentTypeENT.UpdDate = objvcc_ExcellentTypeENS.UpdDate; //修改日期
objvcc_ExcellentTypeENT.UpdUserId = objvcc_ExcellentTypeENS.UpdUserId; //修改用户Id
objvcc_ExcellentTypeENT.Memo = objvcc_ExcellentTypeENS.Memo; //备注
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
 /// <param name = "objvcc_ExcellentTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN)
{
try
{
objvcc_ExcellentTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_ExcellentTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_ExcellentType.ExcellentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.ExcellentTypeId = objvcc_ExcellentTypeEN.ExcellentTypeId; //精品课程类型Id
}
if (arrFldSet.Contains(convcc_ExcellentType.ExcellentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.ExcellentTypeName = objvcc_ExcellentTypeEN.ExcellentTypeName == "[null]" ? null :  objvcc_ExcellentTypeEN.ExcellentTypeName; //精品课程类型名称
}
if (arrFldSet.Contains(convcc_ExcellentType.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.IdSchool = objvcc_ExcellentTypeEN.IdSchool == "[null]" ? null :  objvcc_ExcellentTypeEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convcc_ExcellentType.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.SchoolId = objvcc_ExcellentTypeEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convcc_ExcellentType.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.SchoolName = objvcc_ExcellentTypeEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convcc_ExcellentType.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.IsUse = objvcc_ExcellentTypeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convcc_ExcellentType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.UpdDate = objvcc_ExcellentTypeEN.UpdDate == "[null]" ? null :  objvcc_ExcellentTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_ExcellentType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.UpdUserId = objvcc_ExcellentTypeEN.UpdUserId == "[null]" ? null :  objvcc_ExcellentTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_ExcellentType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExcellentTypeEN.Memo = objvcc_ExcellentTypeEN.Memo == "[null]" ? null :  objvcc_ExcellentTypeEN.Memo; //备注
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
 /// <param name = "objvcc_ExcellentTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN)
{
try
{
if (objvcc_ExcellentTypeEN.ExcellentTypeName == "[null]") objvcc_ExcellentTypeEN.ExcellentTypeName = null; //精品课程类型名称
if (objvcc_ExcellentTypeEN.IdSchool == "[null]") objvcc_ExcellentTypeEN.IdSchool = null; //学校流水号
if (objvcc_ExcellentTypeEN.UpdDate == "[null]") objvcc_ExcellentTypeEN.UpdDate = null; //修改日期
if (objvcc_ExcellentTypeEN.UpdUserId == "[null]") objvcc_ExcellentTypeEN.UpdUserId = null; //修改用户Id
if (objvcc_ExcellentTypeEN.Memo == "[null]") objvcc_ExcellentTypeEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN)
{
 vcc_ExcellentTypeDA.CheckProperty4Condition(objvcc_ExcellentTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ExcellentTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convcc_ExcellentType.ExcellentTypeId); 
List<clsvcc_ExcellentTypeEN> arrObjLst = clsvcc_ExcellentTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = new clsvcc_ExcellentTypeEN()
{
ExcellentTypeId = "0",
ExcellentTypeName = "选[v精品课程类型]..."
};
arrObjLst.Insert(0, objvcc_ExcellentTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convcc_ExcellentType.ExcellentTypeId;
objComboBox.DisplayMember = convcc_ExcellentType.ExcellentTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ExcellentTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v精品课程类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convcc_ExcellentType.ExcellentTypeId); 
IEnumerable<clsvcc_ExcellentTypeEN> arrObjLst = clsvcc_ExcellentTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = convcc_ExcellentType.ExcellentTypeId;
objDDL.DataTextField = convcc_ExcellentType.ExcellentTypeName;
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
public static void BindDdl_ExcellentTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v精品课程类型]...","0");
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst = GetAllvcc_ExcellentTypeObjLstCache(); 
objDDL.DataValueField = convcc_ExcellentType.ExcellentTypeId;
objDDL.DataTextField = convcc_ExcellentType.ExcellentTypeName;
objDDL.DataSource = arrvcc_ExcellentTypeObjLst;
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
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ExcellentTypeId");
//if (arrvcc_ExcellentTypeObjLstCache == null)
//{
//arrvcc_ExcellentTypeObjLstCache = vcc_ExcellentTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExcellentTypeEN GetObjByExcellentTypeIdCache(string strExcellentTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLst_Sel =
arrvcc_ExcellentTypeObjLstCache
.Where(x=> x.ExcellentTypeId == strExcellentTypeId 
);
if (arrvcc_ExcellentTypeObjLst_Sel.Count() == 0)
{
   clsvcc_ExcellentTypeEN obj = clsvcc_ExcellentTypeBL.GetObjByExcellentTypeId(strExcellentTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_ExcellentTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetExcellentTypeNameByExcellentTypeIdCache(string strExcellentTypeId)
{
if (string.IsNullOrEmpty(strExcellentTypeId) == true) return "";
//获取缓存中的对象列表
clsvcc_ExcellentTypeEN objvcc_ExcellentType = GetObjByExcellentTypeIdCache(strExcellentTypeId);
if (objvcc_ExcellentType == null) return "";
return objvcc_ExcellentType.ExcellentTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strExcellentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByExcellentTypeIdCache(string strExcellentTypeId)
{
if (string.IsNullOrEmpty(strExcellentTypeId) == true) return "";
//获取缓存中的对象列表
clsvcc_ExcellentTypeEN objvcc_ExcellentType = GetObjByExcellentTypeIdCache(strExcellentTypeId);
if (objvcc_ExcellentType == null) return "";
return objvcc_ExcellentType.ExcellentTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetAllvcc_ExcellentTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLstCache = GetObjLstCache(); 
return arrvcc_ExcellentTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_ExcellentTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName);
List<clsvcc_ExcellentTypeEN> arrvcc_ExcellentTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_ExcellentTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_ExcellentTypeEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strExcellentTypeId)
{
if (strInFldName != convcc_ExcellentType.ExcellentTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_ExcellentType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_ExcellentType.AttributeName));
throw new Exception(strMsg);
}
var objvcc_ExcellentType = clsvcc_ExcellentTypeBL.GetObjByExcellentTypeIdCache(strExcellentTypeId);
if (objvcc_ExcellentType == null) return "";
return objvcc_ExcellentType[strOutFldName].ToString();
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
int intRecCount = clsvcc_ExcellentTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_ExcellentTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_ExcellentTypeDA.GetRecCount();
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
int intRecCount = clsvcc_ExcellentTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_ExcellentTypeEN objvcc_ExcellentTypeCond)
{
List<clsvcc_ExcellentTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_ExcellentTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_ExcellentType.AttributeName)
{
if (objvcc_ExcellentTypeCond.IsUpdated(strFldName) == false) continue;
if (objvcc_ExcellentTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExcellentTypeCond[strFldName].ToString());
}
else
{
if (objvcc_ExcellentTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_ExcellentTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExcellentTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_ExcellentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_ExcellentTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_ExcellentTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_ExcellentTypeCond[strFldName]));
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
 List<string> arrList = clsvcc_ExcellentTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_ExcellentTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_ExcellentTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}