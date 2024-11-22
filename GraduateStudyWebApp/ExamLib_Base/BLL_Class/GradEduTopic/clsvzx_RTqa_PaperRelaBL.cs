
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_RTqa_PaperRelaBL
 表名:vzx_RTqa_PaperRela(01120875)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:04
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
public static class  clsvzx_RTqa_PaperRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_RTqa_PaperRelaEN GetObj(this K_mId_vzx_RTqa_PaperRela myKey)
{
clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = clsvzx_RTqa_PaperRelaBL.vzx_RTqa_PaperRelaDA.GetObjBymId(myKey.Value);
return objvzx_RTqa_PaperRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetmId(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, long lngmId, string strComparisonOp="")
	{
objvzx_RTqa_PaperRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.mId) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.mId, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.mId] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetMemo(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_RTqa_PaperRela.Memo);
}
objvzx_RTqa_PaperRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.Memo) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.Memo, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.Memo] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetUpdUser(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_RTqa_PaperRela.UpdUser);
}
objvzx_RTqa_PaperRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.UpdUser) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.UpdUser, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.UpdUser] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetUpdDate(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_RTqa_PaperRela.UpdDate);
}
objvzx_RTqa_PaperRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.UpdDate) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.UpdDate, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.UpdDate] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetQaPaperId(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strQaPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQaPaperId, convzx_RTqa_PaperRela.QaPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQaPaperId, 8, convzx_RTqa_PaperRela.QaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQaPaperId, 8, convzx_RTqa_PaperRela.QaPaperId);
}
objvzx_RTqa_PaperRelaEN.QaPaperId = strQaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.QaPaperId) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.QaPaperId, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.QaPaperId] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetGroupTextId(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, convzx_RTqa_PaperRela.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_RTqa_PaperRela.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_RTqa_PaperRela.GroupTextId);
}
objvzx_RTqa_PaperRelaEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.GroupTextId) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.GroupTextId, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.GroupTextId] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetGroupTextName(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_RTqa_PaperRela.GroupTextName);
}
objvzx_RTqa_PaperRelaEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.GroupTextName) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.GroupTextName, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.GroupTextName] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetIdCurrEduCls(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_RTqa_PaperRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_RTqa_PaperRela.IdCurrEduCls);
}
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.IdCurrEduCls) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetTextId(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_RTqa_PaperRela.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_RTqa_PaperRela.TextId);
}
objvzx_RTqa_PaperRelaEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.TextId) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.TextId, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.TextId] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetzxShareId(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_RTqa_PaperRela.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_RTqa_PaperRela.zxShareId);
}
objvzx_RTqa_PaperRelaEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.zxShareId) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.zxShareId, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.zxShareId] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetTagsCount(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, int? intTagsCount, string strComparisonOp="")
	{
objvzx_RTqa_PaperRelaEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.TagsCount) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.TagsCount, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.TagsCount] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetAnswerCount(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, int? intAnswerCount, string strComparisonOp="")
	{
objvzx_RTqa_PaperRelaEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.AnswerCount) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.AnswerCount, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.AnswerCount] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetTextTitle(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_RTqa_PaperRela.TextTitle);
}
objvzx_RTqa_PaperRelaEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.TextTitle) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.TextTitle, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.TextTitle] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetTextContent(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strTextContent, string strComparisonOp="")
	{
objvzx_RTqa_PaperRelaEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.TextContent) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.TextContent, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.TextContent] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetMajorName(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convzx_RTqa_PaperRela.MajorName);
}
objvzx_RTqa_PaperRelaEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.MajorName) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.MajorName, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.MajorName] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetUserName(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_RTqa_PaperRela.UserName);
}
objvzx_RTqa_PaperRelaEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.UserName) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.UserName, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.UserName] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetAttachmentCount(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvzx_RTqa_PaperRelaEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.AttachmentCount) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.AttachmentCount, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.AttachmentCount] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_RTqa_PaperRelaEN SetQuestionsCount(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN, int? intQuestionsCount, string strComparisonOp="")
	{
objvzx_RTqa_PaperRelaEN.QuestionsCount = intQuestionsCount; //提问计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convzx_RTqa_PaperRela.QuestionsCount) == false)
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convzx_RTqa_PaperRela.QuestionsCount, strComparisonOp);
}
else
{
objvzx_RTqa_PaperRelaEN.dicFldComparisonOp[convzx_RTqa_PaperRela.QuestionsCount] = strComparisonOp;
}
}
return objvzx_RTqa_PaperRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaENS">源对象</param>
 /// <param name = "objvzx_RTqa_PaperRelaENT">目标对象</param>
 public static void CopyTo(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENS, clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENT)
{
try
{
objvzx_RTqa_PaperRelaENT.mId = objvzx_RTqa_PaperRelaENS.mId; //mId
objvzx_RTqa_PaperRelaENT.Memo = objvzx_RTqa_PaperRelaENS.Memo; //备注
objvzx_RTqa_PaperRelaENT.UpdUser = objvzx_RTqa_PaperRelaENS.UpdUser; //修改人
objvzx_RTqa_PaperRelaENT.UpdDate = objvzx_RTqa_PaperRelaENS.UpdDate; //修改日期
objvzx_RTqa_PaperRelaENT.QaPaperId = objvzx_RTqa_PaperRelaENS.QaPaperId; //论文答疑Id
objvzx_RTqa_PaperRelaENT.GroupTextId = objvzx_RTqa_PaperRelaENS.GroupTextId; //小组Id
objvzx_RTqa_PaperRelaENT.GroupTextName = objvzx_RTqa_PaperRelaENS.GroupTextName; //小组名称
objvzx_RTqa_PaperRelaENT.IdCurrEduCls = objvzx_RTqa_PaperRelaENS.IdCurrEduCls; //教学班流水号
objvzx_RTqa_PaperRelaENT.TextId = objvzx_RTqa_PaperRelaENS.TextId; //课件Id
objvzx_RTqa_PaperRelaENT.zxShareId = objvzx_RTqa_PaperRelaENS.zxShareId; //分享Id
objvzx_RTqa_PaperRelaENT.TagsCount = objvzx_RTqa_PaperRelaENS.TagsCount; //论文标注数
objvzx_RTqa_PaperRelaENT.AnswerCount = objvzx_RTqa_PaperRelaENS.AnswerCount; //回答计数
objvzx_RTqa_PaperRelaENT.TextTitle = objvzx_RTqa_PaperRelaENS.TextTitle; //TextTitle
objvzx_RTqa_PaperRelaENT.TextContent = objvzx_RTqa_PaperRelaENS.TextContent; //TextContent
objvzx_RTqa_PaperRelaENT.MajorName = objvzx_RTqa_PaperRelaENS.MajorName; //专业名称
objvzx_RTqa_PaperRelaENT.UserName = objvzx_RTqa_PaperRelaENS.UserName; //用户名
objvzx_RTqa_PaperRelaENT.AttachmentCount = objvzx_RTqa_PaperRelaENS.AttachmentCount; //附件计数
objvzx_RTqa_PaperRelaENT.QuestionsCount = objvzx_RTqa_PaperRelaENS.QuestionsCount; //提问计数
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
 /// <param name = "objvzx_RTqa_PaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_RTqa_PaperRelaEN:objvzx_RTqa_PaperRelaENT</returns>
 public static clsvzx_RTqa_PaperRelaEN CopyTo(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENS)
{
try
{
 clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENT = new clsvzx_RTqa_PaperRelaEN()
{
mId = objvzx_RTqa_PaperRelaENS.mId, //mId
Memo = objvzx_RTqa_PaperRelaENS.Memo, //备注
UpdUser = objvzx_RTqa_PaperRelaENS.UpdUser, //修改人
UpdDate = objvzx_RTqa_PaperRelaENS.UpdDate, //修改日期
QaPaperId = objvzx_RTqa_PaperRelaENS.QaPaperId, //论文答疑Id
GroupTextId = objvzx_RTqa_PaperRelaENS.GroupTextId, //小组Id
GroupTextName = objvzx_RTqa_PaperRelaENS.GroupTextName, //小组名称
IdCurrEduCls = objvzx_RTqa_PaperRelaENS.IdCurrEduCls, //教学班流水号
TextId = objvzx_RTqa_PaperRelaENS.TextId, //课件Id
zxShareId = objvzx_RTqa_PaperRelaENS.zxShareId, //分享Id
TagsCount = objvzx_RTqa_PaperRelaENS.TagsCount, //论文标注数
AnswerCount = objvzx_RTqa_PaperRelaENS.AnswerCount, //回答计数
TextTitle = objvzx_RTqa_PaperRelaENS.TextTitle, //TextTitle
TextContent = objvzx_RTqa_PaperRelaENS.TextContent, //TextContent
MajorName = objvzx_RTqa_PaperRelaENS.MajorName, //专业名称
UserName = objvzx_RTqa_PaperRelaENS.UserName, //用户名
AttachmentCount = objvzx_RTqa_PaperRelaENS.AttachmentCount, //附件计数
QuestionsCount = objvzx_RTqa_PaperRelaENS.QuestionsCount, //提问计数
};
 return objvzx_RTqa_PaperRelaENT;
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
public static void CheckProperty4Condition(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN)
{
 clsvzx_RTqa_PaperRelaBL.vzx_RTqa_PaperRelaDA.CheckProperty4Condition(objvzx_RTqa_PaperRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.mId) == true)
{
string strComparisonOpmId = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_RTqa_PaperRela.mId, objvzx_RTqa_PaperRelaCond.mId, strComparisonOpmId);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.Memo) == true)
{
string strComparisonOpMemo = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.Memo, objvzx_RTqa_PaperRelaCond.Memo, strComparisonOpMemo);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.UpdUser, objvzx_RTqa_PaperRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.UpdDate, objvzx_RTqa_PaperRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.QaPaperId) == true)
{
string strComparisonOpQaPaperId = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.QaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.QaPaperId, objvzx_RTqa_PaperRelaCond.QaPaperId, strComparisonOpQaPaperId);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.GroupTextId, objvzx_RTqa_PaperRelaCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.GroupTextName, objvzx_RTqa_PaperRelaCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.IdCurrEduCls, objvzx_RTqa_PaperRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.TextId) == true)
{
string strComparisonOpTextId = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.TextId, objvzx_RTqa_PaperRelaCond.TextId, strComparisonOpTextId);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.zxShareId, objvzx_RTqa_PaperRelaCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.TagsCount) == true)
{
string strComparisonOpTagsCount = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_RTqa_PaperRela.TagsCount, objvzx_RTqa_PaperRelaCond.TagsCount, strComparisonOpTagsCount);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_RTqa_PaperRela.AnswerCount, objvzx_RTqa_PaperRelaCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.TextTitle, objvzx_RTqa_PaperRelaCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.MajorName) == true)
{
string strComparisonOpMajorName = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.MajorName, objvzx_RTqa_PaperRelaCond.MajorName, strComparisonOpMajorName);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.UserName) == true)
{
string strComparisonOpUserName = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_RTqa_PaperRela.UserName, objvzx_RTqa_PaperRelaCond.UserName, strComparisonOpUserName);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_RTqa_PaperRela.AttachmentCount, objvzx_RTqa_PaperRelaCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvzx_RTqa_PaperRelaCond.IsUpdated(convzx_RTqa_PaperRela.QuestionsCount) == true)
{
string strComparisonOpQuestionsCount = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[convzx_RTqa_PaperRela.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_RTqa_PaperRela.QuestionsCount, objvzx_RTqa_PaperRelaCond.QuestionsCount, strComparisonOpQuestionsCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_RTqa_PaperRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_RTqa_PaperRela(vzx_RTqa_PaperRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_RTqa_PaperRelaBL
{
public static RelatedActions_vzx_RTqa_PaperRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_RTqa_PaperRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_RTqa_PaperRelaDA vzx_RTqa_PaperRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_RTqa_PaperRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_RTqa_PaperRelaBL()
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
if (string.IsNullOrEmpty(clsvzx_RTqa_PaperRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_RTqa_PaperRelaEN._ConnectString);
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
public static DataTable GetDataTable_vzx_RTqa_PaperRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_RTqa_PaperRelaDA.GetDataTable_vzx_RTqa_PaperRela(strWhereCond);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTable(strWhereCond);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_RTqa_PaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
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
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_RTqa_PaperRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvzx_RTqa_PaperRelaEN._CurrTabName);
List<clsvzx_RTqa_PaperRelaEN> arrvzx_RTqa_PaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_RTqa_PaperRelaEN> arrvzx_RTqa_PaperRelaObjLst_Sel =
arrvzx_RTqa_PaperRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvzx_RTqa_PaperRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLst(string strWhereCond)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
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
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_RTqa_PaperRelaEN> GetSubObjLstCache(clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaCond)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_RTqa_PaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_RTqa_PaperRela.AttributeName)
{
if (objvzx_RTqa_PaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvzx_RTqa_PaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_RTqa_PaperRelaCond[strFldName].ToString());
}
else
{
if (objvzx_RTqa_PaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_RTqa_PaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_RTqa_PaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_RTqa_PaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_RTqa_PaperRelaCond[strFldName]));
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
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
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
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
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
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_RTqa_PaperRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_RTqa_PaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
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
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
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
public static List<clsvzx_RTqa_PaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
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
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLst = new List<clsvzx_RTqa_PaperRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = new clsvzx_RTqa_PaperRelaEN();
try
{
objvzx_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convzx_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvzx_RTqa_PaperRelaEN.Memo = objRow[convzx_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvzx_RTqa_PaperRelaEN.UpdUser = objRow[convzx_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvzx_RTqa_PaperRelaEN.UpdDate = objRow[convzx_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvzx_RTqa_PaperRelaEN.QaPaperId = objRow[convzx_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvzx_RTqa_PaperRelaEN.GroupTextId = objRow[convzx_RTqa_PaperRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_RTqa_PaperRelaEN.GroupTextName = objRow[convzx_RTqa_PaperRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convzx_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_RTqa_PaperRelaEN.TextId = objRow[convzx_RTqa_PaperRela.TextId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextId].ToString().Trim(); //课件Id
objvzx_RTqa_PaperRelaEN.zxShareId = objRow[convzx_RTqa_PaperRela.zxShareId] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.zxShareId].ToString().Trim(); //分享Id
objvzx_RTqa_PaperRelaEN.TagsCount = objRow[convzx_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvzx_RTqa_PaperRelaEN.AnswerCount = objRow[convzx_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_RTqa_PaperRelaEN.TextTitle = objRow[convzx_RTqa_PaperRela.TextTitle] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextTitle].ToString().Trim(); //TextTitle
objvzx_RTqa_PaperRelaEN.TextContent = objRow[convzx_RTqa_PaperRela.TextContent] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.TextContent].ToString().Trim(); //TextContent
objvzx_RTqa_PaperRelaEN.MajorName = objRow[convzx_RTqa_PaperRela.MajorName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.MajorName].ToString().Trim(); //专业名称
objvzx_RTqa_PaperRelaEN.UserName = objRow[convzx_RTqa_PaperRela.UserName] == DBNull.Value ? null : objRow[convzx_RTqa_PaperRela.UserName].ToString().Trim(); //用户名
objvzx_RTqa_PaperRelaEN.AttachmentCount = objRow[convzx_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvzx_RTqa_PaperRelaEN.QuestionsCount = objRow[convzx_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_RTqa_PaperRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_RTqa_PaperRela(ref clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN)
{
bool bolResult = vzx_RTqa_PaperRelaDA.Getvzx_RTqa_PaperRela(ref objvzx_RTqa_PaperRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_RTqa_PaperRelaEN GetObjBymId(long lngmId)
{
clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = vzx_RTqa_PaperRelaDA.GetObjBymId(lngmId);
return objvzx_RTqa_PaperRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_RTqa_PaperRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = vzx_RTqa_PaperRelaDA.GetFirstObj(strWhereCond);
 return objvzx_RTqa_PaperRelaEN;
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
public static clsvzx_RTqa_PaperRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = vzx_RTqa_PaperRelaDA.GetObjByDataRow(objRow);
 return objvzx_RTqa_PaperRelaEN;
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
public static clsvzx_RTqa_PaperRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN = vzx_RTqa_PaperRelaDA.GetObjByDataRow(objRow);
 return objvzx_RTqa_PaperRelaEN;
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
 /// <param name = "lstvzx_RTqa_PaperRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_RTqa_PaperRelaEN GetObjBymIdFromList(long lngmId, List<clsvzx_RTqa_PaperRelaEN> lstvzx_RTqa_PaperRelaObjLst)
{
foreach (clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN in lstvzx_RTqa_PaperRelaObjLst)
{
if (objvzx_RTqa_PaperRelaEN.mId == lngmId)
{
return objvzx_RTqa_PaperRelaEN;
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
 lngmId = new clsvzx_RTqa_PaperRelaDA().GetFirstID(strWhereCond);
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
 arrList = vzx_RTqa_PaperRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_RTqa_PaperRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vzx_RTqa_PaperRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvzx_RTqa_PaperRelaDA.IsExistTable();
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
 bolIsExist = vzx_RTqa_PaperRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_RTqa_PaperRelaENS">源对象</param>
 /// <param name = "objvzx_RTqa_PaperRelaENT">目标对象</param>
 public static void CopyTo(clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENS, clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaENT)
{
try
{
objvzx_RTqa_PaperRelaENT.mId = objvzx_RTqa_PaperRelaENS.mId; //mId
objvzx_RTqa_PaperRelaENT.Memo = objvzx_RTqa_PaperRelaENS.Memo; //备注
objvzx_RTqa_PaperRelaENT.UpdUser = objvzx_RTqa_PaperRelaENS.UpdUser; //修改人
objvzx_RTqa_PaperRelaENT.UpdDate = objvzx_RTqa_PaperRelaENS.UpdDate; //修改日期
objvzx_RTqa_PaperRelaENT.QaPaperId = objvzx_RTqa_PaperRelaENS.QaPaperId; //论文答疑Id
objvzx_RTqa_PaperRelaENT.GroupTextId = objvzx_RTqa_PaperRelaENS.GroupTextId; //小组Id
objvzx_RTqa_PaperRelaENT.GroupTextName = objvzx_RTqa_PaperRelaENS.GroupTextName; //小组名称
objvzx_RTqa_PaperRelaENT.IdCurrEduCls = objvzx_RTqa_PaperRelaENS.IdCurrEduCls; //教学班流水号
objvzx_RTqa_PaperRelaENT.TextId = objvzx_RTqa_PaperRelaENS.TextId; //课件Id
objvzx_RTqa_PaperRelaENT.zxShareId = objvzx_RTqa_PaperRelaENS.zxShareId; //分享Id
objvzx_RTqa_PaperRelaENT.TagsCount = objvzx_RTqa_PaperRelaENS.TagsCount; //论文标注数
objvzx_RTqa_PaperRelaENT.AnswerCount = objvzx_RTqa_PaperRelaENS.AnswerCount; //回答计数
objvzx_RTqa_PaperRelaENT.TextTitle = objvzx_RTqa_PaperRelaENS.TextTitle; //TextTitle
objvzx_RTqa_PaperRelaENT.TextContent = objvzx_RTqa_PaperRelaENS.TextContent; //TextContent
objvzx_RTqa_PaperRelaENT.MajorName = objvzx_RTqa_PaperRelaENS.MajorName; //专业名称
objvzx_RTqa_PaperRelaENT.UserName = objvzx_RTqa_PaperRelaENS.UserName; //用户名
objvzx_RTqa_PaperRelaENT.AttachmentCount = objvzx_RTqa_PaperRelaENS.AttachmentCount; //附件计数
objvzx_RTqa_PaperRelaENT.QuestionsCount = objvzx_RTqa_PaperRelaENS.QuestionsCount; //提问计数
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
 /// <param name = "objvzx_RTqa_PaperRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN)
{
try
{
objvzx_RTqa_PaperRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_RTqa_PaperRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_RTqa_PaperRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.mId = objvzx_RTqa_PaperRelaEN.mId; //mId
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.Memo = objvzx_RTqa_PaperRelaEN.Memo == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.UpdUser = objvzx_RTqa_PaperRelaEN.UpdUser == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.UpdDate = objvzx_RTqa_PaperRelaEN.UpdDate == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.QaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.QaPaperId = objvzx_RTqa_PaperRelaEN.QaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.GroupTextId = objvzx_RTqa_PaperRelaEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.GroupTextName = objvzx_RTqa_PaperRelaEN.GroupTextName == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.IdCurrEduCls = objvzx_RTqa_PaperRelaEN.IdCurrEduCls == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.TextId = objvzx_RTqa_PaperRelaEN.TextId == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.zxShareId = objvzx_RTqa_PaperRelaEN.zxShareId == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.TagsCount = objvzx_RTqa_PaperRelaEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.AnswerCount = objvzx_RTqa_PaperRelaEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.TextTitle = objvzx_RTqa_PaperRelaEN.TextTitle == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.TextContent = objvzx_RTqa_PaperRelaEN.TextContent == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.MajorName = objvzx_RTqa_PaperRelaEN.MajorName == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.UserName = objvzx_RTqa_PaperRelaEN.UserName == "[null]" ? null :  objvzx_RTqa_PaperRelaEN.UserName; //用户名
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.AttachmentCount = objvzx_RTqa_PaperRelaEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convzx_RTqa_PaperRela.QuestionsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_RTqa_PaperRelaEN.QuestionsCount = objvzx_RTqa_PaperRelaEN.QuestionsCount; //提问计数
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
 /// <param name = "objvzx_RTqa_PaperRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN)
{
try
{
if (objvzx_RTqa_PaperRelaEN.Memo == "[null]") objvzx_RTqa_PaperRelaEN.Memo = null; //备注
if (objvzx_RTqa_PaperRelaEN.UpdUser == "[null]") objvzx_RTqa_PaperRelaEN.UpdUser = null; //修改人
if (objvzx_RTqa_PaperRelaEN.UpdDate == "[null]") objvzx_RTqa_PaperRelaEN.UpdDate = null; //修改日期
if (objvzx_RTqa_PaperRelaEN.GroupTextName == "[null]") objvzx_RTqa_PaperRelaEN.GroupTextName = null; //小组名称
if (objvzx_RTqa_PaperRelaEN.IdCurrEduCls == "[null]") objvzx_RTqa_PaperRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_RTqa_PaperRelaEN.TextId == "[null]") objvzx_RTqa_PaperRelaEN.TextId = null; //课件Id
if (objvzx_RTqa_PaperRelaEN.zxShareId == "[null]") objvzx_RTqa_PaperRelaEN.zxShareId = null; //分享Id
if (objvzx_RTqa_PaperRelaEN.TextTitle == "[null]") objvzx_RTqa_PaperRelaEN.TextTitle = null; //TextTitle
if (objvzx_RTqa_PaperRelaEN.TextContent == "[null]") objvzx_RTqa_PaperRelaEN.TextContent = null; //TextContent
if (objvzx_RTqa_PaperRelaEN.MajorName == "[null]") objvzx_RTqa_PaperRelaEN.MajorName = null; //专业名称
if (objvzx_RTqa_PaperRelaEN.UserName == "[null]") objvzx_RTqa_PaperRelaEN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaEN)
{
 vzx_RTqa_PaperRelaDA.CheckProperty4Condition(objvzx_RTqa_PaperRelaEN);
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
if (clszx_GroupTextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextBL没有刷新缓存机制(clszx_GroupTextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_RTqa_PaperRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_RTqa_PaperRelaBL没有刷新缓存机制(clszx_RTqa_PaperRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_qa_PaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_qa_PaperBL没有刷新缓存机制(clszx_qa_PaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvzx_RTqa_PaperRelaObjLstCache == null)
//{
//arrvzx_RTqa_PaperRelaObjLstCache = vzx_RTqa_PaperRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_RTqa_PaperRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_RTqa_PaperRelaEN._CurrTabName);
List<clsvzx_RTqa_PaperRelaEN> arrvzx_RTqa_PaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_RTqa_PaperRelaEN> arrvzx_RTqa_PaperRelaObjLst_Sel =
arrvzx_RTqa_PaperRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvzx_RTqa_PaperRelaObjLst_Sel.Count() == 0)
{
   clsvzx_RTqa_PaperRelaEN obj = clsvzx_RTqa_PaperRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_RTqa_PaperRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_RTqa_PaperRelaEN> GetAllvzx_RTqa_PaperRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_RTqa_PaperRelaEN> arrvzx_RTqa_PaperRelaObjLstCache = GetObjLstCache(); 
return arrvzx_RTqa_PaperRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_RTqa_PaperRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_RTqa_PaperRelaEN._CurrTabName);
List<clsvzx_RTqa_PaperRelaEN> arrvzx_RTqa_PaperRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_RTqa_PaperRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_RTqa_PaperRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convzx_RTqa_PaperRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_RTqa_PaperRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_RTqa_PaperRela.AttributeName));
throw new Exception(strMsg);
}
var objvzx_RTqa_PaperRela = clsvzx_RTqa_PaperRelaBL.GetObjBymIdCache(lngmId);
if (objvzx_RTqa_PaperRela == null) return "";
return objvzx_RTqa_PaperRela[strOutFldName].ToString();
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
int intRecCount = clsvzx_RTqa_PaperRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_RTqa_PaperRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_RTqa_PaperRelaDA.GetRecCount();
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
int intRecCount = clsvzx_RTqa_PaperRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_RTqa_PaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_RTqa_PaperRelaEN objvzx_RTqa_PaperRelaCond)
{
List<clsvzx_RTqa_PaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_RTqa_PaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_RTqa_PaperRela.AttributeName)
{
if (objvzx_RTqa_PaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvzx_RTqa_PaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_RTqa_PaperRelaCond[strFldName].ToString());
}
else
{
if (objvzx_RTqa_PaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_RTqa_PaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_RTqa_PaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_RTqa_PaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_RTqa_PaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_RTqa_PaperRelaCond[strFldName]));
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
 List<string> arrList = clsvzx_RTqa_PaperRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_RTqa_PaperRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_RTqa_PaperRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}