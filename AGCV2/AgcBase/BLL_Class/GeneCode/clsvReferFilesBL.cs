﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvReferFilesBL
 表名:vReferFiles(00050461)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:50:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvReferFilesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvReferFilesEN GetObj(this K_ReferFileId_vReferFiles myKey)
{
clsvReferFilesEN objvReferFilesEN = clsvReferFilesBL.vReferFilesDA.GetObjByReferFileId(myKey.Value);
return objvReferFilesEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetReferFileId(this clsvReferFilesEN objvReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileId, 8, convReferFiles.ReferFileId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, convReferFiles.ReferFileId);
}
objvReferFilesEN.ReferFileId = strReferFileId; //引用文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.ReferFileId) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.ReferFileId, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.ReferFileId] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetFileName(this clsvReferFilesEN objvReferFilesEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convReferFiles.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convReferFiles.FileName);
}
objvReferFilesEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.FileName) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.FileName, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.FileName] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetReferFileTypeId(this clsvReferFilesEN objvReferFilesEN, string strReferFileTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileTypeId, 2, convReferFiles.ReferFileTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReferFileTypeId, 2, convReferFiles.ReferFileTypeId);
}
objvReferFilesEN.ReferFileTypeId = strReferFileTypeId; //引用文件类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.ReferFileTypeId) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.ReferFileTypeId, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.ReferFileTypeId] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetReferFileTypeName(this clsvReferFilesEN objvReferFilesEN, string strReferFileTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileTypeName, 50, convReferFiles.ReferFileTypeName);
}
objvReferFilesEN.ReferFileTypeName = strReferFileTypeName; //引用文件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.ReferFileTypeName) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.ReferFileTypeName, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.ReferFileTypeName] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetFilePath(this clsvReferFilesEN objvReferFilesEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convReferFiles.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convReferFiles.FilePath);
}
objvReferFilesEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.FilePath) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.FilePath, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.FilePath] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetIsNeedDownLoad(this clsvReferFilesEN objvReferFilesEN, bool bolIsNeedDownLoad, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedDownLoad, convReferFiles.IsNeedDownLoad);
objvReferFilesEN.IsNeedDownLoad = bolIsNeedDownLoad; //是否需要下载
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.IsNeedDownLoad) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.IsNeedDownLoad, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.IsNeedDownLoad] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetVersion(this clsvReferFilesEN objvReferFilesEN, string strVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersion, convReferFiles.Version);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersion, 30, convReferFiles.Version);
}
objvReferFilesEN.Version = strVersion; //版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.Version) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.Version, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.Version] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetInUse(this clsvReferFilesEN objvReferFilesEN, bool bolInUse, string strComparisonOp="")
	{
objvReferFilesEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.InUse) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.InUse, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.InUse] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetOrderNum(this clsvReferFilesEN objvReferFilesEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convReferFiles.OrderNum);
objvReferFilesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.OrderNum) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.OrderNum, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.OrderNum] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetUpdDate(this clsvReferFilesEN objvReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convReferFiles.UpdDate);
}
objvReferFilesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.UpdDate) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.UpdDate, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.UpdDate] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetUpdUserId(this clsvReferFilesEN objvReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convReferFiles.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convReferFiles.UpdUserId);
}
objvReferFilesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.UpdUserId) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.UpdUserId, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.UpdUserId] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetMemo(this clsvReferFilesEN objvReferFilesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convReferFiles.Memo);
}
objvReferFilesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.Memo) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.Memo, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.Memo] = strComparisonOp;
}
}
return objvReferFilesEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvReferFilesENS">源对象</param>
 /// <param name = "objvReferFilesENT">目标对象</param>
 public static void CopyTo(this clsvReferFilesEN objvReferFilesENS, clsvReferFilesEN objvReferFilesENT)
{
try
{
objvReferFilesENT.ReferFileId = objvReferFilesENS.ReferFileId; //引用文件Id
objvReferFilesENT.FileName = objvReferFilesENS.FileName; //文件名
objvReferFilesENT.ReferFileTypeId = objvReferFilesENS.ReferFileTypeId; //引用文件类型Id
objvReferFilesENT.ReferFileTypeName = objvReferFilesENS.ReferFileTypeName; //引用文件类型名
objvReferFilesENT.FilePath = objvReferFilesENS.FilePath; //文件路径
objvReferFilesENT.IsNeedDownLoad = objvReferFilesENS.IsNeedDownLoad; //是否需要下载
objvReferFilesENT.Version = objvReferFilesENS.Version; //版本
objvReferFilesENT.InUse = objvReferFilesENS.InUse; //是否在用
objvReferFilesENT.OrderNum = objvReferFilesENS.OrderNum; //序号
objvReferFilesENT.UpdDate = objvReferFilesENS.UpdDate; //修改日期
objvReferFilesENT.UpdUserId = objvReferFilesENS.UpdUserId; //修改用户Id
objvReferFilesENT.Memo = objvReferFilesENS.Memo; //说明
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
 /// <param name = "objvReferFilesENS">源对象</param>
 /// <returns>目标对象=>clsvReferFilesEN:objvReferFilesENT</returns>
 public static clsvReferFilesEN CopyTo(this clsvReferFilesEN objvReferFilesENS)
{
try
{
 clsvReferFilesEN objvReferFilesENT = new clsvReferFilesEN()
{
ReferFileId = objvReferFilesENS.ReferFileId, //引用文件Id
FileName = objvReferFilesENS.FileName, //文件名
ReferFileTypeId = objvReferFilesENS.ReferFileTypeId, //引用文件类型Id
ReferFileTypeName = objvReferFilesENS.ReferFileTypeName, //引用文件类型名
FilePath = objvReferFilesENS.FilePath, //文件路径
IsNeedDownLoad = objvReferFilesENS.IsNeedDownLoad, //是否需要下载
Version = objvReferFilesENS.Version, //版本
InUse = objvReferFilesENS.InUse, //是否在用
OrderNum = objvReferFilesENS.OrderNum, //序号
UpdDate = objvReferFilesENS.UpdDate, //修改日期
UpdUserId = objvReferFilesENS.UpdUserId, //修改用户Id
Memo = objvReferFilesENS.Memo, //说明
};
 return objvReferFilesENT;
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
public static void CheckProperty4Condition(this clsvReferFilesEN objvReferFilesEN)
{
 clsvReferFilesBL.vReferFilesDA.CheckProperty4Condition(objvReferFilesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvReferFilesEN objvReferFilesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvReferFilesCond.IsUpdated(convReferFiles.ReferFileId) == true)
{
string strComparisonOpReferFileId = objvReferFilesCond.dicFldComparisonOp[convReferFiles.ReferFileId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.ReferFileId, objvReferFilesCond.ReferFileId, strComparisonOpReferFileId);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.FileName) == true)
{
string strComparisonOpFileName = objvReferFilesCond.dicFldComparisonOp[convReferFiles.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.FileName, objvReferFilesCond.FileName, strComparisonOpFileName);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.ReferFileTypeId) == true)
{
string strComparisonOpReferFileTypeId = objvReferFilesCond.dicFldComparisonOp[convReferFiles.ReferFileTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.ReferFileTypeId, objvReferFilesCond.ReferFileTypeId, strComparisonOpReferFileTypeId);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.ReferFileTypeName) == true)
{
string strComparisonOpReferFileTypeName = objvReferFilesCond.dicFldComparisonOp[convReferFiles.ReferFileTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.ReferFileTypeName, objvReferFilesCond.ReferFileTypeName, strComparisonOpReferFileTypeName);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.FilePath) == true)
{
string strComparisonOpFilePath = objvReferFilesCond.dicFldComparisonOp[convReferFiles.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.FilePath, objvReferFilesCond.FilePath, strComparisonOpFilePath);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.IsNeedDownLoad) == true)
{
if (objvReferFilesCond.IsNeedDownLoad == true)
{
strWhereCond += string.Format(" And {0} = '1'", convReferFiles.IsNeedDownLoad);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convReferFiles.IsNeedDownLoad);
}
}
if (objvReferFilesCond.IsUpdated(convReferFiles.Version) == true)
{
string strComparisonOpVersion = objvReferFilesCond.dicFldComparisonOp[convReferFiles.Version];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.Version, objvReferFilesCond.Version, strComparisonOpVersion);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.InUse) == true)
{
if (objvReferFilesCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convReferFiles.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convReferFiles.InUse);
}
}
if (objvReferFilesCond.IsUpdated(convReferFiles.OrderNum) == true)
{
string strComparisonOpOrderNum = objvReferFilesCond.dicFldComparisonOp[convReferFiles.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convReferFiles.OrderNum, objvReferFilesCond.OrderNum, strComparisonOpOrderNum);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.UpdDate) == true)
{
string strComparisonOpUpdDate = objvReferFilesCond.dicFldComparisonOp[convReferFiles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.UpdDate, objvReferFilesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvReferFilesCond.dicFldComparisonOp[convReferFiles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.UpdUserId, objvReferFilesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.Memo) == true)
{
string strComparisonOpMemo = objvReferFilesCond.dicFldComparisonOp[convReferFiles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.Memo, objvReferFilesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vReferFiles(v引用文件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FileName_FilePath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvReferFilesEN objvReferFilesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvReferFilesEN == null) return true;
if (objvReferFilesEN.ReferFileId == null || objvReferFilesEN.ReferFileId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objvReferFilesEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objvReferFilesEN.FilePath);
if (clsvReferFilesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ReferFileId !=  '{0}'", objvReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objvReferFilesEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objvReferFilesEN.FilePath);
if (clsvReferFilesBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vReferFiles(v引用文件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FileName_FilePath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvReferFilesEN objvReferFilesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvReferFilesEN == null) return "";
if (objvReferFilesEN.ReferFileId == null || objvReferFilesEN.ReferFileId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objvReferFilesEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objvReferFilesEN.FilePath);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ReferFileId !=  '{0}'", objvReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objvReferFilesEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objvReferFilesEN.FilePath);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vReferFiles
{
public virtual bool UpdRelaTabDate(string strReferFileId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v引用文件(vReferFiles)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvReferFilesBL
{
public static RelatedActions_vReferFiles relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvReferFilesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvReferFilesDA vReferFilesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvReferFilesDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvReferFilesBL()
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
if (string.IsNullOrEmpty(clsvReferFilesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvReferFilesEN._ConnectString);
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
public static DataTable GetDataTable_vReferFiles(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vReferFilesDA.GetDataTable_vReferFiles(strWhereCond);
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
objDT = vReferFilesDA.GetDataTable(strWhereCond);
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
objDT = vReferFilesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vReferFilesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vReferFilesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vReferFilesDA.GetDataTable_Top(objTopPara);
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
objDT = vReferFilesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrReferFileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvReferFilesEN> GetObjLstByReferFileIdLst(List<string> arrReferFileIdLst)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrReferFileIdLst, true);
 string strWhereCond = string.Format("ReferFileId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrReferFileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvReferFilesEN> GetObjLstByReferFileIdLstCache(List<string> arrReferFileIdLst)
{
string strKey = string.Format("{0}", clsvReferFilesEN._CurrTabName);
List<clsvReferFilesEN> arrvReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsvReferFilesEN> arrvReferFilesObjLst_Sel =
arrvReferFilesObjLstCache
.Where(x => arrReferFileIdLst.Contains(x.ReferFileId));
return arrvReferFilesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvReferFilesEN> GetObjLst(string strWhereCond)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
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
public static List<clsvReferFilesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvReferFilesEN> GetSubObjLstCache(clsvReferFilesEN objvReferFilesCond)
{
List<clsvReferFilesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convReferFiles.AttributeName)
{
if (objvReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objvReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvReferFilesCond[strFldName].ToString());
}
else
{
if (objvReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvReferFilesCond[strFldName]));
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
public static List<clsvReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
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
public static List<clsvReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
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
List<clsvReferFilesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvReferFilesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
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
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
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
public static List<clsvReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
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
public static List<clsvReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvReferFilesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvReferFilesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvReferFilesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvReferFiles(ref clsvReferFilesEN objvReferFilesEN)
{
bool bolResult = vReferFilesDA.GetvReferFiles(ref objvReferFilesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvReferFilesEN GetObjByReferFileId(string strReferFileId)
{
if (strReferFileId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strReferFileId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strReferFileId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strReferFileId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvReferFilesEN objvReferFilesEN = vReferFilesDA.GetObjByReferFileId(strReferFileId);
return objvReferFilesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvReferFilesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvReferFilesEN objvReferFilesEN = vReferFilesDA.GetFirstObj(strWhereCond);
 return objvReferFilesEN;
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
public static clsvReferFilesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvReferFilesEN objvReferFilesEN = vReferFilesDA.GetObjByDataRow(objRow);
 return objvReferFilesEN;
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
public static clsvReferFilesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvReferFilesEN objvReferFilesEN = vReferFilesDA.GetObjByDataRow(objRow);
 return objvReferFilesEN;
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
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <param name = "lstvReferFilesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvReferFilesEN GetObjByReferFileIdFromList(string strReferFileId, List<clsvReferFilesEN> lstvReferFilesObjLst)
{
foreach (clsvReferFilesEN objvReferFilesEN in lstvReferFilesObjLst)
{
if (objvReferFilesEN.ReferFileId == strReferFileId)
{
return objvReferFilesEN;
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
 string strMaxReferFileId;
 try
 {
 strMaxReferFileId = clsvReferFilesDA.GetMaxStrId();
 return strMaxReferFileId;
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
 string strReferFileId;
 try
 {
 strReferFileId = new clsvReferFilesDA().GetFirstID(strWhereCond);
 return strReferFileId;
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
 arrList = vReferFilesDA.GetID(strWhereCond);
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
bool bolIsExist = vReferFilesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strReferFileId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vReferFilesDA.IsExist(strReferFileId);
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
 bolIsExist = clsvReferFilesDA.IsExistTable();
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
 bolIsExist = vReferFilesDA.IsExistTable(strTabName);
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
 /// <param name = "objvReferFilesENS">源对象</param>
 /// <param name = "objvReferFilesENT">目标对象</param>
 public static void CopyTo(clsvReferFilesEN objvReferFilesENS, clsvReferFilesEN objvReferFilesENT)
{
try
{
objvReferFilesENT.ReferFileId = objvReferFilesENS.ReferFileId; //引用文件Id
objvReferFilesENT.FileName = objvReferFilesENS.FileName; //文件名
objvReferFilesENT.ReferFileTypeId = objvReferFilesENS.ReferFileTypeId; //引用文件类型Id
objvReferFilesENT.ReferFileTypeName = objvReferFilesENS.ReferFileTypeName; //引用文件类型名
objvReferFilesENT.FilePath = objvReferFilesENS.FilePath; //文件路径
objvReferFilesENT.IsNeedDownLoad = objvReferFilesENS.IsNeedDownLoad; //是否需要下载
objvReferFilesENT.Version = objvReferFilesENS.Version; //版本
objvReferFilesENT.InUse = objvReferFilesENS.InUse; //是否在用
objvReferFilesENT.OrderNum = objvReferFilesENS.OrderNum; //序号
objvReferFilesENT.UpdDate = objvReferFilesENS.UpdDate; //修改日期
objvReferFilesENT.UpdUserId = objvReferFilesENS.UpdUserId; //修改用户Id
objvReferFilesENT.Memo = objvReferFilesENS.Memo; //说明
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
 /// <param name = "objvReferFilesEN">源简化对象</param>
 public static void SetUpdFlag(clsvReferFilesEN objvReferFilesEN)
{
try
{
objvReferFilesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvReferFilesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convReferFiles.ReferFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.ReferFileId = objvReferFilesEN.ReferFileId; //引用文件Id
}
if (arrFldSet.Contains(convReferFiles.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.FileName = objvReferFilesEN.FileName; //文件名
}
if (arrFldSet.Contains(convReferFiles.ReferFileTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.ReferFileTypeId = objvReferFilesEN.ReferFileTypeId == "[null]" ? null :  objvReferFilesEN.ReferFileTypeId; //引用文件类型Id
}
if (arrFldSet.Contains(convReferFiles.ReferFileTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.ReferFileTypeName = objvReferFilesEN.ReferFileTypeName == "[null]" ? null :  objvReferFilesEN.ReferFileTypeName; //引用文件类型名
}
if (arrFldSet.Contains(convReferFiles.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.FilePath = objvReferFilesEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convReferFiles.IsNeedDownLoad, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.IsNeedDownLoad = objvReferFilesEN.IsNeedDownLoad; //是否需要下载
}
if (arrFldSet.Contains(convReferFiles.Version, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.Version = objvReferFilesEN.Version; //版本
}
if (arrFldSet.Contains(convReferFiles.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.InUse = objvReferFilesEN.InUse; //是否在用
}
if (arrFldSet.Contains(convReferFiles.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.OrderNum = objvReferFilesEN.OrderNum; //序号
}
if (arrFldSet.Contains(convReferFiles.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.UpdDate = objvReferFilesEN.UpdDate == "[null]" ? null :  objvReferFilesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convReferFiles.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.UpdUserId = objvReferFilesEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convReferFiles.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvReferFilesEN.Memo = objvReferFilesEN.Memo == "[null]" ? null :  objvReferFilesEN.Memo; //说明
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
 /// <param name = "objvReferFilesEN">源简化对象</param>
 public static void AccessFldValueNull(clsvReferFilesEN objvReferFilesEN)
{
try
{
if (objvReferFilesEN.ReferFileTypeId == "[null]") objvReferFilesEN.ReferFileTypeId = null; //引用文件类型Id
if (objvReferFilesEN.ReferFileTypeName == "[null]") objvReferFilesEN.ReferFileTypeName = null; //引用文件类型名
if (objvReferFilesEN.UpdDate == "[null]") objvReferFilesEN.UpdDate = null; //修改日期
if (objvReferFilesEN.Memo == "[null]") objvReferFilesEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvReferFilesEN objvReferFilesEN)
{
 vReferFilesDA.CheckProperty4Condition(objvReferFilesEN);
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
if (clsReferFilesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsReferFilesBL没有刷新缓存机制(clsReferFilesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsReferFileTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsReferFileTypeBL没有刷新缓存机制(clsReferFileTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ReferFileId");
//if (arrvReferFilesObjLstCache == null)
//{
//arrvReferFilesObjLstCache = vReferFilesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvReferFilesEN GetObjByReferFileIdCache(string strReferFileId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvReferFilesEN._CurrTabName);
List<clsvReferFilesEN> arrvReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsvReferFilesEN> arrvReferFilesObjLst_Sel =
arrvReferFilesObjLstCache
.Where(x=> x.ReferFileId == strReferFileId 
);
if (arrvReferFilesObjLst_Sel.Count() == 0)
{
   clsvReferFilesEN obj = clsvReferFilesBL.GetObjByReferFileId(strReferFileId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvReferFilesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvReferFilesEN> GetAllvReferFilesObjLstCache()
{
//获取缓存中的对象列表
List<clsvReferFilesEN> arrvReferFilesObjLstCache = GetObjLstCache(); 
return arrvReferFilesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvReferFilesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvReferFilesEN._CurrTabName);
List<clsvReferFilesEN> arrvReferFilesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvReferFilesObjLstCache;
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
string strKey = string.Format("{0}", clsvReferFilesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvReferFilesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvReferFilesEN._RefreshTimeLst.Count == 0) return "";
return clsvReferFilesEN._RefreshTimeLst[clsvReferFilesEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vReferFiles(v引用文件)
 /// 唯一性条件:FileName_FilePath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvReferFilesEN objvReferFilesEN)
{
//检测记录是否存在
string strResult = vReferFilesDA.GetUniCondStr(objvReferFilesEN);
return strResult;
}


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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strReferFileId)
{
if (strInFldName != convReferFiles.ReferFileId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convReferFiles.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convReferFiles.AttributeName));
throw new Exception(strMsg);
}
var objvReferFiles = clsvReferFilesBL.GetObjByReferFileIdCache(strReferFileId);
if (objvReferFiles == null) return "";
return objvReferFiles[strOutFldName].ToString();
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
int intRecCount = clsvReferFilesDA.GetRecCount(strTabName);
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
int intRecCount = clsvReferFilesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvReferFilesDA.GetRecCount();
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
int intRecCount = clsvReferFilesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvReferFilesEN objvReferFilesCond)
{
List<clsvReferFilesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convReferFiles.AttributeName)
{
if (objvReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objvReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvReferFilesCond[strFldName].ToString());
}
else
{
if (objvReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvReferFilesCond[strFldName]));
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
 List<string> arrList = clsvReferFilesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vReferFilesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vReferFilesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}