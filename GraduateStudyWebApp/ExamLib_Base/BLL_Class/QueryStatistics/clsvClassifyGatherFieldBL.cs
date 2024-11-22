
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassifyGatherFieldBL
 表名:vClassifyGatherField(01120016)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvClassifyGatherFieldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassifyGatherFieldEN GetObj(this K_mId_vClassifyGatherField myKey)
{
clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = clsvClassifyGatherFieldBL.vClassifyGatherFieldDA.GetObjBymId(myKey.Value);
return objvClassifyGatherFieldEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetmId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, long lngmId, string strComparisonOp="")
	{
objvClassifyGatherFieldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.mId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.mId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.mId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, long? lngQuestionId, string strComparisonOp="")
	{
objvClassifyGatherFieldEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionIndex(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvClassifyGatherFieldEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionIndex) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionIndex, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionIndex] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionNo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convClassifyGatherField.QuestionNo);
}
objvClassifyGatherFieldEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionNo) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionNo, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionNo] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convClassifyGatherField.QuestionName);
}
objvClassifyGatherFieldEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetGridTitle(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convClassifyGatherField.GridTitle);
}
objvClassifyGatherFieldEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.GridTitle) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.GridTitle, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.GridTitle] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionnaireSetId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convClassifyGatherField.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convClassifyGatherField.QuestionnaireSetId);
}
objvClassifyGatherFieldEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionnaireSetId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionnaireSetId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionnaireSetId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionnaireSetName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convClassifyGatherField.QuestionnaireSetName);
}
objvClassifyGatherFieldEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionnaireSetName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionnaireSetName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionnaireSetName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyGatherId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyGatherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherId, convClassifyGatherField.ClassifyGatherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyGatherId, 4, convClassifyGatherField.ClassifyGatherId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassifyGatherId, 4, convClassifyGatherField.ClassifyGatherId);
}
objvClassifyGatherFieldEN.ClassifyGatherId = strClassifyGatherId; //分类统计Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.ClassifyGatherId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.ClassifyGatherId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyGatherName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyGatherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherName, convClassifyGatherField.ClassifyGatherName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyGatherName, 30, convClassifyGatherField.ClassifyGatherName);
}
objvClassifyGatherFieldEN.ClassifyGatherName = strClassifyGatherName; //分类统计名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.ClassifyGatherName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.ClassifyGatherName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyFieldTypeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyFieldTypeId, convClassifyGatherField.ClassifyFieldTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyFieldTypeId, 4, convClassifyGatherField.ClassifyFieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassifyFieldTypeId, 4, convClassifyGatherField.ClassifyFieldTypeId);
}
objvClassifyGatherFieldEN.ClassifyFieldTypeId = strClassifyFieldTypeId; //分类字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.ClassifyFieldTypeId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.ClassifyFieldTypeId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.ClassifyFieldTypeId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyFieldTypeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyFieldTypeName, convClassifyGatherField.ClassifyFieldTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyFieldTypeName, 30, convClassifyGatherField.ClassifyFieldTypeName);
}
objvClassifyGatherFieldEN.ClassifyFieldTypeName = strClassifyFieldTypeName; //分类字段类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.ClassifyFieldTypeName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.ClassifyFieldTypeName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.ClassifyFieldTypeName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetGatherModeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strGatherModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGatherModeId, convClassifyGatherField.GatherModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGatherModeId, 4, convClassifyGatherField.GatherModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGatherModeId, 4, convClassifyGatherField.GatherModeId);
}
objvClassifyGatherFieldEN.GatherModeId = strGatherModeId; //汇总模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.GatherModeId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.GatherModeId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.GatherModeId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetGatherModeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strGatherModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGatherModeName, convClassifyGatherField.GatherModeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGatherModeName, 30, convClassifyGatherField.GatherModeName);
}
objvClassifyGatherFieldEN.GatherModeName = strGatherModeName; //汇总模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.GatherModeName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.GatherModeName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.GatherModeName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionTypeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convClassifyGatherField.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convClassifyGatherField.QuestionTypeId);
}
objvClassifyGatherFieldEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionTypeId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionTypeId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionTypeId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionTypeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convClassifyGatherField.QuestionTypeName);
}
objvClassifyGatherFieldEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionTypeName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionTypeName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionTypeName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerTypeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convClassifyGatherField.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convClassifyGatherField.AnswerTypeId);
}
objvClassifyGatherFieldEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.AnswerTypeId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.AnswerTypeId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.AnswerTypeId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerTypeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convClassifyGatherField.AnswerTypeName);
}
objvClassifyGatherFieldEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.AnswerTypeName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.AnswerTypeName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.AnswerTypeName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetIsDefault(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, bool bolIsDefault, string strComparisonOp="")
	{
objvClassifyGatherFieldEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.IsDefault) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.IsDefault, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.IsDefault] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerModeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convClassifyGatherField.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convClassifyGatherField.AnswerModeId);
}
objvClassifyGatherFieldEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.AnswerModeId) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.AnswerModeId, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.AnswerModeId] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerModeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convClassifyGatherField.AnswerModeName);
}
objvClassifyGatherFieldEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.AnswerModeName) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.AnswerModeName, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.AnswerModeName] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetDetailTitle(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strDetailTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTitle, 30, convClassifyGatherField.DetailTitle);
}
objvClassifyGatherFieldEN.DetailTitle = strDetailTitle; //详细列表标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.DetailTitle) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.DetailTitle, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.DetailTitle] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetIsDetailTitleIndexNo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, bool bolIsDetailTitleIndexNo, string strComparisonOp="")
	{
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = bolIsDetailTitleIndexNo; //标题是否编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.IsDetailTitleIndexNo) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.IsDetailTitleIndexNo, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.IsDetailTitleIndexNo] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyGatherPeriod(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyGatherPeriod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyGatherPeriod, 50, convClassifyGatherField.ClassifyGatherPeriod);
}
objvClassifyGatherFieldEN.ClassifyGatherPeriod = strClassifyGatherPeriod; //分类统计时期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.ClassifyGatherPeriod) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.ClassifyGatherPeriod, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherPeriod] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetRecNo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, int intRecNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRecNo, convClassifyGatherField.RecNo);
objvClassifyGatherFieldEN.RecNo = intRecNo; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.RecNo) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.RecNo, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.RecNo] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetUpdDate(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convClassifyGatherField.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convClassifyGatherField.UpdDate);
}
objvClassifyGatherFieldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.UpdDate) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.UpdDate, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.UpdDate] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetUpdUser(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convClassifyGatherField.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClassifyGatherField.UpdUser);
}
objvClassifyGatherFieldEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.UpdUser) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.UpdUser, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.UpdUser] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetMemo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClassifyGatherField.Memo);
}
objvClassifyGatherFieldEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.Memo) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.Memo, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.Memo] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldENS">源对象</param>
 /// <param name = "objvClassifyGatherFieldENT">目标对象</param>
 public static void CopyTo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldENS, clsvClassifyGatherFieldEN objvClassifyGatherFieldENT)
{
try
{
objvClassifyGatherFieldENT.mId = objvClassifyGatherFieldENS.mId; //mId
objvClassifyGatherFieldENT.QuestionId = objvClassifyGatherFieldENS.QuestionId; //题目Id
objvClassifyGatherFieldENT.QuestionIndex = objvClassifyGatherFieldENS.QuestionIndex; //题目序号
objvClassifyGatherFieldENT.QuestionNo = objvClassifyGatherFieldENS.QuestionNo; //题目编号
objvClassifyGatherFieldENT.QuestionName = objvClassifyGatherFieldENS.QuestionName; //题目名称
objvClassifyGatherFieldENT.GridTitle = objvClassifyGatherFieldENS.GridTitle; //表格标题
objvClassifyGatherFieldENT.QuestionnaireSetId = objvClassifyGatherFieldENS.QuestionnaireSetId; //问卷集ID
objvClassifyGatherFieldENT.QuestionnaireSetName = objvClassifyGatherFieldENS.QuestionnaireSetName; //问卷集名
objvClassifyGatherFieldENT.ClassifyGatherId = objvClassifyGatherFieldENS.ClassifyGatherId; //分类统计Id
objvClassifyGatherFieldENT.ClassifyGatherName = objvClassifyGatherFieldENS.ClassifyGatherName; //分类统计名称
objvClassifyGatherFieldENT.ClassifyFieldTypeId = objvClassifyGatherFieldENS.ClassifyFieldTypeId; //分类字段类型Id
objvClassifyGatherFieldENT.ClassifyFieldTypeName = objvClassifyGatherFieldENS.ClassifyFieldTypeName; //分类字段类型名称
objvClassifyGatherFieldENT.GatherModeId = objvClassifyGatherFieldENS.GatherModeId; //汇总模式Id
objvClassifyGatherFieldENT.GatherModeName = objvClassifyGatherFieldENS.GatherModeName; //汇总模式名称
objvClassifyGatherFieldENT.QuestionTypeId = objvClassifyGatherFieldENS.QuestionTypeId; //题目类型Id
objvClassifyGatherFieldENT.QuestionTypeName = objvClassifyGatherFieldENS.QuestionTypeName; //题目类型名
objvClassifyGatherFieldENT.AnswerTypeId = objvClassifyGatherFieldENS.AnswerTypeId; //答案类型ID
objvClassifyGatherFieldENT.AnswerTypeName = objvClassifyGatherFieldENS.AnswerTypeName; //答案类型名
objvClassifyGatherFieldENT.IsDefault = objvClassifyGatherFieldENS.IsDefault; //是否默认
objvClassifyGatherFieldENT.AnswerModeId = objvClassifyGatherFieldENS.AnswerModeId; //答案模式Id
objvClassifyGatherFieldENT.AnswerModeName = objvClassifyGatherFieldENS.AnswerModeName; //答案模式名称
objvClassifyGatherFieldENT.DetailTitle = objvClassifyGatherFieldENS.DetailTitle; //详细列表标题
objvClassifyGatherFieldENT.IsDetailTitleIndexNo = objvClassifyGatherFieldENS.IsDetailTitleIndexNo; //标题是否编号
objvClassifyGatherFieldENT.ClassifyGatherPeriod = objvClassifyGatherFieldENS.ClassifyGatherPeriod; //分类统计时期
objvClassifyGatherFieldENT.RecNo = objvClassifyGatherFieldENS.RecNo; //序号
objvClassifyGatherFieldENT.UpdDate = objvClassifyGatherFieldENS.UpdDate; //修改日期
objvClassifyGatherFieldENT.UpdUser = objvClassifyGatherFieldENS.UpdUser; //修改人
objvClassifyGatherFieldENT.Memo = objvClassifyGatherFieldENS.Memo; //备注
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
 /// <param name = "objvClassifyGatherFieldENS">源对象</param>
 /// <returns>目标对象=>clsvClassifyGatherFieldEN:objvClassifyGatherFieldENT</returns>
 public static clsvClassifyGatherFieldEN CopyTo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldENS)
{
try
{
 clsvClassifyGatherFieldEN objvClassifyGatherFieldENT = new clsvClassifyGatherFieldEN()
{
mId = objvClassifyGatherFieldENS.mId, //mId
QuestionId = objvClassifyGatherFieldENS.QuestionId, //题目Id
QuestionIndex = objvClassifyGatherFieldENS.QuestionIndex, //题目序号
QuestionNo = objvClassifyGatherFieldENS.QuestionNo, //题目编号
QuestionName = objvClassifyGatherFieldENS.QuestionName, //题目名称
GridTitle = objvClassifyGatherFieldENS.GridTitle, //表格标题
QuestionnaireSetId = objvClassifyGatherFieldENS.QuestionnaireSetId, //问卷集ID
QuestionnaireSetName = objvClassifyGatherFieldENS.QuestionnaireSetName, //问卷集名
ClassifyGatherId = objvClassifyGatherFieldENS.ClassifyGatherId, //分类统计Id
ClassifyGatherName = objvClassifyGatherFieldENS.ClassifyGatherName, //分类统计名称
ClassifyFieldTypeId = objvClassifyGatherFieldENS.ClassifyFieldTypeId, //分类字段类型Id
ClassifyFieldTypeName = objvClassifyGatherFieldENS.ClassifyFieldTypeName, //分类字段类型名称
GatherModeId = objvClassifyGatherFieldENS.GatherModeId, //汇总模式Id
GatherModeName = objvClassifyGatherFieldENS.GatherModeName, //汇总模式名称
QuestionTypeId = objvClassifyGatherFieldENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvClassifyGatherFieldENS.QuestionTypeName, //题目类型名
AnswerTypeId = objvClassifyGatherFieldENS.AnswerTypeId, //答案类型ID
AnswerTypeName = objvClassifyGatherFieldENS.AnswerTypeName, //答案类型名
IsDefault = objvClassifyGatherFieldENS.IsDefault, //是否默认
AnswerModeId = objvClassifyGatherFieldENS.AnswerModeId, //答案模式Id
AnswerModeName = objvClassifyGatherFieldENS.AnswerModeName, //答案模式名称
DetailTitle = objvClassifyGatherFieldENS.DetailTitle, //详细列表标题
IsDetailTitleIndexNo = objvClassifyGatherFieldENS.IsDetailTitleIndexNo, //标题是否编号
ClassifyGatherPeriod = objvClassifyGatherFieldENS.ClassifyGatherPeriod, //分类统计时期
RecNo = objvClassifyGatherFieldENS.RecNo, //序号
UpdDate = objvClassifyGatherFieldENS.UpdDate, //修改日期
UpdUser = objvClassifyGatherFieldENS.UpdUser, //修改人
Memo = objvClassifyGatherFieldENS.Memo, //备注
};
 return objvClassifyGatherFieldENT;
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
public static void CheckProperty4Condition(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN)
{
 clsvClassifyGatherFieldBL.vClassifyGatherFieldDA.CheckProperty4Condition(objvClassifyGatherFieldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClassifyGatherFieldEN objvClassifyGatherFieldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.mId) == true)
{
string strComparisonOpmId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convClassifyGatherField.mId, objvClassifyGatherFieldCond.mId, strComparisonOpmId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionId) == true)
{
string strComparisonOpQuestionId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convClassifyGatherField.QuestionId, objvClassifyGatherFieldCond.QuestionId, strComparisonOpQuestionId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convClassifyGatherField.QuestionIndex, objvClassifyGatherFieldCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionNo, objvClassifyGatherFieldCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionName) == true)
{
string strComparisonOpQuestionName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionName, objvClassifyGatherFieldCond.QuestionName, strComparisonOpQuestionName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.GridTitle) == true)
{
string strComparisonOpGridTitle = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.GridTitle, objvClassifyGatherFieldCond.GridTitle, strComparisonOpGridTitle);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionnaireSetId, objvClassifyGatherFieldCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionnaireSetName) == true)
{
string strComparisonOpQuestionnaireSetName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionnaireSetName, objvClassifyGatherFieldCond.QuestionnaireSetName, strComparisonOpQuestionnaireSetName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.ClassifyGatherId) == true)
{
string strComparisonOpClassifyGatherId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyGatherId, objvClassifyGatherFieldCond.ClassifyGatherId, strComparisonOpClassifyGatherId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.ClassifyGatherName) == true)
{
string strComparisonOpClassifyGatherName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyGatherName, objvClassifyGatherFieldCond.ClassifyGatherName, strComparisonOpClassifyGatherName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.ClassifyFieldTypeId) == true)
{
string strComparisonOpClassifyFieldTypeId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.ClassifyFieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyFieldTypeId, objvClassifyGatherFieldCond.ClassifyFieldTypeId, strComparisonOpClassifyFieldTypeId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.ClassifyFieldTypeName) == true)
{
string strComparisonOpClassifyFieldTypeName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.ClassifyFieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyFieldTypeName, objvClassifyGatherFieldCond.ClassifyFieldTypeName, strComparisonOpClassifyFieldTypeName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.GatherModeId) == true)
{
string strComparisonOpGatherModeId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.GatherModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.GatherModeId, objvClassifyGatherFieldCond.GatherModeId, strComparisonOpGatherModeId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.GatherModeName) == true)
{
string strComparisonOpGatherModeName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.GatherModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.GatherModeName, objvClassifyGatherFieldCond.GatherModeName, strComparisonOpGatherModeName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionTypeId, objvClassifyGatherFieldCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionTypeName, objvClassifyGatherFieldCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerTypeId, objvClassifyGatherFieldCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerTypeName, objvClassifyGatherFieldCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.IsDefault) == true)
{
if (objvClassifyGatherFieldCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClassifyGatherField.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClassifyGatherField.IsDefault);
}
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerModeId, objvClassifyGatherFieldCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.AnswerModeName) == true)
{
string strComparisonOpAnswerModeName = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerModeName, objvClassifyGatherFieldCond.AnswerModeName, strComparisonOpAnswerModeName);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.DetailTitle) == true)
{
string strComparisonOpDetailTitle = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.DetailTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.DetailTitle, objvClassifyGatherFieldCond.DetailTitle, strComparisonOpDetailTitle);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.IsDetailTitleIndexNo) == true)
{
if (objvClassifyGatherFieldCond.IsDetailTitleIndexNo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClassifyGatherField.IsDetailTitleIndexNo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClassifyGatherField.IsDetailTitleIndexNo);
}
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.ClassifyGatherPeriod) == true)
{
string strComparisonOpClassifyGatherPeriod = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherPeriod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyGatherPeriod, objvClassifyGatherFieldCond.ClassifyGatherPeriod, strComparisonOpClassifyGatherPeriod);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.RecNo) == true)
{
string strComparisonOpRecNo = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.RecNo];
strWhereCond += string.Format(" And {0} {2} {1}", convClassifyGatherField.RecNo, objvClassifyGatherFieldCond.RecNo, strComparisonOpRecNo);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.UpdDate) == true)
{
string strComparisonOpUpdDate = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.UpdDate, objvClassifyGatherFieldCond.UpdDate, strComparisonOpUpdDate);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.UpdUser) == true)
{
string strComparisonOpUpdUser = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.UpdUser, objvClassifyGatherFieldCond.UpdUser, strComparisonOpUpdUser);
}
if (objvClassifyGatherFieldCond.IsUpdated(convClassifyGatherField.Memo) == true)
{
string strComparisonOpMemo = objvClassifyGatherFieldCond.dicFldComparisonOp[convClassifyGatherField.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.Memo, objvClassifyGatherFieldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vClassifyGatherField
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v分类汇总字段(vClassifyGatherField)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvClassifyGatherFieldBL
{
public static RelatedActions_vClassifyGatherField relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvClassifyGatherFieldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvClassifyGatherFieldDA vClassifyGatherFieldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvClassifyGatherFieldDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvClassifyGatherFieldBL()
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
if (string.IsNullOrEmpty(clsvClassifyGatherFieldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClassifyGatherFieldEN._ConnectString);
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
public static DataTable GetDataTable_vClassifyGatherField(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vClassifyGatherFieldDA.GetDataTable_vClassifyGatherField(strWhereCond);
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
objDT = vClassifyGatherFieldDA.GetDataTable(strWhereCond);
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
objDT = vClassifyGatherFieldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vClassifyGatherFieldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vClassifyGatherFieldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vClassifyGatherFieldDA.GetDataTable_Top(objTopPara);
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
objDT = vClassifyGatherFieldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vClassifyGatherFieldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vClassifyGatherFieldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
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
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvClassifyGatherFieldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName);
List<clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLstCache = GetObjLstCache();
IEnumerable <clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLst_Sel =
arrvClassifyGatherFieldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvClassifyGatherFieldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetObjLst(string strWhereCond)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
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
public static List<clsvClassifyGatherFieldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvClassifyGatherFieldEN> GetSubObjLstCache(clsvClassifyGatherFieldEN objvClassifyGatherFieldCond)
{
List<clsvClassifyGatherFieldEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClassifyGatherFieldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClassifyGatherField.AttributeName)
{
if (objvClassifyGatherFieldCond.IsUpdated(strFldName) == false) continue;
if (objvClassifyGatherFieldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClassifyGatherFieldCond[strFldName].ToString());
}
else
{
if (objvClassifyGatherFieldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClassifyGatherFieldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClassifyGatherFieldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClassifyGatherFieldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClassifyGatherFieldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClassifyGatherFieldCond[strFldName]));
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
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
List<clsvClassifyGatherFieldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvClassifyGatherFieldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvClassifyGatherFieldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
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
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
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
public static List<clsvClassifyGatherFieldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassifyGatherFieldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvClassifyGatherField(ref clsvClassifyGatherFieldEN objvClassifyGatherFieldEN)
{
bool bolResult = vClassifyGatherFieldDA.GetvClassifyGatherField(ref objvClassifyGatherFieldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassifyGatherFieldEN GetObjBymId(long lngmId)
{
clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = vClassifyGatherFieldDA.GetObjBymId(lngmId);
return objvClassifyGatherFieldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvClassifyGatherFieldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = vClassifyGatherFieldDA.GetFirstObj(strWhereCond);
 return objvClassifyGatherFieldEN;
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
public static clsvClassifyGatherFieldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = vClassifyGatherFieldDA.GetObjByDataRow(objRow);
 return objvClassifyGatherFieldEN;
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
public static clsvClassifyGatherFieldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = vClassifyGatherFieldDA.GetObjByDataRow(objRow);
 return objvClassifyGatherFieldEN;
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
 /// <param name = "lstvClassifyGatherFieldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClassifyGatherFieldEN GetObjBymIdFromList(long lngmId, List<clsvClassifyGatherFieldEN> lstvClassifyGatherFieldObjLst)
{
foreach (clsvClassifyGatherFieldEN objvClassifyGatherFieldEN in lstvClassifyGatherFieldObjLst)
{
if (objvClassifyGatherFieldEN.mId == lngmId)
{
return objvClassifyGatherFieldEN;
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
 lngmId = new clsvClassifyGatherFieldDA().GetFirstID(strWhereCond);
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
 arrList = vClassifyGatherFieldDA.GetID(strWhereCond);
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
bool bolIsExist = vClassifyGatherFieldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vClassifyGatherFieldDA.IsExist(lngmId);
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
 bolIsExist = clsvClassifyGatherFieldDA.IsExistTable();
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
 bolIsExist = vClassifyGatherFieldDA.IsExistTable(strTabName);
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
 /// <param name = "objvClassifyGatherFieldENS">源对象</param>
 /// <param name = "objvClassifyGatherFieldENT">目标对象</param>
 public static void CopyTo(clsvClassifyGatherFieldEN objvClassifyGatherFieldENS, clsvClassifyGatherFieldEN objvClassifyGatherFieldENT)
{
try
{
objvClassifyGatherFieldENT.mId = objvClassifyGatherFieldENS.mId; //mId
objvClassifyGatherFieldENT.QuestionId = objvClassifyGatherFieldENS.QuestionId; //题目Id
objvClassifyGatherFieldENT.QuestionIndex = objvClassifyGatherFieldENS.QuestionIndex; //题目序号
objvClassifyGatherFieldENT.QuestionNo = objvClassifyGatherFieldENS.QuestionNo; //题目编号
objvClassifyGatherFieldENT.QuestionName = objvClassifyGatherFieldENS.QuestionName; //题目名称
objvClassifyGatherFieldENT.GridTitle = objvClassifyGatherFieldENS.GridTitle; //表格标题
objvClassifyGatherFieldENT.QuestionnaireSetId = objvClassifyGatherFieldENS.QuestionnaireSetId; //问卷集ID
objvClassifyGatherFieldENT.QuestionnaireSetName = objvClassifyGatherFieldENS.QuestionnaireSetName; //问卷集名
objvClassifyGatherFieldENT.ClassifyGatherId = objvClassifyGatherFieldENS.ClassifyGatherId; //分类统计Id
objvClassifyGatherFieldENT.ClassifyGatherName = objvClassifyGatherFieldENS.ClassifyGatherName; //分类统计名称
objvClassifyGatherFieldENT.ClassifyFieldTypeId = objvClassifyGatherFieldENS.ClassifyFieldTypeId; //分类字段类型Id
objvClassifyGatherFieldENT.ClassifyFieldTypeName = objvClassifyGatherFieldENS.ClassifyFieldTypeName; //分类字段类型名称
objvClassifyGatherFieldENT.GatherModeId = objvClassifyGatherFieldENS.GatherModeId; //汇总模式Id
objvClassifyGatherFieldENT.GatherModeName = objvClassifyGatherFieldENS.GatherModeName; //汇总模式名称
objvClassifyGatherFieldENT.QuestionTypeId = objvClassifyGatherFieldENS.QuestionTypeId; //题目类型Id
objvClassifyGatherFieldENT.QuestionTypeName = objvClassifyGatherFieldENS.QuestionTypeName; //题目类型名
objvClassifyGatherFieldENT.AnswerTypeId = objvClassifyGatherFieldENS.AnswerTypeId; //答案类型ID
objvClassifyGatherFieldENT.AnswerTypeName = objvClassifyGatherFieldENS.AnswerTypeName; //答案类型名
objvClassifyGatherFieldENT.IsDefault = objvClassifyGatherFieldENS.IsDefault; //是否默认
objvClassifyGatherFieldENT.AnswerModeId = objvClassifyGatherFieldENS.AnswerModeId; //答案模式Id
objvClassifyGatherFieldENT.AnswerModeName = objvClassifyGatherFieldENS.AnswerModeName; //答案模式名称
objvClassifyGatherFieldENT.DetailTitle = objvClassifyGatherFieldENS.DetailTitle; //详细列表标题
objvClassifyGatherFieldENT.IsDetailTitleIndexNo = objvClassifyGatherFieldENS.IsDetailTitleIndexNo; //标题是否编号
objvClassifyGatherFieldENT.ClassifyGatherPeriod = objvClassifyGatherFieldENS.ClassifyGatherPeriod; //分类统计时期
objvClassifyGatherFieldENT.RecNo = objvClassifyGatherFieldENS.RecNo; //序号
objvClassifyGatherFieldENT.UpdDate = objvClassifyGatherFieldENS.UpdDate; //修改日期
objvClassifyGatherFieldENT.UpdUser = objvClassifyGatherFieldENS.UpdUser; //修改人
objvClassifyGatherFieldENT.Memo = objvClassifyGatherFieldENS.Memo; //备注
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
 /// <param name = "objvClassifyGatherFieldEN">源简化对象</param>
 public static void SetUpdFlag(clsvClassifyGatherFieldEN objvClassifyGatherFieldEN)
{
try
{
objvClassifyGatherFieldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvClassifyGatherFieldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convClassifyGatherField.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.mId = objvClassifyGatherFieldEN.mId; //mId
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionId = objvClassifyGatherFieldEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionIndex = objvClassifyGatherFieldEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionNo = objvClassifyGatherFieldEN.QuestionNo == "[null]" ? null :  objvClassifyGatherFieldEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionName = objvClassifyGatherFieldEN.QuestionName == "[null]" ? null :  objvClassifyGatherFieldEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convClassifyGatherField.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.GridTitle = objvClassifyGatherFieldEN.GridTitle == "[null]" ? null :  objvClassifyGatherFieldEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionnaireSetId = objvClassifyGatherFieldEN.QuestionnaireSetId == "[null]" ? null :  objvClassifyGatherFieldEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionnaireSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionnaireSetName = objvClassifyGatherFieldEN.QuestionnaireSetName == "[null]" ? null :  objvClassifyGatherFieldEN.QuestionnaireSetName; //问卷集名
}
if (arrFldSet.Contains(convClassifyGatherField.ClassifyGatherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.ClassifyGatherId = objvClassifyGatherFieldEN.ClassifyGatherId; //分类统计Id
}
if (arrFldSet.Contains(convClassifyGatherField.ClassifyGatherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.ClassifyGatherName = objvClassifyGatherFieldEN.ClassifyGatherName; //分类统计名称
}
if (arrFldSet.Contains(convClassifyGatherField.ClassifyFieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objvClassifyGatherFieldEN.ClassifyFieldTypeId; //分类字段类型Id
}
if (arrFldSet.Contains(convClassifyGatherField.ClassifyFieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objvClassifyGatherFieldEN.ClassifyFieldTypeName; //分类字段类型名称
}
if (arrFldSet.Contains(convClassifyGatherField.GatherModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.GatherModeId = objvClassifyGatherFieldEN.GatherModeId; //汇总模式Id
}
if (arrFldSet.Contains(convClassifyGatherField.GatherModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.GatherModeName = objvClassifyGatherFieldEN.GatherModeName; //汇总模式名称
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionTypeId = objvClassifyGatherFieldEN.QuestionTypeId == "[null]" ? null :  objvClassifyGatherFieldEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convClassifyGatherField.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.QuestionTypeName = objvClassifyGatherFieldEN.QuestionTypeName == "[null]" ? null :  objvClassifyGatherFieldEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convClassifyGatherField.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.AnswerTypeId = objvClassifyGatherFieldEN.AnswerTypeId == "[null]" ? null :  objvClassifyGatherFieldEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convClassifyGatherField.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.AnswerTypeName = objvClassifyGatherFieldEN.AnswerTypeName == "[null]" ? null :  objvClassifyGatherFieldEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convClassifyGatherField.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.IsDefault = objvClassifyGatherFieldEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(convClassifyGatherField.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.AnswerModeId = objvClassifyGatherFieldEN.AnswerModeId == "[null]" ? null :  objvClassifyGatherFieldEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convClassifyGatherField.AnswerModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.AnswerModeName = objvClassifyGatherFieldEN.AnswerModeName == "[null]" ? null :  objvClassifyGatherFieldEN.AnswerModeName; //答案模式名称
}
if (arrFldSet.Contains(convClassifyGatherField.DetailTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.DetailTitle = objvClassifyGatherFieldEN.DetailTitle == "[null]" ? null :  objvClassifyGatherFieldEN.DetailTitle; //详细列表标题
}
if (arrFldSet.Contains(convClassifyGatherField.IsDetailTitleIndexNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = objvClassifyGatherFieldEN.IsDetailTitleIndexNo; //标题是否编号
}
if (arrFldSet.Contains(convClassifyGatherField.ClassifyGatherPeriod, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objvClassifyGatherFieldEN.ClassifyGatherPeriod == "[null]" ? null :  objvClassifyGatherFieldEN.ClassifyGatherPeriod; //分类统计时期
}
if (arrFldSet.Contains(convClassifyGatherField.RecNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.RecNo = objvClassifyGatherFieldEN.RecNo; //序号
}
if (arrFldSet.Contains(convClassifyGatherField.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.UpdDate = objvClassifyGatherFieldEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convClassifyGatherField.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.UpdUser = objvClassifyGatherFieldEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convClassifyGatherField.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassifyGatherFieldEN.Memo = objvClassifyGatherFieldEN.Memo == "[null]" ? null :  objvClassifyGatherFieldEN.Memo; //备注
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
 /// <param name = "objvClassifyGatherFieldEN">源简化对象</param>
 public static void AccessFldValueNull(clsvClassifyGatherFieldEN objvClassifyGatherFieldEN)
{
try
{
if (objvClassifyGatherFieldEN.QuestionNo == "[null]") objvClassifyGatherFieldEN.QuestionNo = null; //题目编号
if (objvClassifyGatherFieldEN.QuestionName == "[null]") objvClassifyGatherFieldEN.QuestionName = null; //题目名称
if (objvClassifyGatherFieldEN.GridTitle == "[null]") objvClassifyGatherFieldEN.GridTitle = null; //表格标题
if (objvClassifyGatherFieldEN.QuestionnaireSetId == "[null]") objvClassifyGatherFieldEN.QuestionnaireSetId = null; //问卷集ID
if (objvClassifyGatherFieldEN.QuestionnaireSetName == "[null]") objvClassifyGatherFieldEN.QuestionnaireSetName = null; //问卷集名
if (objvClassifyGatherFieldEN.QuestionTypeId == "[null]") objvClassifyGatherFieldEN.QuestionTypeId = null; //题目类型Id
if (objvClassifyGatherFieldEN.QuestionTypeName == "[null]") objvClassifyGatherFieldEN.QuestionTypeName = null; //题目类型名
if (objvClassifyGatherFieldEN.AnswerTypeId == "[null]") objvClassifyGatherFieldEN.AnswerTypeId = null; //答案类型ID
if (objvClassifyGatherFieldEN.AnswerTypeName == "[null]") objvClassifyGatherFieldEN.AnswerTypeName = null; //答案类型名
if (objvClassifyGatherFieldEN.AnswerModeId == "[null]") objvClassifyGatherFieldEN.AnswerModeId = null; //答案模式Id
if (objvClassifyGatherFieldEN.AnswerModeName == "[null]") objvClassifyGatherFieldEN.AnswerModeName = null; //答案模式名称
if (objvClassifyGatherFieldEN.DetailTitle == "[null]") objvClassifyGatherFieldEN.DetailTitle = null; //详细列表标题
if (objvClassifyGatherFieldEN.ClassifyGatherPeriod == "[null]") objvClassifyGatherFieldEN.ClassifyGatherPeriod = null; //分类统计时期
if (objvClassifyGatherFieldEN.Memo == "[null]") objvClassifyGatherFieldEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvClassifyGatherFieldEN objvClassifyGatherFieldEN)
{
 vClassifyGatherFieldDA.CheckProperty4Condition(objvClassifyGatherFieldEN);
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
if (clsClassifyGatherFieldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyGatherFieldBL没有刷新缓存机制(clsClassifyGatherFieldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClassifyFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyFieldTypeBL没有刷新缓存机制(clsClassifyFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGatherModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGatherModeBL没有刷新缓存机制(clsGatherModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetBL没有刷新缓存机制(clsQuestionnaireSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClassifyGatherBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyGatherBL没有刷新缓存机制(clsClassifyGatherBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeBL没有刷新缓存机制(clscc_ExamGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvClassifyGatherFieldObjLstCache == null)
//{
//arrvClassifyGatherFieldObjLstCache = vClassifyGatherFieldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClassifyGatherFieldEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName);
List<clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLstCache = GetObjLstCache();
IEnumerable <clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLst_Sel =
arrvClassifyGatherFieldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvClassifyGatherFieldObjLst_Sel.Count() == 0)
{
   clsvClassifyGatherFieldEN obj = clsvClassifyGatherFieldBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvClassifyGatherFieldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetAllvClassifyGatherFieldObjLstCache()
{
//获取缓存中的对象列表
List<clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLstCache = GetObjLstCache(); 
return arrvClassifyGatherFieldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName);
List<clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClassifyGatherFieldObjLstCache;
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
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvClassifyGatherFieldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvClassifyGatherFieldEN._RefreshTimeLst.Count == 0) return "";
return clsvClassifyGatherFieldEN._RefreshTimeLst[clsvClassifyGatherFieldEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convClassifyGatherField.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convClassifyGatherField.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convClassifyGatherField.AttributeName));
throw new Exception(strMsg);
}
var objvClassifyGatherField = clsvClassifyGatherFieldBL.GetObjBymIdCache(lngmId);
if (objvClassifyGatherField == null) return "";
return objvClassifyGatherField[strOutFldName].ToString();
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
int intRecCount = clsvClassifyGatherFieldDA.GetRecCount(strTabName);
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
int intRecCount = clsvClassifyGatherFieldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvClassifyGatherFieldDA.GetRecCount();
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
int intRecCount = clsvClassifyGatherFieldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvClassifyGatherFieldEN objvClassifyGatherFieldCond)
{
List<clsvClassifyGatherFieldEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClassifyGatherFieldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClassifyGatherField.AttributeName)
{
if (objvClassifyGatherFieldCond.IsUpdated(strFldName) == false) continue;
if (objvClassifyGatherFieldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClassifyGatherFieldCond[strFldName].ToString());
}
else
{
if (objvClassifyGatherFieldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClassifyGatherFieldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClassifyGatherFieldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClassifyGatherFieldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClassifyGatherFieldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClassifyGatherFieldCond[strFldName]));
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
 List<string> arrList = clsvClassifyGatherFieldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vClassifyGatherFieldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vClassifyGatherFieldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}