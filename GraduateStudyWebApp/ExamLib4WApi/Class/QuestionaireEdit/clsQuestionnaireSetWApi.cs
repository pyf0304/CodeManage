
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireSetWApi
 表名:QuestionnaireSet(01120007)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsQuestionnaireSetWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetQuestionnaireSetId(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conQuestionnaireSet.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conQuestionnaireSet.QuestionnaireSetId);
objQuestionnaireSetEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.QuestionnaireSetId) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.QuestionnaireSetId, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetId] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetQuestionnaireSetName(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionnaireSetName, conQuestionnaireSet.QuestionnaireSetName);
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, conQuestionnaireSet.QuestionnaireSetName);
objQuestionnaireSetEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.QuestionnaireSetName) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.QuestionnaireSetName, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetName] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetOrderFieldInExport(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strOrderFieldInExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOrderFieldInExport, 200, conQuestionnaireSet.OrderFieldInExport);
objQuestionnaireSetEN.OrderFieldInExport = strOrderFieldInExport; //导出排序字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.OrderFieldInExport) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.OrderFieldInExport, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.OrderFieldInExport] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetClassNo(this clsQuestionnaireSetEN objQuestionnaireSetEN, int intClassNo, string strComparisonOp="")
	{
objQuestionnaireSetEN.ClassNo = intClassNo; //分类号1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.ClassNo) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.ClassNo, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.ClassNo] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetClassNo2(this clsQuestionnaireSetEN objQuestionnaireSetEN, int intClassNo2, string strComparisonOp="")
	{
objQuestionnaireSetEN.ClassNo2 = intClassNo2; //分类号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.ClassNo2) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.ClassNo2, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.ClassNo2] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetIsShowQuestionNo(this clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsShowQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsShowQuestionNo, conQuestionnaireSet.IsShowQuestionNo);
objQuestionnaireSetEN.IsShowQuestionNo = bolIsShowQuestionNo; //是否显示问题编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.IsShowQuestionNo) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.IsShowQuestionNo, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.IsShowQuestionNo] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetLogoFileName(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strLogoFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLogoFileName, 50, conQuestionnaireSet.LogoFileName);
objQuestionnaireSetEN.LogoFileName = strLogoFileName; //Logo文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.LogoFileName) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.LogoFileName, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.LogoFileName] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetUpdDate(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaireSet.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaireSet.UpdDate);
objQuestionnaireSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.UpdDate) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetUpdUser(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaireSet.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaireSet.UpdUser);
objQuestionnaireSetEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.UpdUser) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionnaireSetEN SetMemo(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaireSet.Memo);
objQuestionnaireSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.Memo) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.Memo, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.Memo] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireSetEN objQuestionnaireSet_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.QuestionnaireSetId, objQuestionnaireSet_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.QuestionnaireSetName) == true)
{
string strComparisonOp_QuestionnaireSetName = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.QuestionnaireSetName, objQuestionnaireSet_Cond.QuestionnaireSetName, strComparisonOp_QuestionnaireSetName);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.OrderFieldInExport) == true)
{
string strComparisonOp_OrderFieldInExport = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.OrderFieldInExport];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.OrderFieldInExport, objQuestionnaireSet_Cond.OrderFieldInExport, strComparisonOp_OrderFieldInExport);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.ClassNo) == true)
{
string strComparisonOp_ClassNo = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.ClassNo];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireSet.ClassNo, objQuestionnaireSet_Cond.ClassNo, strComparisonOp_ClassNo);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.ClassNo2) == true)
{
string strComparisonOp_ClassNo2 = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.ClassNo2];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireSet.ClassNo2, objQuestionnaireSet_Cond.ClassNo2, strComparisonOp_ClassNo2);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.IsShowQuestionNo) == true)
{
if (objQuestionnaireSet_Cond.IsShowQuestionNo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireSet.IsShowQuestionNo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireSet.IsShowQuestionNo);
}
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.LogoFileName) == true)
{
string strComparisonOp_LogoFileName = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.LogoFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.LogoFileName, objQuestionnaireSet_Cond.LogoFileName, strComparisonOp_LogoFileName);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.UpdDate, objQuestionnaireSet_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.UpdUser, objQuestionnaireSet_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQuestionnaireSet_Cond.IsUpdated(conQuestionnaireSet.Memo) == true)
{
string strComparisonOp_Memo = objQuestionnaireSet_Cond.dicFldComparisonOp[conQuestionnaireSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.Memo, objQuestionnaireSet_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionnaireSetEN.sf_UpdFldSetStr = objQuestionnaireSetEN.getsf_UpdFldSetStr();
clsQuestionnaireSetWApi.CheckPropertyNew(objQuestionnaireSetEN); 
bool bolResult = clsQuestionnaireSetWApi.UpdateRecord(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionnaireSetWApi.IsExist(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objQuestionnaireSetEN.QuestionnaireSetId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQuestionnaireSetWApi.CheckPropertyNew(objQuestionnaireSetEN); 
bool bolResult = clsQuestionnaireSetWApi.AddNewRecord(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetWApi.ReFreshCache();
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
try
{
clsQuestionnaireSetWApi.CheckPropertyNew(objQuestionnaireSetEN); 
string strQuestionnaireSetId = clsQuestionnaireSetWApi.AddNewRecordWithMaxId(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetWApi.ReFreshCache();
return strQuestionnaireSetId;
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
 /// <param name = "objQuestionnaireSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strWhereCond)
{
try
{
clsQuestionnaireSetWApi.CheckPropertyNew(objQuestionnaireSetEN); 
bool bolResult = clsQuestionnaireSetWApi.UpdateWithCondition(objQuestionnaireSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetWApi.ReFreshCache();
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
 /// 问卷集(QuestionnaireSet)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireSetWApi
{
private static readonly string mstrApiControllerName = "QuestionnaireSetApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsQuestionnaireSetWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionnaireSetId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[问卷集]...","0");
List<clsQuestionnaireSetEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionnaireSetId";
objDDL.DataTextField="QuestionnaireSetName";
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
public static void BindCbo_QuestionnaireSetId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionnaireSet.QuestionnaireSetId); 
List<clsQuestionnaireSetEN> arrObjLst = clsQuestionnaireSetWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN()
{
QuestionnaireSetId = "0",
QuestionnaireSetName = "选[问卷集]..."
};
arrObjLst.Insert(0, objQuestionnaireSetEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionnaireSet.QuestionnaireSetId;
objComboBox.DisplayMember = conQuestionnaireSet.QuestionnaireSetName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
if (!Object.Equals(null, objQuestionnaireSetEN.QuestionnaireSetId) && GetStrLen(objQuestionnaireSetEN.QuestionnaireSetId) > 4)
{
 throw new Exception("字段[问卷集ID]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionnaireSetEN.QuestionnaireSetName) && GetStrLen(objQuestionnaireSetEN.QuestionnaireSetName) > 50)
{
 throw new Exception("字段[问卷集名]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireSetEN.OrderFieldInExport) && GetStrLen(objQuestionnaireSetEN.OrderFieldInExport) > 200)
{
 throw new Exception("字段[导出排序字段]的长度不能超过200!");
}
if (!Object.Equals(null, objQuestionnaireSetEN.LogoFileName) && GetStrLen(objQuestionnaireSetEN.LogoFileName) > 50)
{
 throw new Exception("字段[Logo文件名]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionnaireSetEN.UpdDate) && GetStrLen(objQuestionnaireSetEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireSetEN.UpdUser) && GetStrLen(objQuestionnaireSetEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionnaireSetEN.Memo) && GetStrLen(objQuestionnaireSetEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQuestionnaireSetEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireSetEN GetObjByQuestionnaireSetId(string strQuestionnaireSetId)
{
string strAction = "GetObjByQuestionnaireSetId";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireSetEN objQuestionnaireSetEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionnaireSetId"] = strQuestionnaireSetId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionnaireSetEN = JsonConvert.DeserializeObject<clsQuestionnaireSetEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireSetEN;
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
 /// <param name = "strQuestionnaireSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireSetEN GetObjByQuestionnaireSetId_WA_Cache(string strQuestionnaireSetId)
{
string strAction = "GetObjByQuestionnaireSetId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireSetEN objQuestionnaireSetEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionnaireSetId"] = strQuestionnaireSetId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionnaireSetEN = JsonConvert.DeserializeObject<clsQuestionnaireSetEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireSetEN;
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
public static clsQuestionnaireSetEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionnaireSetEN objQuestionnaireSetEN = null;
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
objQuestionnaireSetEN = JsonConvert.DeserializeObject<clsQuestionnaireSetEN>((string)jobjReturn["ReturnObj"]);
return objQuestionnaireSetEN;
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
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireSetEN GetObjByQuestionnaireSetId_Cache(string strQuestionnaireSetId)
{
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName_S);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel =
from objQuestionnaireSetEN in arrQuestionnaireSetObjLst_Cache
where objQuestionnaireSetEN.QuestionnaireSetId == strQuestionnaireSetId
select objQuestionnaireSetEN;
if (arrQuestionnaireSetObjLst_Sel.Count() == 0)
{
   clsQuestionnaireSetEN obj = clsQuestionnaireSetWApi.GetObjByQuestionnaireSetId(strQuestionnaireSetId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionnaireSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionnaireSetNameByQuestionnaireSetId_Cache(string strQuestionnaireSetId)
{
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName_S);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel1 =
from objQuestionnaireSetEN in arrQuestionnaireSetObjLst_Cache
where objQuestionnaireSetEN.QuestionnaireSetId == strQuestionnaireSetId
select objQuestionnaireSetEN;
List <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel = new List<clsQuestionnaireSetEN>();
foreach (clsQuestionnaireSetEN obj in arrQuestionnaireSetObjLst_Sel1)
{
arrQuestionnaireSetObjLst_Sel.Add(obj);
}
if (arrQuestionnaireSetObjLst_Sel.Count > 0)
{
return arrQuestionnaireSetObjLst_Sel[0].QuestionnaireSetName;
}
string strErrMsgForGetObjById = string.Format("在QuestionnaireSet对象缓存列表中,找不到记录[QuestionnaireSetId = {0}](函数:{1})", strQuestionnaireSetId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionnaireSetId_Cache(string strQuestionnaireSetId)
{
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName_S);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel1 =
from objQuestionnaireSetEN in arrQuestionnaireSetObjLst_Cache
where objQuestionnaireSetEN.QuestionnaireSetId == strQuestionnaireSetId
select objQuestionnaireSetEN;
List <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel = new List<clsQuestionnaireSetEN>();
foreach (clsQuestionnaireSetEN obj in arrQuestionnaireSetObjLst_Sel1)
{
arrQuestionnaireSetObjLst_Sel.Add(obj);
}
if (arrQuestionnaireSetObjLst_Sel.Count > 0)
{
return arrQuestionnaireSetObjLst_Sel[0].QuestionnaireSetName;
}
string strErrMsgForGetObjById = string.Format("在QuestionnaireSet对象缓存列表中,找不到记录的相关名称[QuestionnaireSetId = {0}](函数:{1})", strQuestionnaireSetId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionnaireSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionnaireSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireSetEN> GetObjLstByQuestionnaireSetIdLst(List<string> arrQuestionnaireSetId)
{
 List<clsQuestionnaireSetEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionnaireSetIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionnaireSetId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQuestionnaireSetEN> GetObjLstByQuestionnaireSetIdLst_Cache(List<string> arrQuestionnaireSetId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName_S);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel =
from objQuestionnaireSetEN in arrQuestionnaireSetObjLst_Cache
where arrQuestionnaireSetId.Contains(objQuestionnaireSetEN.QuestionnaireSetId)
select objQuestionnaireSetEN;
return arrQuestionnaireSetObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLstByQuestionnaireSetIdLst_WA_Cache(List<string> arrQuestionnaireSetId)
{
 List<clsQuestionnaireSetEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionnaireSetIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionnaireSetId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireSetEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionnaireSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireSetEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionnaireSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionnaireSetEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionnaireSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionnaireSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strQuestionnaireSetId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQuestionnaireSetEN objQuestionnaireSetEN = clsQuestionnaireSetWApi.GetObjByQuestionnaireSetId(strQuestionnaireSetId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQuestionnaireSetId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionnaireSetWApi.ReFreshCache();
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
public static int DelQuestionnaireSets(List<string> arrQuestionnaireSetId)
{
string strAction = "DelQuestionnaireSets";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionnaireSetId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionnaireSetWApi.ReFreshCache();
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
public static int DelQuestionnaireSetsByCond(string strWhereCond)
{
string strAction = "DelQuestionnaireSetsByCond";
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
public static bool AddNewRecord(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireSetEN>(objQuestionnaireSetEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireSetEN>(objQuestionnaireSetEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetWApi.ReFreshCache();
var strQuestionnaireSetId = (string)jobjReturn["ReturnStr"];
return strQuestionnaireSetId;
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
public static bool UpdateRecord(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
if (string.IsNullOrEmpty(objQuestionnaireSetEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireSetEN.QuestionnaireSetId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireSetEN>(objQuestionnaireSetEN);
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
 /// <param name = "objQuestionnaireSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionnaireSetEN objQuestionnaireSetEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionnaireSetEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireSetEN.QuestionnaireSetId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionnaireSetEN.QuestionnaireSetId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionnaireSetEN>(objQuestionnaireSetEN);
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
public static bool IsExist(string strQuestionnaireSetId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionnaireSetId"] = strQuestionnaireSetId
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
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <param name = "objQuestionnaireSetENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireSetEN objQuestionnaireSetENS, clsQuestionnaireSetEN objQuestionnaireSetENT)
{
try
{
objQuestionnaireSetENT.QuestionnaireSetId = objQuestionnaireSetENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireSetENT.QuestionnaireSetName = objQuestionnaireSetENS.QuestionnaireSetName; //问卷集名
objQuestionnaireSetENT.OrderFieldInExport = objQuestionnaireSetENS.OrderFieldInExport; //导出排序字段
objQuestionnaireSetENT.ClassNo = objQuestionnaireSetENS.ClassNo; //分类号1
objQuestionnaireSetENT.ClassNo2 = objQuestionnaireSetENS.ClassNo2; //分类号2
objQuestionnaireSetENT.IsShowQuestionNo = objQuestionnaireSetENS.IsShowQuestionNo; //是否显示问题编号
objQuestionnaireSetENT.LogoFileName = objQuestionnaireSetENS.LogoFileName; //Logo文件名
objQuestionnaireSetENT.UpdDate = objQuestionnaireSetENS.UpdDate; //修改日期
objQuestionnaireSetENT.UpdUser = objQuestionnaireSetENS.UpdUser; //修改人
objQuestionnaireSetENT.Memo = objQuestionnaireSetENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQuestionnaireSetEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionnaireSetEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionnaireSetEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionnaireSetEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionnaireSetEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionnaireSetEN.AttributeName)
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
if (clsQuestionnaireSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetWApi没有刷新缓存机制(clsQuestionnaireSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionnaireSetId");
//if (arrQuestionnaireSetObjLst_Cache == null)
//{
//arrQuestionnaireSetObjLst_Cache = await clsQuestionnaireSetWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName_S);
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
if (clsQuestionnaireSetWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsQuestionnaireSetWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName_S);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionnaireSetObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionnaireSetEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionnaireSet.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireSet.QuestionnaireSetName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireSet.OrderFieldInExport, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireSet.ClassNo, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireSet.ClassNo2, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionnaireSet.IsShowQuestionNo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionnaireSet.LogoFileName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireSet.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireSet.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionnaireSet.Memo, Type.GetType("System.String"));
foreach (clsQuestionnaireSetEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionnaireSet.QuestionnaireSetId] = objInFor[conQuestionnaireSet.QuestionnaireSetId];
objDR[conQuestionnaireSet.QuestionnaireSetName] = objInFor[conQuestionnaireSet.QuestionnaireSetName];
objDR[conQuestionnaireSet.OrderFieldInExport] = objInFor[conQuestionnaireSet.OrderFieldInExport];
objDR[conQuestionnaireSet.ClassNo] = objInFor[conQuestionnaireSet.ClassNo];
objDR[conQuestionnaireSet.ClassNo2] = objInFor[conQuestionnaireSet.ClassNo2];
objDR[conQuestionnaireSet.IsShowQuestionNo] = objInFor[conQuestionnaireSet.IsShowQuestionNo];
objDR[conQuestionnaireSet.LogoFileName] = objInFor[conQuestionnaireSet.LogoFileName];
objDR[conQuestionnaireSet.UpdDate] = objInFor[conQuestionnaireSet.UpdDate];
objDR[conQuestionnaireSet.UpdUser] = objInFor[conQuestionnaireSet.UpdUser];
objDR[conQuestionnaireSet.Memo] = objInFor[conQuestionnaireSet.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 问卷集(QuestionnaireSet)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QuestionnaireSet : clsCommFun4BL
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
clsQuestionnaireSetWApi.ReFreshThisCache();
}
}

}