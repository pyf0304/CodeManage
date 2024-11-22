
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_CompositionBL
 表名:vzx_Composition(01120765)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:31
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
public static class  clsvzx_CompositionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_CompositionEN GetObj(this K_zxPaperId_vzx_Composition myKey)
{
clsvzx_CompositionEN objvzx_CompositionEN = clsvzx_CompositionBL.vzx_CompositionDA.GetObjByzxPaperId(myKey.Value);
return objvzx_CompositionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetzxPaperId(this clsvzx_CompositionEN objvzx_CompositionEN, string strzxPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxPaperId, 8, convzx_Composition.zxPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxPaperId, 8, convzx_Composition.zxPaperId);
}
objvzx_CompositionEN.zxPaperId = strzxPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.zxPaperId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.zxPaperId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.zxPaperId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetLiteratureTypeName(this clsvzx_CompositionEN objvzx_CompositionEN, string strLiteratureTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeName, 100, convzx_Composition.LiteratureTypeName);
}
objvzx_CompositionEN.LiteratureTypeName = strLiteratureTypeName; //作文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.LiteratureTypeName) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.LiteratureTypeName, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.LiteratureTypeName] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetCurrEduClsId(this clsvzx_CompositionEN objvzx_CompositionEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convzx_Composition.CurrEduClsId);
}
objvzx_CompositionEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.CurrEduClsId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.CurrEduClsId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.CurrEduClsId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetEduClsName(this clsvzx_CompositionEN objvzx_CompositionEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convzx_Composition.EduClsName);
}
objvzx_CompositionEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.EduClsName) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.EduClsName, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.EduClsName] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetGroupTextId(this clsvzx_CompositionEN objvzx_CompositionEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, convzx_Composition.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_Composition.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_Composition.GroupTextId);
}
objvzx_CompositionEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.GroupTextId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.GroupTextId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.GroupTextId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetTeaQCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intTeaQCount, string strComparisonOp="")
	{
objvzx_CompositionEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.TeaQCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.TeaQCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.TeaQCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetTagsCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intTagsCount, string strComparisonOp="")
	{
objvzx_CompositionEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.TagsCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.TagsCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.TagsCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetSubVCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intSubVCount, string strComparisonOp="")
	{
objvzx_CompositionEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.SubVCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.SubVCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.SubVCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetPaperQCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intPaperQCount, string strComparisonOp="")
	{
objvzx_CompositionEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.PaperQCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.PaperQCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.PaperQCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetzxShareId(this clsvzx_CompositionEN objvzx_CompositionEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_Composition.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_Composition.zxShareId);
}
objvzx_CompositionEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.zxShareId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.zxShareId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.zxShareId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetCreateDate(this clsvzx_CompositionEN objvzx_CompositionEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_Composition.CreateDate);
}
objvzx_CompositionEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.CreateDate) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.CreateDate, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.CreateDate] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetExpectedConclusion(this clsvzx_CompositionEN objvzx_CompositionEN, string strExpectedConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExpectedConclusion, 5000, convzx_Composition.ExpectedConclusion);
}
objvzx_CompositionEN.ExpectedConclusion = strExpectedConclusion; //预期结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.ExpectedConclusion) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.ExpectedConclusion, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.ExpectedConclusion] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetDimensionDataProcess(this clsvzx_CompositionEN objvzx_CompositionEN, string strDimensionDataProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDimensionDataProcess, 5000, convzx_Composition.DimensionDataProcess);
}
objvzx_CompositionEN.DimensionDataProcess = strDimensionDataProcess; //数据处理的维度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.DimensionDataProcess) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.DimensionDataProcess, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.DimensionDataProcess] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetInnovationPoints(this clsvzx_CompositionEN objvzx_CompositionEN, string strInnovationPoints, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInnovationPoints, 5000, convzx_Composition.InnovationPoints);
}
objvzx_CompositionEN.InnovationPoints = strInnovationPoints; //创新点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.InnovationPoints) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.InnovationPoints, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.InnovationPoints] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetResearchStatus(this clsvzx_CompositionEN objvzx_CompositionEN, string strResearchStatus, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchStatus, 5000, convzx_Composition.ResearchStatus);
}
objvzx_CompositionEN.ResearchStatus = strResearchStatus; //目前研究的现状
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.ResearchStatus) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.ResearchStatus, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.ResearchStatus] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetIsPublic(this clsvzx_CompositionEN objvzx_CompositionEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_CompositionEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.IsPublic) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.IsPublic, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.IsPublic] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetUpdUser(this clsvzx_CompositionEN objvzx_CompositionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Composition.UpdUser);
}
objvzx_CompositionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.UpdUser) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.UpdUser, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.UpdUser] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetResearchDesign(this clsvzx_CompositionEN objvzx_CompositionEN, string strResearchDesign, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchDesign, 5000, convzx_Composition.ResearchDesign);
}
objvzx_CompositionEN.ResearchDesign = strResearchDesign; //研究设计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.ResearchDesign) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.ResearchDesign, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.ResearchDesign] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetVersionCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_CompositionEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.VersionCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.VersionCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.VersionCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetAskQuestion(this clsvzx_CompositionEN objvzx_CompositionEN, string strAskQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAskQuestion, 5000, convzx_Composition.AskQuestion);
}
objvzx_CompositionEN.AskQuestion = strAskQuestion; //问题提出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.AskQuestion) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.AskQuestion, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.AskQuestion] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetzxPaperStatusId(this clsvzx_CompositionEN objvzx_CompositionEN, string strzxPaperStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxPaperStatusId, 2, convzx_Composition.zxPaperStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxPaperStatusId, 2, convzx_Composition.zxPaperStatusId);
}
objvzx_CompositionEN.zxPaperStatusId = strzxPaperStatusId; //论文状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.zxPaperStatusId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.zxPaperStatusId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.zxPaperStatusId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetPaperTypeId(this clsvzx_CompositionEN objvzx_CompositionEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convzx_Composition.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convzx_Composition.PaperTypeId);
}
objvzx_CompositionEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.PaperTypeId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.PaperTypeId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.PaperTypeId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetIdCurrEduCls(this clsvzx_CompositionEN objvzx_CompositionEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_Composition.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_Composition.IdCurrEduCls);
}
objvzx_CompositionEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.IdCurrEduCls) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetTeaScore(this clsvzx_CompositionEN objvzx_CompositionEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_CompositionEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.TeaScore) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.TeaScore, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.TeaScore] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetStuScore(this clsvzx_CompositionEN objvzx_CompositionEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_CompositionEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.StuScore) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.StuScore, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.StuScore] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetScore(this clsvzx_CompositionEN objvzx_CompositionEN, float? fltScore, string strComparisonOp="")
	{
objvzx_CompositionEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.Score) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.Score, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.Score] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetPcount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intPcount, string strComparisonOp="")
	{
objvzx_CompositionEN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.Pcount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.Pcount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.Pcount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetOkCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intOkCount, string strComparisonOp="")
	{
objvzx_CompositionEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.OkCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.OkCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.OkCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetDownloadCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intDownloadCount, string strComparisonOp="")
	{
objvzx_CompositionEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.DownloadCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.DownloadCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.DownloadCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetCollectionCount(this clsvzx_CompositionEN objvzx_CompositionEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvzx_CompositionEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.CollectionCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.CollectionCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.CollectionCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetAttachmentCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvzx_CompositionEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.AttachmentCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.AttachmentCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.AttachmentCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetAppraiseCount(this clsvzx_CompositionEN objvzx_CompositionEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_CompositionEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.AppraiseCount) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.AppraiseCount, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.AppraiseCount] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetIsSubmit(this clsvzx_CompositionEN objvzx_CompositionEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_CompositionEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.IsSubmit) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.IsSubmit, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.IsSubmit] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetBrowseNumber(this clsvzx_CompositionEN objvzx_CompositionEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvzx_CompositionEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.BrowseNumber) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.BrowseNumber, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.BrowseNumber] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetzxLiteratureTypeId(this clsvzx_CompositionEN objvzx_CompositionEN, string strzxLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxLiteratureTypeId, convzx_Composition.zxLiteratureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLiteratureTypeId, 2, convzx_Composition.zxLiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLiteratureTypeId, 2, convzx_Composition.zxLiteratureTypeId);
}
objvzx_CompositionEN.zxLiteratureTypeId = strzxLiteratureTypeId; //作文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.zxLiteratureTypeId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.zxLiteratureTypeId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.zxLiteratureTypeId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetChecker(this clsvzx_CompositionEN objvzx_CompositionEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, convzx_Composition.Checker);
}
objvzx_CompositionEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.Checker) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.Checker, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.Checker] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetPaperTitle(this clsvzx_CompositionEN objvzx_CompositionEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convzx_Composition.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convzx_Composition.PaperTitle);
}
objvzx_CompositionEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.PaperTitle) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.PaperTitle, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.PaperTitle] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetPaperName(this clsvzx_CompositionEN objvzx_CompositionEN, string strPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperName, 500, convzx_Composition.PaperName);
}
objvzx_CompositionEN.PaperName = strPaperName; //主题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.PaperName) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.PaperName, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.PaperName] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetPaperContent(this clsvzx_CompositionEN objvzx_CompositionEN, string strPaperContent, string strComparisonOp="")
	{
objvzx_CompositionEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.PaperContent) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.PaperContent, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.PaperContent] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetPeriodical(this clsvzx_CompositionEN objvzx_CompositionEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convzx_Composition.Periodical);
}
objvzx_CompositionEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.Periodical) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.Periodical, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.Periodical] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetAuthor(this clsvzx_CompositionEN objvzx_CompositionEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_Composition.Author);
}
objvzx_CompositionEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.Author) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.Author, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.Author] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetResearchQuestion(this clsvzx_CompositionEN objvzx_CompositionEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convzx_Composition.ResearchQuestion);
}
objvzx_CompositionEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.ResearchQuestion) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.ResearchQuestion, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.ResearchQuestion] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetUpdDate(this clsvzx_CompositionEN objvzx_CompositionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Composition.UpdDate);
}
objvzx_CompositionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.UpdDate) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.UpdDate, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.UpdDate] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetMemo(this clsvzx_CompositionEN objvzx_CompositionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Composition.Memo);
}
objvzx_CompositionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.Memo) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.Memo, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.Memo] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetKeyword(this clsvzx_CompositionEN objvzx_CompositionEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convzx_Composition.Keyword);
}
objvzx_CompositionEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.Keyword) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.Keyword, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.Keyword] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetLiteratureSources(this clsvzx_CompositionEN objvzx_CompositionEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convzx_Composition.LiteratureSources);
}
objvzx_CompositionEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.LiteratureSources) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.LiteratureSources, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.LiteratureSources] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetLiteratureLink(this clsvzx_CompositionEN objvzx_CompositionEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convzx_Composition.LiteratureLink);
}
objvzx_CompositionEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.LiteratureLink) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.LiteratureLink, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.LiteratureLink] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetUploadfileUrl(this clsvzx_CompositionEN objvzx_CompositionEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convzx_Composition.UploadfileUrl);
}
objvzx_CompositionEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.UploadfileUrl) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.UploadfileUrl, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.UploadfileUrl] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetIsQuotethesis(this clsvzx_CompositionEN objvzx_CompositionEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objvzx_CompositionEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.IsQuotethesis) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.IsQuotethesis, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.IsQuotethesis] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetQuoteId(this clsvzx_CompositionEN objvzx_CompositionEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, convzx_Composition.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, convzx_Composition.QuoteId);
}
objvzx_CompositionEN.QuoteId = strQuoteId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.QuoteId) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.QuoteId, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.QuoteId] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_CompositionEN SetIsChecked(this clsvzx_CompositionEN objvzx_CompositionEN, bool bolIsChecked, string strComparisonOp="")
	{
objvzx_CompositionEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_CompositionEN.dicFldComparisonOp.ContainsKey(convzx_Composition.IsChecked) == false)
{
objvzx_CompositionEN.dicFldComparisonOp.Add(convzx_Composition.IsChecked, strComparisonOp);
}
else
{
objvzx_CompositionEN.dicFldComparisonOp[convzx_Composition.IsChecked] = strComparisonOp;
}
}
return objvzx_CompositionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_CompositionENS">源对象</param>
 /// <param name = "objvzx_CompositionENT">目标对象</param>
 public static void CopyTo(this clsvzx_CompositionEN objvzx_CompositionENS, clsvzx_CompositionEN objvzx_CompositionENT)
{
try
{
objvzx_CompositionENT.zxPaperId = objvzx_CompositionENS.zxPaperId; //论文Id
objvzx_CompositionENT.LiteratureTypeName = objvzx_CompositionENS.LiteratureTypeName; //作文类型名
objvzx_CompositionENT.CurrEduClsId = objvzx_CompositionENS.CurrEduClsId; //教学班Id
objvzx_CompositionENT.EduClsName = objvzx_CompositionENS.EduClsName; //教学班名
objvzx_CompositionENT.GroupTextId = objvzx_CompositionENS.GroupTextId; //小组Id
objvzx_CompositionENT.TeaQCount = objvzx_CompositionENS.TeaQCount; //教师提问数
objvzx_CompositionENT.TagsCount = objvzx_CompositionENS.TagsCount; //论文标注数
objvzx_CompositionENT.SubVCount = objvzx_CompositionENS.SubVCount; //论文子观点数
objvzx_CompositionENT.PaperQCount = objvzx_CompositionENS.PaperQCount; //论文答疑数
objvzx_CompositionENT.zxShareId = objvzx_CompositionENS.zxShareId; //分享Id
objvzx_CompositionENT.CreateDate = objvzx_CompositionENS.CreateDate; //建立日期
objvzx_CompositionENT.ExpectedConclusion = objvzx_CompositionENS.ExpectedConclusion; //预期结论
objvzx_CompositionENT.DimensionDataProcess = objvzx_CompositionENS.DimensionDataProcess; //数据处理的维度
objvzx_CompositionENT.InnovationPoints = objvzx_CompositionENS.InnovationPoints; //创新点
objvzx_CompositionENT.ResearchStatus = objvzx_CompositionENS.ResearchStatus; //目前研究的现状
objvzx_CompositionENT.IsPublic = objvzx_CompositionENS.IsPublic; //是否公开
objvzx_CompositionENT.UpdUser = objvzx_CompositionENS.UpdUser; //修改人
objvzx_CompositionENT.ResearchDesign = objvzx_CompositionENS.ResearchDesign; //研究设计
objvzx_CompositionENT.VersionCount = objvzx_CompositionENS.VersionCount; //版本统计
objvzx_CompositionENT.AskQuestion = objvzx_CompositionENS.AskQuestion; //问题提出
objvzx_CompositionENT.zxPaperStatusId = objvzx_CompositionENS.zxPaperStatusId; //论文状态Id
objvzx_CompositionENT.PaperTypeId = objvzx_CompositionENS.PaperTypeId; //论文类型Id
objvzx_CompositionENT.IdCurrEduCls = objvzx_CompositionENS.IdCurrEduCls; //教学班流水号
objvzx_CompositionENT.TeaScore = objvzx_CompositionENS.TeaScore; //教师评分
objvzx_CompositionENT.StuScore = objvzx_CompositionENS.StuScore; //学生平均分
objvzx_CompositionENT.Score = objvzx_CompositionENS.Score; //评分
objvzx_CompositionENT.Pcount = objvzx_CompositionENS.Pcount; //读写数
objvzx_CompositionENT.OkCount = objvzx_CompositionENS.OkCount; //点赞统计
objvzx_CompositionENT.DownloadCount = objvzx_CompositionENS.DownloadCount; //下载数
objvzx_CompositionENT.CollectionCount = objvzx_CompositionENS.CollectionCount; //收藏数量
objvzx_CompositionENT.AttachmentCount = objvzx_CompositionENS.AttachmentCount; //附件计数
objvzx_CompositionENT.AppraiseCount = objvzx_CompositionENS.AppraiseCount; //评论数
objvzx_CompositionENT.IsSubmit = objvzx_CompositionENS.IsSubmit; //是否提交
objvzx_CompositionENT.BrowseNumber = objvzx_CompositionENS.BrowseNumber; //浏览量
objvzx_CompositionENT.zxLiteratureTypeId = objvzx_CompositionENS.zxLiteratureTypeId; //作文类型Id
objvzx_CompositionENT.Checker = objvzx_CompositionENS.Checker; //审核人
objvzx_CompositionENT.PaperTitle = objvzx_CompositionENS.PaperTitle; //论文标题
objvzx_CompositionENT.PaperName = objvzx_CompositionENS.PaperName; //主题名称
objvzx_CompositionENT.PaperContent = objvzx_CompositionENS.PaperContent; //主题内容
objvzx_CompositionENT.Periodical = objvzx_CompositionENS.Periodical; //期刊
objvzx_CompositionENT.Author = objvzx_CompositionENS.Author; //作者
objvzx_CompositionENT.ResearchQuestion = objvzx_CompositionENS.ResearchQuestion; //研究问题
objvzx_CompositionENT.UpdDate = objvzx_CompositionENS.UpdDate; //修改日期
objvzx_CompositionENT.Memo = objvzx_CompositionENS.Memo; //备注
objvzx_CompositionENT.Keyword = objvzx_CompositionENS.Keyword; //关键字
objvzx_CompositionENT.LiteratureSources = objvzx_CompositionENS.LiteratureSources; //文献来源
objvzx_CompositionENT.LiteratureLink = objvzx_CompositionENS.LiteratureLink; //文献链接
objvzx_CompositionENT.UploadfileUrl = objvzx_CompositionENS.UploadfileUrl; //文件地址
objvzx_CompositionENT.IsQuotethesis = objvzx_CompositionENS.IsQuotethesis; //是否引用论文
objvzx_CompositionENT.QuoteId = objvzx_CompositionENS.QuoteId; //引用Id
objvzx_CompositionENT.IsChecked = objvzx_CompositionENS.IsChecked; //是否检查
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
 /// <param name = "objvzx_CompositionENS">源对象</param>
 /// <returns>目标对象=>clsvzx_CompositionEN:objvzx_CompositionENT</returns>
 public static clsvzx_CompositionEN CopyTo(this clsvzx_CompositionEN objvzx_CompositionENS)
{
try
{
 clsvzx_CompositionEN objvzx_CompositionENT = new clsvzx_CompositionEN()
{
zxPaperId = objvzx_CompositionENS.zxPaperId, //论文Id
LiteratureTypeName = objvzx_CompositionENS.LiteratureTypeName, //作文类型名
CurrEduClsId = objvzx_CompositionENS.CurrEduClsId, //教学班Id
EduClsName = objvzx_CompositionENS.EduClsName, //教学班名
GroupTextId = objvzx_CompositionENS.GroupTextId, //小组Id
TeaQCount = objvzx_CompositionENS.TeaQCount, //教师提问数
TagsCount = objvzx_CompositionENS.TagsCount, //论文标注数
SubVCount = objvzx_CompositionENS.SubVCount, //论文子观点数
PaperQCount = objvzx_CompositionENS.PaperQCount, //论文答疑数
zxShareId = objvzx_CompositionENS.zxShareId, //分享Id
CreateDate = objvzx_CompositionENS.CreateDate, //建立日期
ExpectedConclusion = objvzx_CompositionENS.ExpectedConclusion, //预期结论
DimensionDataProcess = objvzx_CompositionENS.DimensionDataProcess, //数据处理的维度
InnovationPoints = objvzx_CompositionENS.InnovationPoints, //创新点
ResearchStatus = objvzx_CompositionENS.ResearchStatus, //目前研究的现状
IsPublic = objvzx_CompositionENS.IsPublic, //是否公开
UpdUser = objvzx_CompositionENS.UpdUser, //修改人
ResearchDesign = objvzx_CompositionENS.ResearchDesign, //研究设计
VersionCount = objvzx_CompositionENS.VersionCount, //版本统计
AskQuestion = objvzx_CompositionENS.AskQuestion, //问题提出
zxPaperStatusId = objvzx_CompositionENS.zxPaperStatusId, //论文状态Id
PaperTypeId = objvzx_CompositionENS.PaperTypeId, //论文类型Id
IdCurrEduCls = objvzx_CompositionENS.IdCurrEduCls, //教学班流水号
TeaScore = objvzx_CompositionENS.TeaScore, //教师评分
StuScore = objvzx_CompositionENS.StuScore, //学生平均分
Score = objvzx_CompositionENS.Score, //评分
Pcount = objvzx_CompositionENS.Pcount, //读写数
OkCount = objvzx_CompositionENS.OkCount, //点赞统计
DownloadCount = objvzx_CompositionENS.DownloadCount, //下载数
CollectionCount = objvzx_CompositionENS.CollectionCount, //收藏数量
AttachmentCount = objvzx_CompositionENS.AttachmentCount, //附件计数
AppraiseCount = objvzx_CompositionENS.AppraiseCount, //评论数
IsSubmit = objvzx_CompositionENS.IsSubmit, //是否提交
BrowseNumber = objvzx_CompositionENS.BrowseNumber, //浏览量
zxLiteratureTypeId = objvzx_CompositionENS.zxLiteratureTypeId, //作文类型Id
Checker = objvzx_CompositionENS.Checker, //审核人
PaperTitle = objvzx_CompositionENS.PaperTitle, //论文标题
PaperName = objvzx_CompositionENS.PaperName, //主题名称
PaperContent = objvzx_CompositionENS.PaperContent, //主题内容
Periodical = objvzx_CompositionENS.Periodical, //期刊
Author = objvzx_CompositionENS.Author, //作者
ResearchQuestion = objvzx_CompositionENS.ResearchQuestion, //研究问题
UpdDate = objvzx_CompositionENS.UpdDate, //修改日期
Memo = objvzx_CompositionENS.Memo, //备注
Keyword = objvzx_CompositionENS.Keyword, //关键字
LiteratureSources = objvzx_CompositionENS.LiteratureSources, //文献来源
LiteratureLink = objvzx_CompositionENS.LiteratureLink, //文献链接
UploadfileUrl = objvzx_CompositionENS.UploadfileUrl, //文件地址
IsQuotethesis = objvzx_CompositionENS.IsQuotethesis, //是否引用论文
QuoteId = objvzx_CompositionENS.QuoteId, //引用Id
IsChecked = objvzx_CompositionENS.IsChecked, //是否检查
};
 return objvzx_CompositionENT;
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
public static void CheckProperty4Condition(this clsvzx_CompositionEN objvzx_CompositionEN)
{
 clsvzx_CompositionBL.vzx_CompositionDA.CheckProperty4Condition(objvzx_CompositionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_CompositionEN objvzx_CompositionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.zxPaperId) == true)
{
string strComparisonOpzxPaperId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.zxPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.zxPaperId, objvzx_CompositionCond.zxPaperId, strComparisonOpzxPaperId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.LiteratureTypeName) == true)
{
string strComparisonOpLiteratureTypeName = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.LiteratureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.LiteratureTypeName, objvzx_CompositionCond.LiteratureTypeName, strComparisonOpLiteratureTypeName);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.CurrEduClsId, objvzx_CompositionCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.EduClsName) == true)
{
string strComparisonOpEduClsName = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.EduClsName, objvzx_CompositionCond.EduClsName, strComparisonOpEduClsName);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.GroupTextId, objvzx_CompositionCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.TeaQCount, objvzx_CompositionCond.TeaQCount, strComparisonOpTeaQCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.TagsCount) == true)
{
string strComparisonOpTagsCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.TagsCount, objvzx_CompositionCond.TagsCount, strComparisonOpTagsCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.SubVCount) == true)
{
string strComparisonOpSubVCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.SubVCount, objvzx_CompositionCond.SubVCount, strComparisonOpSubVCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.PaperQCount, objvzx_CompositionCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.zxShareId, objvzx_CompositionCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.CreateDate, objvzx_CompositionCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.ExpectedConclusion) == true)
{
string strComparisonOpExpectedConclusion = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.ExpectedConclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.ExpectedConclusion, objvzx_CompositionCond.ExpectedConclusion, strComparisonOpExpectedConclusion);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.DimensionDataProcess) == true)
{
string strComparisonOpDimensionDataProcess = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.DimensionDataProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.DimensionDataProcess, objvzx_CompositionCond.DimensionDataProcess, strComparisonOpDimensionDataProcess);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.InnovationPoints) == true)
{
string strComparisonOpInnovationPoints = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.InnovationPoints];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.InnovationPoints, objvzx_CompositionCond.InnovationPoints, strComparisonOpInnovationPoints);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.ResearchStatus) == true)
{
string strComparisonOpResearchStatus = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.ResearchStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.ResearchStatus, objvzx_CompositionCond.ResearchStatus, strComparisonOpResearchStatus);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.IsPublic) == true)
{
if (objvzx_CompositionCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Composition.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Composition.IsPublic);
}
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.UpdUser, objvzx_CompositionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.ResearchDesign) == true)
{
string strComparisonOpResearchDesign = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.ResearchDesign];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.ResearchDesign, objvzx_CompositionCond.ResearchDesign, strComparisonOpResearchDesign);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.VersionCount, objvzx_CompositionCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.AskQuestion) == true)
{
string strComparisonOpAskQuestion = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.AskQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.AskQuestion, objvzx_CompositionCond.AskQuestion, strComparisonOpAskQuestion);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.zxPaperStatusId) == true)
{
string strComparisonOpzxPaperStatusId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.zxPaperStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.zxPaperStatusId, objvzx_CompositionCond.zxPaperStatusId, strComparisonOpzxPaperStatusId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.PaperTypeId, objvzx_CompositionCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.IdCurrEduCls, objvzx_CompositionCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.TeaScore, objvzx_CompositionCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.StuScore, objvzx_CompositionCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.Score) == true)
{
string strComparisonOpScore = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.Score, objvzx_CompositionCond.Score, strComparisonOpScore);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.Pcount) == true)
{
string strComparisonOpPcount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.Pcount, objvzx_CompositionCond.Pcount, strComparisonOpPcount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.OkCount) == true)
{
string strComparisonOpOkCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.OkCount, objvzx_CompositionCond.OkCount, strComparisonOpOkCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.DownloadCount, objvzx_CompositionCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.CollectionCount, objvzx_CompositionCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.AttachmentCount, objvzx_CompositionCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.AppraiseCount, objvzx_CompositionCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.IsSubmit) == true)
{
if (objvzx_CompositionCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Composition.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Composition.IsSubmit);
}
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Composition.BrowseNumber, objvzx_CompositionCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.zxLiteratureTypeId) == true)
{
string strComparisonOpzxLiteratureTypeId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.zxLiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.zxLiteratureTypeId, objvzx_CompositionCond.zxLiteratureTypeId, strComparisonOpzxLiteratureTypeId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.Checker) == true)
{
string strComparisonOpChecker = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.Checker, objvzx_CompositionCond.Checker, strComparisonOpChecker);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.PaperTitle, objvzx_CompositionCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.PaperName) == true)
{
string strComparisonOpPaperName = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.PaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.PaperName, objvzx_CompositionCond.PaperName, strComparisonOpPaperName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.Periodical) == true)
{
string strComparisonOpPeriodical = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.Periodical, objvzx_CompositionCond.Periodical, strComparisonOpPeriodical);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.Author) == true)
{
string strComparisonOpAuthor = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.Author, objvzx_CompositionCond.Author, strComparisonOpAuthor);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.ResearchQuestion, objvzx_CompositionCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.UpdDate, objvzx_CompositionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.Memo) == true)
{
string strComparisonOpMemo = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.Memo, objvzx_CompositionCond.Memo, strComparisonOpMemo);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.Keyword) == true)
{
string strComparisonOpKeyword = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.Keyword, objvzx_CompositionCond.Keyword, strComparisonOpKeyword);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.LiteratureSources, objvzx_CompositionCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.LiteratureLink, objvzx_CompositionCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.UploadfileUrl, objvzx_CompositionCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.IsQuotethesis) == true)
{
if (objvzx_CompositionCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Composition.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Composition.IsQuotethesis);
}
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.QuoteId) == true)
{
string strComparisonOpQuoteId = objvzx_CompositionCond.dicFldComparisonOp[convzx_Composition.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Composition.QuoteId, objvzx_CompositionCond.QuoteId, strComparisonOpQuoteId);
}
if (objvzx_CompositionCond.IsUpdated(convzx_Composition.IsChecked) == true)
{
if (objvzx_CompositionCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Composition.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Composition.IsChecked);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Composition
{
public virtual bool UpdRelaTabDate(string strzxPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Composition(vzx_Composition)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_CompositionBL
{
public static RelatedActions_vzx_Composition relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_CompositionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_CompositionDA vzx_CompositionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_CompositionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_CompositionBL()
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
if (string.IsNullOrEmpty(clsvzx_CompositionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_CompositionEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Composition(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_CompositionDA.GetDataTable_vzx_Composition(strWhereCond);
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
objDT = vzx_CompositionDA.GetDataTable(strWhereCond);
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
objDT = vzx_CompositionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_CompositionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_CompositionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_CompositionDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_CompositionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_CompositionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_CompositionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_CompositionEN> GetObjLstByZxPaperIdLst(List<string> arrZxPaperIdLst)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxPaperIdLst, true);
 string strWhereCond = string.Format("zxPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_CompositionEN> GetObjLstByZxPaperIdLstCache(List<string> arrZxPaperIdLst)
{
string strKey = string.Format("{0}", clsvzx_CompositionEN._CurrTabName);
List<clsvzx_CompositionEN> arrvzx_CompositionObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_CompositionEN> arrvzx_CompositionObjLst_Sel =
arrvzx_CompositionObjLstCache
.Where(x => arrZxPaperIdLst.Contains(x.zxPaperId));
return arrvzx_CompositionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_CompositionEN> GetObjLst(string strWhereCond)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
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
public static List<clsvzx_CompositionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_CompositionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_CompositionEN> GetSubObjLstCache(clsvzx_CompositionEN objvzx_CompositionCond)
{
List<clsvzx_CompositionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_CompositionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Composition.AttributeName)
{
if (objvzx_CompositionCond.IsUpdated(strFldName) == false) continue;
if (objvzx_CompositionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_CompositionCond[strFldName].ToString());
}
else
{
if (objvzx_CompositionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_CompositionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_CompositionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_CompositionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_CompositionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_CompositionCond[strFldName]));
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
public static List<clsvzx_CompositionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
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
public static List<clsvzx_CompositionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
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
List<clsvzx_CompositionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_CompositionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_CompositionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_CompositionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
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
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
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
public static List<clsvzx_CompositionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_CompositionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_CompositionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
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
public static List<clsvzx_CompositionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_CompositionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_CompositionEN.zxPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_CompositionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Composition(ref clsvzx_CompositionEN objvzx_CompositionEN)
{
bool bolResult = vzx_CompositionDA.Getvzx_Composition(ref objvzx_CompositionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_CompositionEN GetObjByzxPaperId(string strzxPaperId)
{
if (strzxPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_CompositionEN objvzx_CompositionEN = vzx_CompositionDA.GetObjByzxPaperId(strzxPaperId);
return objvzx_CompositionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_CompositionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_CompositionEN objvzx_CompositionEN = vzx_CompositionDA.GetFirstObj(strWhereCond);
 return objvzx_CompositionEN;
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
public static clsvzx_CompositionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_CompositionEN objvzx_CompositionEN = vzx_CompositionDA.GetObjByDataRow(objRow);
 return objvzx_CompositionEN;
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
public static clsvzx_CompositionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_CompositionEN objvzx_CompositionEN = vzx_CompositionDA.GetObjByDataRow(objRow);
 return objvzx_CompositionEN;
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
 /// <param name = "strzxPaperId">所给的关键字</param>
 /// <param name = "lstvzx_CompositionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_CompositionEN GetObjByzxPaperIdFromList(string strzxPaperId, List<clsvzx_CompositionEN> lstvzx_CompositionObjLst)
{
foreach (clsvzx_CompositionEN objvzx_CompositionEN in lstvzx_CompositionObjLst)
{
if (objvzx_CompositionEN.zxPaperId == strzxPaperId)
{
return objvzx_CompositionEN;
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
 string strMaxZxPaperId;
 try
 {
 strMaxZxPaperId = clsvzx_CompositionDA.GetMaxStrId();
 return strMaxZxPaperId;
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
 string strzxPaperId;
 try
 {
 strzxPaperId = new clsvzx_CompositionDA().GetFirstID(strWhereCond);
 return strzxPaperId;
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
 arrList = vzx_CompositionDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_CompositionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxPaperId)
{
if (string.IsNullOrEmpty(strzxPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_CompositionDA.IsExist(strzxPaperId);
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
 bolIsExist = clsvzx_CompositionDA.IsExistTable();
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
 bolIsExist = vzx_CompositionDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_CompositionENS">源对象</param>
 /// <param name = "objvzx_CompositionENT">目标对象</param>
 public static void CopyTo(clsvzx_CompositionEN objvzx_CompositionENS, clsvzx_CompositionEN objvzx_CompositionENT)
{
try
{
objvzx_CompositionENT.zxPaperId = objvzx_CompositionENS.zxPaperId; //论文Id
objvzx_CompositionENT.LiteratureTypeName = objvzx_CompositionENS.LiteratureTypeName; //作文类型名
objvzx_CompositionENT.CurrEduClsId = objvzx_CompositionENS.CurrEduClsId; //教学班Id
objvzx_CompositionENT.EduClsName = objvzx_CompositionENS.EduClsName; //教学班名
objvzx_CompositionENT.GroupTextId = objvzx_CompositionENS.GroupTextId; //小组Id
objvzx_CompositionENT.TeaQCount = objvzx_CompositionENS.TeaQCount; //教师提问数
objvzx_CompositionENT.TagsCount = objvzx_CompositionENS.TagsCount; //论文标注数
objvzx_CompositionENT.SubVCount = objvzx_CompositionENS.SubVCount; //论文子观点数
objvzx_CompositionENT.PaperQCount = objvzx_CompositionENS.PaperQCount; //论文答疑数
objvzx_CompositionENT.zxShareId = objvzx_CompositionENS.zxShareId; //分享Id
objvzx_CompositionENT.CreateDate = objvzx_CompositionENS.CreateDate; //建立日期
objvzx_CompositionENT.ExpectedConclusion = objvzx_CompositionENS.ExpectedConclusion; //预期结论
objvzx_CompositionENT.DimensionDataProcess = objvzx_CompositionENS.DimensionDataProcess; //数据处理的维度
objvzx_CompositionENT.InnovationPoints = objvzx_CompositionENS.InnovationPoints; //创新点
objvzx_CompositionENT.ResearchStatus = objvzx_CompositionENS.ResearchStatus; //目前研究的现状
objvzx_CompositionENT.IsPublic = objvzx_CompositionENS.IsPublic; //是否公开
objvzx_CompositionENT.UpdUser = objvzx_CompositionENS.UpdUser; //修改人
objvzx_CompositionENT.ResearchDesign = objvzx_CompositionENS.ResearchDesign; //研究设计
objvzx_CompositionENT.VersionCount = objvzx_CompositionENS.VersionCount; //版本统计
objvzx_CompositionENT.AskQuestion = objvzx_CompositionENS.AskQuestion; //问题提出
objvzx_CompositionENT.zxPaperStatusId = objvzx_CompositionENS.zxPaperStatusId; //论文状态Id
objvzx_CompositionENT.PaperTypeId = objvzx_CompositionENS.PaperTypeId; //论文类型Id
objvzx_CompositionENT.IdCurrEduCls = objvzx_CompositionENS.IdCurrEduCls; //教学班流水号
objvzx_CompositionENT.TeaScore = objvzx_CompositionENS.TeaScore; //教师评分
objvzx_CompositionENT.StuScore = objvzx_CompositionENS.StuScore; //学生平均分
objvzx_CompositionENT.Score = objvzx_CompositionENS.Score; //评分
objvzx_CompositionENT.Pcount = objvzx_CompositionENS.Pcount; //读写数
objvzx_CompositionENT.OkCount = objvzx_CompositionENS.OkCount; //点赞统计
objvzx_CompositionENT.DownloadCount = objvzx_CompositionENS.DownloadCount; //下载数
objvzx_CompositionENT.CollectionCount = objvzx_CompositionENS.CollectionCount; //收藏数量
objvzx_CompositionENT.AttachmentCount = objvzx_CompositionENS.AttachmentCount; //附件计数
objvzx_CompositionENT.AppraiseCount = objvzx_CompositionENS.AppraiseCount; //评论数
objvzx_CompositionENT.IsSubmit = objvzx_CompositionENS.IsSubmit; //是否提交
objvzx_CompositionENT.BrowseNumber = objvzx_CompositionENS.BrowseNumber; //浏览量
objvzx_CompositionENT.zxLiteratureTypeId = objvzx_CompositionENS.zxLiteratureTypeId; //作文类型Id
objvzx_CompositionENT.Checker = objvzx_CompositionENS.Checker; //审核人
objvzx_CompositionENT.PaperTitle = objvzx_CompositionENS.PaperTitle; //论文标题
objvzx_CompositionENT.PaperName = objvzx_CompositionENS.PaperName; //主题名称
objvzx_CompositionENT.PaperContent = objvzx_CompositionENS.PaperContent; //主题内容
objvzx_CompositionENT.Periodical = objvzx_CompositionENS.Periodical; //期刊
objvzx_CompositionENT.Author = objvzx_CompositionENS.Author; //作者
objvzx_CompositionENT.ResearchQuestion = objvzx_CompositionENS.ResearchQuestion; //研究问题
objvzx_CompositionENT.UpdDate = objvzx_CompositionENS.UpdDate; //修改日期
objvzx_CompositionENT.Memo = objvzx_CompositionENS.Memo; //备注
objvzx_CompositionENT.Keyword = objvzx_CompositionENS.Keyword; //关键字
objvzx_CompositionENT.LiteratureSources = objvzx_CompositionENS.LiteratureSources; //文献来源
objvzx_CompositionENT.LiteratureLink = objvzx_CompositionENS.LiteratureLink; //文献链接
objvzx_CompositionENT.UploadfileUrl = objvzx_CompositionENS.UploadfileUrl; //文件地址
objvzx_CompositionENT.IsQuotethesis = objvzx_CompositionENS.IsQuotethesis; //是否引用论文
objvzx_CompositionENT.QuoteId = objvzx_CompositionENS.QuoteId; //引用Id
objvzx_CompositionENT.IsChecked = objvzx_CompositionENS.IsChecked; //是否检查
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
 /// <param name = "objvzx_CompositionEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_CompositionEN objvzx_CompositionEN)
{
try
{
objvzx_CompositionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_CompositionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Composition.zxPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.zxPaperId = objvzx_CompositionEN.zxPaperId; //论文Id
}
if (arrFldSet.Contains(convzx_Composition.LiteratureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.LiteratureTypeName = objvzx_CompositionEN.LiteratureTypeName == "[null]" ? null :  objvzx_CompositionEN.LiteratureTypeName; //作文类型名
}
if (arrFldSet.Contains(convzx_Composition.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.CurrEduClsId = objvzx_CompositionEN.CurrEduClsId == "[null]" ? null :  objvzx_CompositionEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convzx_Composition.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.EduClsName = objvzx_CompositionEN.EduClsName == "[null]" ? null :  objvzx_CompositionEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convzx_Composition.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.GroupTextId = objvzx_CompositionEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_Composition.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.TeaQCount = objvzx_CompositionEN.TeaQCount; //教师提问数
}
if (arrFldSet.Contains(convzx_Composition.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.TagsCount = objvzx_CompositionEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convzx_Composition.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.SubVCount = objvzx_CompositionEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convzx_Composition.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.PaperQCount = objvzx_CompositionEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(convzx_Composition.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.zxShareId = objvzx_CompositionEN.zxShareId == "[null]" ? null :  objvzx_CompositionEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_Composition.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.CreateDate = objvzx_CompositionEN.CreateDate == "[null]" ? null :  objvzx_CompositionEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_Composition.ExpectedConclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.ExpectedConclusion = objvzx_CompositionEN.ExpectedConclusion == "[null]" ? null :  objvzx_CompositionEN.ExpectedConclusion; //预期结论
}
if (arrFldSet.Contains(convzx_Composition.DimensionDataProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.DimensionDataProcess = objvzx_CompositionEN.DimensionDataProcess == "[null]" ? null :  objvzx_CompositionEN.DimensionDataProcess; //数据处理的维度
}
if (arrFldSet.Contains(convzx_Composition.InnovationPoints, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.InnovationPoints = objvzx_CompositionEN.InnovationPoints == "[null]" ? null :  objvzx_CompositionEN.InnovationPoints; //创新点
}
if (arrFldSet.Contains(convzx_Composition.ResearchStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.ResearchStatus = objvzx_CompositionEN.ResearchStatus == "[null]" ? null :  objvzx_CompositionEN.ResearchStatus; //目前研究的现状
}
if (arrFldSet.Contains(convzx_Composition.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.IsPublic = objvzx_CompositionEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_Composition.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.UpdUser = objvzx_CompositionEN.UpdUser == "[null]" ? null :  objvzx_CompositionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Composition.ResearchDesign, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.ResearchDesign = objvzx_CompositionEN.ResearchDesign == "[null]" ? null :  objvzx_CompositionEN.ResearchDesign; //研究设计
}
if (arrFldSet.Contains(convzx_Composition.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.VersionCount = objvzx_CompositionEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_Composition.AskQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.AskQuestion = objvzx_CompositionEN.AskQuestion == "[null]" ? null :  objvzx_CompositionEN.AskQuestion; //问题提出
}
if (arrFldSet.Contains(convzx_Composition.zxPaperStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.zxPaperStatusId = objvzx_CompositionEN.zxPaperStatusId == "[null]" ? null :  objvzx_CompositionEN.zxPaperStatusId; //论文状态Id
}
if (arrFldSet.Contains(convzx_Composition.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.PaperTypeId = objvzx_CompositionEN.PaperTypeId == "[null]" ? null :  objvzx_CompositionEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convzx_Composition.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.IdCurrEduCls = objvzx_CompositionEN.IdCurrEduCls == "[null]" ? null :  objvzx_CompositionEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_Composition.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.TeaScore = objvzx_CompositionEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_Composition.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.StuScore = objvzx_CompositionEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_Composition.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.Score = objvzx_CompositionEN.Score; //评分
}
if (arrFldSet.Contains(convzx_Composition.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.Pcount = objvzx_CompositionEN.Pcount; //读写数
}
if (arrFldSet.Contains(convzx_Composition.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.OkCount = objvzx_CompositionEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convzx_Composition.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.DownloadCount = objvzx_CompositionEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convzx_Composition.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.CollectionCount = objvzx_CompositionEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convzx_Composition.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.AttachmentCount = objvzx_CompositionEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convzx_Composition.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.AppraiseCount = objvzx_CompositionEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_Composition.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.IsSubmit = objvzx_CompositionEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_Composition.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.BrowseNumber = objvzx_CompositionEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convzx_Composition.zxLiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.zxLiteratureTypeId = objvzx_CompositionEN.zxLiteratureTypeId; //作文类型Id
}
if (arrFldSet.Contains(convzx_Composition.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.Checker = objvzx_CompositionEN.Checker == "[null]" ? null :  objvzx_CompositionEN.Checker; //审核人
}
if (arrFldSet.Contains(convzx_Composition.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.PaperTitle = objvzx_CompositionEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convzx_Composition.PaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.PaperName = objvzx_CompositionEN.PaperName == "[null]" ? null :  objvzx_CompositionEN.PaperName; //主题名称
}
if (arrFldSet.Contains(convzx_Composition.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.PaperContent = objvzx_CompositionEN.PaperContent == "[null]" ? null :  objvzx_CompositionEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convzx_Composition.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.Periodical = objvzx_CompositionEN.Periodical == "[null]" ? null :  objvzx_CompositionEN.Periodical; //期刊
}
if (arrFldSet.Contains(convzx_Composition.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.Author = objvzx_CompositionEN.Author == "[null]" ? null :  objvzx_CompositionEN.Author; //作者
}
if (arrFldSet.Contains(convzx_Composition.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.ResearchQuestion = objvzx_CompositionEN.ResearchQuestion == "[null]" ? null :  objvzx_CompositionEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convzx_Composition.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.UpdDate = objvzx_CompositionEN.UpdDate == "[null]" ? null :  objvzx_CompositionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Composition.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.Memo = objvzx_CompositionEN.Memo == "[null]" ? null :  objvzx_CompositionEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Composition.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.Keyword = objvzx_CompositionEN.Keyword == "[null]" ? null :  objvzx_CompositionEN.Keyword; //关键字
}
if (arrFldSet.Contains(convzx_Composition.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.LiteratureSources = objvzx_CompositionEN.LiteratureSources == "[null]" ? null :  objvzx_CompositionEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convzx_Composition.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.LiteratureLink = objvzx_CompositionEN.LiteratureLink == "[null]" ? null :  objvzx_CompositionEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convzx_Composition.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.UploadfileUrl = objvzx_CompositionEN.UploadfileUrl == "[null]" ? null :  objvzx_CompositionEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convzx_Composition.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.IsQuotethesis = objvzx_CompositionEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(convzx_Composition.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.QuoteId = objvzx_CompositionEN.QuoteId == "[null]" ? null :  objvzx_CompositionEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(convzx_Composition.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_CompositionEN.IsChecked = objvzx_CompositionEN.IsChecked; //是否检查
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
 /// <param name = "objvzx_CompositionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_CompositionEN objvzx_CompositionEN)
{
try
{
if (objvzx_CompositionEN.LiteratureTypeName == "[null]") objvzx_CompositionEN.LiteratureTypeName = null; //作文类型名
if (objvzx_CompositionEN.CurrEduClsId == "[null]") objvzx_CompositionEN.CurrEduClsId = null; //教学班Id
if (objvzx_CompositionEN.EduClsName == "[null]") objvzx_CompositionEN.EduClsName = null; //教学班名
if (objvzx_CompositionEN.zxShareId == "[null]") objvzx_CompositionEN.zxShareId = null; //分享Id
if (objvzx_CompositionEN.CreateDate == "[null]") objvzx_CompositionEN.CreateDate = null; //建立日期
if (objvzx_CompositionEN.ExpectedConclusion == "[null]") objvzx_CompositionEN.ExpectedConclusion = null; //预期结论
if (objvzx_CompositionEN.DimensionDataProcess == "[null]") objvzx_CompositionEN.DimensionDataProcess = null; //数据处理的维度
if (objvzx_CompositionEN.InnovationPoints == "[null]") objvzx_CompositionEN.InnovationPoints = null; //创新点
if (objvzx_CompositionEN.ResearchStatus == "[null]") objvzx_CompositionEN.ResearchStatus = null; //目前研究的现状
if (objvzx_CompositionEN.UpdUser == "[null]") objvzx_CompositionEN.UpdUser = null; //修改人
if (objvzx_CompositionEN.ResearchDesign == "[null]") objvzx_CompositionEN.ResearchDesign = null; //研究设计
if (objvzx_CompositionEN.AskQuestion == "[null]") objvzx_CompositionEN.AskQuestion = null; //问题提出
if (objvzx_CompositionEN.zxPaperStatusId == "[null]") objvzx_CompositionEN.zxPaperStatusId = null; //论文状态Id
if (objvzx_CompositionEN.PaperTypeId == "[null]") objvzx_CompositionEN.PaperTypeId = null; //论文类型Id
if (objvzx_CompositionEN.IdCurrEduCls == "[null]") objvzx_CompositionEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_CompositionEN.Checker == "[null]") objvzx_CompositionEN.Checker = null; //审核人
if (objvzx_CompositionEN.PaperName == "[null]") objvzx_CompositionEN.PaperName = null; //主题名称
if (objvzx_CompositionEN.PaperContent == "[null]") objvzx_CompositionEN.PaperContent = null; //主题内容
if (objvzx_CompositionEN.Periodical == "[null]") objvzx_CompositionEN.Periodical = null; //期刊
if (objvzx_CompositionEN.Author == "[null]") objvzx_CompositionEN.Author = null; //作者
if (objvzx_CompositionEN.ResearchQuestion == "[null]") objvzx_CompositionEN.ResearchQuestion = null; //研究问题
if (objvzx_CompositionEN.UpdDate == "[null]") objvzx_CompositionEN.UpdDate = null; //修改日期
if (objvzx_CompositionEN.Memo == "[null]") objvzx_CompositionEN.Memo = null; //备注
if (objvzx_CompositionEN.Keyword == "[null]") objvzx_CompositionEN.Keyword = null; //关键字
if (objvzx_CompositionEN.LiteratureSources == "[null]") objvzx_CompositionEN.LiteratureSources = null; //文献来源
if (objvzx_CompositionEN.LiteratureLink == "[null]") objvzx_CompositionEN.LiteratureLink = null; //文献链接
if (objvzx_CompositionEN.UploadfileUrl == "[null]") objvzx_CompositionEN.UploadfileUrl = null; //文件地址
if (objvzx_CompositionEN.QuoteId == "[null]") objvzx_CompositionEN.QuoteId = null; //引用Id
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
public static void CheckProperty4Condition(clsvzx_CompositionEN objvzx_CompositionEN)
{
 vzx_CompositionDA.CheckProperty4Condition(objvzx_CompositionEN);
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
if (clszx_CompositionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_CompositionBL没有刷新缓存机制(clszx_CompositionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_LiteratureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_LiteratureTypeBL没有刷新缓存机制(clszx_LiteratureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxPaperId");
//if (arrvzx_CompositionObjLstCache == null)
//{
//arrvzx_CompositionObjLstCache = vzx_CompositionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_CompositionEN GetObjByzxPaperIdCache(string strzxPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_CompositionEN._CurrTabName);
List<clsvzx_CompositionEN> arrvzx_CompositionObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_CompositionEN> arrvzx_CompositionObjLst_Sel =
arrvzx_CompositionObjLstCache
.Where(x=> x.zxPaperId == strzxPaperId 
);
if (arrvzx_CompositionObjLst_Sel.Count() == 0)
{
   clsvzx_CompositionEN obj = clsvzx_CompositionBL.GetObjByzxPaperId(strzxPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_CompositionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_CompositionEN> GetAllvzx_CompositionObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_CompositionEN> arrvzx_CompositionObjLstCache = GetObjLstCache(); 
return arrvzx_CompositionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_CompositionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_CompositionEN._CurrTabName);
List<clsvzx_CompositionEN> arrvzx_CompositionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_CompositionObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_CompositionEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxPaperId)
{
if (strInFldName != convzx_Composition.zxPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Composition.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Composition.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Composition = clsvzx_CompositionBL.GetObjByzxPaperIdCache(strzxPaperId);
if (objvzx_Composition == null) return "";
return objvzx_Composition[strOutFldName].ToString();
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
int intRecCount = clsvzx_CompositionDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_CompositionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_CompositionDA.GetRecCount();
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
int intRecCount = clsvzx_CompositionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_CompositionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_CompositionEN objvzx_CompositionCond)
{
List<clsvzx_CompositionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_CompositionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Composition.AttributeName)
{
if (objvzx_CompositionCond.IsUpdated(strFldName) == false) continue;
if (objvzx_CompositionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_CompositionCond[strFldName].ToString());
}
else
{
if (objvzx_CompositionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_CompositionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_CompositionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_CompositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_CompositionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_CompositionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_CompositionCond[strFldName]));
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
 List<string> arrList = clsvzx_CompositionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_CompositionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_CompositionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}