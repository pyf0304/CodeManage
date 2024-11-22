
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzAdminClsBL
 表名:vXzAdminCls(01120163)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvXzAdminClsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAdminCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzAdminClsEN GetObj(this K_IdAdminCls_vXzAdminCls myKey)
{
clsvXzAdminClsEN objvXzAdminClsEN = clsvXzAdminClsBL.vXzAdminClsDA.GetObjByIdAdminCls(myKey.Value);
return objvXzAdminClsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetIdAdminCls(this clsvXzAdminClsEN objvXzAdminClsEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convXzAdminCls.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convXzAdminCls.IdAdminCls);
}
objvXzAdminClsEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.IdAdminCls) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.IdAdminCls, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.IdAdminCls] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetIdXzMajor(this clsvXzAdminClsEN objvXzAdminClsEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convXzAdminCls.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convXzAdminCls.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convXzAdminCls.IdXzMajor);
}
objvXzAdminClsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.IdXzMajor) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.IdXzMajor, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.IdXzMajor] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetMajorID(this clsvXzAdminClsEN objvXzAdminClsEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzAdminCls.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzAdminCls.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetMajorName(this clsvXzAdminClsEN objvXzAdminClsEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzAdminCls.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetIdXzCollege(this clsvXzAdminClsEN objvXzAdminClsEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convXzAdminCls.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convXzAdminCls.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convXzAdminCls.IdXzCollege);
}
objvXzAdminClsEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.IdXzCollege) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.IdXzCollege, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.IdXzCollege] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetCollegeId(this clsvXzAdminClsEN objvXzAdminClsEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convXzAdminCls.CollegeId);
}
objvXzAdminClsEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.CollegeId) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.CollegeId, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.CollegeId] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetCollegeName(this clsvXzAdminClsEN objvXzAdminClsEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzAdminCls.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetCollegeNameA(this clsvXzAdminClsEN objvXzAdminClsEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convXzAdminCls.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetModifyUserId(this clsvXzAdminClsEN objvXzAdminClsEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convXzAdminCls.ModifyUserId);
}
objvXzAdminClsEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.ModifyUserId) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.ModifyUserId, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.ModifyUserId] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetModifyDate(this clsvXzAdminClsEN objvXzAdminClsEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzAdminCls.ModifyDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetIdUniZone(this clsvXzAdminClsEN objvXzAdminClsEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convXzAdminCls.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convXzAdminCls.IdUniZone);
}
objvXzAdminClsEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.IdUniZone) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.IdUniZone, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.IdUniZone] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetUniZoneDesc(this clsvXzAdminClsEN objvXzAdminClsEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convXzAdminCls.UniZoneDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetCurrentStuQty(this clsvXzAdminClsEN objvXzAdminClsEN, int? intCurrentStuQty, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetIdGradeBase(this clsvXzAdminClsEN objvXzAdminClsEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGradeBase, convXzAdminCls.IdGradeBase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convXzAdminCls.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convXzAdminCls.IdGradeBase);
}
objvXzAdminClsEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.IdGradeBase) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.IdGradeBase, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.IdGradeBase] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetGradeBaseId(this clsvXzAdminClsEN objvXzAdminClsEN, string strGradeBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, convXzAdminCls.GradeBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, convXzAdminCls.GradeBaseId);
}
objvXzAdminClsEN.GradeBaseId = strGradeBaseId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.GradeBaseId) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.GradeBaseId, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.GradeBaseId] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetGradeBaseName(this clsvXzAdminClsEN objvXzAdminClsEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convXzAdminCls.GradeBaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetStudyLevelName(this clsvXzAdminClsEN objvXzAdminClsEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convXzAdminCls.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsName(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convXzAdminCls.AdminClsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsId(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convXzAdminCls.AdminClsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetIdAdminClsType(this clsvXzAdminClsEN objvXzAdminClsEN, string strIdAdminClsType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminClsType, 4, convXzAdminCls.IdAdminClsType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminClsType, 4, convXzAdminCls.IdAdminClsType);
}
objvXzAdminClsEN.IdAdminClsType = strIdAdminClsType; //行政班级类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzAdminClsEN.dicFldComparisonOp.ContainsKey(convXzAdminCls.IdAdminClsType) == false)
{
objvXzAdminClsEN.dicFldComparisonOp.Add(convXzAdminCls.IdAdminClsType, strComparisonOp);
}
else
{
objvXzAdminClsEN.dicFldComparisonOp[convXzAdminCls.IdAdminClsType] = strComparisonOp;
}
}
return objvXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsTypeName(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsTypeName, 30, convXzAdminCls.AdminClsTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsTypeId(this clsvXzAdminClsEN objvXzAdminClsEN, string strAdminClsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsTypeId, 4, convXzAdminCls.AdminClsTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetAdminClsIndex(this clsvXzAdminClsEN objvXzAdminClsEN, int? intAdminClsIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzAdminClsEN SetMemo(this clsvXzAdminClsEN objvXzAdminClsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzAdminCls.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzAdminClsENS">源对象</param>
 /// <param name = "objvXzAdminClsENT">目标对象</param>
 public static void CopyTo(this clsvXzAdminClsEN objvXzAdminClsENS, clsvXzAdminClsEN objvXzAdminClsENT)
{
try
{
objvXzAdminClsENT.IdAdminCls = objvXzAdminClsENS.IdAdminCls; //行政班流水号
objvXzAdminClsENT.IdXzMajor = objvXzAdminClsENS.IdXzMajor; //专业流水号
objvXzAdminClsENT.MajorID = objvXzAdminClsENS.MajorID; //专业ID
objvXzAdminClsENT.MajorName = objvXzAdminClsENS.MajorName; //专业名称
objvXzAdminClsENT.IdXzCollege = objvXzAdminClsENS.IdXzCollege; //学院流水号
objvXzAdminClsENT.CollegeId = objvXzAdminClsENS.CollegeId; //学院ID
objvXzAdminClsENT.CollegeName = objvXzAdminClsENS.CollegeName; //学院名称
objvXzAdminClsENT.CollegeNameA = objvXzAdminClsENS.CollegeNameA; //学院名称简写
objvXzAdminClsENT.ModifyUserId = objvXzAdminClsENS.ModifyUserId; //修改人
objvXzAdminClsENT.ModifyDate = objvXzAdminClsENS.ModifyDate; //修改日期
objvXzAdminClsENT.IdUniZone = objvXzAdminClsENS.IdUniZone; //校区流水号
objvXzAdminClsENT.UniZoneDesc = objvXzAdminClsENS.UniZoneDesc; //校区名称
objvXzAdminClsENT.CurrentStuQty = objvXzAdminClsENS.CurrentStuQty; //当前学生数
objvXzAdminClsENT.IdGradeBase = objvXzAdminClsENS.IdGradeBase; //年级流水号
objvXzAdminClsENT.GradeBaseId = objvXzAdminClsENS.GradeBaseId; //年级代号
objvXzAdminClsENT.GradeBaseName = objvXzAdminClsENS.GradeBaseName; //年级名称
objvXzAdminClsENT.StudyLevelName = objvXzAdminClsENS.StudyLevelName; //学段名称
objvXzAdminClsENT.AdminClsName = objvXzAdminClsENS.AdminClsName; //行政班名称
objvXzAdminClsENT.AdminClsId = objvXzAdminClsENS.AdminClsId; //行政班代号
objvXzAdminClsENT.IdAdminClsType = objvXzAdminClsENS.IdAdminClsType; //行政班级类型流水号
objvXzAdminClsENT.AdminClsTypeName = objvXzAdminClsENS.AdminClsTypeName; //行政班级类型名称
objvXzAdminClsENT.AdminClsTypeId = objvXzAdminClsENS.AdminClsTypeId; //行政班级类型ID
objvXzAdminClsENT.AdminClsIndex = objvXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objvXzAdminClsENT.Memo = objvXzAdminClsENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvXzAdminClsENS">源对象</param>
 /// <returns>目标对象=>clsvXzAdminClsEN:objvXzAdminClsENT</returns>
 public static clsvXzAdminClsEN CopyTo(this clsvXzAdminClsEN objvXzAdminClsENS)
{
try
{
 clsvXzAdminClsEN objvXzAdminClsENT = new clsvXzAdminClsEN()
{
IdAdminCls = objvXzAdminClsENS.IdAdminCls, //行政班流水号
IdXzMajor = objvXzAdminClsENS.IdXzMajor, //专业流水号
MajorID = objvXzAdminClsENS.MajorID, //专业ID
MajorName = objvXzAdminClsENS.MajorName, //专业名称
IdXzCollege = objvXzAdminClsENS.IdXzCollege, //学院流水号
CollegeId = objvXzAdminClsENS.CollegeId, //学院ID
CollegeName = objvXzAdminClsENS.CollegeName, //学院名称
CollegeNameA = objvXzAdminClsENS.CollegeNameA, //学院名称简写
ModifyUserId = objvXzAdminClsENS.ModifyUserId, //修改人
ModifyDate = objvXzAdminClsENS.ModifyDate, //修改日期
IdUniZone = objvXzAdminClsENS.IdUniZone, //校区流水号
UniZoneDesc = objvXzAdminClsENS.UniZoneDesc, //校区名称
CurrentStuQty = objvXzAdminClsENS.CurrentStuQty, //当前学生数
IdGradeBase = objvXzAdminClsENS.IdGradeBase, //年级流水号
GradeBaseId = objvXzAdminClsENS.GradeBaseId, //年级代号
GradeBaseName = objvXzAdminClsENS.GradeBaseName, //年级名称
StudyLevelName = objvXzAdminClsENS.StudyLevelName, //学段名称
AdminClsName = objvXzAdminClsENS.AdminClsName, //行政班名称
AdminClsId = objvXzAdminClsENS.AdminClsId, //行政班代号
IdAdminClsType = objvXzAdminClsENS.IdAdminClsType, //行政班级类型流水号
AdminClsTypeName = objvXzAdminClsENS.AdminClsTypeName, //行政班级类型名称
AdminClsTypeId = objvXzAdminClsENS.AdminClsTypeId, //行政班级类型ID
AdminClsIndex = objvXzAdminClsENS.AdminClsIndex, //AdminClsIndex
Memo = objvXzAdminClsENS.Memo, //备注
};
 return objvXzAdminClsENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvXzAdminClsEN objvXzAdminClsEN)
{
 clsvXzAdminClsBL.vXzAdminClsDA.CheckProperty4Condition(objvXzAdminClsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzAdminClsEN objvXzAdminClsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.IdAdminCls, objvXzAdminClsCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.IdXzMajor, objvXzAdminClsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.MajorID) == true)
{
string strComparisonOpMajorID = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.MajorID, objvXzAdminClsCond.MajorID, strComparisonOpMajorID);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.MajorName) == true)
{
string strComparisonOpMajorName = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.MajorName, objvXzAdminClsCond.MajorName, strComparisonOpMajorName);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.IdXzCollege, objvXzAdminClsCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.CollegeId) == true)
{
string strComparisonOpCollegeId = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.CollegeId, objvXzAdminClsCond.CollegeId, strComparisonOpCollegeId);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.CollegeName) == true)
{
string strComparisonOpCollegeName = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.CollegeName, objvXzAdminClsCond.CollegeName, strComparisonOpCollegeName);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.CollegeNameA, objvXzAdminClsCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.ModifyUserId, objvXzAdminClsCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.ModifyDate, objvXzAdminClsCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.IdUniZone, objvXzAdminClsCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.UniZoneDesc, objvXzAdminClsCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.CurrentStuQty) == true)
{
string strComparisonOpCurrentStuQty = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convXzAdminCls.CurrentStuQty, objvXzAdminClsCond.CurrentStuQty, strComparisonOpCurrentStuQty);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.IdGradeBase, objvXzAdminClsCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.GradeBaseId) == true)
{
string strComparisonOpGradeBaseId = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.GradeBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.GradeBaseId, objvXzAdminClsCond.GradeBaseId, strComparisonOpGradeBaseId);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.GradeBaseName, objvXzAdminClsCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.StudyLevelName, objvXzAdminClsCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsName, objvXzAdminClsCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsId, objvXzAdminClsCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.IdAdminClsType) == true)
{
string strComparisonOpIdAdminClsType = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.IdAdminClsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.IdAdminClsType, objvXzAdminClsCond.IdAdminClsType, strComparisonOpIdAdminClsType);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.AdminClsTypeName) == true)
{
string strComparisonOpAdminClsTypeName = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.AdminClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsTypeName, objvXzAdminClsCond.AdminClsTypeName, strComparisonOpAdminClsTypeName);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.AdminClsTypeId) == true)
{
string strComparisonOpAdminClsTypeId = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.AdminClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.AdminClsTypeId, objvXzAdminClsCond.AdminClsTypeId, strComparisonOpAdminClsTypeId);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.AdminClsIndex) == true)
{
string strComparisonOpAdminClsIndex = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.AdminClsIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convXzAdminCls.AdminClsIndex, objvXzAdminClsCond.AdminClsIndex, strComparisonOpAdminClsIndex);
}
if (objvXzAdminClsCond.IsUpdated(convXzAdminCls.Memo) == true)
{
string strComparisonOpMemo = objvXzAdminClsCond.dicFldComparisonOp[convXzAdminCls.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzAdminCls.Memo, objvXzAdminClsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzAdminCls
{
public virtual bool UpdRelaTabDate(string strIdAdminCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v行政班(vXzAdminCls)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzAdminClsBL
{
public static RelatedActions_vXzAdminCls relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzAdminClsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzAdminClsDA vXzAdminClsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzAdminClsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzAdminClsBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvXzAdminClsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzAdminClsEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vXzAdminCls(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTable_vXzAdminCls(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzAdminClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrIdAdminClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstByIdAdminClsLst(List<string> arrIdAdminClsLst)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdAdminClsLst, true);
 string strWhereCond = string.Format("IdAdminCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdAdminClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzAdminClsEN> GetObjLstByIdAdminClsLstCache(List<string> arrIdAdminClsLst)
{
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLstCache = GetObjLstCache();
IEnumerable <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel =
arrvXzAdminClsObjLstCache
.Where(x => arrIdAdminClsLst.Contains(x.IdAdminCls));
return arrvXzAdminClsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLst(string strWhereCond)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzAdminClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzAdminClsEN> GetSubObjLstCache(clsvXzAdminClsEN objvXzAdminClsCond)
{
List<clsvXzAdminClsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzAdminClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzAdminCls.AttributeName)
{
if (objvXzAdminClsCond.IsUpdated(strFldName) == false) continue;
if (objvXzAdminClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzAdminClsCond[strFldName].ToString());
}
else
{
if (objvXzAdminClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzAdminClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzAdminClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzAdminClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzAdminClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzAdminClsCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvXzAdminClsEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzAdminClsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzAdminCls(ref clsvXzAdminClsEN objvXzAdminClsEN)
{
bool bolResult = vXzAdminClsDA.GetvXzAdminCls(ref objvXzAdminClsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAdminCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzAdminClsEN GetObjByIdAdminCls(string strIdAdminCls)
{
if (strIdAdminCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdAdminCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdAdminCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdAdminCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzAdminClsEN objvXzAdminClsEN = vXzAdminClsDA.GetObjByIdAdminCls(strIdAdminCls);
return objvXzAdminClsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzAdminClsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzAdminClsEN objvXzAdminClsEN = vXzAdminClsDA.GetFirstObj(strWhereCond);
 return objvXzAdminClsEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvXzAdminClsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzAdminClsEN objvXzAdminClsEN = vXzAdminClsDA.GetObjByDataRow(objRow);
 return objvXzAdminClsEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvXzAdminClsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzAdminClsEN objvXzAdminClsEN = vXzAdminClsDA.GetObjByDataRow(objRow);
 return objvXzAdminClsEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <param name = "lstvXzAdminClsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzAdminClsEN GetObjByIdAdminClsFromList(string strIdAdminCls, List<clsvXzAdminClsEN> lstvXzAdminClsObjLst)
{
foreach (clsvXzAdminClsEN objvXzAdminClsEN in lstvXzAdminClsObjLst)
{
if (objvXzAdminClsEN.IdAdminCls == strIdAdminCls)
{
return objvXzAdminClsEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxIdAdminCls;
 try
 {
 strMaxIdAdminCls = clsvXzAdminClsDA.GetMaxStrId();
 return strMaxIdAdminCls;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdAdminCls;
 try
 {
 strIdAdminCls = new clsvXzAdminClsDA().GetFirstID(strWhereCond);
 return strIdAdminCls;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vXzAdminClsDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vXzAdminClsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdAdminCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzAdminClsDA.IsExist(strIdAdminCls);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvXzAdminClsDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vXzAdminClsDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvXzAdminClsENS">源对象</param>
 /// <param name = "objvXzAdminClsENT">目标对象</param>
 public static void CopyTo(clsvXzAdminClsEN objvXzAdminClsENS, clsvXzAdminClsEN objvXzAdminClsENT)
{
try
{
objvXzAdminClsENT.IdAdminCls = objvXzAdminClsENS.IdAdminCls; //行政班流水号
objvXzAdminClsENT.IdXzMajor = objvXzAdminClsENS.IdXzMajor; //专业流水号
objvXzAdminClsENT.MajorID = objvXzAdminClsENS.MajorID; //专业ID
objvXzAdminClsENT.MajorName = objvXzAdminClsENS.MajorName; //专业名称
objvXzAdminClsENT.IdXzCollege = objvXzAdminClsENS.IdXzCollege; //学院流水号
objvXzAdminClsENT.CollegeId = objvXzAdminClsENS.CollegeId; //学院ID
objvXzAdminClsENT.CollegeName = objvXzAdminClsENS.CollegeName; //学院名称
objvXzAdminClsENT.CollegeNameA = objvXzAdminClsENS.CollegeNameA; //学院名称简写
objvXzAdminClsENT.ModifyUserId = objvXzAdminClsENS.ModifyUserId; //修改人
objvXzAdminClsENT.ModifyDate = objvXzAdminClsENS.ModifyDate; //修改日期
objvXzAdminClsENT.IdUniZone = objvXzAdminClsENS.IdUniZone; //校区流水号
objvXzAdminClsENT.UniZoneDesc = objvXzAdminClsENS.UniZoneDesc; //校区名称
objvXzAdminClsENT.CurrentStuQty = objvXzAdminClsENS.CurrentStuQty; //当前学生数
objvXzAdminClsENT.IdGradeBase = objvXzAdminClsENS.IdGradeBase; //年级流水号
objvXzAdminClsENT.GradeBaseId = objvXzAdminClsENS.GradeBaseId; //年级代号
objvXzAdminClsENT.GradeBaseName = objvXzAdminClsENS.GradeBaseName; //年级名称
objvXzAdminClsENT.StudyLevelName = objvXzAdminClsENS.StudyLevelName; //学段名称
objvXzAdminClsENT.AdminClsName = objvXzAdminClsENS.AdminClsName; //行政班名称
objvXzAdminClsENT.AdminClsId = objvXzAdminClsENS.AdminClsId; //行政班代号
objvXzAdminClsENT.IdAdminClsType = objvXzAdminClsENS.IdAdminClsType; //行政班级类型流水号
objvXzAdminClsENT.AdminClsTypeName = objvXzAdminClsENS.AdminClsTypeName; //行政班级类型名称
objvXzAdminClsENT.AdminClsTypeId = objvXzAdminClsENS.AdminClsTypeId; //行政班级类型ID
objvXzAdminClsENT.AdminClsIndex = objvXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objvXzAdminClsENT.Memo = objvXzAdminClsENS.Memo; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzAdminClsEN objvXzAdminClsEN)
{
try
{
objvXzAdminClsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzAdminClsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzAdminCls.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.IdAdminCls = objvXzAdminClsEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convXzAdminCls.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.IdXzMajor = objvXzAdminClsEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convXzAdminCls.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.MajorID = objvXzAdminClsEN.MajorID == "[null]" ? null :  objvXzAdminClsEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convXzAdminCls.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.MajorName = objvXzAdminClsEN.MajorName == "[null]" ? null :  objvXzAdminClsEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convXzAdminCls.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.IdXzCollege = objvXzAdminClsEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convXzAdminCls.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.CollegeId = objvXzAdminClsEN.CollegeId == "[null]" ? null :  objvXzAdminClsEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convXzAdminCls.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.CollegeName = objvXzAdminClsEN.CollegeName == "[null]" ? null :  objvXzAdminClsEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convXzAdminCls.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.CollegeNameA = objvXzAdminClsEN.CollegeNameA == "[null]" ? null :  objvXzAdminClsEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convXzAdminCls.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.ModifyUserId = objvXzAdminClsEN.ModifyUserId == "[null]" ? null :  objvXzAdminClsEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convXzAdminCls.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.ModifyDate = objvXzAdminClsEN.ModifyDate == "[null]" ? null :  objvXzAdminClsEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convXzAdminCls.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.IdUniZone = objvXzAdminClsEN.IdUniZone == "[null]" ? null :  objvXzAdminClsEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convXzAdminCls.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.UniZoneDesc = objvXzAdminClsEN.UniZoneDesc == "[null]" ? null :  objvXzAdminClsEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convXzAdminCls.CurrentStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.CurrentStuQty = objvXzAdminClsEN.CurrentStuQty; //当前学生数
}
if (arrFldSet.Contains(convXzAdminCls.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.IdGradeBase = objvXzAdminClsEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convXzAdminCls.GradeBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.GradeBaseId = objvXzAdminClsEN.GradeBaseId == "[null]" ? null :  objvXzAdminClsEN.GradeBaseId; //年级代号
}
if (arrFldSet.Contains(convXzAdminCls.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.GradeBaseName = objvXzAdminClsEN.GradeBaseName == "[null]" ? null :  objvXzAdminClsEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convXzAdminCls.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.StudyLevelName = objvXzAdminClsEN.StudyLevelName == "[null]" ? null :  objvXzAdminClsEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convXzAdminCls.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.AdminClsName = objvXzAdminClsEN.AdminClsName == "[null]" ? null :  objvXzAdminClsEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convXzAdminCls.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.AdminClsId = objvXzAdminClsEN.AdminClsId == "[null]" ? null :  objvXzAdminClsEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convXzAdminCls.IdAdminClsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.IdAdminClsType = objvXzAdminClsEN.IdAdminClsType == "[null]" ? null :  objvXzAdminClsEN.IdAdminClsType; //行政班级类型流水号
}
if (arrFldSet.Contains(convXzAdminCls.AdminClsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.AdminClsTypeName = objvXzAdminClsEN.AdminClsTypeName == "[null]" ? null :  objvXzAdminClsEN.AdminClsTypeName; //行政班级类型名称
}
if (arrFldSet.Contains(convXzAdminCls.AdminClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.AdminClsTypeId = objvXzAdminClsEN.AdminClsTypeId == "[null]" ? null :  objvXzAdminClsEN.AdminClsTypeId; //行政班级类型ID
}
if (arrFldSet.Contains(convXzAdminCls.AdminClsIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.AdminClsIndex = objvXzAdminClsEN.AdminClsIndex; //AdminClsIndex
}
if (arrFldSet.Contains(convXzAdminCls.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzAdminClsEN.Memo = objvXzAdminClsEN.Memo == "[null]" ? null :  objvXzAdminClsEN.Memo; //备注
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzAdminClsEN objvXzAdminClsEN)
{
try
{
if (objvXzAdminClsEN.MajorID == "[null]") objvXzAdminClsEN.MajorID = null; //专业ID
if (objvXzAdminClsEN.MajorName == "[null]") objvXzAdminClsEN.MajorName = null; //专业名称
if (objvXzAdminClsEN.CollegeId == "[null]") objvXzAdminClsEN.CollegeId = null; //学院ID
if (objvXzAdminClsEN.CollegeName == "[null]") objvXzAdminClsEN.CollegeName = null; //学院名称
if (objvXzAdminClsEN.CollegeNameA == "[null]") objvXzAdminClsEN.CollegeNameA = null; //学院名称简写
if (objvXzAdminClsEN.ModifyUserId == "[null]") objvXzAdminClsEN.ModifyUserId = null; //修改人
if (objvXzAdminClsEN.ModifyDate == "[null]") objvXzAdminClsEN.ModifyDate = null; //修改日期
if (objvXzAdminClsEN.IdUniZone == "[null]") objvXzAdminClsEN.IdUniZone = null; //校区流水号
if (objvXzAdminClsEN.UniZoneDesc == "[null]") objvXzAdminClsEN.UniZoneDesc = null; //校区名称
if (objvXzAdminClsEN.GradeBaseId == "[null]") objvXzAdminClsEN.GradeBaseId = null; //年级代号
if (objvXzAdminClsEN.GradeBaseName == "[null]") objvXzAdminClsEN.GradeBaseName = null; //年级名称
if (objvXzAdminClsEN.StudyLevelName == "[null]") objvXzAdminClsEN.StudyLevelName = null; //学段名称
if (objvXzAdminClsEN.AdminClsName == "[null]") objvXzAdminClsEN.AdminClsName = null; //行政班名称
if (objvXzAdminClsEN.AdminClsId == "[null]") objvXzAdminClsEN.AdminClsId = null; //行政班代号
if (objvXzAdminClsEN.IdAdminClsType == "[null]") objvXzAdminClsEN.IdAdminClsType = null; //行政班级类型流水号
if (objvXzAdminClsEN.AdminClsTypeName == "[null]") objvXzAdminClsEN.AdminClsTypeName = null; //行政班级类型名称
if (objvXzAdminClsEN.AdminClsTypeId == "[null]") objvXzAdminClsEN.AdminClsTypeId = null; //行政班级类型ID
if (objvXzAdminClsEN.Memo == "[null]") objvXzAdminClsEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvXzAdminClsEN objvXzAdminClsEN)
{
 vXzAdminClsDA.CheckProperty4Condition(objvXzAdminClsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdAdminCls(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzAdminCls.IdAdminCls); 
List<clsvXzAdminClsEN> arrObjLst = clsvXzAdminClsBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN()
{
IdAdminCls = "0",
AdminClsName = "选[v行政班]..."
};
arrObjLst.Insert(0, objvXzAdminClsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzAdminCls.IdAdminCls;
objComboBox.DisplayMember = convXzAdminCls.AdminClsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdAdminCls(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v行政班]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convXzAdminCls.IdAdminCls); 
IEnumerable<clsvXzAdminClsEN> arrObjLst = clsvXzAdminClsBL.GetObjLst(strCondition);
objDDL.DataValueField = convXzAdminCls.IdAdminCls;
objDDL.DataTextField = convXzAdminCls.AdminClsName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdAdminClsCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v行政班]...","0");
List<clsvXzAdminClsEN> arrvXzAdminClsObjLst = GetAllvXzAdminClsObjLstCache(); 
objDDL.DataValueField = convXzAdminCls.IdAdminCls;
objDDL.DataTextField = convXzAdminCls.AdminClsName;
objDDL.DataSource = arrvXzAdminClsObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdAdminCls");
//if (arrvXzAdminClsObjLstCache == null)
//{
//arrvXzAdminClsObjLstCache = vXzAdminClsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzAdminClsEN GetObjByIdAdminClsCache(string strIdAdminCls)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLstCache = GetObjLstCache();
IEnumerable <clsvXzAdminClsEN> arrvXzAdminClsObjLst_Sel =
arrvXzAdminClsObjLstCache
.Where(x=> x.IdAdminCls == strIdAdminCls 
);
if (arrvXzAdminClsObjLst_Sel.Count() == 0)
{
   clsvXzAdminClsEN obj = clsvXzAdminClsBL.GetObjByIdAdminCls(strIdAdminCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzAdminClsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAdminClsNameByIdAdminClsCache(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true) return "";
//获取缓存中的对象列表
clsvXzAdminClsEN objvXzAdminCls = GetObjByIdAdminClsCache(strIdAdminCls);
if (objvXzAdminCls == null) return "";
return objvXzAdminCls.AdminClsName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdAdminClsCache(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true) return "";
//获取缓存中的对象列表
clsvXzAdminClsEN objvXzAdminCls = GetObjByIdAdminClsCache(strIdAdminCls);
if (objvXzAdminCls == null) return "";
return objvXzAdminCls.AdminClsName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzAdminClsEN> GetAllvXzAdminClsObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzAdminClsEN> arrvXzAdminClsObjLstCache = GetObjLstCache(); 
return arrvXzAdminClsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzAdminClsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName);
List<clsvXzAdminClsEN> arrvXzAdminClsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzAdminClsObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvXzAdminClsEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdAdminCls)
{
if (strInFldName != convXzAdminCls.IdAdminCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzAdminCls.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzAdminCls.AttributeName));
throw new Exception(strMsg);
}
var objvXzAdminCls = clsvXzAdminClsBL.GetObjByIdAdminClsCache(strIdAdminCls);
if (objvXzAdminCls == null) return "";
return objvXzAdminCls[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvXzAdminClsDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvXzAdminClsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzAdminClsDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvXzAdminClsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzAdminClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzAdminClsEN objvXzAdminClsCond)
{
List<clsvXzAdminClsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzAdminClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzAdminCls.AttributeName)
{
if (objvXzAdminClsCond.IsUpdated(strFldName) == false) continue;
if (objvXzAdminClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzAdminClsCond[strFldName].ToString());
}
else
{
if (objvXzAdminClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzAdminClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzAdminClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzAdminClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzAdminClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzAdminClsCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvXzAdminClsDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vXzAdminClsDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vXzAdminClsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}