
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClassifyGatherFieldWApi
 表名:ClassifyGatherField(01120012)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:51
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
public static class clsClassifyGatherFieldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetmId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, long lngmId, string strComparisonOp="")
	{
objClassifyGatherFieldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.mId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.mId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.mId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetClassifyGatherId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strClassifyGatherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherId, conClassifyGatherField.ClassifyGatherId);
clsCheckSql.CheckFieldLen(strClassifyGatherId, 4, conClassifyGatherField.ClassifyGatherId);
clsCheckSql.CheckFieldForeignKey(strClassifyGatherId, 4, conClassifyGatherField.ClassifyGatherId);
objClassifyGatherFieldEN.ClassifyGatherId = strClassifyGatherId; //分类统计Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.ClassifyGatherId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.ClassifyGatherId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.ClassifyGatherId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetQuestionID(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, conClassifyGatherField.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conClassifyGatherField.QuestionID);
objClassifyGatherFieldEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.QuestionID) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.QuestionID, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.QuestionID] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetClassifyFieldTypeId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strClassifyFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyFieldTypeId, conClassifyGatherField.ClassifyFieldTypeId);
clsCheckSql.CheckFieldLen(strClassifyFieldTypeId, 4, conClassifyGatherField.ClassifyFieldTypeId);
clsCheckSql.CheckFieldForeignKey(strClassifyFieldTypeId, 4, conClassifyGatherField.ClassifyFieldTypeId);
objClassifyGatherFieldEN.ClassifyFieldTypeId = strClassifyFieldTypeId; //分类字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.ClassifyFieldTypeId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.ClassifyFieldTypeId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.ClassifyFieldTypeId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetGatherModeId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strGatherModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGatherModeId, conClassifyGatherField.GatherModeId);
clsCheckSql.CheckFieldLen(strGatherModeId, 4, conClassifyGatherField.GatherModeId);
clsCheckSql.CheckFieldForeignKey(strGatherModeId, 4, conClassifyGatherField.GatherModeId);
objClassifyGatherFieldEN.GatherModeId = strGatherModeId; //汇总模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.GatherModeId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.GatherModeId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.GatherModeId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetDetailTitle(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strDetailTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDetailTitle, 30, conClassifyGatherField.DetailTitle);
objClassifyGatherFieldEN.DetailTitle = strDetailTitle; //详细列表标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.DetailTitle) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.DetailTitle, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.DetailTitle] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetIsDetailTitleIndexNo(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, bool bolIsDetailTitleIndexNo, string strComparisonOp="")
	{
objClassifyGatherFieldEN.IsDetailTitleIndexNo = bolIsDetailTitleIndexNo; //标题是否编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.IsDetailTitleIndexNo) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.IsDetailTitleIndexNo, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.IsDetailTitleIndexNo] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetRecNo(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, int intRecNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRecNo, conClassifyGatherField.RecNo);
objClassifyGatherFieldEN.RecNo = intRecNo; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.RecNo) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.RecNo, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.RecNo] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetUpdDate(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conClassifyGatherField.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conClassifyGatherField.UpdDate);
objClassifyGatherFieldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.UpdDate) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.UpdDate, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.UpdDate] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetUpdUser(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conClassifyGatherField.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conClassifyGatherField.UpdUser);
objClassifyGatherFieldEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.UpdUser) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.UpdUser, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.UpdUser] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClassifyGatherFieldEN SetMemo(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conClassifyGatherField.Memo);
objClassifyGatherFieldEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.Memo) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.Memo, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.Memo] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsClassifyGatherFieldEN objClassifyGatherField_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.mId) == true)
{
string strComparisonOp_mId = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conClassifyGatherField.mId, objClassifyGatherField_Cond.mId, strComparisonOp_mId);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.ClassifyGatherId) == true)
{
string strComparisonOp_ClassifyGatherId = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.ClassifyGatherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.ClassifyGatherId, objClassifyGatherField_Cond.ClassifyGatherId, strComparisonOp_ClassifyGatherId);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.QuestionID) == true)
{
string strComparisonOp_QuestionID = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.QuestionID, objClassifyGatherField_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.ClassifyFieldTypeId) == true)
{
string strComparisonOp_ClassifyFieldTypeId = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.ClassifyFieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.ClassifyFieldTypeId, objClassifyGatherField_Cond.ClassifyFieldTypeId, strComparisonOp_ClassifyFieldTypeId);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.GatherModeId) == true)
{
string strComparisonOp_GatherModeId = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.GatherModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.GatherModeId, objClassifyGatherField_Cond.GatherModeId, strComparisonOp_GatherModeId);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.DetailTitle) == true)
{
string strComparisonOp_DetailTitle = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.DetailTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.DetailTitle, objClassifyGatherField_Cond.DetailTitle, strComparisonOp_DetailTitle);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.IsDetailTitleIndexNo) == true)
{
if (objClassifyGatherField_Cond.IsDetailTitleIndexNo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClassifyGatherField.IsDetailTitleIndexNo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClassifyGatherField.IsDetailTitleIndexNo);
}
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.RecNo) == true)
{
string strComparisonOp_RecNo = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.RecNo];
strWhereCond += string.Format(" And {0} {2} {1}", conClassifyGatherField.RecNo, objClassifyGatherField_Cond.RecNo, strComparisonOp_RecNo);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.UpdDate) == true)
{
string strComparisonOp_UpdDate = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.UpdDate, objClassifyGatherField_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.UpdUser) == true)
{
string strComparisonOp_UpdUser = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.UpdUser, objClassifyGatherField_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objClassifyGatherField_Cond.IsUpdated(conClassifyGatherField.Memo) == true)
{
string strComparisonOp_Memo = objClassifyGatherField_Cond.dicFldComparisonOp[conClassifyGatherField.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.Memo, objClassifyGatherField_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
 if (objClassifyGatherFieldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objClassifyGatherFieldEN.sf_UpdFldSetStr = objClassifyGatherFieldEN.getsf_UpdFldSetStr();
clsClassifyGatherFieldWApi.CheckPropertyNew(objClassifyGatherFieldEN); 
bool bolResult = clsClassifyGatherFieldWApi.UpdateRecord(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--ClassifyGatherField(分类汇总字段), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ClassifyGatherId_QuestionID_ClassifyFieldTypeId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objClassifyGatherFieldEN == null) return "";
if (objClassifyGatherFieldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClassifyGatherId = '{0}'", objClassifyGatherFieldEN.ClassifyGatherId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objClassifyGatherFieldEN.QuestionID);
 sbCondition.AppendFormat(" and ClassifyFieldTypeId = '{0}'", objClassifyGatherFieldEN.ClassifyFieldTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objClassifyGatherFieldEN.mId);
 sbCondition.AppendFormat(" and ClassifyGatherId = '{0}'", objClassifyGatherFieldEN.ClassifyGatherId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objClassifyGatherFieldEN.QuestionID);
 sbCondition.AppendFormat(" and ClassifyFieldTypeId = '{0}'", objClassifyGatherFieldEN.ClassifyFieldTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
try
{
clsClassifyGatherFieldWApi.CheckPropertyNew(objClassifyGatherFieldEN); 
bool bolResult = clsClassifyGatherFieldWApi.AddNewRecord(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldWApi.ReFreshCache();
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
 /// <param name = "objClassifyGatherFieldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strWhereCond)
{
try
{
clsClassifyGatherFieldWApi.CheckPropertyNew(objClassifyGatherFieldEN); 
bool bolResult = clsClassifyGatherFieldWApi.UpdateWithCondition(objClassifyGatherFieldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldWApi.ReFreshCache();
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
 /// 分类汇总字段(ClassifyGatherField)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsClassifyGatherFieldWApi
{
private static readonly string mstrApiControllerName = "ClassifyGatherFieldApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsClassifyGatherFieldWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
if (!Object.Equals(null, objClassifyGatherFieldEN.ClassifyGatherId) && GetStrLen(objClassifyGatherFieldEN.ClassifyGatherId) > 4)
{
 throw new Exception("字段[分类统计Id]的长度不能超过4!");
}
if (!Object.Equals(null, objClassifyGatherFieldEN.QuestionID) && GetStrLen(objClassifyGatherFieldEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objClassifyGatherFieldEN.ClassifyFieldTypeId) && GetStrLen(objClassifyGatherFieldEN.ClassifyFieldTypeId) > 4)
{
 throw new Exception("字段[分类字段类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objClassifyGatherFieldEN.GatherModeId) && GetStrLen(objClassifyGatherFieldEN.GatherModeId) > 4)
{
 throw new Exception("字段[汇总模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objClassifyGatherFieldEN.DetailTitle) && GetStrLen(objClassifyGatherFieldEN.DetailTitle) > 30)
{
 throw new Exception("字段[详细列表标题]的长度不能超过30!");
}
if (!Object.Equals(null, objClassifyGatherFieldEN.UpdDate) && GetStrLen(objClassifyGatherFieldEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objClassifyGatherFieldEN.UpdUser) && GetStrLen(objClassifyGatherFieldEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objClassifyGatherFieldEN.Memo) && GetStrLen(objClassifyGatherFieldEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objClassifyGatherFieldEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClassifyGatherFieldEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsClassifyGatherFieldEN objClassifyGatherFieldEN = null;
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
objClassifyGatherFieldEN = JsonConvert.DeserializeObject<clsClassifyGatherFieldEN>((string)jobjReturn["ReturnObj"]);
return objClassifyGatherFieldEN;
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
public static clsClassifyGatherFieldEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsClassifyGatherFieldEN objClassifyGatherFieldEN = null;
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
objClassifyGatherFieldEN = JsonConvert.DeserializeObject<clsClassifyGatherFieldEN>((string)jobjReturn["ReturnObj"]);
return objClassifyGatherFieldEN;
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
public static clsClassifyGatherFieldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsClassifyGatherFieldEN objClassifyGatherFieldEN = null;
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
objClassifyGatherFieldEN = JsonConvert.DeserializeObject<clsClassifyGatherFieldEN>((string)jobjReturn["ReturnObj"]);
return objClassifyGatherFieldEN;
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
public static clsClassifyGatherFieldEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName_S);
List<clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLst_Sel =
from objClassifyGatherFieldEN in arrClassifyGatherFieldObjLst_Cache
where objClassifyGatherFieldEN.mId == lngmId
select objClassifyGatherFieldEN;
if (arrClassifyGatherFieldObjLst_Sel.Count() == 0)
{
   clsClassifyGatherFieldEN obj = clsClassifyGatherFieldWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrClassifyGatherFieldObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetObjLst(string strWhereCond)
{
 List<clsClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClassifyGatherFieldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsClassifyGatherFieldEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName_S);
List<clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLst_Sel =
from objClassifyGatherFieldEN in arrClassifyGatherFieldObjLst_Cache
where arrMId.Contains(objClassifyGatherFieldEN.mId)
select objClassifyGatherFieldEN;
return arrClassifyGatherFieldObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClassifyGatherFieldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClassifyGatherFieldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClassifyGatherFieldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClassifyGatherFieldEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsClassifyGatherFieldEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClassifyGatherFieldEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsClassifyGatherFieldEN objClassifyGatherFieldEN = clsClassifyGatherFieldWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsClassifyGatherFieldWApi.ReFreshCache();
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
public static int DelClassifyGatherFields(List<string> arrmId)
{
string strAction = "DelClassifyGatherFields";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsClassifyGatherFieldWApi.ReFreshCache();
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
public static int DelClassifyGatherFieldsByCond(string strWhereCond)
{
string strAction = "DelClassifyGatherFieldsByCond";
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
public static bool AddNewRecord(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClassifyGatherFieldEN>(objClassifyGatherFieldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldWApi.ReFreshCache();
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
 /// <param name = "objClassifyGatherFieldEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClassifyGatherFieldEN>(objClassifyGatherFieldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldWApi.ReFreshCache();
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
public static bool UpdateRecord(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
if (string.IsNullOrEmpty(objClassifyGatherFieldEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClassifyGatherFieldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClassifyGatherFieldEN>(objClassifyGatherFieldEN);
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
 /// <param name = "objClassifyGatherFieldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objClassifyGatherFieldEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClassifyGatherFieldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClassifyGatherFieldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClassifyGatherFieldEN>(objClassifyGatherFieldEN);
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
 /// <param name = "objClassifyGatherFieldENS">源对象</param>
 /// <param name = "objClassifyGatherFieldENT">目标对象</param>
 public static void CopyTo(clsClassifyGatherFieldEN objClassifyGatherFieldENS, clsClassifyGatherFieldEN objClassifyGatherFieldENT)
{
try
{
objClassifyGatherFieldENT.mId = objClassifyGatherFieldENS.mId; //mId
objClassifyGatherFieldENT.ClassifyGatherId = objClassifyGatherFieldENS.ClassifyGatherId; //分类统计Id
objClassifyGatherFieldENT.QuestionID = objClassifyGatherFieldENS.QuestionID; //题目ID
objClassifyGatherFieldENT.ClassifyFieldTypeId = objClassifyGatherFieldENS.ClassifyFieldTypeId; //分类字段类型Id
objClassifyGatherFieldENT.GatherModeId = objClassifyGatherFieldENS.GatherModeId; //汇总模式Id
objClassifyGatherFieldENT.DetailTitle = objClassifyGatherFieldENS.DetailTitle; //详细列表标题
objClassifyGatherFieldENT.IsDetailTitleIndexNo = objClassifyGatherFieldENS.IsDetailTitleIndexNo; //标题是否编号
objClassifyGatherFieldENT.RecNo = objClassifyGatherFieldENS.RecNo; //序号
objClassifyGatherFieldENT.UpdDate = objClassifyGatherFieldENS.UpdDate; //修改日期
objClassifyGatherFieldENT.UpdUser = objClassifyGatherFieldENS.UpdUser; //修改人
objClassifyGatherFieldENT.Memo = objClassifyGatherFieldENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsClassifyGatherFieldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsClassifyGatherFieldEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsClassifyGatherFieldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsClassifyGatherFieldEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsClassifyGatherFieldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsClassifyGatherFieldEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrClassifyGatherFieldObjLst_Cache == null)
//{
//arrClassifyGatherFieldObjLst_Cache = await clsClassifyGatherFieldWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName_S);
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
if (clsClassifyGatherFieldWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsClassifyGatherFieldWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName_S);
List<clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrClassifyGatherFieldObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsClassifyGatherFieldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conClassifyGatherField.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conClassifyGatherField.ClassifyGatherId, Type.GetType("System.String"));
objDT.Columns.Add(conClassifyGatherField.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conClassifyGatherField.ClassifyFieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conClassifyGatherField.GatherModeId, Type.GetType("System.String"));
objDT.Columns.Add(conClassifyGatherField.DetailTitle, Type.GetType("System.String"));
objDT.Columns.Add(conClassifyGatherField.IsDetailTitleIndexNo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conClassifyGatherField.RecNo, Type.GetType("System.Int32"));
objDT.Columns.Add(conClassifyGatherField.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conClassifyGatherField.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conClassifyGatherField.Memo, Type.GetType("System.String"));
foreach (clsClassifyGatherFieldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conClassifyGatherField.mId] = objInFor[conClassifyGatherField.mId];
objDR[conClassifyGatherField.ClassifyGatherId] = objInFor[conClassifyGatherField.ClassifyGatherId];
objDR[conClassifyGatherField.QuestionID] = objInFor[conClassifyGatherField.QuestionID];
objDR[conClassifyGatherField.ClassifyFieldTypeId] = objInFor[conClassifyGatherField.ClassifyFieldTypeId];
objDR[conClassifyGatherField.GatherModeId] = objInFor[conClassifyGatherField.GatherModeId];
objDR[conClassifyGatherField.DetailTitle] = objInFor[conClassifyGatherField.DetailTitle];
objDR[conClassifyGatherField.IsDetailTitleIndexNo] = objInFor[conClassifyGatherField.IsDetailTitleIndexNo];
objDR[conClassifyGatherField.RecNo] = objInFor[conClassifyGatherField.RecNo];
objDR[conClassifyGatherField.UpdDate] = objInFor[conClassifyGatherField.UpdDate];
objDR[conClassifyGatherField.UpdUser] = objInFor[conClassifyGatherField.UpdUser];
objDR[conClassifyGatherField.Memo] = objInFor[conClassifyGatherField.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 分类汇总字段(ClassifyGatherField)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4ClassifyGatherField : clsCommFun4BL
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
clsClassifyGatherFieldWApi.ReFreshThisCache();
clsvClassifyGatherFieldWApi.ReFreshThisCache();
}
}

}