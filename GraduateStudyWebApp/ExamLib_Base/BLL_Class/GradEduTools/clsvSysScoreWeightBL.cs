
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysScoreWeightBL
 表名:vSysScoreWeight(01120630)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:38:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvSysScoreWeightBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strScoreWeightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysScoreWeightEN GetObj(this K_ScoreWeightId_vSysScoreWeight myKey)
{
clsvSysScoreWeightEN objvSysScoreWeightEN = clsvSysScoreWeightBL.vSysScoreWeightDA.GetObjByScoreWeightId(myKey.Value);
return objvSysScoreWeightEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetScoreWeightId(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strScoreWeightId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreWeightId, 1, convSysScoreWeight.ScoreWeightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreWeightId, 1, convSysScoreWeight.ScoreWeightId);
}
objvSysScoreWeightEN.ScoreWeightId = strScoreWeightId; //分数权重Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.ScoreWeightId) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.ScoreWeightId, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.ScoreWeightId] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetScoreWeightValue(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strScoreWeightValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strScoreWeightValue, convSysScoreWeight.ScoreWeightValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreWeightValue, 20, convSysScoreWeight.ScoreWeightValue);
}
objvSysScoreWeightEN.ScoreWeightValue = strScoreWeightValue; //分数权重值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.ScoreWeightValue) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.ScoreWeightValue, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.ScoreWeightValue] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetIsPublic(this clsvSysScoreWeightEN objvSysScoreWeightEN, bool bolIsPublic, string strComparisonOp="")
	{
objvSysScoreWeightEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.IsPublic) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.IsPublic, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.IsPublic] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetUpdDate(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysScoreWeight.UpdDate);
}
objvSysScoreWeightEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.UpdDate) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.UpdDate, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.UpdDate] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetUpdUser(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysScoreWeight.UpdUser);
}
objvSysScoreWeightEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.UpdUser) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.UpdUser, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.UpdUser] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetMemo(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysScoreWeight.Memo);
}
objvSysScoreWeightEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.Memo) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.Memo, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.Memo] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetScoreTypeId(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strScoreTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeId, 4, convSysScoreWeight.ScoreTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreTypeId, 4, convSysScoreWeight.ScoreTypeId);
}
objvSysScoreWeightEN.ScoreTypeId = strScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.ScoreTypeId) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.ScoreTypeId, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.ScoreTypeId] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetScoreTypeName(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strScoreTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeName, 10, convSysScoreWeight.ScoreTypeName);
}
objvSysScoreWeightEN.ScoreTypeName = strScoreTypeName; //分数类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.ScoreTypeName) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.ScoreTypeName, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.ScoreTypeName] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetOnlyId(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strOnlyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOnlyId, 20, convSysScoreWeight.OnlyId);
}
objvSysScoreWeightEN.OnlyId = strOnlyId; //OnlyId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.OnlyId) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.OnlyId, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.OnlyId] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetIdCurrEduCls(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convSysScoreWeight.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convSysScoreWeight.IdCurrEduCls);
}
objvSysScoreWeightEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.IdCurrEduCls) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.IdCurrEduCls, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.IdCurrEduCls] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetCurrEduClsId(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, convSysScoreWeight.CurrEduClsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convSysScoreWeight.CurrEduClsId);
}
objvSysScoreWeightEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.CurrEduClsId) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.CurrEduClsId, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.CurrEduClsId] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreWeightEN SetEduClsName(this clsvSysScoreWeightEN objvSysScoreWeightEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convSysScoreWeight.EduClsName);
}
objvSysScoreWeightEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreWeightEN.dicFldComparisonOp.ContainsKey(convSysScoreWeight.EduClsName) == false)
{
objvSysScoreWeightEN.dicFldComparisonOp.Add(convSysScoreWeight.EduClsName, strComparisonOp);
}
else
{
objvSysScoreWeightEN.dicFldComparisonOp[convSysScoreWeight.EduClsName] = strComparisonOp;
}
}
return objvSysScoreWeightEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysScoreWeightENS">源对象</param>
 /// <param name = "objvSysScoreWeightENT">目标对象</param>
 public static void CopyTo(this clsvSysScoreWeightEN objvSysScoreWeightENS, clsvSysScoreWeightEN objvSysScoreWeightENT)
{
try
{
objvSysScoreWeightENT.ScoreWeightId = objvSysScoreWeightENS.ScoreWeightId; //分数权重Id
objvSysScoreWeightENT.ScoreWeightValue = objvSysScoreWeightENS.ScoreWeightValue; //分数权重值
objvSysScoreWeightENT.IsPublic = objvSysScoreWeightENS.IsPublic; //是否公开
objvSysScoreWeightENT.UpdDate = objvSysScoreWeightENS.UpdDate; //修改日期
objvSysScoreWeightENT.UpdUser = objvSysScoreWeightENS.UpdUser; //修改人
objvSysScoreWeightENT.Memo = objvSysScoreWeightENS.Memo; //备注
objvSysScoreWeightENT.ScoreTypeId = objvSysScoreWeightENS.ScoreTypeId; //分数类型Id
objvSysScoreWeightENT.ScoreTypeName = objvSysScoreWeightENS.ScoreTypeName; //分数类型名称
objvSysScoreWeightENT.OnlyId = objvSysScoreWeightENS.OnlyId; //OnlyId
objvSysScoreWeightENT.IdCurrEduCls = objvSysScoreWeightENS.IdCurrEduCls; //教学班流水号
objvSysScoreWeightENT.CurrEduClsId = objvSysScoreWeightENS.CurrEduClsId; //教学班Id
objvSysScoreWeightENT.EduClsName = objvSysScoreWeightENS.EduClsName; //教学班名
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
 /// <param name = "objvSysScoreWeightENS">源对象</param>
 /// <returns>目标对象=>clsvSysScoreWeightEN:objvSysScoreWeightENT</returns>
 public static clsvSysScoreWeightEN CopyTo(this clsvSysScoreWeightEN objvSysScoreWeightENS)
{
try
{
 clsvSysScoreWeightEN objvSysScoreWeightENT = new clsvSysScoreWeightEN()
{
ScoreWeightId = objvSysScoreWeightENS.ScoreWeightId, //分数权重Id
ScoreWeightValue = objvSysScoreWeightENS.ScoreWeightValue, //分数权重值
IsPublic = objvSysScoreWeightENS.IsPublic, //是否公开
UpdDate = objvSysScoreWeightENS.UpdDate, //修改日期
UpdUser = objvSysScoreWeightENS.UpdUser, //修改人
Memo = objvSysScoreWeightENS.Memo, //备注
ScoreTypeId = objvSysScoreWeightENS.ScoreTypeId, //分数类型Id
ScoreTypeName = objvSysScoreWeightENS.ScoreTypeName, //分数类型名称
OnlyId = objvSysScoreWeightENS.OnlyId, //OnlyId
IdCurrEduCls = objvSysScoreWeightENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objvSysScoreWeightENS.CurrEduClsId, //教学班Id
EduClsName = objvSysScoreWeightENS.EduClsName, //教学班名
};
 return objvSysScoreWeightENT;
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
public static void CheckProperty4Condition(this clsvSysScoreWeightEN objvSysScoreWeightEN)
{
 clsvSysScoreWeightBL.vSysScoreWeightDA.CheckProperty4Condition(objvSysScoreWeightEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysScoreWeightEN objvSysScoreWeightCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.ScoreWeightId) == true)
{
string strComparisonOpScoreWeightId = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.ScoreWeightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.ScoreWeightId, objvSysScoreWeightCond.ScoreWeightId, strComparisonOpScoreWeightId);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.ScoreWeightValue) == true)
{
string strComparisonOpScoreWeightValue = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.ScoreWeightValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.ScoreWeightValue, objvSysScoreWeightCond.ScoreWeightValue, strComparisonOpScoreWeightValue);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.IsPublic) == true)
{
if (objvSysScoreWeightCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSysScoreWeight.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSysScoreWeight.IsPublic);
}
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.UpdDate, objvSysScoreWeightCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.UpdUser, objvSysScoreWeightCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.Memo) == true)
{
string strComparisonOpMemo = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.Memo, objvSysScoreWeightCond.Memo, strComparisonOpMemo);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.ScoreTypeId) == true)
{
string strComparisonOpScoreTypeId = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.ScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.ScoreTypeId, objvSysScoreWeightCond.ScoreTypeId, strComparisonOpScoreTypeId);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.ScoreTypeName) == true)
{
string strComparisonOpScoreTypeName = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.ScoreTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.ScoreTypeName, objvSysScoreWeightCond.ScoreTypeName, strComparisonOpScoreTypeName);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.OnlyId) == true)
{
string strComparisonOpOnlyId = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.OnlyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.OnlyId, objvSysScoreWeightCond.OnlyId, strComparisonOpOnlyId);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.IdCurrEduCls, objvSysScoreWeightCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.CurrEduClsId, objvSysScoreWeightCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvSysScoreWeightCond.IsUpdated(convSysScoreWeight.EduClsName) == true)
{
string strComparisonOpEduClsName = objvSysScoreWeightCond.dicFldComparisonOp[convSysScoreWeight.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreWeight.EduClsName, objvSysScoreWeightCond.EduClsName, strComparisonOpEduClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysScoreWeight
{
public virtual bool UpdRelaTabDate(string strScoreWeightId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v系统分数权重表(vSysScoreWeight)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysScoreWeightBL
{
public static RelatedActions_vSysScoreWeight relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysScoreWeightDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysScoreWeightDA vSysScoreWeightDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysScoreWeightDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysScoreWeightBL()
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
if (string.IsNullOrEmpty(clsvSysScoreWeightEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysScoreWeightEN._ConnectString);
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
public static DataTable GetDataTable_vSysScoreWeight(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysScoreWeightDA.GetDataTable_vSysScoreWeight(strWhereCond);
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
objDT = vSysScoreWeightDA.GetDataTable(strWhereCond);
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
objDT = vSysScoreWeightDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSysScoreWeightDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSysScoreWeightDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSysScoreWeightDA.GetDataTable_Top(objTopPara);
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
objDT = vSysScoreWeightDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSysScoreWeightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSysScoreWeightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrScoreWeightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSysScoreWeightEN> GetObjLstByScoreWeightIdLst(List<string> arrScoreWeightIdLst)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrScoreWeightIdLst, true);
 string strWhereCond = string.Format("ScoreWeightId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrScoreWeightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysScoreWeightEN> GetObjLstByScoreWeightIdLstCache(List<string> arrScoreWeightIdLst)
{
string strKey = string.Format("{0}", clsvSysScoreWeightEN._CurrTabName);
List<clsvSysScoreWeightEN> arrvSysScoreWeightObjLstCache = GetObjLstCache();
IEnumerable <clsvSysScoreWeightEN> arrvSysScoreWeightObjLst_Sel =
arrvSysScoreWeightObjLstCache
.Where(x => arrScoreWeightIdLst.Contains(x.ScoreWeightId));
return arrvSysScoreWeightObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysScoreWeightEN> GetObjLst(string strWhereCond)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
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
public static List<clsvSysScoreWeightEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysScoreWeightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysScoreWeightEN> GetSubObjLstCache(clsvSysScoreWeightEN objvSysScoreWeightCond)
{
List<clsvSysScoreWeightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysScoreWeightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysScoreWeight.AttributeName)
{
if (objvSysScoreWeightCond.IsUpdated(strFldName) == false) continue;
if (objvSysScoreWeightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreWeightCond[strFldName].ToString());
}
else
{
if (objvSysScoreWeightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysScoreWeightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreWeightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysScoreWeightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysScoreWeightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysScoreWeightCond[strFldName]));
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
public static List<clsvSysScoreWeightEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
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
public static List<clsvSysScoreWeightEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
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
List<clsvSysScoreWeightEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSysScoreWeightEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysScoreWeightEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSysScoreWeightEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
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
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
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
public static List<clsvSysScoreWeightEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysScoreWeightEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSysScoreWeightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
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
public static List<clsvSysScoreWeightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysScoreWeightEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysScoreWeightEN> arrObjLst = new List<clsvSysScoreWeightEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreWeightEN objvSysScoreWeightEN = new clsvSysScoreWeightEN();
try
{
objvSysScoreWeightEN.ScoreWeightId = objRow[convSysScoreWeight.ScoreWeightId].ToString().Trim(); //分数权重Id
objvSysScoreWeightEN.ScoreWeightValue = objRow[convSysScoreWeight.ScoreWeightValue].ToString().Trim(); //分数权重值
objvSysScoreWeightEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreWeight.IsPublic].ToString().Trim()); //是否公开
objvSysScoreWeightEN.UpdDate = objRow[convSysScoreWeight.UpdDate] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdDate].ToString().Trim(); //修改日期
objvSysScoreWeightEN.UpdUser = objRow[convSysScoreWeight.UpdUser] == DBNull.Value ? null : objRow[convSysScoreWeight.UpdUser].ToString().Trim(); //修改人
objvSysScoreWeightEN.Memo = objRow[convSysScoreWeight.Memo] == DBNull.Value ? null : objRow[convSysScoreWeight.Memo].ToString().Trim(); //备注
objvSysScoreWeightEN.ScoreTypeId = objRow[convSysScoreWeight.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreWeightEN.ScoreTypeName = objRow[convSysScoreWeight.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreWeight.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreWeightEN.OnlyId = objRow[convSysScoreWeight.OnlyId] == DBNull.Value ? null : objRow[convSysScoreWeight.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreWeightEN.IdCurrEduCls = objRow[convSysScoreWeight.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreWeight.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreWeightEN.CurrEduClsId = objRow[convSysScoreWeight.CurrEduClsId].ToString().Trim(); //教学班Id
objvSysScoreWeightEN.EduClsName = objRow[convSysScoreWeight.EduClsName] == DBNull.Value ? null : objRow[convSysScoreWeight.EduClsName].ToString().Trim(); //教学班名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreWeightEN.ScoreWeightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreWeightEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysScoreWeightEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysScoreWeight(ref clsvSysScoreWeightEN objvSysScoreWeightEN)
{
bool bolResult = vSysScoreWeightDA.GetvSysScoreWeight(ref objvSysScoreWeightEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strScoreWeightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysScoreWeightEN GetObjByScoreWeightId(string strScoreWeightId)
{
if (strScoreWeightId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strScoreWeightId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strScoreWeightId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strScoreWeightId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSysScoreWeightEN objvSysScoreWeightEN = vSysScoreWeightDA.GetObjByScoreWeightId(strScoreWeightId);
return objvSysScoreWeightEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysScoreWeightEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysScoreWeightEN objvSysScoreWeightEN = vSysScoreWeightDA.GetFirstObj(strWhereCond);
 return objvSysScoreWeightEN;
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
public static clsvSysScoreWeightEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysScoreWeightEN objvSysScoreWeightEN = vSysScoreWeightDA.GetObjByDataRow(objRow);
 return objvSysScoreWeightEN;
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
public static clsvSysScoreWeightEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysScoreWeightEN objvSysScoreWeightEN = vSysScoreWeightDA.GetObjByDataRow(objRow);
 return objvSysScoreWeightEN;
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
 /// <param name = "strScoreWeightId">所给的关键字</param>
 /// <param name = "lstvSysScoreWeightObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysScoreWeightEN GetObjByScoreWeightIdFromList(string strScoreWeightId, List<clsvSysScoreWeightEN> lstvSysScoreWeightObjLst)
{
foreach (clsvSysScoreWeightEN objvSysScoreWeightEN in lstvSysScoreWeightObjLst)
{
if (objvSysScoreWeightEN.ScoreWeightId == strScoreWeightId)
{
return objvSysScoreWeightEN;
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
 string strScoreWeightId;
 try
 {
 strScoreWeightId = new clsvSysScoreWeightDA().GetFirstID(strWhereCond);
 return strScoreWeightId;
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
 arrList = vSysScoreWeightDA.GetID(strWhereCond);
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
bool bolIsExist = vSysScoreWeightDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strScoreWeightId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strScoreWeightId)
{
if (string.IsNullOrEmpty(strScoreWeightId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strScoreWeightId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSysScoreWeightDA.IsExist(strScoreWeightId);
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
 bolIsExist = clsvSysScoreWeightDA.IsExistTable();
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
 bolIsExist = vSysScoreWeightDA.IsExistTable(strTabName);
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
 /// <param name = "objvSysScoreWeightENS">源对象</param>
 /// <param name = "objvSysScoreWeightENT">目标对象</param>
 public static void CopyTo(clsvSysScoreWeightEN objvSysScoreWeightENS, clsvSysScoreWeightEN objvSysScoreWeightENT)
{
try
{
objvSysScoreWeightENT.ScoreWeightId = objvSysScoreWeightENS.ScoreWeightId; //分数权重Id
objvSysScoreWeightENT.ScoreWeightValue = objvSysScoreWeightENS.ScoreWeightValue; //分数权重值
objvSysScoreWeightENT.IsPublic = objvSysScoreWeightENS.IsPublic; //是否公开
objvSysScoreWeightENT.UpdDate = objvSysScoreWeightENS.UpdDate; //修改日期
objvSysScoreWeightENT.UpdUser = objvSysScoreWeightENS.UpdUser; //修改人
objvSysScoreWeightENT.Memo = objvSysScoreWeightENS.Memo; //备注
objvSysScoreWeightENT.ScoreTypeId = objvSysScoreWeightENS.ScoreTypeId; //分数类型Id
objvSysScoreWeightENT.ScoreTypeName = objvSysScoreWeightENS.ScoreTypeName; //分数类型名称
objvSysScoreWeightENT.OnlyId = objvSysScoreWeightENS.OnlyId; //OnlyId
objvSysScoreWeightENT.IdCurrEduCls = objvSysScoreWeightENS.IdCurrEduCls; //教学班流水号
objvSysScoreWeightENT.CurrEduClsId = objvSysScoreWeightENS.CurrEduClsId; //教学班Id
objvSysScoreWeightENT.EduClsName = objvSysScoreWeightENS.EduClsName; //教学班名
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
 /// <param name = "objvSysScoreWeightEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysScoreWeightEN objvSysScoreWeightEN)
{
try
{
objvSysScoreWeightEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSysScoreWeightEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysScoreWeight.ScoreWeightId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.ScoreWeightId = objvSysScoreWeightEN.ScoreWeightId; //分数权重Id
}
if (arrFldSet.Contains(convSysScoreWeight.ScoreWeightValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.ScoreWeightValue = objvSysScoreWeightEN.ScoreWeightValue; //分数权重值
}
if (arrFldSet.Contains(convSysScoreWeight.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.IsPublic = objvSysScoreWeightEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convSysScoreWeight.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.UpdDate = objvSysScoreWeightEN.UpdDate == "[null]" ? null :  objvSysScoreWeightEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSysScoreWeight.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.UpdUser = objvSysScoreWeightEN.UpdUser == "[null]" ? null :  objvSysScoreWeightEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSysScoreWeight.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.Memo = objvSysScoreWeightEN.Memo == "[null]" ? null :  objvSysScoreWeightEN.Memo; //备注
}
if (arrFldSet.Contains(convSysScoreWeight.ScoreTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.ScoreTypeId = objvSysScoreWeightEN.ScoreTypeId == "[null]" ? null :  objvSysScoreWeightEN.ScoreTypeId; //分数类型Id
}
if (arrFldSet.Contains(convSysScoreWeight.ScoreTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.ScoreTypeName = objvSysScoreWeightEN.ScoreTypeName == "[null]" ? null :  objvSysScoreWeightEN.ScoreTypeName; //分数类型名称
}
if (arrFldSet.Contains(convSysScoreWeight.OnlyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.OnlyId = objvSysScoreWeightEN.OnlyId == "[null]" ? null :  objvSysScoreWeightEN.OnlyId; //OnlyId
}
if (arrFldSet.Contains(convSysScoreWeight.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.IdCurrEduCls = objvSysScoreWeightEN.IdCurrEduCls == "[null]" ? null :  objvSysScoreWeightEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convSysScoreWeight.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.CurrEduClsId = objvSysScoreWeightEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convSysScoreWeight.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreWeightEN.EduClsName = objvSysScoreWeightEN.EduClsName == "[null]" ? null :  objvSysScoreWeightEN.EduClsName; //教学班名
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
 /// <param name = "objvSysScoreWeightEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysScoreWeightEN objvSysScoreWeightEN)
{
try
{
if (objvSysScoreWeightEN.UpdDate == "[null]") objvSysScoreWeightEN.UpdDate = null; //修改日期
if (objvSysScoreWeightEN.UpdUser == "[null]") objvSysScoreWeightEN.UpdUser = null; //修改人
if (objvSysScoreWeightEN.Memo == "[null]") objvSysScoreWeightEN.Memo = null; //备注
if (objvSysScoreWeightEN.ScoreTypeId == "[null]") objvSysScoreWeightEN.ScoreTypeId = null; //分数类型Id
if (objvSysScoreWeightEN.ScoreTypeName == "[null]") objvSysScoreWeightEN.ScoreTypeName = null; //分数类型名称
if (objvSysScoreWeightEN.OnlyId == "[null]") objvSysScoreWeightEN.OnlyId = null; //OnlyId
if (objvSysScoreWeightEN.IdCurrEduCls == "[null]") objvSysScoreWeightEN.IdCurrEduCls = null; //教学班流水号
if (objvSysScoreWeightEN.EduClsName == "[null]") objvSysScoreWeightEN.EduClsName = null; //教学班名
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
public static void CheckProperty4Condition(clsvSysScoreWeightEN objvSysScoreWeightEN)
{
 vSysScoreWeightDA.CheckProperty4Condition(objvSysScoreWeightEN);
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
if (clsSysScoreWeightBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysScoreWeightBL没有刷新缓存机制(clsSysScoreWeightBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysScoreTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysScoreTypeBL没有刷新缓存机制(clsSysScoreTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ScoreWeightId");
//if (arrvSysScoreWeightObjLstCache == null)
//{
//arrvSysScoreWeightObjLstCache = vSysScoreWeightDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strScoreWeightId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysScoreWeightEN GetObjByScoreWeightIdCache(string strScoreWeightId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSysScoreWeightEN._CurrTabName);
List<clsvSysScoreWeightEN> arrvSysScoreWeightObjLstCache = GetObjLstCache();
IEnumerable <clsvSysScoreWeightEN> arrvSysScoreWeightObjLst_Sel =
arrvSysScoreWeightObjLstCache
.Where(x=> x.ScoreWeightId == strScoreWeightId 
);
if (arrvSysScoreWeightObjLst_Sel.Count() == 0)
{
   clsvSysScoreWeightEN obj = clsvSysScoreWeightBL.GetObjByScoreWeightId(strScoreWeightId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSysScoreWeightObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysScoreWeightEN> GetAllvSysScoreWeightObjLstCache()
{
//获取缓存中的对象列表
List<clsvSysScoreWeightEN> arrvSysScoreWeightObjLstCache = GetObjLstCache(); 
return arrvSysScoreWeightObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysScoreWeightEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSysScoreWeightEN._CurrTabName);
List<clsvSysScoreWeightEN> arrvSysScoreWeightObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSysScoreWeightObjLstCache;
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
string strKey = string.Format("{0}", clsvSysScoreWeightEN._CurrTabName);
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
 /// 日期:2023-10-08
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strScoreWeightId)
{
if (strInFldName != convSysScoreWeight.ScoreWeightId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysScoreWeight.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysScoreWeight.AttributeName));
throw new Exception(strMsg);
}
var objvSysScoreWeight = clsvSysScoreWeightBL.GetObjByScoreWeightIdCache(strScoreWeightId);
if (objvSysScoreWeight == null) return "";
return objvSysScoreWeight[strOutFldName].ToString();
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
int intRecCount = clsvSysScoreWeightDA.GetRecCount(strTabName);
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
int intRecCount = clsvSysScoreWeightDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysScoreWeightDA.GetRecCount();
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
int intRecCount = clsvSysScoreWeightDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysScoreWeightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysScoreWeightEN objvSysScoreWeightCond)
{
List<clsvSysScoreWeightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysScoreWeightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysScoreWeight.AttributeName)
{
if (objvSysScoreWeightCond.IsUpdated(strFldName) == false) continue;
if (objvSysScoreWeightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreWeightCond[strFldName].ToString());
}
else
{
if (objvSysScoreWeightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysScoreWeightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreWeightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysScoreWeightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysScoreWeightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysScoreWeightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysScoreWeightCond[strFldName]));
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
 List<string> arrList = clsvSysScoreWeightDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSysScoreWeightDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSysScoreWeightDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}