﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabKeyFldBL
 表名:vPrjTabKeyFld(00050286)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:03:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvPrjTabKeyFldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabKeyFldEN GetObj(this K_TabId_vPrjTabKeyFld myKey)
{
clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = clsvPrjTabKeyFldBL.vPrjTabKeyFldDA.GetObjByTabId(myKey.Value);
return objvPrjTabKeyFldEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetTabId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabKeyFld.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabKeyFld.TabId);
}
objvPrjTabKeyFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.TabId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.TabId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.TabId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetFldId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabKeyFld.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabKeyFld.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabKeyFld.FldId);
}
objvPrjTabKeyFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.FldId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.FldId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.FldId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetFieldTypeId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, convPrjTabKeyFld.FieldTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabKeyFld.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabKeyFld.FieldTypeId);
}
objvPrjTabKeyFldEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.FieldTypeId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.FieldTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.FieldTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetPrimaryTypeId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, convPrjTabKeyFld.PrimaryTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convPrjTabKeyFld.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convPrjTabKeyFld.PrimaryTypeId);
}
objvPrjTabKeyFldEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.PrimaryTypeId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.PrimaryTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetPrimaryTypeName(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strPrimaryTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convPrjTabKeyFld.PrimaryTypeName);
}
objvPrjTabKeyFldEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.PrimaryTypeName) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.PrimaryTypeName, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeName] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetKeyFldName(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strKeyFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldName, 300, convPrjTabKeyFld.KeyFldName);
}
objvPrjTabKeyFldEN.KeyFldName = strKeyFldName; //关键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.KeyFldName) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.KeyFldName, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.KeyFldName] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetPrjId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTabKeyFld.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTabKeyFld.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTabKeyFld.PrjId);
}
objvPrjTabKeyFldEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.PrjId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.PrjId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.PrjId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldENS">源对象</param>
 /// <param name = "objvPrjTabKeyFldENT">目标对象</param>
 public static void CopyTo(this clsvPrjTabKeyFldEN objvPrjTabKeyFldENS, clsvPrjTabKeyFldEN objvPrjTabKeyFldENT)
{
try
{
objvPrjTabKeyFldENT.TabId = objvPrjTabKeyFldENS.TabId; //表ID
objvPrjTabKeyFldENT.FldId = objvPrjTabKeyFldENS.FldId; //字段Id
objvPrjTabKeyFldENT.FieldTypeId = objvPrjTabKeyFldENS.FieldTypeId; //字段类型Id
objvPrjTabKeyFldENT.PrimaryTypeId = objvPrjTabKeyFldENS.PrimaryTypeId; //主键类型ID
objvPrjTabKeyFldENT.PrimaryTypeName = objvPrjTabKeyFldENS.PrimaryTypeName; //主键类型名
objvPrjTabKeyFldENT.KeyFldName = objvPrjTabKeyFldENS.KeyFldName; //关键字段名
objvPrjTabKeyFldENT.PrjId = objvPrjTabKeyFldENS.PrjId; //工程ID
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
 /// <param name = "objvPrjTabKeyFldENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTabKeyFldEN:objvPrjTabKeyFldENT</returns>
 public static clsvPrjTabKeyFldEN CopyTo(this clsvPrjTabKeyFldEN objvPrjTabKeyFldENS)
{
try
{
 clsvPrjTabKeyFldEN objvPrjTabKeyFldENT = new clsvPrjTabKeyFldEN()
{
TabId = objvPrjTabKeyFldENS.TabId, //表ID
FldId = objvPrjTabKeyFldENS.FldId, //字段Id
FieldTypeId = objvPrjTabKeyFldENS.FieldTypeId, //字段类型Id
PrimaryTypeId = objvPrjTabKeyFldENS.PrimaryTypeId, //主键类型ID
PrimaryTypeName = objvPrjTabKeyFldENS.PrimaryTypeName, //主键类型名
KeyFldName = objvPrjTabKeyFldENS.KeyFldName, //关键字段名
PrjId = objvPrjTabKeyFldENS.PrjId, //工程ID
};
 return objvPrjTabKeyFldENT;
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
public static void CheckProperty4Condition(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN)
{
 clsvPrjTabKeyFldBL.vPrjTabKeyFldDA.CheckProperty4Condition(objvPrjTabKeyFldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabKeyFldEN objvPrjTabKeyFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.TabId, objvPrjTabKeyFldCond.TabId, strComparisonOpTabId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.FldId) == true)
{
string strComparisonOpFldId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.FldId, objvPrjTabKeyFldCond.FldId, strComparisonOpFldId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.FieldTypeId, objvPrjTabKeyFldCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.PrimaryTypeId, objvPrjTabKeyFldCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.PrimaryTypeName, objvPrjTabKeyFldCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.KeyFldName) == true)
{
string strComparisonOpKeyFldName = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.KeyFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.KeyFldName, objvPrjTabKeyFldCond.KeyFldName, strComparisonOpKeyFldName);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.PrjId, objvPrjTabKeyFldCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTabKeyFld
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPrjTabKeyFld(vPrjTabKeyFld)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabKeyFldBL
{
public static RelatedActions_vPrjTabKeyFld relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTabKeyFldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTabKeyFldDA vPrjTabKeyFldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTabKeyFldDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTabKeyFldBL()
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
if (string.IsNullOrEmpty(clsvPrjTabKeyFldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTabKeyFldEN._ConnectString);
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
public static DataTable GetDataTable_vPrjTabKeyFld(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldDA.GetDataTable_vPrjTabKeyFld(strWhereCond);
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
objDT = vPrjTabKeyFldDA.GetDataTable(strWhereCond);
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
objDT = vPrjTabKeyFldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjTabKeyFldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjTabKeyFldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjTabKeyFldDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjTabKeyFldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjTabKeyFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjTabKeyFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTabKeyFldEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLst_Sel =
arrvPrjTabKeyFldObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvPrjTabKeyFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetObjLst(string strWhereCond)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
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
public static List<clsvPrjTabKeyFldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTabKeyFldEN> GetSubObjLstCache(clsvPrjTabKeyFldEN objvPrjTabKeyFldCond)
{
 string strPrjId = objvPrjTabKeyFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTabKeyFldBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabKeyFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabKeyFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabKeyFld.AttributeName)
{
if (objvPrjTabKeyFldCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabKeyFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldCond[strFldName].ToString());
}
else
{
if (objvPrjTabKeyFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabKeyFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabKeyFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldCond[strFldName]));
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
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
List<clsvPrjTabKeyFldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjTabKeyFldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjTabKeyFldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
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
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
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
public static List<clsvPrjTabKeyFldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTabKeyFldEN> arrObjLst = new List<clsvPrjTabKeyFldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = new clsvPrjTabKeyFldEN();
try
{
objvPrjTabKeyFldEN.TabId = objRow[convPrjTabKeyFld.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldEN.FldId = objRow[convPrjTabKeyFld.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldEN.FieldTypeId = objRow[convPrjTabKeyFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldEN.PrimaryTypeId = objRow[convPrjTabKeyFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldEN.PrimaryTypeName = objRow[convPrjTabKeyFld.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldEN.KeyFldName = objRow[convPrjTabKeyFld.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFld.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldEN.PrjId = objRow[convPrjTabKeyFld.PrjId].ToString().Trim(); //工程ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTabKeyFld(ref clsvPrjTabKeyFldEN objvPrjTabKeyFldEN)
{
bool bolResult = vPrjTabKeyFldDA.GetvPrjTabKeyFld(ref objvPrjTabKeyFldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabKeyFldEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = vPrjTabKeyFldDA.GetObjByTabId(strTabId);
return objvPrjTabKeyFldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTabKeyFldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = vPrjTabKeyFldDA.GetFirstObj(strWhereCond);
 return objvPrjTabKeyFldEN;
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
public static clsvPrjTabKeyFldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = vPrjTabKeyFldDA.GetObjByDataRow(objRow);
 return objvPrjTabKeyFldEN;
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
public static clsvPrjTabKeyFldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTabKeyFldEN objvPrjTabKeyFldEN = vPrjTabKeyFldDA.GetObjByDataRow(objRow);
 return objvPrjTabKeyFldEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstvPrjTabKeyFldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabKeyFldEN GetObjByTabIdFromList(string strTabId, List<clsvPrjTabKeyFldEN> lstvPrjTabKeyFldObjLst)
{
foreach (clsvPrjTabKeyFldEN objvPrjTabKeyFldEN in lstvPrjTabKeyFldObjLst)
{
if (objvPrjTabKeyFldEN.TabId == strTabId)
{
return objvPrjTabKeyFldEN;
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
 string strTabId;
 try
 {
 strTabId = new clsvPrjTabKeyFldDA().GetFirstID(strWhereCond);
 return strTabId;
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
 arrList = vPrjTabKeyFldDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjTabKeyFldDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjTabKeyFldDA.IsExist(strTabId);
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
 bolIsExist = clsvPrjTabKeyFldDA.IsExistTable();
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
 bolIsExist = vPrjTabKeyFldDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjTabKeyFldENS">源对象</param>
 /// <param name = "objvPrjTabKeyFldENT">目标对象</param>
 public static void CopyTo(clsvPrjTabKeyFldEN objvPrjTabKeyFldENS, clsvPrjTabKeyFldEN objvPrjTabKeyFldENT)
{
try
{
objvPrjTabKeyFldENT.TabId = objvPrjTabKeyFldENS.TabId; //表ID
objvPrjTabKeyFldENT.FldId = objvPrjTabKeyFldENS.FldId; //字段Id
objvPrjTabKeyFldENT.FieldTypeId = objvPrjTabKeyFldENS.FieldTypeId; //字段类型Id
objvPrjTabKeyFldENT.PrimaryTypeId = objvPrjTabKeyFldENS.PrimaryTypeId; //主键类型ID
objvPrjTabKeyFldENT.PrimaryTypeName = objvPrjTabKeyFldENS.PrimaryTypeName; //主键类型名
objvPrjTabKeyFldENT.KeyFldName = objvPrjTabKeyFldENS.KeyFldName; //关键字段名
objvPrjTabKeyFldENT.PrjId = objvPrjTabKeyFldENS.PrjId; //工程ID
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
 /// <param name = "objvPrjTabKeyFldEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTabKeyFldEN objvPrjTabKeyFldEN)
{
try
{
objvPrjTabKeyFldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTabKeyFldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTabKeyFld.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldEN.TabId = objvPrjTabKeyFldEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTabKeyFld.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldEN.FldId = objvPrjTabKeyFldEN.FldId; //字段Id
}
if (arrFldSet.Contains(convPrjTabKeyFld.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldEN.FieldTypeId = objvPrjTabKeyFldEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convPrjTabKeyFld.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldEN.PrimaryTypeId = objvPrjTabKeyFldEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(convPrjTabKeyFld.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldEN.PrimaryTypeName = objvPrjTabKeyFldEN.PrimaryTypeName == "[null]" ? null :  objvPrjTabKeyFldEN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(convPrjTabKeyFld.KeyFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldEN.KeyFldName = objvPrjTabKeyFldEN.KeyFldName == "[null]" ? null :  objvPrjTabKeyFldEN.KeyFldName; //关键字段名
}
if (arrFldSet.Contains(convPrjTabKeyFld.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldEN.PrjId = objvPrjTabKeyFldEN.PrjId; //工程ID
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
 /// <param name = "objvPrjTabKeyFldEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTabKeyFldEN objvPrjTabKeyFldEN)
{
try
{
if (objvPrjTabKeyFldEN.PrimaryTypeName == "[null]") objvPrjTabKeyFldEN.PrimaryTypeName = null; //主键类型名
if (objvPrjTabKeyFldEN.KeyFldName == "[null]") objvPrjTabKeyFldEN.KeyFldName = null; //关键字段名
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
public static void CheckProperty4Condition(clsvPrjTabKeyFldEN objvPrjTabKeyFldEN)
{
 vPrjTabKeyFldDA.CheckProperty4Condition(objvPrjTabKeyFldEN);
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
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrimaryTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrimaryTypeBL没有刷新缓存机制(clsPrimaryTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvPrjTabKeyFldObjLstCache == null)
//{
//arrvPrjTabKeyFldObjLstCache = vPrjTabKeyFldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabKeyFldEN GetObjByTabIdCache(string strTabId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLst_Sel =
arrvPrjTabKeyFldObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvPrjTabKeyFldObjLst_Sel.Count() == 0)
{
   clsvPrjTabKeyFldEN obj = clsvPrjTabKeyFldBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjTabKeyFldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetAllvPrjTabKeyFldObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = GetObjLstCache(strPrjId); 
return arrvPrjTabKeyFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTabKeyFldObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvPrjTabKeyFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjTabKeyFldEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTabKeyFldEN._RefreshTimeLst[clsvPrjTabKeyFldEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-10-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strPrjId)
{
if (strInFldName != convPrjTabKeyFld.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTabKeyFld.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTabKeyFld.AttributeName));
throw new Exception(strMsg);
}
var objvPrjTabKeyFld = clsvPrjTabKeyFldBL.GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTabKeyFld == null) return "";
return objvPrjTabKeyFld[strOutFldName].ToString();
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
int intRecCount = clsvPrjTabKeyFldDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjTabKeyFldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTabKeyFldDA.GetRecCount();
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
int intRecCount = clsvPrjTabKeyFldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTabKeyFldEN objvPrjTabKeyFldCond)
{
 string strPrjId = objvPrjTabKeyFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTabKeyFldBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabKeyFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabKeyFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabKeyFld.AttributeName)
{
if (objvPrjTabKeyFldCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabKeyFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldCond[strFldName].ToString());
}
else
{
if (objvPrjTabKeyFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabKeyFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabKeyFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabKeyFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldCond[strFldName]));
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
 List<string> arrList = clsvPrjTabKeyFldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabKeyFldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabKeyFldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}