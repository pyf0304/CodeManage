
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStu4CorrectWApi
 表名:CurrEduClsStu4Correct(01120180)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:42
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:UsersRight
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
public static class clsCurrEduClsStu4CorrectWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetId_CurrEduClsStu4Correct(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, long lngId_CurrEduClsStu4Correct, string strComparisonOp="")
	{
objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct = lngId_CurrEduClsStu4Correct; //教学班学生_批改作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN Setid_CurrEduCls(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conCurrEduClsStu4Correct.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conCurrEduClsStu4Correct.id_CurrEduCls);
objCurrEduClsStu4CorrectEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.id_CurrEduCls) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.id_CurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.id_CurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN Setid_Stu(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strid_Stu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Stu, 8, conCurrEduClsStu4Correct.id_Stu);
clsCheckSql.CheckFieldForeignKey(strid_Stu, 8, conCurrEduClsStu4Correct.id_Stu);
objCurrEduClsStu4CorrectEN.id_Stu = strid_Stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.id_Stu) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.id_Stu, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.id_Stu] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetRightId(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, conCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckFieldLen(strRightId, 8, conCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckFieldForeignKey(strRightId, 8, conCurrEduClsStu4Correct.RightId);
objCurrEduClsStu4CorrectEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.RightId) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.RightId, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.RightId] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetSchoolTerm(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsStu4Correct.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsStu4Correct.SchoolTerm);
objCurrEduClsStu4CorrectEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.SchoolTerm) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetSchoolYear(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsStu4Correct.SchoolYear);
objCurrEduClsStu4CorrectEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.SchoolYear) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetModifyDate(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduClsStu4Correct.ModifyDate);
objCurrEduClsStu4CorrectEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.ModifyDate) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.ModifyDate, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyDate] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetModifyUserID(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conCurrEduClsStu4Correct.ModifyUserID);
objCurrEduClsStu4CorrectEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.ModifyUserID) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.ModifyUserID, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyUserID] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetMemo(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsStu4Correct.Memo);
objCurrEduClsStu4CorrectEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.Memo) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.Memo, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.Memo] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4Correct_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct) == true)
{
string strComparisonOp_Id_CurrEduClsStu4Correct = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct, objCurrEduClsStu4Correct_Cond.Id_CurrEduClsStu4Correct, strComparisonOp_Id_CurrEduClsStu4Correct);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.id_CurrEduCls, objCurrEduClsStu4Correct_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.id_Stu) == true)
{
string strComparisonOp_id_Stu = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.id_Stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.id_Stu, objCurrEduClsStu4Correct_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.RightId) == true)
{
string strComparisonOp_RightId = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.RightId, objCurrEduClsStu4Correct_Cond.RightId, strComparisonOp_RightId);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.SchoolTerm, objCurrEduClsStu4Correct_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.SchoolYear, objCurrEduClsStu4Correct_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.ModifyDate, objCurrEduClsStu4Correct_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.ModifyUserID, objCurrEduClsStu4Correct_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objCurrEduClsStu4Correct_Cond.IsUpdated(conCurrEduClsStu4Correct.Memo) == true)
{
string strComparisonOp_Memo = objCurrEduClsStu4Correct_Cond.dicFldComparisonOp[conCurrEduClsStu4Correct.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.Memo, objCurrEduClsStu4Correct_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 if (objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCurrEduClsStu4CorrectEN.sf_UpdFldSetStr = objCurrEduClsStu4CorrectEN.getsf_UpdFldSetStr();
clsCurrEduClsStu4CorrectWApi.CheckPropertyNew(objCurrEduClsStu4CorrectEN); 
bool bolResult = clsCurrEduClsStu4CorrectWApi.UpdateRecord(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CurrEduClsStu4Correct(教学班学生_批改作业), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_id_Stu(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsStu4CorrectEN == null) return "";
if (objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsStu4CorrectEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Stu = '{0}'", objCurrEduClsStu4CorrectEN.id_Stu);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_CurrEduClsStu4Correct !=  {0}", objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsStu4CorrectEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Stu = '{0}'", objCurrEduClsStu4CorrectEN.id_Stu);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
try
{
clsCurrEduClsStu4CorrectWApi.CheckPropertyNew(objCurrEduClsStu4CorrectEN); 
bool bolResult = clsCurrEduClsStu4CorrectWApi.AddNewRecord(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectWApi.ReFreshCache();
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strWhereCond)
{
try
{
clsCurrEduClsStu4CorrectWApi.CheckPropertyNew(objCurrEduClsStu4CorrectEN); 
bool bolResult = clsCurrEduClsStu4CorrectWApi.UpdateWithCondition(objCurrEduClsStu4CorrectEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectWApi.ReFreshCache();
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
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsStu4CorrectWApi
{
private static readonly string mstrApiControllerName = "CurrEduClsStu4CorrectApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCurrEduClsStu4CorrectWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.id_CurrEduCls) && GetStrLen(objCurrEduClsStu4CorrectEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.id_Stu) && GetStrLen(objCurrEduClsStu4CorrectEN.id_Stu) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.RightId) && GetStrLen(objCurrEduClsStu4CorrectEN.RightId) > 8)
{
 throw new Exception("字段[权限编号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.SchoolTerm) && GetStrLen(objCurrEduClsStu4CorrectEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.SchoolYear) && GetStrLen(objCurrEduClsStu4CorrectEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.ModifyDate) && GetStrLen(objCurrEduClsStu4CorrectEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.ModifyUserID) && GetStrLen(objCurrEduClsStu4CorrectEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objCurrEduClsStu4CorrectEN.Memo) && GetStrLen(objCurrEduClsStu4CorrectEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCurrEduClsStu4CorrectEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_CurrEduClsStu4Correct">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStu4CorrectEN GetObjById_CurrEduClsStu4Correct(long lngId_CurrEduClsStu4Correct)
{
string strAction = "GetObjById_CurrEduClsStu4Correct";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CurrEduClsStu4Correct"] = lngId_CurrEduClsStu4Correct.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduClsStu4CorrectEN = JsonConvert.DeserializeObject<clsCurrEduClsStu4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStu4CorrectEN;
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
 /// <param name = "lngId_CurrEduClsStu4Correct">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStu4CorrectEN GetObjById_CurrEduClsStu4Correct_WA_Cache(long lngId_CurrEduClsStu4Correct)
{
string strAction = "GetObjById_CurrEduClsStu4Correct_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CurrEduClsStu4Correct"] = lngId_CurrEduClsStu4Correct.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduClsStu4CorrectEN = JsonConvert.DeserializeObject<clsCurrEduClsStu4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStu4CorrectEN;
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
public static clsCurrEduClsStu4CorrectEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = null;
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
objCurrEduClsStu4CorrectEN = JsonConvert.DeserializeObject<clsCurrEduClsStu4CorrectEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsStu4CorrectEN;
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
 /// <param name = "lngId_CurrEduClsStu4Correct">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsStu4CorrectEN GetObjById_CurrEduClsStu4Correct_Cache(long lngId_CurrEduClsStu4Correct)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName_S);
List<clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLst_Sel =
from objCurrEduClsStu4CorrectEN in arrCurrEduClsStu4CorrectObjLst_Cache
where objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct == lngId_CurrEduClsStu4Correct
select objCurrEduClsStu4CorrectEN;
if (arrCurrEduClsStu4CorrectObjLst_Sel.Count() == 0)
{
   clsCurrEduClsStu4CorrectEN obj = clsCurrEduClsStu4CorrectWApi.GetObjById_CurrEduClsStu4Correct(lngId_CurrEduClsStu4Correct);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCurrEduClsStu4CorrectObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLst(string strWhereCond)
{
 List<clsCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstById_CurrEduClsStu4CorrectLst(List<long> arrId_CurrEduClsStu4Correct)
{
 List<clsCurrEduClsStu4CorrectEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsStu4CorrectLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduClsStu4Correct);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_CurrEduClsStu4Correct">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCurrEduClsStu4CorrectEN> GetObjLstById_CurrEduClsStu4CorrectLst_Cache(List<long> arrId_CurrEduClsStu4Correct)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName_S);
List<clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLst_Sel =
from objCurrEduClsStu4CorrectEN in arrCurrEduClsStu4CorrectObjLst_Cache
where arrId_CurrEduClsStu4Correct.Contains(objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct)
select objCurrEduClsStu4CorrectEN;
return arrCurrEduClsStu4CorrectObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstById_CurrEduClsStu4CorrectLst_WA_Cache(List<long> arrId_CurrEduClsStu4Correct)
{
 List<clsCurrEduClsStu4CorrectEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsStu4CorrectLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduClsStu4Correct);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4CorrectEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsStu4CorrectEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsStu4CorrectEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_CurrEduClsStu4Correct)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = clsCurrEduClsStu4CorrectWApi.GetObjById_CurrEduClsStu4Correct(lngId_CurrEduClsStu4Correct);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_CurrEduClsStu4Correct.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduClsStu4CorrectWApi.ReFreshCache();
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
public static int DelCurrEduClsStu4Corrects(List<string> arrId_CurrEduClsStu4Correct)
{
string strAction = "DelCurrEduClsStu4Corrects";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduClsStu4Correct);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduClsStu4CorrectWApi.ReFreshCache();
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
public static int DelCurrEduClsStu4CorrectsByCond(string strWhereCond)
{
string strAction = "DelCurrEduClsStu4CorrectsByCond";
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
public static bool AddNewRecord(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4CorrectEN>(objCurrEduClsStu4CorrectEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectWApi.ReFreshCache();
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4CorrectEN>(objCurrEduClsStu4CorrectEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
if (string.IsNullOrEmpty(objCurrEduClsStu4CorrectEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4CorrectEN>(objCurrEduClsStu4CorrectEN);
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCurrEduClsStu4CorrectEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsStu4CorrectEN.Id_CurrEduClsStu4Correct, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsStu4CorrectEN>(objCurrEduClsStu4CorrectEN);
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
public static bool IsExist(long lngId_CurrEduClsStu4Correct)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CurrEduClsStu4Correct"] = lngId_CurrEduClsStu4Correct.ToString()
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
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <param name = "objCurrEduClsStu4CorrectENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENS, clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENT)
{
try
{
objCurrEduClsStu4CorrectENT.Id_CurrEduClsStu4Correct = objCurrEduClsStu4CorrectENS.Id_CurrEduClsStu4Correct; //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectENT.id_CurrEduCls = objCurrEduClsStu4CorrectENS.id_CurrEduCls; //当前教学班流水号
objCurrEduClsStu4CorrectENT.id_Stu = objCurrEduClsStu4CorrectENS.id_Stu; //学生流水号
objCurrEduClsStu4CorrectENT.RightId = objCurrEduClsStu4CorrectENS.RightId; //权限编号
objCurrEduClsStu4CorrectENT.SchoolTerm = objCurrEduClsStu4CorrectENS.SchoolTerm; //学期
objCurrEduClsStu4CorrectENT.SchoolYear = objCurrEduClsStu4CorrectENS.SchoolYear; //学年
objCurrEduClsStu4CorrectENT.ModifyDate = objCurrEduClsStu4CorrectENS.ModifyDate; //修改日期
objCurrEduClsStu4CorrectENT.ModifyUserID = objCurrEduClsStu4CorrectENS.ModifyUserID; //修改人
objCurrEduClsStu4CorrectENT.Memo = objCurrEduClsStu4CorrectENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCurrEduClsStu4CorrectEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCurrEduClsStu4CorrectEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCurrEduClsStu4CorrectEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCurrEduClsStu4CorrectEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCurrEduClsStu4CorrectEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCurrEduClsStu4CorrectEN.AttributeName)
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
if (clsCurrEduClsStu4CorrectWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStu4CorrectWApi没有刷新缓存机制(clsCurrEduClsStu4CorrectWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CurrEduClsStu4Correct");
//if (arrCurrEduClsStu4CorrectObjLst_Cache == null)
//{
//arrCurrEduClsStu4CorrectObjLst_Cache = await clsCurrEduClsStu4CorrectWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName_S);
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
if (clsCurrEduClsStu4CorrectWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCurrEduClsStu4CorrectWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName_S);
List<clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduClsStu4CorrectObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCurrEduClsStu4CorrectEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduClsStu4Correct.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Correct.id_Stu, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Correct.RightId, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Correct.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Correct.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Correct.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Correct.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsStu4Correct.Memo, Type.GetType("System.String"));
foreach (clsCurrEduClsStu4CorrectEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct] = objInFor[conCurrEduClsStu4Correct.Id_CurrEduClsStu4Correct];
objDR[conCurrEduClsStu4Correct.id_CurrEduCls] = objInFor[conCurrEduClsStu4Correct.id_CurrEduCls];
objDR[conCurrEduClsStu4Correct.id_Stu] = objInFor[conCurrEduClsStu4Correct.id_Stu];
objDR[conCurrEduClsStu4Correct.RightId] = objInFor[conCurrEduClsStu4Correct.RightId];
objDR[conCurrEduClsStu4Correct.SchoolTerm] = objInFor[conCurrEduClsStu4Correct.SchoolTerm];
objDR[conCurrEduClsStu4Correct.SchoolYear] = objInFor[conCurrEduClsStu4Correct.SchoolYear];
objDR[conCurrEduClsStu4Correct.ModifyDate] = objInFor[conCurrEduClsStu4Correct.ModifyDate];
objDR[conCurrEduClsStu4Correct.ModifyUserID] = objInFor[conCurrEduClsStu4Correct.ModifyUserID];
objDR[conCurrEduClsStu4Correct.Memo] = objInFor[conCurrEduClsStu4Correct.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CurrEduClsStu4Correct : clsCommFun4BL
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
clsCurrEduClsStu4CorrectWApi.ReFreshThisCache();
clsvCurrEduClsStu4CorrectWApi.ReFreshThisCache();
}
}

}