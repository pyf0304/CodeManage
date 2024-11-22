
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperAttentionWApi
 表名:vgs_PaperAttention(01120750)
 生成代码版本:2021.08.17.1
 生成日期:2021/08/20 02:39:07
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsvgs_PaperAttentionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperAttentionId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, long lngPaperAttentionId, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.PaperAttentionId = lngPaperAttentionId; //论文收藏Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperAttentionId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperAttentionId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperAttentionId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PaperAttention.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PaperAttention.PaperId);
objvgs_PaperAttentionEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperTitle(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convgs_PaperAttention.PaperTitle);
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PaperAttention.PaperTitle);
objvgs_PaperAttentionEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperTitle) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperTitle, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperTitle] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetAuthor(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuthor, 200, convgs_PaperAttention.Author);
objvgs_PaperAttentionEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.Author) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.Author, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.Author] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetKeyword(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convgs_PaperAttention.Keyword);
objvgs_PaperAttentionEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.Keyword) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.Keyword, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.Keyword] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetBrowseNumber(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int intBrowseNumber, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.BrowseNumber) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.BrowseNumber, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.BrowseNumber] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetUserId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convgs_PaperAttention.UserId);
objvgs_PaperAttentionEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.UserId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.UserId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.UserId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperGroupId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperGroupId, 8, convgs_PaperAttention.PaperGroupId);
clsCheckSql.CheckFieldForeignKey(strPaperGroupId, 8, convgs_PaperAttention.PaperGroupId);
objvgs_PaperAttentionEN.PaperGroupId = strPaperGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperGroupId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperGroupId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperGroupId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetUpdUser(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PaperAttention.UpdUser);
objvgs_PaperAttentionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.UpdUser) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.UpdUser, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.UpdUser] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetUpdDate(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PaperAttention.UpdDate);
objvgs_PaperAttentionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.UpdDate) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.UpdDate, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.UpdDate] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetMeno(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strMeno, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMeno, 2000, convgs_PaperAttention.Meno);
objvgs_PaperAttentionEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.Meno) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.Meno, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.Meno] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperGroupName(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperGroupName, 50, convgs_PaperAttention.PaperGroupName);
objvgs_PaperAttentionEN.PaperGroupName = strPaperGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperGroupName) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperGroupName, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperGroupName] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperQCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int intPaperQCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperQCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperQCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperQCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetSubVCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int intSubVCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.SubVCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.SubVCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.SubVCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetTagsCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int intTagsCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.TagsCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.TagsCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.TagsCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetTeaQCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int intTeaQCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.TeaQCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.TeaQCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.TeaQCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PaperAttentionEN objvgs_PaperAttention_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.PaperAttentionId) == true)
{
string strComparisonOp_PaperAttentionId = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.PaperAttentionId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.PaperAttentionId, objvgs_PaperAttention_Cond.PaperAttentionId, strComparisonOp_PaperAttentionId);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.PaperId) == true)
{
string strComparisonOp_PaperId = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperId, objvgs_PaperAttention_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperTitle, objvgs_PaperAttention_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.Author) == true)
{
string strComparisonOp_Author = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.Author, objvgs_PaperAttention_Cond.Author, strComparisonOp_Author);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.Keyword) == true)
{
string strComparisonOp_Keyword = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.Keyword, objvgs_PaperAttention_Cond.Keyword, strComparisonOp_Keyword);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.BrowseNumber) == true)
{
string strComparisonOp_BrowseNumber = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.BrowseNumber, objvgs_PaperAttention_Cond.BrowseNumber, strComparisonOp_BrowseNumber);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.UserId) == true)
{
string strComparisonOp_UserId = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.UserId, objvgs_PaperAttention_Cond.UserId, strComparisonOp_UserId);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.PaperGroupId) == true)
{
string strComparisonOp_PaperGroupId = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.PaperGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperGroupId, objvgs_PaperAttention_Cond.PaperGroupId, strComparisonOp_PaperGroupId);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.UpdUser, objvgs_PaperAttention_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.UpdDate, objvgs_PaperAttention_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.Meno) == true)
{
string strComparisonOp_Meno = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.Meno, objvgs_PaperAttention_Cond.Meno, strComparisonOp_Meno);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.PaperGroupName) == true)
{
string strComparisonOp_PaperGroupName = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.PaperGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperGroupName, objvgs_PaperAttention_Cond.PaperGroupName, strComparisonOp_PaperGroupName);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.PaperQCount) == true)
{
string strComparisonOp_PaperQCount = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.PaperQCount, objvgs_PaperAttention_Cond.PaperQCount, strComparisonOp_PaperQCount);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.SubVCount) == true)
{
string strComparisonOp_SubVCount = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.SubVCount, objvgs_PaperAttention_Cond.SubVCount, strComparisonOp_SubVCount);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.TagsCount) == true)
{
string strComparisonOp_TagsCount = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.TagsCount, objvgs_PaperAttention_Cond.TagsCount, strComparisonOp_TagsCount);
}
if (objvgs_PaperAttention_Cond.IsUpdated(convgs_PaperAttention.TeaQCount) == true)
{
string strComparisonOp_TeaQCount = objvgs_PaperAttention_Cond.dicFldComparisonOp[convgs_PaperAttention.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.TeaQCount, objvgs_PaperAttention_Cond.TeaQCount, strComparisonOp_TeaQCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 论文关注视图(vgs_PaperAttention)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PaperAttentionWApi
{
private static readonly string mstrApiControllerName = "vgs_PaperAttentionApi";

 public clsvgs_PaperAttentionWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperAttentionEN GetObjByPaperAttentionId(long lngPaperAttentionId)
{
string strAction = "GetObjByPaperAttentionId";
string strErrMsg = string.Empty;
string strResult = "";
clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAttentionId"] = lngPaperAttentionId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvgs_PaperAttentionEN = JsonConvert.DeserializeObject<clsvgs_PaperAttentionEN>((string)jobjReturn["ReturnObj"]);
return objvgs_PaperAttentionEN;
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
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperAttentionEN GetObjByPaperAttentionId_WA_Cache(long lngPaperAttentionId, string strUserId)
{
string strAction = "GetObjByPaperAttentionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAttentionId"] = lngPaperAttentionId.ToString(),
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvgs_PaperAttentionEN = JsonConvert.DeserializeObject<clsvgs_PaperAttentionEN>((string)jobjReturn["ReturnObj"]);
return objvgs_PaperAttentionEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvgs_PaperAttentionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = null;
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
objvgs_PaperAttentionEN = JsonConvert.DeserializeObject<clsvgs_PaperAttentionEN>((string)jobjReturn["ReturnObj"]);
return objvgs_PaperAttentionEN;
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperAttentionEN GetObjByPaperAttentionId_Cache(long lngPaperAttentionId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName_S, strUserId);
List<clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLst_Cache = GetObjLst_Cache(strUserId);
IEnumerable <clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLst_Sel =
from objvgs_PaperAttentionEN in arrvgs_PaperAttentionObjLst_Cache
where objvgs_PaperAttentionEN.PaperAttentionId == lngPaperAttentionId
select objvgs_PaperAttentionEN;
if (arrvgs_PaperAttentionObjLst_Sel.Count() == 0)
{
   clsvgs_PaperAttentionEN obj = clsvgs_PaperAttentionWApi.GetObjByPaperAttentionId(lngPaperAttentionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvgs_PaperAttentionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLst(string strWhereCond)
{
 List<clsvgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst(List<long> arrPaperAttentionId)
{
 List<clsvgs_PaperAttentionEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperAttentionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperAttentionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst_Cache(List<long> arrPaperAttentionId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName_S, strUserId);
List<clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLst_Cache = GetObjLst_Cache(strUserId);
IEnumerable <clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLst_Sel =
from objvgs_PaperAttentionEN in arrvgs_PaperAttentionObjLst_Cache
where arrPaperAttentionId.Contains(objvgs_PaperAttentionEN.PaperAttentionId)
select objvgs_PaperAttentionEN;
return arrvgs_PaperAttentionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst_WA_Cache(List<long> arrPaperAttentionId, string strUserId)
{
 List<clsvgs_PaperAttentionEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperAttentionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperAttentionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvgs_PaperAttentionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngPaperAttentionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAttentionId"] = lngPaperAttentionId.ToString()
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionENS">源对象</param>
 /// <param name = "objvgs_PaperAttentionENT">目标对象</param>
 public static void CopyTo(clsvgs_PaperAttentionEN objvgs_PaperAttentionENS, clsvgs_PaperAttentionEN objvgs_PaperAttentionENT)
{
try
{
objvgs_PaperAttentionENT.PaperAttentionId = objvgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objvgs_PaperAttentionENT.PaperId = objvgs_PaperAttentionENS.PaperId; //论文Id
objvgs_PaperAttentionENT.PaperTitle = objvgs_PaperAttentionENS.PaperTitle; //论文标题
objvgs_PaperAttentionENT.Author = objvgs_PaperAttentionENS.Author; //作者
objvgs_PaperAttentionENT.Keyword = objvgs_PaperAttentionENS.Keyword; //关键字
objvgs_PaperAttentionENT.BrowseNumber = objvgs_PaperAttentionENS.BrowseNumber; //浏览量
objvgs_PaperAttentionENT.UserId = objvgs_PaperAttentionENS.UserId; //用户ID
objvgs_PaperAttentionENT.PaperGroupId = objvgs_PaperAttentionENS.PaperGroupId; //组Id
objvgs_PaperAttentionENT.UpdUser = objvgs_PaperAttentionENS.UpdUser; //修改人
objvgs_PaperAttentionENT.UpdDate = objvgs_PaperAttentionENS.UpdDate; //修改日期
objvgs_PaperAttentionENT.Meno = objvgs_PaperAttentionENS.Meno; //备注
objvgs_PaperAttentionENT.PaperGroupName = objvgs_PaperAttentionENS.PaperGroupName; //组名
objvgs_PaperAttentionENT.PaperQCount = objvgs_PaperAttentionENS.PaperQCount; //论文答疑数
objvgs_PaperAttentionENT.SubVCount = objvgs_PaperAttentionENS.SubVCount; //论文子观点数
objvgs_PaperAttentionENT.TagsCount = objvgs_PaperAttentionENS.TagsCount; //论文标注数
objvgs_PaperAttentionENT.TeaQCount = objvgs_PaperAttentionENS.TeaQCount; //教师提问数
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
public static DataTable ToDataTable(List<clsvgs_PaperAttentionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvgs_PaperAttentionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvgs_PaperAttentionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvgs_PaperAttentionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvgs_PaperAttentionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvgs_PaperAttentionEN.AttributeName)
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
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperAttentionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperAttentionWApi没有刷新缓存机制(clsgs_PaperAttentionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperGroupWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperGroupWApi没有刷新缓存机制(clsgs_PaperGroupWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperAttentionId");
//if (arrvgs_PaperAttentionObjLst_Cache == null)
//{
//arrvgs_PaperAttentionObjLst_Cache = await clsvgs_PaperAttentionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName_S, strUserId);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLst_Cache(string strUserId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName_S, strUserId);
List<clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("UserId='{0}'", strUserId)); });
return arrvgs_PaperAttentionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvgs_PaperAttentionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convgs_PaperAttention.PaperAttentionId, Type.GetType("System.Int64"));
objDT.Columns.Add(convgs_PaperAttention.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.Author, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.BrowseNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convgs_PaperAttention.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.PaperGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.Meno, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.PaperGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convgs_PaperAttention.PaperQCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convgs_PaperAttention.SubVCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convgs_PaperAttention.TagsCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convgs_PaperAttention.TeaQCount, Type.GetType("System.Int32"));
foreach (clsvgs_PaperAttentionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convgs_PaperAttention.PaperAttentionId] = objInFor[convgs_PaperAttention.PaperAttentionId];
objDR[convgs_PaperAttention.PaperId] = objInFor[convgs_PaperAttention.PaperId];
objDR[convgs_PaperAttention.PaperTitle] = objInFor[convgs_PaperAttention.PaperTitle];
objDR[convgs_PaperAttention.Author] = objInFor[convgs_PaperAttention.Author];
objDR[convgs_PaperAttention.Keyword] = objInFor[convgs_PaperAttention.Keyword];
objDR[convgs_PaperAttention.BrowseNumber] = objInFor[convgs_PaperAttention.BrowseNumber];
objDR[convgs_PaperAttention.UserId] = objInFor[convgs_PaperAttention.UserId];
objDR[convgs_PaperAttention.PaperGroupId] = objInFor[convgs_PaperAttention.PaperGroupId];
objDR[convgs_PaperAttention.UpdUser] = objInFor[convgs_PaperAttention.UpdUser];
objDR[convgs_PaperAttention.UpdDate] = objInFor[convgs_PaperAttention.UpdDate];
objDR[convgs_PaperAttention.Meno] = objInFor[convgs_PaperAttention.Meno];
objDR[convgs_PaperAttention.PaperGroupName] = objInFor[convgs_PaperAttention.PaperGroupName];
objDR[convgs_PaperAttention.PaperQCount] = objInFor[convgs_PaperAttention.PaperQCount];
objDR[convgs_PaperAttention.SubVCount] = objInFor[convgs_PaperAttention.SubVCount];
objDR[convgs_PaperAttention.TagsCount] = objInFor[convgs_PaperAttention.TagsCount];
objDR[convgs_PaperAttention.TeaQCount] = objInFor[convgs_PaperAttention.TeaQCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}