
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PapersBigTopicBL
 表名:vcc_PapersBigTopic(01120078)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsvcc_PapersBigTopicBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PapersBigTopicEN GetObj(this K_PapersBigTopicId_vcc_PapersBigTopic myKey)
{
clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = clsvcc_PapersBigTopicBL.vcc_PapersBigTopicDA.GetObjByPapersBigTopicId(myKey.Value);
return objvcc_PapersBigTopicEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetPapersBigTopicId(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strPapersBigTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicId, 8, convcc_PapersBigTopic.PapersBigTopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicId, 8, convcc_PapersBigTopic.PapersBigTopicId);
}
objvcc_PapersBigTopicEN.PapersBigTopicId = strPapersBigTopicId; //试卷大题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.PapersBigTopicId) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.PapersBigTopicId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetPapersBigTopicName(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPapersBigTopicName, convcc_PapersBigTopic.PapersBigTopicName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_PapersBigTopic.PapersBigTopicName);
}
objvcc_PapersBigTopicEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.PapersBigTopicName) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.PapersBigTopicName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetTopicDescription(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strTopicDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_PapersBigTopic.TopicDescription);
}
objvcc_PapersBigTopicEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.TopicDescription) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.TopicDescription, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.TopicDescription] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetTopicScores(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, int? intTopicScores, string strComparisonOp="")
	{
objvcc_PapersBigTopicEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.TopicScores) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.TopicScores, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.TopicScores] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetCourseExamPaperId(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, convcc_PapersBigTopic.CourseExamPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_PapersBigTopic.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_PapersBigTopic.CourseExamPaperId);
}
objvcc_PapersBigTopicEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.CourseExamPaperId) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetExamPaperName(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_PapersBigTopic.ExamPaperName);
}
objvcc_PapersBigTopicEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.ExamPaperName) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.ExamPaperName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.ExamPaperName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetQuestionTypeId(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId, convcc_PapersBigTopic.QuestionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_PapersBigTopic.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_PapersBigTopic.QuestionTypeId);
}
objvcc_PapersBigTopicEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.QuestionTypeId) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetIsShow(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_PapersBigTopicEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.IsShow) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.IsShow, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.IsShow] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetOrderNum(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_PapersBigTopicEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.OrderNum) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.OrderNum, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.OrderNum] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetUpdDate(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PapersBigTopic.UpdDate);
}
objvcc_PapersBigTopicEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.UpdDate) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.UpdDate, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.UpdDate] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetUpdUser(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_PapersBigTopic.UpdUser);
}
objvcc_PapersBigTopicEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.UpdUser) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.UpdUser, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.UpdUser] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetMemo(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PapersBigTopic.Memo);
}
objvcc_PapersBigTopicEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.Memo) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.Memo, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.Memo] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicEN SetQuestionTypeName(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_PapersBigTopic.QuestionTypeName);
}
objvcc_PapersBigTopicEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopic.QuestionTypeName) == false)
{
objvcc_PapersBigTopicEN.dicFldComparisonOp.Add(convcc_PapersBigTopic.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicEN.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicENS">源对象</param>
 /// <param name = "objvcc_PapersBigTopicENT">目标对象</param>
 public static void CopyTo(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENS, clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENT)
{
try
{
objvcc_PapersBigTopicENT.PapersBigTopicId = objvcc_PapersBigTopicENS.PapersBigTopicId; //试卷大题目Id
objvcc_PapersBigTopicENT.PapersBigTopicName = objvcc_PapersBigTopicENS.PapersBigTopicName; //试卷大题目名称
objvcc_PapersBigTopicENT.TopicDescription = objvcc_PapersBigTopicENS.TopicDescription; //标题描述
objvcc_PapersBigTopicENT.TopicScores = objvcc_PapersBigTopicENS.TopicScores; //大题得分
objvcc_PapersBigTopicENT.CourseExamPaperId = objvcc_PapersBigTopicENS.CourseExamPaperId; //考卷流水号
objvcc_PapersBigTopicENT.ExamPaperName = objvcc_PapersBigTopicENS.ExamPaperName; //考卷名称
objvcc_PapersBigTopicENT.QuestionTypeId = objvcc_PapersBigTopicENS.QuestionTypeId; //题目类型Id
objvcc_PapersBigTopicENT.IsShow = objvcc_PapersBigTopicENS.IsShow; //是否启用
objvcc_PapersBigTopicENT.OrderNum = objvcc_PapersBigTopicENS.OrderNum; //序号
objvcc_PapersBigTopicENT.UpdDate = objvcc_PapersBigTopicENS.UpdDate; //修改日期
objvcc_PapersBigTopicENT.UpdUser = objvcc_PapersBigTopicENS.UpdUser; //修改人
objvcc_PapersBigTopicENT.Memo = objvcc_PapersBigTopicENS.Memo; //备注
objvcc_PapersBigTopicENT.QuestionTypeName = objvcc_PapersBigTopicENS.QuestionTypeName; //题目类型名
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
 /// <param name = "objvcc_PapersBigTopicENS">源对象</param>
 /// <returns>目标对象=>clsvcc_PapersBigTopicEN:objvcc_PapersBigTopicENT</returns>
 public static clsvcc_PapersBigTopicEN CopyTo(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENS)
{
try
{
 clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENT = new clsvcc_PapersBigTopicEN()
{
PapersBigTopicId = objvcc_PapersBigTopicENS.PapersBigTopicId, //试卷大题目Id
PapersBigTopicName = objvcc_PapersBigTopicENS.PapersBigTopicName, //试卷大题目名称
TopicDescription = objvcc_PapersBigTopicENS.TopicDescription, //标题描述
TopicScores = objvcc_PapersBigTopicENS.TopicScores, //大题得分
CourseExamPaperId = objvcc_PapersBigTopicENS.CourseExamPaperId, //考卷流水号
ExamPaperName = objvcc_PapersBigTopicENS.ExamPaperName, //考卷名称
QuestionTypeId = objvcc_PapersBigTopicENS.QuestionTypeId, //题目类型Id
IsShow = objvcc_PapersBigTopicENS.IsShow, //是否启用
OrderNum = objvcc_PapersBigTopicENS.OrderNum, //序号
UpdDate = objvcc_PapersBigTopicENS.UpdDate, //修改日期
UpdUser = objvcc_PapersBigTopicENS.UpdUser, //修改人
Memo = objvcc_PapersBigTopicENS.Memo, //备注
QuestionTypeName = objvcc_PapersBigTopicENS.QuestionTypeName, //题目类型名
};
 return objvcc_PapersBigTopicENT;
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
public static void CheckProperty4Condition(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN)
{
 clsvcc_PapersBigTopicBL.vcc_PapersBigTopicDA.CheckProperty4Condition(objvcc_PapersBigTopicEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PapersBigTopicEN objvcc_PapersBigTopicCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.PapersBigTopicId) == true)
{
string strComparisonOpPapersBigTopicId = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.PapersBigTopicId, objvcc_PapersBigTopicCond.PapersBigTopicId, strComparisonOpPapersBigTopicId);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.PapersBigTopicName) == true)
{
string strComparisonOpPapersBigTopicName = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.PapersBigTopicName, objvcc_PapersBigTopicCond.PapersBigTopicName, strComparisonOpPapersBigTopicName);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.TopicDescription) == true)
{
string strComparisonOpTopicDescription = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.TopicDescription, objvcc_PapersBigTopicCond.TopicDescription, strComparisonOpTopicDescription);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.TopicScores) == true)
{
string strComparisonOpTopicScores = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PapersBigTopic.TopicScores, objvcc_PapersBigTopicCond.TopicScores, strComparisonOpTopicScores);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.CourseExamPaperId, objvcc_PapersBigTopicCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.ExamPaperName, objvcc_PapersBigTopicCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.QuestionTypeId, objvcc_PapersBigTopicCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.IsShow) == true)
{
if (objvcc_PapersBigTopicCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_PapersBigTopic.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_PapersBigTopic.IsShow);
}
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PapersBigTopic.OrderNum, objvcc_PapersBigTopicCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.UpdDate, objvcc_PapersBigTopicCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.UpdUser, objvcc_PapersBigTopicCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.Memo) == true)
{
string strComparisonOpMemo = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.Memo, objvcc_PapersBigTopicCond.Memo, strComparisonOpMemo);
}
if (objvcc_PapersBigTopicCond.IsUpdated(convcc_PapersBigTopic.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvcc_PapersBigTopicCond.dicFldComparisonOp[convcc_PapersBigTopic.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopic.QuestionTypeName, objvcc_PapersBigTopicCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_PapersBigTopic
{
public virtual bool UpdRelaTabDate(string strPapersBigTopicId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 试卷大标题(vcc_PapersBigTopic)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PapersBigTopicBL
{
public static RelatedActions_vcc_PapersBigTopic relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_PapersBigTopicDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_PapersBigTopicDA vcc_PapersBigTopicDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_PapersBigTopicDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_PapersBigTopicBL()
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
if (string.IsNullOrEmpty(clsvcc_PapersBigTopicEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_PapersBigTopicEN._ConnectString);
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
public static DataTable GetDataTable_vcc_PapersBigTopic(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_PapersBigTopicDA.GetDataTable_vcc_PapersBigTopic(strWhereCond);
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
objDT = vcc_PapersBigTopicDA.GetDataTable(strWhereCond);
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
objDT = vcc_PapersBigTopicDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_PapersBigTopicDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_PapersBigTopicDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_PapersBigTopicDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_PapersBigTopicDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_PapersBigTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_PapersBigTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPapersBigTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLst(List<string> arrPapersBigTopicIdLst)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPapersBigTopicIdLst, true);
 string strWhereCond = string.Format("PapersBigTopicId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPapersBigTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_PapersBigTopicEN> GetObjLstByPapersBigTopicIdLstCache(List<string> arrPapersBigTopicIdLst)
{
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName);
List<clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLst_Sel =
arrvcc_PapersBigTopicObjLstCache
.Where(x => arrPapersBigTopicIdLst.Contains(x.PapersBigTopicId));
return arrvcc_PapersBigTopicObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetObjLst(string strWhereCond)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_PapersBigTopicEN> GetSubObjLstCache(clsvcc_PapersBigTopicEN objvcc_PapersBigTopicCond)
{
List<clsvcc_PapersBigTopicEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_PapersBigTopic.AttributeName)
{
if (objvcc_PapersBigTopicCond.IsUpdated(strFldName) == false) continue;
if (objvcc_PapersBigTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicCond[strFldName].ToString());
}
else
{
if (objvcc_PapersBigTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_PapersBigTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_PapersBigTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicCond[strFldName]));
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
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
List<clsvcc_PapersBigTopicEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_PapersBigTopicEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_PapersBigTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
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
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
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
public static List<clsvcc_PapersBigTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
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
public static List<clsvcc_PapersBigTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_PapersBigTopicEN> arrObjLst = new List<clsvcc_PapersBigTopicEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = new clsvcc_PapersBigTopicEN();
try
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objRow[convcc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_PapersBigTopicEN.PapersBigTopicName = objRow[convcc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicEN.TopicDescription = objRow[convcc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicEN.TopicScores = objRow[convcc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicEN.CourseExamPaperId = objRow[convcc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_PapersBigTopicEN.ExamPaperName = objRow[convcc_PapersBigTopic.ExamPaperName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_PapersBigTopicEN.QuestionTypeId = objRow[convcc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objvcc_PapersBigTopicEN.OrderNum = objRow[convcc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objvcc_PapersBigTopicEN.UpdDate = objRow[convcc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicEN.UpdUser = objRow[convcc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicEN.Memo = objRow[convcc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.Memo].ToString().Trim(); //备注
objvcc_PapersBigTopicEN.QuestionTypeName = objRow[convcc_PapersBigTopic.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopic.QuestionTypeName].ToString().Trim(); //题目类型名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicEN.PapersBigTopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_PapersBigTopic(ref clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN)
{
bool bolResult = vcc_PapersBigTopicDA.Getvcc_PapersBigTopic(ref objvcc_PapersBigTopicEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PapersBigTopicEN GetObjByPapersBigTopicId(string strPapersBigTopicId)
{
if (strPapersBigTopicId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPapersBigTopicId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPapersBigTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPapersBigTopicId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = vcc_PapersBigTopicDA.GetObjByPapersBigTopicId(strPapersBigTopicId);
return objvcc_PapersBigTopicEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_PapersBigTopicEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = vcc_PapersBigTopicDA.GetFirstObj(strWhereCond);
 return objvcc_PapersBigTopicEN;
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
public static clsvcc_PapersBigTopicEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = vcc_PapersBigTopicDA.GetObjByDataRow(objRow);
 return objvcc_PapersBigTopicEN;
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
public static clsvcc_PapersBigTopicEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN = vcc_PapersBigTopicDA.GetObjByDataRow(objRow);
 return objvcc_PapersBigTopicEN;
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
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <param name = "lstvcc_PapersBigTopicObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PapersBigTopicEN GetObjByPapersBigTopicIdFromList(string strPapersBigTopicId, List<clsvcc_PapersBigTopicEN> lstvcc_PapersBigTopicObjLst)
{
foreach (clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN in lstvcc_PapersBigTopicObjLst)
{
if (objvcc_PapersBigTopicEN.PapersBigTopicId == strPapersBigTopicId)
{
return objvcc_PapersBigTopicEN;
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
 string strMaxPapersBigTopicId;
 try
 {
 strMaxPapersBigTopicId = clsvcc_PapersBigTopicDA.GetMaxStrId();
 return strMaxPapersBigTopicId;
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
 string strPapersBigTopicId;
 try
 {
 strPapersBigTopicId = new clsvcc_PapersBigTopicDA().GetFirstID(strWhereCond);
 return strPapersBigTopicId;
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
 arrList = vcc_PapersBigTopicDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_PapersBigTopicDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPapersBigTopicId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_PapersBigTopicDA.IsExist(strPapersBigTopicId);
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
 bolIsExist = clsvcc_PapersBigTopicDA.IsExistTable();
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
 bolIsExist = vcc_PapersBigTopicDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_PapersBigTopicENS">源对象</param>
 /// <param name = "objvcc_PapersBigTopicENT">目标对象</param>
 public static void CopyTo(clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENS, clsvcc_PapersBigTopicEN objvcc_PapersBigTopicENT)
{
try
{
objvcc_PapersBigTopicENT.PapersBigTopicId = objvcc_PapersBigTopicENS.PapersBigTopicId; //试卷大题目Id
objvcc_PapersBigTopicENT.PapersBigTopicName = objvcc_PapersBigTopicENS.PapersBigTopicName; //试卷大题目名称
objvcc_PapersBigTopicENT.TopicDescription = objvcc_PapersBigTopicENS.TopicDescription; //标题描述
objvcc_PapersBigTopicENT.TopicScores = objvcc_PapersBigTopicENS.TopicScores; //大题得分
objvcc_PapersBigTopicENT.CourseExamPaperId = objvcc_PapersBigTopicENS.CourseExamPaperId; //考卷流水号
objvcc_PapersBigTopicENT.ExamPaperName = objvcc_PapersBigTopicENS.ExamPaperName; //考卷名称
objvcc_PapersBigTopicENT.QuestionTypeId = objvcc_PapersBigTopicENS.QuestionTypeId; //题目类型Id
objvcc_PapersBigTopicENT.IsShow = objvcc_PapersBigTopicENS.IsShow; //是否启用
objvcc_PapersBigTopicENT.OrderNum = objvcc_PapersBigTopicENS.OrderNum; //序号
objvcc_PapersBigTopicENT.UpdDate = objvcc_PapersBigTopicENS.UpdDate; //修改日期
objvcc_PapersBigTopicENT.UpdUser = objvcc_PapersBigTopicENS.UpdUser; //修改人
objvcc_PapersBigTopicENT.Memo = objvcc_PapersBigTopicENS.Memo; //备注
objvcc_PapersBigTopicENT.QuestionTypeName = objvcc_PapersBigTopicENS.QuestionTypeName; //题目类型名
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
 /// <param name = "objvcc_PapersBigTopicEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN)
{
try
{
objvcc_PapersBigTopicEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_PapersBigTopicEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_PapersBigTopic.PapersBigTopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.PapersBigTopicId = objvcc_PapersBigTopicEN.PapersBigTopicId; //试卷大题目Id
}
if (arrFldSet.Contains(convcc_PapersBigTopic.PapersBigTopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.PapersBigTopicName = objvcc_PapersBigTopicEN.PapersBigTopicName; //试卷大题目名称
}
if (arrFldSet.Contains(convcc_PapersBigTopic.TopicDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.TopicDescription = objvcc_PapersBigTopicEN.TopicDescription == "[null]" ? null :  objvcc_PapersBigTopicEN.TopicDescription; //标题描述
}
if (arrFldSet.Contains(convcc_PapersBigTopic.TopicScores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.TopicScores = objvcc_PapersBigTopicEN.TopicScores; //大题得分
}
if (arrFldSet.Contains(convcc_PapersBigTopic.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.CourseExamPaperId = objvcc_PapersBigTopicEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convcc_PapersBigTopic.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.ExamPaperName = objvcc_PapersBigTopicEN.ExamPaperName == "[null]" ? null :  objvcc_PapersBigTopicEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(convcc_PapersBigTopic.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.QuestionTypeId = objvcc_PapersBigTopicEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convcc_PapersBigTopic.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.IsShow = objvcc_PapersBigTopicEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convcc_PapersBigTopic.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.OrderNum = objvcc_PapersBigTopicEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_PapersBigTopic.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.UpdDate = objvcc_PapersBigTopicEN.UpdDate == "[null]" ? null :  objvcc_PapersBigTopicEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_PapersBigTopic.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.UpdUser = objvcc_PapersBigTopicEN.UpdUser == "[null]" ? null :  objvcc_PapersBigTopicEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_PapersBigTopic.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.Memo = objvcc_PapersBigTopicEN.Memo == "[null]" ? null :  objvcc_PapersBigTopicEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_PapersBigTopic.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicEN.QuestionTypeName = objvcc_PapersBigTopicEN.QuestionTypeName == "[null]" ? null :  objvcc_PapersBigTopicEN.QuestionTypeName; //题目类型名
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
 /// <param name = "objvcc_PapersBigTopicEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN)
{
try
{
if (objvcc_PapersBigTopicEN.TopicDescription == "[null]") objvcc_PapersBigTopicEN.TopicDescription = null; //标题描述
if (objvcc_PapersBigTopicEN.ExamPaperName == "[null]") objvcc_PapersBigTopicEN.ExamPaperName = null; //考卷名称
if (objvcc_PapersBigTopicEN.UpdDate == "[null]") objvcc_PapersBigTopicEN.UpdDate = null; //修改日期
if (objvcc_PapersBigTopicEN.UpdUser == "[null]") objvcc_PapersBigTopicEN.UpdUser = null; //修改人
if (objvcc_PapersBigTopicEN.Memo == "[null]") objvcc_PapersBigTopicEN.Memo = null; //备注
if (objvcc_PapersBigTopicEN.QuestionTypeName == "[null]") objvcc_PapersBigTopicEN.QuestionTypeName = null; //题目类型名
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
public static void CheckProperty4Condition(clsvcc_PapersBigTopicEN objvcc_PapersBigTopicEN)
{
 vcc_PapersBigTopicDA.CheckProperty4Condition(objvcc_PapersBigTopicEN);
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
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicBL没有刷新缓存机制(clscc_PapersBigTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicId");
//if (arrvcc_PapersBigTopicObjLstCache == null)
//{
//arrvcc_PapersBigTopicObjLstCache = vcc_PapersBigTopicDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPapersBigTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PapersBigTopicEN GetObjByPapersBigTopicIdCache(string strPapersBigTopicId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName);
List<clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLst_Sel =
arrvcc_PapersBigTopicObjLstCache
.Where(x=> x.PapersBigTopicId == strPapersBigTopicId 
);
if (arrvcc_PapersBigTopicObjLst_Sel.Count() == 0)
{
   clsvcc_PapersBigTopicEN obj = clsvcc_PapersBigTopicBL.GetObjByPapersBigTopicId(strPapersBigTopicId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_PapersBigTopicObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetAllvcc_PapersBigTopicObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLstCache = GetObjLstCache(); 
return arrvcc_PapersBigTopicObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_PapersBigTopicEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName);
List<clsvcc_PapersBigTopicEN> arrvcc_PapersBigTopicObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PapersBigTopicObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_PapersBigTopicEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strPapersBigTopicId)
{
if (strInFldName != convcc_PapersBigTopic.PapersBigTopicId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_PapersBigTopic.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_PapersBigTopic.AttributeName));
throw new Exception(strMsg);
}
var objvcc_PapersBigTopic = clsvcc_PapersBigTopicBL.GetObjByPapersBigTopicIdCache(strPapersBigTopicId);
if (objvcc_PapersBigTopic == null) return "";
return objvcc_PapersBigTopic[strOutFldName].ToString();
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
int intRecCount = clsvcc_PapersBigTopicDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_PapersBigTopicDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_PapersBigTopicDA.GetRecCount();
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
int intRecCount = clsvcc_PapersBigTopicDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_PapersBigTopicEN objvcc_PapersBigTopicCond)
{
List<clsvcc_PapersBigTopicEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_PapersBigTopic.AttributeName)
{
if (objvcc_PapersBigTopicCond.IsUpdated(strFldName) == false) continue;
if (objvcc_PapersBigTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicCond[strFldName].ToString());
}
else
{
if (objvcc_PapersBigTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_PapersBigTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_PapersBigTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_PapersBigTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicCond[strFldName]));
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
 List<string> arrList = clsvcc_PapersBigTopicDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_PapersBigTopicDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_PapersBigTopicDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}