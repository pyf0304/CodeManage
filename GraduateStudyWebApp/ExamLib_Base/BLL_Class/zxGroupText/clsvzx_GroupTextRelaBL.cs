
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupTextRelaBL
 表名:vzx_GroupTextRela(01120867)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
public static class  clsvzx_GroupTextRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strGroupTextRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_GroupTextRelaEN GetObj(this K_GroupTextRelaId_vzx_GroupTextRela myKey)
{
clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = clsvzx_GroupTextRelaBL.vzx_GroupTextRelaDA.GetObjByGroupTextRelaId(myKey.Value);
return objvzx_GroupTextRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetUpdDate(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_GroupTextRela.UpdDate);
}
objvzx_GroupTextRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.UpdDate) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.UpdDate, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.UpdDate] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetMemo(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_GroupTextRela.Memo);
}
objvzx_GroupTextRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.Memo) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.Memo, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.Memo] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetUpdUser(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_GroupTextRela.UpdUser);
}
objvzx_GroupTextRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.UpdUser) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.UpdUser, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.UpdUser] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetTextId(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextId, convzx_GroupTextRela.TextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_GroupTextRela.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_GroupTextRela.TextId);
}
objvzx_GroupTextRelaEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.TextId) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.TextId, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.TextId] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetGroupTextId(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, convzx_GroupTextRela.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_GroupTextRela.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_GroupTextRela.GroupTextId);
}
objvzx_GroupTextRelaEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.GroupTextId) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.GroupTextId, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.GroupTextId] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetGroupTextRelaId(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strGroupTextRelaId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextRelaId, 8, convzx_GroupTextRela.GroupTextRelaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextRelaId, 8, convzx_GroupTextRela.GroupTextRelaId);
}
objvzx_GroupTextRelaEN.GroupTextRelaId = strGroupTextRelaId; //主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.GroupTextRelaId) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.GroupTextRelaId, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.GroupTextRelaId] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetGroupTextName(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_GroupTextRela.GroupTextName);
}
objvzx_GroupTextRelaEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.GroupTextName) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.GroupTextName, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.GroupTextName] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetIdCurrEduCls(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_GroupTextRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_GroupTextRela.IdCurrEduCls);
}
objvzx_GroupTextRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.IdCurrEduCls) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetzxShareId(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_GroupTextRela.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_GroupTextRela.zxShareId);
}
objvzx_GroupTextRelaEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.zxShareId) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.zxShareId, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.zxShareId] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetTextTitle(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_GroupTextRela.TextTitle);
}
objvzx_GroupTextRelaEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.TextTitle) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.TextTitle, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.TextTitle] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetTextContent(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strTextContent, string strComparisonOp="")
	{
objvzx_GroupTextRelaEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.TextContent) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.TextContent, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.TextContent] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetAuthor(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_GroupTextRela.Author);
}
objvzx_GroupTextRelaEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.Author) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.Author, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.Author] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetIsSubmit(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_GroupTextRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.IsSubmit) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.IsSubmit, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.IsSubmit] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetTextTypeId(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strTextTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTypeId, 2, convzx_GroupTextRela.TextTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextTypeId, 2, convzx_GroupTextRela.TextTypeId);
}
objvzx_GroupTextRelaEN.TextTypeId = strTextTypeId; //TextTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.TextTypeId) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.TextTypeId, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.TextTypeId] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetTextStatusId(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strTextStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextStatusId, 2, convzx_GroupTextRela.TextStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextStatusId, 2, convzx_GroupTextRela.TextStatusId);
}
objvzx_GroupTextRelaEN.TextStatusId = strTextStatusId; //TextStatusId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.TextStatusId) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.TextStatusId, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.TextStatusId] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetTextDate(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strTextDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextDate, 50, convzx_GroupTextRela.TextDate);
}
objvzx_GroupTextRelaEN.TextDate = strTextDate; //TextDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.TextDate) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.TextDate, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.TextDate] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupTextRelaEN SetTextUserId(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN, string strTextUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextUserId, 20, convzx_GroupTextRela.TextUserId);
}
objvzx_GroupTextRelaEN.TextUserId = strTextUserId; //TextUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupTextRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupTextRela.TextUserId) == false)
{
objvzx_GroupTextRelaEN.dicFldComparisonOp.Add(convzx_GroupTextRela.TextUserId, strComparisonOp);
}
else
{
objvzx_GroupTextRelaEN.dicFldComparisonOp[convzx_GroupTextRela.TextUserId] = strComparisonOp;
}
}
return objvzx_GroupTextRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaENS">源对象</param>
 /// <param name = "objvzx_GroupTextRelaENT">目标对象</param>
 public static void CopyTo(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENS, clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENT)
{
try
{
objvzx_GroupTextRelaENT.UpdDate = objvzx_GroupTextRelaENS.UpdDate; //修改日期
objvzx_GroupTextRelaENT.Memo = objvzx_GroupTextRelaENS.Memo; //备注
objvzx_GroupTextRelaENT.UpdUser = objvzx_GroupTextRelaENS.UpdUser; //修改人
objvzx_GroupTextRelaENT.TextId = objvzx_GroupTextRelaENS.TextId; //课件Id
objvzx_GroupTextRelaENT.GroupTextId = objvzx_GroupTextRelaENS.GroupTextId; //小组Id
objvzx_GroupTextRelaENT.GroupTextRelaId = objvzx_GroupTextRelaENS.GroupTextRelaId; //主键
objvzx_GroupTextRelaENT.GroupTextName = objvzx_GroupTextRelaENS.GroupTextName; //小组名称
objvzx_GroupTextRelaENT.IdCurrEduCls = objvzx_GroupTextRelaENS.IdCurrEduCls; //教学班流水号
objvzx_GroupTextRelaENT.zxShareId = objvzx_GroupTextRelaENS.zxShareId; //分享Id
objvzx_GroupTextRelaENT.TextTitle = objvzx_GroupTextRelaENS.TextTitle; //TextTitle
objvzx_GroupTextRelaENT.TextContent = objvzx_GroupTextRelaENS.TextContent; //TextContent
objvzx_GroupTextRelaENT.Author = objvzx_GroupTextRelaENS.Author; //作者
objvzx_GroupTextRelaENT.IsSubmit = objvzx_GroupTextRelaENS.IsSubmit; //是否提交
objvzx_GroupTextRelaENT.TextTypeId = objvzx_GroupTextRelaENS.TextTypeId; //TextTypeId
objvzx_GroupTextRelaENT.TextStatusId = objvzx_GroupTextRelaENS.TextStatusId; //TextStatusId
objvzx_GroupTextRelaENT.TextDate = objvzx_GroupTextRelaENS.TextDate; //TextDate
objvzx_GroupTextRelaENT.TextUserId = objvzx_GroupTextRelaENS.TextUserId; //TextUserId
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
 /// <param name = "objvzx_GroupTextRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_GroupTextRelaEN:objvzx_GroupTextRelaENT</returns>
 public static clsvzx_GroupTextRelaEN CopyTo(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENS)
{
try
{
 clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENT = new clsvzx_GroupTextRelaEN()
{
UpdDate = objvzx_GroupTextRelaENS.UpdDate, //修改日期
Memo = objvzx_GroupTextRelaENS.Memo, //备注
UpdUser = objvzx_GroupTextRelaENS.UpdUser, //修改人
TextId = objvzx_GroupTextRelaENS.TextId, //课件Id
GroupTextId = objvzx_GroupTextRelaENS.GroupTextId, //小组Id
GroupTextRelaId = objvzx_GroupTextRelaENS.GroupTextRelaId, //主键
GroupTextName = objvzx_GroupTextRelaENS.GroupTextName, //小组名称
IdCurrEduCls = objvzx_GroupTextRelaENS.IdCurrEduCls, //教学班流水号
zxShareId = objvzx_GroupTextRelaENS.zxShareId, //分享Id
TextTitle = objvzx_GroupTextRelaENS.TextTitle, //TextTitle
TextContent = objvzx_GroupTextRelaENS.TextContent, //TextContent
Author = objvzx_GroupTextRelaENS.Author, //作者
IsSubmit = objvzx_GroupTextRelaENS.IsSubmit, //是否提交
TextTypeId = objvzx_GroupTextRelaENS.TextTypeId, //TextTypeId
TextStatusId = objvzx_GroupTextRelaENS.TextStatusId, //TextStatusId
TextDate = objvzx_GroupTextRelaENS.TextDate, //TextDate
TextUserId = objvzx_GroupTextRelaENS.TextUserId, //TextUserId
};
 return objvzx_GroupTextRelaENT;
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
public static void CheckProperty4Condition(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
 clsvzx_GroupTextRelaBL.vzx_GroupTextRelaDA.CheckProperty4Condition(objvzx_GroupTextRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.UpdDate, objvzx_GroupTextRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.Memo) == true)
{
string strComparisonOpMemo = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.Memo, objvzx_GroupTextRelaCond.Memo, strComparisonOpMemo);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.UpdUser, objvzx_GroupTextRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.TextId) == true)
{
string strComparisonOpTextId = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.TextId, objvzx_GroupTextRelaCond.TextId, strComparisonOpTextId);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.GroupTextId, objvzx_GroupTextRelaCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.GroupTextRelaId) == true)
{
string strComparisonOpGroupTextRelaId = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.GroupTextRelaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.GroupTextRelaId, objvzx_GroupTextRelaCond.GroupTextRelaId, strComparisonOpGroupTextRelaId);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.GroupTextName, objvzx_GroupTextRelaCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.IdCurrEduCls, objvzx_GroupTextRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.zxShareId, objvzx_GroupTextRelaCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.TextTitle, objvzx_GroupTextRelaCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.Author) == true)
{
string strComparisonOpAuthor = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.Author, objvzx_GroupTextRelaCond.Author, strComparisonOpAuthor);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.IsSubmit) == true)
{
if (objvzx_GroupTextRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_GroupTextRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_GroupTextRela.IsSubmit);
}
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.TextTypeId) == true)
{
string strComparisonOpTextTypeId = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.TextTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.TextTypeId, objvzx_GroupTextRelaCond.TextTypeId, strComparisonOpTextTypeId);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.TextStatusId) == true)
{
string strComparisonOpTextStatusId = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.TextStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.TextStatusId, objvzx_GroupTextRelaCond.TextStatusId, strComparisonOpTextStatusId);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.TextDate) == true)
{
string strComparisonOpTextDate = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.TextDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.TextDate, objvzx_GroupTextRelaCond.TextDate, strComparisonOpTextDate);
}
if (objvzx_GroupTextRelaCond.IsUpdated(convzx_GroupTextRela.TextUserId) == true)
{
string strComparisonOpTextUserId = objvzx_GroupTextRelaCond.dicFldComparisonOp[convzx_GroupTextRela.TextUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupTextRela.TextUserId, objvzx_GroupTextRelaCond.TextUserId, strComparisonOpTextUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vzx_GroupTextRela(小组课文关系视图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:GroupTextRelaId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvzx_GroupTextRelaEN == null) return true;
if (objvzx_GroupTextRelaEN.GroupTextRelaId == null || objvzx_GroupTextRelaEN.GroupTextRelaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GroupTextRelaId = '{0}'", objvzx_GroupTextRelaEN.GroupTextRelaId);
if (clsvzx_GroupTextRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("GroupTextRelaId !=  '{0}'", objvzx_GroupTextRelaEN.GroupTextRelaId);
 sbCondition.AppendFormat(" and GroupTextRelaId = '{0}'", objvzx_GroupTextRelaEN.GroupTextRelaId);
if (clsvzx_GroupTextRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vzx_GroupTextRela(小组课文关系视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:GroupTextRelaId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvzx_GroupTextRelaEN == null) return "";
if (objvzx_GroupTextRelaEN.GroupTextRelaId == null || objvzx_GroupTextRelaEN.GroupTextRelaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GroupTextRelaId = '{0}'", objvzx_GroupTextRelaEN.GroupTextRelaId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("GroupTextRelaId !=  '{0}'", objvzx_GroupTextRelaEN.GroupTextRelaId);
 sbCondition.AppendFormat(" and GroupTextRelaId = '{0}'", objvzx_GroupTextRelaEN.GroupTextRelaId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_GroupTextRela
{
public virtual bool UpdRelaTabDate(string strGroupTextRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 小组课文关系视图(vzx_GroupTextRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_GroupTextRelaBL
{
public static RelatedActions_vzx_GroupTextRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_GroupTextRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_GroupTextRelaDA vzx_GroupTextRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_GroupTextRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_GroupTextRelaBL()
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
if (string.IsNullOrEmpty(clsvzx_GroupTextRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_GroupTextRelaEN._ConnectString);
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
public static DataTable GetDataTable_vzx_GroupTextRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_GroupTextRelaDA.GetDataTable_vzx_GroupTextRela(strWhereCond);
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
objDT = vzx_GroupTextRelaDA.GetDataTable(strWhereCond);
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
objDT = vzx_GroupTextRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_GroupTextRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_GroupTextRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_GroupTextRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_GroupTextRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_GroupTextRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_GroupTextRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrGroupTextRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_GroupTextRelaEN> GetObjLstByGroupTextRelaIdLst(List<string> arrGroupTextRelaIdLst)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrGroupTextRelaIdLst, true);
 string strWhereCond = string.Format("GroupTextRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrGroupTextRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_GroupTextRelaEN> GetObjLstByGroupTextRelaIdLstCache(List<string> arrGroupTextRelaIdLst)
{
string strKey = string.Format("{0}", clsvzx_GroupTextRelaEN._CurrTabName);
List<clsvzx_GroupTextRelaEN> arrvzx_GroupTextRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupTextRelaEN> arrvzx_GroupTextRelaObjLst_Sel =
arrvzx_GroupTextRelaObjLstCache
.Where(x => arrGroupTextRelaIdLst.Contains(x.GroupTextRelaId));
return arrvzx_GroupTextRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_GroupTextRelaEN> GetObjLst(string strWhereCond)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
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
public static List<clsvzx_GroupTextRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_GroupTextRelaEN> GetSubObjLstCache(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaCond)
{
List<clsvzx_GroupTextRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupTextRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_GroupTextRela.AttributeName)
{
if (objvzx_GroupTextRelaCond.IsUpdated(strFldName) == false) continue;
if (objvzx_GroupTextRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupTextRelaCond[strFldName].ToString());
}
else
{
if (objvzx_GroupTextRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_GroupTextRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupTextRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_GroupTextRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_GroupTextRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_GroupTextRelaCond[strFldName]));
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
public static List<clsvzx_GroupTextRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
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
public static List<clsvzx_GroupTextRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
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
List<clsvzx_GroupTextRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_GroupTextRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_GroupTextRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_GroupTextRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
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
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
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
public static List<clsvzx_GroupTextRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_GroupTextRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_GroupTextRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
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
public static List<clsvzx_GroupTextRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_GroupTextRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_GroupTextRelaEN> arrObjLst = new List<clsvzx_GroupTextRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = new clsvzx_GroupTextRelaEN();
try
{
objvzx_GroupTextRelaEN.UpdDate = objRow[convzx_GroupTextRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupTextRelaEN.Memo = objRow[convzx_GroupTextRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Memo].ToString().Trim(); //备注
objvzx_GroupTextRelaEN.UpdUser = objRow[convzx_GroupTextRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupTextRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupTextRelaEN.TextId = objRow[convzx_GroupTextRela.TextId].ToString().Trim(); //课件Id
objvzx_GroupTextRelaEN.GroupTextId = objRow[convzx_GroupTextRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupTextRelaEN.GroupTextRelaId = objRow[convzx_GroupTextRela.GroupTextRelaId].ToString().Trim(); //主键
objvzx_GroupTextRelaEN.GroupTextName = objRow[convzx_GroupTextRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupTextRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupTextRelaEN.IdCurrEduCls = objRow[convzx_GroupTextRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_GroupTextRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_GroupTextRelaEN.zxShareId = objRow[convzx_GroupTextRela.zxShareId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.zxShareId].ToString().Trim(); //分享Id
objvzx_GroupTextRelaEN.TextTitle = objRow[convzx_GroupTextRela.TextTitle] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_GroupTextRelaEN.TextContent = objRow[convzx_GroupTextRela.TextContent] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextContent].ToString().Trim(); //TextContent
objvzx_GroupTextRelaEN.Author = objRow[convzx_GroupTextRela.Author] == DBNull.Value ? null : objRow[convzx_GroupTextRela.Author].ToString().Trim(); //作者
objvzx_GroupTextRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupTextRela.IsSubmit].ToString().Trim()); //是否提交
objvzx_GroupTextRelaEN.TextTypeId = objRow[convzx_GroupTextRela.TextTypeId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_GroupTextRelaEN.TextStatusId = objRow[convzx_GroupTextRela.TextStatusId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextStatusId].ToString().Trim(); //TextStatusId
objvzx_GroupTextRelaEN.TextDate = objRow[convzx_GroupTextRela.TextDate] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextDate].ToString().Trim(); //TextDate
objvzx_GroupTextRelaEN.TextUserId = objRow[convzx_GroupTextRela.TextUserId] == DBNull.Value ? null : objRow[convzx_GroupTextRela.TextUserId].ToString().Trim(); //TextUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupTextRelaEN.GroupTextRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupTextRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_GroupTextRela(ref clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
bool bolResult = vzx_GroupTextRelaDA.Getvzx_GroupTextRela(ref objvzx_GroupTextRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strGroupTextRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_GroupTextRelaEN GetObjByGroupTextRelaId(string strGroupTextRelaId)
{
if (strGroupTextRelaId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strGroupTextRelaId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strGroupTextRelaId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strGroupTextRelaId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = vzx_GroupTextRelaDA.GetObjByGroupTextRelaId(strGroupTextRelaId);
return objvzx_GroupTextRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_GroupTextRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = vzx_GroupTextRelaDA.GetFirstObj(strWhereCond);
 return objvzx_GroupTextRelaEN;
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
public static clsvzx_GroupTextRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = vzx_GroupTextRelaDA.GetObjByDataRow(objRow);
 return objvzx_GroupTextRelaEN;
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
public static clsvzx_GroupTextRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN = vzx_GroupTextRelaDA.GetObjByDataRow(objRow);
 return objvzx_GroupTextRelaEN;
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
 /// <param name = "strGroupTextRelaId">所给的关键字</param>
 /// <param name = "lstvzx_GroupTextRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_GroupTextRelaEN GetObjByGroupTextRelaIdFromList(string strGroupTextRelaId, List<clsvzx_GroupTextRelaEN> lstvzx_GroupTextRelaObjLst)
{
foreach (clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN in lstvzx_GroupTextRelaObjLst)
{
if (objvzx_GroupTextRelaEN.GroupTextRelaId == strGroupTextRelaId)
{
return objvzx_GroupTextRelaEN;
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
 string strMaxGroupTextRelaId;
 try
 {
 strMaxGroupTextRelaId = clsvzx_GroupTextRelaDA.GetMaxStrId();
 return strMaxGroupTextRelaId;
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
 string strGroupTextRelaId;
 try
 {
 strGroupTextRelaId = new clsvzx_GroupTextRelaDA().GetFirstID(strWhereCond);
 return strGroupTextRelaId;
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
 arrList = vzx_GroupTextRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_GroupTextRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strGroupTextRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strGroupTextRelaId)
{
if (string.IsNullOrEmpty(strGroupTextRelaId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strGroupTextRelaId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_GroupTextRelaDA.IsExist(strGroupTextRelaId);
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
 bolIsExist = clsvzx_GroupTextRelaDA.IsExistTable();
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
 bolIsExist = vzx_GroupTextRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_GroupTextRelaENS">源对象</param>
 /// <param name = "objvzx_GroupTextRelaENT">目标对象</param>
 public static void CopyTo(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENS, clsvzx_GroupTextRelaEN objvzx_GroupTextRelaENT)
{
try
{
objvzx_GroupTextRelaENT.UpdDate = objvzx_GroupTextRelaENS.UpdDate; //修改日期
objvzx_GroupTextRelaENT.Memo = objvzx_GroupTextRelaENS.Memo; //备注
objvzx_GroupTextRelaENT.UpdUser = objvzx_GroupTextRelaENS.UpdUser; //修改人
objvzx_GroupTextRelaENT.TextId = objvzx_GroupTextRelaENS.TextId; //课件Id
objvzx_GroupTextRelaENT.GroupTextId = objvzx_GroupTextRelaENS.GroupTextId; //小组Id
objvzx_GroupTextRelaENT.GroupTextRelaId = objvzx_GroupTextRelaENS.GroupTextRelaId; //主键
objvzx_GroupTextRelaENT.GroupTextName = objvzx_GroupTextRelaENS.GroupTextName; //小组名称
objvzx_GroupTextRelaENT.IdCurrEduCls = objvzx_GroupTextRelaENS.IdCurrEduCls; //教学班流水号
objvzx_GroupTextRelaENT.zxShareId = objvzx_GroupTextRelaENS.zxShareId; //分享Id
objvzx_GroupTextRelaENT.TextTitle = objvzx_GroupTextRelaENS.TextTitle; //TextTitle
objvzx_GroupTextRelaENT.TextContent = objvzx_GroupTextRelaENS.TextContent; //TextContent
objvzx_GroupTextRelaENT.Author = objvzx_GroupTextRelaENS.Author; //作者
objvzx_GroupTextRelaENT.IsSubmit = objvzx_GroupTextRelaENS.IsSubmit; //是否提交
objvzx_GroupTextRelaENT.TextTypeId = objvzx_GroupTextRelaENS.TextTypeId; //TextTypeId
objvzx_GroupTextRelaENT.TextStatusId = objvzx_GroupTextRelaENS.TextStatusId; //TextStatusId
objvzx_GroupTextRelaENT.TextDate = objvzx_GroupTextRelaENS.TextDate; //TextDate
objvzx_GroupTextRelaENT.TextUserId = objvzx_GroupTextRelaENS.TextUserId; //TextUserId
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
 /// <param name = "objvzx_GroupTextRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
try
{
objvzx_GroupTextRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_GroupTextRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_GroupTextRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.UpdDate = objvzx_GroupTextRelaEN.UpdDate == "[null]" ? null :  objvzx_GroupTextRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_GroupTextRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.Memo = objvzx_GroupTextRelaEN.Memo == "[null]" ? null :  objvzx_GroupTextRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_GroupTextRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.UpdUser = objvzx_GroupTextRelaEN.UpdUser == "[null]" ? null :  objvzx_GroupTextRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_GroupTextRela.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.TextId = objvzx_GroupTextRelaEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_GroupTextRela.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.GroupTextId = objvzx_GroupTextRelaEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_GroupTextRela.GroupTextRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.GroupTextRelaId = objvzx_GroupTextRelaEN.GroupTextRelaId; //主键
}
if (arrFldSet.Contains(convzx_GroupTextRela.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.GroupTextName = objvzx_GroupTextRelaEN.GroupTextName == "[null]" ? null :  objvzx_GroupTextRelaEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_GroupTextRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.IdCurrEduCls = objvzx_GroupTextRelaEN.IdCurrEduCls == "[null]" ? null :  objvzx_GroupTextRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_GroupTextRela.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.zxShareId = objvzx_GroupTextRelaEN.zxShareId == "[null]" ? null :  objvzx_GroupTextRelaEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_GroupTextRela.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.TextTitle = objvzx_GroupTextRelaEN.TextTitle == "[null]" ? null :  objvzx_GroupTextRelaEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_GroupTextRela.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.TextContent = objvzx_GroupTextRelaEN.TextContent == "[null]" ? null :  objvzx_GroupTextRelaEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_GroupTextRela.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.Author = objvzx_GroupTextRelaEN.Author == "[null]" ? null :  objvzx_GroupTextRelaEN.Author; //作者
}
if (arrFldSet.Contains(convzx_GroupTextRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.IsSubmit = objvzx_GroupTextRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_GroupTextRela.TextTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.TextTypeId = objvzx_GroupTextRelaEN.TextTypeId == "[null]" ? null :  objvzx_GroupTextRelaEN.TextTypeId; //TextTypeId
}
if (arrFldSet.Contains(convzx_GroupTextRela.TextStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.TextStatusId = objvzx_GroupTextRelaEN.TextStatusId == "[null]" ? null :  objvzx_GroupTextRelaEN.TextStatusId; //TextStatusId
}
if (arrFldSet.Contains(convzx_GroupTextRela.TextDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.TextDate = objvzx_GroupTextRelaEN.TextDate == "[null]" ? null :  objvzx_GroupTextRelaEN.TextDate; //TextDate
}
if (arrFldSet.Contains(convzx_GroupTextRela.TextUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupTextRelaEN.TextUserId = objvzx_GroupTextRelaEN.TextUserId == "[null]" ? null :  objvzx_GroupTextRelaEN.TextUserId; //TextUserId
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
 /// <param name = "objvzx_GroupTextRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
try
{
if (objvzx_GroupTextRelaEN.UpdDate == "[null]") objvzx_GroupTextRelaEN.UpdDate = null; //修改日期
if (objvzx_GroupTextRelaEN.Memo == "[null]") objvzx_GroupTextRelaEN.Memo = null; //备注
if (objvzx_GroupTextRelaEN.UpdUser == "[null]") objvzx_GroupTextRelaEN.UpdUser = null; //修改人
if (objvzx_GroupTextRelaEN.GroupTextName == "[null]") objvzx_GroupTextRelaEN.GroupTextName = null; //小组名称
if (objvzx_GroupTextRelaEN.IdCurrEduCls == "[null]") objvzx_GroupTextRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_GroupTextRelaEN.zxShareId == "[null]") objvzx_GroupTextRelaEN.zxShareId = null; //分享Id
if (objvzx_GroupTextRelaEN.TextTitle == "[null]") objvzx_GroupTextRelaEN.TextTitle = null; //TextTitle
if (objvzx_GroupTextRelaEN.TextContent == "[null]") objvzx_GroupTextRelaEN.TextContent = null; //TextContent
if (objvzx_GroupTextRelaEN.Author == "[null]") objvzx_GroupTextRelaEN.Author = null; //作者
if (objvzx_GroupTextRelaEN.TextTypeId == "[null]") objvzx_GroupTextRelaEN.TextTypeId = null; //TextTypeId
if (objvzx_GroupTextRelaEN.TextStatusId == "[null]") objvzx_GroupTextRelaEN.TextStatusId = null; //TextStatusId
if (objvzx_GroupTextRelaEN.TextDate == "[null]") objvzx_GroupTextRelaEN.TextDate = null; //TextDate
if (objvzx_GroupTextRelaEN.TextUserId == "[null]") objvzx_GroupTextRelaEN.TextUserId = null; //TextUserId
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
public static void CheckProperty4Condition(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
 vzx_GroupTextRelaDA.CheckProperty4Condition(objvzx_GroupTextRelaEN);
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
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_GroupTextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextBL没有刷新缓存机制(clszx_GroupTextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_GroupTextRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextRelaBL没有刷新缓存机制(clszx_GroupTextRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by GroupTextRelaId");
//if (arrvzx_GroupTextRelaObjLstCache == null)
//{
//arrvzx_GroupTextRelaObjLstCache = vzx_GroupTextRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strGroupTextRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_GroupTextRelaEN GetObjByGroupTextRelaIdCache(string strGroupTextRelaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_GroupTextRelaEN._CurrTabName);
List<clsvzx_GroupTextRelaEN> arrvzx_GroupTextRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupTextRelaEN> arrvzx_GroupTextRelaObjLst_Sel =
arrvzx_GroupTextRelaObjLstCache
.Where(x=> x.GroupTextRelaId == strGroupTextRelaId 
);
if (arrvzx_GroupTextRelaObjLst_Sel.Count() == 0)
{
   clsvzx_GroupTextRelaEN obj = clsvzx_GroupTextRelaBL.GetObjByGroupTextRelaId(strGroupTextRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_GroupTextRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_GroupTextRelaEN> GetAllvzx_GroupTextRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_GroupTextRelaEN> arrvzx_GroupTextRelaObjLstCache = GetObjLstCache(); 
return arrvzx_GroupTextRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_GroupTextRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_GroupTextRelaEN._CurrTabName);
List<clsvzx_GroupTextRelaEN> arrvzx_GroupTextRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_GroupTextRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_GroupTextRelaEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vzx_GroupTextRela(小组课文关系视图)
 /// 唯一性条件:GroupTextRelaId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaEN)
{
//检测记录是否存在
string strResult = vzx_GroupTextRelaDA.GetUniCondStr(objvzx_GroupTextRelaEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strGroupTextRelaId)
{
if (strInFldName != convzx_GroupTextRela.GroupTextRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_GroupTextRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_GroupTextRela.AttributeName));
throw new Exception(strMsg);
}
var objvzx_GroupTextRela = clsvzx_GroupTextRelaBL.GetObjByGroupTextRelaIdCache(strGroupTextRelaId);
if (objvzx_GroupTextRela == null) return "";
return objvzx_GroupTextRela[strOutFldName].ToString();
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
int intRecCount = clsvzx_GroupTextRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_GroupTextRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_GroupTextRelaDA.GetRecCount();
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
int intRecCount = clsvzx_GroupTextRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_GroupTextRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_GroupTextRelaEN objvzx_GroupTextRelaCond)
{
List<clsvzx_GroupTextRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupTextRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_GroupTextRela.AttributeName)
{
if (objvzx_GroupTextRelaCond.IsUpdated(strFldName) == false) continue;
if (objvzx_GroupTextRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupTextRelaCond[strFldName].ToString());
}
else
{
if (objvzx_GroupTextRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_GroupTextRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupTextRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_GroupTextRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_GroupTextRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_GroupTextRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_GroupTextRelaCond[strFldName]));
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
 List<string> arrList = clsvzx_GroupTextRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_GroupTextRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_GroupTextRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}