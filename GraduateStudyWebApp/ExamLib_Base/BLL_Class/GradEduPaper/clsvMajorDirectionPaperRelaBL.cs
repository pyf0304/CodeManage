
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorDirectionPaperRelaBL
 表名:vMajorDirectionPaperRela(01120555)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsvMajorDirectionPaperRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMajorDirectionPaperRelaEN GetObj(this K_mId_vMajorDirectionPaperRela myKey)
{
clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = clsvMajorDirectionPaperRelaBL.vMajorDirectionPaperRelaDA.GetObjBymId(myKey.Value);
return objvMajorDirectionPaperRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetmId(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, long lngmId, string strComparisonOp="")
	{
objvMajorDirectionPaperRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.mId) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.mId, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.mId] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetMajorDirectionId(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strMajorDirectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionId, 8, convMajorDirectionPaperRela.MajorDirectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorDirectionId, 8, convMajorDirectionPaperRela.MajorDirectionId);
}
objvMajorDirectionPaperRelaEN.MajorDirectionId = strMajorDirectionId; //研究方向Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.MajorDirectionId) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.MajorDirectionId, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionId] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetPaperId(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convMajorDirectionPaperRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convMajorDirectionPaperRela.PaperId);
}
objvMajorDirectionPaperRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.PaperId) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.PaperId, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.PaperId] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetUpdDate(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMajorDirectionPaperRela.UpdDate);
}
objvMajorDirectionPaperRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.UpdDate) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.UpdDate, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.UpdDate] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetUpdUser(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convMajorDirectionPaperRela.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMajorDirectionPaperRela.UpdUser);
}
objvMajorDirectionPaperRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.UpdUser) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.UpdUser, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.UpdUser] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetMemo(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMajorDirectionPaperRela.Memo);
}
objvMajorDirectionPaperRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.Memo) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.Memo, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.Memo] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetIdXzMajor(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convMajorDirectionPaperRela.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convMajorDirectionPaperRela.IdXzMajor);
}
objvMajorDirectionPaperRelaEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.IdXzMajor) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.IdXzMajor, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.IdXzMajor] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetMajorDirectionENName(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strMajorDirectionENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionENName, 200, convMajorDirectionPaperRela.MajorDirectionENName);
}
objvMajorDirectionPaperRelaEN.MajorDirectionENName = strMajorDirectionENName; //研究方向英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.MajorDirectionENName) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.MajorDirectionENName, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionENName] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetMajorDirectionName(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strMajorDirectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionName, 100, convMajorDirectionPaperRela.MajorDirectionName);
}
objvMajorDirectionPaperRelaEN.MajorDirectionName = strMajorDirectionName; //研究方向名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.MajorDirectionName) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.MajorDirectionName, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionName] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetMajorDirectionExplain(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strMajorDirectionExplain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionExplain, 2000, convMajorDirectionPaperRela.MajorDirectionExplain);
}
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = strMajorDirectionExplain; //专业方向说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.MajorDirectionExplain) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.MajorDirectionExplain, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionExplain] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetIsVisible(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objvMajorDirectionPaperRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.IsVisible) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.IsVisible, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.IsVisible] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetPaperTitle(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convMajorDirectionPaperRela.PaperTitle);
}
objvMajorDirectionPaperRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.PaperTitle) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.PaperTitle, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.PaperTitle] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetPaperContent(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strPaperContent, string strComparisonOp="")
	{
objvMajorDirectionPaperRelaEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.PaperContent) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.PaperContent, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.PaperContent] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetPeriodical(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convMajorDirectionPaperRela.Periodical);
}
objvMajorDirectionPaperRelaEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.Periodical) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.Periodical, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.Periodical] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetAuthor(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convMajorDirectionPaperRela.Author);
}
objvMajorDirectionPaperRelaEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.Author) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.Author, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.Author] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetResearchQuestion(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convMajorDirectionPaperRela.ResearchQuestion);
}
objvMajorDirectionPaperRelaEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.ResearchQuestion) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.ResearchQuestion, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.ResearchQuestion] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetKeyword(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convMajorDirectionPaperRela.Keyword);
}
objvMajorDirectionPaperRelaEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.Keyword) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.Keyword, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.Keyword] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetLiteratureSources(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convMajorDirectionPaperRela.LiteratureSources);
}
objvMajorDirectionPaperRelaEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.LiteratureSources) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.LiteratureSources, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.LiteratureSources] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetLiteratureLink(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convMajorDirectionPaperRela.LiteratureLink);
}
objvMajorDirectionPaperRelaEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.LiteratureLink) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.LiteratureLink, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.LiteratureLink] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetUploadfileUrl(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convMajorDirectionPaperRela.UploadfileUrl);
}
objvMajorDirectionPaperRelaEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.UploadfileUrl) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.UploadfileUrl, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.UploadfileUrl] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetIsQuotethesis(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objvMajorDirectionPaperRelaEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.IsQuotethesis) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.IsQuotethesis, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.IsQuotethesis] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetChecker(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, convMajorDirectionPaperRela.Checker);
}
objvMajorDirectionPaperRelaEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.Checker) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.Checker, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.Checker] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetIsChecked(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, bool bolIsChecked, string strComparisonOp="")
	{
objvMajorDirectionPaperRelaEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.IsChecked) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.IsChecked, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.IsChecked] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetMajorID(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convMajorDirectionPaperRela.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convMajorDirectionPaperRela.MajorID);
}
objvMajorDirectionPaperRelaEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.MajorID) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.MajorID, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.MajorID] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetMajorName(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convMajorDirectionPaperRela.MajorName);
}
objvMajorDirectionPaperRelaEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.MajorName) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.MajorName, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.MajorName] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorDirectionPaperRelaEN SetUserName(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convMajorDirectionPaperRela.UserName);
}
objvMajorDirectionPaperRelaEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorDirectionPaperRelaEN.dicFldComparisonOp.ContainsKey(convMajorDirectionPaperRela.UserName) == false)
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp.Add(convMajorDirectionPaperRela.UserName, strComparisonOp);
}
else
{
objvMajorDirectionPaperRelaEN.dicFldComparisonOp[convMajorDirectionPaperRela.UserName] = strComparisonOp;
}
}
return objvMajorDirectionPaperRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaENS">源对象</param>
 /// <param name = "objvMajorDirectionPaperRelaENT">目标对象</param>
 public static void CopyTo(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENS, clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENT)
{
try
{
objvMajorDirectionPaperRelaENT.mId = objvMajorDirectionPaperRelaENS.mId; //mId
objvMajorDirectionPaperRelaENT.MajorDirectionId = objvMajorDirectionPaperRelaENS.MajorDirectionId; //研究方向Id
objvMajorDirectionPaperRelaENT.PaperId = objvMajorDirectionPaperRelaENS.PaperId; //论文Id
objvMajorDirectionPaperRelaENT.UpdDate = objvMajorDirectionPaperRelaENS.UpdDate; //修改日期
objvMajorDirectionPaperRelaENT.UpdUser = objvMajorDirectionPaperRelaENS.UpdUser; //修改人
objvMajorDirectionPaperRelaENT.Memo = objvMajorDirectionPaperRelaENS.Memo; //备注
objvMajorDirectionPaperRelaENT.IdXzMajor = objvMajorDirectionPaperRelaENS.IdXzMajor; //专业流水号
objvMajorDirectionPaperRelaENT.MajorDirectionENName = objvMajorDirectionPaperRelaENS.MajorDirectionENName; //研究方向英文名
objvMajorDirectionPaperRelaENT.MajorDirectionName = objvMajorDirectionPaperRelaENS.MajorDirectionName; //研究方向名
objvMajorDirectionPaperRelaENT.MajorDirectionExplain = objvMajorDirectionPaperRelaENS.MajorDirectionExplain; //专业方向说明
objvMajorDirectionPaperRelaENT.IsVisible = objvMajorDirectionPaperRelaENS.IsVisible; //是否显示
objvMajorDirectionPaperRelaENT.PaperTitle = objvMajorDirectionPaperRelaENS.PaperTitle; //论文标题
objvMajorDirectionPaperRelaENT.PaperContent = objvMajorDirectionPaperRelaENS.PaperContent; //主题内容
objvMajorDirectionPaperRelaENT.Periodical = objvMajorDirectionPaperRelaENS.Periodical; //期刊
objvMajorDirectionPaperRelaENT.Author = objvMajorDirectionPaperRelaENS.Author; //作者
objvMajorDirectionPaperRelaENT.ResearchQuestion = objvMajorDirectionPaperRelaENS.ResearchQuestion; //研究问题
objvMajorDirectionPaperRelaENT.Keyword = objvMajorDirectionPaperRelaENS.Keyword; //关键字
objvMajorDirectionPaperRelaENT.LiteratureSources = objvMajorDirectionPaperRelaENS.LiteratureSources; //文献来源
objvMajorDirectionPaperRelaENT.LiteratureLink = objvMajorDirectionPaperRelaENS.LiteratureLink; //文献链接
objvMajorDirectionPaperRelaENT.UploadfileUrl = objvMajorDirectionPaperRelaENS.UploadfileUrl; //文件地址
objvMajorDirectionPaperRelaENT.IsQuotethesis = objvMajorDirectionPaperRelaENS.IsQuotethesis; //是否引用论文
objvMajorDirectionPaperRelaENT.Checker = objvMajorDirectionPaperRelaENS.Checker; //审核人
objvMajorDirectionPaperRelaENT.IsChecked = objvMajorDirectionPaperRelaENS.IsChecked; //是否检查
objvMajorDirectionPaperRelaENT.MajorID = objvMajorDirectionPaperRelaENS.MajorID; //专业ID
objvMajorDirectionPaperRelaENT.MajorName = objvMajorDirectionPaperRelaENS.MajorName; //专业名称
objvMajorDirectionPaperRelaENT.UserName = objvMajorDirectionPaperRelaENS.UserName; //用户名
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
 /// <param name = "objvMajorDirectionPaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvMajorDirectionPaperRelaEN:objvMajorDirectionPaperRelaENT</returns>
 public static clsvMajorDirectionPaperRelaEN CopyTo(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENS)
{
try
{
 clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENT = new clsvMajorDirectionPaperRelaEN()
{
mId = objvMajorDirectionPaperRelaENS.mId, //mId
MajorDirectionId = objvMajorDirectionPaperRelaENS.MajorDirectionId, //研究方向Id
PaperId = objvMajorDirectionPaperRelaENS.PaperId, //论文Id
UpdDate = objvMajorDirectionPaperRelaENS.UpdDate, //修改日期
UpdUser = objvMajorDirectionPaperRelaENS.UpdUser, //修改人
Memo = objvMajorDirectionPaperRelaENS.Memo, //备注
IdXzMajor = objvMajorDirectionPaperRelaENS.IdXzMajor, //专业流水号
MajorDirectionENName = objvMajorDirectionPaperRelaENS.MajorDirectionENName, //研究方向英文名
MajorDirectionName = objvMajorDirectionPaperRelaENS.MajorDirectionName, //研究方向名
MajorDirectionExplain = objvMajorDirectionPaperRelaENS.MajorDirectionExplain, //专业方向说明
IsVisible = objvMajorDirectionPaperRelaENS.IsVisible, //是否显示
PaperTitle = objvMajorDirectionPaperRelaENS.PaperTitle, //论文标题
PaperContent = objvMajorDirectionPaperRelaENS.PaperContent, //主题内容
Periodical = objvMajorDirectionPaperRelaENS.Periodical, //期刊
Author = objvMajorDirectionPaperRelaENS.Author, //作者
ResearchQuestion = objvMajorDirectionPaperRelaENS.ResearchQuestion, //研究问题
Keyword = objvMajorDirectionPaperRelaENS.Keyword, //关键字
LiteratureSources = objvMajorDirectionPaperRelaENS.LiteratureSources, //文献来源
LiteratureLink = objvMajorDirectionPaperRelaENS.LiteratureLink, //文献链接
UploadfileUrl = objvMajorDirectionPaperRelaENS.UploadfileUrl, //文件地址
IsQuotethesis = objvMajorDirectionPaperRelaENS.IsQuotethesis, //是否引用论文
Checker = objvMajorDirectionPaperRelaENS.Checker, //审核人
IsChecked = objvMajorDirectionPaperRelaENS.IsChecked, //是否检查
MajorID = objvMajorDirectionPaperRelaENS.MajorID, //专业ID
MajorName = objvMajorDirectionPaperRelaENS.MajorName, //专业名称
UserName = objvMajorDirectionPaperRelaENS.UserName, //用户名
};
 return objvMajorDirectionPaperRelaENT;
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
public static void CheckProperty4Condition(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN)
{
 clsvMajorDirectionPaperRelaBL.vMajorDirectionPaperRelaDA.CheckProperty4Condition(objvMajorDirectionPaperRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.mId) == true)
{
string strComparisonOpmId = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convMajorDirectionPaperRela.mId, objvMajorDirectionPaperRelaCond.mId, strComparisonOpmId);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.MajorDirectionId) == true)
{
string strComparisonOpMajorDirectionId = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.MajorDirectionId, objvMajorDirectionPaperRelaCond.MajorDirectionId, strComparisonOpMajorDirectionId);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.PaperId) == true)
{
string strComparisonOpPaperId = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.PaperId, objvMajorDirectionPaperRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.UpdDate, objvMajorDirectionPaperRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.UpdUser, objvMajorDirectionPaperRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.Memo) == true)
{
string strComparisonOpMemo = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.Memo, objvMajorDirectionPaperRelaCond.Memo, strComparisonOpMemo);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.IdXzMajor, objvMajorDirectionPaperRelaCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.MajorDirectionENName) == true)
{
string strComparisonOpMajorDirectionENName = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.MajorDirectionENName, objvMajorDirectionPaperRelaCond.MajorDirectionENName, strComparisonOpMajorDirectionENName);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.MajorDirectionName) == true)
{
string strComparisonOpMajorDirectionName = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.MajorDirectionName, objvMajorDirectionPaperRelaCond.MajorDirectionName, strComparisonOpMajorDirectionName);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.MajorDirectionExplain) == true)
{
string strComparisonOpMajorDirectionExplain = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.MajorDirectionExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.MajorDirectionExplain, objvMajorDirectionPaperRelaCond.MajorDirectionExplain, strComparisonOpMajorDirectionExplain);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.IsVisible) == true)
{
if (objvMajorDirectionPaperRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMajorDirectionPaperRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMajorDirectionPaperRela.IsVisible);
}
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.PaperTitle, objvMajorDirectionPaperRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.Periodical) == true)
{
string strComparisonOpPeriodical = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.Periodical, objvMajorDirectionPaperRelaCond.Periodical, strComparisonOpPeriodical);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.Author) == true)
{
string strComparisonOpAuthor = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.Author, objvMajorDirectionPaperRelaCond.Author, strComparisonOpAuthor);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.ResearchQuestion, objvMajorDirectionPaperRelaCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.Keyword) == true)
{
string strComparisonOpKeyword = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.Keyword, objvMajorDirectionPaperRelaCond.Keyword, strComparisonOpKeyword);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.LiteratureSources, objvMajorDirectionPaperRelaCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.LiteratureLink, objvMajorDirectionPaperRelaCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.UploadfileUrl, objvMajorDirectionPaperRelaCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.IsQuotethesis) == true)
{
if (objvMajorDirectionPaperRelaCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMajorDirectionPaperRela.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMajorDirectionPaperRela.IsQuotethesis);
}
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.Checker) == true)
{
string strComparisonOpChecker = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.Checker, objvMajorDirectionPaperRelaCond.Checker, strComparisonOpChecker);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.IsChecked) == true)
{
if (objvMajorDirectionPaperRelaCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMajorDirectionPaperRela.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMajorDirectionPaperRela.IsChecked);
}
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.MajorID) == true)
{
string strComparisonOpMajorID = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.MajorID, objvMajorDirectionPaperRelaCond.MajorID, strComparisonOpMajorID);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.MajorName) == true)
{
string strComparisonOpMajorName = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.MajorName, objvMajorDirectionPaperRelaCond.MajorName, strComparisonOpMajorName);
}
if (objvMajorDirectionPaperRelaCond.IsUpdated(convMajorDirectionPaperRela.UserName) == true)
{
string strComparisonOpUserName = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[convMajorDirectionPaperRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorDirectionPaperRela.UserName, objvMajorDirectionPaperRelaCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMajorDirectionPaperRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v专业方向论文关系(vMajorDirectionPaperRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMajorDirectionPaperRelaBL
{
public static RelatedActions_vMajorDirectionPaperRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMajorDirectionPaperRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMajorDirectionPaperRelaDA vMajorDirectionPaperRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMajorDirectionPaperRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMajorDirectionPaperRelaBL()
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
if (string.IsNullOrEmpty(clsvMajorDirectionPaperRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMajorDirectionPaperRelaEN._ConnectString);
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
public static DataTable GetDataTable_vMajorDirectionPaperRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMajorDirectionPaperRelaDA.GetDataTable_vMajorDirectionPaperRela(strWhereCond);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTable(strWhereCond);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMajorDirectionPaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
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
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMajorDirectionPaperRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvMajorDirectionPaperRelaEN._CurrTabName);
List<clsvMajorDirectionPaperRelaEN> arrvMajorDirectionPaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorDirectionPaperRelaEN> arrvMajorDirectionPaperRelaObjLst_Sel =
arrvMajorDirectionPaperRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvMajorDirectionPaperRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorDirectionPaperRelaEN> GetObjLst(string strWhereCond)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
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
public static List<clsvMajorDirectionPaperRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMajorDirectionPaperRelaEN> GetSubObjLstCache(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaCond)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorDirectionPaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMajorDirectionPaperRela.AttributeName)
{
if (objvMajorDirectionPaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvMajorDirectionPaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorDirectionPaperRelaCond[strFldName].ToString());
}
else
{
if (objvMajorDirectionPaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorDirectionPaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMajorDirectionPaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMajorDirectionPaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMajorDirectionPaperRelaCond[strFldName]));
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
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
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
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
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
List<clsvMajorDirectionPaperRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMajorDirectionPaperRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorDirectionPaperRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMajorDirectionPaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
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
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
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
public static List<clsvMajorDirectionPaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
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
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorDirectionPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMajorDirectionPaperRela(ref clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN)
{
bool bolResult = vMajorDirectionPaperRelaDA.GetvMajorDirectionPaperRela(ref objvMajorDirectionPaperRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMajorDirectionPaperRelaEN GetObjBymId(long lngmId)
{
clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = vMajorDirectionPaperRelaDA.GetObjBymId(lngmId);
return objvMajorDirectionPaperRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMajorDirectionPaperRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = vMajorDirectionPaperRelaDA.GetFirstObj(strWhereCond);
 return objvMajorDirectionPaperRelaEN;
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
public static clsvMajorDirectionPaperRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = vMajorDirectionPaperRelaDA.GetObjByDataRow(objRow);
 return objvMajorDirectionPaperRelaEN;
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
public static clsvMajorDirectionPaperRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = vMajorDirectionPaperRelaDA.GetObjByDataRow(objRow);
 return objvMajorDirectionPaperRelaEN;
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
 /// <param name = "lstvMajorDirectionPaperRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMajorDirectionPaperRelaEN GetObjBymIdFromList(long lngmId, List<clsvMajorDirectionPaperRelaEN> lstvMajorDirectionPaperRelaObjLst)
{
foreach (clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN in lstvMajorDirectionPaperRelaObjLst)
{
if (objvMajorDirectionPaperRelaEN.mId == lngmId)
{
return objvMajorDirectionPaperRelaEN;
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
 lngmId = new clsvMajorDirectionPaperRelaDA().GetFirstID(strWhereCond);
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
 arrList = vMajorDirectionPaperRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vMajorDirectionPaperRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vMajorDirectionPaperRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvMajorDirectionPaperRelaDA.IsExistTable();
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
 bolIsExist = vMajorDirectionPaperRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvMajorDirectionPaperRelaENS">源对象</param>
 /// <param name = "objvMajorDirectionPaperRelaENT">目标对象</param>
 public static void CopyTo(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENS, clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENT)
{
try
{
objvMajorDirectionPaperRelaENT.mId = objvMajorDirectionPaperRelaENS.mId; //mId
objvMajorDirectionPaperRelaENT.MajorDirectionId = objvMajorDirectionPaperRelaENS.MajorDirectionId; //研究方向Id
objvMajorDirectionPaperRelaENT.PaperId = objvMajorDirectionPaperRelaENS.PaperId; //论文Id
objvMajorDirectionPaperRelaENT.UpdDate = objvMajorDirectionPaperRelaENS.UpdDate; //修改日期
objvMajorDirectionPaperRelaENT.UpdUser = objvMajorDirectionPaperRelaENS.UpdUser; //修改人
objvMajorDirectionPaperRelaENT.Memo = objvMajorDirectionPaperRelaENS.Memo; //备注
objvMajorDirectionPaperRelaENT.IdXzMajor = objvMajorDirectionPaperRelaENS.IdXzMajor; //专业流水号
objvMajorDirectionPaperRelaENT.MajorDirectionENName = objvMajorDirectionPaperRelaENS.MajorDirectionENName; //研究方向英文名
objvMajorDirectionPaperRelaENT.MajorDirectionName = objvMajorDirectionPaperRelaENS.MajorDirectionName; //研究方向名
objvMajorDirectionPaperRelaENT.MajorDirectionExplain = objvMajorDirectionPaperRelaENS.MajorDirectionExplain; //专业方向说明
objvMajorDirectionPaperRelaENT.IsVisible = objvMajorDirectionPaperRelaENS.IsVisible; //是否显示
objvMajorDirectionPaperRelaENT.PaperTitle = objvMajorDirectionPaperRelaENS.PaperTitle; //论文标题
objvMajorDirectionPaperRelaENT.PaperContent = objvMajorDirectionPaperRelaENS.PaperContent; //主题内容
objvMajorDirectionPaperRelaENT.Periodical = objvMajorDirectionPaperRelaENS.Periodical; //期刊
objvMajorDirectionPaperRelaENT.Author = objvMajorDirectionPaperRelaENS.Author; //作者
objvMajorDirectionPaperRelaENT.ResearchQuestion = objvMajorDirectionPaperRelaENS.ResearchQuestion; //研究问题
objvMajorDirectionPaperRelaENT.Keyword = objvMajorDirectionPaperRelaENS.Keyword; //关键字
objvMajorDirectionPaperRelaENT.LiteratureSources = objvMajorDirectionPaperRelaENS.LiteratureSources; //文献来源
objvMajorDirectionPaperRelaENT.LiteratureLink = objvMajorDirectionPaperRelaENS.LiteratureLink; //文献链接
objvMajorDirectionPaperRelaENT.UploadfileUrl = objvMajorDirectionPaperRelaENS.UploadfileUrl; //文件地址
objvMajorDirectionPaperRelaENT.IsQuotethesis = objvMajorDirectionPaperRelaENS.IsQuotethesis; //是否引用论文
objvMajorDirectionPaperRelaENT.Checker = objvMajorDirectionPaperRelaENS.Checker; //审核人
objvMajorDirectionPaperRelaENT.IsChecked = objvMajorDirectionPaperRelaENS.IsChecked; //是否检查
objvMajorDirectionPaperRelaENT.MajorID = objvMajorDirectionPaperRelaENS.MajorID; //专业ID
objvMajorDirectionPaperRelaENT.MajorName = objvMajorDirectionPaperRelaENS.MajorName; //专业名称
objvMajorDirectionPaperRelaENT.UserName = objvMajorDirectionPaperRelaENS.UserName; //用户名
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
 /// <param name = "objvMajorDirectionPaperRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN)
{
try
{
objvMajorDirectionPaperRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMajorDirectionPaperRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMajorDirectionPaperRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.mId = objvMajorDirectionPaperRelaEN.mId; //mId
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.MajorDirectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.MajorDirectionId = objvMajorDirectionPaperRelaEN.MajorDirectionId == "[null]" ? null :  objvMajorDirectionPaperRelaEN.MajorDirectionId; //研究方向Id
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.PaperId = objvMajorDirectionPaperRelaEN.PaperId == "[null]" ? null :  objvMajorDirectionPaperRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.UpdDate = objvMajorDirectionPaperRelaEN.UpdDate == "[null]" ? null :  objvMajorDirectionPaperRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.UpdUser = objvMajorDirectionPaperRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.Memo = objvMajorDirectionPaperRelaEN.Memo == "[null]" ? null :  objvMajorDirectionPaperRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.IdXzMajor = objvMajorDirectionPaperRelaEN.IdXzMajor == "[null]" ? null :  objvMajorDirectionPaperRelaEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.MajorDirectionENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objvMajorDirectionPaperRelaEN.MajorDirectionENName == "[null]" ? null :  objvMajorDirectionPaperRelaEN.MajorDirectionENName; //研究方向英文名
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.MajorDirectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.MajorDirectionName = objvMajorDirectionPaperRelaEN.MajorDirectionName == "[null]" ? null :  objvMajorDirectionPaperRelaEN.MajorDirectionName; //研究方向名
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.MajorDirectionExplain, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objvMajorDirectionPaperRelaEN.MajorDirectionExplain == "[null]" ? null :  objvMajorDirectionPaperRelaEN.MajorDirectionExplain; //专业方向说明
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.IsVisible = objvMajorDirectionPaperRelaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.PaperTitle = objvMajorDirectionPaperRelaEN.PaperTitle == "[null]" ? null :  objvMajorDirectionPaperRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.PaperContent = objvMajorDirectionPaperRelaEN.PaperContent == "[null]" ? null :  objvMajorDirectionPaperRelaEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.Periodical = objvMajorDirectionPaperRelaEN.Periodical == "[null]" ? null :  objvMajorDirectionPaperRelaEN.Periodical; //期刊
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.Author = objvMajorDirectionPaperRelaEN.Author == "[null]" ? null :  objvMajorDirectionPaperRelaEN.Author; //作者
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.ResearchQuestion = objvMajorDirectionPaperRelaEN.ResearchQuestion == "[null]" ? null :  objvMajorDirectionPaperRelaEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.Keyword = objvMajorDirectionPaperRelaEN.Keyword == "[null]" ? null :  objvMajorDirectionPaperRelaEN.Keyword; //关键字
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.LiteratureSources = objvMajorDirectionPaperRelaEN.LiteratureSources == "[null]" ? null :  objvMajorDirectionPaperRelaEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.LiteratureLink = objvMajorDirectionPaperRelaEN.LiteratureLink == "[null]" ? null :  objvMajorDirectionPaperRelaEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.UploadfileUrl = objvMajorDirectionPaperRelaEN.UploadfileUrl == "[null]" ? null :  objvMajorDirectionPaperRelaEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.IsQuotethesis = objvMajorDirectionPaperRelaEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.Checker = objvMajorDirectionPaperRelaEN.Checker == "[null]" ? null :  objvMajorDirectionPaperRelaEN.Checker; //审核人
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.IsChecked = objvMajorDirectionPaperRelaEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.MajorID = objvMajorDirectionPaperRelaEN.MajorID == "[null]" ? null :  objvMajorDirectionPaperRelaEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.MajorName = objvMajorDirectionPaperRelaEN.MajorName == "[null]" ? null :  objvMajorDirectionPaperRelaEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convMajorDirectionPaperRela.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorDirectionPaperRelaEN.UserName = objvMajorDirectionPaperRelaEN.UserName == "[null]" ? null :  objvMajorDirectionPaperRelaEN.UserName; //用户名
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
 /// <param name = "objvMajorDirectionPaperRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN)
{
try
{
if (objvMajorDirectionPaperRelaEN.MajorDirectionId == "[null]") objvMajorDirectionPaperRelaEN.MajorDirectionId = null; //研究方向Id
if (objvMajorDirectionPaperRelaEN.PaperId == "[null]") objvMajorDirectionPaperRelaEN.PaperId = null; //论文Id
if (objvMajorDirectionPaperRelaEN.UpdDate == "[null]") objvMajorDirectionPaperRelaEN.UpdDate = null; //修改日期
if (objvMajorDirectionPaperRelaEN.Memo == "[null]") objvMajorDirectionPaperRelaEN.Memo = null; //备注
if (objvMajorDirectionPaperRelaEN.IdXzMajor == "[null]") objvMajorDirectionPaperRelaEN.IdXzMajor = null; //专业流水号
if (objvMajorDirectionPaperRelaEN.MajorDirectionENName == "[null]") objvMajorDirectionPaperRelaEN.MajorDirectionENName = null; //研究方向英文名
if (objvMajorDirectionPaperRelaEN.MajorDirectionName == "[null]") objvMajorDirectionPaperRelaEN.MajorDirectionName = null; //研究方向名
if (objvMajorDirectionPaperRelaEN.MajorDirectionExplain == "[null]") objvMajorDirectionPaperRelaEN.MajorDirectionExplain = null; //专业方向说明
if (objvMajorDirectionPaperRelaEN.PaperTitle == "[null]") objvMajorDirectionPaperRelaEN.PaperTitle = null; //论文标题
if (objvMajorDirectionPaperRelaEN.PaperContent == "[null]") objvMajorDirectionPaperRelaEN.PaperContent = null; //主题内容
if (objvMajorDirectionPaperRelaEN.Periodical == "[null]") objvMajorDirectionPaperRelaEN.Periodical = null; //期刊
if (objvMajorDirectionPaperRelaEN.Author == "[null]") objvMajorDirectionPaperRelaEN.Author = null; //作者
if (objvMajorDirectionPaperRelaEN.ResearchQuestion == "[null]") objvMajorDirectionPaperRelaEN.ResearchQuestion = null; //研究问题
if (objvMajorDirectionPaperRelaEN.Keyword == "[null]") objvMajorDirectionPaperRelaEN.Keyword = null; //关键字
if (objvMajorDirectionPaperRelaEN.LiteratureSources == "[null]") objvMajorDirectionPaperRelaEN.LiteratureSources = null; //文献来源
if (objvMajorDirectionPaperRelaEN.LiteratureLink == "[null]") objvMajorDirectionPaperRelaEN.LiteratureLink = null; //文献链接
if (objvMajorDirectionPaperRelaEN.UploadfileUrl == "[null]") objvMajorDirectionPaperRelaEN.UploadfileUrl = null; //文件地址
if (objvMajorDirectionPaperRelaEN.Checker == "[null]") objvMajorDirectionPaperRelaEN.Checker = null; //审核人
if (objvMajorDirectionPaperRelaEN.MajorID == "[null]") objvMajorDirectionPaperRelaEN.MajorID = null; //专业ID
if (objvMajorDirectionPaperRelaEN.MajorName == "[null]") objvMajorDirectionPaperRelaEN.MajorName = null; //专业名称
if (objvMajorDirectionPaperRelaEN.UserName == "[null]") objvMajorDirectionPaperRelaEN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN)
{
 vMajorDirectionPaperRelaDA.CheckProperty4Condition(objvMajorDirectionPaperRelaEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMajorDirectionPaperRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMajorDirectionPaperRelaBL没有刷新缓存机制(clsMajorDirectionPaperRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorDirectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorDirectionBL没有刷新缓存机制(clsXzMajorDirectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvMajorDirectionPaperRelaObjLstCache == null)
//{
//arrvMajorDirectionPaperRelaObjLstCache = vMajorDirectionPaperRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMajorDirectionPaperRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMajorDirectionPaperRelaEN._CurrTabName);
List<clsvMajorDirectionPaperRelaEN> arrvMajorDirectionPaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorDirectionPaperRelaEN> arrvMajorDirectionPaperRelaObjLst_Sel =
arrvMajorDirectionPaperRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvMajorDirectionPaperRelaObjLst_Sel.Count() == 0)
{
   clsvMajorDirectionPaperRelaEN obj = clsvMajorDirectionPaperRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMajorDirectionPaperRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMajorDirectionPaperRelaEN> GetAllvMajorDirectionPaperRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvMajorDirectionPaperRelaEN> arrvMajorDirectionPaperRelaObjLstCache = GetObjLstCache(); 
return arrvMajorDirectionPaperRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMajorDirectionPaperRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMajorDirectionPaperRelaEN._CurrTabName);
List<clsvMajorDirectionPaperRelaEN> arrvMajorDirectionPaperRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMajorDirectionPaperRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvMajorDirectionPaperRelaEN._CurrTabName);
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
if (strInFldName != convMajorDirectionPaperRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMajorDirectionPaperRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMajorDirectionPaperRela.AttributeName));
throw new Exception(strMsg);
}
var objvMajorDirectionPaperRela = clsvMajorDirectionPaperRelaBL.GetObjBymIdCache(lngmId);
if (objvMajorDirectionPaperRela == null) return "";
return objvMajorDirectionPaperRela[strOutFldName].ToString();
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
int intRecCount = clsvMajorDirectionPaperRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvMajorDirectionPaperRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMajorDirectionPaperRelaDA.GetRecCount();
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
int intRecCount = clsvMajorDirectionPaperRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaCond)
{
List<clsvMajorDirectionPaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorDirectionPaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMajorDirectionPaperRela.AttributeName)
{
if (objvMajorDirectionPaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvMajorDirectionPaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorDirectionPaperRelaCond[strFldName].ToString());
}
else
{
if (objvMajorDirectionPaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMajorDirectionPaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorDirectionPaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMajorDirectionPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMajorDirectionPaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMajorDirectionPaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMajorDirectionPaperRelaCond[strFldName]));
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
 List<string> arrList = clsvMajorDirectionPaperRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMajorDirectionPaperRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMajorDirectionPaperRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}