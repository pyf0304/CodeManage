
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTViewpointRelaBL
 表名:vRTViewpointRela(01120541)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:30
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
public static class  clsvRTViewpointRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTViewpointRelaEN GetObj(this K_mId_vRTViewpointRela myKey)
{
clsvRTViewpointRelaEN objvRTViewpointRelaEN = clsvRTViewpointRelaBL.vRTViewpointRelaDA.GetObjBymId(myKey.Value);
return objvRTViewpointRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetmId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, long lngmId, string strComparisonOp="")
	{
objvRTViewpointRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.mId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.mId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.mId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetViewpointName(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convRTViewpointRela.ViewpointName);
}
objvRTViewpointRelaEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ViewpointName) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ViewpointName, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ViewpointName] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetViewpointContent(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strViewpointContent, string strComparisonOp="")
	{
objvRTViewpointRelaEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ViewpointContent) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ViewpointContent, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ViewpointContent] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetViewpointId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convRTViewpointRela.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convRTViewpointRela.ViewpointId);
}
objvRTViewpointRelaEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ViewpointId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ViewpointId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ViewpointId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetProposePeople(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProposePeople, 50, convRTViewpointRela.ProposePeople);
}
objvRTViewpointRelaEN.ProposePeople = strProposePeople; //提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ProposePeople) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ProposePeople, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ProposePeople] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetViewpointTypeId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeId, 4, convRTViewpointRela.ViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointTypeId, 4, convRTViewpointRela.ViewpointTypeId);
}
objvRTViewpointRelaEN.ViewpointTypeId = strViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ViewpointTypeId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ViewpointTypeId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ViewpointTypeId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetViewpointTypeName(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeName, 50, convRTViewpointRela.ViewpointTypeName);
}
objvRTViewpointRelaEN.ViewpointTypeName = strViewpointTypeName; //观点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ViewpointTypeName) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ViewpointTypeName, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ViewpointTypeName] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetReason(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strReason, string strComparisonOp="")
	{
objvRTViewpointRelaEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.Reason) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.Reason, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.Reason] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetSource(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, convRTViewpointRela.Source);
}
objvRTViewpointRelaEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.Source) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.Source, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.Source] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetTopicId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTViewpointRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTViewpointRela.TopicId);
}
objvRTViewpointRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.TopicId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.TopicId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.TopicId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetTopicName(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTViewpointRela.TopicName);
}
objvRTViewpointRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.TopicName) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.TopicName, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.TopicName] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetTopicContent(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strTopicContent, string strComparisonOp="")
	{
objvRTViewpointRelaEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.TopicContent) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.TopicContent, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.TopicContent] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetTopicProposePeople(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTViewpointRela.TopicProposePeople);
}
objvRTViewpointRelaEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.TopicProposePeople) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.TopicProposePeople, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.TopicProposePeople] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetUpdDate(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTViewpointRela.UpdDate);
}
objvRTViewpointRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.UpdDate) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.UpdDate, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.UpdDate] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetUpdUser(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTViewpointRela.UpdUser);
}
objvRTViewpointRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.UpdUser) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.UpdUser, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.UpdUser] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetMemo(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTViewpointRela.Memo);
}
objvRTViewpointRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.Memo) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.Memo, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.Memo] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetIsSubmit(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTViewpointRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.IsSubmit) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.IsSubmit, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.IsSubmit] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetAppraiseCount(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTViewpointRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.AppraiseCount) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.AppraiseCount, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.AppraiseCount] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetOkCount(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvRTViewpointRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.OkCount) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.OkCount, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.OkCount] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetScore(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, float? fltScore, string strComparisonOp="")
	{
objvRTViewpointRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.Score) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.Score, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.Score] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetUserTypeId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convRTViewpointRela.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convRTViewpointRela.UserTypeId);
}
objvRTViewpointRelaEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.UserTypeId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.UserTypeId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.UserTypeId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetUserTypeName(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convRTViewpointRela.UserTypeName);
}
objvRTViewpointRelaEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.UserTypeName) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.UserTypeName, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.UserTypeName] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetCitationCount(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvRTViewpointRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.CitationCount) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.CitationCount, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.CitationCount] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetCitationId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convRTViewpointRela.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convRTViewpointRela.CitationId);
}
objvRTViewpointRelaEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.CitationId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.CitationId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.CitationId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetStuScore(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTViewpointRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.StuScore) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.StuScore, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.StuScore] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetTeaScore(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTViewpointRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.TeaScore) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.TeaScore, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.TeaScore] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetViewsDate(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strViewsDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewsDate, 20, convRTViewpointRela.ViewsDate);
}
objvRTViewpointRelaEN.ViewsDate = strViewsDate; //ViewsDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ViewsDate) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ViewsDate, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ViewsDate] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetViewsUserId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strViewsUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewsUserId, 20, convRTViewpointRela.ViewsUserId);
}
objvRTViewpointRelaEN.ViewsUserId = strViewsUserId; //ViewsUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ViewsUserId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ViewsUserId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ViewsUserId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetIdCurrEduCls(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTViewpointRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTViewpointRela.IdCurrEduCls);
}
objvRTViewpointRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.IdCurrEduCls) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetPdfContent(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convRTViewpointRela.PdfContent);
}
objvRTViewpointRelaEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.PdfContent) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.PdfContent, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.PdfContent] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetPdfPageNum(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvRTViewpointRelaEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.PdfPageNum) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.PdfPageNum, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.PdfPageNum] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetVersionCount(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvRTViewpointRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.VersionCount) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.VersionCount, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.VersionCount] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetCreateDate(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convRTViewpointRela.CreateDate);
}
objvRTViewpointRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.CreateDate) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.CreateDate, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.CreateDate] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetShareId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convRTViewpointRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convRTViewpointRela.ShareId);
}
objvRTViewpointRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ShareId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ShareId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ShareId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetIsRecommend(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, bool bolIsRecommend, string strComparisonOp="")
	{
objvRTViewpointRelaEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.IsRecommend) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.IsRecommend, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.IsRecommend] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointRelaEN SetClassificationId(this clsvRTViewpointRelaEN objvRTViewpointRelaEN, string strClassificationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassificationId, 10, convRTViewpointRela.ClassificationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassificationId, 10, convRTViewpointRela.ClassificationId);
}
objvRTViewpointRelaEN.ClassificationId = strClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointRelaEN.dicFldComparisonOp.ContainsKey(convRTViewpointRela.ClassificationId) == false)
{
objvRTViewpointRelaEN.dicFldComparisonOp.Add(convRTViewpointRela.ClassificationId, strComparisonOp);
}
else
{
objvRTViewpointRelaEN.dicFldComparisonOp[convRTViewpointRela.ClassificationId] = strComparisonOp;
}
}
return objvRTViewpointRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTViewpointRelaENS">源对象</param>
 /// <param name = "objvRTViewpointRelaENT">目标对象</param>
 public static void CopyTo(this clsvRTViewpointRelaEN objvRTViewpointRelaENS, clsvRTViewpointRelaEN objvRTViewpointRelaENT)
{
try
{
objvRTViewpointRelaENT.mId = objvRTViewpointRelaENS.mId; //mId
objvRTViewpointRelaENT.ViewpointName = objvRTViewpointRelaENS.ViewpointName; //观点名称
objvRTViewpointRelaENT.ViewpointContent = objvRTViewpointRelaENS.ViewpointContent; //观点内容
objvRTViewpointRelaENT.ViewpointId = objvRTViewpointRelaENS.ViewpointId; //观点Id
objvRTViewpointRelaENT.ProposePeople = objvRTViewpointRelaENS.ProposePeople; //提出人
objvRTViewpointRelaENT.ViewpointTypeId = objvRTViewpointRelaENS.ViewpointTypeId; //观点类型Id
objvRTViewpointRelaENT.ViewpointTypeName = objvRTViewpointRelaENS.ViewpointTypeName; //观点类型名
objvRTViewpointRelaENT.Reason = objvRTViewpointRelaENS.Reason; //理由
objvRTViewpointRelaENT.Source = objvRTViewpointRelaENS.Source; //来源
objvRTViewpointRelaENT.TopicId = objvRTViewpointRelaENS.TopicId; //主题Id
objvRTViewpointRelaENT.TopicName = objvRTViewpointRelaENS.TopicName; //栏目主题
objvRTViewpointRelaENT.TopicContent = objvRTViewpointRelaENS.TopicContent; //主题内容
objvRTViewpointRelaENT.TopicProposePeople = objvRTViewpointRelaENS.TopicProposePeople; //主题提出人
objvRTViewpointRelaENT.UpdDate = objvRTViewpointRelaENS.UpdDate; //修改日期
objvRTViewpointRelaENT.UpdUser = objvRTViewpointRelaENS.UpdUser; //修改人
objvRTViewpointRelaENT.Memo = objvRTViewpointRelaENS.Memo; //备注
objvRTViewpointRelaENT.IsSubmit = objvRTViewpointRelaENS.IsSubmit; //是否提交
objvRTViewpointRelaENT.AppraiseCount = objvRTViewpointRelaENS.AppraiseCount; //评论数
objvRTViewpointRelaENT.OkCount = objvRTViewpointRelaENS.OkCount; //点赞统计
objvRTViewpointRelaENT.Score = objvRTViewpointRelaENS.Score; //评分
objvRTViewpointRelaENT.UserTypeId = objvRTViewpointRelaENS.UserTypeId; //用户类型Id
objvRTViewpointRelaENT.UserTypeName = objvRTViewpointRelaENS.UserTypeName; //用户类型名称
objvRTViewpointRelaENT.CitationCount = objvRTViewpointRelaENS.CitationCount; //引用统计
objvRTViewpointRelaENT.CitationId = objvRTViewpointRelaENS.CitationId; //引用Id
objvRTViewpointRelaENT.StuScore = objvRTViewpointRelaENS.StuScore; //学生平均分
objvRTViewpointRelaENT.TeaScore = objvRTViewpointRelaENS.TeaScore; //教师评分
objvRTViewpointRelaENT.ViewsDate = objvRTViewpointRelaENS.ViewsDate; //ViewsDate
objvRTViewpointRelaENT.ViewsUserId = objvRTViewpointRelaENS.ViewsUserId; //ViewsUserId
objvRTViewpointRelaENT.IdCurrEduCls = objvRTViewpointRelaENS.IdCurrEduCls; //教学班流水号
objvRTViewpointRelaENT.PdfContent = objvRTViewpointRelaENS.PdfContent; //Pdf内容
objvRTViewpointRelaENT.PdfPageNum = objvRTViewpointRelaENS.PdfPageNum; //Pdf页码
objvRTViewpointRelaENT.VersionCount = objvRTViewpointRelaENS.VersionCount; //版本统计
objvRTViewpointRelaENT.CreateDate = objvRTViewpointRelaENS.CreateDate; //建立日期
objvRTViewpointRelaENT.ShareId = objvRTViewpointRelaENS.ShareId; //分享Id
objvRTViewpointRelaENT.IsRecommend = objvRTViewpointRelaENS.IsRecommend; //是否推荐
objvRTViewpointRelaENT.ClassificationId = objvRTViewpointRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTViewpointRelaENS">源对象</param>
 /// <returns>目标对象=>clsvRTViewpointRelaEN:objvRTViewpointRelaENT</returns>
 public static clsvRTViewpointRelaEN CopyTo(this clsvRTViewpointRelaEN objvRTViewpointRelaENS)
{
try
{
 clsvRTViewpointRelaEN objvRTViewpointRelaENT = new clsvRTViewpointRelaEN()
{
mId = objvRTViewpointRelaENS.mId, //mId
ViewpointName = objvRTViewpointRelaENS.ViewpointName, //观点名称
ViewpointContent = objvRTViewpointRelaENS.ViewpointContent, //观点内容
ViewpointId = objvRTViewpointRelaENS.ViewpointId, //观点Id
ProposePeople = objvRTViewpointRelaENS.ProposePeople, //提出人
ViewpointTypeId = objvRTViewpointRelaENS.ViewpointTypeId, //观点类型Id
ViewpointTypeName = objvRTViewpointRelaENS.ViewpointTypeName, //观点类型名
Reason = objvRTViewpointRelaENS.Reason, //理由
Source = objvRTViewpointRelaENS.Source, //来源
TopicId = objvRTViewpointRelaENS.TopicId, //主题Id
TopicName = objvRTViewpointRelaENS.TopicName, //栏目主题
TopicContent = objvRTViewpointRelaENS.TopicContent, //主题内容
TopicProposePeople = objvRTViewpointRelaENS.TopicProposePeople, //主题提出人
UpdDate = objvRTViewpointRelaENS.UpdDate, //修改日期
UpdUser = objvRTViewpointRelaENS.UpdUser, //修改人
Memo = objvRTViewpointRelaENS.Memo, //备注
IsSubmit = objvRTViewpointRelaENS.IsSubmit, //是否提交
AppraiseCount = objvRTViewpointRelaENS.AppraiseCount, //评论数
OkCount = objvRTViewpointRelaENS.OkCount, //点赞统计
Score = objvRTViewpointRelaENS.Score, //评分
UserTypeId = objvRTViewpointRelaENS.UserTypeId, //用户类型Id
UserTypeName = objvRTViewpointRelaENS.UserTypeName, //用户类型名称
CitationCount = objvRTViewpointRelaENS.CitationCount, //引用统计
CitationId = objvRTViewpointRelaENS.CitationId, //引用Id
StuScore = objvRTViewpointRelaENS.StuScore, //学生平均分
TeaScore = objvRTViewpointRelaENS.TeaScore, //教师评分
ViewsDate = objvRTViewpointRelaENS.ViewsDate, //ViewsDate
ViewsUserId = objvRTViewpointRelaENS.ViewsUserId, //ViewsUserId
IdCurrEduCls = objvRTViewpointRelaENS.IdCurrEduCls, //教学班流水号
PdfContent = objvRTViewpointRelaENS.PdfContent, //Pdf内容
PdfPageNum = objvRTViewpointRelaENS.PdfPageNum, //Pdf页码
VersionCount = objvRTViewpointRelaENS.VersionCount, //版本统计
CreateDate = objvRTViewpointRelaENS.CreateDate, //建立日期
ShareId = objvRTViewpointRelaENS.ShareId, //分享Id
IsRecommend = objvRTViewpointRelaENS.IsRecommend, //是否推荐
ClassificationId = objvRTViewpointRelaENS.ClassificationId, //分类Id
};
 return objvRTViewpointRelaENT;
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
public static void CheckProperty4Condition(this clsvRTViewpointRelaEN objvRTViewpointRelaEN)
{
 clsvRTViewpointRelaBL.vRTViewpointRelaDA.CheckProperty4Condition(objvRTViewpointRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTViewpointRelaEN objvRTViewpointRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.mId) == true)
{
string strComparisonOpmId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.mId, objvRTViewpointRelaCond.mId, strComparisonOpmId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ViewpointName, objvRTViewpointRelaCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ViewpointId, objvRTViewpointRelaCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ProposePeople) == true)
{
string strComparisonOpProposePeople = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ProposePeople, objvRTViewpointRelaCond.ProposePeople, strComparisonOpProposePeople);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ViewpointTypeId) == true)
{
string strComparisonOpViewpointTypeId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ViewpointTypeId, objvRTViewpointRelaCond.ViewpointTypeId, strComparisonOpViewpointTypeId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ViewpointTypeName) == true)
{
string strComparisonOpViewpointTypeName = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ViewpointTypeName, objvRTViewpointRelaCond.ViewpointTypeName, strComparisonOpViewpointTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.Source) == true)
{
string strComparisonOpSource = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.Source, objvRTViewpointRelaCond.Source, strComparisonOpSource);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.TopicId) == true)
{
string strComparisonOpTopicId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.TopicId, objvRTViewpointRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.TopicName) == true)
{
string strComparisonOpTopicName = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.TopicName, objvRTViewpointRelaCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.TopicProposePeople, objvRTViewpointRelaCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.UpdDate, objvRTViewpointRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.UpdUser, objvRTViewpointRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.Memo) == true)
{
string strComparisonOpMemo = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.Memo, objvRTViewpointRelaCond.Memo, strComparisonOpMemo);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.IsSubmit) == true)
{
if (objvRTViewpointRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTViewpointRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTViewpointRela.IsSubmit);
}
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.AppraiseCount, objvRTViewpointRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.OkCount) == true)
{
string strComparisonOpOkCount = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.OkCount, objvRTViewpointRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.Score) == true)
{
string strComparisonOpScore = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.Score, objvRTViewpointRelaCond.Score, strComparisonOpScore);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.UserTypeId, objvRTViewpointRelaCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.UserTypeName, objvRTViewpointRelaCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.CitationCount, objvRTViewpointRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.CitationId) == true)
{
string strComparisonOpCitationId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.CitationId, objvRTViewpointRelaCond.CitationId, strComparisonOpCitationId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.StuScore) == true)
{
string strComparisonOpStuScore = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.StuScore, objvRTViewpointRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.TeaScore, objvRTViewpointRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ViewsDate) == true)
{
string strComparisonOpViewsDate = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ViewsDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ViewsDate, objvRTViewpointRelaCond.ViewsDate, strComparisonOpViewsDate);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ViewsUserId) == true)
{
string strComparisonOpViewsUserId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ViewsUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ViewsUserId, objvRTViewpointRelaCond.ViewsUserId, strComparisonOpViewsUserId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.IdCurrEduCls, objvRTViewpointRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.PdfContent) == true)
{
string strComparisonOpPdfContent = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.PdfContent, objvRTViewpointRelaCond.PdfContent, strComparisonOpPdfContent);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.PdfPageNum, objvRTViewpointRelaCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpointRela.VersionCount, objvRTViewpointRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.CreateDate, objvRTViewpointRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ShareId) == true)
{
string strComparisonOpShareId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ShareId, objvRTViewpointRelaCond.ShareId, strComparisonOpShareId);
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.IsRecommend) == true)
{
if (objvRTViewpointRelaCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTViewpointRela.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTViewpointRela.IsRecommend);
}
}
if (objvRTViewpointRelaCond.IsUpdated(convRTViewpointRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objvRTViewpointRelaCond.dicFldComparisonOp[convRTViewpointRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpointRela.ClassificationId, objvRTViewpointRelaCond.ClassificationId, strComparisonOpClassificationId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTViewpointRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v主题观点关系(vRTViewpointRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTViewpointRelaBL
{
public static RelatedActions_vRTViewpointRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTViewpointRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTViewpointRelaDA vRTViewpointRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTViewpointRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTViewpointRelaBL()
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
if (string.IsNullOrEmpty(clsvRTViewpointRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTViewpointRelaEN._ConnectString);
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
public static DataTable GetDataTable_vRTViewpointRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTViewpointRelaDA.GetDataTable_vRTViewpointRela(strWhereCond);
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
objDT = vRTViewpointRelaDA.GetDataTable(strWhereCond);
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
objDT = vRTViewpointRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTViewpointRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTViewpointRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTViewpointRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vRTViewpointRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTViewpointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTViewpointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvRTViewpointRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
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
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTViewpointRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvRTViewpointRelaEN._CurrTabName, strIdCurrEduCls);
List<clsvRTViewpointRelaEN> arrvRTViewpointRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvRTViewpointRelaEN> arrvRTViewpointRelaObjLst_Sel =
arrvRTViewpointRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTViewpointRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTViewpointRelaEN> GetObjLst(string strWhereCond)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
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
public static List<clsvRTViewpointRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTViewpointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTViewpointRelaEN> GetSubObjLstCache(clsvRTViewpointRelaEN objvRTViewpointRelaCond)
{
 string strIdCurrEduCls = objvRTViewpointRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvRTViewpointRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvRTViewpointRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvRTViewpointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTViewpointRela.AttributeName)
{
if (objvRTViewpointRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTViewpointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointRelaCond[strFldName].ToString());
}
else
{
if (objvRTViewpointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTViewpointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTViewpointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTViewpointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTViewpointRelaCond[strFldName]));
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
public static List<clsvRTViewpointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
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
public static List<clsvRTViewpointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
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
List<clsvRTViewpointRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTViewpointRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTViewpointRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTViewpointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
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
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
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
public static List<clsvRTViewpointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTViewpointRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTViewpointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
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
public static List<clsvRTViewpointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTViewpointRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTViewpointRelaEN> arrObjLst = new List<clsvRTViewpointRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointRelaEN objvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
try
{
objvRTViewpointRelaEN.mId = Int32.Parse(objRow[convRTViewpointRela.mId].ToString().Trim()); //mId
objvRTViewpointRelaEN.ViewpointName = objRow[convRTViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvRTViewpointRelaEN.ViewpointContent = objRow[convRTViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvRTViewpointRelaEN.ViewpointId = objRow[convRTViewpointRela.ViewpointId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvRTViewpointRelaEN.ProposePeople = objRow[convRTViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointRelaEN.ViewpointTypeId = objRow[convRTViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvRTViewpointRelaEN.ViewpointTypeName = objRow[convRTViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvRTViewpointRelaEN.Reason = objRow[convRTViewpointRela.Reason] == DBNull.Value ? null : objRow[convRTViewpointRela.Reason].ToString().Trim(); //理由
objvRTViewpointRelaEN.Source = objRow[convRTViewpointRela.Source] == DBNull.Value ? null : objRow[convRTViewpointRela.Source].ToString().Trim(); //来源
objvRTViewpointRelaEN.TopicId = objRow[convRTViewpointRela.TopicId] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicId].ToString().Trim(); //主题Id
objvRTViewpointRelaEN.TopicName = objRow[convRTViewpointRela.TopicName] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointRelaEN.TopicContent = objRow[convRTViewpointRela.TopicContent] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointRelaEN.TopicProposePeople = objRow[convRTViewpointRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpointRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointRelaEN.UpdDate = objRow[convRTViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointRelaEN.UpdUser = objRow[convRTViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convRTViewpointRela.UpdUser].ToString().Trim(); //修改人
objvRTViewpointRelaEN.Memo = objRow[convRTViewpointRela.Memo] == DBNull.Value ? null : objRow[convRTViewpointRela.Memo].ToString().Trim(); //备注
objvRTViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointRelaEN.AppraiseCount = objRow[convRTViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointRelaEN.OkCount = objRow[convRTViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointRelaEN.Score = objRow[convRTViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.Score].ToString().Trim()); //评分
objvRTViewpointRelaEN.UserTypeId = objRow[convRTViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvRTViewpointRelaEN.UserTypeName = objRow[convRTViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convRTViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvRTViewpointRelaEN.CitationCount = objRow[convRTViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointRelaEN.CitationId = objRow[convRTViewpointRela.CitationId] == DBNull.Value ? null : objRow[convRTViewpointRela.CitationId].ToString().Trim(); //引用Id
objvRTViewpointRelaEN.StuScore = objRow[convRTViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointRelaEN.TeaScore = objRow[convRTViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointRelaEN.ViewsDate = objRow[convRTViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvRTViewpointRelaEN.ViewsUserId = objRow[convRTViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convRTViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvRTViewpointRelaEN.IdCurrEduCls = objRow[convRTViewpointRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTViewpointRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointRelaEN.PdfContent = objRow[convRTViewpointRela.PdfContent] == DBNull.Value ? null : objRow[convRTViewpointRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointRelaEN.PdfPageNum = objRow[convRTViewpointRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTViewpointRelaEN.VersionCount = objRow[convRTViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointRelaEN.CreateDate = objRow[convRTViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convRTViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointRelaEN.ShareId = objRow[convRTViewpointRela.ShareId] == DBNull.Value ? null : objRow[convRTViewpointRela.ShareId].ToString().Trim(); //分享Id
objvRTViewpointRelaEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpointRela.IsRecommend].ToString().Trim()); //是否推荐
objvRTViewpointRelaEN.ClassificationId = objRow[convRTViewpointRela.ClassificationId] == DBNull.Value ? null : objRow[convRTViewpointRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTViewpointRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTViewpointRela(ref clsvRTViewpointRelaEN objvRTViewpointRelaEN)
{
bool bolResult = vRTViewpointRelaDA.GetvRTViewpointRela(ref objvRTViewpointRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTViewpointRelaEN GetObjBymId(long lngmId)
{
clsvRTViewpointRelaEN objvRTViewpointRelaEN = vRTViewpointRelaDA.GetObjBymId(lngmId);
return objvRTViewpointRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTViewpointRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTViewpointRelaEN objvRTViewpointRelaEN = vRTViewpointRelaDA.GetFirstObj(strWhereCond);
 return objvRTViewpointRelaEN;
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
public static clsvRTViewpointRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTViewpointRelaEN objvRTViewpointRelaEN = vRTViewpointRelaDA.GetObjByDataRow(objRow);
 return objvRTViewpointRelaEN;
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
public static clsvRTViewpointRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTViewpointRelaEN objvRTViewpointRelaEN = vRTViewpointRelaDA.GetObjByDataRow(objRow);
 return objvRTViewpointRelaEN;
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
 /// <param name = "lstvRTViewpointRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTViewpointRelaEN GetObjBymIdFromList(long lngmId, List<clsvRTViewpointRelaEN> lstvRTViewpointRelaObjLst)
{
foreach (clsvRTViewpointRelaEN objvRTViewpointRelaEN in lstvRTViewpointRelaObjLst)
{
if (objvRTViewpointRelaEN.mId == lngmId)
{
return objvRTViewpointRelaEN;
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
 lngmId = new clsvRTViewpointRelaDA().GetFirstID(strWhereCond);
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
 arrList = vRTViewpointRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vRTViewpointRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vRTViewpointRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvRTViewpointRelaDA.IsExistTable();
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
 bolIsExist = vRTViewpointRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTViewpointRelaENS">源对象</param>
 /// <param name = "objvRTViewpointRelaENT">目标对象</param>
 public static void CopyTo(clsvRTViewpointRelaEN objvRTViewpointRelaENS, clsvRTViewpointRelaEN objvRTViewpointRelaENT)
{
try
{
objvRTViewpointRelaENT.mId = objvRTViewpointRelaENS.mId; //mId
objvRTViewpointRelaENT.ViewpointName = objvRTViewpointRelaENS.ViewpointName; //观点名称
objvRTViewpointRelaENT.ViewpointContent = objvRTViewpointRelaENS.ViewpointContent; //观点内容
objvRTViewpointRelaENT.ViewpointId = objvRTViewpointRelaENS.ViewpointId; //观点Id
objvRTViewpointRelaENT.ProposePeople = objvRTViewpointRelaENS.ProposePeople; //提出人
objvRTViewpointRelaENT.ViewpointTypeId = objvRTViewpointRelaENS.ViewpointTypeId; //观点类型Id
objvRTViewpointRelaENT.ViewpointTypeName = objvRTViewpointRelaENS.ViewpointTypeName; //观点类型名
objvRTViewpointRelaENT.Reason = objvRTViewpointRelaENS.Reason; //理由
objvRTViewpointRelaENT.Source = objvRTViewpointRelaENS.Source; //来源
objvRTViewpointRelaENT.TopicId = objvRTViewpointRelaENS.TopicId; //主题Id
objvRTViewpointRelaENT.TopicName = objvRTViewpointRelaENS.TopicName; //栏目主题
objvRTViewpointRelaENT.TopicContent = objvRTViewpointRelaENS.TopicContent; //主题内容
objvRTViewpointRelaENT.TopicProposePeople = objvRTViewpointRelaENS.TopicProposePeople; //主题提出人
objvRTViewpointRelaENT.UpdDate = objvRTViewpointRelaENS.UpdDate; //修改日期
objvRTViewpointRelaENT.UpdUser = objvRTViewpointRelaENS.UpdUser; //修改人
objvRTViewpointRelaENT.Memo = objvRTViewpointRelaENS.Memo; //备注
objvRTViewpointRelaENT.IsSubmit = objvRTViewpointRelaENS.IsSubmit; //是否提交
objvRTViewpointRelaENT.AppraiseCount = objvRTViewpointRelaENS.AppraiseCount; //评论数
objvRTViewpointRelaENT.OkCount = objvRTViewpointRelaENS.OkCount; //点赞统计
objvRTViewpointRelaENT.Score = objvRTViewpointRelaENS.Score; //评分
objvRTViewpointRelaENT.UserTypeId = objvRTViewpointRelaENS.UserTypeId; //用户类型Id
objvRTViewpointRelaENT.UserTypeName = objvRTViewpointRelaENS.UserTypeName; //用户类型名称
objvRTViewpointRelaENT.CitationCount = objvRTViewpointRelaENS.CitationCount; //引用统计
objvRTViewpointRelaENT.CitationId = objvRTViewpointRelaENS.CitationId; //引用Id
objvRTViewpointRelaENT.StuScore = objvRTViewpointRelaENS.StuScore; //学生平均分
objvRTViewpointRelaENT.TeaScore = objvRTViewpointRelaENS.TeaScore; //教师评分
objvRTViewpointRelaENT.ViewsDate = objvRTViewpointRelaENS.ViewsDate; //ViewsDate
objvRTViewpointRelaENT.ViewsUserId = objvRTViewpointRelaENS.ViewsUserId; //ViewsUserId
objvRTViewpointRelaENT.IdCurrEduCls = objvRTViewpointRelaENS.IdCurrEduCls; //教学班流水号
objvRTViewpointRelaENT.PdfContent = objvRTViewpointRelaENS.PdfContent; //Pdf内容
objvRTViewpointRelaENT.PdfPageNum = objvRTViewpointRelaENS.PdfPageNum; //Pdf页码
objvRTViewpointRelaENT.VersionCount = objvRTViewpointRelaENS.VersionCount; //版本统计
objvRTViewpointRelaENT.CreateDate = objvRTViewpointRelaENS.CreateDate; //建立日期
objvRTViewpointRelaENT.ShareId = objvRTViewpointRelaENS.ShareId; //分享Id
objvRTViewpointRelaENT.IsRecommend = objvRTViewpointRelaENS.IsRecommend; //是否推荐
objvRTViewpointRelaENT.ClassificationId = objvRTViewpointRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTViewpointRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTViewpointRelaEN objvRTViewpointRelaEN)
{
try
{
objvRTViewpointRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTViewpointRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTViewpointRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.mId = objvRTViewpointRelaEN.mId; //mId
}
if (arrFldSet.Contains(convRTViewpointRela.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ViewpointName = objvRTViewpointRelaEN.ViewpointName == "[null]" ? null :  objvRTViewpointRelaEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convRTViewpointRela.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ViewpointContent = objvRTViewpointRelaEN.ViewpointContent == "[null]" ? null :  objvRTViewpointRelaEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convRTViewpointRela.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ViewpointId = objvRTViewpointRelaEN.ViewpointId == "[null]" ? null :  objvRTViewpointRelaEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convRTViewpointRela.ProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ProposePeople = objvRTViewpointRelaEN.ProposePeople == "[null]" ? null :  objvRTViewpointRelaEN.ProposePeople; //提出人
}
if (arrFldSet.Contains(convRTViewpointRela.ViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ViewpointTypeId = objvRTViewpointRelaEN.ViewpointTypeId == "[null]" ? null :  objvRTViewpointRelaEN.ViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(convRTViewpointRela.ViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ViewpointTypeName = objvRTViewpointRelaEN.ViewpointTypeName == "[null]" ? null :  objvRTViewpointRelaEN.ViewpointTypeName; //观点类型名
}
if (arrFldSet.Contains(convRTViewpointRela.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.Reason = objvRTViewpointRelaEN.Reason == "[null]" ? null :  objvRTViewpointRelaEN.Reason; //理由
}
if (arrFldSet.Contains(convRTViewpointRela.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.Source = objvRTViewpointRelaEN.Source == "[null]" ? null :  objvRTViewpointRelaEN.Source; //来源
}
if (arrFldSet.Contains(convRTViewpointRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.TopicId = objvRTViewpointRelaEN.TopicId == "[null]" ? null :  objvRTViewpointRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTViewpointRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.TopicName = objvRTViewpointRelaEN.TopicName == "[null]" ? null :  objvRTViewpointRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTViewpointRela.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.TopicContent = objvRTViewpointRelaEN.TopicContent == "[null]" ? null :  objvRTViewpointRelaEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTViewpointRela.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.TopicProposePeople = objvRTViewpointRelaEN.TopicProposePeople == "[null]" ? null :  objvRTViewpointRelaEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTViewpointRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.UpdDate = objvRTViewpointRelaEN.UpdDate == "[null]" ? null :  objvRTViewpointRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTViewpointRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.UpdUser = objvRTViewpointRelaEN.UpdUser == "[null]" ? null :  objvRTViewpointRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTViewpointRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.Memo = objvRTViewpointRelaEN.Memo == "[null]" ? null :  objvRTViewpointRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convRTViewpointRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.IsSubmit = objvRTViewpointRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTViewpointRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.AppraiseCount = objvRTViewpointRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTViewpointRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.OkCount = objvRTViewpointRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTViewpointRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.Score = objvRTViewpointRelaEN.Score; //评分
}
if (arrFldSet.Contains(convRTViewpointRela.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.UserTypeId = objvRTViewpointRelaEN.UserTypeId == "[null]" ? null :  objvRTViewpointRelaEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convRTViewpointRela.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.UserTypeName = objvRTViewpointRelaEN.UserTypeName == "[null]" ? null :  objvRTViewpointRelaEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convRTViewpointRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.CitationCount = objvRTViewpointRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convRTViewpointRela.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.CitationId = objvRTViewpointRelaEN.CitationId == "[null]" ? null :  objvRTViewpointRelaEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convRTViewpointRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.StuScore = objvRTViewpointRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTViewpointRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.TeaScore = objvRTViewpointRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTViewpointRela.ViewsDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ViewsDate = objvRTViewpointRelaEN.ViewsDate == "[null]" ? null :  objvRTViewpointRelaEN.ViewsDate; //ViewsDate
}
if (arrFldSet.Contains(convRTViewpointRela.ViewsUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ViewsUserId = objvRTViewpointRelaEN.ViewsUserId == "[null]" ? null :  objvRTViewpointRelaEN.ViewsUserId; //ViewsUserId
}
if (arrFldSet.Contains(convRTViewpointRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.IdCurrEduCls = objvRTViewpointRelaEN.IdCurrEduCls == "[null]" ? null :  objvRTViewpointRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTViewpointRela.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.PdfContent = objvRTViewpointRelaEN.PdfContent == "[null]" ? null :  objvRTViewpointRelaEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convRTViewpointRela.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.PdfPageNum = objvRTViewpointRelaEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convRTViewpointRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.VersionCount = objvRTViewpointRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convRTViewpointRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.CreateDate = objvRTViewpointRelaEN.CreateDate == "[null]" ? null :  objvRTViewpointRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convRTViewpointRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ShareId = objvRTViewpointRelaEN.ShareId == "[null]" ? null :  objvRTViewpointRelaEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convRTViewpointRela.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.IsRecommend = objvRTViewpointRelaEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(convRTViewpointRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointRelaEN.ClassificationId = objvRTViewpointRelaEN.ClassificationId == "[null]" ? null :  objvRTViewpointRelaEN.ClassificationId; //分类Id
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
 /// <param name = "objvRTViewpointRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTViewpointRelaEN objvRTViewpointRelaEN)
{
try
{
if (objvRTViewpointRelaEN.ViewpointName == "[null]") objvRTViewpointRelaEN.ViewpointName = null; //观点名称
if (objvRTViewpointRelaEN.ViewpointContent == "[null]") objvRTViewpointRelaEN.ViewpointContent = null; //观点内容
if (objvRTViewpointRelaEN.ViewpointId == "[null]") objvRTViewpointRelaEN.ViewpointId = null; //观点Id
if (objvRTViewpointRelaEN.ProposePeople == "[null]") objvRTViewpointRelaEN.ProposePeople = null; //提出人
if (objvRTViewpointRelaEN.ViewpointTypeId == "[null]") objvRTViewpointRelaEN.ViewpointTypeId = null; //观点类型Id
if (objvRTViewpointRelaEN.ViewpointTypeName == "[null]") objvRTViewpointRelaEN.ViewpointTypeName = null; //观点类型名
if (objvRTViewpointRelaEN.Reason == "[null]") objvRTViewpointRelaEN.Reason = null; //理由
if (objvRTViewpointRelaEN.Source == "[null]") objvRTViewpointRelaEN.Source = null; //来源
if (objvRTViewpointRelaEN.TopicId == "[null]") objvRTViewpointRelaEN.TopicId = null; //主题Id
if (objvRTViewpointRelaEN.TopicName == "[null]") objvRTViewpointRelaEN.TopicName = null; //栏目主题
if (objvRTViewpointRelaEN.TopicContent == "[null]") objvRTViewpointRelaEN.TopicContent = null; //主题内容
if (objvRTViewpointRelaEN.TopicProposePeople == "[null]") objvRTViewpointRelaEN.TopicProposePeople = null; //主题提出人
if (objvRTViewpointRelaEN.UpdDate == "[null]") objvRTViewpointRelaEN.UpdDate = null; //修改日期
if (objvRTViewpointRelaEN.UpdUser == "[null]") objvRTViewpointRelaEN.UpdUser = null; //修改人
if (objvRTViewpointRelaEN.Memo == "[null]") objvRTViewpointRelaEN.Memo = null; //备注
if (objvRTViewpointRelaEN.UserTypeId == "[null]") objvRTViewpointRelaEN.UserTypeId = null; //用户类型Id
if (objvRTViewpointRelaEN.UserTypeName == "[null]") objvRTViewpointRelaEN.UserTypeName = null; //用户类型名称
if (objvRTViewpointRelaEN.CitationId == "[null]") objvRTViewpointRelaEN.CitationId = null; //引用Id
if (objvRTViewpointRelaEN.ViewsDate == "[null]") objvRTViewpointRelaEN.ViewsDate = null; //ViewsDate
if (objvRTViewpointRelaEN.ViewsUserId == "[null]") objvRTViewpointRelaEN.ViewsUserId = null; //ViewsUserId
if (objvRTViewpointRelaEN.IdCurrEduCls == "[null]") objvRTViewpointRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvRTViewpointRelaEN.PdfContent == "[null]") objvRTViewpointRelaEN.PdfContent = null; //Pdf内容
if (objvRTViewpointRelaEN.CreateDate == "[null]") objvRTViewpointRelaEN.CreateDate = null; //建立日期
if (objvRTViewpointRelaEN.ShareId == "[null]") objvRTViewpointRelaEN.ShareId = null; //分享Id
if (objvRTViewpointRelaEN.ClassificationId == "[null]") objvRTViewpointRelaEN.ClassificationId = null; //分类Id
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
public static void CheckProperty4Condition(clsvRTViewpointRelaEN objvRTViewpointRelaEN)
{
 vRTViewpointRelaDA.CheckProperty4Condition(objvRTViewpointRelaEN);
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
if (clsRTViewpointRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTViewpointRelaBL没有刷新缓存机制(clsRTViewpointRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointBL没有刷新缓存机制(clsViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointTypeBL没有刷新缓存机制(clsViewpointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvRTViewpointRelaObjLstCache == null)
//{
//arrvRTViewpointRelaObjLstCache = vRTViewpointRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTViewpointRelaEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvRTViewpointRelaEN._CurrTabName, strIdCurrEduCls);
List<clsvRTViewpointRelaEN> arrvRTViewpointRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvRTViewpointRelaEN> arrvRTViewpointRelaObjLst_Sel =
arrvRTViewpointRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTViewpointRelaObjLst_Sel.Count() == 0)
{
   clsvRTViewpointRelaEN obj = clsvRTViewpointRelaBL.GetObjBymId(lngmId);
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
return arrvRTViewpointRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTViewpointRelaEN> GetAllvRTViewpointRelaObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvRTViewpointRelaEN> arrvRTViewpointRelaObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvRTViewpointRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTViewpointRelaEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvRTViewpointRelaEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvRTViewpointRelaEN> arrvRTViewpointRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvRTViewpointRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvRTViewpointRelaEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strIdCurrEduCls)
{
if (strInFldName != convRTViewpointRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTViewpointRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTViewpointRela.AttributeName));
throw new Exception(strMsg);
}
var objvRTViewpointRela = clsvRTViewpointRelaBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objvRTViewpointRela == null) return "";
return objvRTViewpointRela[strOutFldName].ToString();
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
int intRecCount = clsvRTViewpointRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTViewpointRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTViewpointRelaDA.GetRecCount();
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
int intRecCount = clsvRTViewpointRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTViewpointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTViewpointRelaEN objvRTViewpointRelaCond)
{
 string strIdCurrEduCls = objvRTViewpointRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvRTViewpointRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvRTViewpointRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvRTViewpointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTViewpointRela.AttributeName)
{
if (objvRTViewpointRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTViewpointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointRelaCond[strFldName].ToString());
}
else
{
if (objvRTViewpointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTViewpointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTViewpointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTViewpointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTViewpointRelaCond[strFldName]));
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
 List<string> arrList = clsvRTViewpointRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTViewpointRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTViewpointRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}