
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassifyGatherFieldWApi
 表名:vClassifyGatherField(01120016)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:15
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计
 模块英文名:QueryStatistics
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
public static class clsvClassifyGatherFieldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionID(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convClassifyGatherField.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convClassifyGatherField.QuestionID);
objvClassifyGatherFieldEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(convClassifyGatherField.QuestionID) == false)
{
objvClassifyGatherFieldEN.dicFldComparisonOp.Add(convClassifyGatherField.QuestionID, strComparisonOp);
}
else
{
objvClassifyGatherFieldEN.dicFldComparisonOp[convClassifyGatherField.QuestionID] = strComparisonOp;
}
}
return objvClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionIndex(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, int intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionNo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convClassifyGatherField.QuestionNo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convClassifyGatherField.QuestionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetGridTitle(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convClassifyGatherField.GridTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionnaireSetId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convClassifyGatherField.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convClassifyGatherField.QuestionnaireSetId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionnaireSetName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convClassifyGatherField.QuestionnaireSetName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyGatherId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyGatherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherId, convClassifyGatherField.ClassifyGatherId);
clsCheckSql.CheckFieldLen(strClassifyGatherId, 4, convClassifyGatherField.ClassifyGatherId);
clsCheckSql.CheckFieldForeignKey(strClassifyGatherId, 4, convClassifyGatherField.ClassifyGatherId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyGatherName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyGatherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherName, convClassifyGatherField.ClassifyGatherName);
clsCheckSql.CheckFieldLen(strClassifyGatherName, 30, convClassifyGatherField.ClassifyGatherName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyFieldTypeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyFieldTypeId, convClassifyGatherField.ClassifyFieldTypeId);
clsCheckSql.CheckFieldLen(strClassifyFieldTypeId, 4, convClassifyGatherField.ClassifyFieldTypeId);
clsCheckSql.CheckFieldForeignKey(strClassifyFieldTypeId, 4, convClassifyGatherField.ClassifyFieldTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyFieldTypeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyFieldTypeName, convClassifyGatherField.ClassifyFieldTypeName);
clsCheckSql.CheckFieldLen(strClassifyFieldTypeName, 30, convClassifyGatherField.ClassifyFieldTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetGatherModeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strGatherModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGatherModeId, convClassifyGatherField.GatherModeId);
clsCheckSql.CheckFieldLen(strGatherModeId, 4, convClassifyGatherField.GatherModeId);
clsCheckSql.CheckFieldForeignKey(strGatherModeId, 4, convClassifyGatherField.GatherModeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetGatherModeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strGatherModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGatherModeName, convClassifyGatherField.GatherModeName);
clsCheckSql.CheckFieldLen(strGatherModeName, 30, convClassifyGatherField.GatherModeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionTypeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convClassifyGatherField.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convClassifyGatherField.QuestionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetQuestionTypeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convClassifyGatherField.QuestionTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerTypeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convClassifyGatherField.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convClassifyGatherField.AnswerTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerTypeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convClassifyGatherField.AnswerTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerModeId(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convClassifyGatherField.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convClassifyGatherField.AnswerModeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetAnswerModeName(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convClassifyGatherField.AnswerModeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetDetailTitle(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strDetailTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTitle, 30, convClassifyGatherField.DetailTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetClassifyGatherPeriod(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strClassifyGatherPeriod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassifyGatherPeriod, 50, convClassifyGatherField.ClassifyGatherPeriod);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetUpdDate(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convClassifyGatherField.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convClassifyGatherField.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetUpdUser(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convClassifyGatherField.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClassifyGatherField.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherFieldEN SetMemo(this clsvClassifyGatherFieldEN objvClassifyGatherFieldEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClassifyGatherField.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClassifyGatherFieldEN objvClassifyGatherField_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.mId) == true)
{
string strComparisonOp_mId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convClassifyGatherField.mId, objvClassifyGatherField_Cond.mId, strComparisonOp_mId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionID, objvClassifyGatherField_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convClassifyGatherField.QuestionIndex, objvClassifyGatherField_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionNo, objvClassifyGatherField_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionName, objvClassifyGatherField_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.GridTitle, objvClassifyGatherField_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionnaireSetId, objvClassifyGatherField_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionnaireSetName) == true)
{
string strComparisonOp_QuestionnaireSetName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionnaireSetName, objvClassifyGatherField_Cond.QuestionnaireSetName, strComparisonOp_QuestionnaireSetName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.ClassifyGatherId) == true)
{
string strComparisonOp_ClassifyGatherId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyGatherId, objvClassifyGatherField_Cond.ClassifyGatherId, strComparisonOp_ClassifyGatherId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.ClassifyGatherName) == true)
{
string strComparisonOp_ClassifyGatherName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyGatherName, objvClassifyGatherField_Cond.ClassifyGatherName, strComparisonOp_ClassifyGatherName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.ClassifyFieldTypeId) == true)
{
string strComparisonOp_ClassifyFieldTypeId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.ClassifyFieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyFieldTypeId, objvClassifyGatherField_Cond.ClassifyFieldTypeId, strComparisonOp_ClassifyFieldTypeId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.ClassifyFieldTypeName) == true)
{
string strComparisonOp_ClassifyFieldTypeName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.ClassifyFieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyFieldTypeName, objvClassifyGatherField_Cond.ClassifyFieldTypeName, strComparisonOp_ClassifyFieldTypeName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.GatherModeId) == true)
{
string strComparisonOp_GatherModeId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.GatherModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.GatherModeId, objvClassifyGatherField_Cond.GatherModeId, strComparisonOp_GatherModeId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.GatherModeName) == true)
{
string strComparisonOp_GatherModeName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.GatherModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.GatherModeName, objvClassifyGatherField_Cond.GatherModeName, strComparisonOp_GatherModeName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionTypeId, objvClassifyGatherField_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.QuestionTypeName, objvClassifyGatherField_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerTypeId, objvClassifyGatherField_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerTypeName, objvClassifyGatherField_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.IsDefault) == true)
{
if (objvClassifyGatherField_Cond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClassifyGatherField.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClassifyGatherField.IsDefault);
}
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerModeId, objvClassifyGatherField_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.AnswerModeName, objvClassifyGatherField_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.DetailTitle) == true)
{
string strComparisonOp_DetailTitle = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.DetailTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.DetailTitle, objvClassifyGatherField_Cond.DetailTitle, strComparisonOp_DetailTitle);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.IsDetailTitleIndexNo) == true)
{
if (objvClassifyGatherField_Cond.IsDetailTitleIndexNo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClassifyGatherField.IsDetailTitleIndexNo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClassifyGatherField.IsDetailTitleIndexNo);
}
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.ClassifyGatherPeriod) == true)
{
string strComparisonOp_ClassifyGatherPeriod = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.ClassifyGatherPeriod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.ClassifyGatherPeriod, objvClassifyGatherField_Cond.ClassifyGatherPeriod, strComparisonOp_ClassifyGatherPeriod);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.RecNo) == true)
{
string strComparisonOp_RecNo = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.RecNo];
strWhereCond += string.Format(" And {0} {2} {1}", convClassifyGatherField.RecNo, objvClassifyGatherField_Cond.RecNo, strComparisonOp_RecNo);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.UpdDate, objvClassifyGatherField_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.UpdUser, objvClassifyGatherField_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvClassifyGatherField_Cond.IsUpdated(convClassifyGatherField.Memo) == true)
{
string strComparisonOp_Memo = objvClassifyGatherField_Cond.dicFldComparisonOp[convClassifyGatherField.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGatherField.Memo, objvClassifyGatherField_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v分类汇总字段(vClassifyGatherField)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClassifyGatherFieldWApi
{
private static readonly string mstrApiControllerName = "vClassifyGatherFieldApi";

 public clsvClassifyGatherFieldWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassifyGatherFieldEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvClassifyGatherFieldEN = JsonConvert.DeserializeObject<clsvClassifyGatherFieldEN>((string)jobjReturn["ReturnObj"]);
return objvClassifyGatherFieldEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassifyGatherFieldEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvClassifyGatherFieldEN = JsonConvert.DeserializeObject<clsvClassifyGatherFieldEN>((string)jobjReturn["ReturnObj"]);
return objvClassifyGatherFieldEN;
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
public static clsvClassifyGatherFieldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = null;
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
objvClassifyGatherFieldEN = JsonConvert.DeserializeObject<clsvClassifyGatherFieldEN>((string)jobjReturn["ReturnObj"]);
return objvClassifyGatherFieldEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClassifyGatherFieldEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName_S);
List<clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLst_Sel =
from objvClassifyGatherFieldEN in arrvClassifyGatherFieldObjLst_Cache
where objvClassifyGatherFieldEN.mId == lngmId
select objvClassifyGatherFieldEN;
if (arrvClassifyGatherFieldObjLst_Sel.Count() == 0)
{
   clsvClassifyGatherFieldEN obj = clsvClassifyGatherFieldWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClassifyGatherFieldObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetObjLst(string strWhereCond)
{
 List<clsvClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvClassifyGatherFieldEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvClassifyGatherFieldEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName_S);
List<clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLst_Sel =
from objvClassifyGatherFieldEN in arrvClassifyGatherFieldObjLst_Cache
where arrMId.Contains(objvClassifyGatherFieldEN.mId)
select objvClassifyGatherFieldEN;
return arrvClassifyGatherFieldObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassifyGatherFieldEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvClassifyGatherFieldEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherFieldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherFieldEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvClassifyGatherFieldENS">源对象</param>
 /// <param name = "objvClassifyGatherFieldENT">目标对象</param>
 public static void CopyTo(clsvClassifyGatherFieldEN objvClassifyGatherFieldENS, clsvClassifyGatherFieldEN objvClassifyGatherFieldENT)
{
try
{
objvClassifyGatherFieldENT.mId = objvClassifyGatherFieldENS.mId; //mId
objvClassifyGatherFieldENT.QuestionID = objvClassifyGatherFieldENS.QuestionID; //题目ID
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
public static DataTable ToDataTable(List<clsvClassifyGatherFieldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClassifyGatherFieldEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClassifyGatherFieldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClassifyGatherFieldEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClassifyGatherFieldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClassifyGatherFieldEN.AttributeName)
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
if (clsClassifyGatherFieldWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyGatherFieldWApi没有刷新缓存机制(clsClassifyGatherFieldWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClassifyFieldTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyFieldTypeWApi没有刷新缓存机制(clsClassifyFieldTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGatherModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsGatherModeWApi没有刷新缓存机制(clsGatherModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetWApi没有刷新缓存机制(clsQuestionnaireSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClassifyGatherWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyGatherWApi没有刷新缓存机制(clsClassifyGatherWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvClassifyGatherFieldObjLst_Cache == null)
//{
//arrvClassifyGatherFieldObjLst_Cache = await clsvClassifyGatherFieldWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName_S);
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
public static List<clsvClassifyGatherFieldEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClassifyGatherFieldEN._CurrTabName_S);
List<clsvClassifyGatherFieldEN> arrvClassifyGatherFieldObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClassifyGatherFieldObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClassifyGatherFieldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClassifyGatherField.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convClassifyGatherField.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convClassifyGatherField.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.QuestionnaireSetName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.ClassifyGatherId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.ClassifyGatherName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.ClassifyFieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.ClassifyFieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.GatherModeId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.GatherModeName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.IsDefault, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClassifyGatherField.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.DetailTitle, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.IsDetailTitleIndexNo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClassifyGatherField.ClassifyGatherPeriod, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.RecNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convClassifyGatherField.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGatherField.Memo, Type.GetType("System.String"));
foreach (clsvClassifyGatherFieldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClassifyGatherField.mId] = objInFor[convClassifyGatherField.mId];
objDR[convClassifyGatherField.QuestionID] = objInFor[convClassifyGatherField.QuestionID];
objDR[convClassifyGatherField.QuestionIndex] = objInFor[convClassifyGatherField.QuestionIndex];
objDR[convClassifyGatherField.QuestionNo] = objInFor[convClassifyGatherField.QuestionNo];
objDR[convClassifyGatherField.QuestionName] = objInFor[convClassifyGatherField.QuestionName];
objDR[convClassifyGatherField.GridTitle] = objInFor[convClassifyGatherField.GridTitle];
objDR[convClassifyGatherField.QuestionnaireSetId] = objInFor[convClassifyGatherField.QuestionnaireSetId];
objDR[convClassifyGatherField.QuestionnaireSetName] = objInFor[convClassifyGatherField.QuestionnaireSetName];
objDR[convClassifyGatherField.ClassifyGatherId] = objInFor[convClassifyGatherField.ClassifyGatherId];
objDR[convClassifyGatherField.ClassifyGatherName] = objInFor[convClassifyGatherField.ClassifyGatherName];
objDR[convClassifyGatherField.ClassifyFieldTypeId] = objInFor[convClassifyGatherField.ClassifyFieldTypeId];
objDR[convClassifyGatherField.ClassifyFieldTypeName] = objInFor[convClassifyGatherField.ClassifyFieldTypeName];
objDR[convClassifyGatherField.GatherModeId] = objInFor[convClassifyGatherField.GatherModeId];
objDR[convClassifyGatherField.GatherModeName] = objInFor[convClassifyGatherField.GatherModeName];
objDR[convClassifyGatherField.QuestionTypeId] = objInFor[convClassifyGatherField.QuestionTypeId];
objDR[convClassifyGatherField.QuestionTypeName] = objInFor[convClassifyGatherField.QuestionTypeName];
objDR[convClassifyGatherField.AnswerTypeId] = objInFor[convClassifyGatherField.AnswerTypeId];
objDR[convClassifyGatherField.AnswerTypeName] = objInFor[convClassifyGatherField.AnswerTypeName];
objDR[convClassifyGatherField.IsDefault] = objInFor[convClassifyGatherField.IsDefault];
objDR[convClassifyGatherField.AnswerModeId] = objInFor[convClassifyGatherField.AnswerModeId];
objDR[convClassifyGatherField.AnswerModeName] = objInFor[convClassifyGatherField.AnswerModeName];
objDR[convClassifyGatherField.DetailTitle] = objInFor[convClassifyGatherField.DetailTitle];
objDR[convClassifyGatherField.IsDetailTitleIndexNo] = objInFor[convClassifyGatherField.IsDetailTitleIndexNo];
objDR[convClassifyGatherField.ClassifyGatherPeriod] = objInFor[convClassifyGatherField.ClassifyGatherPeriod];
objDR[convClassifyGatherField.RecNo] = objInFor[convClassifyGatherField.RecNo];
objDR[convClassifyGatherField.UpdDate] = objInFor[convClassifyGatherField.UpdDate];
objDR[convClassifyGatherField.UpdUser] = objInFor[convClassifyGatherField.UpdUser];
objDR[convClassifyGatherField.Memo] = objInFor[convClassifyGatherField.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}