
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorDirectionBL
 表名:vXzMajorDirection(01120553)
 * 版本:2023.10.12.1(服务器:WIN-SRV103-116)
 日期:2023/10/28 09:46:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
public static class  clsvXzMajorDirectionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorDirectionEN GetObj(this K_MajorDirectionId_vXzMajorDirection myKey)
{
clsvXzMajorDirectionEN objvXzMajorDirectionEN = clsvXzMajorDirectionBL.vXzMajorDirectionDA.GetObjByMajorDirectionId(myKey.Value);
return objvXzMajorDirectionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionId(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionId, 8, convXzMajorDirection.MajorDirectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorDirectionId, 8, convXzMajorDirection.MajorDirectionId);
}
objvXzMajorDirectionEN.MajorDirectionId = strMajorDirectionId; //研究方向Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionId) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionId, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionId] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetIdXzMajor(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convXzMajorDirection.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convXzMajorDirection.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convXzMajorDirection.IdXzMajor);
}
objvXzMajorDirectionEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.IdXzMajor) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.IdXzMajor, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.IdXzMajor] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorID(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convXzMajorDirection.MajorID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzMajorDirection.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzMajorDirection.MajorID);
}
objvXzMajorDirectionEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorID) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorID, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorID] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorName(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convXzMajorDirection.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzMajorDirection.MajorName);
}
objvXzMajorDirectionEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorName) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorName, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorName] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionName(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorDirectionName, convXzMajorDirection.MajorDirectionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionName, 100, convXzMajorDirection.MajorDirectionName);
}
objvXzMajorDirectionEN.MajorDirectionName = strMajorDirectionName; //研究方向名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionName) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionName, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionName] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionENName(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionENName, 200, convXzMajorDirection.MajorDirectionENName);
}
objvXzMajorDirectionEN.MajorDirectionENName = strMajorDirectionENName; //研究方向英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionENName) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionENName, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionENName] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionExplain(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionExplain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionExplain, 2000, convXzMajorDirection.MajorDirectionExplain);
}
objvXzMajorDirectionEN.MajorDirectionExplain = strMajorDirectionExplain; //专业方向说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionExplain) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionExplain, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionExplain] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetIsVisible(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, bool bolIsVisible, string strComparisonOp="")
	{
objvXzMajorDirectionEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.IsVisible) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.IsVisible, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.IsVisible] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetUpdDate(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convXzMajorDirection.UpdDate);
}
objvXzMajorDirectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.UpdDate) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.UpdDate, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.UpdDate] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetUpdUser(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convXzMajorDirection.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convXzMajorDirection.UpdUser);
}
objvXzMajorDirectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.UpdUser) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.UpdUser, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.UpdUser] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMemo(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzMajorDirection.Memo);
}
objvXzMajorDirectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.Memo) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.Memo, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.Memo] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzMajorDirectionENS">源对象</param>
 /// <param name = "objvXzMajorDirectionENT">目标对象</param>
 public static void CopyTo(this clsvXzMajorDirectionEN objvXzMajorDirectionENS, clsvXzMajorDirectionEN objvXzMajorDirectionENT)
{
try
{
objvXzMajorDirectionENT.MajorDirectionId = objvXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objvXzMajorDirectionENT.IdXzMajor = objvXzMajorDirectionENS.IdXzMajor; //专业流水号
objvXzMajorDirectionENT.MajorID = objvXzMajorDirectionENS.MajorID; //专业ID
objvXzMajorDirectionENT.MajorName = objvXzMajorDirectionENS.MajorName; //专业名称
objvXzMajorDirectionENT.MajorDirectionName = objvXzMajorDirectionENS.MajorDirectionName; //研究方向名
objvXzMajorDirectionENT.MajorDirectionENName = objvXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objvXzMajorDirectionENT.MajorDirectionExplain = objvXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objvXzMajorDirectionENT.IsVisible = objvXzMajorDirectionENS.IsVisible; //是否显示
objvXzMajorDirectionENT.UpdDate = objvXzMajorDirectionENS.UpdDate; //修改日期
objvXzMajorDirectionENT.UpdUser = objvXzMajorDirectionENS.UpdUser; //修改人
objvXzMajorDirectionENT.Memo = objvXzMajorDirectionENS.Memo; //备注
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
 /// <param name = "objvXzMajorDirectionENS">源对象</param>
 /// <returns>目标对象=>clsvXzMajorDirectionEN:objvXzMajorDirectionENT</returns>
 public static clsvXzMajorDirectionEN CopyTo(this clsvXzMajorDirectionEN objvXzMajorDirectionENS)
{
try
{
 clsvXzMajorDirectionEN objvXzMajorDirectionENT = new clsvXzMajorDirectionEN()
{
MajorDirectionId = objvXzMajorDirectionENS.MajorDirectionId, //研究方向Id
IdXzMajor = objvXzMajorDirectionENS.IdXzMajor, //专业流水号
MajorID = objvXzMajorDirectionENS.MajorID, //专业ID
MajorName = objvXzMajorDirectionENS.MajorName, //专业名称
MajorDirectionName = objvXzMajorDirectionENS.MajorDirectionName, //研究方向名
MajorDirectionENName = objvXzMajorDirectionENS.MajorDirectionENName, //研究方向英文名
MajorDirectionExplain = objvXzMajorDirectionENS.MajorDirectionExplain, //专业方向说明
IsVisible = objvXzMajorDirectionENS.IsVisible, //是否显示
UpdDate = objvXzMajorDirectionENS.UpdDate, //修改日期
UpdUser = objvXzMajorDirectionENS.UpdUser, //修改人
Memo = objvXzMajorDirectionENS.Memo, //备注
};
 return objvXzMajorDirectionENT;
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
public static void CheckProperty4Condition(this clsvXzMajorDirectionEN objvXzMajorDirectionEN)
{
 clsvXzMajorDirectionBL.vXzMajorDirectionDA.CheckProperty4Condition(objvXzMajorDirectionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzMajorDirectionEN objvXzMajorDirectionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.MajorDirectionId) == true)
{
string strComparisonOpMajorDirectionId = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionId, objvXzMajorDirectionCond.MajorDirectionId, strComparisonOpMajorDirectionId);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.IdXzMajor, objvXzMajorDirectionCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.MajorID) == true)
{
string strComparisonOpMajorID = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorID, objvXzMajorDirectionCond.MajorID, strComparisonOpMajorID);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.MajorName) == true)
{
string strComparisonOpMajorName = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorName, objvXzMajorDirectionCond.MajorName, strComparisonOpMajorName);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.MajorDirectionName) == true)
{
string strComparisonOpMajorDirectionName = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionName, objvXzMajorDirectionCond.MajorDirectionName, strComparisonOpMajorDirectionName);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.MajorDirectionENName) == true)
{
string strComparisonOpMajorDirectionENName = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionENName, objvXzMajorDirectionCond.MajorDirectionENName, strComparisonOpMajorDirectionENName);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.MajorDirectionExplain) == true)
{
string strComparisonOpMajorDirectionExplain = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionExplain, objvXzMajorDirectionCond.MajorDirectionExplain, strComparisonOpMajorDirectionExplain);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.IsVisible) == true)
{
if (objvXzMajorDirectionCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajorDirection.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajorDirection.IsVisible);
}
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.UpdDate) == true)
{
string strComparisonOpUpdDate = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.UpdDate, objvXzMajorDirectionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.UpdUser) == true)
{
string strComparisonOpUpdUser = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.UpdUser, objvXzMajorDirectionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvXzMajorDirectionCond.IsUpdated(convXzMajorDirection.Memo) == true)
{
string strComparisonOpMemo = objvXzMajorDirectionCond.dicFldComparisonOp[convXzMajorDirection.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.Memo, objvXzMajorDirectionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzMajorDirection
{
public virtual bool UpdRelaTabDate(string strMajorDirectionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v专业方向(vXzMajorDirection)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzMajorDirectionBL
{
public static RelatedActions_vXzMajorDirection relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzMajorDirectionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzMajorDirectionDA vXzMajorDirectionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzMajorDirectionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzMajorDirectionBL()
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
if (string.IsNullOrEmpty(clsvXzMajorDirectionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzMajorDirectionEN._ConnectString);
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
public static DataTable GetDataTable_vXzMajorDirection(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzMajorDirectionDA.GetDataTable_vXzMajorDirection(strWhereCond);
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
objDT = vXzMajorDirectionDA.GetDataTable(strWhereCond);
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
objDT = vXzMajorDirectionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vXzMajorDirectionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzMajorDirectionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vXzMajorDirectionDA.GetDataTable_Top(objTopPara);
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
objDT = vXzMajorDirectionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vXzMajorDirectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzMajorDirectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMajorDirectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst(List<string> arrMajorDirectionIdLst)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMajorDirectionIdLst, true);
 string strWhereCond = string.Format("MajorDirectionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMajorDirectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzMajorDirectionEN> GetObjLstByMajorDirectionIdLstCache(List<string> arrMajorDirectionIdLst)
{
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName);
List<clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLst_Sel =
arrvXzMajorDirectionObjLstCache
.Where(x => arrMajorDirectionIdLst.Contains(x.MajorDirectionId));
return arrvXzMajorDirectionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetObjLst(string strWhereCond)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
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
public static List<clsvXzMajorDirectionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzMajorDirectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzMajorDirectionEN> GetSubObjLstCache(clsvXzMajorDirectionEN objvXzMajorDirectionCond)
{
List<clsvXzMajorDirectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorDirectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzMajorDirection.AttributeName)
{
if (objvXzMajorDirectionCond.IsUpdated(strFldName) == false) continue;
if (objvXzMajorDirectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorDirectionCond[strFldName].ToString());
}
else
{
if (objvXzMajorDirectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzMajorDirectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorDirectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzMajorDirectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzMajorDirectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzMajorDirectionCond[strFldName]));
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
public static List<clsvXzMajorDirectionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
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
public static List<clsvXzMajorDirectionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
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
List<clsvXzMajorDirectionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzMajorDirectionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzMajorDirectionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
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
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
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
public static List<clsvXzMajorDirectionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzMajorDirectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
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
public static List<clsvXzMajorDirectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzMajorDirectionEN> arrObjLst = new List<clsvXzMajorDirectionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorDirectionEN objvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
try
{
objvXzMajorDirectionEN.MajorDirectionId = objRow[convXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objvXzMajorDirectionEN.IdXzMajor = objRow[convXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorDirectionEN.MajorID = objRow[convXzMajorDirection.MajorID].ToString().Trim(); //专业ID
objvXzMajorDirectionEN.MajorName = objRow[convXzMajorDirection.MajorName].ToString().Trim(); //专业名称
objvXzMajorDirectionEN.MajorDirectionName = objRow[convXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objvXzMajorDirectionEN.MajorDirectionENName = objRow[convXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvXzMajorDirectionEN.MajorDirectionExplain = objRow[convXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[convXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objvXzMajorDirectionEN.UpdDate = objRow[convXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[convXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objvXzMajorDirectionEN.UpdUser = objRow[convXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objvXzMajorDirectionEN.Memo = objRow[convXzMajorDirection.Memo] == DBNull.Value ? null : objRow[convXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorDirectionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzMajorDirection(ref clsvXzMajorDirectionEN objvXzMajorDirectionEN)
{
bool bolResult = vXzMajorDirectionDA.GetvXzMajorDirection(ref objvXzMajorDirectionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorDirectionEN GetObjByMajorDirectionId(string strMajorDirectionId)
{
if (strMajorDirectionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMajorDirectionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMajorDirectionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMajorDirectionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzMajorDirectionEN objvXzMajorDirectionEN = vXzMajorDirectionDA.GetObjByMajorDirectionId(strMajorDirectionId);
return objvXzMajorDirectionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzMajorDirectionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzMajorDirectionEN objvXzMajorDirectionEN = vXzMajorDirectionDA.GetFirstObj(strWhereCond);
 return objvXzMajorDirectionEN;
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
public static clsvXzMajorDirectionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzMajorDirectionEN objvXzMajorDirectionEN = vXzMajorDirectionDA.GetObjByDataRow(objRow);
 return objvXzMajorDirectionEN;
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
public static clsvXzMajorDirectionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzMajorDirectionEN objvXzMajorDirectionEN = vXzMajorDirectionDA.GetObjByDataRow(objRow);
 return objvXzMajorDirectionEN;
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
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <param name = "lstvXzMajorDirectionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorDirectionEN GetObjByMajorDirectionIdFromList(string strMajorDirectionId, List<clsvXzMajorDirectionEN> lstvXzMajorDirectionObjLst)
{
foreach (clsvXzMajorDirectionEN objvXzMajorDirectionEN in lstvXzMajorDirectionObjLst)
{
if (objvXzMajorDirectionEN.MajorDirectionId == strMajorDirectionId)
{
return objvXzMajorDirectionEN;
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
 string strMaxMajorDirectionId;
 try
 {
 strMaxMajorDirectionId = clsvXzMajorDirectionDA.GetMaxStrId();
 return strMaxMajorDirectionId;
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
 string strMajorDirectionId;
 try
 {
 strMajorDirectionId = new clsvXzMajorDirectionDA().GetFirstID(strWhereCond);
 return strMajorDirectionId;
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
 arrList = vXzMajorDirectionDA.GetID(strWhereCond);
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
bool bolIsExist = vXzMajorDirectionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMajorDirectionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzMajorDirectionDA.IsExist(strMajorDirectionId);
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
 bolIsExist = clsvXzMajorDirectionDA.IsExistTable();
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
 bolIsExist = vXzMajorDirectionDA.IsExistTable(strTabName);
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
 /// <param name = "objvXzMajorDirectionENS">源对象</param>
 /// <param name = "objvXzMajorDirectionENT">目标对象</param>
 public static void CopyTo(clsvXzMajorDirectionEN objvXzMajorDirectionENS, clsvXzMajorDirectionEN objvXzMajorDirectionENT)
{
try
{
objvXzMajorDirectionENT.MajorDirectionId = objvXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objvXzMajorDirectionENT.IdXzMajor = objvXzMajorDirectionENS.IdXzMajor; //专业流水号
objvXzMajorDirectionENT.MajorID = objvXzMajorDirectionENS.MajorID; //专业ID
objvXzMajorDirectionENT.MajorName = objvXzMajorDirectionENS.MajorName; //专业名称
objvXzMajorDirectionENT.MajorDirectionName = objvXzMajorDirectionENS.MajorDirectionName; //研究方向名
objvXzMajorDirectionENT.MajorDirectionENName = objvXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objvXzMajorDirectionENT.MajorDirectionExplain = objvXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objvXzMajorDirectionENT.IsVisible = objvXzMajorDirectionENS.IsVisible; //是否显示
objvXzMajorDirectionENT.UpdDate = objvXzMajorDirectionENS.UpdDate; //修改日期
objvXzMajorDirectionENT.UpdUser = objvXzMajorDirectionENS.UpdUser; //修改人
objvXzMajorDirectionENT.Memo = objvXzMajorDirectionENS.Memo; //备注
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
 /// <param name = "objvXzMajorDirectionEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzMajorDirectionEN objvXzMajorDirectionEN)
{
try
{
objvXzMajorDirectionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzMajorDirectionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzMajorDirection.MajorDirectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.MajorDirectionId = objvXzMajorDirectionEN.MajorDirectionId; //研究方向Id
}
if (arrFldSet.Contains(convXzMajorDirection.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.IdXzMajor = objvXzMajorDirectionEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convXzMajorDirection.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.MajorID = objvXzMajorDirectionEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convXzMajorDirection.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.MajorName = objvXzMajorDirectionEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convXzMajorDirection.MajorDirectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.MajorDirectionName = objvXzMajorDirectionEN.MajorDirectionName; //研究方向名
}
if (arrFldSet.Contains(convXzMajorDirection.MajorDirectionENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.MajorDirectionENName = objvXzMajorDirectionEN.MajorDirectionENName == "[null]" ? null :  objvXzMajorDirectionEN.MajorDirectionENName; //研究方向英文名
}
if (arrFldSet.Contains(convXzMajorDirection.MajorDirectionExplain, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.MajorDirectionExplain = objvXzMajorDirectionEN.MajorDirectionExplain == "[null]" ? null :  objvXzMajorDirectionEN.MajorDirectionExplain; //专业方向说明
}
if (arrFldSet.Contains(convXzMajorDirection.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.IsVisible = objvXzMajorDirectionEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convXzMajorDirection.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.UpdDate = objvXzMajorDirectionEN.UpdDate == "[null]" ? null :  objvXzMajorDirectionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convXzMajorDirection.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.UpdUser = objvXzMajorDirectionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convXzMajorDirection.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorDirectionEN.Memo = objvXzMajorDirectionEN.Memo == "[null]" ? null :  objvXzMajorDirectionEN.Memo; //备注
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
 /// <param name = "objvXzMajorDirectionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzMajorDirectionEN objvXzMajorDirectionEN)
{
try
{
if (objvXzMajorDirectionEN.MajorDirectionENName == "[null]") objvXzMajorDirectionEN.MajorDirectionENName = null; //研究方向英文名
if (objvXzMajorDirectionEN.MajorDirectionExplain == "[null]") objvXzMajorDirectionEN.MajorDirectionExplain = null; //专业方向说明
if (objvXzMajorDirectionEN.UpdDate == "[null]") objvXzMajorDirectionEN.UpdDate = null; //修改日期
if (objvXzMajorDirectionEN.Memo == "[null]") objvXzMajorDirectionEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvXzMajorDirectionEN objvXzMajorDirectionEN)
{
 vXzMajorDirectionDA.CheckProperty4Condition(objvXzMajorDirectionEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorDirectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorDirectionBL没有刷新缓存机制(clsXzMajorDirectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MajorDirectionId");
//if (arrvXzMajorDirectionObjLstCache == null)
//{
//arrvXzMajorDirectionObjLstCache = vXzMajorDirectionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorDirectionEN GetObjByMajorDirectionIdCache(string strMajorDirectionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName);
List<clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLst_Sel =
arrvXzMajorDirectionObjLstCache
.Where(x=> x.MajorDirectionId == strMajorDirectionId 
);
if (arrvXzMajorDirectionObjLst_Sel.Count() == 0)
{
   clsvXzMajorDirectionEN obj = clsvXzMajorDirectionBL.GetObjByMajorDirectionId(strMajorDirectionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzMajorDirectionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetAllvXzMajorDirectionObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLstCache = GetObjLstCache(); 
return arrvXzMajorDirectionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName);
List<clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzMajorDirectionObjLstCache;
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
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName);
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
 /// 日期:2023-10-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strMajorDirectionId)
{
if (strInFldName != convXzMajorDirection.MajorDirectionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzMajorDirection.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzMajorDirection.AttributeName));
throw new Exception(strMsg);
}
var objvXzMajorDirection = clsvXzMajorDirectionBL.GetObjByMajorDirectionIdCache(strMajorDirectionId);
if (objvXzMajorDirection == null) return "";
return objvXzMajorDirection[strOutFldName].ToString();
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
int intRecCount = clsvXzMajorDirectionDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzMajorDirectionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzMajorDirectionDA.GetRecCount();
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
int intRecCount = clsvXzMajorDirectionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzMajorDirectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzMajorDirectionEN objvXzMajorDirectionCond)
{
List<clsvXzMajorDirectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorDirectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzMajorDirection.AttributeName)
{
if (objvXzMajorDirectionCond.IsUpdated(strFldName) == false) continue;
if (objvXzMajorDirectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorDirectionCond[strFldName].ToString());
}
else
{
if (objvXzMajorDirectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzMajorDirectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorDirectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzMajorDirectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzMajorDirectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzMajorDirectionCond[strFldName]));
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
 List<string> arrList = clsvXzMajorDirectionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzMajorDirectionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzMajorDirectionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}