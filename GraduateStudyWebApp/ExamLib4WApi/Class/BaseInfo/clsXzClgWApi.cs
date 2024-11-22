
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzClgWApi
 表名:XzClg(01120064)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:57
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
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
public static class clsXzClgWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN Setid_XzCollege(this clsXzClgEN objXzClgEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conXzClg.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conXzClg.id_XzCollege);
objXzClgEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.id_XzCollege) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.id_XzCollege, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.id_XzCollege] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetCollegeID(this clsXzClgEN objXzClgEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, conXzClg.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, conXzClg.CollegeID);
objXzClgEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeID) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeID, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeID] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetCollegeName(this clsXzClgEN objXzClgEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, conXzClg.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, conXzClg.CollegeName);
objXzClgEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeName) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeName, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeName] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetCollegeIdInGP(this clsXzClgEN objXzClgEN, string strCollegeIdInGP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeIdInGP, 6, conXzClg.CollegeIdInGP);
objXzClgEN.CollegeIdInGP = strCollegeIdInGP; //CollegeIdInGP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeIdInGP) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeIdInGP, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeIdInGP] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetClgEnglishName(this clsXzClgEN objXzClgEN, string strClgEnglishName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClgEnglishName, 60, conXzClg.ClgEnglishName);
objXzClgEN.ClgEnglishName = strClgEnglishName; //ClgEnglishName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.ClgEnglishName) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.ClgEnglishName, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.ClgEnglishName] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetCollegeNameA(this clsXzClgEN objXzClgEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeNameA, conXzClg.CollegeNameA);
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, conXzClg.CollegeNameA);
objXzClgEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeNameA) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeNameA, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeNameA] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetPhoneNumber(this clsXzClgEN objXzClgEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conXzClg.PhoneNumber);
objXzClgEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.PhoneNumber) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.PhoneNumber, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.PhoneNumber] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetWebSite(this clsXzClgEN objXzClgEN, string strWebSite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSite, 60, conXzClg.WebSite);
objXzClgEN.WebSite = strWebSite; //个人主页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.WebSite) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.WebSite, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.WebSite] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN Setid_School(this clsXzClgEN objXzClgEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, conXzClg.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, conXzClg.id_School);
objXzClgEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.id_School) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.id_School, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.id_School] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN Setid_Uni(this clsXzClgEN objXzClgEN, string strid_Uni, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Uni, 4, conXzClg.id_Uni);
clsCheckSql.CheckFieldForeignKey(strid_Uni, 4, conXzClg.id_Uni);
objXzClgEN.id_Uni = strid_Uni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.id_Uni) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.id_Uni, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.id_Uni] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetIsVisible4Tea(this clsXzClgEN objXzClgEN, bool bolIsVisible4Tea, string strComparisonOp="")
	{
objXzClgEN.IsVisible4Tea = bolIsVisible4Tea; //IsVisible4Tea
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.IsVisible4Tea) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.IsVisible4Tea, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.IsVisible4Tea] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetIsVisible(this clsXzClgEN objXzClgEN, bool bolIsVisible, string strComparisonOp="")
	{
objXzClgEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.IsVisible) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.IsVisible, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.IsVisible] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetOrderNum(this clsXzClgEN objXzClgEN, int intOrderNum, string strComparisonOp="")
	{
objXzClgEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.OrderNum) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.OrderNum, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.OrderNum] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetModifyDate(this clsXzClgEN objXzClgEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzClg.ModifyDate);
objXzClgEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.ModifyDate) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.ModifyDate, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.ModifyDate] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetModifyUserID(this clsXzClgEN objXzClgEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conXzClg.ModifyUserID);
objXzClgEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.ModifyUserID) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.ModifyUserID, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.ModifyUserID] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzClgEN SetMemo(this clsXzClgEN objXzClgEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzClg.Memo);
objXzClgEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.Memo) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.Memo, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.Memo] = strComparisonOp;
}
}
return objXzClgEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzClgEN objXzClg_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzClg_Cond.IsUpdated(conXzClg.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objXzClg_Cond.dicFldComparisonOp[conXzClg.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.id_XzCollege, objXzClg_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objXzClg_Cond.IsUpdated(conXzClg.CollegeID) == true)
{
string strComparisonOp_CollegeID = objXzClg_Cond.dicFldComparisonOp[conXzClg.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeID, objXzClg_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objXzClg_Cond.IsUpdated(conXzClg.CollegeName) == true)
{
string strComparisonOp_CollegeName = objXzClg_Cond.dicFldComparisonOp[conXzClg.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeName, objXzClg_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objXzClg_Cond.IsUpdated(conXzClg.CollegeIdInGP) == true)
{
string strComparisonOp_CollegeIdInGP = objXzClg_Cond.dicFldComparisonOp[conXzClg.CollegeIdInGP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeIdInGP, objXzClg_Cond.CollegeIdInGP, strComparisonOp_CollegeIdInGP);
}
if (objXzClg_Cond.IsUpdated(conXzClg.ClgEnglishName) == true)
{
string strComparisonOp_ClgEnglishName = objXzClg_Cond.dicFldComparisonOp[conXzClg.ClgEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.ClgEnglishName, objXzClg_Cond.ClgEnglishName, strComparisonOp_ClgEnglishName);
}
if (objXzClg_Cond.IsUpdated(conXzClg.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objXzClg_Cond.dicFldComparisonOp[conXzClg.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeNameA, objXzClg_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objXzClg_Cond.IsUpdated(conXzClg.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objXzClg_Cond.dicFldComparisonOp[conXzClg.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.PhoneNumber, objXzClg_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objXzClg_Cond.IsUpdated(conXzClg.WebSite) == true)
{
string strComparisonOp_WebSite = objXzClg_Cond.dicFldComparisonOp[conXzClg.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.WebSite, objXzClg_Cond.WebSite, strComparisonOp_WebSite);
}
if (objXzClg_Cond.IsUpdated(conXzClg.id_School) == true)
{
string strComparisonOp_id_School = objXzClg_Cond.dicFldComparisonOp[conXzClg.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.id_School, objXzClg_Cond.id_School, strComparisonOp_id_School);
}
if (objXzClg_Cond.IsUpdated(conXzClg.id_Uni) == true)
{
string strComparisonOp_id_Uni = objXzClg_Cond.dicFldComparisonOp[conXzClg.id_Uni];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.id_Uni, objXzClg_Cond.id_Uni, strComparisonOp_id_Uni);
}
if (objXzClg_Cond.IsUpdated(conXzClg.IsVisible4Tea) == true)
{
if (objXzClg_Cond.IsVisible4Tea == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzClg.IsVisible4Tea);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzClg.IsVisible4Tea);
}
}
if (objXzClg_Cond.IsUpdated(conXzClg.IsVisible) == true)
{
if (objXzClg_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzClg.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzClg.IsVisible);
}
}
if (objXzClg_Cond.IsUpdated(conXzClg.OrderNum) == true)
{
string strComparisonOp_OrderNum = objXzClg_Cond.dicFldComparisonOp[conXzClg.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conXzClg.OrderNum, objXzClg_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objXzClg_Cond.IsUpdated(conXzClg.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objXzClg_Cond.dicFldComparisonOp[conXzClg.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.ModifyDate, objXzClg_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objXzClg_Cond.IsUpdated(conXzClg.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objXzClg_Cond.dicFldComparisonOp[conXzClg.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.ModifyUserID, objXzClg_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objXzClg_Cond.IsUpdated(conXzClg.Memo) == true)
{
string strComparisonOp_Memo = objXzClg_Cond.dicFldComparisonOp[conXzClg.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.Memo, objXzClg_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzClgEN objXzClgEN)
{
 if (string.IsNullOrEmpty(objXzClgEN.id_XzCollege) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzClgEN.sf_UpdFldSetStr = objXzClgEN.getsf_UpdFldSetStr();
clsXzClgWApi.CheckPropertyNew(objXzClgEN); 
bool bolResult = clsXzClgWApi.UpdateRecord(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgWApi.ReFreshCache();
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzClgEN objXzClgEN)
{
 if (string.IsNullOrEmpty(objXzClgEN.id_XzCollege) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzClgWApi.IsExist(objXzClgEN.id_XzCollege) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objXzClgEN.id_XzCollege, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsXzClgWApi.CheckPropertyNew(objXzClgEN); 
bool bolResult = clsXzClgWApi.AddNewRecord(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgWApi.ReFreshCache();
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzClgEN objXzClgEN)
{
try
{
clsXzClgWApi.CheckPropertyNew(objXzClgEN); 
string strid_XzCollege = clsXzClgWApi.AddNewRecordWithMaxId(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgWApi.ReFreshCache();
return strid_XzCollege;
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
 /// <param name = "objXzClgEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzClgEN objXzClgEN, string strWhereCond)
{
try
{
clsXzClgWApi.CheckPropertyNew(objXzClgEN); 
bool bolResult = clsXzClgWApi.UpdateWithCondition(objXzClgEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgWApi.ReFreshCache();
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
 /// 学院(XzClg)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzClgWApi
{
private static readonly string mstrApiControllerName = "XzClgApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsXzClgWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_XzCollege(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学院]...","0");
List<clsXzClgEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_XzCollege";
objDDL.DataTextField="CollegeName";
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
public static void BindCbo_id_XzCollege(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzClg.id_XzCollege); 
List<clsXzClgEN> arrObjLst = clsXzClgWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzClgEN objXzClgEN = new clsXzClgEN()
{
id_XzCollege = "0",
CollegeName = "选[学院]..."
};
arrObjLst.Insert(0, objXzClgEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzClg.id_XzCollege;
objComboBox.DisplayMember = conXzClg.CollegeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzClgEN objXzClgEN)
{
if (!Object.Equals(null, objXzClgEN.id_XzCollege) && GetStrLen(objXzClgEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzClgEN.CollegeID) && GetStrLen(objXzClgEN.CollegeID) > 4)
{
 throw new Exception("字段[学院ID]的长度不能超过4!");
}
if (!Object.Equals(null, objXzClgEN.CollegeName) && GetStrLen(objXzClgEN.CollegeName) > 100)
{
 throw new Exception("字段[学院名称]的长度不能超过100!");
}
if (!Object.Equals(null, objXzClgEN.CollegeIdInGP) && GetStrLen(objXzClgEN.CollegeIdInGP) > 6)
{
 throw new Exception("字段[CollegeIdInGP]的长度不能超过6!");
}
if (!Object.Equals(null, objXzClgEN.ClgEnglishName) && GetStrLen(objXzClgEN.ClgEnglishName) > 60)
{
 throw new Exception("字段[ClgEnglishName]的长度不能超过60!");
}
if (!Object.Equals(null, objXzClgEN.CollegeNameA) && GetStrLen(objXzClgEN.CollegeNameA) > 12)
{
 throw new Exception("字段[学院名称简写]的长度不能超过12!");
}
if (!Object.Equals(null, objXzClgEN.PhoneNumber) && GetStrLen(objXzClgEN.PhoneNumber) > 15)
{
 throw new Exception("字段[PhoneNumber]的长度不能超过15!");
}
if (!Object.Equals(null, objXzClgEN.WebSite) && GetStrLen(objXzClgEN.WebSite) > 60)
{
 throw new Exception("字段[个人主页]的长度不能超过60!");
}
if (!Object.Equals(null, objXzClgEN.id_School) && GetStrLen(objXzClgEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzClgEN.id_Uni) && GetStrLen(objXzClgEN.id_Uni) > 4)
{
 throw new Exception("字段[id_Uni]的长度不能超过4!");
}
if (!Object.Equals(null, objXzClgEN.ModifyDate) && GetStrLen(objXzClgEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objXzClgEN.ModifyUserID) && GetStrLen(objXzClgEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objXzClgEN.Memo) && GetStrLen(objXzClgEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objXzClgEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_XzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzClgEN GetObjByid_XzCollege(string strid_XzCollege)
{
string strAction = "GetObjByid_XzCollege";
string strErrMsg = string.Empty;
string strResult = "";
clsXzClgEN objXzClgEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzCollege"] = strid_XzCollege
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzClgEN = JsonConvert.DeserializeObject<clsXzClgEN>((string)jobjReturn["ReturnObj"]);
return objXzClgEN;
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
 /// <param name = "strid_XzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzClgEN GetObjByid_XzCollege_WA_Cache(string strid_XzCollege)
{
string strAction = "GetObjByid_XzCollege_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsXzClgEN objXzClgEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzCollege"] = strid_XzCollege
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzClgEN = JsonConvert.DeserializeObject<clsXzClgEN>((string)jobjReturn["ReturnObj"]);
return objXzClgEN;
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
public static clsXzClgEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsXzClgEN objXzClgEN = null;
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
objXzClgEN = JsonConvert.DeserializeObject<clsXzClgEN>((string)jobjReturn["ReturnObj"]);
return objXzClgEN;
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
 /// <param name = "strid_XzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzClgEN GetObjByid_XzCollege_Cache(string strid_XzCollege)
{
if (string.IsNullOrEmpty(strid_XzCollege) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName_S);
List<clsXzClgEN> arrXzClgObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzClgEN> arrXzClgObjLst_Sel =
from objXzClgEN in arrXzClgObjLst_Cache
where objXzClgEN.id_XzCollege == strid_XzCollege
select objXzClgEN;
if (arrXzClgObjLst_Sel.Count() == 0)
{
   clsXzClgEN obj = clsXzClgWApi.GetObjByid_XzCollege(strid_XzCollege);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzClgObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_XzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCollegeNameByid_XzCollege_Cache(string strid_XzCollege)
{
if (string.IsNullOrEmpty(strid_XzCollege) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName_S);
List<clsXzClgEN> arrXzClgObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzClgEN> arrXzClgObjLst_Sel1 =
from objXzClgEN in arrXzClgObjLst_Cache
where objXzClgEN.id_XzCollege == strid_XzCollege
select objXzClgEN;
List <clsXzClgEN> arrXzClgObjLst_Sel = new List<clsXzClgEN>();
foreach (clsXzClgEN obj in arrXzClgObjLst_Sel1)
{
arrXzClgObjLst_Sel.Add(obj);
}
if (arrXzClgObjLst_Sel.Count > 0)
{
return arrXzClgObjLst_Sel[0].CollegeName;
}
string strErrMsgForGetObjById = string.Format("在XzClg对象缓存列表中,找不到记录[id_XzCollege = {0}](函数:{1})", strid_XzCollege, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzClgBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_XzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_XzCollege_Cache(string strid_XzCollege)
{
if (string.IsNullOrEmpty(strid_XzCollege) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName_S);
List<clsXzClgEN> arrXzClgObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzClgEN> arrXzClgObjLst_Sel1 =
from objXzClgEN in arrXzClgObjLst_Cache
where objXzClgEN.id_XzCollege == strid_XzCollege
select objXzClgEN;
List <clsXzClgEN> arrXzClgObjLst_Sel = new List<clsXzClgEN>();
foreach (clsXzClgEN obj in arrXzClgObjLst_Sel1)
{
arrXzClgObjLst_Sel.Add(obj);
}
if (arrXzClgObjLst_Sel.Count > 0)
{
return arrXzClgObjLst_Sel[0].CollegeName;
}
string strErrMsgForGetObjById = string.Format("在XzClg对象缓存列表中,找不到记录的相关名称[id_XzCollege = {0}](函数:{1})", strid_XzCollege, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzClgBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzClgEN> GetObjLst(string strWhereCond)
{
 List<clsXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzClgEN> GetObjLstById_XzCollegeLst(List<string> arrId_XzCollege)
{
 List<clsXzClgEN> arrObjLst = null; 
string strAction = "GetObjLstById_XzCollegeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_XzCollege);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_XzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsXzClgEN> GetObjLstById_XzCollegeLst_Cache(List<string> arrId_XzCollege)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName_S);
List<clsXzClgEN> arrXzClgObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzClgEN> arrXzClgObjLst_Sel =
from objXzClgEN in arrXzClgObjLst_Cache
where arrId_XzCollege.Contains(objXzClgEN.id_XzCollege)
select objXzClgEN;
return arrXzClgObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzClgEN> GetObjLstById_XzCollegeLst_WA_Cache(List<string> arrId_XzCollege)
{
 List<clsXzClgEN> arrObjLst = null; 
string strAction = "GetObjLstById_XzCollegeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_XzCollege);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzClgEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzClgEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzClgEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzClgEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_XzCollege)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsXzClgEN objXzClgEN = clsXzClgWApi.GetObjByid_XzCollege(strid_XzCollege);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_XzCollege.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzClgWApi.ReFreshCache();
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
public static int DelXzClgs(List<string> arrid_XzCollege)
{
string strAction = "DelXzClgs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_XzCollege);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzClgWApi.ReFreshCache();
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
public static int DelXzClgsByCond(string strWhereCond)
{
string strAction = "DelXzClgsByCond";
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
public static bool AddNewRecord(clsXzClgEN objXzClgEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzClgEN>(objXzClgEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsXzClgEN objXzClgEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzClgEN>(objXzClgEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgWApi.ReFreshCache();
var strid_XzCollege = (string)jobjReturn["ReturnStr"];
return strid_XzCollege;
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
public static bool UpdateRecord(clsXzClgEN objXzClgEN)
{
if (string.IsNullOrEmpty(objXzClgEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzClgEN.id_XzCollege, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzClgEN>(objXzClgEN);
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
 /// <param name = "objXzClgEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzClgEN objXzClgEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzClgEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzClgEN.id_XzCollege, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzClgEN.id_XzCollege, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzClgEN>(objXzClgEN);
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
public static bool IsExist(string strid_XzCollege)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzCollege"] = strid_XzCollege
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
 /// <param name = "objXzClgENS">源对象</param>
 /// <param name = "objXzClgENT">目标对象</param>
 public static void CopyTo(clsXzClgEN objXzClgENS, clsXzClgEN objXzClgENT)
{
try
{
objXzClgENT.id_XzCollege = objXzClgENS.id_XzCollege; //学院流水号
objXzClgENT.CollegeID = objXzClgENS.CollegeID; //学院ID
objXzClgENT.CollegeName = objXzClgENS.CollegeName; //学院名称
objXzClgENT.CollegeIdInGP = objXzClgENS.CollegeIdInGP; //CollegeIdInGP
objXzClgENT.ClgEnglishName = objXzClgENS.ClgEnglishName; //ClgEnglishName
objXzClgENT.CollegeNameA = objXzClgENS.CollegeNameA; //学院名称简写
objXzClgENT.PhoneNumber = objXzClgENS.PhoneNumber; //PhoneNumber
objXzClgENT.WebSite = objXzClgENS.WebSite; //个人主页
objXzClgENT.id_School = objXzClgENS.id_School; //学校流水号
objXzClgENT.id_Uni = objXzClgENS.id_Uni; //id_Uni
objXzClgENT.IsVisible4Tea = objXzClgENS.IsVisible4Tea; //IsVisible4Tea
objXzClgENT.IsVisible = objXzClgENS.IsVisible; //是否显示
objXzClgENT.OrderNum = objXzClgENS.OrderNum; //序号
objXzClgENT.ModifyDate = objXzClgENS.ModifyDate; //修改日期
objXzClgENT.ModifyUserID = objXzClgENS.ModifyUserID; //修改人
objXzClgENT.Memo = objXzClgENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsXzClgEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzClgEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzClgEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzClgEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzClgEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzClgEN.AttributeName)
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_XzCollege");
//if (arrXzClgObjLst_Cache == null)
//{
//arrXzClgObjLst_Cache = await clsXzClgWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName_S);
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
if (clsXzClgWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzClgWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzClgEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName_S);
List<clsXzClgEN> arrXzClgObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzClgObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzClgEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzClg.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.CollegeIdInGP, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.ClgEnglishName, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.WebSite, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.id_School, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.id_Uni, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.IsVisible4Tea, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzClg.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzClg.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzClg.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conXzClg.Memo, Type.GetType("System.String"));
foreach (clsXzClgEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzClg.id_XzCollege] = objInFor[conXzClg.id_XzCollege];
objDR[conXzClg.CollegeID] = objInFor[conXzClg.CollegeID];
objDR[conXzClg.CollegeName] = objInFor[conXzClg.CollegeName];
objDR[conXzClg.CollegeIdInGP] = objInFor[conXzClg.CollegeIdInGP];
objDR[conXzClg.ClgEnglishName] = objInFor[conXzClg.ClgEnglishName];
objDR[conXzClg.CollegeNameA] = objInFor[conXzClg.CollegeNameA];
objDR[conXzClg.PhoneNumber] = objInFor[conXzClg.PhoneNumber];
objDR[conXzClg.WebSite] = objInFor[conXzClg.WebSite];
objDR[conXzClg.id_School] = objInFor[conXzClg.id_School];
objDR[conXzClg.id_Uni] = objInFor[conXzClg.id_Uni];
objDR[conXzClg.IsVisible4Tea] = objInFor[conXzClg.IsVisible4Tea];
objDR[conXzClg.IsVisible] = objInFor[conXzClg.IsVisible];
objDR[conXzClg.OrderNum] = objInFor[conXzClg.OrderNum];
objDR[conXzClg.ModifyDate] = objInFor[conXzClg.ModifyDate];
objDR[conXzClg.ModifyUserID] = objInFor[conXzClg.ModifyUserID];
objDR[conXzClg.Memo] = objInFor[conXzClg.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学院(XzClg)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4XzClg : clsCommFun4BL
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
clsXzClgWApi.ReFreshThisCache();
clsvXzClgWApi.ReFreshThisCache();
}
}

}