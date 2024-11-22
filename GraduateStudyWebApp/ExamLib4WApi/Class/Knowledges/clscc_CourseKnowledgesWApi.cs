
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseKnowledgesWApi
 表名:cc_CourseKnowledges(01120082)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:09
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clscc_CourseKnowledgesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetCourseKnowledgeId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, concc_CourseKnowledges.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, concc_CourseKnowledges.CourseKnowledgeId);
objcc_CourseKnowledgesEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.CourseKnowledgeId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.CourseKnowledgeId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.CourseKnowledgeId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeName(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, concc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, concc_CourseKnowledges.KnowledgeName);
objcc_CourseKnowledgesEN.KnowledgeName = strKnowledgeName; //知识点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeName) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeName, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeName] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeTitle(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, concc_CourseKnowledges.KnowledgeTitle);
objcc_CourseKnowledgesEN.KnowledgeTitle = strKnowledgeTitle; //知识点标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeTitle) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeTitle, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTitle] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeContent(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeContent, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.KnowledgeContent = strKnowledgeContent; //知识点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeContent) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeContent, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeContent] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetCourseId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseKnowledges.CourseId);
objcc_CourseKnowledgesEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.CourseId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.CourseId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.CourseId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeTypeId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeTypeId, 4, concc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckFieldForeignKey(strKnowledgeTypeId, 4, concc_CourseKnowledges.KnowledgeTypeId);
objcc_CourseKnowledgesEN.KnowledgeTypeId = strKnowledgeTypeId; //知识点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeTypeId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeTypeId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTypeId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetCourseChapterId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, concc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
objcc_CourseKnowledgesEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.CourseChapterId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUserId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, concc_CourseKnowledges.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, concc_CourseKnowledges.UserId);
objcc_CourseKnowledgesEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UserId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UserId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UserId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUploadDate(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadDate, 20, concc_CourseKnowledges.UploadDate);
objcc_CourseKnowledgesEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UploadDate) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UploadDate, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UploadDate] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetIsShow(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsShow, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.IsShow) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.IsShow, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.IsShow] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetIsCast(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsCast, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.IsCast) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.IsCast, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.IsCast] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetLikeCount(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, long lngLikeCount, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.LikeCount) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.LikeCount, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.LikeCount] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetOrderNum(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, int intOrderNum, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.OrderNum) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.OrderNum, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.OrderNum] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUpdDate(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseKnowledges.UpdDate);
objcc_CourseKnowledgesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UpdDate) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UpdDate, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UpdDate] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUpdUser(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_CourseKnowledges.UpdUser);
objcc_CourseKnowledgesEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UpdUser) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UpdUser, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UpdUser] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetMemo(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseKnowledges.Memo);
objcc_CourseKnowledgesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.Memo) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.Memo, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.Memo] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseKnowledgesEN objcc_CourseKnowledges_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.CourseKnowledgeId, objcc_CourseKnowledges_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.KnowledgeName) == true)
{
string strComparisonOp_KnowledgeName = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.KnowledgeName, objcc_CourseKnowledges_Cond.KnowledgeName, strComparisonOp_KnowledgeName);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.KnowledgeTitle) == true)
{
string strComparisonOp_KnowledgeTitle = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.KnowledgeTitle, objcc_CourseKnowledges_Cond.KnowledgeTitle, strComparisonOp_KnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.CourseId, objcc_CourseKnowledges_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.KnowledgeTypeId) == true)
{
string strComparisonOp_KnowledgeTypeId = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.KnowledgeTypeId, objcc_CourseKnowledges_Cond.KnowledgeTypeId, strComparisonOp_KnowledgeTypeId);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.CourseChapterId, objcc_CourseKnowledges_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.UserId) == true)
{
string strComparisonOp_UserId = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UserId, objcc_CourseKnowledges_Cond.UserId, strComparisonOp_UserId);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.UploadDate) == true)
{
string strComparisonOp_UploadDate = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UploadDate, objcc_CourseKnowledges_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.IsShow) == true)
{
if (objcc_CourseKnowledges_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseKnowledges.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseKnowledges.IsShow);
}
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.IsCast) == true)
{
if (objcc_CourseKnowledges_Cond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseKnowledges.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseKnowledges.IsCast);
}
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.LikeCount) == true)
{
string strComparisonOp_LikeCount = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseKnowledges.LikeCount, objcc_CourseKnowledges_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.OrderNum) == true)
{
string strComparisonOp_OrderNum = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseKnowledges.OrderNum, objcc_CourseKnowledges_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UpdDate, objcc_CourseKnowledges_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.UpdUser) == true)
{
string strComparisonOp_UpdUser = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UpdUser, objcc_CourseKnowledges_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objcc_CourseKnowledges_Cond.IsUpdated(concc_CourseKnowledges.Memo) == true)
{
string strComparisonOp_Memo = objcc_CourseKnowledges_Cond.dicFldComparisonOp[concc_CourseKnowledges.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.Memo, objcc_CourseKnowledges_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseKnowledgesEN.sf_UpdFldSetStr = objcc_CourseKnowledgesEN.getsf_UpdFldSetStr();
clscc_CourseKnowledgesWApi.CheckPropertyNew(objcc_CourseKnowledgesEN); 
bool bolResult = clscc_CourseKnowledgesWApi.UpdateRecord(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseKnowledges(知识点), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseId_KnowledgeName(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseKnowledgesEN == null) return "";
if (objcc_CourseKnowledgesEN.CourseKnowledgeId == null || objcc_CourseKnowledgesEN.CourseKnowledgeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.KnowledgeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseKnowledgeId !=  '{0}'", objcc_CourseKnowledgesEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.KnowledgeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
try
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesWApi.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesWApi.GetMaxStrId();
 }
clscc_CourseKnowledgesWApi.CheckPropertyNew(objcc_CourseKnowledgesEN); 
bool bolResult = clscc_CourseKnowledgesWApi.AddNewRecord(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
try
{
clscc_CourseKnowledgesWApi.CheckPropertyNew(objcc_CourseKnowledgesEN); 
string strCourseKnowledgeId = clscc_CourseKnowledgesWApi.AddNewRecordWithMaxId(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
return strCourseKnowledgeId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strWhereCond)
{
try
{
clscc_CourseKnowledgesWApi.CheckPropertyNew(objcc_CourseKnowledgesEN); 
bool bolResult = clscc_CourseKnowledgesWApi.UpdateWithCondition(objcc_CourseKnowledgesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 知识点(cc_CourseKnowledges)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseKnowledgesWApi
{
private static readonly string mstrApiControllerName = "cc_CourseKnowledgesApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_CourseKnowledgesWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseKnowledgeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点]...","0");
List<clscc_CourseKnowledgesEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CourseKnowledgeId";
objDDL.DataTextField="KnowledgeName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_CourseKnowledgeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concc_CourseKnowledges.CourseKnowledgeId); 
List<clscc_CourseKnowledgesEN> arrObjLst = clscc_CourseKnowledgesWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN()
{
CourseKnowledgeId = "0",
KnowledgeName = "选[知识点]..."
};
arrObjLst.Insert(0, objcc_CourseKnowledgesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_CourseKnowledges.CourseKnowledgeId;
objComboBox.DisplayMember = concc_CourseKnowledges.KnowledgeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
if (!Object.Equals(null, objcc_CourseKnowledgesEN.CourseKnowledgeId) && GetStrLen(objcc_CourseKnowledgesEN.CourseKnowledgeId) > 8)
{
 throw new Exception("字段[知识点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.KnowledgeName) && GetStrLen(objcc_CourseKnowledgesEN.KnowledgeName) > 100)
{
 throw new Exception("字段[知识点名称]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.KnowledgeTitle) && GetStrLen(objcc_CourseKnowledgesEN.KnowledgeTitle) > 100)
{
 throw new Exception("字段[知识点标题]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.CourseId) && GetStrLen(objcc_CourseKnowledgesEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.KnowledgeTypeId) && GetStrLen(objcc_CourseKnowledgesEN.KnowledgeTypeId) > 4)
{
 throw new Exception("字段[知识点类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.CourseChapterId) && GetStrLen(objcc_CourseKnowledgesEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.UserId) && GetStrLen(objcc_CourseKnowledgesEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.UploadDate) && GetStrLen(objcc_CourseKnowledgesEN.UploadDate) > 20)
{
 throw new Exception("字段[上传时间]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.UpdDate) && GetStrLen(objcc_CourseKnowledgesEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.UpdUser) && GetStrLen(objcc_CourseKnowledgesEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseKnowledgesEN.Memo) && GetStrLen(objcc_CourseKnowledgesEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_CourseKnowledgesEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseKnowledgesEN GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
string strAction = "GetObjByCourseKnowledgeId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseKnowledgeId"] = strCourseKnowledgeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseKnowledgesEN = JsonConvert.DeserializeObject<clscc_CourseKnowledgesEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseKnowledgesEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseKnowledgesEN GetObjByCourseKnowledgeId_WA_Cache(string strCourseKnowledgeId, string strCourseId)
{
string strAction = "GetObjByCourseKnowledgeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseKnowledgeId"] = strCourseKnowledgeId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseKnowledgesEN = JsonConvert.DeserializeObject<clscc_CourseKnowledgesEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseKnowledgesEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clscc_CourseKnowledgesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseKnowledgesEN = JsonConvert.DeserializeObject<clscc_CourseKnowledgesEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseKnowledgesEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseKnowledgesEN GetObjByCourseKnowledgeId_Cache(string strCourseKnowledgeId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel =
from objcc_CourseKnowledgesEN in arrcc_CourseKnowledgesObjLst_Cache
where objcc_CourseKnowledgesEN.CourseKnowledgeId == strCourseKnowledgeId
select objcc_CourseKnowledgesEN;
if (arrcc_CourseKnowledgesObjLst_Sel.Count() == 0)
{
   clscc_CourseKnowledgesEN obj = clscc_CourseKnowledgesWApi.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseKnowledgesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKnowledgeNameByCourseKnowledgeId_Cache(string strCourseKnowledgeId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel1 =
from objcc_CourseKnowledgesEN in arrcc_CourseKnowledgesObjLst_Cache
where objcc_CourseKnowledgesEN.CourseKnowledgeId == strCourseKnowledgeId
select objcc_CourseKnowledgesEN;
List <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel = new List<clscc_CourseKnowledgesEN>();
foreach (clscc_CourseKnowledgesEN obj in arrcc_CourseKnowledgesObjLst_Sel1)
{
arrcc_CourseKnowledgesObjLst_Sel.Add(obj);
}
if (arrcc_CourseKnowledgesObjLst_Sel.Count > 0)
{
return arrcc_CourseKnowledgesObjLst_Sel[0].KnowledgeName;
}
string strErrMsgForGetObjById = string.Format("在cc_CourseKnowledges对象缓存列表中,找不到记录[CourseKnowledgeId = {0}](函数:{1})", strCourseKnowledgeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseKnowledgesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseKnowledgeId_Cache(string strCourseKnowledgeId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel1 =
from objcc_CourseKnowledgesEN in arrcc_CourseKnowledgesObjLst_Cache
where objcc_CourseKnowledgesEN.CourseKnowledgeId == strCourseKnowledgeId
select objcc_CourseKnowledgesEN;
List <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel = new List<clscc_CourseKnowledgesEN>();
foreach (clscc_CourseKnowledgesEN obj in arrcc_CourseKnowledgesObjLst_Sel1)
{
arrcc_CourseKnowledgesObjLst_Sel.Add(obj);
}
if (arrcc_CourseKnowledgesObjLst_Sel.Count > 0)
{
return arrcc_CourseKnowledgesObjLst_Sel[0].KnowledgeName;
}
string strErrMsgForGetObjById = string.Format("在cc_CourseKnowledges对象缓存列表中,找不到记录的相关名称[CourseKnowledgeId = {0}](函数:{1})", strCourseKnowledgeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseKnowledgesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst(List<string> arrCourseKnowledgeId)
{
 List<clscc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseKnowledgeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseKnowledgeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst_Cache(List<string> arrCourseKnowledgeId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel =
from objcc_CourseKnowledgesEN in arrcc_CourseKnowledgesObjLst_Cache
where arrCourseKnowledgeId.Contains(objcc_CourseKnowledgesEN.CourseKnowledgeId)
select objcc_CourseKnowledgesEN;
return arrcc_CourseKnowledgesObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst_WA_Cache(List<string> arrCourseKnowledgeId, string strCourseId)
{
 List<clscc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseKnowledgeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseKnowledgeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseKnowledgesEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseKnowledgesEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strCourseKnowledgeId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesWApi.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCourseKnowledgeId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseKnowledgess(List<string> arrCourseKnowledgeId)
{
string strAction = "Delcc_CourseKnowledgess";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseKnowledgeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesWApi.GetObjByCourseKnowledgeId(arrCourseKnowledgeId[0]);
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseKnowledgessByCond(string strWhereCond)
{
string strAction = "Delcc_CourseKnowledgessByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseKnowledgesEN>(objcc_CourseKnowledgesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseKnowledgesEN>(objcc_CourseKnowledgesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesWApi.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
var strCourseKnowledgeId = (string)jobjReturn["ReturnStr"];
return strCourseKnowledgeId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseKnowledgesEN.CourseKnowledgeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseKnowledgesEN>(objcc_CourseKnowledgesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseKnowledgesEN.CourseKnowledgeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseKnowledgesEN.CourseKnowledgeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseKnowledgesEN>(objcc_CourseKnowledgesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strCourseKnowledgeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseKnowledgeId"] = strCourseKnowledgeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesENS">源对象</param>
 /// <param name = "objcc_CourseKnowledgesENT">目标对象</param>
 public static void CopyTo(clscc_CourseKnowledgesEN objcc_CourseKnowledgesENS, clscc_CourseKnowledgesEN objcc_CourseKnowledgesENT)
{
try
{
objcc_CourseKnowledgesENT.CourseKnowledgeId = objcc_CourseKnowledgesENS.CourseKnowledgeId; //知识点Id
objcc_CourseKnowledgesENT.KnowledgeName = objcc_CourseKnowledgesENS.KnowledgeName; //知识点名称
objcc_CourseKnowledgesENT.KnowledgeTitle = objcc_CourseKnowledgesENS.KnowledgeTitle; //知识点标题
objcc_CourseKnowledgesENT.KnowledgeContent = objcc_CourseKnowledgesENS.KnowledgeContent; //知识点内容
objcc_CourseKnowledgesENT.CourseId = objcc_CourseKnowledgesENS.CourseId; //课程Id
objcc_CourseKnowledgesENT.KnowledgeTypeId = objcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objcc_CourseKnowledgesENT.CourseChapterId = objcc_CourseKnowledgesENS.CourseChapterId; //课程章节ID
objcc_CourseKnowledgesENT.UserId = objcc_CourseKnowledgesENS.UserId; //用户ID
objcc_CourseKnowledgesENT.UploadDate = objcc_CourseKnowledgesENS.UploadDate; //上传时间
objcc_CourseKnowledgesENT.IsShow = objcc_CourseKnowledgesENS.IsShow; //是否启用
objcc_CourseKnowledgesENT.IsCast = objcc_CourseKnowledgesENS.IsCast; //是否播放
objcc_CourseKnowledgesENT.LikeCount = objcc_CourseKnowledgesENS.LikeCount; //资源喜欢数量
objcc_CourseKnowledgesENT.OrderNum = objcc_CourseKnowledgesENS.OrderNum; //序号
objcc_CourseKnowledgesENT.UpdDate = objcc_CourseKnowledgesENS.UpdDate; //修改日期
objcc_CourseKnowledgesENT.UpdUser = objcc_CourseKnowledgesENS.UpdUser; //修改人
objcc_CourseKnowledgesENT.Memo = objcc_CourseKnowledgesENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clscc_CourseKnowledgesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseKnowledgesEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseKnowledgesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseKnowledgesEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseKnowledgesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseKnowledgesEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clscc_CourseKnowledgesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseKnowledgesWApi没有刷新缓存机制(clscc_CourseKnowledgesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseKnowledgeId");
//if (arrcc_CourseKnowledgesObjLst_Cache == null)
//{
//arrcc_CourseKnowledgesObjLst_Cache = await clscc_CourseKnowledgesWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
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

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_CourseKnowledgesWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseKnowledgesWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName_S, strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_CourseKnowledgesObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseKnowledgesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_CourseKnowledges.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.KnowledgeName, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.KnowledgeTitle, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.KnowledgeContent, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.KnowledgeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.UserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.UploadDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseKnowledges.IsCast, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseKnowledges.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_CourseKnowledges.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseKnowledges.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseKnowledges.Memo, Type.GetType("System.String"));
foreach (clscc_CourseKnowledgesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_CourseKnowledges.CourseKnowledgeId] = objInFor[concc_CourseKnowledges.CourseKnowledgeId];
objDR[concc_CourseKnowledges.KnowledgeName] = objInFor[concc_CourseKnowledges.KnowledgeName];
objDR[concc_CourseKnowledges.KnowledgeTitle] = objInFor[concc_CourseKnowledges.KnowledgeTitle];
objDR[concc_CourseKnowledges.KnowledgeContent] = objInFor[concc_CourseKnowledges.KnowledgeContent];
objDR[concc_CourseKnowledges.CourseId] = objInFor[concc_CourseKnowledges.CourseId];
objDR[concc_CourseKnowledges.KnowledgeTypeId] = objInFor[concc_CourseKnowledges.KnowledgeTypeId];
objDR[concc_CourseKnowledges.CourseChapterId] = objInFor[concc_CourseKnowledges.CourseChapterId];
objDR[concc_CourseKnowledges.UserId] = objInFor[concc_CourseKnowledges.UserId];
objDR[concc_CourseKnowledges.UploadDate] = objInFor[concc_CourseKnowledges.UploadDate];
objDR[concc_CourseKnowledges.IsShow] = objInFor[concc_CourseKnowledges.IsShow];
objDR[concc_CourseKnowledges.IsCast] = objInFor[concc_CourseKnowledges.IsCast];
objDR[concc_CourseKnowledges.LikeCount] = objInFor[concc_CourseKnowledges.LikeCount];
objDR[concc_CourseKnowledges.OrderNum] = objInFor[concc_CourseKnowledges.OrderNum];
objDR[concc_CourseKnowledges.UpdDate] = objInFor[concc_CourseKnowledges.UpdDate];
objDR[concc_CourseKnowledges.UpdUser] = objInFor[concc_CourseKnowledges.UpdUser];
objDR[concc_CourseKnowledges.Memo] = objInFor[concc_CourseKnowledges.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 知识点(cc_CourseKnowledges)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_CourseKnowledges : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesWApi.ReFreshThisCache(strCourseId);
clsvcc_CourseKnowledgesWApi.ReFreshThisCache(strCourseId);
}
}

}