﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachSkillBL
 表名:vTeachSkill(01120314)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
public static class  clsvTeachSkillBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachSkill">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachSkillEN GetObj(this K_IdTeachSkill_vTeachSkill myKey)
{
clsvTeachSkillEN objvTeachSkillEN = clsvTeachSkillBL.vTeachSkillDA.GetObjByIdTeachSkill(myKey.Value);
return objvTeachSkillEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetIdTeachSkill(this clsvTeachSkillEN objvTeachSkillEN, string strIdTeachSkill, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convTeachSkill.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convTeachSkill.IdTeachSkill);
}
objvTeachSkillEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.IdTeachSkill) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.IdTeachSkill, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.IdTeachSkill] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillID(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convTeachSkill.TeachSkillID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachSkill.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachSkill.TeachSkillID);
}
objvTeachSkillEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillID) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillID, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillID] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetSkillTypeName(this clsvTeachSkillEN objvTeachSkillEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeName, convTeachSkill.SkillTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachSkill.SkillTypeName);
}
objvTeachSkillEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.SkillTypeName) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.SkillTypeName, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.SkillTypeName] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillName(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convTeachSkill.TeachSkillName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachSkill.TeachSkillName);
}
objvTeachSkillEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillName) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillName, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillName] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillTheory(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachSkill.TeachSkillTheory);
}
objvTeachSkillEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillTheory) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetTeachSkillOperMethod(this clsvTeachSkillEN objvTeachSkillEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachSkill.TeachSkillOperMethod);
}
objvTeachSkillEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.TeachSkillOperMethod) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetIdSkillType(this clsvTeachSkillEN objvTeachSkillEN, string strIdSkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSkillType, convTeachSkill.IdSkillType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convTeachSkill.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convTeachSkill.IdSkillType);
}
objvTeachSkillEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.IdSkillType) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.IdSkillType, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.IdSkillType] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetMemo(this clsvTeachSkillEN objvTeachSkillEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachSkill.Memo);
}
objvTeachSkillEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.Memo) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.Memo, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.Memo] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachSkillEN SetSkillTypeID(this clsvTeachSkillEN objvTeachSkillEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeID, convTeachSkill.SkillTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachSkill.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachSkill.SkillTypeID);
}
objvTeachSkillEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachSkillEN.dicFldComparisonOp.ContainsKey(convTeachSkill.SkillTypeID) == false)
{
objvTeachSkillEN.dicFldComparisonOp.Add(convTeachSkill.SkillTypeID, strComparisonOp);
}
else
{
objvTeachSkillEN.dicFldComparisonOp[convTeachSkill.SkillTypeID] = strComparisonOp;
}
}
return objvTeachSkillEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachSkillENS">源对象</param>
 /// <param name = "objvTeachSkillENT">目标对象</param>
 public static void CopyTo(this clsvTeachSkillEN objvTeachSkillENS, clsvTeachSkillEN objvTeachSkillENT)
{
try
{
objvTeachSkillENT.IdTeachSkill = objvTeachSkillENS.IdTeachSkill; //教学技能流水号
objvTeachSkillENT.TeachSkillID = objvTeachSkillENS.TeachSkillID; //教学技能ID
objvTeachSkillENT.SkillTypeName = objvTeachSkillENS.SkillTypeName; //技能类型名称
objvTeachSkillENT.TeachSkillName = objvTeachSkillENS.TeachSkillName; //教学技能名称
objvTeachSkillENT.TeachSkillTheory = objvTeachSkillENS.TeachSkillTheory; //教学技能理论阐述
objvTeachSkillENT.TeachSkillOperMethod = objvTeachSkillENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachSkillENT.IdSkillType = objvTeachSkillENS.IdSkillType; //技能类型流水号
objvTeachSkillENT.Memo = objvTeachSkillENS.Memo; //备注
objvTeachSkillENT.SkillTypeID = objvTeachSkillENS.SkillTypeID; //技能类型ID
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
 /// <param name = "objvTeachSkillENS">源对象</param>
 /// <returns>目标对象=>clsvTeachSkillEN:objvTeachSkillENT</returns>
 public static clsvTeachSkillEN CopyTo(this clsvTeachSkillEN objvTeachSkillENS)
{
try
{
 clsvTeachSkillEN objvTeachSkillENT = new clsvTeachSkillEN()
{
IdTeachSkill = objvTeachSkillENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvTeachSkillENS.TeachSkillID, //教学技能ID
SkillTypeName = objvTeachSkillENS.SkillTypeName, //技能类型名称
TeachSkillName = objvTeachSkillENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvTeachSkillENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvTeachSkillENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvTeachSkillENS.IdSkillType, //技能类型流水号
Memo = objvTeachSkillENS.Memo, //备注
SkillTypeID = objvTeachSkillENS.SkillTypeID, //技能类型ID
};
 return objvTeachSkillENT;
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
public static void CheckProperty4Condition(this clsvTeachSkillEN objvTeachSkillEN)
{
 clsvTeachSkillBL.vTeachSkillDA.CheckProperty4Condition(objvTeachSkillEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachSkillEN objvTeachSkillCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachSkillCond.IsUpdated(convTeachSkill.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.IdTeachSkill, objvTeachSkillCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillID, objvTeachSkillCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.SkillTypeName, objvTeachSkillCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillName, objvTeachSkillCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillTheory, objvTeachSkillCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.TeachSkillOperMethod, objvTeachSkillCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.IdSkillType, objvTeachSkillCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.Memo) == true)
{
string strComparisonOpMemo = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.Memo, objvTeachSkillCond.Memo, strComparisonOpMemo);
}
if (objvTeachSkillCond.IsUpdated(convTeachSkill.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvTeachSkillCond.dicFldComparisonOp[convTeachSkill.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachSkill.SkillTypeID, objvTeachSkillCond.SkillTypeID, strComparisonOpSkillTypeID);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachSkill
{
public virtual bool UpdRelaTabDate(string strIdTeachSkill, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教学技能视图(vTeachSkill)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachSkillBL
{
public static RelatedActions_vTeachSkill relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachSkillDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachSkillDA vTeachSkillDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachSkillDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachSkillBL()
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
if (string.IsNullOrEmpty(clsvTeachSkillEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachSkillEN._ConnectString);
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
public static DataTable GetDataTable_vTeachSkill(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachSkillDA.GetDataTable_vTeachSkill(strWhereCond);
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
objDT = vTeachSkillDA.GetDataTable(strWhereCond);
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
objDT = vTeachSkillDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachSkillDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachSkillDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachSkillDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachSkillDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachSkillLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachSkillEN> GetObjLstByIdTeachSkillLst(List<string> arrIdTeachSkillLst)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachSkillLst, true);
 string strWhereCond = string.Format("IdTeachSkill in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachSkillLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachSkillEN> GetObjLstByIdTeachSkillLstCache(List<string> arrIdTeachSkillLst)
{
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName);
List<clsvTeachSkillEN> arrvTeachSkillObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachSkillEN> arrvTeachSkillObjLst_Sel =
arrvTeachSkillObjLstCache
.Where(x => arrIdTeachSkillLst.Contains(x.IdTeachSkill));
return arrvTeachSkillObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachSkillEN> GetObjLst(string strWhereCond)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
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
public static List<clsvTeachSkillEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachSkillEN> GetSubObjLstCache(clsvTeachSkillEN objvTeachSkillCond)
{
List<clsvTeachSkillEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachSkill.AttributeName)
{
if (objvTeachSkillCond.IsUpdated(strFldName) == false) continue;
if (objvTeachSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachSkillCond[strFldName].ToString());
}
else
{
if (objvTeachSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachSkillCond[strFldName]));
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
public static List<clsvTeachSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
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
public static List<clsvTeachSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
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
List<clsvTeachSkillEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachSkillEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachSkillEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
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
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
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
public static List<clsvTeachSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachSkillEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
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
public static List<clsvTeachSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachSkillEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachSkillEN> arrObjLst = new List<clsvTeachSkillEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachSkillEN objvTeachSkillEN = new clsvTeachSkillEN();
try
{
objvTeachSkillEN.IdTeachSkill = objRow[convTeachSkill.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachSkillEN.TeachSkillID = objRow[convTeachSkill.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachSkillEN.SkillTypeName = objRow[convTeachSkill.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachSkillEN.TeachSkillName = objRow[convTeachSkill.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachSkillEN.TeachSkillTheory = objRow[convTeachSkill.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachSkillEN.TeachSkillOperMethod = objRow[convTeachSkill.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachSkill.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachSkillEN.IdSkillType = objRow[convTeachSkill.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachSkillEN.Memo = objRow[convTeachSkill.Memo] == DBNull.Value ? null : objRow[convTeachSkill.Memo].ToString().Trim(); //备注
objvTeachSkillEN.SkillTypeID = objRow[convTeachSkill.SkillTypeID].ToString().Trim(); //技能类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachSkillEN.IdTeachSkill, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachSkillEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachSkillEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachSkill(ref clsvTeachSkillEN objvTeachSkillEN)
{
bool bolResult = vTeachSkillDA.GetvTeachSkill(ref objvTeachSkillEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachSkill">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachSkillEN GetObjByIdTeachSkill(string strIdTeachSkill)
{
if (strIdTeachSkill.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeachSkill]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeachSkill) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeachSkill]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTeachSkillEN objvTeachSkillEN = vTeachSkillDA.GetObjByIdTeachSkill(strIdTeachSkill);
return objvTeachSkillEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachSkillEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachSkillEN objvTeachSkillEN = vTeachSkillDA.GetFirstObj(strWhereCond);
 return objvTeachSkillEN;
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
public static clsvTeachSkillEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachSkillEN objvTeachSkillEN = vTeachSkillDA.GetObjByDataRow(objRow);
 return objvTeachSkillEN;
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
public static clsvTeachSkillEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachSkillEN objvTeachSkillEN = vTeachSkillDA.GetObjByDataRow(objRow);
 return objvTeachSkillEN;
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
 /// <param name = "strIdTeachSkill">所给的关键字</param>
 /// <param name = "lstvTeachSkillObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachSkillEN GetObjByIdTeachSkillFromList(string strIdTeachSkill, List<clsvTeachSkillEN> lstvTeachSkillObjLst)
{
foreach (clsvTeachSkillEN objvTeachSkillEN in lstvTeachSkillObjLst)
{
if (objvTeachSkillEN.IdTeachSkill == strIdTeachSkill)
{
return objvTeachSkillEN;
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
 string strIdTeachSkill;
 try
 {
 strIdTeachSkill = new clsvTeachSkillDA().GetFirstID(strWhereCond);
 return strIdTeachSkill;
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
 arrList = vTeachSkillDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachSkillDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeachSkill">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeachSkill)
{
if (string.IsNullOrEmpty(strIdTeachSkill) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeachSkill]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTeachSkillDA.IsExist(strIdTeachSkill);
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
 bolIsExist = clsvTeachSkillDA.IsExistTable();
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
 bolIsExist = vTeachSkillDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachSkillENS">源对象</param>
 /// <param name = "objvTeachSkillENT">目标对象</param>
 public static void CopyTo(clsvTeachSkillEN objvTeachSkillENS, clsvTeachSkillEN objvTeachSkillENT)
{
try
{
objvTeachSkillENT.IdTeachSkill = objvTeachSkillENS.IdTeachSkill; //教学技能流水号
objvTeachSkillENT.TeachSkillID = objvTeachSkillENS.TeachSkillID; //教学技能ID
objvTeachSkillENT.SkillTypeName = objvTeachSkillENS.SkillTypeName; //技能类型名称
objvTeachSkillENT.TeachSkillName = objvTeachSkillENS.TeachSkillName; //教学技能名称
objvTeachSkillENT.TeachSkillTheory = objvTeachSkillENS.TeachSkillTheory; //教学技能理论阐述
objvTeachSkillENT.TeachSkillOperMethod = objvTeachSkillENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachSkillENT.IdSkillType = objvTeachSkillENS.IdSkillType; //技能类型流水号
objvTeachSkillENT.Memo = objvTeachSkillENS.Memo; //备注
objvTeachSkillENT.SkillTypeID = objvTeachSkillENS.SkillTypeID; //技能类型ID
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
 /// <param name = "objvTeachSkillEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachSkillEN objvTeachSkillEN)
{
try
{
objvTeachSkillEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachSkillEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachSkill.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.IdTeachSkill = objvTeachSkillEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convTeachSkill.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.TeachSkillID = objvTeachSkillEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convTeachSkill.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.SkillTypeName = objvTeachSkillEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convTeachSkill.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.TeachSkillName = objvTeachSkillEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convTeachSkill.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.TeachSkillTheory = objvTeachSkillEN.TeachSkillTheory == "[null]" ? null :  objvTeachSkillEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convTeachSkill.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.TeachSkillOperMethod = objvTeachSkillEN.TeachSkillOperMethod == "[null]" ? null :  objvTeachSkillEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convTeachSkill.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.IdSkillType = objvTeachSkillEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convTeachSkill.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.Memo = objvTeachSkillEN.Memo == "[null]" ? null :  objvTeachSkillEN.Memo; //备注
}
if (arrFldSet.Contains(convTeachSkill.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachSkillEN.SkillTypeID = objvTeachSkillEN.SkillTypeID; //技能类型ID
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
 /// <param name = "objvTeachSkillEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachSkillEN objvTeachSkillEN)
{
try
{
if (objvTeachSkillEN.TeachSkillTheory == "[null]") objvTeachSkillEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvTeachSkillEN.TeachSkillOperMethod == "[null]") objvTeachSkillEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvTeachSkillEN.Memo == "[null]") objvTeachSkillEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvTeachSkillEN objvTeachSkillEN)
{
 vTeachSkillDA.CheckProperty4Condition(objvTeachSkillEN);
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
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachSkill");
//if (arrvTeachSkillObjLstCache == null)
//{
//arrvTeachSkillObjLstCache = vTeachSkillDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachSkill">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachSkillEN GetObjByIdTeachSkillCache(string strIdTeachSkill)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName);
List<clsvTeachSkillEN> arrvTeachSkillObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachSkillEN> arrvTeachSkillObjLst_Sel =
arrvTeachSkillObjLstCache
.Where(x=> x.IdTeachSkill == strIdTeachSkill 
);
if (arrvTeachSkillObjLst_Sel.Count() == 0)
{
   clsvTeachSkillEN obj = clsvTeachSkillBL.GetObjByIdTeachSkill(strIdTeachSkill);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachSkillObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachSkillEN> GetAllvTeachSkillObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachSkillEN> arrvTeachSkillObjLstCache = GetObjLstCache(); 
return arrvTeachSkillObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachSkillEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName);
List<clsvTeachSkillEN> arrvTeachSkillObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachSkillObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachSkillEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdTeachSkill)
{
if (strInFldName != convTeachSkill.IdTeachSkill)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachSkill.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachSkill.AttributeName));
throw new Exception(strMsg);
}
var objvTeachSkill = clsvTeachSkillBL.GetObjByIdTeachSkillCache(strIdTeachSkill);
if (objvTeachSkill == null) return "";
return objvTeachSkill[strOutFldName].ToString();
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
int intRecCount = clsvTeachSkillDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachSkillDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachSkillDA.GetRecCount();
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
int intRecCount = clsvTeachSkillDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachSkillEN objvTeachSkillCond)
{
List<clsvTeachSkillEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachSkill.AttributeName)
{
if (objvTeachSkillCond.IsUpdated(strFldName) == false) continue;
if (objvTeachSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachSkillCond[strFldName].ToString());
}
else
{
if (objvTeachSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachSkillCond[strFldName]));
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
 List<string> arrList = clsvTeachSkillDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachSkillDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachSkillDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}