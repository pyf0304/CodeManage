
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_UserConfigBL
 表名:vgs_UserConfig(01120691)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:04:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:考试管理(ExamMan)
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
public static class  clsvgs_UserConfigBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngConfigId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_UserConfigEN GetObj(this K_ConfigId_vgs_UserConfig myKey)
{
clsvgs_UserConfigEN objvgs_UserConfigEN = clsvgs_UserConfigBL.vgs_UserConfigDA.GetObjByConfigId(myKey.Value);
return objvgs_UserConfigEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetConfigId(this clsvgs_UserConfigEN objvgs_UserConfigEN, long lngConfigId, string strComparisonOp="")
	{
objvgs_UserConfigEN.ConfigId = lngConfigId; //配置Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.ConfigId) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.ConfigId, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.ConfigId] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetConfigTypeId(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strConfigTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConfigTypeId, convgs_UserConfig.ConfigTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConfigTypeId, 2, convgs_UserConfig.ConfigTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConfigTypeId, 2, convgs_UserConfig.ConfigTypeId);
}
objvgs_UserConfigEN.ConfigTypeId = strConfigTypeId; //配置类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.ConfigTypeId) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.ConfigTypeId, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.ConfigTypeId] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetConfigTypeName(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strConfigTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConfigTypeName, 500, convgs_UserConfig.ConfigTypeName);
}
objvgs_UserConfigEN.ConfigTypeName = strConfigTypeName; //配置类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.ConfigTypeName) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.ConfigTypeName, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.ConfigTypeName] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetShareId(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, convgs_UserConfig.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_UserConfig.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_UserConfig.ShareId);
}
objvgs_UserConfigEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.ShareId) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.ShareId, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.ShareId] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetDataTable(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strDataTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTable, 100, convgs_UserConfig.DataTable);
}
objvgs_UserConfigEN.DataTable = strDataTable; //数据表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.DataTable) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.DataTable, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.DataTable] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetUpdUser(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_UserConfig.UpdUser);
}
objvgs_UserConfigEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.UpdUser) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.UpdUser, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.UpdUser] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetDataTableId(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strDataTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTableId, 50, convgs_UserConfig.DataTableId);
}
objvgs_UserConfigEN.DataTableId = strDataTableId; //数据表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.DataTableId) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.DataTableId, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.DataTableId] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetUpdDate(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_UserConfig.UpdDate);
}
objvgs_UserConfigEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.UpdDate) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.UpdDate, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.UpdDate] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetShareName(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strShareName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareName, 50, convgs_UserConfig.ShareName);
}
objvgs_UserConfigEN.ShareName = strShareName; //分享名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.ShareName) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.ShareName, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.ShareName] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_UserConfigEN SetMemo(this clsvgs_UserConfigEN objvgs_UserConfigEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_UserConfig.Memo);
}
objvgs_UserConfigEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_UserConfigEN.dicFldComparisonOp.ContainsKey(convgs_UserConfig.Memo) == false)
{
objvgs_UserConfigEN.dicFldComparisonOp.Add(convgs_UserConfig.Memo, strComparisonOp);
}
else
{
objvgs_UserConfigEN.dicFldComparisonOp[convgs_UserConfig.Memo] = strComparisonOp;
}
}
return objvgs_UserConfigEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_UserConfigENS">源对象</param>
 /// <param name = "objvgs_UserConfigENT">目标对象</param>
 public static void CopyTo(this clsvgs_UserConfigEN objvgs_UserConfigENS, clsvgs_UserConfigEN objvgs_UserConfigENT)
{
try
{
objvgs_UserConfigENT.ConfigId = objvgs_UserConfigENS.ConfigId; //配置Id
objvgs_UserConfigENT.ConfigTypeId = objvgs_UserConfigENS.ConfigTypeId; //配置类型Id
objvgs_UserConfigENT.ConfigTypeName = objvgs_UserConfigENS.ConfigTypeName; //配置类型名称
objvgs_UserConfigENT.ShareId = objvgs_UserConfigENS.ShareId; //分享Id
objvgs_UserConfigENT.DataTable = objvgs_UserConfigENS.DataTable; //数据表
objvgs_UserConfigENT.UpdUser = objvgs_UserConfigENS.UpdUser; //修改人
objvgs_UserConfigENT.DataTableId = objvgs_UserConfigENS.DataTableId; //数据表Id
objvgs_UserConfigENT.UpdDate = objvgs_UserConfigENS.UpdDate; //修改日期
objvgs_UserConfigENT.ShareName = objvgs_UserConfigENS.ShareName; //分享名称
objvgs_UserConfigENT.Memo = objvgs_UserConfigENS.Memo; //备注
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
 /// <param name = "objvgs_UserConfigENS">源对象</param>
 /// <returns>目标对象=>clsvgs_UserConfigEN:objvgs_UserConfigENT</returns>
 public static clsvgs_UserConfigEN CopyTo(this clsvgs_UserConfigEN objvgs_UserConfigENS)
{
try
{
 clsvgs_UserConfigEN objvgs_UserConfigENT = new clsvgs_UserConfigEN()
{
ConfigId = objvgs_UserConfigENS.ConfigId, //配置Id
ConfigTypeId = objvgs_UserConfigENS.ConfigTypeId, //配置类型Id
ConfigTypeName = objvgs_UserConfigENS.ConfigTypeName, //配置类型名称
ShareId = objvgs_UserConfigENS.ShareId, //分享Id
DataTable = objvgs_UserConfigENS.DataTable, //数据表
UpdUser = objvgs_UserConfigENS.UpdUser, //修改人
DataTableId = objvgs_UserConfigENS.DataTableId, //数据表Id
UpdDate = objvgs_UserConfigENS.UpdDate, //修改日期
ShareName = objvgs_UserConfigENS.ShareName, //分享名称
Memo = objvgs_UserConfigENS.Memo, //备注
};
 return objvgs_UserConfigENT;
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
public static void CheckProperty4Condition(this clsvgs_UserConfigEN objvgs_UserConfigEN)
{
 clsvgs_UserConfigBL.vgs_UserConfigDA.CheckProperty4Condition(objvgs_UserConfigEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_UserConfigEN objvgs_UserConfigCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.ConfigId) == true)
{
string strComparisonOpConfigId = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.ConfigId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_UserConfig.ConfigId, objvgs_UserConfigCond.ConfigId, strComparisonOpConfigId);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.ConfigTypeId) == true)
{
string strComparisonOpConfigTypeId = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.ConfigTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.ConfigTypeId, objvgs_UserConfigCond.ConfigTypeId, strComparisonOpConfigTypeId);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.ConfigTypeName) == true)
{
string strComparisonOpConfigTypeName = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.ConfigTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.ConfigTypeName, objvgs_UserConfigCond.ConfigTypeName, strComparisonOpConfigTypeName);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.ShareId) == true)
{
string strComparisonOpShareId = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.ShareId, objvgs_UserConfigCond.ShareId, strComparisonOpShareId);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.DataTable) == true)
{
string strComparisonOpDataTable = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.DataTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.DataTable, objvgs_UserConfigCond.DataTable, strComparisonOpDataTable);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.UpdUser, objvgs_UserConfigCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.DataTableId) == true)
{
string strComparisonOpDataTableId = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.DataTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.DataTableId, objvgs_UserConfigCond.DataTableId, strComparisonOpDataTableId);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.UpdDate, objvgs_UserConfigCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.ShareName) == true)
{
string strComparisonOpShareName = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.ShareName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.ShareName, objvgs_UserConfigCond.ShareName, strComparisonOpShareName);
}
if (objvgs_UserConfigCond.IsUpdated(convgs_UserConfig.Memo) == true)
{
string strComparisonOpMemo = objvgs_UserConfigCond.dicFldComparisonOp[convgs_UserConfig.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_UserConfig.Memo, objvgs_UserConfigCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_UserConfig
{
public virtual bool UpdRelaTabDate(long lngConfigId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户配置视图(vgs_UserConfig)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_UserConfigBL
{
public static RelatedActions_vgs_UserConfig relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_UserConfigDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_UserConfigDA vgs_UserConfigDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_UserConfigDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_UserConfigBL()
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
if (string.IsNullOrEmpty(clsvgs_UserConfigEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_UserConfigEN._ConnectString);
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
public static DataTable GetDataTable_vgs_UserConfig(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_UserConfigDA.GetDataTable_vgs_UserConfig(strWhereCond);
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
objDT = vgs_UserConfigDA.GetDataTable(strWhereCond);
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
objDT = vgs_UserConfigDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_UserConfigDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_UserConfigDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_UserConfigDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_UserConfigDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_UserConfigDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_UserConfigDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConfigIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_UserConfigEN> GetObjLstByConfigIdLst(List<long> arrConfigIdLst)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConfigIdLst);
 string strWhereCond = string.Format("ConfigId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConfigIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_UserConfigEN> GetObjLstByConfigIdLstCache(List<long> arrConfigIdLst)
{
string strKey = string.Format("{0}", clsvgs_UserConfigEN._CurrTabName);
List<clsvgs_UserConfigEN> arrvgs_UserConfigObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_UserConfigEN> arrvgs_UserConfigObjLst_Sel =
arrvgs_UserConfigObjLstCache
.Where(x => arrConfigIdLst.Contains(x.ConfigId));
return arrvgs_UserConfigObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_UserConfigEN> GetObjLst(string strWhereCond)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
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
public static List<clsvgs_UserConfigEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_UserConfigCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_UserConfigEN> GetSubObjLstCache(clsvgs_UserConfigEN objvgs_UserConfigCond)
{
List<clsvgs_UserConfigEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_UserConfigEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_UserConfig.AttributeName)
{
if (objvgs_UserConfigCond.IsUpdated(strFldName) == false) continue;
if (objvgs_UserConfigCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_UserConfigCond[strFldName].ToString());
}
else
{
if (objvgs_UserConfigCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_UserConfigCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_UserConfigCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_UserConfigCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_UserConfigCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_UserConfigCond[strFldName]));
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
public static List<clsvgs_UserConfigEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
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
public static List<clsvgs_UserConfigEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
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
List<clsvgs_UserConfigEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_UserConfigEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_UserConfigEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_UserConfigEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
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
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
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
public static List<clsvgs_UserConfigEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_UserConfigEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_UserConfigEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
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
public static List<clsvgs_UserConfigEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_UserConfigEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_UserConfigEN> arrObjLst = new List<clsvgs_UserConfigEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_UserConfigEN objvgs_UserConfigEN = new clsvgs_UserConfigEN();
try
{
objvgs_UserConfigEN.ConfigId = Int32.Parse(objRow[convgs_UserConfig.ConfigId].ToString().Trim()); //配置Id
objvgs_UserConfigEN.ConfigTypeId = objRow[convgs_UserConfig.ConfigTypeId].ToString().Trim(); //配置类型Id
objvgs_UserConfigEN.ConfigTypeName = objRow[convgs_UserConfig.ConfigTypeName] == DBNull.Value ? null : objRow[convgs_UserConfig.ConfigTypeName].ToString().Trim(); //配置类型名称
objvgs_UserConfigEN.ShareId = objRow[convgs_UserConfig.ShareId].ToString().Trim(); //分享Id
objvgs_UserConfigEN.DataTable = objRow[convgs_UserConfig.DataTable] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTable].ToString().Trim(); //数据表
objvgs_UserConfigEN.UpdUser = objRow[convgs_UserConfig.UpdUser] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdUser].ToString().Trim(); //修改人
objvgs_UserConfigEN.DataTableId = objRow[convgs_UserConfig.DataTableId] == DBNull.Value ? null : objRow[convgs_UserConfig.DataTableId].ToString().Trim(); //数据表Id
objvgs_UserConfigEN.UpdDate = objRow[convgs_UserConfig.UpdDate] == DBNull.Value ? null : objRow[convgs_UserConfig.UpdDate].ToString().Trim(); //修改日期
objvgs_UserConfigEN.ShareName = objRow[convgs_UserConfig.ShareName] == DBNull.Value ? null : objRow[convgs_UserConfig.ShareName].ToString().Trim(); //分享名称
objvgs_UserConfigEN.Memo = objRow[convgs_UserConfig.Memo] == DBNull.Value ? null : objRow[convgs_UserConfig.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_UserConfigEN.ConfigId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_UserConfigEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_UserConfigEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_UserConfig(ref clsvgs_UserConfigEN objvgs_UserConfigEN)
{
bool bolResult = vgs_UserConfigDA.Getvgs_UserConfig(ref objvgs_UserConfigEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngConfigId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_UserConfigEN GetObjByConfigId(long lngConfigId)
{
clsvgs_UserConfigEN objvgs_UserConfigEN = vgs_UserConfigDA.GetObjByConfigId(lngConfigId);
return objvgs_UserConfigEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_UserConfigEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_UserConfigEN objvgs_UserConfigEN = vgs_UserConfigDA.GetFirstObj(strWhereCond);
 return objvgs_UserConfigEN;
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
public static clsvgs_UserConfigEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_UserConfigEN objvgs_UserConfigEN = vgs_UserConfigDA.GetObjByDataRow(objRow);
 return objvgs_UserConfigEN;
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
public static clsvgs_UserConfigEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_UserConfigEN objvgs_UserConfigEN = vgs_UserConfigDA.GetObjByDataRow(objRow);
 return objvgs_UserConfigEN;
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
 /// <param name = "lngConfigId">所给的关键字</param>
 /// <param name = "lstvgs_UserConfigObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_UserConfigEN GetObjByConfigIdFromList(long lngConfigId, List<clsvgs_UserConfigEN> lstvgs_UserConfigObjLst)
{
foreach (clsvgs_UserConfigEN objvgs_UserConfigEN in lstvgs_UserConfigObjLst)
{
if (objvgs_UserConfigEN.ConfigId == lngConfigId)
{
return objvgs_UserConfigEN;
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
 long lngConfigId;
 try
 {
 lngConfigId = new clsvgs_UserConfigDA().GetFirstID(strWhereCond);
 return lngConfigId;
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
 arrList = vgs_UserConfigDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_UserConfigDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngConfigId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngConfigId)
{
//检测记录是否存在
bool bolIsExist = vgs_UserConfigDA.IsExist(lngConfigId);
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
 bolIsExist = clsvgs_UserConfigDA.IsExistTable();
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
 bolIsExist = vgs_UserConfigDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_UserConfigENS">源对象</param>
 /// <param name = "objvgs_UserConfigENT">目标对象</param>
 public static void CopyTo(clsvgs_UserConfigEN objvgs_UserConfigENS, clsvgs_UserConfigEN objvgs_UserConfigENT)
{
try
{
objvgs_UserConfigENT.ConfigId = objvgs_UserConfigENS.ConfigId; //配置Id
objvgs_UserConfigENT.ConfigTypeId = objvgs_UserConfigENS.ConfigTypeId; //配置类型Id
objvgs_UserConfigENT.ConfigTypeName = objvgs_UserConfigENS.ConfigTypeName; //配置类型名称
objvgs_UserConfigENT.ShareId = objvgs_UserConfigENS.ShareId; //分享Id
objvgs_UserConfigENT.DataTable = objvgs_UserConfigENS.DataTable; //数据表
objvgs_UserConfigENT.UpdUser = objvgs_UserConfigENS.UpdUser; //修改人
objvgs_UserConfigENT.DataTableId = objvgs_UserConfigENS.DataTableId; //数据表Id
objvgs_UserConfigENT.UpdDate = objvgs_UserConfigENS.UpdDate; //修改日期
objvgs_UserConfigENT.ShareName = objvgs_UserConfigENS.ShareName; //分享名称
objvgs_UserConfigENT.Memo = objvgs_UserConfigENS.Memo; //备注
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
 /// <param name = "objvgs_UserConfigEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_UserConfigEN objvgs_UserConfigEN)
{
try
{
objvgs_UserConfigEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_UserConfigEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_UserConfig.ConfigId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.ConfigId = objvgs_UserConfigEN.ConfigId; //配置Id
}
if (arrFldSet.Contains(convgs_UserConfig.ConfigTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.ConfigTypeId = objvgs_UserConfigEN.ConfigTypeId; //配置类型Id
}
if (arrFldSet.Contains(convgs_UserConfig.ConfigTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.ConfigTypeName = objvgs_UserConfigEN.ConfigTypeName == "[null]" ? null :  objvgs_UserConfigEN.ConfigTypeName; //配置类型名称
}
if (arrFldSet.Contains(convgs_UserConfig.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.ShareId = objvgs_UserConfigEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convgs_UserConfig.DataTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.DataTable = objvgs_UserConfigEN.DataTable == "[null]" ? null :  objvgs_UserConfigEN.DataTable; //数据表
}
if (arrFldSet.Contains(convgs_UserConfig.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.UpdUser = objvgs_UserConfigEN.UpdUser == "[null]" ? null :  objvgs_UserConfigEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_UserConfig.DataTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.DataTableId = objvgs_UserConfigEN.DataTableId == "[null]" ? null :  objvgs_UserConfigEN.DataTableId; //数据表Id
}
if (arrFldSet.Contains(convgs_UserConfig.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.UpdDate = objvgs_UserConfigEN.UpdDate == "[null]" ? null :  objvgs_UserConfigEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_UserConfig.ShareName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.ShareName = objvgs_UserConfigEN.ShareName == "[null]" ? null :  objvgs_UserConfigEN.ShareName; //分享名称
}
if (arrFldSet.Contains(convgs_UserConfig.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_UserConfigEN.Memo = objvgs_UserConfigEN.Memo == "[null]" ? null :  objvgs_UserConfigEN.Memo; //备注
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
 /// <param name = "objvgs_UserConfigEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_UserConfigEN objvgs_UserConfigEN)
{
try
{
if (objvgs_UserConfigEN.ConfigTypeName == "[null]") objvgs_UserConfigEN.ConfigTypeName = null; //配置类型名称
if (objvgs_UserConfigEN.DataTable == "[null]") objvgs_UserConfigEN.DataTable = null; //数据表
if (objvgs_UserConfigEN.UpdUser == "[null]") objvgs_UserConfigEN.UpdUser = null; //修改人
if (objvgs_UserConfigEN.DataTableId == "[null]") objvgs_UserConfigEN.DataTableId = null; //数据表Id
if (objvgs_UserConfigEN.UpdDate == "[null]") objvgs_UserConfigEN.UpdDate = null; //修改日期
if (objvgs_UserConfigEN.ShareName == "[null]") objvgs_UserConfigEN.ShareName = null; //分享名称
if (objvgs_UserConfigEN.Memo == "[null]") objvgs_UserConfigEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvgs_UserConfigEN objvgs_UserConfigEN)
{
 vgs_UserConfigDA.CheckProperty4Condition(objvgs_UserConfigEN);
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
if (clsgs_ConfigTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ConfigTypeBL没有刷新缓存机制(clsgs_ConfigTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_UserConfigBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_UserConfigBL没有刷新缓存机制(clsgs_UserConfigBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_ShareBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ShareBL没有刷新缓存机制(clsgs_ShareBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConfigId");
//if (arrvgs_UserConfigObjLstCache == null)
//{
//arrvgs_UserConfigObjLstCache = vgs_UserConfigDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngConfigId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_UserConfigEN GetObjByConfigIdCache(long lngConfigId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_UserConfigEN._CurrTabName);
List<clsvgs_UserConfigEN> arrvgs_UserConfigObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_UserConfigEN> arrvgs_UserConfigObjLst_Sel =
arrvgs_UserConfigObjLstCache
.Where(x=> x.ConfigId == lngConfigId 
);
if (arrvgs_UserConfigObjLst_Sel.Count() == 0)
{
   clsvgs_UserConfigEN obj = clsvgs_UserConfigBL.GetObjByConfigId(lngConfigId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_UserConfigObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_UserConfigEN> GetAllvgs_UserConfigObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_UserConfigEN> arrvgs_UserConfigObjLstCache = GetObjLstCache(); 
return arrvgs_UserConfigObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_UserConfigEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_UserConfigEN._CurrTabName);
List<clsvgs_UserConfigEN> arrvgs_UserConfigObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_UserConfigObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_UserConfigEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngConfigId)
{
if (strInFldName != convgs_UserConfig.ConfigId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_UserConfig.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_UserConfig.AttributeName));
throw new Exception(strMsg);
}
var objvgs_UserConfig = clsvgs_UserConfigBL.GetObjByConfigIdCache(lngConfigId);
if (objvgs_UserConfig == null) return "";
return objvgs_UserConfig[strOutFldName].ToString();
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
int intRecCount = clsvgs_UserConfigDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_UserConfigDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_UserConfigDA.GetRecCount();
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
int intRecCount = clsvgs_UserConfigDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_UserConfigCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_UserConfigEN objvgs_UserConfigCond)
{
List<clsvgs_UserConfigEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_UserConfigEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_UserConfig.AttributeName)
{
if (objvgs_UserConfigCond.IsUpdated(strFldName) == false) continue;
if (objvgs_UserConfigCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_UserConfigCond[strFldName].ToString());
}
else
{
if (objvgs_UserConfigCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_UserConfigCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_UserConfigCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_UserConfigCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_UserConfigCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_UserConfigCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_UserConfigCond[strFldName]));
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
 List<string> arrList = clsvgs_UserConfigDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_UserConfigDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_UserConfigDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}