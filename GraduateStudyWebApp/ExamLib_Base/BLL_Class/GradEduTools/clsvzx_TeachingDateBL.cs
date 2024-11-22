
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TeachingDateBL
 表名:vzx_TeachingDate(01120857)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsvzx_TeachingDateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TeachingDateEN GetObj(this K_mId_vzx_TeachingDate myKey)
{
clsvzx_TeachingDateEN objvzx_TeachingDateEN = clsvzx_TeachingDateBL.vzx_TeachingDateDA.GetObjBymId(myKey.Value);
return objvzx_TeachingDateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetCurrEduClsId(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convzx_TeachingDate.CurrEduClsId);
}
objvzx_TeachingDateEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.CurrEduClsId) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.CurrEduClsId, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.CurrEduClsId] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetmId(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, long lngmId, string strComparisonOp="")
	{
objvzx_TeachingDateEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.mId) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.mId, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.mId] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetEduClsName(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convzx_TeachingDate.EduClsName);
}
objvzx_TeachingDateEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.EduClsName) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.EduClsName, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.EduClsName] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetIdCurrEduCls(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_TeachingDate.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_TeachingDate.IdCurrEduCls);
}
objvzx_TeachingDateEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.IdCurrEduCls) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetStartDate(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strStartDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartDate, 20, convzx_TeachingDate.StartDate);
}
objvzx_TeachingDateEN.StartDate = strStartDate; //开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.StartDate) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.StartDate, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.StartDate] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetEndDate(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndDate, 20, convzx_TeachingDate.EndDate);
}
objvzx_TeachingDateEN.EndDate = strEndDate; //截止日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.EndDate) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.EndDate, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.EndDate] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetUpdDate(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_TeachingDate.UpdDate);
}
objvzx_TeachingDateEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.UpdDate) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.UpdDate, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.UpdDate] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetUpdUser(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_TeachingDate.UpdUser);
}
objvzx_TeachingDateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.UpdUser) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.UpdUser, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.UpdUser] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TeachingDateEN SetMemo(this clsvzx_TeachingDateEN objvzx_TeachingDateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_TeachingDate.Memo);
}
objvzx_TeachingDateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TeachingDateEN.dicFldComparisonOp.ContainsKey(convzx_TeachingDate.Memo) == false)
{
objvzx_TeachingDateEN.dicFldComparisonOp.Add(convzx_TeachingDate.Memo, strComparisonOp);
}
else
{
objvzx_TeachingDateEN.dicFldComparisonOp[convzx_TeachingDate.Memo] = strComparisonOp;
}
}
return objvzx_TeachingDateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_TeachingDateENS">源对象</param>
 /// <param name = "objvzx_TeachingDateENT">目标对象</param>
 public static void CopyTo(this clsvzx_TeachingDateEN objvzx_TeachingDateENS, clsvzx_TeachingDateEN objvzx_TeachingDateENT)
{
try
{
objvzx_TeachingDateENT.CurrEduClsId = objvzx_TeachingDateENS.CurrEduClsId; //教学班Id
objvzx_TeachingDateENT.mId = objvzx_TeachingDateENS.mId; //mId
objvzx_TeachingDateENT.EduClsName = objvzx_TeachingDateENS.EduClsName; //教学班名
objvzx_TeachingDateENT.IdCurrEduCls = objvzx_TeachingDateENS.IdCurrEduCls; //教学班流水号
objvzx_TeachingDateENT.StartDate = objvzx_TeachingDateENS.StartDate; //开始日期
objvzx_TeachingDateENT.EndDate = objvzx_TeachingDateENS.EndDate; //截止日期
objvzx_TeachingDateENT.UpdDate = objvzx_TeachingDateENS.UpdDate; //修改日期
objvzx_TeachingDateENT.UpdUser = objvzx_TeachingDateENS.UpdUser; //修改人
objvzx_TeachingDateENT.Memo = objvzx_TeachingDateENS.Memo; //备注
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
 /// <param name = "objvzx_TeachingDateENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TeachingDateEN:objvzx_TeachingDateENT</returns>
 public static clsvzx_TeachingDateEN CopyTo(this clsvzx_TeachingDateEN objvzx_TeachingDateENS)
{
try
{
 clsvzx_TeachingDateEN objvzx_TeachingDateENT = new clsvzx_TeachingDateEN()
{
CurrEduClsId = objvzx_TeachingDateENS.CurrEduClsId, //教学班Id
mId = objvzx_TeachingDateENS.mId, //mId
EduClsName = objvzx_TeachingDateENS.EduClsName, //教学班名
IdCurrEduCls = objvzx_TeachingDateENS.IdCurrEduCls, //教学班流水号
StartDate = objvzx_TeachingDateENS.StartDate, //开始日期
EndDate = objvzx_TeachingDateENS.EndDate, //截止日期
UpdDate = objvzx_TeachingDateENS.UpdDate, //修改日期
UpdUser = objvzx_TeachingDateENS.UpdUser, //修改人
Memo = objvzx_TeachingDateENS.Memo, //备注
};
 return objvzx_TeachingDateENT;
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
public static void CheckProperty4Condition(this clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
 clsvzx_TeachingDateBL.vzx_TeachingDateDA.CheckProperty4Condition(objvzx_TeachingDateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_TeachingDateEN objvzx_TeachingDateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.CurrEduClsId, objvzx_TeachingDateCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.mId) == true)
{
string strComparisonOpmId = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TeachingDate.mId, objvzx_TeachingDateCond.mId, strComparisonOpmId);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.EduClsName) == true)
{
string strComparisonOpEduClsName = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.EduClsName, objvzx_TeachingDateCond.EduClsName, strComparisonOpEduClsName);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.IdCurrEduCls, objvzx_TeachingDateCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.StartDate) == true)
{
string strComparisonOpStartDate = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.StartDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.StartDate, objvzx_TeachingDateCond.StartDate, strComparisonOpStartDate);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.EndDate) == true)
{
string strComparisonOpEndDate = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.EndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.EndDate, objvzx_TeachingDateCond.EndDate, strComparisonOpEndDate);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.UpdDate, objvzx_TeachingDateCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.UpdUser, objvzx_TeachingDateCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_TeachingDateCond.IsUpdated(convzx_TeachingDate.Memo) == true)
{
string strComparisonOpMemo = objvzx_TeachingDateCond.dicFldComparisonOp[convzx_TeachingDate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TeachingDate.Memo, objvzx_TeachingDateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vzx_TeachingDate(vzx_TeachingDate), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvzx_TeachingDateEN == null) return true;
if (objvzx_TeachingDateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvzx_TeachingDateEN.mId);
if (clsvzx_TeachingDateBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvzx_TeachingDateEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvzx_TeachingDateEN.mId);
if (clsvzx_TeachingDateBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vzx_TeachingDate(vzx_TeachingDate), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvzx_TeachingDateEN == null) return "";
if (objvzx_TeachingDateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvzx_TeachingDateEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvzx_TeachingDateEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvzx_TeachingDateEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_TeachingDate
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_TeachingDate(vzx_TeachingDate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_TeachingDateBL
{
public static RelatedActions_vzx_TeachingDate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_TeachingDateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_TeachingDateDA vzx_TeachingDateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_TeachingDateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_TeachingDateBL()
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
if (string.IsNullOrEmpty(clsvzx_TeachingDateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TeachingDateEN._ConnectString);
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
public static DataTable GetDataTable_vzx_TeachingDate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_TeachingDateDA.GetDataTable_vzx_TeachingDate(strWhereCond);
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
objDT = vzx_TeachingDateDA.GetDataTable(strWhereCond);
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
objDT = vzx_TeachingDateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_TeachingDateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_TeachingDateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_TeachingDateDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_TeachingDateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_TeachingDateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_TeachingDateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_TeachingDateEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_TeachingDateEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_TeachingDateEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TeachingDateEN> arrvzx_TeachingDateObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TeachingDateEN> arrvzx_TeachingDateObjLst_Sel =
arrvzx_TeachingDateObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvzx_TeachingDateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TeachingDateEN> GetObjLst(string strWhereCond)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
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
public static List<clsvzx_TeachingDateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_TeachingDateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_TeachingDateEN> GetSubObjLstCache(clsvzx_TeachingDateEN objvzx_TeachingDateCond)
{
 string strIdCurrEduCls = objvzx_TeachingDateCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_TeachingDateBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_TeachingDateEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TeachingDateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TeachingDate.AttributeName)
{
if (objvzx_TeachingDateCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TeachingDateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TeachingDateCond[strFldName].ToString());
}
else
{
if (objvzx_TeachingDateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TeachingDateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TeachingDateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TeachingDateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TeachingDateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TeachingDateCond[strFldName]));
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
public static List<clsvzx_TeachingDateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
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
public static List<clsvzx_TeachingDateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
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
List<clsvzx_TeachingDateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_TeachingDateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TeachingDateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_TeachingDateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
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
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
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
public static List<clsvzx_TeachingDateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_TeachingDateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_TeachingDateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
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
public static List<clsvzx_TeachingDateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TeachingDateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_TeachingDateEN> arrObjLst = new List<clsvzx_TeachingDateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TeachingDateEN objvzx_TeachingDateEN = new clsvzx_TeachingDateEN();
try
{
objvzx_TeachingDateEN.CurrEduClsId = objRow[convzx_TeachingDate.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_TeachingDate.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_TeachingDateEN.mId = Int32.Parse(objRow[convzx_TeachingDate.mId].ToString().Trim()); //mId
objvzx_TeachingDateEN.EduClsName = objRow[convzx_TeachingDate.EduClsName] == DBNull.Value ? null : objRow[convzx_TeachingDate.EduClsName].ToString().Trim(); //教学班名
objvzx_TeachingDateEN.IdCurrEduCls = objRow[convzx_TeachingDate.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TeachingDate.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TeachingDateEN.StartDate = objRow[convzx_TeachingDate.StartDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.StartDate].ToString().Trim(); //开始日期
objvzx_TeachingDateEN.EndDate = objRow[convzx_TeachingDate.EndDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.EndDate].ToString().Trim(); //截止日期
objvzx_TeachingDateEN.UpdDate = objRow[convzx_TeachingDate.UpdDate] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdDate].ToString().Trim(); //修改日期
objvzx_TeachingDateEN.UpdUser = objRow[convzx_TeachingDate.UpdUser] == DBNull.Value ? null : objRow[convzx_TeachingDate.UpdUser].ToString().Trim(); //修改人
objvzx_TeachingDateEN.Memo = objRow[convzx_TeachingDate.Memo] == DBNull.Value ? null : objRow[convzx_TeachingDate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TeachingDateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TeachingDateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_TeachingDate(ref clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
bool bolResult = vzx_TeachingDateDA.Getvzx_TeachingDate(ref objvzx_TeachingDateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TeachingDateEN GetObjBymId(long lngmId)
{
clsvzx_TeachingDateEN objvzx_TeachingDateEN = vzx_TeachingDateDA.GetObjBymId(lngmId);
return objvzx_TeachingDateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_TeachingDateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_TeachingDateEN objvzx_TeachingDateEN = vzx_TeachingDateDA.GetFirstObj(strWhereCond);
 return objvzx_TeachingDateEN;
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
public static clsvzx_TeachingDateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_TeachingDateEN objvzx_TeachingDateEN = vzx_TeachingDateDA.GetObjByDataRow(objRow);
 return objvzx_TeachingDateEN;
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
public static clsvzx_TeachingDateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_TeachingDateEN objvzx_TeachingDateEN = vzx_TeachingDateDA.GetObjByDataRow(objRow);
 return objvzx_TeachingDateEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvzx_TeachingDateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TeachingDateEN GetObjBymIdFromList(long lngmId, List<clsvzx_TeachingDateEN> lstvzx_TeachingDateObjLst)
{
foreach (clsvzx_TeachingDateEN objvzx_TeachingDateEN in lstvzx_TeachingDateObjLst)
{
if (objvzx_TeachingDateEN.mId == lngmId)
{
return objvzx_TeachingDateEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvzx_TeachingDateDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vzx_TeachingDateDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_TeachingDateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vzx_TeachingDateDA.IsExist(lngmId);
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
 bolIsExist = clsvzx_TeachingDateDA.IsExistTable();
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
 bolIsExist = vzx_TeachingDateDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_TeachingDateENS">源对象</param>
 /// <param name = "objvzx_TeachingDateENT">目标对象</param>
 public static void CopyTo(clsvzx_TeachingDateEN objvzx_TeachingDateENS, clsvzx_TeachingDateEN objvzx_TeachingDateENT)
{
try
{
objvzx_TeachingDateENT.CurrEduClsId = objvzx_TeachingDateENS.CurrEduClsId; //教学班Id
objvzx_TeachingDateENT.mId = objvzx_TeachingDateENS.mId; //mId
objvzx_TeachingDateENT.EduClsName = objvzx_TeachingDateENS.EduClsName; //教学班名
objvzx_TeachingDateENT.IdCurrEduCls = objvzx_TeachingDateENS.IdCurrEduCls; //教学班流水号
objvzx_TeachingDateENT.StartDate = objvzx_TeachingDateENS.StartDate; //开始日期
objvzx_TeachingDateENT.EndDate = objvzx_TeachingDateENS.EndDate; //截止日期
objvzx_TeachingDateENT.UpdDate = objvzx_TeachingDateENS.UpdDate; //修改日期
objvzx_TeachingDateENT.UpdUser = objvzx_TeachingDateENS.UpdUser; //修改人
objvzx_TeachingDateENT.Memo = objvzx_TeachingDateENS.Memo; //备注
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
 /// <param name = "objvzx_TeachingDateEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
try
{
objvzx_TeachingDateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_TeachingDateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_TeachingDate.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.CurrEduClsId = objvzx_TeachingDateEN.CurrEduClsId == "[null]" ? null :  objvzx_TeachingDateEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convzx_TeachingDate.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.mId = objvzx_TeachingDateEN.mId; //mId
}
if (arrFldSet.Contains(convzx_TeachingDate.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.EduClsName = objvzx_TeachingDateEN.EduClsName == "[null]" ? null :  objvzx_TeachingDateEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convzx_TeachingDate.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.IdCurrEduCls = objvzx_TeachingDateEN.IdCurrEduCls == "[null]" ? null :  objvzx_TeachingDateEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_TeachingDate.StartDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.StartDate = objvzx_TeachingDateEN.StartDate == "[null]" ? null :  objvzx_TeachingDateEN.StartDate; //开始日期
}
if (arrFldSet.Contains(convzx_TeachingDate.EndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.EndDate = objvzx_TeachingDateEN.EndDate == "[null]" ? null :  objvzx_TeachingDateEN.EndDate; //截止日期
}
if (arrFldSet.Contains(convzx_TeachingDate.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.UpdDate = objvzx_TeachingDateEN.UpdDate == "[null]" ? null :  objvzx_TeachingDateEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_TeachingDate.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.UpdUser = objvzx_TeachingDateEN.UpdUser == "[null]" ? null :  objvzx_TeachingDateEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_TeachingDate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TeachingDateEN.Memo = objvzx_TeachingDateEN.Memo == "[null]" ? null :  objvzx_TeachingDateEN.Memo; //备注
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
 /// <param name = "objvzx_TeachingDateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
try
{
if (objvzx_TeachingDateEN.CurrEduClsId == "[null]") objvzx_TeachingDateEN.CurrEduClsId = null; //教学班Id
if (objvzx_TeachingDateEN.EduClsName == "[null]") objvzx_TeachingDateEN.EduClsName = null; //教学班名
if (objvzx_TeachingDateEN.IdCurrEduCls == "[null]") objvzx_TeachingDateEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_TeachingDateEN.StartDate == "[null]") objvzx_TeachingDateEN.StartDate = null; //开始日期
if (objvzx_TeachingDateEN.EndDate == "[null]") objvzx_TeachingDateEN.EndDate = null; //截止日期
if (objvzx_TeachingDateEN.UpdDate == "[null]") objvzx_TeachingDateEN.UpdDate = null; //修改日期
if (objvzx_TeachingDateEN.UpdUser == "[null]") objvzx_TeachingDateEN.UpdUser = null; //修改人
if (objvzx_TeachingDateEN.Memo == "[null]") objvzx_TeachingDateEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
 vzx_TeachingDateDA.CheckProperty4Condition(objvzx_TeachingDateEN);
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TeachingDateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TeachingDateBL没有刷新缓存机制(clszx_TeachingDateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvzx_TeachingDateObjLstCache == null)
//{
//arrvzx_TeachingDateObjLstCache = vzx_TeachingDateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TeachingDateEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvzx_TeachingDateEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TeachingDateEN> arrvzx_TeachingDateObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TeachingDateEN> arrvzx_TeachingDateObjLst_Sel =
arrvzx_TeachingDateObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvzx_TeachingDateObjLst_Sel.Count() == 0)
{
   clsvzx_TeachingDateEN obj = clsvzx_TeachingDateBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_TeachingDateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TeachingDateEN> GetAllvzx_TeachingDateObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_TeachingDateEN> arrvzx_TeachingDateObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_TeachingDateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TeachingDateEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvzx_TeachingDateEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_TeachingDateEN> arrvzx_TeachingDateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_TeachingDateObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvzx_TeachingDateEN._CurrTabName, strIdCurrEduCls);
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

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vzx_TeachingDate(vzx_TeachingDate)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvzx_TeachingDateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvzx_TeachingDateEN objvzx_TeachingDateEN)
{
//检测记录是否存在
string strResult = vzx_TeachingDateDA.GetUniCondStr(objvzx_TeachingDateEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strIdCurrEduCls)
{
if (strInFldName != convzx_TeachingDate.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_TeachingDate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_TeachingDate.AttributeName));
throw new Exception(strMsg);
}
var objvzx_TeachingDate = clsvzx_TeachingDateBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objvzx_TeachingDate == null) return "";
return objvzx_TeachingDate[strOutFldName].ToString();
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
int intRecCount = clsvzx_TeachingDateDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_TeachingDateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_TeachingDateDA.GetRecCount();
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
int intRecCount = clsvzx_TeachingDateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_TeachingDateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_TeachingDateEN objvzx_TeachingDateCond)
{
 string strIdCurrEduCls = objvzx_TeachingDateCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_TeachingDateBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_TeachingDateEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TeachingDateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TeachingDate.AttributeName)
{
if (objvzx_TeachingDateCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TeachingDateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TeachingDateCond[strFldName].ToString());
}
else
{
if (objvzx_TeachingDateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TeachingDateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TeachingDateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TeachingDateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TeachingDateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TeachingDateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TeachingDateCond[strFldName]));
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
 List<string> arrList = clsvzx_TeachingDateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_TeachingDateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_TeachingDateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}