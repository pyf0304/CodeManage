
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsTeacherWApi
 表名:CurrEduClsTeacher(01120124)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:02
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行
 模块英文名:DailyRunning
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
public static class clsCurrEduClsTeacherWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN Setid_EduClsTeacher(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, long lngid_EduClsTeacher, string strComparisonOp="")
	{
objCurrEduClsTeacherEN.id_EduClsTeacher = lngid_EduClsTeacher; //教学班老师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.id_EduClsTeacher) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.id_EduClsTeacher, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.id_EduClsTeacher] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN Setid_CurrEduCls(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conCurrEduClsTeacher.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conCurrEduClsTeacher.id_CurrEduCls);
objCurrEduClsTeacherEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.id_CurrEduCls) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.id_CurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.id_CurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN Setid_Teacher(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Teacher, 8, conCurrEduClsTeacher.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, conCurrEduClsTeacher.id_Teacher);
objCurrEduClsTeacherEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.id_Teacher) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.id_Teacher, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.id_Teacher] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN Setid_Pk2EduClsTeacherType(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strid_Pk2EduClsTeacherType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Pk2EduClsTeacherType, 4, conCurrEduClsTeacher.id_Pk2EduClsTeacherType);
clsCheckSql.CheckFieldForeignKey(strid_Pk2EduClsTeacherType, 4, conCurrEduClsTeacher.id_Pk2EduClsTeacherType);
objCurrEduClsTeacherEN.id_Pk2EduClsTeacherType = strid_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.id_Pk2EduClsTeacherType) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.id_Pk2EduClsTeacherType, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.id_Pk2EduClsTeacherType] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetSchoolTerm(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsTeacher.SchoolTerm);
objCurrEduClsTeacherEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.SchoolTerm) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetSchoolYear(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsTeacher.SchoolYear);
objCurrEduClsTeacherEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.SchoolYear) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetOpenBeginDate(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strOpenBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenBeginDate, 8, conCurrEduClsTeacher.OpenBeginDate);
objCurrEduClsTeacherEN.OpenBeginDate = strOpenBeginDate; //开放开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.OpenBeginDate) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.OpenBeginDate, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.OpenBeginDate] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetOpenEndDate(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strOpenEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenEndDate, 8, conCurrEduClsTeacher.OpenEndDate);
objCurrEduClsTeacherEN.OpenEndDate = strOpenEndDate; //开放结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.OpenEndDate) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.OpenEndDate, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.OpenEndDate] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetUpdDate(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCurrEduClsTeacher.UpdDate);
objCurrEduClsTeacherEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.UpdDate) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.UpdDate, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.UpdDate] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetUpdUser(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCurrEduClsTeacher.UpdUser);
objCurrEduClsTeacherEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.UpdUser) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.UpdUser, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.UpdUser] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacherEN SetMemo(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsTeacher.Memo);
objCurrEduClsTeacherEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacherEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher.Memo) == false)
{
objCurrEduClsTeacherEN.dicFldComparisonOp.Add(conCurrEduClsTeacher.Memo, strComparisonOp);
}
else
{
objCurrEduClsTeacherEN.dicFldComparisonOp[conCurrEduClsTeacher.Memo] = strComparisonOp;
}
}
return objCurrEduClsTeacherEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsTeacherEN objCurrEduClsTeacher_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.id_EduClsTeacher) == true)
{
string strComparisonOp_id_EduClsTeacher = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.id_EduClsTeacher];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsTeacher.id_EduClsTeacher, objCurrEduClsTeacher_Cond.id_EduClsTeacher, strComparisonOp_id_EduClsTeacher);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.id_CurrEduCls, objCurrEduClsTeacher_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.id_Teacher, objCurrEduClsTeacher_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.id_Pk2EduClsTeacherType) == true)
{
string strComparisonOp_id_Pk2EduClsTeacherType = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.id_Pk2EduClsTeacherType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.id_Pk2EduClsTeacherType, objCurrEduClsTeacher_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.SchoolTerm, objCurrEduClsTeacher_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.SchoolYear, objCurrEduClsTeacher_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.OpenBeginDate) == true)
{
string strComparisonOp_OpenBeginDate = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.OpenBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.OpenBeginDate, objCurrEduClsTeacher_Cond.OpenBeginDate, strComparisonOp_OpenBeginDate);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.OpenEndDate) == true)
{
string strComparisonOp_OpenEndDate = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.OpenEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.OpenEndDate, objCurrEduClsTeacher_Cond.OpenEndDate, strComparisonOp_OpenEndDate);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.UpdDate, objCurrEduClsTeacher_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.UpdUser) == true)
{
string strComparisonOp_UpdUser = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.UpdUser, objCurrEduClsTeacher_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objCurrEduClsTeacher_Cond.IsUpdated(conCurrEduClsTeacher.Memo) == true)
{
string strComparisonOp_Memo = objCurrEduClsTeacher_Cond.dicFldComparisonOp[conCurrEduClsTeacher.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher.Memo, objCurrEduClsTeacher_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 if (objCurrEduClsTeacherEN.id_EduClsTeacher == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCurrEduClsTeacherEN.sf_UpdFldSetStr = objCurrEduClsTeacherEN.getsf_UpdFldSetStr();
clsCurrEduClsTeacherWApi.CheckPropertyNew(objCurrEduClsTeacherEN); 
bool bolResult = clsCurrEduClsTeacherWApi.UpdateRecord(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherWApi.ReFreshCache(objCurrEduClsTeacherEN.id_CurrEduCls);
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
 /// 检查唯一性(Uniqueness)--CurrEduClsTeacher(当前教学班教师), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_id_Teacher(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsTeacherEN == null) return "";
if (objCurrEduClsTeacherEN.id_EduClsTeacher == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacherEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Teacher = '{0}'", objCurrEduClsTeacherEN.id_Teacher);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_EduClsTeacher !=  {0}", objCurrEduClsTeacherEN.id_EduClsTeacher);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacherEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Teacher = '{0}'", objCurrEduClsTeacherEN.id_Teacher);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
try
{
clsCurrEduClsTeacherWApi.CheckPropertyNew(objCurrEduClsTeacherEN); 
bool bolResult = clsCurrEduClsTeacherWApi.AddNewRecord(objCurrEduClsTeacherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherWApi.ReFreshCache(objCurrEduClsTeacherEN.id_CurrEduCls);
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
 /// <param name = "objCurrEduClsTeacherEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strWhereCond)
{
try
{
clsCurrEduClsTeacherWApi.CheckPropertyNew(objCurrEduClsTeacherEN); 
bool bolResult = clsCurrEduClsTeacherWApi.UpdateWithCondition(objCurrEduClsTeacherEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherWApi.ReFreshCache(objCurrEduClsTeacherEN.id_CurrEduCls);
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
 /// 当前教学班教师(CurrEduClsTeacher)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsTeacherWApi
{
private static readonly string mstrApiControllerName = "CurrEduClsTeacherApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsCurrEduClsTeacherWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
if (!Object.Equals(null, objCurrEduClsTeacherEN.id_CurrEduCls) && GetStrLen(objCurrEduClsTeacherEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.id_Teacher) && GetStrLen(objCurrEduClsTeacherEN.id_Teacher) > 8)
{
 throw new Exception("字段[教师流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) && GetStrLen(objCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) > 4)
{
 throw new Exception("字段[教学班老师角色(主讲,辅导)流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.SchoolTerm) && GetStrLen(objCurrEduClsTeacherEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.SchoolYear) && GetStrLen(objCurrEduClsTeacherEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.OpenBeginDate) && GetStrLen(objCurrEduClsTeacherEN.OpenBeginDate) > 8)
{
 throw new Exception("字段[开放开始日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.OpenEndDate) && GetStrLen(objCurrEduClsTeacherEN.OpenEndDate) > 8)
{
 throw new Exception("字段[开放结束日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.UpdDate) && GetStrLen(objCurrEduClsTeacherEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.UpdUser) && GetStrLen(objCurrEduClsTeacherEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsTeacherEN.Memo) && GetStrLen(objCurrEduClsTeacherEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCurrEduClsTeacherEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_EduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsTeacherEN GetObjByid_EduClsTeacher(long lngid_EduClsTeacher)
{
string strAction = "GetObjByid_EduClsTeacher";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsTeacher"] = lngid_EduClsTeacher.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduClsTeacherEN = JsonConvert.DeserializeObject<clsCurrEduClsTeacherEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsTeacherEN;
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
 /// <param name = "lngid_EduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsTeacherEN GetObjByid_EduClsTeacher_WA_Cache(long lngid_EduClsTeacher, string strid_CurrEduCls)
{
string strAction = "GetObjByid_EduClsTeacher_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsTeacher"] = lngid_EduClsTeacher.ToString(),
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCurrEduClsTeacherEN = JsonConvert.DeserializeObject<clsCurrEduClsTeacherEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsTeacherEN;
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
public static clsCurrEduClsTeacherEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = null;
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
objCurrEduClsTeacherEN = JsonConvert.DeserializeObject<clsCurrEduClsTeacherEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsTeacherEN;
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
 /// <param name = "lngid_EduClsTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsTeacherEN GetObjByid_EduClsTeacher_Cache(long lngid_EduClsTeacher, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLst_Sel =
from objCurrEduClsTeacherEN in arrCurrEduClsTeacherObjLst_Cache
where objCurrEduClsTeacherEN.id_EduClsTeacher == lngid_EduClsTeacher
select objCurrEduClsTeacherEN;
if (arrCurrEduClsTeacherObjLst_Sel.Count() == 0)
{
   clsCurrEduClsTeacherEN obj = clsCurrEduClsTeacherWApi.GetObjByid_EduClsTeacher(lngid_EduClsTeacher);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCurrEduClsTeacherObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLst(string strWhereCond)
{
 List<clsCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacherEN> GetObjLstById_EduClsTeacherLst(List<long> arrId_EduClsTeacher)
{
 List<clsCurrEduClsTeacherEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsTeacherLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsTeacher);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_EduClsTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCurrEduClsTeacherEN> GetObjLstById_EduClsTeacherLst_Cache(List<long> arrId_EduClsTeacher, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLst_Sel =
from objCurrEduClsTeacherEN in arrCurrEduClsTeacherObjLst_Cache
where arrId_EduClsTeacher.Contains(objCurrEduClsTeacherEN.id_EduClsTeacher)
select objCurrEduClsTeacherEN;
return arrCurrEduClsTeacherObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLstById_EduClsTeacherLst_WA_Cache(List<long> arrId_EduClsTeacher, string strid_CurrEduCls)
{
 List<clsCurrEduClsTeacherEN> arrObjLst = null; 
string strAction = "GetObjLstById_EduClsTeacherLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_EduClsTeacher);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacherEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacherEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacherEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacherEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsTeacherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_EduClsTeacher)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = clsCurrEduClsTeacherWApi.GetObjByid_EduClsTeacher(lngid_EduClsTeacher);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_EduClsTeacher.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduClsTeacherWApi.ReFreshCache(objCurrEduClsTeacherEN.id_CurrEduCls);
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
public static int DelCurrEduClsTeachers(List<string> arrid_EduClsTeacher)
{
string strAction = "DelCurrEduClsTeachers";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_EduClsTeacher);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = clsCurrEduClsTeacherWApi.GetObjByid_EduClsTeacher(long.Parse(arrid_EduClsTeacher[0]));
clsCurrEduClsTeacherWApi.ReFreshCache(objCurrEduClsTeacherEN.id_CurrEduCls);
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
public static int DelCurrEduClsTeachersByCond(string strWhereCond)
{
string strAction = "DelCurrEduClsTeachersByCond";
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
public static bool AddNewRecord(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacherEN>(objCurrEduClsTeacherEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherWApi.ReFreshCache(objCurrEduClsTeacherEN.id_CurrEduCls);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacherEN>(objCurrEduClsTeacherEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacherWApi.ReFreshCache(objCurrEduClsTeacherEN.id_CurrEduCls);
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
public static bool UpdateRecord(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
if (string.IsNullOrEmpty(objCurrEduClsTeacherEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsTeacherEN.id_EduClsTeacher, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacherEN>(objCurrEduClsTeacherEN);
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
 /// <param name = "objCurrEduClsTeacherEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCurrEduClsTeacherEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsTeacherEN.id_EduClsTeacher, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsTeacherEN.id_EduClsTeacher, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacherEN>(objCurrEduClsTeacherEN);
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
public static bool IsExist(long lngid_EduClsTeacher)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_EduClsTeacher"] = lngid_EduClsTeacher.ToString()
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
 /// <param name = "objCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objCurrEduClsTeacherENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsTeacherEN objCurrEduClsTeacherENS, clsCurrEduClsTeacherEN objCurrEduClsTeacherENT)
{
try
{
objCurrEduClsTeacherENT.id_EduClsTeacher = objCurrEduClsTeacherENS.id_EduClsTeacher; //教学班老师流水号
objCurrEduClsTeacherENT.id_CurrEduCls = objCurrEduClsTeacherENS.id_CurrEduCls; //当前教学班流水号
objCurrEduClsTeacherENT.id_Teacher = objCurrEduClsTeacherENS.id_Teacher; //教师流水号
objCurrEduClsTeacherENT.id_Pk2EduClsTeacherType = objCurrEduClsTeacherENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherENT.SchoolTerm = objCurrEduClsTeacherENS.SchoolTerm; //学期
objCurrEduClsTeacherENT.SchoolYear = objCurrEduClsTeacherENS.SchoolYear; //学年
objCurrEduClsTeacherENT.OpenBeginDate = objCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objCurrEduClsTeacherENT.OpenEndDate = objCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objCurrEduClsTeacherENT.UpdDate = objCurrEduClsTeacherENS.UpdDate; //修改日期
objCurrEduClsTeacherENT.UpdUser = objCurrEduClsTeacherENS.UpdUser; //修改人
objCurrEduClsTeacherENT.Memo = objCurrEduClsTeacherENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCurrEduClsTeacherEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCurrEduClsTeacherEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCurrEduClsTeacherEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCurrEduClsTeacherEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCurrEduClsTeacherEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCurrEduClsTeacherEN.AttributeName)
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
if (clsCurrEduClsTeacherWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsTeacherWApi没有刷新缓存机制(clsCurrEduClsTeacherWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_EduClsTeacher");
//if (arrCurrEduClsTeacherObjLst_Cache == null)
//{
//arrCurrEduClsTeacherObjLst_Cache = await clsCurrEduClsTeacherWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strid_CurrEduCls = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
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
public static void ReFreshCache(string strid_CurrEduCls)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCurrEduClsTeacherWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
CacheHelper.Remove(strKey);
clsCurrEduClsTeacherWApi.objCommFun4BL.ReFreshCache(strid_CurrEduCls);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsTeacherEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName_S, strid_CurrEduCls);
List<clsCurrEduClsTeacherEN> arrCurrEduClsTeacherObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrCurrEduClsTeacherObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCurrEduClsTeacherEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCurrEduClsTeacher.id_EduClsTeacher, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduClsTeacher.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.id_Pk2EduClsTeacherType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.OpenBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.OpenEndDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher.Memo, Type.GetType("System.String"));
foreach (clsCurrEduClsTeacherEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCurrEduClsTeacher.id_EduClsTeacher] = objInFor[conCurrEduClsTeacher.id_EduClsTeacher];
objDR[conCurrEduClsTeacher.id_CurrEduCls] = objInFor[conCurrEduClsTeacher.id_CurrEduCls];
objDR[conCurrEduClsTeacher.id_Teacher] = objInFor[conCurrEduClsTeacher.id_Teacher];
objDR[conCurrEduClsTeacher.id_Pk2EduClsTeacherType] = objInFor[conCurrEduClsTeacher.id_Pk2EduClsTeacherType];
objDR[conCurrEduClsTeacher.SchoolTerm] = objInFor[conCurrEduClsTeacher.SchoolTerm];
objDR[conCurrEduClsTeacher.SchoolYear] = objInFor[conCurrEduClsTeacher.SchoolYear];
objDR[conCurrEduClsTeacher.OpenBeginDate] = objInFor[conCurrEduClsTeacher.OpenBeginDate];
objDR[conCurrEduClsTeacher.OpenEndDate] = objInFor[conCurrEduClsTeacher.OpenEndDate];
objDR[conCurrEduClsTeacher.UpdDate] = objInFor[conCurrEduClsTeacher.UpdDate];
objDR[conCurrEduClsTeacher.UpdUser] = objInFor[conCurrEduClsTeacher.UpdUser];
objDR[conCurrEduClsTeacher.Memo] = objInFor[conCurrEduClsTeacher.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 当前教学班教师(CurrEduClsTeacher)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CurrEduClsTeacher : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strid_CurrEduCls)
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
clsCurrEduClsTeacherWApi.ReFreshThisCache(strid_CurrEduCls);
clsvCurrEduClsTeacherWApi.ReFreshThisCache(strid_CurrEduCls);
}
}

}