
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperSimBL
 表名:vzx_PaperSim(01120848)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clsvzx_PaperSimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_PaperSimEN GetObj(this K_TextId_vzx_PaperSim myKey)
{
clsvzx_PaperSimEN objvzx_PaperSimEN = clsvzx_PaperSimBL.vzx_PaperSimDA.GetObjByTextId(myKey.Value);
return objvzx_PaperSimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetEduClsName(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convzx_PaperSim.EduClsName);
}
objvzx_PaperSimEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.EduClsName) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.EduClsName, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.EduClsName] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetCollegeName(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convzx_PaperSim.CollegeName);
}
objvzx_PaperSimEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.CollegeName) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.CollegeName, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.CollegeName] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetMajorName(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convzx_PaperSim.MajorName);
}
objvzx_PaperSimEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.MajorName) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.MajorName, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.MajorName] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetIdXzMajor(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convzx_PaperSim.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convzx_PaperSim.IdXzMajor);
}
objvzx_PaperSimEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.IdXzMajor) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.IdXzMajor, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.IdXzMajor] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetIdXzCollege(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convzx_PaperSim.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convzx_PaperSim.IdXzCollege);
}
objvzx_PaperSimEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.IdXzCollege) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.IdXzCollege, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.IdXzCollege] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetIsGSuser(this clsvzx_PaperSimEN objvzx_PaperSimEN, bool bolIsGSuser, string strComparisonOp="")
	{
objvzx_PaperSimEN.IsGSuser = bolIsGSuser; //是否GS用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.IsGSuser) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.IsGSuser, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.IsGSuser] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetUserName(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_PaperSim.UserName);
}
objvzx_PaperSimEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.UserName) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.UserName, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.UserName] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTextId(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_PaperSim.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_PaperSim.TextId);
}
objvzx_PaperSimEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TextId) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TextId, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TextId] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTextTitle(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strTextTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextTitle, convzx_PaperSim.TextTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_PaperSim.TextTitle);
}
objvzx_PaperSimEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TextTitle) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TextTitle, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TextTitle] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTextContent(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strTextContent, string strComparisonOp="")
	{
objvzx_PaperSimEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TextContent) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TextContent, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TextContent] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetEdition(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strEdition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEdition, 100, convzx_PaperSim.Edition);
}
objvzx_PaperSimEN.Edition = strEdition; //Edition
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.Edition) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.Edition, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.Edition] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetAuthor(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_PaperSim.Author);
}
objvzx_PaperSimEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.Author) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.Author, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.Author] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetResearchQuestion(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convzx_PaperSim.ResearchQuestion);
}
objvzx_PaperSimEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.ResearchQuestion) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.ResearchQuestion, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.ResearchQuestion] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetUpdDate(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_PaperSim.UpdDate);
}
objvzx_PaperSimEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.UpdDate) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.UpdDate, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.UpdDate] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTeaQCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intTeaQCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TeaQCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TeaQCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TeaQCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTagsCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intTagsCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TagsCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TagsCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TagsCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetSubVCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intSubVCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.SubVCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.SubVCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.SubVCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetPaperQCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intPaperQCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.PaperQCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.PaperQCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.PaperQCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetMemo(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_PaperSim.Memo);
}
objvzx_PaperSimEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.Memo) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.Memo, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.Memo] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetGradeId(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeId, 4, convzx_PaperSim.GradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeId, 4, convzx_PaperSim.GradeId);
}
objvzx_PaperSimEN.GradeId = strGradeId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.GradeId) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.GradeId, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.GradeId] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetSchoolTerm(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convzx_PaperSim.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convzx_PaperSim.SchoolTerm);
}
objvzx_PaperSimEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.SchoolTerm) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.SchoolTerm, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.SchoolTerm] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetUnitId(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strUnitId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUnitId, 4, convzx_PaperSim.UnitId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUnitId, 4, convzx_PaperSim.UnitId);
}
objvzx_PaperSimEN.UnitId = strUnitId; //UnitId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.UnitId) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.UnitId, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.UnitId] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetzxShareId(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_PaperSim.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_PaperSim.zxShareId);
}
objvzx_PaperSimEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.zxShareId) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.zxShareId, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.zxShareId] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetIsPublic(this clsvzx_PaperSimEN objvzx_PaperSimEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_PaperSimEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.IsPublic) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.IsPublic, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.IsPublic] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetVersionCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.VersionCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.VersionCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.VersionCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetStuScore(this clsvzx_PaperSimEN objvzx_PaperSimEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_PaperSimEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.StuScore) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.StuScore, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.StuScore] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTeaScore(this clsvzx_PaperSimEN objvzx_PaperSimEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_PaperSimEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TeaScore) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TeaScore, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TeaScore] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetScore(this clsvzx_PaperSimEN objvzx_PaperSimEN, float? fltScore, string strComparisonOp="")
	{
objvzx_PaperSimEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.Score) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.Score, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.Score] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetAppraiseCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.AppraiseCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.AppraiseCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.AppraiseCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetDownloadCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intDownloadCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.DownloadCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.DownloadCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.DownloadCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetCollectionCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.CollectionCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.CollectionCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.CollectionCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetVoteCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.VoteCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.VoteCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.VoteCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetVCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intVCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.VCount = intVCount; //VCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.VCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.VCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.VCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetLiteratureLink(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convzx_PaperSim.LiteratureLink);
}
objvzx_PaperSimEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.LiteratureLink) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.LiteratureLink, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.LiteratureLink] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetUploadfileUrl(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convzx_PaperSim.UploadfileUrl);
}
objvzx_PaperSimEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.UploadfileUrl) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.UploadfileUrl, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.UploadfileUrl] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetIsSubmit(this clsvzx_PaperSimEN objvzx_PaperSimEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_PaperSimEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.IsSubmit) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.IsSubmit, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.IsSubmit] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetIsChecked(this clsvzx_PaperSimEN objvzx_PaperSimEN, bool bolIsChecked, string strComparisonOp="")
	{
objvzx_PaperSimEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.IsChecked) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.IsChecked, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.IsChecked] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetBrowseNumber(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvzx_PaperSimEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.BrowseNumber) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.BrowseNumber, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.BrowseNumber] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetAttachmentCount(this clsvzx_PaperSimEN objvzx_PaperSimEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvzx_PaperSimEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.AttachmentCount) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.AttachmentCount, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.AttachmentCount] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetUpdUser(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_PaperSim.UpdUser);
}
objvzx_PaperSimEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.UpdUser) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.UpdUser, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.UpdUser] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetCreateDate(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_PaperSim.CreateDate);
}
objvzx_PaperSimEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.CreateDate) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.CreateDate, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.CreateDate] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetChecker(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, convzx_PaperSim.Checker);
}
objvzx_PaperSimEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.Checker) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.Checker, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.Checker] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetIdCurrEduCls(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_PaperSim.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_PaperSim.IdCurrEduCls);
}
objvzx_PaperSimEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.IdCurrEduCls) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetKeyword(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convzx_PaperSim.Keyword);
}
objvzx_PaperSimEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.Keyword) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.Keyword, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.Keyword] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetLiteratureSources(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convzx_PaperSim.LiteratureSources);
}
objvzx_PaperSimEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.LiteratureSources) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.LiteratureSources, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.LiteratureSources] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTextTypeId(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strTextTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTypeId, 2, convzx_PaperSim.TextTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextTypeId, 2, convzx_PaperSim.TextTypeId);
}
objvzx_PaperSimEN.TextTypeId = strTextTypeId; //TextTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TextTypeId) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TextTypeId, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TextTypeId] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperSimEN SetTextStatusId(this clsvzx_PaperSimEN objvzx_PaperSimEN, string strTextStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextStatusId, 2, convzx_PaperSim.TextStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextStatusId, 2, convzx_PaperSim.TextStatusId);
}
objvzx_PaperSimEN.TextStatusId = strTextStatusId; //TextStatusId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperSimEN.dicFldComparisonOp.ContainsKey(convzx_PaperSim.TextStatusId) == false)
{
objvzx_PaperSimEN.dicFldComparisonOp.Add(convzx_PaperSim.TextStatusId, strComparisonOp);
}
else
{
objvzx_PaperSimEN.dicFldComparisonOp[convzx_PaperSim.TextStatusId] = strComparisonOp;
}
}
return objvzx_PaperSimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_PaperSimENS">源对象</param>
 /// <param name = "objvzx_PaperSimENT">目标对象</param>
 public static void CopyTo(this clsvzx_PaperSimEN objvzx_PaperSimENS, clsvzx_PaperSimEN objvzx_PaperSimENT)
{
try
{
objvzx_PaperSimENT.EduClsName = objvzx_PaperSimENS.EduClsName; //教学班名
objvzx_PaperSimENT.CollegeName = objvzx_PaperSimENS.CollegeName; //学院名称
objvzx_PaperSimENT.MajorName = objvzx_PaperSimENS.MajorName; //专业名称
objvzx_PaperSimENT.IdXzMajor = objvzx_PaperSimENS.IdXzMajor; //专业流水号
objvzx_PaperSimENT.IdXzCollege = objvzx_PaperSimENS.IdXzCollege; //学院流水号
objvzx_PaperSimENT.IsGSuser = objvzx_PaperSimENS.IsGSuser; //是否GS用户
objvzx_PaperSimENT.UserName = objvzx_PaperSimENS.UserName; //用户名
objvzx_PaperSimENT.TextId = objvzx_PaperSimENS.TextId; //课件Id
objvzx_PaperSimENT.TextTitle = objvzx_PaperSimENS.TextTitle; //TextTitle
objvzx_PaperSimENT.TextContent = objvzx_PaperSimENS.TextContent; //TextContent
objvzx_PaperSimENT.Edition = objvzx_PaperSimENS.Edition; //Edition
objvzx_PaperSimENT.Author = objvzx_PaperSimENS.Author; //作者
objvzx_PaperSimENT.ResearchQuestion = objvzx_PaperSimENS.ResearchQuestion; //研究问题
objvzx_PaperSimENT.UpdDate = objvzx_PaperSimENS.UpdDate; //修改日期
objvzx_PaperSimENT.TeaQCount = objvzx_PaperSimENS.TeaQCount; //教师提问数
objvzx_PaperSimENT.TagsCount = objvzx_PaperSimENS.TagsCount; //论文标注数
objvzx_PaperSimENT.SubVCount = objvzx_PaperSimENS.SubVCount; //论文子观点数
objvzx_PaperSimENT.PaperQCount = objvzx_PaperSimENS.PaperQCount; //论文答疑数
objvzx_PaperSimENT.Memo = objvzx_PaperSimENS.Memo; //备注
objvzx_PaperSimENT.GradeId = objvzx_PaperSimENS.GradeId; //年级代号
objvzx_PaperSimENT.SchoolTerm = objvzx_PaperSimENS.SchoolTerm; //学期
objvzx_PaperSimENT.UnitId = objvzx_PaperSimENS.UnitId; //UnitId
objvzx_PaperSimENT.zxShareId = objvzx_PaperSimENS.zxShareId; //分享Id
objvzx_PaperSimENT.IsPublic = objvzx_PaperSimENS.IsPublic; //是否公开
objvzx_PaperSimENT.VersionCount = objvzx_PaperSimENS.VersionCount; //版本统计
objvzx_PaperSimENT.StuScore = objvzx_PaperSimENS.StuScore; //学生平均分
objvzx_PaperSimENT.TeaScore = objvzx_PaperSimENS.TeaScore; //教师评分
objvzx_PaperSimENT.Score = objvzx_PaperSimENS.Score; //评分
objvzx_PaperSimENT.AppraiseCount = objvzx_PaperSimENS.AppraiseCount; //评论数
objvzx_PaperSimENT.DownloadCount = objvzx_PaperSimENS.DownloadCount; //下载数
objvzx_PaperSimENT.CollectionCount = objvzx_PaperSimENS.CollectionCount; //收藏数量
objvzx_PaperSimENT.VoteCount = objvzx_PaperSimENS.VoteCount; //点赞计数
objvzx_PaperSimENT.VCount = objvzx_PaperSimENS.VCount; //VCount
objvzx_PaperSimENT.LiteratureLink = objvzx_PaperSimENS.LiteratureLink; //文献链接
objvzx_PaperSimENT.UploadfileUrl = objvzx_PaperSimENS.UploadfileUrl; //文件地址
objvzx_PaperSimENT.IsSubmit = objvzx_PaperSimENS.IsSubmit; //是否提交
objvzx_PaperSimENT.IsChecked = objvzx_PaperSimENS.IsChecked; //是否检查
objvzx_PaperSimENT.BrowseNumber = objvzx_PaperSimENS.BrowseNumber; //浏览量
objvzx_PaperSimENT.AttachmentCount = objvzx_PaperSimENS.AttachmentCount; //附件计数
objvzx_PaperSimENT.UpdUser = objvzx_PaperSimENS.UpdUser; //修改人
objvzx_PaperSimENT.CreateDate = objvzx_PaperSimENS.CreateDate; //建立日期
objvzx_PaperSimENT.Checker = objvzx_PaperSimENS.Checker; //审核人
objvzx_PaperSimENT.IdCurrEduCls = objvzx_PaperSimENS.IdCurrEduCls; //教学班流水号
objvzx_PaperSimENT.Keyword = objvzx_PaperSimENS.Keyword; //关键字
objvzx_PaperSimENT.LiteratureSources = objvzx_PaperSimENS.LiteratureSources; //文献来源
objvzx_PaperSimENT.TextTypeId = objvzx_PaperSimENS.TextTypeId; //TextTypeId
objvzx_PaperSimENT.TextStatusId = objvzx_PaperSimENS.TextStatusId; //TextStatusId
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
 /// <param name = "objvzx_PaperSimENS">源对象</param>
 /// <returns>目标对象=>clsvzx_PaperSimEN:objvzx_PaperSimENT</returns>
 public static clsvzx_PaperSimEN CopyTo(this clsvzx_PaperSimEN objvzx_PaperSimENS)
{
try
{
 clsvzx_PaperSimEN objvzx_PaperSimENT = new clsvzx_PaperSimEN()
{
EduClsName = objvzx_PaperSimENS.EduClsName, //教学班名
CollegeName = objvzx_PaperSimENS.CollegeName, //学院名称
MajorName = objvzx_PaperSimENS.MajorName, //专业名称
IdXzMajor = objvzx_PaperSimENS.IdXzMajor, //专业流水号
IdXzCollege = objvzx_PaperSimENS.IdXzCollege, //学院流水号
IsGSuser = objvzx_PaperSimENS.IsGSuser, //是否GS用户
UserName = objvzx_PaperSimENS.UserName, //用户名
TextId = objvzx_PaperSimENS.TextId, //课件Id
TextTitle = objvzx_PaperSimENS.TextTitle, //TextTitle
TextContent = objvzx_PaperSimENS.TextContent, //TextContent
Edition = objvzx_PaperSimENS.Edition, //Edition
Author = objvzx_PaperSimENS.Author, //作者
ResearchQuestion = objvzx_PaperSimENS.ResearchQuestion, //研究问题
UpdDate = objvzx_PaperSimENS.UpdDate, //修改日期
TeaQCount = objvzx_PaperSimENS.TeaQCount, //教师提问数
TagsCount = objvzx_PaperSimENS.TagsCount, //论文标注数
SubVCount = objvzx_PaperSimENS.SubVCount, //论文子观点数
PaperQCount = objvzx_PaperSimENS.PaperQCount, //论文答疑数
Memo = objvzx_PaperSimENS.Memo, //备注
GradeId = objvzx_PaperSimENS.GradeId, //年级代号
SchoolTerm = objvzx_PaperSimENS.SchoolTerm, //学期
UnitId = objvzx_PaperSimENS.UnitId, //UnitId
zxShareId = objvzx_PaperSimENS.zxShareId, //分享Id
IsPublic = objvzx_PaperSimENS.IsPublic, //是否公开
VersionCount = objvzx_PaperSimENS.VersionCount, //版本统计
StuScore = objvzx_PaperSimENS.StuScore, //学生平均分
TeaScore = objvzx_PaperSimENS.TeaScore, //教师评分
Score = objvzx_PaperSimENS.Score, //评分
AppraiseCount = objvzx_PaperSimENS.AppraiseCount, //评论数
DownloadCount = objvzx_PaperSimENS.DownloadCount, //下载数
CollectionCount = objvzx_PaperSimENS.CollectionCount, //收藏数量
VoteCount = objvzx_PaperSimENS.VoteCount, //点赞计数
VCount = objvzx_PaperSimENS.VCount, //VCount
LiteratureLink = objvzx_PaperSimENS.LiteratureLink, //文献链接
UploadfileUrl = objvzx_PaperSimENS.UploadfileUrl, //文件地址
IsSubmit = objvzx_PaperSimENS.IsSubmit, //是否提交
IsChecked = objvzx_PaperSimENS.IsChecked, //是否检查
BrowseNumber = objvzx_PaperSimENS.BrowseNumber, //浏览量
AttachmentCount = objvzx_PaperSimENS.AttachmentCount, //附件计数
UpdUser = objvzx_PaperSimENS.UpdUser, //修改人
CreateDate = objvzx_PaperSimENS.CreateDate, //建立日期
Checker = objvzx_PaperSimENS.Checker, //审核人
IdCurrEduCls = objvzx_PaperSimENS.IdCurrEduCls, //教学班流水号
Keyword = objvzx_PaperSimENS.Keyword, //关键字
LiteratureSources = objvzx_PaperSimENS.LiteratureSources, //文献来源
TextTypeId = objvzx_PaperSimENS.TextTypeId, //TextTypeId
TextStatusId = objvzx_PaperSimENS.TextStatusId, //TextStatusId
};
 return objvzx_PaperSimENT;
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
public static void CheckProperty4Condition(this clsvzx_PaperSimEN objvzx_PaperSimEN)
{
 clsvzx_PaperSimBL.vzx_PaperSimDA.CheckProperty4Condition(objvzx_PaperSimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_PaperSimEN objvzx_PaperSimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.EduClsName) == true)
{
string strComparisonOpEduClsName = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.EduClsName, objvzx_PaperSimCond.EduClsName, strComparisonOpEduClsName);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.CollegeName) == true)
{
string strComparisonOpCollegeName = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.CollegeName, objvzx_PaperSimCond.CollegeName, strComparisonOpCollegeName);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.MajorName) == true)
{
string strComparisonOpMajorName = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.MajorName, objvzx_PaperSimCond.MajorName, strComparisonOpMajorName);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.IdXzMajor, objvzx_PaperSimCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.IdXzCollege, objvzx_PaperSimCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.IsGSuser) == true)
{
if (objvzx_PaperSimCond.IsGSuser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_PaperSim.IsGSuser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_PaperSim.IsGSuser);
}
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.UserName) == true)
{
string strComparisonOpUserName = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.UserName, objvzx_PaperSimCond.UserName, strComparisonOpUserName);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.TextId) == true)
{
string strComparisonOpTextId = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.TextId, objvzx_PaperSimCond.TextId, strComparisonOpTextId);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.TextTitle, objvzx_PaperSimCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.Edition) == true)
{
string strComparisonOpEdition = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.Edition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.Edition, objvzx_PaperSimCond.Edition, strComparisonOpEdition);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.Author) == true)
{
string strComparisonOpAuthor = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.Author, objvzx_PaperSimCond.Author, strComparisonOpAuthor);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.ResearchQuestion, objvzx_PaperSimCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.UpdDate, objvzx_PaperSimCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.TeaQCount, objvzx_PaperSimCond.TeaQCount, strComparisonOpTeaQCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.TagsCount) == true)
{
string strComparisonOpTagsCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.TagsCount, objvzx_PaperSimCond.TagsCount, strComparisonOpTagsCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.SubVCount) == true)
{
string strComparisonOpSubVCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.SubVCount, objvzx_PaperSimCond.SubVCount, strComparisonOpSubVCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.PaperQCount, objvzx_PaperSimCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.Memo) == true)
{
string strComparisonOpMemo = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.Memo, objvzx_PaperSimCond.Memo, strComparisonOpMemo);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.GradeId) == true)
{
string strComparisonOpGradeId = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.GradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.GradeId, objvzx_PaperSimCond.GradeId, strComparisonOpGradeId);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.SchoolTerm, objvzx_PaperSimCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.UnitId) == true)
{
string strComparisonOpUnitId = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.UnitId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.UnitId, objvzx_PaperSimCond.UnitId, strComparisonOpUnitId);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.zxShareId, objvzx_PaperSimCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.IsPublic) == true)
{
if (objvzx_PaperSimCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_PaperSim.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_PaperSim.IsPublic);
}
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.VersionCount, objvzx_PaperSimCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.StuScore, objvzx_PaperSimCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.TeaScore, objvzx_PaperSimCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.Score) == true)
{
string strComparisonOpScore = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.Score, objvzx_PaperSimCond.Score, strComparisonOpScore);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.AppraiseCount, objvzx_PaperSimCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.DownloadCount, objvzx_PaperSimCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.CollectionCount, objvzx_PaperSimCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.VoteCount, objvzx_PaperSimCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.VCount) == true)
{
string strComparisonOpVCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.VCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.VCount, objvzx_PaperSimCond.VCount, strComparisonOpVCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.LiteratureLink, objvzx_PaperSimCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.UploadfileUrl, objvzx_PaperSimCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.IsSubmit) == true)
{
if (objvzx_PaperSimCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_PaperSim.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_PaperSim.IsSubmit);
}
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.IsChecked) == true)
{
if (objvzx_PaperSimCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_PaperSim.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_PaperSim.IsChecked);
}
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.BrowseNumber, objvzx_PaperSimCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperSim.AttachmentCount, objvzx_PaperSimCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.UpdUser, objvzx_PaperSimCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.CreateDate, objvzx_PaperSimCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.Checker) == true)
{
string strComparisonOpChecker = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.Checker, objvzx_PaperSimCond.Checker, strComparisonOpChecker);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.IdCurrEduCls, objvzx_PaperSimCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.Keyword) == true)
{
string strComparisonOpKeyword = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.Keyword, objvzx_PaperSimCond.Keyword, strComparisonOpKeyword);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.LiteratureSources, objvzx_PaperSimCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.TextTypeId) == true)
{
string strComparisonOpTextTypeId = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.TextTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.TextTypeId, objvzx_PaperSimCond.TextTypeId, strComparisonOpTextTypeId);
}
if (objvzx_PaperSimCond.IsUpdated(convzx_PaperSim.TextStatusId) == true)
{
string strComparisonOpTextStatusId = objvzx_PaperSimCond.dicFldComparisonOp[convzx_PaperSim.TextStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperSim.TextStatusId, objvzx_PaperSimCond.TextStatusId, strComparisonOpTextStatusId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_PaperSim
{
public virtual bool UpdRelaTabDate(string strTextId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_PaperSim(vzx_PaperSim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_PaperSimBL
{
public static RelatedActions_vzx_PaperSim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_PaperSimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_PaperSimDA vzx_PaperSimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_PaperSimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_PaperSimBL()
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
if (string.IsNullOrEmpty(clsvzx_PaperSimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_PaperSimEN._ConnectString);
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
public static DataTable GetDataTable_vzx_PaperSim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_PaperSimDA.GetDataTable_vzx_PaperSim(strWhereCond);
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
objDT = vzx_PaperSimDA.GetDataTable(strWhereCond);
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
objDT = vzx_PaperSimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_PaperSimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_PaperSimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_PaperSimDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_PaperSimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_PaperSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_PaperSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTextIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_PaperSimEN> GetObjLstByTextIdLst(List<string> arrTextIdLst)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTextIdLst, true);
 string strWhereCond = string.Format("TextId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTextIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_PaperSimEN> GetObjLstByTextIdLstCache(List<string> arrTextIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_PaperSimEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_PaperSimEN> arrvzx_PaperSimObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_PaperSimEN> arrvzx_PaperSimObjLst_Sel =
arrvzx_PaperSimObjLstCache
.Where(x => arrTextIdLst.Contains(x.TextId));
return arrvzx_PaperSimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperSimEN> GetObjLst(string strWhereCond)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
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
public static List<clsvzx_PaperSimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_PaperSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_PaperSimEN> GetSubObjLstCache(clsvzx_PaperSimEN objvzx_PaperSimCond)
{
 string strIdCurrEduCls = objvzx_PaperSimCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_PaperSimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_PaperSimEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_PaperSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_PaperSim.AttributeName)
{
if (objvzx_PaperSimCond.IsUpdated(strFldName) == false) continue;
if (objvzx_PaperSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperSimCond[strFldName].ToString());
}
else
{
if (objvzx_PaperSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_PaperSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_PaperSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_PaperSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_PaperSimCond[strFldName]));
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
public static List<clsvzx_PaperSimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
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
public static List<clsvzx_PaperSimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
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
List<clsvzx_PaperSimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_PaperSimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperSimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_PaperSimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
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
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
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
public static List<clsvzx_PaperSimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_PaperSimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_PaperSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
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
public static List<clsvzx_PaperSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperSimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_PaperSimEN> arrObjLst = new List<clsvzx_PaperSimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperSimEN objvzx_PaperSimEN = new clsvzx_PaperSimEN();
try
{
objvzx_PaperSimEN.EduClsName = objRow[convzx_PaperSim.EduClsName] == DBNull.Value ? null : objRow[convzx_PaperSim.EduClsName].ToString().Trim(); //教学班名
objvzx_PaperSimEN.CollegeName = objRow[convzx_PaperSim.CollegeName] == DBNull.Value ? null : objRow[convzx_PaperSim.CollegeName].ToString().Trim(); //学院名称
objvzx_PaperSimEN.MajorName = objRow[convzx_PaperSim.MajorName] == DBNull.Value ? null : objRow[convzx_PaperSim.MajorName].ToString().Trim(); //专业名称
objvzx_PaperSimEN.IdXzMajor = objRow[convzx_PaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_PaperSimEN.IdXzCollege = objRow[convzx_PaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convzx_PaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_PaperSimEN.IsGSuser = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsGSuser].ToString().Trim()); //是否GS用户
objvzx_PaperSimEN.UserName = objRow[convzx_PaperSim.UserName] == DBNull.Value ? null : objRow[convzx_PaperSim.UserName].ToString().Trim(); //用户名
objvzx_PaperSimEN.TextId = objRow[convzx_PaperSim.TextId].ToString().Trim(); //课件Id
objvzx_PaperSimEN.TextTitle = objRow[convzx_PaperSim.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperSimEN.TextContent = objRow[convzx_PaperSim.TextContent] == DBNull.Value ? null : objRow[convzx_PaperSim.TextContent].ToString().Trim(); //TextContent
objvzx_PaperSimEN.Edition = objRow[convzx_PaperSim.Edition] == DBNull.Value ? null : objRow[convzx_PaperSim.Edition].ToString().Trim(); //Edition
objvzx_PaperSimEN.Author = objRow[convzx_PaperSim.Author] == DBNull.Value ? null : objRow[convzx_PaperSim.Author].ToString().Trim(); //作者
objvzx_PaperSimEN.ResearchQuestion = objRow[convzx_PaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_PaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_PaperSimEN.UpdDate = objRow[convzx_PaperSim.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperSimEN.TeaQCount = objRow[convzx_PaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvzx_PaperSimEN.TagsCount = objRow[convzx_PaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.TagsCount].ToString().Trim()); //论文标注数
objvzx_PaperSimEN.SubVCount = objRow[convzx_PaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvzx_PaperSimEN.PaperQCount = objRow[convzx_PaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_PaperSimEN.Memo = objRow[convzx_PaperSim.Memo] == DBNull.Value ? null : objRow[convzx_PaperSim.Memo].ToString().Trim(); //备注
objvzx_PaperSimEN.GradeId = objRow[convzx_PaperSim.GradeId] == DBNull.Value ? null : objRow[convzx_PaperSim.GradeId].ToString().Trim(); //年级代号
objvzx_PaperSimEN.SchoolTerm = objRow[convzx_PaperSim.SchoolTerm] == DBNull.Value ? null : objRow[convzx_PaperSim.SchoolTerm].ToString().Trim(); //学期
objvzx_PaperSimEN.UnitId = objRow[convzx_PaperSim.UnitId] == DBNull.Value ? null : objRow[convzx_PaperSim.UnitId].ToString().Trim(); //UnitId
objvzx_PaperSimEN.zxShareId = objRow[convzx_PaperSim.zxShareId] == DBNull.Value ? null : objRow[convzx_PaperSim.zxShareId].ToString().Trim(); //分享Id
objvzx_PaperSimEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsPublic].ToString().Trim()); //是否公开
objvzx_PaperSimEN.VersionCount = objRow[convzx_PaperSim.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperSimEN.StuScore = objRow[convzx_PaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperSimEN.TeaScore = objRow[convzx_PaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperSimEN.Score = objRow[convzx_PaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperSim.Score].ToString().Trim()); //评分
objvzx_PaperSimEN.AppraiseCount = objRow[convzx_PaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AppraiseCount].ToString().Trim()); //评论数
objvzx_PaperSimEN.DownloadCount = objRow[convzx_PaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.DownloadCount].ToString().Trim()); //下载数
objvzx_PaperSimEN.CollectionCount = objRow[convzx_PaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvzx_PaperSimEN.VoteCount = objRow[convzx_PaperSim.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperSimEN.VCount = objRow[convzx_PaperSim.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.VCount].ToString().Trim()); //VCount
objvzx_PaperSimEN.LiteratureLink = objRow[convzx_PaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvzx_PaperSimEN.UploadfileUrl = objRow[convzx_PaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_PaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_PaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperSim.IsChecked].ToString().Trim()); //是否检查
objvzx_PaperSimEN.BrowseNumber = objRow[convzx_PaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvzx_PaperSimEN.AttachmentCount = objRow[convzx_PaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvzx_PaperSimEN.UpdUser = objRow[convzx_PaperSim.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperSim.UpdUser].ToString().Trim(); //修改人
objvzx_PaperSimEN.CreateDate = objRow[convzx_PaperSim.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperSim.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperSimEN.Checker = objRow[convzx_PaperSim.Checker] == DBNull.Value ? null : objRow[convzx_PaperSim.Checker].ToString().Trim(); //审核人
objvzx_PaperSimEN.IdCurrEduCls = objRow[convzx_PaperSim.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperSim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperSimEN.Keyword = objRow[convzx_PaperSim.Keyword] == DBNull.Value ? null : objRow[convzx_PaperSim.Keyword].ToString().Trim(); //关键字
objvzx_PaperSimEN.LiteratureSources = objRow[convzx_PaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convzx_PaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvzx_PaperSimEN.TextTypeId = objRow[convzx_PaperSim.TextTypeId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextTypeId].ToString().Trim(); //TextTypeId
objvzx_PaperSimEN.TextStatusId = objRow[convzx_PaperSim.TextStatusId] == DBNull.Value ? null : objRow[convzx_PaperSim.TextStatusId].ToString().Trim(); //TextStatusId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperSimEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperSimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_PaperSimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_PaperSim(ref clsvzx_PaperSimEN objvzx_PaperSimEN)
{
bool bolResult = vzx_PaperSimDA.Getvzx_PaperSim(ref objvzx_PaperSimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_PaperSimEN GetObjByTextId(string strTextId)
{
if (strTextId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTextId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTextId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTextId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_PaperSimEN objvzx_PaperSimEN = vzx_PaperSimDA.GetObjByTextId(strTextId);
return objvzx_PaperSimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_PaperSimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_PaperSimEN objvzx_PaperSimEN = vzx_PaperSimDA.GetFirstObj(strWhereCond);
 return objvzx_PaperSimEN;
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
public static clsvzx_PaperSimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_PaperSimEN objvzx_PaperSimEN = vzx_PaperSimDA.GetObjByDataRow(objRow);
 return objvzx_PaperSimEN;
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
public static clsvzx_PaperSimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_PaperSimEN objvzx_PaperSimEN = vzx_PaperSimDA.GetObjByDataRow(objRow);
 return objvzx_PaperSimEN;
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
 /// <param name = "strTextId">所给的关键字</param>
 /// <param name = "lstvzx_PaperSimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_PaperSimEN GetObjByTextIdFromList(string strTextId, List<clsvzx_PaperSimEN> lstvzx_PaperSimObjLst)
{
foreach (clsvzx_PaperSimEN objvzx_PaperSimEN in lstvzx_PaperSimObjLst)
{
if (objvzx_PaperSimEN.TextId == strTextId)
{
return objvzx_PaperSimEN;
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
 string strMaxTextId;
 try
 {
 strMaxTextId = clsvzx_PaperSimDA.GetMaxStrId();
 return strMaxTextId;
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
 string strTextId;
 try
 {
 strTextId = new clsvzx_PaperSimDA().GetFirstID(strWhereCond);
 return strTextId;
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
 arrList = vzx_PaperSimDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_PaperSimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTextId)
{
if (string.IsNullOrEmpty(strTextId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTextId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_PaperSimDA.IsExist(strTextId);
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
 bolIsExist = clsvzx_PaperSimDA.IsExistTable();
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
 bolIsExist = vzx_PaperSimDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_PaperSimENS">源对象</param>
 /// <param name = "objvzx_PaperSimENT">目标对象</param>
 public static void CopyTo(clsvzx_PaperSimEN objvzx_PaperSimENS, clsvzx_PaperSimEN objvzx_PaperSimENT)
{
try
{
objvzx_PaperSimENT.EduClsName = objvzx_PaperSimENS.EduClsName; //教学班名
objvzx_PaperSimENT.CollegeName = objvzx_PaperSimENS.CollegeName; //学院名称
objvzx_PaperSimENT.MajorName = objvzx_PaperSimENS.MajorName; //专业名称
objvzx_PaperSimENT.IdXzMajor = objvzx_PaperSimENS.IdXzMajor; //专业流水号
objvzx_PaperSimENT.IdXzCollege = objvzx_PaperSimENS.IdXzCollege; //学院流水号
objvzx_PaperSimENT.IsGSuser = objvzx_PaperSimENS.IsGSuser; //是否GS用户
objvzx_PaperSimENT.UserName = objvzx_PaperSimENS.UserName; //用户名
objvzx_PaperSimENT.TextId = objvzx_PaperSimENS.TextId; //课件Id
objvzx_PaperSimENT.TextTitle = objvzx_PaperSimENS.TextTitle; //TextTitle
objvzx_PaperSimENT.TextContent = objvzx_PaperSimENS.TextContent; //TextContent
objvzx_PaperSimENT.Edition = objvzx_PaperSimENS.Edition; //Edition
objvzx_PaperSimENT.Author = objvzx_PaperSimENS.Author; //作者
objvzx_PaperSimENT.ResearchQuestion = objvzx_PaperSimENS.ResearchQuestion; //研究问题
objvzx_PaperSimENT.UpdDate = objvzx_PaperSimENS.UpdDate; //修改日期
objvzx_PaperSimENT.TeaQCount = objvzx_PaperSimENS.TeaQCount; //教师提问数
objvzx_PaperSimENT.TagsCount = objvzx_PaperSimENS.TagsCount; //论文标注数
objvzx_PaperSimENT.SubVCount = objvzx_PaperSimENS.SubVCount; //论文子观点数
objvzx_PaperSimENT.PaperQCount = objvzx_PaperSimENS.PaperQCount; //论文答疑数
objvzx_PaperSimENT.Memo = objvzx_PaperSimENS.Memo; //备注
objvzx_PaperSimENT.GradeId = objvzx_PaperSimENS.GradeId; //年级代号
objvzx_PaperSimENT.SchoolTerm = objvzx_PaperSimENS.SchoolTerm; //学期
objvzx_PaperSimENT.UnitId = objvzx_PaperSimENS.UnitId; //UnitId
objvzx_PaperSimENT.zxShareId = objvzx_PaperSimENS.zxShareId; //分享Id
objvzx_PaperSimENT.IsPublic = objvzx_PaperSimENS.IsPublic; //是否公开
objvzx_PaperSimENT.VersionCount = objvzx_PaperSimENS.VersionCount; //版本统计
objvzx_PaperSimENT.StuScore = objvzx_PaperSimENS.StuScore; //学生平均分
objvzx_PaperSimENT.TeaScore = objvzx_PaperSimENS.TeaScore; //教师评分
objvzx_PaperSimENT.Score = objvzx_PaperSimENS.Score; //评分
objvzx_PaperSimENT.AppraiseCount = objvzx_PaperSimENS.AppraiseCount; //评论数
objvzx_PaperSimENT.DownloadCount = objvzx_PaperSimENS.DownloadCount; //下载数
objvzx_PaperSimENT.CollectionCount = objvzx_PaperSimENS.CollectionCount; //收藏数量
objvzx_PaperSimENT.VoteCount = objvzx_PaperSimENS.VoteCount; //点赞计数
objvzx_PaperSimENT.VCount = objvzx_PaperSimENS.VCount; //VCount
objvzx_PaperSimENT.LiteratureLink = objvzx_PaperSimENS.LiteratureLink; //文献链接
objvzx_PaperSimENT.UploadfileUrl = objvzx_PaperSimENS.UploadfileUrl; //文件地址
objvzx_PaperSimENT.IsSubmit = objvzx_PaperSimENS.IsSubmit; //是否提交
objvzx_PaperSimENT.IsChecked = objvzx_PaperSimENS.IsChecked; //是否检查
objvzx_PaperSimENT.BrowseNumber = objvzx_PaperSimENS.BrowseNumber; //浏览量
objvzx_PaperSimENT.AttachmentCount = objvzx_PaperSimENS.AttachmentCount; //附件计数
objvzx_PaperSimENT.UpdUser = objvzx_PaperSimENS.UpdUser; //修改人
objvzx_PaperSimENT.CreateDate = objvzx_PaperSimENS.CreateDate; //建立日期
objvzx_PaperSimENT.Checker = objvzx_PaperSimENS.Checker; //审核人
objvzx_PaperSimENT.IdCurrEduCls = objvzx_PaperSimENS.IdCurrEduCls; //教学班流水号
objvzx_PaperSimENT.Keyword = objvzx_PaperSimENS.Keyword; //关键字
objvzx_PaperSimENT.LiteratureSources = objvzx_PaperSimENS.LiteratureSources; //文献来源
objvzx_PaperSimENT.TextTypeId = objvzx_PaperSimENS.TextTypeId; //TextTypeId
objvzx_PaperSimENT.TextStatusId = objvzx_PaperSimENS.TextStatusId; //TextStatusId
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
 /// <param name = "objvzx_PaperSimEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_PaperSimEN objvzx_PaperSimEN)
{
try
{
objvzx_PaperSimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_PaperSimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_PaperSim.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.EduClsName = objvzx_PaperSimEN.EduClsName == "[null]" ? null :  objvzx_PaperSimEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convzx_PaperSim.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.CollegeName = objvzx_PaperSimEN.CollegeName == "[null]" ? null :  objvzx_PaperSimEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convzx_PaperSim.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.MajorName = objvzx_PaperSimEN.MajorName == "[null]" ? null :  objvzx_PaperSimEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convzx_PaperSim.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.IdXzMajor = objvzx_PaperSimEN.IdXzMajor == "[null]" ? null :  objvzx_PaperSimEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convzx_PaperSim.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.IdXzCollege = objvzx_PaperSimEN.IdXzCollege == "[null]" ? null :  objvzx_PaperSimEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convzx_PaperSim.IsGSuser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.IsGSuser = objvzx_PaperSimEN.IsGSuser; //是否GS用户
}
if (arrFldSet.Contains(convzx_PaperSim.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.UserName = objvzx_PaperSimEN.UserName == "[null]" ? null :  objvzx_PaperSimEN.UserName; //用户名
}
if (arrFldSet.Contains(convzx_PaperSim.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TextId = objvzx_PaperSimEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_PaperSim.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TextTitle = objvzx_PaperSimEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_PaperSim.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TextContent = objvzx_PaperSimEN.TextContent == "[null]" ? null :  objvzx_PaperSimEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_PaperSim.Edition, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.Edition = objvzx_PaperSimEN.Edition == "[null]" ? null :  objvzx_PaperSimEN.Edition; //Edition
}
if (arrFldSet.Contains(convzx_PaperSim.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.Author = objvzx_PaperSimEN.Author == "[null]" ? null :  objvzx_PaperSimEN.Author; //作者
}
if (arrFldSet.Contains(convzx_PaperSim.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.ResearchQuestion = objvzx_PaperSimEN.ResearchQuestion == "[null]" ? null :  objvzx_PaperSimEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convzx_PaperSim.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.UpdDate = objvzx_PaperSimEN.UpdDate == "[null]" ? null :  objvzx_PaperSimEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_PaperSim.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TeaQCount = objvzx_PaperSimEN.TeaQCount; //教师提问数
}
if (arrFldSet.Contains(convzx_PaperSim.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TagsCount = objvzx_PaperSimEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convzx_PaperSim.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.SubVCount = objvzx_PaperSimEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convzx_PaperSim.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.PaperQCount = objvzx_PaperSimEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(convzx_PaperSim.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.Memo = objvzx_PaperSimEN.Memo == "[null]" ? null :  objvzx_PaperSimEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_PaperSim.GradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.GradeId = objvzx_PaperSimEN.GradeId == "[null]" ? null :  objvzx_PaperSimEN.GradeId; //年级代号
}
if (arrFldSet.Contains(convzx_PaperSim.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.SchoolTerm = objvzx_PaperSimEN.SchoolTerm == "[null]" ? null :  objvzx_PaperSimEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convzx_PaperSim.UnitId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.UnitId = objvzx_PaperSimEN.UnitId == "[null]" ? null :  objvzx_PaperSimEN.UnitId; //UnitId
}
if (arrFldSet.Contains(convzx_PaperSim.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.zxShareId = objvzx_PaperSimEN.zxShareId == "[null]" ? null :  objvzx_PaperSimEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_PaperSim.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.IsPublic = objvzx_PaperSimEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_PaperSim.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.VersionCount = objvzx_PaperSimEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_PaperSim.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.StuScore = objvzx_PaperSimEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_PaperSim.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TeaScore = objvzx_PaperSimEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_PaperSim.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.Score = objvzx_PaperSimEN.Score; //评分
}
if (arrFldSet.Contains(convzx_PaperSim.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.AppraiseCount = objvzx_PaperSimEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_PaperSim.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.DownloadCount = objvzx_PaperSimEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convzx_PaperSim.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.CollectionCount = objvzx_PaperSimEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convzx_PaperSim.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.VoteCount = objvzx_PaperSimEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_PaperSim.VCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.VCount = objvzx_PaperSimEN.VCount; //VCount
}
if (arrFldSet.Contains(convzx_PaperSim.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.LiteratureLink = objvzx_PaperSimEN.LiteratureLink == "[null]" ? null :  objvzx_PaperSimEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convzx_PaperSim.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.UploadfileUrl = objvzx_PaperSimEN.UploadfileUrl == "[null]" ? null :  objvzx_PaperSimEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convzx_PaperSim.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.IsSubmit = objvzx_PaperSimEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_PaperSim.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.IsChecked = objvzx_PaperSimEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(convzx_PaperSim.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.BrowseNumber = objvzx_PaperSimEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convzx_PaperSim.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.AttachmentCount = objvzx_PaperSimEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convzx_PaperSim.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.UpdUser = objvzx_PaperSimEN.UpdUser == "[null]" ? null :  objvzx_PaperSimEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_PaperSim.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.CreateDate = objvzx_PaperSimEN.CreateDate == "[null]" ? null :  objvzx_PaperSimEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_PaperSim.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.Checker = objvzx_PaperSimEN.Checker == "[null]" ? null :  objvzx_PaperSimEN.Checker; //审核人
}
if (arrFldSet.Contains(convzx_PaperSim.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.IdCurrEduCls = objvzx_PaperSimEN.IdCurrEduCls == "[null]" ? null :  objvzx_PaperSimEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_PaperSim.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.Keyword = objvzx_PaperSimEN.Keyword == "[null]" ? null :  objvzx_PaperSimEN.Keyword; //关键字
}
if (arrFldSet.Contains(convzx_PaperSim.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.LiteratureSources = objvzx_PaperSimEN.LiteratureSources == "[null]" ? null :  objvzx_PaperSimEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convzx_PaperSim.TextTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TextTypeId = objvzx_PaperSimEN.TextTypeId == "[null]" ? null :  objvzx_PaperSimEN.TextTypeId; //TextTypeId
}
if (arrFldSet.Contains(convzx_PaperSim.TextStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperSimEN.TextStatusId = objvzx_PaperSimEN.TextStatusId == "[null]" ? null :  objvzx_PaperSimEN.TextStatusId; //TextStatusId
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
 /// <param name = "objvzx_PaperSimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_PaperSimEN objvzx_PaperSimEN)
{
try
{
if (objvzx_PaperSimEN.EduClsName == "[null]") objvzx_PaperSimEN.EduClsName = null; //教学班名
if (objvzx_PaperSimEN.CollegeName == "[null]") objvzx_PaperSimEN.CollegeName = null; //学院名称
if (objvzx_PaperSimEN.MajorName == "[null]") objvzx_PaperSimEN.MajorName = null; //专业名称
if (objvzx_PaperSimEN.IdXzMajor == "[null]") objvzx_PaperSimEN.IdXzMajor = null; //专业流水号
if (objvzx_PaperSimEN.IdXzCollege == "[null]") objvzx_PaperSimEN.IdXzCollege = null; //学院流水号
if (objvzx_PaperSimEN.UserName == "[null]") objvzx_PaperSimEN.UserName = null; //用户名
if (objvzx_PaperSimEN.TextContent == "[null]") objvzx_PaperSimEN.TextContent = null; //TextContent
if (objvzx_PaperSimEN.Edition == "[null]") objvzx_PaperSimEN.Edition = null; //Edition
if (objvzx_PaperSimEN.Author == "[null]") objvzx_PaperSimEN.Author = null; //作者
if (objvzx_PaperSimEN.ResearchQuestion == "[null]") objvzx_PaperSimEN.ResearchQuestion = null; //研究问题
if (objvzx_PaperSimEN.UpdDate == "[null]") objvzx_PaperSimEN.UpdDate = null; //修改日期
if (objvzx_PaperSimEN.Memo == "[null]") objvzx_PaperSimEN.Memo = null; //备注
if (objvzx_PaperSimEN.GradeId == "[null]") objvzx_PaperSimEN.GradeId = null; //年级代号
if (objvzx_PaperSimEN.SchoolTerm == "[null]") objvzx_PaperSimEN.SchoolTerm = null; //学期
if (objvzx_PaperSimEN.UnitId == "[null]") objvzx_PaperSimEN.UnitId = null; //UnitId
if (objvzx_PaperSimEN.zxShareId == "[null]") objvzx_PaperSimEN.zxShareId = null; //分享Id
if (objvzx_PaperSimEN.LiteratureLink == "[null]") objvzx_PaperSimEN.LiteratureLink = null; //文献链接
if (objvzx_PaperSimEN.UploadfileUrl == "[null]") objvzx_PaperSimEN.UploadfileUrl = null; //文件地址
if (objvzx_PaperSimEN.UpdUser == "[null]") objvzx_PaperSimEN.UpdUser = null; //修改人
if (objvzx_PaperSimEN.CreateDate == "[null]") objvzx_PaperSimEN.CreateDate = null; //建立日期
if (objvzx_PaperSimEN.Checker == "[null]") objvzx_PaperSimEN.Checker = null; //审核人
if (objvzx_PaperSimEN.IdCurrEduCls == "[null]") objvzx_PaperSimEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_PaperSimEN.Keyword == "[null]") objvzx_PaperSimEN.Keyword = null; //关键字
if (objvzx_PaperSimEN.LiteratureSources == "[null]") objvzx_PaperSimEN.LiteratureSources = null; //文献来源
if (objvzx_PaperSimEN.TextTypeId == "[null]") objvzx_PaperSimEN.TextTypeId = null; //TextTypeId
if (objvzx_PaperSimEN.TextStatusId == "[null]") objvzx_PaperSimEN.TextStatusId = null; //TextStatusId
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
public static void CheckProperty4Condition(clsvzx_PaperSimEN objvzx_PaperSimEN)
{
 vzx_PaperSimDA.CheckProperty4Condition(objvzx_PaperSimEN);
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TextId");
//if (arrvzx_PaperSimObjLstCache == null)
//{
//arrvzx_PaperSimObjLstCache = vzx_PaperSimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTextId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_PaperSimEN GetObjByTextIdCache(string strTextId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_PaperSimEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_PaperSimEN> arrvzx_PaperSimObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_PaperSimEN> arrvzx_PaperSimObjLst_Sel =
arrvzx_PaperSimObjLstCache
.Where(x=> x.TextId == strTextId 
);
if (arrvzx_PaperSimObjLst_Sel.Count() == 0)
{
   clsvzx_PaperSimEN obj = clsvzx_PaperSimBL.GetObjByTextId(strTextId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTextId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_PaperSimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_PaperSimEN> GetAllvzx_PaperSimObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_PaperSimEN> arrvzx_PaperSimObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_PaperSimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_PaperSimEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_PaperSimEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_PaperSimEN> arrvzx_PaperSimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_PaperSimObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_PaperSimEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strTextId, string strIdCurrEduCls)
{
if (strInFldName != convzx_PaperSim.TextId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_PaperSim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_PaperSim.AttributeName));
throw new Exception(strMsg);
}
var objvzx_PaperSim = clsvzx_PaperSimBL.GetObjByTextIdCache(strTextId, strIdCurrEduCls);
if (objvzx_PaperSim == null) return "";
return objvzx_PaperSim[strOutFldName].ToString();
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
int intRecCount = clsvzx_PaperSimDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_PaperSimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_PaperSimDA.GetRecCount();
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
int intRecCount = clsvzx_PaperSimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_PaperSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_PaperSimEN objvzx_PaperSimCond)
{
 string strIdCurrEduCls = objvzx_PaperSimCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_PaperSimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_PaperSimEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_PaperSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_PaperSim.AttributeName)
{
if (objvzx_PaperSimCond.IsUpdated(strFldName) == false) continue;
if (objvzx_PaperSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperSimCond[strFldName].ToString());
}
else
{
if (objvzx_PaperSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_PaperSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_PaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_PaperSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_PaperSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_PaperSimCond[strFldName]));
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
 List<string> arrList = clsvzx_PaperSimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_PaperSimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_PaperSimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}