
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvModuleTabRelaBL
 表名:vModuleTabRela(01120364)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:06
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
public static class  clsvModuleTabRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleTabRelaEN GetObj(this K_FuncModuleId_vModuleTabRela myKey)
{
clsvModuleTabRelaEN objvModuleTabRelaEN = clsvModuleTabRelaBL.vModuleTabRelaDA.GetObjByFuncModuleId(myKey.Value);
return objvModuleTabRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetFuncModuleId(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convModuleTabRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convModuleTabRela.FuncModuleId);
}
objvModuleTabRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.FuncModuleId) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.FuncModuleId, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.FuncModuleId] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetFuncModuleName(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convModuleTabRela.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convModuleTabRela.FuncModuleName);
}
objvModuleTabRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.FuncModuleName) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.FuncModuleName, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.FuncModuleName] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetFuncModuleNameSim(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convModuleTabRela.FuncModuleNameSim);
}
objvModuleTabRelaEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.FuncModuleNameSim) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.FuncModuleNameSim, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.FuncModuleNameSim] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetOrderNum(this clsvModuleTabRelaEN objvModuleTabRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvModuleTabRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.OrderNum) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.OrderNum, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.OrderNum] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetCollegeTab(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strCollegeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeTab, 50, convModuleTabRela.CollegeTab);
}
objvModuleTabRelaEN.CollegeTab = strCollegeTab; //学院表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.CollegeTab) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.CollegeTab, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.CollegeTab] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetMajorTab(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strMajorTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorTab, 50, convModuleTabRela.MajorTab);
}
objvModuleTabRelaEN.MajorTab = strMajorTab; //专业表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.MajorTab) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.MajorTab, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.MajorTab] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetUpdDate(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convModuleTabRela.UpdDate);
}
objvModuleTabRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.UpdDate) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.UpdDate, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.UpdDate] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetUpdUserId(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convModuleTabRela.UpdUserId);
}
objvModuleTabRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.UpdUserId) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.UpdUserId, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.UpdUserId] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleTabRelaEN SetMemo(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convModuleTabRela.Memo);
}
objvModuleTabRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.Memo) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.Memo, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.Memo] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvModuleTabRelaENS">源对象</param>
 /// <param name = "objvModuleTabRelaENT">目标对象</param>
 public static void CopyTo(this clsvModuleTabRelaEN objvModuleTabRelaENS, clsvModuleTabRelaEN objvModuleTabRelaENT)
{
try
{
objvModuleTabRelaENT.FuncModuleId = objvModuleTabRelaENS.FuncModuleId; //功能模块Id
objvModuleTabRelaENT.FuncModuleName = objvModuleTabRelaENS.FuncModuleName; //功能模块名称
objvModuleTabRelaENT.FuncModuleNameSim = objvModuleTabRelaENS.FuncModuleNameSim; //功能模块简称
objvModuleTabRelaENT.OrderNum = objvModuleTabRelaENS.OrderNum; //序号
objvModuleTabRelaENT.CollegeTab = objvModuleTabRelaENS.CollegeTab; //学院表
objvModuleTabRelaENT.MajorTab = objvModuleTabRelaENS.MajorTab; //专业表
objvModuleTabRelaENT.UpdDate = objvModuleTabRelaENS.UpdDate; //修改日期
objvModuleTabRelaENT.UpdUserId = objvModuleTabRelaENS.UpdUserId; //修改用户Id
objvModuleTabRelaENT.Memo = objvModuleTabRelaENS.Memo; //备注
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
 /// <param name = "objvModuleTabRelaENS">源对象</param>
 /// <returns>目标对象=>clsvModuleTabRelaEN:objvModuleTabRelaENT</returns>
 public static clsvModuleTabRelaEN CopyTo(this clsvModuleTabRelaEN objvModuleTabRelaENS)
{
try
{
 clsvModuleTabRelaEN objvModuleTabRelaENT = new clsvModuleTabRelaEN()
{
FuncModuleId = objvModuleTabRelaENS.FuncModuleId, //功能模块Id
FuncModuleName = objvModuleTabRelaENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvModuleTabRelaENS.FuncModuleNameSim, //功能模块简称
OrderNum = objvModuleTabRelaENS.OrderNum, //序号
CollegeTab = objvModuleTabRelaENS.CollegeTab, //学院表
MajorTab = objvModuleTabRelaENS.MajorTab, //专业表
UpdDate = objvModuleTabRelaENS.UpdDate, //修改日期
UpdUserId = objvModuleTabRelaENS.UpdUserId, //修改用户Id
Memo = objvModuleTabRelaENS.Memo, //备注
};
 return objvModuleTabRelaENT;
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
public static void CheckProperty4Condition(this clsvModuleTabRelaEN objvModuleTabRelaEN)
{
 clsvModuleTabRelaBL.vModuleTabRelaDA.CheckProperty4Condition(objvModuleTabRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvModuleTabRelaEN objvModuleTabRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.FuncModuleId, objvModuleTabRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.FuncModuleName, objvModuleTabRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.FuncModuleNameSim, objvModuleTabRelaCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleTabRela.OrderNum, objvModuleTabRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.CollegeTab) == true)
{
string strComparisonOpCollegeTab = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.CollegeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.CollegeTab, objvModuleTabRelaCond.CollegeTab, strComparisonOpCollegeTab);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.MajorTab) == true)
{
string strComparisonOpMajorTab = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.MajorTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.MajorTab, objvModuleTabRelaCond.MajorTab, strComparisonOpMajorTab);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.UpdDate, objvModuleTabRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.UpdUserId, objvModuleTabRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvModuleTabRelaCond.IsUpdated(convModuleTabRela.Memo) == true)
{
string strComparisonOpMemo = objvModuleTabRelaCond.dicFldComparisonOp[convModuleTabRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.Memo, objvModuleTabRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vModuleTabRela
{
public virtual bool UpdRelaTabDate(string strFuncModuleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v模块表关系(vModuleTabRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvModuleTabRelaBL
{
public static RelatedActions_vModuleTabRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvModuleTabRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvModuleTabRelaDA vModuleTabRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvModuleTabRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvModuleTabRelaBL()
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
if (string.IsNullOrEmpty(clsvModuleTabRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvModuleTabRelaEN._ConnectString);
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
public static DataTable GetDataTable_vModuleTabRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vModuleTabRelaDA.GetDataTable_vModuleTabRela(strWhereCond);
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
objDT = vModuleTabRelaDA.GetDataTable(strWhereCond);
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
objDT = vModuleTabRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vModuleTabRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vModuleTabRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vModuleTabRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vModuleTabRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vModuleTabRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vModuleTabRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvModuleTabRelaEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleIdLst)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleIdLst, true);
 string strWhereCond = string.Format("FuncModuleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvModuleTabRelaEN> GetObjLstByFuncModuleIdLstCache(List<string> arrFuncModuleIdLst)
{
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName);
List<clsvModuleTabRelaEN> arrvModuleTabRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleTabRelaEN> arrvModuleTabRelaObjLst_Sel =
arrvModuleTabRelaObjLstCache
.Where(x => arrFuncModuleIdLst.Contains(x.FuncModuleId));
return arrvModuleTabRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleTabRelaEN> GetObjLst(string strWhereCond)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
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
public static List<clsvModuleTabRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvModuleTabRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvModuleTabRelaEN> GetSubObjLstCache(clsvModuleTabRelaEN objvModuleTabRelaCond)
{
List<clsvModuleTabRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleTabRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convModuleTabRela.AttributeName)
{
if (objvModuleTabRelaCond.IsUpdated(strFldName) == false) continue;
if (objvModuleTabRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleTabRelaCond[strFldName].ToString());
}
else
{
if (objvModuleTabRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvModuleTabRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleTabRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvModuleTabRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvModuleTabRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvModuleTabRelaCond[strFldName]));
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
public static List<clsvModuleTabRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
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
public static List<clsvModuleTabRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
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
List<clsvModuleTabRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvModuleTabRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleTabRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvModuleTabRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
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
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
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
public static List<clsvModuleTabRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvModuleTabRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvModuleTabRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
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
public static List<clsvModuleTabRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleTabRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvModuleTabRelaEN> arrObjLst = new List<clsvModuleTabRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleTabRelaEN objvModuleTabRelaEN = new clsvModuleTabRelaEN();
try
{
objvModuleTabRelaEN.FuncModuleId = objRow[convModuleTabRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleTabRelaEN.FuncModuleName = objRow[convModuleTabRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleTabRelaEN.FuncModuleNameSim = objRow[convModuleTabRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convModuleTabRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvModuleTabRelaEN.OrderNum = objRow[convModuleTabRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleTabRela.OrderNum].ToString().Trim()); //序号
objvModuleTabRelaEN.CollegeTab = objRow[convModuleTabRela.CollegeTab] == DBNull.Value ? null : objRow[convModuleTabRela.CollegeTab].ToString().Trim(); //学院表
objvModuleTabRelaEN.MajorTab = objRow[convModuleTabRela.MajorTab] == DBNull.Value ? null : objRow[convModuleTabRela.MajorTab].ToString().Trim(); //专业表
objvModuleTabRelaEN.UpdDate = objRow[convModuleTabRela.UpdDate] == DBNull.Value ? null : objRow[convModuleTabRela.UpdDate].ToString().Trim(); //修改日期
objvModuleTabRelaEN.UpdUserId = objRow[convModuleTabRela.UpdUserId] == DBNull.Value ? null : objRow[convModuleTabRela.UpdUserId].ToString().Trim(); //修改用户Id
objvModuleTabRelaEN.Memo = objRow[convModuleTabRela.Memo] == DBNull.Value ? null : objRow[convModuleTabRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleTabRelaEN.FuncModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleTabRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvModuleTabRela(ref clsvModuleTabRelaEN objvModuleTabRelaEN)
{
bool bolResult = vModuleTabRelaDA.GetvModuleTabRela(ref objvModuleTabRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleTabRelaEN GetObjByFuncModuleId(string strFuncModuleId)
{
if (strFuncModuleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvModuleTabRelaEN objvModuleTabRelaEN = vModuleTabRelaDA.GetObjByFuncModuleId(strFuncModuleId);
return objvModuleTabRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvModuleTabRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvModuleTabRelaEN objvModuleTabRelaEN = vModuleTabRelaDA.GetFirstObj(strWhereCond);
 return objvModuleTabRelaEN;
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
public static clsvModuleTabRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvModuleTabRelaEN objvModuleTabRelaEN = vModuleTabRelaDA.GetObjByDataRow(objRow);
 return objvModuleTabRelaEN;
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
public static clsvModuleTabRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvModuleTabRelaEN objvModuleTabRelaEN = vModuleTabRelaDA.GetObjByDataRow(objRow);
 return objvModuleTabRelaEN;
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
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <param name = "lstvModuleTabRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvModuleTabRelaEN GetObjByFuncModuleIdFromList(string strFuncModuleId, List<clsvModuleTabRelaEN> lstvModuleTabRelaObjLst)
{
foreach (clsvModuleTabRelaEN objvModuleTabRelaEN in lstvModuleTabRelaObjLst)
{
if (objvModuleTabRelaEN.FuncModuleId == strFuncModuleId)
{
return objvModuleTabRelaEN;
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
 string strFuncModuleId;
 try
 {
 strFuncModuleId = new clsvModuleTabRelaDA().GetFirstID(strWhereCond);
 return strFuncModuleId;
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
 arrList = vModuleTabRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vModuleTabRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vModuleTabRelaDA.IsExist(strFuncModuleId);
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
 bolIsExist = clsvModuleTabRelaDA.IsExistTable();
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
 bolIsExist = vModuleTabRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvModuleTabRelaENS">源对象</param>
 /// <param name = "objvModuleTabRelaENT">目标对象</param>
 public static void CopyTo(clsvModuleTabRelaEN objvModuleTabRelaENS, clsvModuleTabRelaEN objvModuleTabRelaENT)
{
try
{
objvModuleTabRelaENT.FuncModuleId = objvModuleTabRelaENS.FuncModuleId; //功能模块Id
objvModuleTabRelaENT.FuncModuleName = objvModuleTabRelaENS.FuncModuleName; //功能模块名称
objvModuleTabRelaENT.FuncModuleNameSim = objvModuleTabRelaENS.FuncModuleNameSim; //功能模块简称
objvModuleTabRelaENT.OrderNum = objvModuleTabRelaENS.OrderNum; //序号
objvModuleTabRelaENT.CollegeTab = objvModuleTabRelaENS.CollegeTab; //学院表
objvModuleTabRelaENT.MajorTab = objvModuleTabRelaENS.MajorTab; //专业表
objvModuleTabRelaENT.UpdDate = objvModuleTabRelaENS.UpdDate; //修改日期
objvModuleTabRelaENT.UpdUserId = objvModuleTabRelaENS.UpdUserId; //修改用户Id
objvModuleTabRelaENT.Memo = objvModuleTabRelaENS.Memo; //备注
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
 /// <param name = "objvModuleTabRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvModuleTabRelaEN objvModuleTabRelaEN)
{
try
{
objvModuleTabRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvModuleTabRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convModuleTabRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.FuncModuleId = objvModuleTabRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convModuleTabRela.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.FuncModuleName = objvModuleTabRelaEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convModuleTabRela.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.FuncModuleNameSim = objvModuleTabRelaEN.FuncModuleNameSim == "[null]" ? null :  objvModuleTabRelaEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convModuleTabRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.OrderNum = objvModuleTabRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convModuleTabRela.CollegeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.CollegeTab = objvModuleTabRelaEN.CollegeTab == "[null]" ? null :  objvModuleTabRelaEN.CollegeTab; //学院表
}
if (arrFldSet.Contains(convModuleTabRela.MajorTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.MajorTab = objvModuleTabRelaEN.MajorTab == "[null]" ? null :  objvModuleTabRelaEN.MajorTab; //专业表
}
if (arrFldSet.Contains(convModuleTabRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.UpdDate = objvModuleTabRelaEN.UpdDate == "[null]" ? null :  objvModuleTabRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convModuleTabRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.UpdUserId = objvModuleTabRelaEN.UpdUserId == "[null]" ? null :  objvModuleTabRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convModuleTabRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleTabRelaEN.Memo = objvModuleTabRelaEN.Memo == "[null]" ? null :  objvModuleTabRelaEN.Memo; //备注
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
 /// <param name = "objvModuleTabRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvModuleTabRelaEN objvModuleTabRelaEN)
{
try
{
if (objvModuleTabRelaEN.FuncModuleNameSim == "[null]") objvModuleTabRelaEN.FuncModuleNameSim = null; //功能模块简称
if (objvModuleTabRelaEN.CollegeTab == "[null]") objvModuleTabRelaEN.CollegeTab = null; //学院表
if (objvModuleTabRelaEN.MajorTab == "[null]") objvModuleTabRelaEN.MajorTab = null; //专业表
if (objvModuleTabRelaEN.UpdDate == "[null]") objvModuleTabRelaEN.UpdDate = null; //修改日期
if (objvModuleTabRelaEN.UpdUserId == "[null]") objvModuleTabRelaEN.UpdUserId = null; //修改用户Id
if (objvModuleTabRelaEN.Memo == "[null]") objvModuleTabRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvModuleTabRelaEN objvModuleTabRelaEN)
{
 vModuleTabRelaDA.CheckProperty4Condition(objvModuleTabRelaEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsModuleTabRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsModuleTabRelaBL没有刷新缓存机制(clsModuleTabRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleId");
//if (arrvModuleTabRelaObjLstCache == null)
//{
//arrvModuleTabRelaObjLstCache = vModuleTabRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvModuleTabRelaEN GetObjByFuncModuleIdCache(string strFuncModuleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName);
List<clsvModuleTabRelaEN> arrvModuleTabRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleTabRelaEN> arrvModuleTabRelaObjLst_Sel =
arrvModuleTabRelaObjLstCache
.Where(x=> x.FuncModuleId == strFuncModuleId 
);
if (arrvModuleTabRelaObjLst_Sel.Count() == 0)
{
   clsvModuleTabRelaEN obj = clsvModuleTabRelaBL.GetObjByFuncModuleId(strFuncModuleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvModuleTabRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvModuleTabRelaEN> GetAllvModuleTabRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvModuleTabRelaEN> arrvModuleTabRelaObjLstCache = GetObjLstCache(); 
return arrvModuleTabRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvModuleTabRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName);
List<clsvModuleTabRelaEN> arrvModuleTabRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvModuleTabRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleId)
{
if (strInFldName != convModuleTabRela.FuncModuleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convModuleTabRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convModuleTabRela.AttributeName));
throw new Exception(strMsg);
}
var objvModuleTabRela = clsvModuleTabRelaBL.GetObjByFuncModuleIdCache(strFuncModuleId);
if (objvModuleTabRela == null) return "";
return objvModuleTabRela[strOutFldName].ToString();
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
int intRecCount = clsvModuleTabRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvModuleTabRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvModuleTabRelaDA.GetRecCount();
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
int intRecCount = clsvModuleTabRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvModuleTabRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvModuleTabRelaEN objvModuleTabRelaCond)
{
List<clsvModuleTabRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleTabRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convModuleTabRela.AttributeName)
{
if (objvModuleTabRelaCond.IsUpdated(strFldName) == false) continue;
if (objvModuleTabRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleTabRelaCond[strFldName].ToString());
}
else
{
if (objvModuleTabRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvModuleTabRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleTabRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvModuleTabRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvModuleTabRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvModuleTabRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvModuleTabRelaCond[strFldName]));
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
 List<string> arrList = clsvModuleTabRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vModuleTabRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vModuleTabRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}