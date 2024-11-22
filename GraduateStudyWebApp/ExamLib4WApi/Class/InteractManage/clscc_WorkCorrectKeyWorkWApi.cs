
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkCorrectKeyWorkWApi
 表名:cc_WorkCorrectKeyWork(01120190)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:52
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clscc_WorkCorrectKeyWorkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetId_WorkCorrectKeyWork(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, long lngId_WorkCorrectKeyWork, string strComparisonOp="")
	{
objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork = lngId_WorkCorrectKeyWork; //作业批改关键词流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetQuestionID(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_WorkCorrectKeyWork.QuestionID);
objcc_WorkCorrectKeyWorkEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.QuestionID) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.QuestionID, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.QuestionID] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetKeyWorkIndex(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, int intKeyWorkIndex, string strComparisonOp="")
	{
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = intKeyWorkIndex; //关键字序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.KeyWorkIndex) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.KeyWorkIndex, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.KeyWorkIndex] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetCorrectKeyWork(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCorrectKeyWork, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCorrectKeyWork, concc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckFieldLen(strCorrectKeyWork, 200, concc_WorkCorrectKeyWork.CorrectKeyWork);
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = strCorrectKeyWork; //批改关键词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.CorrectKeyWork) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.CorrectKeyWork, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.CorrectKeyWork] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetIsUseFormatPara(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, bool bolIsUseFormatPara, string strComparisonOp="")
	{
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = bolIsUseFormatPara; //是否使用格式化参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.IsUseFormatPara) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.IsUseFormatPara, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.IsUseFormatPara] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetFormatPara(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strFormatPara, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFormatPara, 100, concc_WorkCorrectKeyWork.FormatPara);
objcc_WorkCorrectKeyWorkEN.FormatPara = strFormatPara; //格式化参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.FormatPara) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.FormatPara, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.FormatPara] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetInOutTypeId(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, concc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, concc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, concc_WorkCorrectKeyWork.InOutTypeId);
objcc_WorkCorrectKeyWorkEN.InOutTypeId = strInOutTypeId; //InOut类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.InOutTypeId) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.InOutTypeId, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.InOutTypeId] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetCreator(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, concc_WorkCorrectKeyWork.Creator);
objcc_WorkCorrectKeyWorkEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.Creator) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.Creator, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.Creator] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetCreateDate(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_WorkCorrectKeyWork.CreateDate);
objcc_WorkCorrectKeyWorkEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.CreateDate) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.CreateDate, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.CreateDate] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetIsEnable(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, bool bolIsEnable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsEnable, concc_WorkCorrectKeyWork.IsEnable);
objcc_WorkCorrectKeyWorkEN.IsEnable = bolIsEnable; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.IsEnable) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.IsEnable, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.IsEnable] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetUpdDate(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkCorrectKeyWork.UpdDate);
objcc_WorkCorrectKeyWorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.UpdDate) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.UpdDate, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdDate] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetUpdUser(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, concc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_WorkCorrectKeyWork.UpdUser);
objcc_WorkCorrectKeyWorkEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.UpdUser) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.UpdUser, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdUser] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkCorrectKeyWorkEN SetMemo(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkCorrectKeyWork.Memo);
objcc_WorkCorrectKeyWorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.ContainsKey(concc_WorkCorrectKeyWork.Memo) == false)
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp.Add(concc_WorkCorrectKeyWork.Memo, strComparisonOp);
}
else
{
objcc_WorkCorrectKeyWorkEN.dicFldComparisonOp[concc_WorkCorrectKeyWork.Memo] = strComparisonOp;
}
}
return objcc_WorkCorrectKeyWorkEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWork_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork) == true)
{
string strComparisonOp_Id_WorkCorrectKeyWork = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork, objcc_WorkCorrectKeyWork_Cond.Id_WorkCorrectKeyWork, strComparisonOp_Id_WorkCorrectKeyWork);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.QuestionID, objcc_WorkCorrectKeyWork_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.KeyWorkIndex) == true)
{
string strComparisonOp_KeyWorkIndex = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.KeyWorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkCorrectKeyWork.KeyWorkIndex, objcc_WorkCorrectKeyWork_Cond.KeyWorkIndex, strComparisonOp_KeyWorkIndex);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.CorrectKeyWork) == true)
{
string strComparisonOp_CorrectKeyWork = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.CorrectKeyWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.CorrectKeyWork, objcc_WorkCorrectKeyWork_Cond.CorrectKeyWork, strComparisonOp_CorrectKeyWork);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.IsUseFormatPara) == true)
{
if (objcc_WorkCorrectKeyWork_Cond.IsUseFormatPara == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkCorrectKeyWork.IsUseFormatPara);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkCorrectKeyWork.IsUseFormatPara);
}
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.FormatPara) == true)
{
string strComparisonOp_FormatPara = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.FormatPara];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.FormatPara, objcc_WorkCorrectKeyWork_Cond.FormatPara, strComparisonOp_FormatPara);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.InOutTypeId) == true)
{
string strComparisonOp_InOutTypeId = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.InOutTypeId, objcc_WorkCorrectKeyWork_Cond.InOutTypeId, strComparisonOp_InOutTypeId);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.Creator) == true)
{
string strComparisonOp_Creator = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.Creator, objcc_WorkCorrectKeyWork_Cond.Creator, strComparisonOp_Creator);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.CreateDate) == true)
{
string strComparisonOp_CreateDate = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.CreateDate, objcc_WorkCorrectKeyWork_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.IsEnable) == true)
{
if (objcc_WorkCorrectKeyWork_Cond.IsEnable == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkCorrectKeyWork.IsEnable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkCorrectKeyWork.IsEnable);
}
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.UpdDate, objcc_WorkCorrectKeyWork_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.UpdUser) == true)
{
string strComparisonOp_UpdUser = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.UpdUser, objcc_WorkCorrectKeyWork_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objcc_WorkCorrectKeyWork_Cond.IsUpdated(concc_WorkCorrectKeyWork.Memo) == true)
{
string strComparisonOp_Memo = objcc_WorkCorrectKeyWork_Cond.dicFldComparisonOp[concc_WorkCorrectKeyWork.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkCorrectKeyWork.Memo, objcc_WorkCorrectKeyWork_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 if (objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_WorkCorrectKeyWorkEN.sf_UpdFldSetStr = objcc_WorkCorrectKeyWorkEN.getsf_UpdFldSetStr();
clscc_WorkCorrectKeyWorkWApi.CheckPropertyNew(objcc_WorkCorrectKeyWorkEN); 
bool bolResult = clscc_WorkCorrectKeyWorkWApi.UpdateRecord(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--cc_WorkCorrectKeyWork(作业批改关键词), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionID_CorrectKeyWork(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkCorrectKeyWorkEN == null) return "";
if (objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkCorrectKeyWorkEN.QuestionID);
 sbCondition.AppendFormat(" and CorrectKeyWork = '{0}'", objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_WorkCorrectKeyWork !=  {0}", objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkCorrectKeyWorkEN.QuestionID);
 sbCondition.AppendFormat(" and CorrectKeyWork = '{0}'", objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
try
{
clscc_WorkCorrectKeyWorkWApi.CheckPropertyNew(objcc_WorkCorrectKeyWorkEN); 
bool bolResult = clscc_WorkCorrectKeyWorkWApi.AddNewRecord(objcc_WorkCorrectKeyWorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strWhereCond)
{
try
{
clscc_WorkCorrectKeyWorkWApi.CheckPropertyNew(objcc_WorkCorrectKeyWorkEN); 
bool bolResult = clscc_WorkCorrectKeyWorkWApi.UpdateWithCondition(objcc_WorkCorrectKeyWorkEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkWApi.ReFreshCache();
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
 /// 作业批改关键词(cc_WorkCorrectKeyWork)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkCorrectKeyWorkWApi
{
private static readonly string mstrApiControllerName = "cc_WorkCorrectKeyWorkApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_WorkCorrectKeyWorkWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.QuestionID) && GetStrLen(objcc_WorkCorrectKeyWorkEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.CorrectKeyWork) && GetStrLen(objcc_WorkCorrectKeyWorkEN.CorrectKeyWork) > 200)
{
 throw new Exception("字段[批改关键词]的长度不能超过200!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.FormatPara) && GetStrLen(objcc_WorkCorrectKeyWorkEN.FormatPara) > 100)
{
 throw new Exception("字段[格式化参数]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.InOutTypeId) && GetStrLen(objcc_WorkCorrectKeyWorkEN.InOutTypeId) > 2)
{
 throw new Exception("字段[InOut类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.Creator) && GetStrLen(objcc_WorkCorrectKeyWorkEN.Creator) > 18)
{
 throw new Exception("字段[创建者]的长度不能超过18!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.CreateDate) && GetStrLen(objcc_WorkCorrectKeyWorkEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.UpdDate) && GetStrLen(objcc_WorkCorrectKeyWorkEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.UpdUser) && GetStrLen(objcc_WorkCorrectKeyWorkEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkCorrectKeyWorkEN.Memo) && GetStrLen(objcc_WorkCorrectKeyWorkEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_WorkCorrectKeyWorkEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetObjById_WorkCorrectKeyWork(long lngId_WorkCorrectKeyWork)
{
string strAction = "GetObjById_WorkCorrectKeyWork";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkCorrectKeyWork"] = lngId_WorkCorrectKeyWork.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkCorrectKeyWorkEN = JsonConvert.DeserializeObject<clscc_WorkCorrectKeyWorkEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkCorrectKeyWorkEN;
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
 /// <param name = "lngId_WorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetObjById_WorkCorrectKeyWork_WA_Cache(long lngId_WorkCorrectKeyWork)
{
string strAction = "GetObjById_WorkCorrectKeyWork_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkCorrectKeyWork"] = lngId_WorkCorrectKeyWork.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkCorrectKeyWorkEN = JsonConvert.DeserializeObject<clscc_WorkCorrectKeyWorkEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkCorrectKeyWorkEN;
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
public static clscc_WorkCorrectKeyWorkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = null;
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
objcc_WorkCorrectKeyWorkEN = JsonConvert.DeserializeObject<clscc_WorkCorrectKeyWorkEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkCorrectKeyWorkEN;
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
 /// <param name = "lngId_WorkCorrectKeyWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkCorrectKeyWorkEN GetObjById_WorkCorrectKeyWork_Cache(long lngId_WorkCorrectKeyWork)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName_S);
List<clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLst_Sel =
from objcc_WorkCorrectKeyWorkEN in arrcc_WorkCorrectKeyWorkObjLst_Cache
where objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork == lngId_WorkCorrectKeyWork
select objcc_WorkCorrectKeyWorkEN;
if (arrcc_WorkCorrectKeyWorkObjLst_Sel.Count() == 0)
{
   clscc_WorkCorrectKeyWorkEN obj = clscc_WorkCorrectKeyWorkWApi.GetObjById_WorkCorrectKeyWork(lngId_WorkCorrectKeyWork);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_WorkCorrectKeyWorkObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLst(string strWhereCond)
{
 List<clscc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstById_WorkCorrectKeyWorkLst(List<long> arrId_WorkCorrectKeyWork)
{
 List<clscc_WorkCorrectKeyWorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkCorrectKeyWorkLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkCorrectKeyWork);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkCorrectKeyWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_WorkCorrectKeyWorkEN> GetObjLstById_WorkCorrectKeyWorkLst_Cache(List<long> arrId_WorkCorrectKeyWork)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName_S);
List<clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLst_Sel =
from objcc_WorkCorrectKeyWorkEN in arrcc_WorkCorrectKeyWorkObjLst_Cache
where arrId_WorkCorrectKeyWork.Contains(objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork)
select objcc_WorkCorrectKeyWorkEN;
return arrcc_WorkCorrectKeyWorkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstById_WorkCorrectKeyWorkLst_WA_Cache(List<long> arrId_WorkCorrectKeyWork)
{
 List<clscc_WorkCorrectKeyWorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkCorrectKeyWorkLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkCorrectKeyWork);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_WorkCorrectKeyWorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkCorrectKeyWorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_WorkCorrectKeyWork)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = clscc_WorkCorrectKeyWorkWApi.GetObjById_WorkCorrectKeyWork(lngId_WorkCorrectKeyWork);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_WorkCorrectKeyWork.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkCorrectKeyWorkWApi.ReFreshCache();
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
public static int Delcc_WorkCorrectKeyWorks(List<string> arrId_WorkCorrectKeyWork)
{
string strAction = "Delcc_WorkCorrectKeyWorks";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkCorrectKeyWork);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkCorrectKeyWorkWApi.ReFreshCache();
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
public static int Delcc_WorkCorrectKeyWorksByCond(string strWhereCond)
{
string strAction = "Delcc_WorkCorrectKeyWorksByCond";
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
public static bool AddNewRecord(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkCorrectKeyWorkEN>(objcc_WorkCorrectKeyWorkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkCorrectKeyWorkEN>(objcc_WorkCorrectKeyWorkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkCorrectKeyWorkWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
if (string.IsNullOrEmpty(objcc_WorkCorrectKeyWorkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkCorrectKeyWorkEN>(objcc_WorkCorrectKeyWorkEN);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_WorkCorrectKeyWorkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkCorrectKeyWorkEN.Id_WorkCorrectKeyWork, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkCorrectKeyWorkEN>(objcc_WorkCorrectKeyWorkEN);
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
public static bool IsExist(long lngId_WorkCorrectKeyWork)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkCorrectKeyWork"] = lngId_WorkCorrectKeyWork.ToString()
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
 /// <param name = "objcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objcc_WorkCorrectKeyWorkENT">目标对象</param>
 public static void CopyTo(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENS, clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENT)
{
try
{
objcc_WorkCorrectKeyWorkENT.Id_WorkCorrectKeyWork = objcc_WorkCorrectKeyWorkENS.Id_WorkCorrectKeyWork; //作业批改关键词流水号
objcc_WorkCorrectKeyWorkENT.QuestionID = objcc_WorkCorrectKeyWorkENS.QuestionID; //题目ID
objcc_WorkCorrectKeyWorkENT.KeyWorkIndex = objcc_WorkCorrectKeyWorkENS.KeyWorkIndex; //关键字序号
objcc_WorkCorrectKeyWorkENT.CorrectKeyWork = objcc_WorkCorrectKeyWorkENS.CorrectKeyWork; //批改关键词
objcc_WorkCorrectKeyWorkENT.IsUseFormatPara = objcc_WorkCorrectKeyWorkENS.IsUseFormatPara; //是否使用格式化参数
objcc_WorkCorrectKeyWorkENT.FormatPara = objcc_WorkCorrectKeyWorkENS.FormatPara; //格式化参数
objcc_WorkCorrectKeyWorkENT.InOutTypeId = objcc_WorkCorrectKeyWorkENS.InOutTypeId; //InOut类型Id
objcc_WorkCorrectKeyWorkENT.Creator = objcc_WorkCorrectKeyWorkENS.Creator; //创建者
objcc_WorkCorrectKeyWorkENT.CreateDate = objcc_WorkCorrectKeyWorkENS.CreateDate; //建立日期
objcc_WorkCorrectKeyWorkENT.IsEnable = objcc_WorkCorrectKeyWorkENS.IsEnable; //是否启用
objcc_WorkCorrectKeyWorkENT.UpdDate = objcc_WorkCorrectKeyWorkENS.UpdDate; //修改日期
objcc_WorkCorrectKeyWorkENT.UpdUser = objcc_WorkCorrectKeyWorkENS.UpdUser; //修改人
objcc_WorkCorrectKeyWorkENT.Memo = objcc_WorkCorrectKeyWorkENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_WorkCorrectKeyWorkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_WorkCorrectKeyWorkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_WorkCorrectKeyWorkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_WorkCorrectKeyWorkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_WorkCorrectKeyWorkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_WorkCorrectKeyWorkEN.AttributeName)
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
if (clscc_WorkCorrectKeyWorkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkCorrectKeyWorkWApi没有刷新缓存机制(clscc_WorkCorrectKeyWorkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_WorkCorrectKeyWork");
//if (arrcc_WorkCorrectKeyWorkObjLst_Cache == null)
//{
//arrcc_WorkCorrectKeyWorkObjLst_Cache = await clscc_WorkCorrectKeyWorkWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName_S);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_WorkCorrectKeyWorkWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_WorkCorrectKeyWorkWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkCorrectKeyWorkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkCorrectKeyWorkEN._CurrTabName_S);
List<clscc_WorkCorrectKeyWorkEN> arrcc_WorkCorrectKeyWorkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkCorrectKeyWorkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_WorkCorrectKeyWorkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.KeyWorkIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.CorrectKeyWork, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.IsUseFormatPara, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.FormatPara, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.InOutTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.Creator, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.IsEnable, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkCorrectKeyWork.Memo, Type.GetType("System.String"));
foreach (clscc_WorkCorrectKeyWorkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork] = objInFor[concc_WorkCorrectKeyWork.Id_WorkCorrectKeyWork];
objDR[concc_WorkCorrectKeyWork.QuestionID] = objInFor[concc_WorkCorrectKeyWork.QuestionID];
objDR[concc_WorkCorrectKeyWork.KeyWorkIndex] = objInFor[concc_WorkCorrectKeyWork.KeyWorkIndex];
objDR[concc_WorkCorrectKeyWork.CorrectKeyWork] = objInFor[concc_WorkCorrectKeyWork.CorrectKeyWork];
objDR[concc_WorkCorrectKeyWork.IsUseFormatPara] = objInFor[concc_WorkCorrectKeyWork.IsUseFormatPara];
objDR[concc_WorkCorrectKeyWork.FormatPara] = objInFor[concc_WorkCorrectKeyWork.FormatPara];
objDR[concc_WorkCorrectKeyWork.InOutTypeId] = objInFor[concc_WorkCorrectKeyWork.InOutTypeId];
objDR[concc_WorkCorrectKeyWork.Creator] = objInFor[concc_WorkCorrectKeyWork.Creator];
objDR[concc_WorkCorrectKeyWork.CreateDate] = objInFor[concc_WorkCorrectKeyWork.CreateDate];
objDR[concc_WorkCorrectKeyWork.IsEnable] = objInFor[concc_WorkCorrectKeyWork.IsEnable];
objDR[concc_WorkCorrectKeyWork.UpdDate] = objInFor[concc_WorkCorrectKeyWork.UpdDate];
objDR[concc_WorkCorrectKeyWork.UpdUser] = objInFor[concc_WorkCorrectKeyWork.UpdUser];
objDR[concc_WorkCorrectKeyWork.Memo] = objInFor[concc_WorkCorrectKeyWork.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 作业批改关键词(cc_WorkCorrectKeyWork)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_WorkCorrectKeyWork : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clscc_WorkCorrectKeyWorkWApi.ReFreshThisCache();
clsvcc_WorkCorrectKeyWorkWApi.ReFreshThisCache();
}
}

}