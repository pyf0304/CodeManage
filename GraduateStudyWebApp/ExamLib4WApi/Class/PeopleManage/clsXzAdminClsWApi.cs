
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzAdminClsWApi
 表名:XzAdminCls(01120194)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:43
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理
 模块英文名:PeopleManage
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
public static class clsXzAdminClsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN Setid_AdminCls(this clsXzAdminClsEN objXzAdminClsEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, conXzAdminCls.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, conXzAdminCls.id_AdminCls);
objXzAdminClsEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.id_AdminCls) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.id_AdminCls, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.id_AdminCls] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN SetAdminClsName(this clsXzAdminClsEN objXzAdminClsEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, conXzAdminCls.AdminClsName);
objXzAdminClsEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.AdminClsName) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.AdminClsName, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.AdminClsName] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN Setid_XzMajor(this clsXzAdminClsEN objXzAdminClsEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, conXzAdminCls.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conXzAdminCls.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conXzAdminCls.id_XzMajor);
objXzAdminClsEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.id_XzMajor) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.id_XzMajor, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.id_XzMajor] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN Setid_XzCollege(this clsXzAdminClsEN objXzAdminClsEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, conXzAdminCls.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conXzAdminCls.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conXzAdminCls.id_XzCollege);
objXzAdminClsEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.id_XzCollege) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.id_XzCollege, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.id_XzCollege] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN Setid_UniZone(this clsXzAdminClsEN objXzAdminClsEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, conXzAdminCls.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, conXzAdminCls.id_UniZone);
objXzAdminClsEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.id_UniZone) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.id_UniZone, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.id_UniZone] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN SetCurrentStuQty(this clsXzAdminClsEN objXzAdminClsEN, int intCurrentStuQty, string strComparisonOp="")
	{
objXzAdminClsEN.CurrentStuQty = intCurrentStuQty; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.CurrentStuQty) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.CurrentStuQty, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.CurrentStuQty] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN Setid_GradeBase(this clsXzAdminClsEN objXzAdminClsEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_GradeBase, conXzAdminCls.id_GradeBase);
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, conXzAdminCls.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, conXzAdminCls.id_GradeBase);
objXzAdminClsEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.id_GradeBase) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.id_GradeBase, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.id_GradeBase] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN SetAdminClsId(this clsXzAdminClsEN objXzAdminClsEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, conXzAdminCls.AdminClsId);
objXzAdminClsEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.AdminClsId) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.AdminClsId, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.AdminClsId] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN Setid_AdminClsType(this clsXzAdminClsEN objXzAdminClsEN, string strid_AdminClsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminClsType, 4, conXzAdminCls.id_AdminClsType);
clsCheckSql.CheckFieldForeignKey(strid_AdminClsType, 4, conXzAdminCls.id_AdminClsType);
objXzAdminClsEN.id_AdminClsType = strid_AdminClsType; //行政班级类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.id_AdminClsType) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.id_AdminClsType, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.id_AdminClsType] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN SetAdminClsIndex(this clsXzAdminClsEN objXzAdminClsEN, int intAdminClsIndex, string strComparisonOp="")
	{
objXzAdminClsEN.AdminClsIndex = intAdminClsIndex; //AdminClsIndex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.AdminClsIndex) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.AdminClsIndex, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.AdminClsIndex] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN SetMemo(this clsXzAdminClsEN objXzAdminClsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzAdminCls.Memo);
objXzAdminClsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.Memo) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.Memo, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.Memo] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN SetModifyUserID(this clsXzAdminClsEN objXzAdminClsEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conXzAdminCls.ModifyUserID);
objXzAdminClsEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.ModifyUserID) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.ModifyUserID, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.ModifyUserID] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzAdminClsEN SetModifyDate(this clsXzAdminClsEN objXzAdminClsEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzAdminCls.ModifyDate);
objXzAdminClsEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.ModifyDate) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.ModifyDate, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.ModifyDate] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzAdminClsEN objXzAdminCls_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.id_AdminCls, objXzAdminCls_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.AdminClsName, objXzAdminCls_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.id_XzMajor, objXzAdminCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.id_XzCollege, objXzAdminCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.id_UniZone, objXzAdminCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.CurrentStuQty) == true)
{
string strComparisonOp_CurrentStuQty = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conXzAdminCls.CurrentStuQty, objXzAdminCls_Cond.CurrentStuQty, strComparisonOp_CurrentStuQty);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.id_GradeBase, objXzAdminCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.AdminClsId, objXzAdminCls_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.id_AdminClsType) == true)
{
string strComparisonOp_id_AdminClsType = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.id_AdminClsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.id_AdminClsType, objXzAdminCls_Cond.id_AdminClsType, strComparisonOp_id_AdminClsType);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.AdminClsIndex) == true)
{
string strComparisonOp_AdminClsIndex = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.AdminClsIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conXzAdminCls.AdminClsIndex, objXzAdminCls_Cond.AdminClsIndex, strComparisonOp_AdminClsIndex);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.Memo) == true)
{
string strComparisonOp_Memo = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.Memo, objXzAdminCls_Cond.Memo, strComparisonOp_Memo);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.ModifyUserID, objXzAdminCls_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objXzAdminCls_Cond.IsUpdated(conXzAdminCls.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objXzAdminCls_Cond.dicFldComparisonOp[conXzAdminCls.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.ModifyDate, objXzAdminCls_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzAdminClsEN objXzAdminClsEN)
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.id_AdminCls) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzAdminClsEN.sf_UpdFldSetStr = objXzAdminClsEN.getsf_UpdFldSetStr();
clsXzAdminClsWApi.CheckPropertyNew(objXzAdminClsEN); 
bool bolResult = clsXzAdminClsWApi.UpdateRecord(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsWApi.ReFreshCache();
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzAdminClsEN objXzAdminClsEN)
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.id_AdminCls) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzAdminClsWApi.IsExist(objXzAdminClsEN.id_AdminCls) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objXzAdminClsEN.id_AdminCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsXzAdminClsWApi.CheckPropertyNew(objXzAdminClsEN); 
bool bolResult = clsXzAdminClsWApi.AddNewRecord(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsWApi.ReFreshCache();
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzAdminClsEN objXzAdminClsEN)
{
try
{
clsXzAdminClsWApi.CheckPropertyNew(objXzAdminClsEN); 
string strid_AdminCls = clsXzAdminClsWApi.AddNewRecordWithMaxId(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsWApi.ReFreshCache();
return strid_AdminCls;
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
 /// <param name = "objXzAdminClsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzAdminClsEN objXzAdminClsEN, string strWhereCond)
{
try
{
clsXzAdminClsWApi.CheckPropertyNew(objXzAdminClsEN); 
bool bolResult = clsXzAdminClsWApi.UpdateWithCondition(objXzAdminClsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsWApi.ReFreshCache();
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
 /// 行政班(XzAdminCls)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzAdminClsWApi
{
private static readonly string mstrApiControllerName = "XzAdminClsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsXzAdminClsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_AdminCls(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[行政班]...","0");
List<clsXzAdminClsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_AdminCls";
objDDL.DataTextField="AdminClsName";
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
public static void BindCbo_id_AdminCls(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzAdminCls.id_AdminCls); 
List<clsXzAdminClsEN> arrObjLst = clsXzAdminClsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN()
{
id_AdminCls = "0",
AdminClsName = "选[行政班]..."
};
arrObjLst.Insert(0, objXzAdminClsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzAdminCls.id_AdminCls;
objComboBox.DisplayMember = conXzAdminCls.AdminClsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzAdminClsEN objXzAdminClsEN)
{
if (!Object.Equals(null, objXzAdminClsEN.id_AdminCls) && GetStrLen(objXzAdminClsEN.id_AdminCls) > 8)
{
 throw new Exception("字段[行政班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objXzAdminClsEN.AdminClsName) && GetStrLen(objXzAdminClsEN.AdminClsName) > 100)
{
 throw new Exception("字段[行政班名称]的长度不能超过100!");
}
if (!Object.Equals(null, objXzAdminClsEN.id_XzMajor) && GetStrLen(objXzAdminClsEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objXzAdminClsEN.id_XzCollege) && GetStrLen(objXzAdminClsEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzAdminClsEN.id_UniZone) && GetStrLen(objXzAdminClsEN.id_UniZone) > 4)
{
 throw new Exception("字段[校区流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzAdminClsEN.id_GradeBase) && GetStrLen(objXzAdminClsEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzAdminClsEN.AdminClsId) && GetStrLen(objXzAdminClsEN.AdminClsId) > 8)
{
 throw new Exception("字段[行政班代号]的长度不能超过8!");
}
if (!Object.Equals(null, objXzAdminClsEN.id_AdminClsType) && GetStrLen(objXzAdminClsEN.id_AdminClsType) > 4)
{
 throw new Exception("字段[行政班级类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzAdminClsEN.Memo) && GetStrLen(objXzAdminClsEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objXzAdminClsEN.ModifyUserID) && GetStrLen(objXzAdminClsEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objXzAdminClsEN.ModifyDate) && GetStrLen(objXzAdminClsEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
 objXzAdminClsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_AdminCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzAdminClsEN GetObjByid_AdminCls(string strid_AdminCls)
{
string strAction = "GetObjByid_AdminCls";
string strErrMsg = string.Empty;
string strResult = "";
clsXzAdminClsEN objXzAdminClsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_AdminCls"] = strid_AdminCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzAdminClsEN = JsonConvert.DeserializeObject<clsXzAdminClsEN>((string)jobjReturn["ReturnObj"]);
return objXzAdminClsEN;
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
 /// <param name = "strid_AdminCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzAdminClsEN GetObjByid_AdminCls_WA_Cache(string strid_AdminCls)
{
string strAction = "GetObjByid_AdminCls_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsXzAdminClsEN objXzAdminClsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_AdminCls"] = strid_AdminCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzAdminClsEN = JsonConvert.DeserializeObject<clsXzAdminClsEN>((string)jobjReturn["ReturnObj"]);
return objXzAdminClsEN;
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
public static clsXzAdminClsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsXzAdminClsEN objXzAdminClsEN = null;
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
objXzAdminClsEN = JsonConvert.DeserializeObject<clsXzAdminClsEN>((string)jobjReturn["ReturnObj"]);
return objXzAdminClsEN;
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
 /// <param name = "strid_AdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzAdminClsEN GetObjByid_AdminCls_Cache(string strid_AdminCls)
{
if (string.IsNullOrEmpty(strid_AdminCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName_S);
List<clsXzAdminClsEN> arrXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel =
from objXzAdminClsEN in arrXzAdminClsObjLst_Cache
where objXzAdminClsEN.id_AdminCls == strid_AdminCls
select objXzAdminClsEN;
if (arrXzAdminClsObjLst_Sel.Count() == 0)
{
   clsXzAdminClsEN obj = clsXzAdminClsWApi.GetObjByid_AdminCls(strid_AdminCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzAdminClsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_AdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAdminClsNameByid_AdminCls_Cache(string strid_AdminCls)
{
if (string.IsNullOrEmpty(strid_AdminCls) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName_S);
List<clsXzAdminClsEN> arrXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel1 =
from objXzAdminClsEN in arrXzAdminClsObjLst_Cache
where objXzAdminClsEN.id_AdminCls == strid_AdminCls
select objXzAdminClsEN;
List <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel = new List<clsXzAdminClsEN>();
foreach (clsXzAdminClsEN obj in arrXzAdminClsObjLst_Sel1)
{
arrXzAdminClsObjLst_Sel.Add(obj);
}
if (arrXzAdminClsObjLst_Sel.Count > 0)
{
return arrXzAdminClsObjLst_Sel[0].AdminClsName;
}
string strErrMsgForGetObjById = string.Format("在XzAdminCls对象缓存列表中,找不到记录[id_AdminCls = {0}](函数:{1})", strid_AdminCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzAdminClsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_AdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_AdminCls_Cache(string strid_AdminCls)
{
if (string.IsNullOrEmpty(strid_AdminCls) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName_S);
List<clsXzAdminClsEN> arrXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel1 =
from objXzAdminClsEN in arrXzAdminClsObjLst_Cache
where objXzAdminClsEN.id_AdminCls == strid_AdminCls
select objXzAdminClsEN;
List <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel = new List<clsXzAdminClsEN>();
foreach (clsXzAdminClsEN obj in arrXzAdminClsObjLst_Sel1)
{
arrXzAdminClsObjLst_Sel.Add(obj);
}
if (arrXzAdminClsObjLst_Sel.Count > 0)
{
return arrXzAdminClsObjLst_Sel[0].AdminClsName;
}
string strErrMsgForGetObjById = string.Format("在XzAdminCls对象缓存列表中,找不到记录的相关名称[id_AdminCls = {0}](函数:{1})", strid_AdminCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzAdminClsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLst(string strWhereCond)
{
 List<clsXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzAdminClsEN> GetObjLstById_AdminClsLst(List<string> arrId_AdminCls)
{
 List<clsXzAdminClsEN> arrObjLst = null; 
string strAction = "GetObjLstById_AdminClsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_AdminCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_AdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsXzAdminClsEN> GetObjLstById_AdminClsLst_Cache(List<string> arrId_AdminCls)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName_S);
List<clsXzAdminClsEN> arrXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel =
from objXzAdminClsEN in arrXzAdminClsObjLst_Cache
where arrId_AdminCls.Contains(objXzAdminClsEN.id_AdminCls)
select objXzAdminClsEN;
return arrXzAdminClsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLstById_AdminClsLst_WA_Cache(List<string> arrId_AdminCls)
{
 List<clsXzAdminClsEN> arrObjLst = null; 
string strAction = "GetObjLstById_AdminClsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_AdminCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzAdminClsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzAdminClsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzAdminClsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzAdminClsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_AdminCls)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsXzAdminClsEN objXzAdminClsEN = clsXzAdminClsWApi.GetObjByid_AdminCls(strid_AdminCls);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_AdminCls.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzAdminClsWApi.ReFreshCache();
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
public static int DelXzAdminClss(List<string> arrid_AdminCls)
{
string strAction = "DelXzAdminClss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_AdminCls);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzAdminClsWApi.ReFreshCache();
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
public static int DelXzAdminClssByCond(string strWhereCond)
{
string strAction = "DelXzAdminClssByCond";
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
public static bool AddNewRecord(clsXzAdminClsEN objXzAdminClsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzAdminClsEN>(objXzAdminClsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsXzAdminClsEN objXzAdminClsEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzAdminClsEN>(objXzAdminClsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsWApi.ReFreshCache();
var strid_AdminCls = (string)jobjReturn["ReturnStr"];
return strid_AdminCls;
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
public static bool UpdateRecord(clsXzAdminClsEN objXzAdminClsEN)
{
if (string.IsNullOrEmpty(objXzAdminClsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzAdminClsEN.id_AdminCls, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzAdminClsEN>(objXzAdminClsEN);
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
 /// <param name = "objXzAdminClsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzAdminClsEN objXzAdminClsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzAdminClsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzAdminClsEN.id_AdminCls, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzAdminClsEN.id_AdminCls, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzAdminClsEN>(objXzAdminClsEN);
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
public static bool IsExist(string strid_AdminCls)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_AdminCls"] = strid_AdminCls
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
 /// <param name = "objXzAdminClsENS">源对象</param>
 /// <param name = "objXzAdminClsENT">目标对象</param>
 public static void CopyTo(clsXzAdminClsEN objXzAdminClsENS, clsXzAdminClsEN objXzAdminClsENT)
{
try
{
objXzAdminClsENT.id_AdminCls = objXzAdminClsENS.id_AdminCls; //行政班流水号
objXzAdminClsENT.AdminClsName = objXzAdminClsENS.AdminClsName; //行政班名称
objXzAdminClsENT.id_XzMajor = objXzAdminClsENS.id_XzMajor; //专业流水号
objXzAdminClsENT.id_XzCollege = objXzAdminClsENS.id_XzCollege; //学院流水号
objXzAdminClsENT.id_UniZone = objXzAdminClsENS.id_UniZone; //校区流水号
objXzAdminClsENT.CurrentStuQty = objXzAdminClsENS.CurrentStuQty; //当前学生数
objXzAdminClsENT.id_GradeBase = objXzAdminClsENS.id_GradeBase; //年级流水号
objXzAdminClsENT.AdminClsId = objXzAdminClsENS.AdminClsId; //行政班代号
objXzAdminClsENT.id_AdminClsType = objXzAdminClsENS.id_AdminClsType; //行政班级类型流水号
objXzAdminClsENT.AdminClsIndex = objXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objXzAdminClsENT.Memo = objXzAdminClsENS.Memo; //备注
objXzAdminClsENT.ModifyUserID = objXzAdminClsENS.ModifyUserID; //修改人
objXzAdminClsENT.ModifyDate = objXzAdminClsENS.ModifyDate; //修改日期
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
public static DataTable ToDataTable(List<clsXzAdminClsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzAdminClsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzAdminClsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzAdminClsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzAdminClsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzAdminClsEN.AttributeName)
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
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_AdminCls");
//if (arrXzAdminClsObjLst_Cache == null)
//{
//arrXzAdminClsObjLst_Cache = await clsXzAdminClsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName_S);
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
if (clsXzAdminClsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzAdminClsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName_S);
List<clsXzAdminClsEN> arrXzAdminClsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzAdminClsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzAdminClsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzAdminCls.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.CurrentStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzAdminCls.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.id_AdminClsType, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.AdminClsIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzAdminCls.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conXzAdminCls.ModifyDate, Type.GetType("System.String"));
foreach (clsXzAdminClsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzAdminCls.id_AdminCls] = objInFor[conXzAdminCls.id_AdminCls];
objDR[conXzAdminCls.AdminClsName] = objInFor[conXzAdminCls.AdminClsName];
objDR[conXzAdminCls.id_XzMajor] = objInFor[conXzAdminCls.id_XzMajor];
objDR[conXzAdminCls.id_XzCollege] = objInFor[conXzAdminCls.id_XzCollege];
objDR[conXzAdminCls.id_UniZone] = objInFor[conXzAdminCls.id_UniZone];
objDR[conXzAdminCls.CurrentStuQty] = objInFor[conXzAdminCls.CurrentStuQty];
objDR[conXzAdminCls.id_GradeBase] = objInFor[conXzAdminCls.id_GradeBase];
objDR[conXzAdminCls.AdminClsId] = objInFor[conXzAdminCls.AdminClsId];
objDR[conXzAdminCls.id_AdminClsType] = objInFor[conXzAdminCls.id_AdminClsType];
objDR[conXzAdminCls.AdminClsIndex] = objInFor[conXzAdminCls.AdminClsIndex];
objDR[conXzAdminCls.Memo] = objInFor[conXzAdminCls.Memo];
objDR[conXzAdminCls.ModifyUserID] = objInFor[conXzAdminCls.ModifyUserID];
objDR[conXzAdminCls.ModifyDate] = objInFor[conXzAdminCls.ModifyDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 行政班(XzAdminCls)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4XzAdminCls : clsCommFun4BL
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
clsXzAdminClsWApi.ReFreshThisCache();
clsvXzAdminClsWApi.ReFreshThisCache();
}
}

}