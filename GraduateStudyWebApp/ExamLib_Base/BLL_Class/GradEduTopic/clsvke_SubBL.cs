
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvke_SubBL
 表名:vke_Sub(01120659)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsvke_SubBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strKeSubId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvke_SubEN GetObj(this K_KeSubId_vke_Sub myKey)
{
clsvke_SubEN objvke_SubEN = clsvke_SubBL.vke_SubDA.GetObjByKeSubId(myKey.Value);
return objvke_SubEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSubId(this clsvke_SubEN objvke_SubEN, string strKeSubId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSubId, 4, convke_Sub.KeSubId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKeSubId, 4, convke_Sub.KeSubId);
}
objvke_SubEN.KeSubId = strKeSubId; //知识子类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSubId) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSubId, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSubId] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSuperId(this clsvke_SubEN objvke_SubEN, string strKeSuperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeSuperId, convke_Sub.KeSuperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSuperId, 4, convke_Sub.KeSuperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKeSuperId, 4, convke_Sub.KeSuperId);
}
objvke_SubEN.KeSuperId = strKeSuperId; //知识分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSuperId) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSuperId, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSuperId] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSuperNameCn(this clsvke_SubEN objvke_SubEN, string strKeSuperNameCn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSuperNameCn, 200, convke_Sub.KeSuperNameCn);
}
objvke_SubEN.KeSuperNameCn = strKeSuperNameCn; //知识分类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSuperNameCn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSuperNameCn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSuperNameCn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSuperNameEn(this clsvke_SubEN objvke_SubEN, string strKeSuperNameEn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSuperNameEn, 200, convke_Sub.KeSuperNameEn);
}
objvke_SubEN.KeSuperNameEn = strKeSuperNameEn; //知识分类英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSuperNameEn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSuperNameEn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSuperNameEn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSubNameCn(this clsvke_SubEN objvke_SubEN, string strKeSubNameCn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeSubNameCn, convke_Sub.KeSubNameCn);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSubNameCn, 200, convke_Sub.KeSubNameCn);
}
objvke_SubEN.KeSubNameCn = strKeSubNameCn; //知识子类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSubNameCn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSubNameCn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSubNameCn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSubNameEn(this clsvke_SubEN objvke_SubEN, string strKeSubNameEn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSubNameEn, 200, convke_Sub.KeSubNameEn);
}
objvke_SubEN.KeSubNameEn = strKeSubNameEn; //知识子类英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSubNameEn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSubNameEn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSubNameEn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSuperDescribeCn(this clsvke_SubEN objvke_SubEN, string strKeSuperDescribeCn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSuperDescribeCn, 500, convke_Sub.KeSuperDescribeCn);
}
objvke_SubEN.KeSuperDescribeCn = strKeSuperDescribeCn; //知识分类描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSuperDescribeCn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSuperDescribeCn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSuperDescribeCn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSubDescribeCn(this clsvke_SubEN objvke_SubEN, string strKeSubDescribeCn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSubDescribeCn, 500, convke_Sub.KeSubDescribeCn);
}
objvke_SubEN.KeSubDescribeCn = strKeSubDescribeCn; //知识子类描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSubDescribeCn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSubDescribeCn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSubDescribeCn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSuperDescribeEn(this clsvke_SubEN objvke_SubEN, string strKeSuperDescribeEn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSuperDescribeEn, 500, convke_Sub.KeSuperDescribeEn);
}
objvke_SubEN.KeSuperDescribeEn = strKeSuperDescribeEn; //知识分类英文描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSuperDescribeEn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSuperDescribeEn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSuperDescribeEn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetKeSubDescribeEn(this clsvke_SubEN objvke_SubEN, string strKeSubDescribeEn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeSubDescribeEn, 500, convke_Sub.KeSubDescribeEn);
}
objvke_SubEN.KeSubDescribeEn = strKeSubDescribeEn; //知识子类英文描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.KeSubDescribeEn) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.KeSubDescribeEn, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.KeSubDescribeEn] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetUpdDate(this clsvke_SubEN objvke_SubEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convke_Sub.UpdDate);
}
objvke_SubEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.UpdDate) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.UpdDate, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.UpdDate] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetUpdUser(this clsvke_SubEN objvke_SubEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convke_Sub.UpdUser);
}
objvke_SubEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.UpdUser) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.UpdUser, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.UpdUser] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetMemo(this clsvke_SubEN objvke_SubEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convke_Sub.Memo);
}
objvke_SubEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.Memo) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.Memo, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.Memo] = strComparisonOp;
}
}
return objvke_SubEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvke_SubEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvke_SubEN SetLink(this clsvke_SubEN objvke_SubEN, string strLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLink, 200, convke_Sub.Link);
}
objvke_SubEN.Link = strLink; //相应链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvke_SubEN.dicFldComparisonOp.ContainsKey(convke_Sub.Link) == false)
{
objvke_SubEN.dicFldComparisonOp.Add(convke_Sub.Link, strComparisonOp);
}
else
{
objvke_SubEN.dicFldComparisonOp[convke_Sub.Link] = strComparisonOp;
}
}
return objvke_SubEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvke_SubENS">源对象</param>
 /// <param name = "objvke_SubENT">目标对象</param>
 public static void CopyTo(this clsvke_SubEN objvke_SubENS, clsvke_SubEN objvke_SubENT)
{
try
{
objvke_SubENT.KeSubId = objvke_SubENS.KeSubId; //知识子类Id
objvke_SubENT.KeSuperId = objvke_SubENS.KeSuperId; //知识分类Id
objvke_SubENT.KeSuperNameCn = objvke_SubENS.KeSuperNameCn; //知识分类名
objvke_SubENT.KeSuperNameEn = objvke_SubENS.KeSuperNameEn; //知识分类英文名
objvke_SubENT.KeSubNameCn = objvke_SubENS.KeSubNameCn; //知识子类名
objvke_SubENT.KeSubNameEn = objvke_SubENS.KeSubNameEn; //知识子类英文名
objvke_SubENT.KeSuperDescribeCn = objvke_SubENS.KeSuperDescribeCn; //知识分类描述
objvke_SubENT.KeSubDescribeCn = objvke_SubENS.KeSubDescribeCn; //知识子类描述
objvke_SubENT.KeSuperDescribeEn = objvke_SubENS.KeSuperDescribeEn; //知识分类英文描述
objvke_SubENT.KeSubDescribeEn = objvke_SubENS.KeSubDescribeEn; //知识子类英文描述
objvke_SubENT.UpdDate = objvke_SubENS.UpdDate; //修改日期
objvke_SubENT.UpdUser = objvke_SubENS.UpdUser; //修改人
objvke_SubENT.Memo = objvke_SubENS.Memo; //备注
objvke_SubENT.Link = objvke_SubENS.Link; //相应链接
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
 /// <param name = "objvke_SubENS">源对象</param>
 /// <returns>目标对象=>clsvke_SubEN:objvke_SubENT</returns>
 public static clsvke_SubEN CopyTo(this clsvke_SubEN objvke_SubENS)
{
try
{
 clsvke_SubEN objvke_SubENT = new clsvke_SubEN()
{
KeSubId = objvke_SubENS.KeSubId, //知识子类Id
KeSuperId = objvke_SubENS.KeSuperId, //知识分类Id
KeSuperNameCn = objvke_SubENS.KeSuperNameCn, //知识分类名
KeSuperNameEn = objvke_SubENS.KeSuperNameEn, //知识分类英文名
KeSubNameCn = objvke_SubENS.KeSubNameCn, //知识子类名
KeSubNameEn = objvke_SubENS.KeSubNameEn, //知识子类英文名
KeSuperDescribeCn = objvke_SubENS.KeSuperDescribeCn, //知识分类描述
KeSubDescribeCn = objvke_SubENS.KeSubDescribeCn, //知识子类描述
KeSuperDescribeEn = objvke_SubENS.KeSuperDescribeEn, //知识分类英文描述
KeSubDescribeEn = objvke_SubENS.KeSubDescribeEn, //知识子类英文描述
UpdDate = objvke_SubENS.UpdDate, //修改日期
UpdUser = objvke_SubENS.UpdUser, //修改人
Memo = objvke_SubENS.Memo, //备注
Link = objvke_SubENS.Link, //相应链接
};
 return objvke_SubENT;
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
public static void CheckProperty4Condition(this clsvke_SubEN objvke_SubEN)
{
 clsvke_SubBL.vke_SubDA.CheckProperty4Condition(objvke_SubEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvke_SubEN objvke_SubCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvke_SubCond.IsUpdated(convke_Sub.KeSubId) == true)
{
string strComparisonOpKeSubId = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSubId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSubId, objvke_SubCond.KeSubId, strComparisonOpKeSubId);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSuperId) == true)
{
string strComparisonOpKeSuperId = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSuperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSuperId, objvke_SubCond.KeSuperId, strComparisonOpKeSuperId);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSuperNameCn) == true)
{
string strComparisonOpKeSuperNameCn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSuperNameCn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSuperNameCn, objvke_SubCond.KeSuperNameCn, strComparisonOpKeSuperNameCn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSuperNameEn) == true)
{
string strComparisonOpKeSuperNameEn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSuperNameEn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSuperNameEn, objvke_SubCond.KeSuperNameEn, strComparisonOpKeSuperNameEn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSubNameCn) == true)
{
string strComparisonOpKeSubNameCn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSubNameCn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSubNameCn, objvke_SubCond.KeSubNameCn, strComparisonOpKeSubNameCn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSubNameEn) == true)
{
string strComparisonOpKeSubNameEn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSubNameEn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSubNameEn, objvke_SubCond.KeSubNameEn, strComparisonOpKeSubNameEn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSuperDescribeCn) == true)
{
string strComparisonOpKeSuperDescribeCn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSuperDescribeCn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSuperDescribeCn, objvke_SubCond.KeSuperDescribeCn, strComparisonOpKeSuperDescribeCn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSubDescribeCn) == true)
{
string strComparisonOpKeSubDescribeCn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSubDescribeCn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSubDescribeCn, objvke_SubCond.KeSubDescribeCn, strComparisonOpKeSubDescribeCn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSuperDescribeEn) == true)
{
string strComparisonOpKeSuperDescribeEn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSuperDescribeEn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSuperDescribeEn, objvke_SubCond.KeSuperDescribeEn, strComparisonOpKeSuperDescribeEn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.KeSubDescribeEn) == true)
{
string strComparisonOpKeSubDescribeEn = objvke_SubCond.dicFldComparisonOp[convke_Sub.KeSubDescribeEn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.KeSubDescribeEn, objvke_SubCond.KeSubDescribeEn, strComparisonOpKeSubDescribeEn);
}
if (objvke_SubCond.IsUpdated(convke_Sub.UpdDate) == true)
{
string strComparisonOpUpdDate = objvke_SubCond.dicFldComparisonOp[convke_Sub.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.UpdDate, objvke_SubCond.UpdDate, strComparisonOpUpdDate);
}
if (objvke_SubCond.IsUpdated(convke_Sub.UpdUser) == true)
{
string strComparisonOpUpdUser = objvke_SubCond.dicFldComparisonOp[convke_Sub.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.UpdUser, objvke_SubCond.UpdUser, strComparisonOpUpdUser);
}
if (objvke_SubCond.IsUpdated(convke_Sub.Memo) == true)
{
string strComparisonOpMemo = objvke_SubCond.dicFldComparisonOp[convke_Sub.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.Memo, objvke_SubCond.Memo, strComparisonOpMemo);
}
if (objvke_SubCond.IsUpdated(convke_Sub.Link) == true)
{
string strComparisonOpLink = objvke_SubCond.dicFldComparisonOp[convke_Sub.Link];
strWhereCond += string.Format(" And {0} {2} '{1}'", convke_Sub.Link, objvke_SubCond.Link, strComparisonOpLink);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vke_Sub
{
public virtual bool UpdRelaTabDate(string strKeSubId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识经济子类视图(vke_Sub)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvke_SubBL
{
public static RelatedActions_vke_Sub relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvke_SubDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvke_SubDA vke_SubDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvke_SubDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvke_SubBL()
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
if (string.IsNullOrEmpty(clsvke_SubEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvke_SubEN._ConnectString);
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
public static DataTable GetDataTable_vke_Sub(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vke_SubDA.GetDataTable_vke_Sub(strWhereCond);
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
objDT = vke_SubDA.GetDataTable(strWhereCond);
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
objDT = vke_SubDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vke_SubDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vke_SubDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vke_SubDA.GetDataTable_Top(objTopPara);
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
objDT = vke_SubDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vke_SubDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vke_SubDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrKeSubIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvke_SubEN> GetObjLstByKeSubIdLst(List<string> arrKeSubIdLst)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrKeSubIdLst, true);
 string strWhereCond = string.Format("KeSubId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeSubIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvke_SubEN> GetObjLstByKeSubIdLstCache(List<string> arrKeSubIdLst)
{
string strKey = string.Format("{0}", clsvke_SubEN._CurrTabName);
List<clsvke_SubEN> arrvke_SubObjLstCache = GetObjLstCache();
IEnumerable <clsvke_SubEN> arrvke_SubObjLst_Sel =
arrvke_SubObjLstCache
.Where(x => arrKeSubIdLst.Contains(x.KeSubId));
return arrvke_SubObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvke_SubEN> GetObjLst(string strWhereCond)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
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
public static List<clsvke_SubEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvke_SubCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvke_SubEN> GetSubObjLstCache(clsvke_SubEN objvke_SubCond)
{
List<clsvke_SubEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvke_SubEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convke_Sub.AttributeName)
{
if (objvke_SubCond.IsUpdated(strFldName) == false) continue;
if (objvke_SubCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvke_SubCond[strFldName].ToString());
}
else
{
if (objvke_SubCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvke_SubCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvke_SubCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvke_SubCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvke_SubCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvke_SubCond[strFldName]));
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
public static List<clsvke_SubEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
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
public static List<clsvke_SubEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
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
List<clsvke_SubEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvke_SubEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvke_SubEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvke_SubEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
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
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
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
public static List<clsvke_SubEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvke_SubEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvke_SubEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
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
public static List<clsvke_SubEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvke_SubEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvke_SubEN> arrObjLst = new List<clsvke_SubEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvke_SubEN objvke_SubEN = new clsvke_SubEN();
try
{
objvke_SubEN.KeSubId = objRow[convke_Sub.KeSubId].ToString().Trim(); //知识子类Id
objvke_SubEN.KeSuperId = objRow[convke_Sub.KeSuperId].ToString().Trim(); //知识分类Id
objvke_SubEN.KeSuperNameCn = objRow[convke_Sub.KeSuperNameCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameCn].ToString().Trim(); //知识分类名
objvke_SubEN.KeSuperNameEn = objRow[convke_Sub.KeSuperNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperNameEn].ToString().Trim(); //知识分类英文名
objvke_SubEN.KeSubNameCn = objRow[convke_Sub.KeSubNameCn].ToString().Trim(); //知识子类名
objvke_SubEN.KeSubNameEn = objRow[convke_Sub.KeSubNameEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubNameEn].ToString().Trim(); //知识子类英文名
objvke_SubEN.KeSuperDescribeCn = objRow[convke_Sub.KeSuperDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeCn].ToString().Trim(); //知识分类描述
objvke_SubEN.KeSubDescribeCn = objRow[convke_Sub.KeSubDescribeCn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeCn].ToString().Trim(); //知识子类描述
objvke_SubEN.KeSuperDescribeEn = objRow[convke_Sub.KeSuperDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSuperDescribeEn].ToString().Trim(); //知识分类英文描述
objvke_SubEN.KeSubDescribeEn = objRow[convke_Sub.KeSubDescribeEn] == DBNull.Value ? null : objRow[convke_Sub.KeSubDescribeEn].ToString().Trim(); //知识子类英文描述
objvke_SubEN.UpdDate = objRow[convke_Sub.UpdDate] == DBNull.Value ? null : objRow[convke_Sub.UpdDate].ToString().Trim(); //修改日期
objvke_SubEN.UpdUser = objRow[convke_Sub.UpdUser] == DBNull.Value ? null : objRow[convke_Sub.UpdUser].ToString().Trim(); //修改人
objvke_SubEN.Memo = objRow[convke_Sub.Memo] == DBNull.Value ? null : objRow[convke_Sub.Memo].ToString().Trim(); //备注
objvke_SubEN.Link = objRow[convke_Sub.Link] == DBNull.Value ? null : objRow[convke_Sub.Link].ToString().Trim(); //相应链接
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvke_SubEN.KeSubId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvke_SubEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvke_SubEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvke_Sub(ref clsvke_SubEN objvke_SubEN)
{
bool bolResult = vke_SubDA.Getvke_Sub(ref objvke_SubEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strKeSubId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvke_SubEN GetObjByKeSubId(string strKeSubId)
{
if (strKeSubId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strKeSubId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strKeSubId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strKeSubId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvke_SubEN objvke_SubEN = vke_SubDA.GetObjByKeSubId(strKeSubId);
return objvke_SubEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvke_SubEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvke_SubEN objvke_SubEN = vke_SubDA.GetFirstObj(strWhereCond);
 return objvke_SubEN;
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
public static clsvke_SubEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvke_SubEN objvke_SubEN = vke_SubDA.GetObjByDataRow(objRow);
 return objvke_SubEN;
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
public static clsvke_SubEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvke_SubEN objvke_SubEN = vke_SubDA.GetObjByDataRow(objRow);
 return objvke_SubEN;
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
 /// <param name = "strKeSubId">所给的关键字</param>
 /// <param name = "lstvke_SubObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvke_SubEN GetObjByKeSubIdFromList(string strKeSubId, List<clsvke_SubEN> lstvke_SubObjLst)
{
foreach (clsvke_SubEN objvke_SubEN in lstvke_SubObjLst)
{
if (objvke_SubEN.KeSubId == strKeSubId)
{
return objvke_SubEN;
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
 string strKeSubId;
 try
 {
 strKeSubId = new clsvke_SubDA().GetFirstID(strWhereCond);
 return strKeSubId;
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
 arrList = vke_SubDA.GetID(strWhereCond);
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
bool bolIsExist = vke_SubDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strKeSubId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strKeSubId)
{
if (string.IsNullOrEmpty(strKeSubId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strKeSubId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vke_SubDA.IsExist(strKeSubId);
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
 bolIsExist = clsvke_SubDA.IsExistTable();
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
 bolIsExist = vke_SubDA.IsExistTable(strTabName);
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
 /// <param name = "objvke_SubENS">源对象</param>
 /// <param name = "objvke_SubENT">目标对象</param>
 public static void CopyTo(clsvke_SubEN objvke_SubENS, clsvke_SubEN objvke_SubENT)
{
try
{
objvke_SubENT.KeSubId = objvke_SubENS.KeSubId; //知识子类Id
objvke_SubENT.KeSuperId = objvke_SubENS.KeSuperId; //知识分类Id
objvke_SubENT.KeSuperNameCn = objvke_SubENS.KeSuperNameCn; //知识分类名
objvke_SubENT.KeSuperNameEn = objvke_SubENS.KeSuperNameEn; //知识分类英文名
objvke_SubENT.KeSubNameCn = objvke_SubENS.KeSubNameCn; //知识子类名
objvke_SubENT.KeSubNameEn = objvke_SubENS.KeSubNameEn; //知识子类英文名
objvke_SubENT.KeSuperDescribeCn = objvke_SubENS.KeSuperDescribeCn; //知识分类描述
objvke_SubENT.KeSubDescribeCn = objvke_SubENS.KeSubDescribeCn; //知识子类描述
objvke_SubENT.KeSuperDescribeEn = objvke_SubENS.KeSuperDescribeEn; //知识分类英文描述
objvke_SubENT.KeSubDescribeEn = objvke_SubENS.KeSubDescribeEn; //知识子类英文描述
objvke_SubENT.UpdDate = objvke_SubENS.UpdDate; //修改日期
objvke_SubENT.UpdUser = objvke_SubENS.UpdUser; //修改人
objvke_SubENT.Memo = objvke_SubENS.Memo; //备注
objvke_SubENT.Link = objvke_SubENS.Link; //相应链接
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
 /// <param name = "objvke_SubEN">源简化对象</param>
 public static void SetUpdFlag(clsvke_SubEN objvke_SubEN)
{
try
{
objvke_SubEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvke_SubEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convke_Sub.KeSubId, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSubId = objvke_SubEN.KeSubId; //知识子类Id
}
if (arrFldSet.Contains(convke_Sub.KeSuperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSuperId = objvke_SubEN.KeSuperId; //知识分类Id
}
if (arrFldSet.Contains(convke_Sub.KeSuperNameCn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSuperNameCn = objvke_SubEN.KeSuperNameCn == "[null]" ? null :  objvke_SubEN.KeSuperNameCn; //知识分类名
}
if (arrFldSet.Contains(convke_Sub.KeSuperNameEn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSuperNameEn = objvke_SubEN.KeSuperNameEn == "[null]" ? null :  objvke_SubEN.KeSuperNameEn; //知识分类英文名
}
if (arrFldSet.Contains(convke_Sub.KeSubNameCn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSubNameCn = objvke_SubEN.KeSubNameCn; //知识子类名
}
if (arrFldSet.Contains(convke_Sub.KeSubNameEn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSubNameEn = objvke_SubEN.KeSubNameEn == "[null]" ? null :  objvke_SubEN.KeSubNameEn; //知识子类英文名
}
if (arrFldSet.Contains(convke_Sub.KeSuperDescribeCn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSuperDescribeCn = objvke_SubEN.KeSuperDescribeCn == "[null]" ? null :  objvke_SubEN.KeSuperDescribeCn; //知识分类描述
}
if (arrFldSet.Contains(convke_Sub.KeSubDescribeCn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSubDescribeCn = objvke_SubEN.KeSubDescribeCn == "[null]" ? null :  objvke_SubEN.KeSubDescribeCn; //知识子类描述
}
if (arrFldSet.Contains(convke_Sub.KeSuperDescribeEn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSuperDescribeEn = objvke_SubEN.KeSuperDescribeEn == "[null]" ? null :  objvke_SubEN.KeSuperDescribeEn; //知识分类英文描述
}
if (arrFldSet.Contains(convke_Sub.KeSubDescribeEn, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.KeSubDescribeEn = objvke_SubEN.KeSubDescribeEn == "[null]" ? null :  objvke_SubEN.KeSubDescribeEn; //知识子类英文描述
}
if (arrFldSet.Contains(convke_Sub.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.UpdDate = objvke_SubEN.UpdDate == "[null]" ? null :  objvke_SubEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convke_Sub.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.UpdUser = objvke_SubEN.UpdUser == "[null]" ? null :  objvke_SubEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convke_Sub.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.Memo = objvke_SubEN.Memo == "[null]" ? null :  objvke_SubEN.Memo; //备注
}
if (arrFldSet.Contains(convke_Sub.Link, new clsStrCompareIgnoreCase())  ==  true)
{
objvke_SubEN.Link = objvke_SubEN.Link == "[null]" ? null :  objvke_SubEN.Link; //相应链接
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
 /// <param name = "objvke_SubEN">源简化对象</param>
 public static void AccessFldValueNull(clsvke_SubEN objvke_SubEN)
{
try
{
if (objvke_SubEN.KeSuperNameCn == "[null]") objvke_SubEN.KeSuperNameCn = null; //知识分类名
if (objvke_SubEN.KeSuperNameEn == "[null]") objvke_SubEN.KeSuperNameEn = null; //知识分类英文名
if (objvke_SubEN.KeSubNameEn == "[null]") objvke_SubEN.KeSubNameEn = null; //知识子类英文名
if (objvke_SubEN.KeSuperDescribeCn == "[null]") objvke_SubEN.KeSuperDescribeCn = null; //知识分类描述
if (objvke_SubEN.KeSubDescribeCn == "[null]") objvke_SubEN.KeSubDescribeCn = null; //知识子类描述
if (objvke_SubEN.KeSuperDescribeEn == "[null]") objvke_SubEN.KeSuperDescribeEn = null; //知识分类英文描述
if (objvke_SubEN.KeSubDescribeEn == "[null]") objvke_SubEN.KeSubDescribeEn = null; //知识子类英文描述
if (objvke_SubEN.UpdDate == "[null]") objvke_SubEN.UpdDate = null; //修改日期
if (objvke_SubEN.UpdUser == "[null]") objvke_SubEN.UpdUser = null; //修改人
if (objvke_SubEN.Memo == "[null]") objvke_SubEN.Memo = null; //备注
if (objvke_SubEN.Link == "[null]") objvke_SubEN.Link = null; //相应链接
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
public static void CheckProperty4Condition(clsvke_SubEN objvke_SubEN)
{
 vke_SubDA.CheckProperty4Condition(objvke_SubEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_KeSuperId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convke_Sub.KeSuperId); 
List<clsvke_SubEN> arrObjLst = clsvke_SubBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvke_SubEN objvke_SubEN = new clsvke_SubEN()
{
KeSuperId = "0",
KeSuperNameCn = "选[知识经济子类视图]..."
};
arrObjLst.Insert(0, objvke_SubEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convke_Sub.KeSuperId;
objComboBox.DisplayMember = convke_Sub.KeSuperNameCn;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_KeSuperId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识经济子类视图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convke_Sub.KeSuperId); 
IEnumerable<clsvke_SubEN> arrObjLst = clsvke_SubBL.GetObjLst(strCondition);
objDDL.DataValueField = convke_Sub.KeSuperId;
objDDL.DataTextField = convke_Sub.KeSuperNameCn;
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
public static void BindDdl_KeSubIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识经济子类视图]...","0");
List<clsvke_SubEN> arrvke_SubObjLst = GetAllvke_SubObjLstCache(); 
objDDL.DataValueField = convke_Sub.KeSubId;
objDDL.DataTextField = convke_Sub.KeSuperNameCn;
objDDL.DataSource = arrvke_SubObjLst;
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
if (clske_SubBL.objCommFun4BL == null)
{
strMsg = string.Format("类clske_SubBL没有刷新缓存机制(clske_SubBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clske_SuperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clske_SuperBL没有刷新缓存机制(clske_SuperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by KeSubId");
//if (arrvke_SubObjLstCache == null)
//{
//arrvke_SubObjLstCache = vke_SubDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strKeSubId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvke_SubEN GetObjByKeSubIdCache(string strKeSubId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvke_SubEN._CurrTabName);
List<clsvke_SubEN> arrvke_SubObjLstCache = GetObjLstCache();
IEnumerable <clsvke_SubEN> arrvke_SubObjLst_Sel =
arrvke_SubObjLstCache
.Where(x=> x.KeSubId == strKeSubId 
);
if (arrvke_SubObjLst_Sel.Count() == 0)
{
   clsvke_SubEN obj = clsvke_SubBL.GetObjByKeSubId(strKeSubId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvke_SubObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKeSubId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKeSuperNameCnByKeSubIdCache(string strKeSubId)
{
if (string.IsNullOrEmpty(strKeSubId) == true) return "";
//获取缓存中的对象列表
clsvke_SubEN objvke_Sub = GetObjByKeSubIdCache(strKeSubId);
if (objvke_Sub == null) return "";
return objvke_Sub.KeSuperNameCn;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKeSubId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByKeSubIdCache(string strKeSubId)
{
if (string.IsNullOrEmpty(strKeSubId) == true) return "";
//获取缓存中的对象列表
clsvke_SubEN objvke_Sub = GetObjByKeSubIdCache(strKeSubId);
if (objvke_Sub == null) return "";
return objvke_Sub.KeSuperNameCn;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvke_SubEN> GetAllvke_SubObjLstCache()
{
//获取缓存中的对象列表
List<clsvke_SubEN> arrvke_SubObjLstCache = GetObjLstCache(); 
return arrvke_SubObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvke_SubEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvke_SubEN._CurrTabName);
List<clsvke_SubEN> arrvke_SubObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvke_SubObjLstCache;
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
string strKey = string.Format("{0}", clsvke_SubEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strKeSubId)
{
if (strInFldName != convke_Sub.KeSubId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convke_Sub.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convke_Sub.AttributeName));
throw new Exception(strMsg);
}
var objvke_Sub = clsvke_SubBL.GetObjByKeSubIdCache(strKeSubId);
if (objvke_Sub == null) return "";
return objvke_Sub[strOutFldName].ToString();
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
int intRecCount = clsvke_SubDA.GetRecCount(strTabName);
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
int intRecCount = clsvke_SubDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvke_SubDA.GetRecCount();
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
int intRecCount = clsvke_SubDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvke_SubCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvke_SubEN objvke_SubCond)
{
List<clsvke_SubEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvke_SubEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convke_Sub.AttributeName)
{
if (objvke_SubCond.IsUpdated(strFldName) == false) continue;
if (objvke_SubCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvke_SubCond[strFldName].ToString());
}
else
{
if (objvke_SubCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvke_SubCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvke_SubCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvke_SubCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvke_SubCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvke_SubCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvke_SubCond[strFldName]));
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
 List<string> arrList = clsvke_SubDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vke_SubDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vke_SubDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}