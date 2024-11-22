
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsTeacher4SynchWApi
 表名:CurrEduClsTeacher4Synch(01120360)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:10
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
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
public static class clsCurrEduClsTeacher4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetmId(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, long lngmId, string strComparisonOp="")
	{
objCurrEduClsTeacher4SynchEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.mId) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.mId, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.mId] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetAccessSynchDate(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, conCurrEduClsTeacher4Synch.AccessSynchDate);
objCurrEduClsTeacher4SynchEN.AccessSynchDate = strAccessSynchDate; //处理同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.AccessSynchDate) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.AccessSynchDate, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.AccessSynchDate] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN Setid_EduClsTeacher(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, long lngid_EduClsTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngid_EduClsTeacher, conCurrEduClsTeacher4Synch.id_EduClsTeacher);
objCurrEduClsTeacher4SynchEN.id_EduClsTeacher = lngid_EduClsTeacher; //教学班老师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.id_EduClsTeacher) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.id_EduClsTeacher, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_EduClsTeacher] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN Setid_CurrEduCls(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conCurrEduClsTeacher4Synch.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conCurrEduClsTeacher4Synch.id_CurrEduCls);
objCurrEduClsTeacher4SynchEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.id_CurrEduCls) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.id_CurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_CurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN Setid_Teacher(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Teacher, 8, conCurrEduClsTeacher4Synch.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, conCurrEduClsTeacher4Synch.id_Teacher);
objCurrEduClsTeacher4SynchEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.id_Teacher) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.id_Teacher, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_Teacher] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN Setid_Pk2EduClsTeacherType(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strid_Pk2EduClsTeacherType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Pk2EduClsTeacherType, 4, conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType);
clsCheckSql.CheckFieldForeignKey(strid_Pk2EduClsTeacherType, 4, conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType);
objCurrEduClsTeacher4SynchEN.id_Pk2EduClsTeacherType = strid_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetSchoolTerm(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsTeacher4Synch.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsTeacher4Synch.SchoolTerm);
objCurrEduClsTeacher4SynchEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.SchoolTerm) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetSchoolYear(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsTeacher4Synch.SchoolYear);
objCurrEduClsTeacher4SynchEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.SchoolYear) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetOpenBeginDate(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strOpenBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenBeginDate, 8, conCurrEduClsTeacher4Synch.OpenBeginDate);
objCurrEduClsTeacher4SynchEN.OpenBeginDate = strOpenBeginDate; //开放开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.OpenBeginDate) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.OpenBeginDate, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.OpenBeginDate] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetOpenEndDate(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strOpenEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenEndDate, 8, conCurrEduClsTeacher4Synch.OpenEndDate);
objCurrEduClsTeacher4SynchEN.OpenEndDate = strOpenEndDate; //开放结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.OpenEndDate) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.OpenEndDate, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.OpenEndDate] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetIpAddress(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conCurrEduClsTeacher4Synch.IpAddress);
objCurrEduClsTeacher4SynchEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.IpAddress) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.IpAddress, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.IpAddress] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetIsAccessSynch(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, bool bolIsAccessSynch, string strComparisonOp="")
	{
objCurrEduClsTeacher4SynchEN.IsAccessSynch = bolIsAccessSynch; //是否处理同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.IsAccessSynch) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.IsAccessSynch, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.IsAccessSynch] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetUpdDate(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCurrEduClsTeacher4Synch.UpdDate);
objCurrEduClsTeacher4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.UpdDate) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.UpdDate, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.UpdDate] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetUpdUser(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCurrEduClsTeacher4Synch.UpdUser);
objCurrEduClsTeacher4SynchEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.UpdUser) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.UpdUser, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.UpdUser] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCurrEduClsTeacher4SynchEN SetMemo(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsTeacher4Synch.Memo);
objCurrEduClsTeacher4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.ContainsKey(conCurrEduClsTeacher4Synch.Memo) == false)
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp.Add(conCurrEduClsTeacher4Synch.Memo, strComparisonOp);
}
else
{
objCurrEduClsTeacher4SynchEN.dicFldComparisonOp[conCurrEduClsTeacher4Synch.Memo] = strComparisonOp;
}
}
return objCurrEduClsTeacher4SynchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4Synch_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.mId) == true)
{
string strComparisonOp_mId = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsTeacher4Synch.mId, objCurrEduClsTeacher4Synch_Cond.mId, strComparisonOp_mId);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.AccessSynchDate) == true)
{
string strComparisonOp_AccessSynchDate = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.AccessSynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.AccessSynchDate, objCurrEduClsTeacher4Synch_Cond.AccessSynchDate, strComparisonOp_AccessSynchDate);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.id_EduClsTeacher) == true)
{
string strComparisonOp_id_EduClsTeacher = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_EduClsTeacher];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsTeacher4Synch.id_EduClsTeacher, objCurrEduClsTeacher4Synch_Cond.id_EduClsTeacher, strComparisonOp_id_EduClsTeacher);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.id_CurrEduCls, objCurrEduClsTeacher4Synch_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.id_Teacher, objCurrEduClsTeacher4Synch_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType) == true)
{
string strComparisonOp_id_Pk2EduClsTeacherType = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType, objCurrEduClsTeacher4Synch_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.SchoolTerm, objCurrEduClsTeacher4Synch_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.SchoolYear, objCurrEduClsTeacher4Synch_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.OpenBeginDate) == true)
{
string strComparisonOp_OpenBeginDate = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.OpenBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.OpenBeginDate, objCurrEduClsTeacher4Synch_Cond.OpenBeginDate, strComparisonOp_OpenBeginDate);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.OpenEndDate) == true)
{
string strComparisonOp_OpenEndDate = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.OpenEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.OpenEndDate, objCurrEduClsTeacher4Synch_Cond.OpenEndDate, strComparisonOp_OpenEndDate);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.IpAddress) == true)
{
string strComparisonOp_IpAddress = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.IpAddress, objCurrEduClsTeacher4Synch_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.IsAccessSynch) == true)
{
if (objCurrEduClsTeacher4Synch_Cond.IsAccessSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduClsTeacher4Synch.IsAccessSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduClsTeacher4Synch.IsAccessSynch);
}
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.UpdDate, objCurrEduClsTeacher4Synch_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.UpdUser) == true)
{
string strComparisonOp_UpdUser = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.UpdUser, objCurrEduClsTeacher4Synch_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objCurrEduClsTeacher4Synch_Cond.IsUpdated(conCurrEduClsTeacher4Synch.Memo) == true)
{
string strComparisonOp_Memo = objCurrEduClsTeacher4Synch_Cond.dicFldComparisonOp[conCurrEduClsTeacher4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsTeacher4Synch.Memo, objCurrEduClsTeacher4Synch_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
 if (objCurrEduClsTeacher4SynchEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCurrEduClsTeacher4SynchEN.sf_UpdFldSetStr = objCurrEduClsTeacher4SynchEN.getsf_UpdFldSetStr();
clsCurrEduClsTeacher4SynchWApi.CheckPropertyNew(objCurrEduClsTeacher4SynchEN); 
bool bolResult = clsCurrEduClsTeacher4SynchWApi.UpdateRecord(objCurrEduClsTeacher4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CurrEduClsTeacher4Synch(当前教学班教师_同步), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_id_Teacher(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsTeacher4SynchEN == null) return "";
if (objCurrEduClsTeacher4SynchEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacher4SynchEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Teacher = '{0}'", objCurrEduClsTeacher4SynchEN.id_Teacher);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCurrEduClsTeacher4SynchEN.mId);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacher4SynchEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_Teacher = '{0}'", objCurrEduClsTeacher4SynchEN.id_Teacher);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
try
{
clsCurrEduClsTeacher4SynchWApi.CheckPropertyNew(objCurrEduClsTeacher4SynchEN); 
bool bolResult = clsCurrEduClsTeacher4SynchWApi.AddNewRecord(objCurrEduClsTeacher4SynchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strWhereCond)
{
try
{
clsCurrEduClsTeacher4SynchWApi.CheckPropertyNew(objCurrEduClsTeacher4SynchEN); 
bool bolResult = clsCurrEduClsTeacher4SynchWApi.UpdateWithCondition(objCurrEduClsTeacher4SynchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
 /// 当前教学班教师_同步(CurrEduClsTeacher4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsTeacher4SynchWApi
{
private static readonly string mstrApiControllerName = "CurrEduClsTeacher4SynchApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCurrEduClsTeacher4SynchWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.AccessSynchDate) && GetStrLen(objCurrEduClsTeacher4SynchEN.AccessSynchDate) > 14)
{
 throw new Exception("字段[处理同步日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.id_CurrEduCls) && GetStrLen(objCurrEduClsTeacher4SynchEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.id_Teacher) && GetStrLen(objCurrEduClsTeacher4SynchEN.id_Teacher) > 8)
{
 throw new Exception("字段[教师流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.id_Pk2EduClsTeacherType) && GetStrLen(objCurrEduClsTeacher4SynchEN.id_Pk2EduClsTeacherType) > 4)
{
 throw new Exception("字段[教学班老师角色(主讲,辅导)流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.SchoolTerm) && GetStrLen(objCurrEduClsTeacher4SynchEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.SchoolYear) && GetStrLen(objCurrEduClsTeacher4SynchEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.OpenBeginDate) && GetStrLen(objCurrEduClsTeacher4SynchEN.OpenBeginDate) > 8)
{
 throw new Exception("字段[开放开始日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.OpenEndDate) && GetStrLen(objCurrEduClsTeacher4SynchEN.OpenEndDate) > 8)
{
 throw new Exception("字段[开放结束日期]的长度不能超过8!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.IpAddress) && GetStrLen(objCurrEduClsTeacher4SynchEN.IpAddress) > 50)
{
 throw new Exception("字段[Ip地址]的长度不能超过50!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.UpdDate) && GetStrLen(objCurrEduClsTeacher4SynchEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.UpdUser) && GetStrLen(objCurrEduClsTeacher4SynchEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objCurrEduClsTeacher4SynchEN.Memo) && GetStrLen(objCurrEduClsTeacher4SynchEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCurrEduClsTeacher4SynchEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsTeacher4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN = null;
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
objCurrEduClsTeacher4SynchEN = JsonConvert.DeserializeObject<clsCurrEduClsTeacher4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsTeacher4SynchEN;
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
public static clsCurrEduClsTeacher4SynchEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN = null;
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
objCurrEduClsTeacher4SynchEN = JsonConvert.DeserializeObject<clsCurrEduClsTeacher4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsTeacher4SynchEN;
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
public static clsCurrEduClsTeacher4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN = null;
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
objCurrEduClsTeacher4SynchEN = JsonConvert.DeserializeObject<clsCurrEduClsTeacher4SynchEN>((string)jobjReturn["ReturnObj"]);
return objCurrEduClsTeacher4SynchEN;
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
public static clsCurrEduClsTeacher4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduClsTeacher4SynchEN._CurrTabName_S);
List<clsCurrEduClsTeacher4SynchEN> arrCurrEduClsTeacher4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduClsTeacher4SynchEN> arrCurrEduClsTeacher4SynchObjLst_Sel =
from objCurrEduClsTeacher4SynchEN in arrCurrEduClsTeacher4SynchObjLst_Cache
where objCurrEduClsTeacher4SynchEN.mId == lngmId
select objCurrEduClsTeacher4SynchEN;
if (arrCurrEduClsTeacher4SynchObjLst_Sel.Count() == 0)
{
   clsCurrEduClsTeacher4SynchEN obj = clsCurrEduClsTeacher4SynchWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCurrEduClsTeacher4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsTeacher4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsCurrEduClsTeacher4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacher4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacher4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCurrEduClsTeacher4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacher4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsCurrEduClsTeacher4SynchEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCurrEduClsTeacher4SynchEN._CurrTabName_S);
List<clsCurrEduClsTeacher4SynchEN> arrCurrEduClsTeacher4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCurrEduClsTeacher4SynchEN> arrCurrEduClsTeacher4SynchObjLst_Sel =
from objCurrEduClsTeacher4SynchEN in arrCurrEduClsTeacher4SynchObjLst_Cache
where arrMId.Contains(objCurrEduClsTeacher4SynchEN.mId)
select objCurrEduClsTeacher4SynchEN;
return arrCurrEduClsTeacher4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsTeacher4SynchEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsCurrEduClsTeacher4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacher4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacher4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCurrEduClsTeacher4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacher4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacher4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCurrEduClsTeacher4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacher4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacher4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsTeacher4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacher4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCurrEduClsTeacher4SynchEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCurrEduClsTeacher4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCurrEduClsTeacher4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN = clsCurrEduClsTeacher4SynchWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
public static int DelCurrEduClsTeacher4Synchs(List<string> arrmId)
{
string strAction = "DelCurrEduClsTeacher4Synchs";
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
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
public static int DelCurrEduClsTeacher4SynchsByCond(string strWhereCond)
{
string strAction = "DelCurrEduClsTeacher4SynchsByCond";
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
public static bool AddNewRecord(clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacher4SynchEN>(objCurrEduClsTeacher4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacher4SynchEN>(objCurrEduClsTeacher4SynchEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsTeacher4SynchWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN)
{
if (string.IsNullOrEmpty(objCurrEduClsTeacher4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsTeacher4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacher4SynchEN>(objCurrEduClsTeacher4SynchEN);
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
 /// <param name = "objCurrEduClsTeacher4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCurrEduClsTeacher4SynchEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsTeacher4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCurrEduClsTeacher4SynchEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCurrEduClsTeacher4SynchEN>(objCurrEduClsTeacher4SynchEN);
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
 /// <param name = "objCurrEduClsTeacher4SynchENS">源对象</param>
 /// <param name = "objCurrEduClsTeacher4SynchENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchENS, clsCurrEduClsTeacher4SynchEN objCurrEduClsTeacher4SynchENT)
{
try
{
objCurrEduClsTeacher4SynchENT.mId = objCurrEduClsTeacher4SynchENS.mId; //mId
objCurrEduClsTeacher4SynchENT.AccessSynchDate = objCurrEduClsTeacher4SynchENS.AccessSynchDate; //处理同步日期
objCurrEduClsTeacher4SynchENT.id_EduClsTeacher = objCurrEduClsTeacher4SynchENS.id_EduClsTeacher; //教学班老师流水号
objCurrEduClsTeacher4SynchENT.id_CurrEduCls = objCurrEduClsTeacher4SynchENS.id_CurrEduCls; //当前教学班流水号
objCurrEduClsTeacher4SynchENT.id_Teacher = objCurrEduClsTeacher4SynchENS.id_Teacher; //教师流水号
objCurrEduClsTeacher4SynchENT.id_Pk2EduClsTeacherType = objCurrEduClsTeacher4SynchENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacher4SynchENT.SchoolTerm = objCurrEduClsTeacher4SynchENS.SchoolTerm; //学期
objCurrEduClsTeacher4SynchENT.SchoolYear = objCurrEduClsTeacher4SynchENS.SchoolYear; //学年
objCurrEduClsTeacher4SynchENT.OpenBeginDate = objCurrEduClsTeacher4SynchENS.OpenBeginDate; //开放开始日期
objCurrEduClsTeacher4SynchENT.OpenEndDate = objCurrEduClsTeacher4SynchENS.OpenEndDate; //开放结束日期
objCurrEduClsTeacher4SynchENT.IpAddress = objCurrEduClsTeacher4SynchENS.IpAddress; //Ip地址
objCurrEduClsTeacher4SynchENT.IsAccessSynch = objCurrEduClsTeacher4SynchENS.IsAccessSynch; //是否处理同步
objCurrEduClsTeacher4SynchENT.UpdDate = objCurrEduClsTeacher4SynchENS.UpdDate; //修改日期
objCurrEduClsTeacher4SynchENT.UpdUser = objCurrEduClsTeacher4SynchENS.UpdUser; //修改人
objCurrEduClsTeacher4SynchENT.Memo = objCurrEduClsTeacher4SynchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCurrEduClsTeacher4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCurrEduClsTeacher4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCurrEduClsTeacher4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCurrEduClsTeacher4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCurrEduClsTeacher4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCurrEduClsTeacher4SynchEN.AttributeName)
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
if (clsCurrEduClsTeacher4SynchWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsTeacher4SynchWApi没有刷新缓存机制(clsCurrEduClsTeacher4SynchWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCurrEduClsTeacher4SynchObjLst_Cache == null)
//{
//arrCurrEduClsTeacher4SynchObjLst_Cache = await clsCurrEduClsTeacher4SynchWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCurrEduClsTeacher4SynchEN._CurrTabName_S);
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
if (clsCurrEduClsTeacher4SynchWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduClsTeacher4SynchEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCurrEduClsTeacher4SynchWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsTeacher4SynchEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduClsTeacher4SynchEN._CurrTabName_S);
List<clsCurrEduClsTeacher4SynchEN> arrCurrEduClsTeacher4SynchObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduClsTeacher4SynchObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCurrEduClsTeacher4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCurrEduClsTeacher4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.AccessSynchDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.id_EduClsTeacher, Type.GetType("System.Int64"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.OpenBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.OpenEndDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.IsAccessSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCurrEduClsTeacher4Synch.Memo, Type.GetType("System.String"));
foreach (clsCurrEduClsTeacher4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCurrEduClsTeacher4Synch.mId] = objInFor[conCurrEduClsTeacher4Synch.mId];
objDR[conCurrEduClsTeacher4Synch.AccessSynchDate] = objInFor[conCurrEduClsTeacher4Synch.AccessSynchDate];
objDR[conCurrEduClsTeacher4Synch.id_EduClsTeacher] = objInFor[conCurrEduClsTeacher4Synch.id_EduClsTeacher];
objDR[conCurrEduClsTeacher4Synch.id_CurrEduCls] = objInFor[conCurrEduClsTeacher4Synch.id_CurrEduCls];
objDR[conCurrEduClsTeacher4Synch.id_Teacher] = objInFor[conCurrEduClsTeacher4Synch.id_Teacher];
objDR[conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType] = objInFor[conCurrEduClsTeacher4Synch.id_Pk2EduClsTeacherType];
objDR[conCurrEduClsTeacher4Synch.SchoolTerm] = objInFor[conCurrEduClsTeacher4Synch.SchoolTerm];
objDR[conCurrEduClsTeacher4Synch.SchoolYear] = objInFor[conCurrEduClsTeacher4Synch.SchoolYear];
objDR[conCurrEduClsTeacher4Synch.OpenBeginDate] = objInFor[conCurrEduClsTeacher4Synch.OpenBeginDate];
objDR[conCurrEduClsTeacher4Synch.OpenEndDate] = objInFor[conCurrEduClsTeacher4Synch.OpenEndDate];
objDR[conCurrEduClsTeacher4Synch.IpAddress] = objInFor[conCurrEduClsTeacher4Synch.IpAddress];
objDR[conCurrEduClsTeacher4Synch.IsAccessSynch] = objInFor[conCurrEduClsTeacher4Synch.IsAccessSynch];
objDR[conCurrEduClsTeacher4Synch.UpdDate] = objInFor[conCurrEduClsTeacher4Synch.UpdDate];
objDR[conCurrEduClsTeacher4Synch.UpdUser] = objInFor[conCurrEduClsTeacher4Synch.UpdUser];
objDR[conCurrEduClsTeacher4Synch.Memo] = objInFor[conCurrEduClsTeacher4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 当前教学班教师_同步(CurrEduClsTeacher4Synch)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CurrEduClsTeacher4Synch : clsCommFun4BL
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
clsCurrEduClsTeacher4SynchWApi.ReFreshThisCache();
}
}

}