
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointAttachmentBL
 表名:vViewpointAttachment(01120593)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:52
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
public static class  clsvViewpointAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointAttachmentEN GetObj(this K_ViewpointAttachmentId_vViewpointAttachment myKey)
{
clsvViewpointAttachmentEN objvViewpointAttachmentEN = clsvViewpointAttachmentBL.vViewpointAttachmentDA.GetObjByViewpointAttachmentId(myKey.Value);
return objvViewpointAttachmentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetViewpointAttachmentId(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, long lngViewpointAttachmentId, string strComparisonOp="")
	{
objvViewpointAttachmentEN.ViewpointAttachmentId = lngViewpointAttachmentId; //主键Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.ViewpointAttachmentId) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.ViewpointAttachmentId, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.ViewpointAttachmentId] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetReason(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strReason, string strComparisonOp="")
	{
objvViewpointAttachmentEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.Reason) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.Reason, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.Reason] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetViewpointAttachmentName(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strViewpointAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointAttachmentName, 200, convViewpointAttachment.ViewpointAttachmentName);
}
objvViewpointAttachmentEN.ViewpointAttachmentName = strViewpointAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.ViewpointAttachmentName) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.ViewpointAttachmentName, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.ViewpointAttachmentName] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetSource(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, convViewpointAttachment.Source);
}
objvViewpointAttachmentEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.Source) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.Source, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.Source] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetViewpointId(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpointAttachment.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpointAttachment.ViewpointId);
}
objvViewpointAttachmentEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.ViewpointId) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.ViewpointId, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.ViewpointId] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetFilePath(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convViewpointAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convViewpointAttachment.FilePath);
}
objvViewpointAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.FilePath) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.FilePath, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.FilePath] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetUpdUser(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewpointAttachment.UpdUser);
}
objvViewpointAttachmentEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.UpdUser) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.UpdUser, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.UpdUser] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetUpdDate(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpointAttachment.UpdDate);
}
objvViewpointAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.UpdDate) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.UpdDate, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.UpdDate] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetViewpointContent(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strViewpointContent, string strComparisonOp="")
	{
objvViewpointAttachmentEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.ViewpointContent) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.ViewpointContent, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.ViewpointContent] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetViewpointName(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpointAttachment.ViewpointName);
}
objvViewpointAttachmentEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.ViewpointName) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.ViewpointName, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.ViewpointName] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetViewpointTypeId(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeId, 4, convViewpointAttachment.ViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointTypeId, 4, convViewpointAttachment.ViewpointTypeId);
}
objvViewpointAttachmentEN.ViewpointTypeId = strViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.ViewpointTypeId) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.ViewpointTypeId, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.ViewpointTypeId] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetViewpointTypeName(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeName, 50, convViewpointAttachment.ViewpointTypeName);
}
objvViewpointAttachmentEN.ViewpointTypeName = strViewpointTypeName; //观点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.ViewpointTypeName) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.ViewpointTypeName, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.ViewpointTypeName] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetVPProposePeople(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strVPProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVPProposePeople, 50, convViewpointAttachment.VPProposePeople);
}
objvViewpointAttachmentEN.VPProposePeople = strVPProposePeople; //观点提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.VPProposePeople) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.VPProposePeople, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.VPProposePeople] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointAttachmentEN SetIdCurrEduCls(this clsvViewpointAttachmentEN objvViewpointAttachmentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convViewpointAttachment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convViewpointAttachment.IdCurrEduCls);
}
objvViewpointAttachmentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAttachmentEN.dicFldComparisonOp.ContainsKey(convViewpointAttachment.IdCurrEduCls) == false)
{
objvViewpointAttachmentEN.dicFldComparisonOp.Add(convViewpointAttachment.IdCurrEduCls, strComparisonOp);
}
else
{
objvViewpointAttachmentEN.dicFldComparisonOp[convViewpointAttachment.IdCurrEduCls] = strComparisonOp;
}
}
return objvViewpointAttachmentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewpointAttachmentENS">源对象</param>
 /// <param name = "objvViewpointAttachmentENT">目标对象</param>
 public static void CopyTo(this clsvViewpointAttachmentEN objvViewpointAttachmentENS, clsvViewpointAttachmentEN objvViewpointAttachmentENT)
{
try
{
objvViewpointAttachmentENT.ViewpointAttachmentId = objvViewpointAttachmentENS.ViewpointAttachmentId; //主键Id
objvViewpointAttachmentENT.Reason = objvViewpointAttachmentENS.Reason; //理由
objvViewpointAttachmentENT.ViewpointAttachmentName = objvViewpointAttachmentENS.ViewpointAttachmentName; //附件名称
objvViewpointAttachmentENT.Source = objvViewpointAttachmentENS.Source; //来源
objvViewpointAttachmentENT.ViewpointId = objvViewpointAttachmentENS.ViewpointId; //观点Id
objvViewpointAttachmentENT.FilePath = objvViewpointAttachmentENS.FilePath; //文件路径
objvViewpointAttachmentENT.UpdUser = objvViewpointAttachmentENS.UpdUser; //修改人
objvViewpointAttachmentENT.UpdDate = objvViewpointAttachmentENS.UpdDate; //修改日期
objvViewpointAttachmentENT.ViewpointContent = objvViewpointAttachmentENS.ViewpointContent; //观点内容
objvViewpointAttachmentENT.ViewpointName = objvViewpointAttachmentENS.ViewpointName; //观点名称
objvViewpointAttachmentENT.ViewpointTypeId = objvViewpointAttachmentENS.ViewpointTypeId; //观点类型Id
objvViewpointAttachmentENT.ViewpointTypeName = objvViewpointAttachmentENS.ViewpointTypeName; //观点类型名
objvViewpointAttachmentENT.VPProposePeople = objvViewpointAttachmentENS.VPProposePeople; //观点提出人
objvViewpointAttachmentENT.IdCurrEduCls = objvViewpointAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvViewpointAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsvViewpointAttachmentEN:objvViewpointAttachmentENT</returns>
 public static clsvViewpointAttachmentEN CopyTo(this clsvViewpointAttachmentEN objvViewpointAttachmentENS)
{
try
{
 clsvViewpointAttachmentEN objvViewpointAttachmentENT = new clsvViewpointAttachmentEN()
{
ViewpointAttachmentId = objvViewpointAttachmentENS.ViewpointAttachmentId, //主键Id
Reason = objvViewpointAttachmentENS.Reason, //理由
ViewpointAttachmentName = objvViewpointAttachmentENS.ViewpointAttachmentName, //附件名称
Source = objvViewpointAttachmentENS.Source, //来源
ViewpointId = objvViewpointAttachmentENS.ViewpointId, //观点Id
FilePath = objvViewpointAttachmentENS.FilePath, //文件路径
UpdUser = objvViewpointAttachmentENS.UpdUser, //修改人
UpdDate = objvViewpointAttachmentENS.UpdDate, //修改日期
ViewpointContent = objvViewpointAttachmentENS.ViewpointContent, //观点内容
ViewpointName = objvViewpointAttachmentENS.ViewpointName, //观点名称
ViewpointTypeId = objvViewpointAttachmentENS.ViewpointTypeId, //观点类型Id
ViewpointTypeName = objvViewpointAttachmentENS.ViewpointTypeName, //观点类型名
VPProposePeople = objvViewpointAttachmentENS.VPProposePeople, //观点提出人
IdCurrEduCls = objvViewpointAttachmentENS.IdCurrEduCls, //教学班流水号
};
 return objvViewpointAttachmentENT;
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
public static void CheckProperty4Condition(this clsvViewpointAttachmentEN objvViewpointAttachmentEN)
{
 clsvViewpointAttachmentBL.vViewpointAttachmentDA.CheckProperty4Condition(objvViewpointAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointAttachmentEN objvViewpointAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.ViewpointAttachmentId) == true)
{
string strComparisonOpViewpointAttachmentId = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.ViewpointAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointAttachment.ViewpointAttachmentId, objvViewpointAttachmentCond.ViewpointAttachmentId, strComparisonOpViewpointAttachmentId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.ViewpointAttachmentName) == true)
{
string strComparisonOpViewpointAttachmentName = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.ViewpointAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.ViewpointAttachmentName, objvViewpointAttachmentCond.ViewpointAttachmentName, strComparisonOpViewpointAttachmentName);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.Source) == true)
{
string strComparisonOpSource = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.Source, objvViewpointAttachmentCond.Source, strComparisonOpSource);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.ViewpointId, objvViewpointAttachmentCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.FilePath, objvViewpointAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.UpdUser, objvViewpointAttachmentCond.UpdUser, strComparisonOpUpdUser);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.UpdDate, objvViewpointAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.ViewpointName, objvViewpointAttachmentCond.ViewpointName, strComparisonOpViewpointName);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.ViewpointTypeId) == true)
{
string strComparisonOpViewpointTypeId = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.ViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.ViewpointTypeId, objvViewpointAttachmentCond.ViewpointTypeId, strComparisonOpViewpointTypeId);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.ViewpointTypeName) == true)
{
string strComparisonOpViewpointTypeName = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.ViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.ViewpointTypeName, objvViewpointAttachmentCond.ViewpointTypeName, strComparisonOpViewpointTypeName);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.VPProposePeople) == true)
{
string strComparisonOpVPProposePeople = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.VPProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.VPProposePeople, objvViewpointAttachmentCond.VPProposePeople, strComparisonOpVPProposePeople);
}
if (objvViewpointAttachmentCond.IsUpdated(convViewpointAttachment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvViewpointAttachmentCond.dicFldComparisonOp[convViewpointAttachment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAttachment.IdCurrEduCls, objvViewpointAttachmentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewpointAttachment
{
public virtual bool UpdRelaTabDate(long lngViewpointAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v观点附件(vViewpointAttachment)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointAttachmentBL
{
public static RelatedActions_vViewpointAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewpointAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewpointAttachmentDA vViewpointAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewpointAttachmentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewpointAttachmentBL()
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
if (string.IsNullOrEmpty(clsvViewpointAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_vViewpointAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewpointAttachmentDA.GetDataTable_vViewpointAttachment(strWhereCond);
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
objDT = vViewpointAttachmentDA.GetDataTable(strWhereCond);
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
objDT = vViewpointAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewpointAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewpointAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewpointAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = vViewpointAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewpointAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewpointAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewpointAttachmentEN> GetObjLstByViewpointAttachmentIdLst(List<long> arrViewpointAttachmentIdLst)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointAttachmentIdLst);
 string strWhereCond = string.Format("ViewpointAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewpointAttachmentEN> GetObjLstByViewpointAttachmentIdLstCache(List<long> arrViewpointAttachmentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvViewpointAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsvViewpointAttachmentEN> arrvViewpointAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointAttachmentEN> arrvViewpointAttachmentObjLst_Sel =
arrvViewpointAttachmentObjLstCache
.Where(x => arrViewpointAttachmentIdLst.Contains(x.ViewpointAttachmentId));
return arrvViewpointAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
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
public static List<clsvViewpointAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewpointAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewpointAttachmentEN> GetSubObjLstCache(clsvViewpointAttachmentEN objvViewpointAttachmentCond)
{
 string strIdCurrEduCls = objvViewpointAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewpointAttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewpointAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointAttachment.AttributeName)
{
if (objvViewpointAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAttachmentCond[strFldName].ToString());
}
else
{
if (objvViewpointAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointAttachmentCond[strFldName]));
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
public static List<clsvViewpointAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
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
public static List<clsvViewpointAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
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
List<clsvViewpointAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewpointAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewpointAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
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
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
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
public static List<clsvViewpointAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewpointAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewpointAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
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
public static List<clsvViewpointAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewpointAttachmentEN> arrObjLst = new List<clsvViewpointAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointAttachmentEN objvViewpointAttachmentEN = new clsvViewpointAttachmentEN();
try
{
objvViewpointAttachmentEN.ViewpointAttachmentId = Int32.Parse(objRow[convViewpointAttachment.ViewpointAttachmentId].ToString().Trim()); //主键Id
objvViewpointAttachmentEN.Reason = objRow[convViewpointAttachment.Reason] == DBNull.Value ? null : objRow[convViewpointAttachment.Reason].ToString().Trim(); //理由
objvViewpointAttachmentEN.ViewpointAttachmentName = objRow[convViewpointAttachment.ViewpointAttachmentName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointAttachmentName].ToString().Trim(); //附件名称
objvViewpointAttachmentEN.Source = objRow[convViewpointAttachment.Source] == DBNull.Value ? null : objRow[convViewpointAttachment.Source].ToString().Trim(); //来源
objvViewpointAttachmentEN.ViewpointId = objRow[convViewpointAttachment.ViewpointId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointId].ToString().Trim(); //观点Id
objvViewpointAttachmentEN.FilePath = objRow[convViewpointAttachment.FilePath].ToString().Trim(); //文件路径
objvViewpointAttachmentEN.UpdUser = objRow[convViewpointAttachment.UpdUser] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdUser].ToString().Trim(); //修改人
objvViewpointAttachmentEN.UpdDate = objRow[convViewpointAttachment.UpdDate] == DBNull.Value ? null : objRow[convViewpointAttachment.UpdDate].ToString().Trim(); //修改日期
objvViewpointAttachmentEN.ViewpointContent = objRow[convViewpointAttachment.ViewpointContent] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointAttachmentEN.ViewpointName = objRow[convViewpointAttachment.ViewpointName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointName].ToString().Trim(); //观点名称
objvViewpointAttachmentEN.ViewpointTypeId = objRow[convViewpointAttachment.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointAttachmentEN.ViewpointTypeName = objRow[convViewpointAttachment.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointAttachment.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointAttachmentEN.VPProposePeople = objRow[convViewpointAttachment.VPProposePeople] == DBNull.Value ? null : objRow[convViewpointAttachment.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointAttachmentEN.IdCurrEduCls = objRow[convViewpointAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpointAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointAttachmentEN.ViewpointAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewpointAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewpointAttachment(ref clsvViewpointAttachmentEN objvViewpointAttachmentEN)
{
bool bolResult = vViewpointAttachmentDA.GetvViewpointAttachment(ref objvViewpointAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointAttachmentEN GetObjByViewpointAttachmentId(long lngViewpointAttachmentId)
{
clsvViewpointAttachmentEN objvViewpointAttachmentEN = vViewpointAttachmentDA.GetObjByViewpointAttachmentId(lngViewpointAttachmentId);
return objvViewpointAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewpointAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewpointAttachmentEN objvViewpointAttachmentEN = vViewpointAttachmentDA.GetFirstObj(strWhereCond);
 return objvViewpointAttachmentEN;
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
public static clsvViewpointAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewpointAttachmentEN objvViewpointAttachmentEN = vViewpointAttachmentDA.GetObjByDataRow(objRow);
 return objvViewpointAttachmentEN;
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
public static clsvViewpointAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewpointAttachmentEN objvViewpointAttachmentEN = vViewpointAttachmentDA.GetObjByDataRow(objRow);
 return objvViewpointAttachmentEN;
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
 /// <param name = "lngViewpointAttachmentId">所给的关键字</param>
 /// <param name = "lstvViewpointAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointAttachmentEN GetObjByViewpointAttachmentIdFromList(long lngViewpointAttachmentId, List<clsvViewpointAttachmentEN> lstvViewpointAttachmentObjLst)
{
foreach (clsvViewpointAttachmentEN objvViewpointAttachmentEN in lstvViewpointAttachmentObjLst)
{
if (objvViewpointAttachmentEN.ViewpointAttachmentId == lngViewpointAttachmentId)
{
return objvViewpointAttachmentEN;
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
 long lngViewpointAttachmentId;
 try
 {
 lngViewpointAttachmentId = new clsvViewpointAttachmentDA().GetFirstID(strWhereCond);
 return lngViewpointAttachmentId;
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
 arrList = vViewpointAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = vViewpointAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointAttachmentId)
{
//检测记录是否存在
bool bolIsExist = vViewpointAttachmentDA.IsExist(lngViewpointAttachmentId);
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
 bolIsExist = clsvViewpointAttachmentDA.IsExistTable();
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
 bolIsExist = vViewpointAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewpointAttachmentENS">源对象</param>
 /// <param name = "objvViewpointAttachmentENT">目标对象</param>
 public static void CopyTo(clsvViewpointAttachmentEN objvViewpointAttachmentENS, clsvViewpointAttachmentEN objvViewpointAttachmentENT)
{
try
{
objvViewpointAttachmentENT.ViewpointAttachmentId = objvViewpointAttachmentENS.ViewpointAttachmentId; //主键Id
objvViewpointAttachmentENT.Reason = objvViewpointAttachmentENS.Reason; //理由
objvViewpointAttachmentENT.ViewpointAttachmentName = objvViewpointAttachmentENS.ViewpointAttachmentName; //附件名称
objvViewpointAttachmentENT.Source = objvViewpointAttachmentENS.Source; //来源
objvViewpointAttachmentENT.ViewpointId = objvViewpointAttachmentENS.ViewpointId; //观点Id
objvViewpointAttachmentENT.FilePath = objvViewpointAttachmentENS.FilePath; //文件路径
objvViewpointAttachmentENT.UpdUser = objvViewpointAttachmentENS.UpdUser; //修改人
objvViewpointAttachmentENT.UpdDate = objvViewpointAttachmentENS.UpdDate; //修改日期
objvViewpointAttachmentENT.ViewpointContent = objvViewpointAttachmentENS.ViewpointContent; //观点内容
objvViewpointAttachmentENT.ViewpointName = objvViewpointAttachmentENS.ViewpointName; //观点名称
objvViewpointAttachmentENT.ViewpointTypeId = objvViewpointAttachmentENS.ViewpointTypeId; //观点类型Id
objvViewpointAttachmentENT.ViewpointTypeName = objvViewpointAttachmentENS.ViewpointTypeName; //观点类型名
objvViewpointAttachmentENT.VPProposePeople = objvViewpointAttachmentENS.VPProposePeople; //观点提出人
objvViewpointAttachmentENT.IdCurrEduCls = objvViewpointAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvViewpointAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewpointAttachmentEN objvViewpointAttachmentEN)
{
try
{
objvViewpointAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewpointAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewpointAttachment.ViewpointAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.ViewpointAttachmentId = objvViewpointAttachmentEN.ViewpointAttachmentId; //主键Id
}
if (arrFldSet.Contains(convViewpointAttachment.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.Reason = objvViewpointAttachmentEN.Reason == "[null]" ? null :  objvViewpointAttachmentEN.Reason; //理由
}
if (arrFldSet.Contains(convViewpointAttachment.ViewpointAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.ViewpointAttachmentName = objvViewpointAttachmentEN.ViewpointAttachmentName == "[null]" ? null :  objvViewpointAttachmentEN.ViewpointAttachmentName; //附件名称
}
if (arrFldSet.Contains(convViewpointAttachment.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.Source = objvViewpointAttachmentEN.Source == "[null]" ? null :  objvViewpointAttachmentEN.Source; //来源
}
if (arrFldSet.Contains(convViewpointAttachment.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.ViewpointId = objvViewpointAttachmentEN.ViewpointId == "[null]" ? null :  objvViewpointAttachmentEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convViewpointAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.FilePath = objvViewpointAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convViewpointAttachment.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.UpdUser = objvViewpointAttachmentEN.UpdUser == "[null]" ? null :  objvViewpointAttachmentEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convViewpointAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.UpdDate = objvViewpointAttachmentEN.UpdDate == "[null]" ? null :  objvViewpointAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewpointAttachment.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.ViewpointContent = objvViewpointAttachmentEN.ViewpointContent == "[null]" ? null :  objvViewpointAttachmentEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convViewpointAttachment.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.ViewpointName = objvViewpointAttachmentEN.ViewpointName == "[null]" ? null :  objvViewpointAttachmentEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convViewpointAttachment.ViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.ViewpointTypeId = objvViewpointAttachmentEN.ViewpointTypeId == "[null]" ? null :  objvViewpointAttachmentEN.ViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(convViewpointAttachment.ViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.ViewpointTypeName = objvViewpointAttachmentEN.ViewpointTypeName == "[null]" ? null :  objvViewpointAttachmentEN.ViewpointTypeName; //观点类型名
}
if (arrFldSet.Contains(convViewpointAttachment.VPProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.VPProposePeople = objvViewpointAttachmentEN.VPProposePeople == "[null]" ? null :  objvViewpointAttachmentEN.VPProposePeople; //观点提出人
}
if (arrFldSet.Contains(convViewpointAttachment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointAttachmentEN.IdCurrEduCls = objvViewpointAttachmentEN.IdCurrEduCls == "[null]" ? null :  objvViewpointAttachmentEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvViewpointAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewpointAttachmentEN objvViewpointAttachmentEN)
{
try
{
if (objvViewpointAttachmentEN.Reason == "[null]") objvViewpointAttachmentEN.Reason = null; //理由
if (objvViewpointAttachmentEN.ViewpointAttachmentName == "[null]") objvViewpointAttachmentEN.ViewpointAttachmentName = null; //附件名称
if (objvViewpointAttachmentEN.Source == "[null]") objvViewpointAttachmentEN.Source = null; //来源
if (objvViewpointAttachmentEN.ViewpointId == "[null]") objvViewpointAttachmentEN.ViewpointId = null; //观点Id
if (objvViewpointAttachmentEN.UpdUser == "[null]") objvViewpointAttachmentEN.UpdUser = null; //修改人
if (objvViewpointAttachmentEN.UpdDate == "[null]") objvViewpointAttachmentEN.UpdDate = null; //修改日期
if (objvViewpointAttachmentEN.ViewpointContent == "[null]") objvViewpointAttachmentEN.ViewpointContent = null; //观点内容
if (objvViewpointAttachmentEN.ViewpointName == "[null]") objvViewpointAttachmentEN.ViewpointName = null; //观点名称
if (objvViewpointAttachmentEN.ViewpointTypeId == "[null]") objvViewpointAttachmentEN.ViewpointTypeId = null; //观点类型Id
if (objvViewpointAttachmentEN.ViewpointTypeName == "[null]") objvViewpointAttachmentEN.ViewpointTypeName = null; //观点类型名
if (objvViewpointAttachmentEN.VPProposePeople == "[null]") objvViewpointAttachmentEN.VPProposePeople = null; //观点提出人
if (objvViewpointAttachmentEN.IdCurrEduCls == "[null]") objvViewpointAttachmentEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvViewpointAttachmentEN objvViewpointAttachmentEN)
{
 vViewpointAttachmentDA.CheckProperty4Condition(objvViewpointAttachmentEN);
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
if (clsViewpointAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointAttachmentBL没有刷新缓存机制(clsViewpointAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by ViewpointAttachmentId");
//if (arrvViewpointAttachmentObjLstCache == null)
//{
//arrvViewpointAttachmentObjLstCache = vViewpointAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointAttachmentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointAttachmentEN GetObjByViewpointAttachmentIdCache(long lngViewpointAttachmentId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvViewpointAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsvViewpointAttachmentEN> arrvViewpointAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointAttachmentEN> arrvViewpointAttachmentObjLst_Sel =
arrvViewpointAttachmentObjLstCache
.Where(x=> x.ViewpointAttachmentId == lngViewpointAttachmentId 
);
if (arrvViewpointAttachmentObjLst_Sel.Count() == 0)
{
   clsvViewpointAttachmentEN obj = clsvViewpointAttachmentBL.GetObjByViewpointAttachmentId(lngViewpointAttachmentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngViewpointAttachmentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewpointAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointAttachmentEN> GetAllvViewpointAttachmentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvViewpointAttachmentEN> arrvViewpointAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvViewpointAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointAttachmentEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvViewpointAttachmentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvViewpointAttachmentEN> arrvViewpointAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewpointAttachmentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewpointAttachmentEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointAttachmentId, string strIdCurrEduCls)
{
if (strInFldName != convViewpointAttachment.ViewpointAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewpointAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewpointAttachment.AttributeName));
throw new Exception(strMsg);
}
var objvViewpointAttachment = clsvViewpointAttachmentBL.GetObjByViewpointAttachmentIdCache(lngViewpointAttachmentId, strIdCurrEduCls);
if (objvViewpointAttachment == null) return "";
return objvViewpointAttachment[strOutFldName].ToString();
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
int intRecCount = clsvViewpointAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewpointAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewpointAttachmentDA.GetRecCount();
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
int intRecCount = clsvViewpointAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewpointAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewpointAttachmentEN objvViewpointAttachmentCond)
{
 string strIdCurrEduCls = objvViewpointAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewpointAttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewpointAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointAttachment.AttributeName)
{
if (objvViewpointAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAttachmentCond[strFldName].ToString());
}
else
{
if (objvViewpointAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointAttachmentCond[strFldName]));
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
 List<string> arrList = clsvViewpointAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewpointAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewpointAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}