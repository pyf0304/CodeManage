
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzAdminClsWApi
 表名:vXzAdminCls(01120163)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:46
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成长档案
 模块英文名:EPortfolio
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
public static class clsvXzAdminClsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN Setid_AdminCls(this clsvXzAdminClsEN objvXzAdminClsEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convXzAdminCls.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convXzAdminCls.id_AdminCls);
objvXzAdminClsEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.id_AdminCls) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.id_AdminCls, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.id_AdminCls] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN Setid_XzMajor(this clsvXzAdminClsEN objvXzAdminClsEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convXzAdminCls.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convXzAdminCls.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convXzAdminCls.id_XzMajor);
objvXzAdminClsEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.id_XzMajor) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.id_XzMajor, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.id_XzMajor] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetMajorID(this clsvXzAdminClsEN objvXzAdminClsEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzAdminCls.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzAdminCls.MajorID);
objvXzAdminClsEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.MajorID) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.MajorID, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.MajorID] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetMajorName(this clsvXzAdminClsEN objvXzAdminClsEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzAdminCls.MajorName);
objvXzAdminClsEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.MajorName) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.MajorName, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.MajorName] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN Setid_XzCollege(this clsvXzAdminClsEN objvXzAdminClsEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convXzAdminCls.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convXzAdminCls.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convXzAdminCls.id_XzCollege);
objvXzAdminClsEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.id_XzCollege) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.id_XzCollege, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.id_XzCollege] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetCollegeID(this clsvXzAdminClsEN objvXzAdminClsEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convXzAdminCls.CollegeID);
objvXzAdminClsEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.CollegeID) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.CollegeID, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.CollegeID] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetCollegeName(this clsvXzAdminClsEN objvXzAdminClsEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzAdminCls.CollegeName);
objvXzAdminClsEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.CollegeName) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.CollegeName, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.CollegeName] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetCollegeNameA(this clsvXzAdminClsEN objvXzAdminClsEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convXzAdminCls.CollegeNameA);
objvXzAdminClsEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.CollegeNameA) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.CollegeNameA, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.CollegeNameA] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetModifyUserID(this clsvXzAdminClsEN objvXzAdminClsEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convXzAdminCls.ModifyUserID);
objvXzAdminClsEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.ModifyUserID) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.ModifyUserID, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.ModifyUserID] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetModifyDate(this clsvXzAdminClsEN objvXzAdminClsEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzAdminCls.ModifyDate);
objvXzAdminClsEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.ModifyDate) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.ModifyDate, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.ModifyDate] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN Setid_UniZone(this clsvXzAdminClsEN objvXzAdminClsEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convXzAdminCls.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convXzAdminCls.id_UniZone);
objvXzAdminClsEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.id_UniZone) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.id_UniZone, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.id_UniZone] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetUniZoneDesc(this clsvXzAdminClsEN objvXzAdminClsEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convXzAdminCls.UniZoneDesc);
objvXzAdminClsEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.UniZoneDesc) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.UniZoneDesc, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.UniZoneDesc] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetCurrentStuQty(this clsvXzAdminClsEN objvXzAdminClsEN, int intCurrentStuQty, string strComparisonOp="")
	{
objvXzAdminClsEN.CurrentStuQty = intCurrentStuQty; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.CurrentStuQty) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.CurrentStuQty, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.CurrentStuQty] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN Setid_GradeBase(this clsvXzAdminClsEN objvXzAdminClsEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_GradeBase, convXzAdminCls.id_GradeBase);
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convXzAdminCls.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convXzAdminCls.id_GradeBase);
objvXzAdminClsEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.id_GradeBase) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.id_GradeBase, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.id_GradeBase] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetGradeBaseID(this clsvXzAdminClsEN objvXzAdminClsEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convXzAdminCls.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convXzAdminCls.GradeBaseID);
objvXzAdminClsEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.GradeBaseID) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.GradeBaseID, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.GradeBaseID] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetGradeBaseName(this clsvXzAdminClsEN objvXzAdminClsEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convXzAdminCls.GradeBaseName);
objvXzAdminClsEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.GradeBaseName) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.GradeBaseName, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.GradeBaseName] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetStudyLevelName(this clsvXzAdminClsEN objvXzAdminClsEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convXzAdminCls.StudyLevelName);
objvXzAdminClsEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.StudyLevelName) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.StudyLevelName, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.StudyLevelName] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsName(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convXzAdminCls.AdminClsName);
objvXzAdminClsEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.AdminClsName) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.AdminClsName, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.AdminClsName] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsId(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convXzAdminCls.AdminClsId);
objvXzAdminClsEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.AdminClsId) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.AdminClsId, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.AdminClsId] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN Setid_AdminClsType(this clsvXzAdminClsEN objvXzAdminClsEN, string strid_AdminClsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminClsType, 4, convXzAdminCls.id_AdminClsType);
clsCheckSql.CheckFieldForeignKey(strid_AdminClsType, 4, convXzAdminCls.id_AdminClsType);
objvXzAdminClsEN.id_AdminClsType = strid_AdminClsType; //行政班级类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.id_AdminClsType) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.id_AdminClsType, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.id_AdminClsType] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsTypeName(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsTypeName, 30, convXzAdminCls.AdminClsTypeName);
objvXzAdminClsEN.AdminClsTypeName = strAdminClsTypeName; //行政班级类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.AdminClsTypeName) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.AdminClsTypeName, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.AdminClsTypeName] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsTypeId(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsTypeId, 4, convXzAdminCls.AdminClsTypeId);
objvXzAdminClsEN.AdminClsTypeId = strAdminClsTypeId; //行政班级类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.AdminClsTypeId) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.AdminClsTypeId, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.AdminClsTypeId] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsIndex(this clsvXzAdminClsEN objvXzAdminClsEN, int intAdminClsIndex, string strComparisonOp="")
	{
objvXzAdminClsEN.AdminClsIndex = intAdminClsIndex; //AdminClsIndex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.AdminClsIndex) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.AdminClsIndex, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.AdminClsIndex] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzAdminClsEN SetMemo(this clsvXzAdminClsEN objvXzAdminClsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzAdminCls.Memo);
objvXzAdminClsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.Memo) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.Memo, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.Memo] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzAdminClsEN objvXzAdminCls_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.id_AdminCls, objvXzAdminCls_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.id_XzMajor, objvXzAdminCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.MajorID) == true)
{
string strComparisonOp_MajorID = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.MajorID, objvXzAdminCls_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.MajorName) == true)
{
string strComparisonOp_MajorName = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.MajorName, objvXzAdminCls_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.id_XzCollege, objvXzAdminCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.CollegeID, objvXzAdminCls_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.CollegeName, objvXzAdminCls_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.CollegeNameA, objvXzAdminCls_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.ModifyUserID, objvXzAdminCls_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.ModifyDate, objvXzAdminCls_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.id_UniZone, objvXzAdminCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.UniZoneDesc, objvXzAdminCls_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.CurrentStuQty) == true)
{
string strComparisonOp_CurrentStuQty = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convXzAdminCls.CurrentStuQty, objvXzAdminCls_Cond.CurrentStuQty, strComparisonOp_CurrentStuQty);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.id_GradeBase, objvXzAdminCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.GradeBaseID, objvXzAdminCls_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.GradeBaseName, objvXzAdminCls_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.StudyLevelName, objvXzAdminCls_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsName, objvXzAdminCls_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsId, objvXzAdminCls_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.id_AdminClsType) == true)
{
string strComparisonOp_id_AdminClsType = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.id_AdminClsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.id_AdminClsType, objvXzAdminCls_Cond.id_AdminClsType, strComparisonOp_id_AdminClsType);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.AdminClsTypeName) == true)
{
string strComparisonOp_AdminClsTypeName = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.AdminClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsTypeName, objvXzAdminCls_Cond.AdminClsTypeName, strComparisonOp_AdminClsTypeName);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.AdminClsTypeId) == true)
{
string strComparisonOp_AdminClsTypeId = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.AdminClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsTypeId, objvXzAdminCls_Cond.AdminClsTypeId, strComparisonOp_AdminClsTypeId);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.AdminClsIndex) == true)
{
string strComparisonOp_AdminClsIndex = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.AdminClsIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convXzAdminCls.AdminClsIndex, objvXzAdminCls_Cond.AdminClsIndex, strComparisonOp_AdminClsIndex);
}
if (objvXzAdminCls_Cond.IsUpdated(convXzAdminCls.Memo) == true)
{
string strComparisonOp_Memo = objvXzAdminCls_Cond.dicFldComparisonOp[convXzAdminCls.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.Memo, objvXzAdminCls_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v行政班(vXzAdminCls)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzAdminClsWApi
{
private static readonly string mstrApiControllerName = "vXzAdminClsApi";

 public clsvXzAdminClsWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v行政班]...","0");
List<clsvXzAdminClsEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convXzAdminCls.id_AdminCls); 
List<clsvXzAdminClsEN> arrObjLst = clsvXzAdminClsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN()
{
id_AdminCls = "0",
AdminClsName = "选[v行政班]..."
};
arrObjLst.Insert(0, objvXzAdminClsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzAdminCls.id_AdminCls;
objComboBox.DisplayMember = convXzAdminCls.AdminClsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_AdminCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzAdminClsEN GetObjByid_AdminCls(string strid_AdminCls)
{
string strAction = "GetObjByid_AdminCls";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzAdminClsEN objvXzAdminClsEN = null;
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
objvXzAdminClsEN = JsonConvert.DeserializeObject<clsvXzAdminClsEN>((string)jobjReturn["ReturnObj"]);
return objvXzAdminClsEN;
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
public static clsvXzAdminClsEN GetObjByid_AdminCls_WA_Cache(string strid_AdminCls)
{
string strAction = "GetObjByid_AdminCls_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzAdminClsEN objvXzAdminClsEN = null;
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
objvXzAdminClsEN = JsonConvert.DeserializeObject<clsvXzAdminClsEN>((string)jobjReturn["ReturnObj"]);
return objvXzAdminClsEN;
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
public static clsvXzAdminClsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzAdminClsEN objvXzAdminClsEN = null;
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
objvXzAdminClsEN = JsonConvert.DeserializeObject<clsvXzAdminClsEN>((string)jobjReturn["ReturnObj"]);
return objvXzAdminClsEN;
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
public static clsvXzAdminClsEN GetObjByid_AdminCls_Cache(string strid_AdminCls)
{
if (string.IsNullOrEmpty(strid_AdminCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName_S);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel =
from objvXzAdminClsEN in arrvXzAdminClsObjLst_Cache
where objvXzAdminClsEN.id_AdminCls == strid_AdminCls
select objvXzAdminClsEN;
if (arrvXzAdminClsObjLst_Sel.Count() == 0)
{
   clsvXzAdminClsEN obj = clsvXzAdminClsWApi.GetObjByid_AdminCls(strid_AdminCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzAdminClsObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName_S);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel1 =
from objvXzAdminClsEN in arrvXzAdminClsObjLst_Cache
where objvXzAdminClsEN.id_AdminCls == strid_AdminCls
select objvXzAdminClsEN;
List <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel = new List<clsvXzAdminClsEN>();
foreach (clsvXzAdminClsEN obj in arrvXzAdminClsObjLst_Sel1)
{
arrvXzAdminClsObjLst_Sel.Add(obj);
}
if (arrvXzAdminClsObjLst_Sel.Count > 0)
{
return arrvXzAdminClsObjLst_Sel[0].AdminClsName;
}
string strErrMsgForGetObjById = string.Format("在vXzAdminCls对象缓存列表中,找不到记录[id_AdminCls = {0}](函数:{1})", strid_AdminCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzAdminClsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName_S);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel1 =
from objvXzAdminClsEN in arrvXzAdminClsObjLst_Cache
where objvXzAdminClsEN.id_AdminCls == strid_AdminCls
select objvXzAdminClsEN;
List <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel = new List<clsvXzAdminClsEN>();
foreach (clsvXzAdminClsEN obj in arrvXzAdminClsObjLst_Sel1)
{
arrvXzAdminClsObjLst_Sel.Add(obj);
}
if (arrvXzAdminClsObjLst_Sel.Count > 0)
{
return arrvXzAdminClsObjLst_Sel[0].AdminClsName;
}
string strErrMsgForGetObjById = string.Format("在vXzAdminCls对象缓存列表中,找不到记录的相关名称[id_AdminCls = {0}](函数:{1})", strid_AdminCls, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzAdminClsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLst(string strWhereCond)
{
 List<clsvXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzAdminClsEN> GetObjLstById_AdminClsLst(List<string> arrId_AdminCls)
{
 List<clsvXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvXzAdminClsEN> GetObjLstById_AdminClsLst_Cache(List<string> arrId_AdminCls)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName_S);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel =
from objvXzAdminClsEN in arrvXzAdminClsObjLst_Cache
where arrId_AdminCls.Contains(objvXzAdminClsEN.id_AdminCls)
select objvXzAdminClsEN;
return arrvXzAdminClsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstById_AdminClsLst_WA_Cache(List<string> arrId_AdminCls)
{
 List<clsvXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzAdminClsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzAdminClsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzAdminClsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzAdminClsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzAdminClsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzAdminClsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvXzAdminClsENS">源对象</param>
 /// <param name = "objvXzAdminClsENT">目标对象</param>
 public static void CopyTo(clsvXzAdminClsEN objvXzAdminClsENS, clsvXzAdminClsEN objvXzAdminClsENT)
{
try
{
objvXzAdminClsENT.id_AdminCls = objvXzAdminClsENS.id_AdminCls; //行政班流水号
objvXzAdminClsENT.id_XzMajor = objvXzAdminClsENS.id_XzMajor; //专业流水号
objvXzAdminClsENT.MajorID = objvXzAdminClsENS.MajorID; //专业ID
objvXzAdminClsENT.MajorName = objvXzAdminClsENS.MajorName; //专业名称
objvXzAdminClsENT.id_XzCollege = objvXzAdminClsENS.id_XzCollege; //学院流水号
objvXzAdminClsENT.CollegeID = objvXzAdminClsENS.CollegeID; //学院ID
objvXzAdminClsENT.CollegeName = objvXzAdminClsENS.CollegeName; //学院名称
objvXzAdminClsENT.CollegeNameA = objvXzAdminClsENS.CollegeNameA; //学院名称简写
objvXzAdminClsENT.ModifyUserID = objvXzAdminClsENS.ModifyUserID; //修改人
objvXzAdminClsENT.ModifyDate = objvXzAdminClsENS.ModifyDate; //修改日期
objvXzAdminClsENT.id_UniZone = objvXzAdminClsENS.id_UniZone; //校区流水号
objvXzAdminClsENT.UniZoneDesc = objvXzAdminClsENS.UniZoneDesc; //校区名称
objvXzAdminClsENT.CurrentStuQty = objvXzAdminClsENS.CurrentStuQty; //当前学生数
objvXzAdminClsENT.id_GradeBase = objvXzAdminClsENS.id_GradeBase; //年级流水号
objvXzAdminClsENT.GradeBaseID = objvXzAdminClsENS.GradeBaseID; //年级代号
objvXzAdminClsENT.GradeBaseName = objvXzAdminClsENS.GradeBaseName; //年级名称
objvXzAdminClsENT.StudyLevelName = objvXzAdminClsENS.StudyLevelName; //学段名称
objvXzAdminClsENT.AdminClsName = objvXzAdminClsENS.AdminClsName; //行政班名称
objvXzAdminClsENT.AdminClsId = objvXzAdminClsENS.AdminClsId; //行政班代号
objvXzAdminClsENT.id_AdminClsType = objvXzAdminClsENS.id_AdminClsType; //行政班级类型流水号
objvXzAdminClsENT.AdminClsTypeName = objvXzAdminClsENS.AdminClsTypeName; //行政班级类型名称
objvXzAdminClsENT.AdminClsTypeId = objvXzAdminClsENS.AdminClsTypeId; //行政班级类型ID
objvXzAdminClsENT.AdminClsIndex = objvXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objvXzAdminClsENT.Memo = objvXzAdminClsENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvXzAdminClsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzAdminClsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzAdminClsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzAdminClsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzAdminClsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzAdminClsEN.AttributeName)
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
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_AdminCls");
//if (arrvXzAdminClsObjLst_Cache == null)
//{
//arrvXzAdminClsObjLst_Cache = await clsvXzAdminClsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName_S);
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
public static List<clsvXzAdminClsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName_S);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzAdminClsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzAdminClsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzAdminCls.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.CurrentStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convXzAdminCls.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.id_AdminClsType, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.AdminClsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.AdminClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convXzAdminCls.AdminClsIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convXzAdminCls.Memo, Type.GetType("System.String"));
foreach (clsvXzAdminClsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzAdminCls.id_AdminCls] = objInFor[convXzAdminCls.id_AdminCls];
objDR[convXzAdminCls.id_XzMajor] = objInFor[convXzAdminCls.id_XzMajor];
objDR[convXzAdminCls.MajorID] = objInFor[convXzAdminCls.MajorID];
objDR[convXzAdminCls.MajorName] = objInFor[convXzAdminCls.MajorName];
objDR[convXzAdminCls.id_XzCollege] = objInFor[convXzAdminCls.id_XzCollege];
objDR[convXzAdminCls.CollegeID] = objInFor[convXzAdminCls.CollegeID];
objDR[convXzAdminCls.CollegeName] = objInFor[convXzAdminCls.CollegeName];
objDR[convXzAdminCls.CollegeNameA] = objInFor[convXzAdminCls.CollegeNameA];
objDR[convXzAdminCls.ModifyUserID] = objInFor[convXzAdminCls.ModifyUserID];
objDR[convXzAdminCls.ModifyDate] = objInFor[convXzAdminCls.ModifyDate];
objDR[convXzAdminCls.id_UniZone] = objInFor[convXzAdminCls.id_UniZone];
objDR[convXzAdminCls.UniZoneDesc] = objInFor[convXzAdminCls.UniZoneDesc];
objDR[convXzAdminCls.CurrentStuQty] = objInFor[convXzAdminCls.CurrentStuQty];
objDR[convXzAdminCls.id_GradeBase] = objInFor[convXzAdminCls.id_GradeBase];
objDR[convXzAdminCls.GradeBaseID] = objInFor[convXzAdminCls.GradeBaseID];
objDR[convXzAdminCls.GradeBaseName] = objInFor[convXzAdminCls.GradeBaseName];
objDR[convXzAdminCls.StudyLevelName] = objInFor[convXzAdminCls.StudyLevelName];
objDR[convXzAdminCls.AdminClsName] = objInFor[convXzAdminCls.AdminClsName];
objDR[convXzAdminCls.AdminClsId] = objInFor[convXzAdminCls.AdminClsId];
objDR[convXzAdminCls.id_AdminClsType] = objInFor[convXzAdminCls.id_AdminClsType];
objDR[convXzAdminCls.AdminClsTypeName] = objInFor[convXzAdminCls.AdminClsTypeName];
objDR[convXzAdminCls.AdminClsTypeId] = objInFor[convXzAdminCls.AdminClsTypeId];
objDR[convXzAdminCls.AdminClsIndex] = objInFor[convXzAdminCls.AdminClsIndex];
objDR[convXzAdminCls.Memo] = objInFor[convXzAdminCls.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}