
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityWApi
 表名:vSetFieldVisibility(01120120)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:46
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
public static class clsvSetFieldVisibilityWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetmId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, long lngmId, string strComparisonOp="")
	{
objvSetFieldVisibilityEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.mId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.mId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.mId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN Setid_School(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convSetFieldVisibility.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convSetFieldVisibility.id_School);
objvSetFieldVisibilityEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.id_School) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.id_School, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.id_School] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetSchoolId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convSetFieldVisibility.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convSetFieldVisibility.SchoolId);
objvSetFieldVisibilityEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.SchoolId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.SchoolId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.SchoolId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetSchoolName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convSetFieldVisibility.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convSetFieldVisibility.SchoolName);
objvSetFieldVisibilityEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.SchoolName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.SchoolName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.SchoolName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convSetFieldVisibility.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convSetFieldVisibility.FuncModuleId);
objvSetFieldVisibilityEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convSetFieldVisibility.FuncModuleName);
objvSetFieldVisibilityEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleName_Sim(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convSetFieldVisibility.FuncModuleName_Sim);
objvSetFieldVisibilityEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleName_Sim) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleEnName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convSetFieldVisibility.FuncModuleEnName);
objvSetFieldVisibilityEN.FuncModuleEnName = strFuncModuleEnName; //FuncModuleEnName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleEnName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleEnName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleEnName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetViewName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 50, convSetFieldVisibility.ViewName);
objvSetFieldVisibilityEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.ViewName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.ViewName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.ViewName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFieldName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldName, 50, convSetFieldVisibility.FieldName);
objvSetFieldVisibilityEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FieldName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FieldName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FieldName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetCaption(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convSetFieldVisibility.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convSetFieldVisibility.Caption);
objvSetFieldVisibilityEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.Caption) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.Caption, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.Caption] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetCtrlType(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strCtrlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtrlType, convSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(strCtrlType, 50, convSetFieldVisibility.CtrlType);
objvSetFieldVisibilityEN.CtrlType = strCtrlType; //控件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.CtrlType) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.CtrlType, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.CtrlType] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetIsVisible(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, bool bolIsVisible, string strComparisonOp="")
	{
objvSetFieldVisibilityEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.IsVisible) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.IsVisible, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.IsVisible] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetUpdDate(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSetFieldVisibility.UpdDate);
objvSetFieldVisibilityEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.UpdDate) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.UpdDate, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.UpdDate] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetUpdUserId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSetFieldVisibility.UpdUserId);
objvSetFieldVisibilityEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.UpdUserId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.UpdUserId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.UpdUserId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetMemo(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSetFieldVisibility.Memo);
objvSetFieldVisibilityEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.Memo) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.Memo, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.Memo] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSetFieldVisibilityEN objvSetFieldVisibility_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.mId) == true)
{
string strComparisonOp_mId = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convSetFieldVisibility.mId, objvSetFieldVisibility_Cond.mId, strComparisonOp_mId);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.id_School) == true)
{
string strComparisonOp_id_School = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.id_School, objvSetFieldVisibility_Cond.id_School, strComparisonOp_id_School);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.SchoolId, objvSetFieldVisibility_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.SchoolName, objvSetFieldVisibility_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleId, objvSetFieldVisibility_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleName, objvSetFieldVisibility_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleName_Sim, objvSetFieldVisibility_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.FuncModuleEnName) == true)
{
string strComparisonOp_FuncModuleEnName = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleEnName, objvSetFieldVisibility_Cond.FuncModuleEnName, strComparisonOp_FuncModuleEnName);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.ViewName) == true)
{
string strComparisonOp_ViewName = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.ViewName, objvSetFieldVisibility_Cond.ViewName, strComparisonOp_ViewName);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.FieldName) == true)
{
string strComparisonOp_FieldName = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FieldName, objvSetFieldVisibility_Cond.FieldName, strComparisonOp_FieldName);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.Caption) == true)
{
string strComparisonOp_Caption = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.Caption, objvSetFieldVisibility_Cond.Caption, strComparisonOp_Caption);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.CtrlType) == true)
{
string strComparisonOp_CtrlType = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.CtrlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.CtrlType, objvSetFieldVisibility_Cond.CtrlType, strComparisonOp_CtrlType);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.IsVisible) == true)
{
if (objvSetFieldVisibility_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSetFieldVisibility.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSetFieldVisibility.IsVisible);
}
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.UpdDate, objvSetFieldVisibility_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.UpdUserId, objvSetFieldVisibility_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvSetFieldVisibility_Cond.IsUpdated(convSetFieldVisibility.Memo) == true)
{
string strComparisonOp_Memo = objvSetFieldVisibility_Cond.dicFldComparisonOp[convSetFieldVisibility.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.Memo, objvSetFieldVisibility_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSetFieldVisibilityWApi
{
private static readonly string mstrApiControllerName = "vSetFieldVisibilityApi";

 public clsvSetFieldVisibilityWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSetFieldVisibilityEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = null;
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
objvSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsvSetFieldVisibilityEN>((string)jobjReturn["ReturnObj"]);
return objvSetFieldVisibilityEN;
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
public static clsvSetFieldVisibilityEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = null;
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
objvSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsvSetFieldVisibilityEN>((string)jobjReturn["ReturnObj"]);
return objvSetFieldVisibilityEN;
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
public static clsvSetFieldVisibilityEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = null;
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
objvSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsvSetFieldVisibilityEN>((string)jobjReturn["ReturnObj"]);
return objvSetFieldVisibilityEN;
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
public static clsvSetFieldVisibilityEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName_S);
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Sel =
from objvSetFieldVisibilityEN in arrvSetFieldVisibilityObjLst_Cache
where objvSetFieldVisibilityEN.mId == lngmId
select objvSetFieldVisibilityEN;
if (arrvSetFieldVisibilityObjLst_Sel.Count() == 0)
{
   clsvSetFieldVisibilityEN obj = clsvSetFieldVisibilityWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSetFieldVisibilityObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvSetFieldVisibilityEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName_S);
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Sel =
from objvSetFieldVisibilityEN in arrvSetFieldVisibilityObjLst_Cache
where arrMId.Contains(objvSetFieldVisibilityEN.mId)
select objvSetFieldVisibilityEN;
return arrvSetFieldVisibilityObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSetFieldVisibilityEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvSetFieldVisibilityENS">源对象</param>
 /// <param name = "objvSetFieldVisibilityENT">目标对象</param>
 public static void CopyTo(clsvSetFieldVisibilityEN objvSetFieldVisibilityENS, clsvSetFieldVisibilityEN objvSetFieldVisibilityENT)
{
try
{
objvSetFieldVisibilityENT.mId = objvSetFieldVisibilityENS.mId; //mId
objvSetFieldVisibilityENT.id_School = objvSetFieldVisibilityENS.id_School; //学校流水号
objvSetFieldVisibilityENT.SchoolId = objvSetFieldVisibilityENS.SchoolId; //学校编号
objvSetFieldVisibilityENT.SchoolName = objvSetFieldVisibilityENS.SchoolName; //学校名称
objvSetFieldVisibilityENT.FuncModuleId = objvSetFieldVisibilityENS.FuncModuleId; //功能模块Id
objvSetFieldVisibilityENT.FuncModuleName = objvSetFieldVisibilityENS.FuncModuleName; //功能模块名称
objvSetFieldVisibilityENT.FuncModuleName_Sim = objvSetFieldVisibilityENS.FuncModuleName_Sim; //功能模块简称
objvSetFieldVisibilityENT.FuncModuleEnName = objvSetFieldVisibilityENS.FuncModuleEnName; //FuncModuleEnName
objvSetFieldVisibilityENT.ViewName = objvSetFieldVisibilityENS.ViewName; //界面名称
objvSetFieldVisibilityENT.FieldName = objvSetFieldVisibilityENS.FieldName; //字段名
objvSetFieldVisibilityENT.Caption = objvSetFieldVisibilityENS.Caption; //标题
objvSetFieldVisibilityENT.CtrlType = objvSetFieldVisibilityENS.CtrlType; //控件类型
objvSetFieldVisibilityENT.IsVisible = objvSetFieldVisibilityENS.IsVisible; //是否显示
objvSetFieldVisibilityENT.UpdDate = objvSetFieldVisibilityENS.UpdDate; //修改日期
objvSetFieldVisibilityENT.UpdUserId = objvSetFieldVisibilityENS.UpdUserId; //修改用户Id
objvSetFieldVisibilityENT.Memo = objvSetFieldVisibilityENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvSetFieldVisibilityEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSetFieldVisibilityEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSetFieldVisibilityEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSetFieldVisibilityEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSetFieldVisibilityEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSetFieldVisibilityEN.AttributeName)
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
if (clsXzSchoolWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolWApi没有刷新缓存机制(clsXzSchoolWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSetFieldVisibilityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSetFieldVisibilityWApi没有刷新缓存机制(clsSetFieldVisibilityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvSetFieldVisibilityObjLst_Cache == null)
//{
//arrvSetFieldVisibilityObjLst_Cache = await clsvSetFieldVisibilityWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName_S);
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
public static List<clsvSetFieldVisibilityEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName_S);
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSetFieldVisibilityObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSetFieldVisibilityEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSetFieldVisibility.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convSetFieldVisibility.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FieldName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.CtrlType, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSetFieldVisibility.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.Memo, Type.GetType("System.String"));
foreach (clsvSetFieldVisibilityEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSetFieldVisibility.mId] = objInFor[convSetFieldVisibility.mId];
objDR[convSetFieldVisibility.id_School] = objInFor[convSetFieldVisibility.id_School];
objDR[convSetFieldVisibility.SchoolId] = objInFor[convSetFieldVisibility.SchoolId];
objDR[convSetFieldVisibility.SchoolName] = objInFor[convSetFieldVisibility.SchoolName];
objDR[convSetFieldVisibility.FuncModuleId] = objInFor[convSetFieldVisibility.FuncModuleId];
objDR[convSetFieldVisibility.FuncModuleName] = objInFor[convSetFieldVisibility.FuncModuleName];
objDR[convSetFieldVisibility.FuncModuleName_Sim] = objInFor[convSetFieldVisibility.FuncModuleName_Sim];
objDR[convSetFieldVisibility.FuncModuleEnName] = objInFor[convSetFieldVisibility.FuncModuleEnName];
objDR[convSetFieldVisibility.ViewName] = objInFor[convSetFieldVisibility.ViewName];
objDR[convSetFieldVisibility.FieldName] = objInFor[convSetFieldVisibility.FieldName];
objDR[convSetFieldVisibility.Caption] = objInFor[convSetFieldVisibility.Caption];
objDR[convSetFieldVisibility.CtrlType] = objInFor[convSetFieldVisibility.CtrlType];
objDR[convSetFieldVisibility.IsVisible] = objInFor[convSetFieldVisibility.IsVisible];
objDR[convSetFieldVisibility.UpdDate] = objInFor[convSetFieldVisibility.UpdDate];
objDR[convSetFieldVisibility.UpdUserId] = objInFor[convSetFieldVisibility.UpdUserId];
objDR[convSetFieldVisibility.Memo] = objInFor[convSetFieldVisibility.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}