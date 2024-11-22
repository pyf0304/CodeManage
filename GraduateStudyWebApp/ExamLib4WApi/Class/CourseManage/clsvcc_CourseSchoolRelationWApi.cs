
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseSchoolRelationWApi
 表名:vcc_CourseSchoolRelation(01120334)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:22
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理
 模块英文名:CourseManage
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
public static class clsvcc_CourseSchoolRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetmId(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, long lngmId, string strComparisonOp="")
	{
objvcc_CourseSchoolRelationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.mId) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.mId, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.mId] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN Setid_School(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convcc_CourseSchoolRelation.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convcc_CourseSchoolRelation.id_School);
objvcc_CourseSchoolRelationEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.id_School) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.id_School, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.id_School] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetSchoolId(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convcc_CourseSchoolRelation.SchoolId);
objvcc_CourseSchoolRelationEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.SchoolId) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.SchoolId, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolId] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetSchoolName(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convcc_CourseSchoolRelation.SchoolName);
objvcc_CourseSchoolRelationEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.SchoolName) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.SchoolName, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolName] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetSchoolNameA(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strSchoolNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convcc_CourseSchoolRelation.SchoolNameA);
objvcc_CourseSchoolRelationEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.SchoolNameA) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.SchoolNameA, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolNameA] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetCourseId(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseSchoolRelation.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseSchoolRelation.CourseId);
objvcc_CourseSchoolRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.CourseId) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.CourseId, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseId] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetCourseName(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseSchoolRelation.CourseName);
objvcc_CourseSchoolRelationEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.CourseName) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.CourseName, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseName] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetOrderNum(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, int intOrderNum, string strComparisonOp="")
	{
objvcc_CourseSchoolRelationEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.OrderNum) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetUpdDate(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseSchoolRelation.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseSchoolRelation.UpdDate);
objvcc_CourseSchoolRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.UpdDate) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetUpdUser(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_CourseSchoolRelation.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseSchoolRelation.UpdUser);
objvcc_CourseSchoolRelationEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.UpdUser) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseSchoolRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseSchoolRelationEN SetMemo(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseSchoolRelation.Memo);
objvcc_CourseSchoolRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseSchoolRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseSchoolRelation.Memo) == false)
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp.Add(convcc_CourseSchoolRelation.Memo, strComparisonOp);
}
else
{
objvcc_CourseSchoolRelationEN.dicFldComparisonOp[convcc_CourseSchoolRelation.Memo] = strComparisonOp;
}
}
return objvcc_CourseSchoolRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.mId) == true)
{
string strComparisonOp_mId = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseSchoolRelation.mId, objvcc_CourseSchoolRelation_Cond.mId, strComparisonOp_mId);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.id_School) == true)
{
string strComparisonOp_id_School = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.id_School, objvcc_CourseSchoolRelation_Cond.id_School, strComparisonOp_id_School);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.SchoolId, objvcc_CourseSchoolRelation_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.SchoolName, objvcc_CourseSchoolRelation_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.SchoolNameA) == true)
{
string strComparisonOp_SchoolNameA = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.SchoolNameA, objvcc_CourseSchoolRelation_Cond.SchoolNameA, strComparisonOp_SchoolNameA);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.CourseId, objvcc_CourseSchoolRelation_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.CourseName, objvcc_CourseSchoolRelation_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseSchoolRelation.OrderNum, objvcc_CourseSchoolRelation_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.UpdDate, objvcc_CourseSchoolRelation_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.UpdUser, objvcc_CourseSchoolRelation_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_CourseSchoolRelation_Cond.IsUpdated(convcc_CourseSchoolRelation.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseSchoolRelation_Cond.dicFldComparisonOp[convcc_CourseSchoolRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseSchoolRelation.Memo, objvcc_CourseSchoolRelation_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程和学校关系(vcc_CourseSchoolRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseSchoolRelationWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseSchoolRelationApi";

 public clsvcc_CourseSchoolRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseSchoolRelationEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = null;
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
objvcc_CourseSchoolRelationEN = JsonConvert.DeserializeObject<clsvcc_CourseSchoolRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseSchoolRelationEN;
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
public static clsvcc_CourseSchoolRelationEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = null;
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
objvcc_CourseSchoolRelationEN = JsonConvert.DeserializeObject<clsvcc_CourseSchoolRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseSchoolRelationEN;
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
public static clsvcc_CourseSchoolRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationEN = null;
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
objvcc_CourseSchoolRelationEN = JsonConvert.DeserializeObject<clsvcc_CourseSchoolRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseSchoolRelationEN;
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
public static clsvcc_CourseSchoolRelationEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName_S);
List<clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLst_Sel =
from objvcc_CourseSchoolRelationEN in arrvcc_CourseSchoolRelationObjLst_Cache
where objvcc_CourseSchoolRelationEN.mId == lngmId
select objvcc_CourseSchoolRelationEN;
if (arrvcc_CourseSchoolRelationObjLst_Sel.Count() == 0)
{
   clsvcc_CourseSchoolRelationEN obj = clsvcc_CourseSchoolRelationWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseSchoolRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseSchoolRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseSchoolRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcc_CourseSchoolRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseSchoolRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_CourseSchoolRelationEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName_S);
List<clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLst_Sel =
from objvcc_CourseSchoolRelationEN in arrvcc_CourseSchoolRelationObjLst_Cache
where arrMId.Contains(objvcc_CourseSchoolRelationEN.mId)
select objvcc_CourseSchoolRelationEN;
return arrvcc_CourseSchoolRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvcc_CourseSchoolRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseSchoolRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseSchoolRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseSchoolRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseSchoolRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseSchoolRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseSchoolRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseSchoolRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseSchoolRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseSchoolRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseSchoolRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_CourseSchoolRelationENS">源对象</param>
 /// <param name = "objvcc_CourseSchoolRelationENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENS, clsvcc_CourseSchoolRelationEN objvcc_CourseSchoolRelationENT)
{
try
{
objvcc_CourseSchoolRelationENT.mId = objvcc_CourseSchoolRelationENS.mId; //mId
objvcc_CourseSchoolRelationENT.id_School = objvcc_CourseSchoolRelationENS.id_School; //学校流水号
objvcc_CourseSchoolRelationENT.SchoolId = objvcc_CourseSchoolRelationENS.SchoolId; //学校编号
objvcc_CourseSchoolRelationENT.SchoolName = objvcc_CourseSchoolRelationENS.SchoolName; //学校名称
objvcc_CourseSchoolRelationENT.SchoolNameA = objvcc_CourseSchoolRelationENS.SchoolNameA; //学校简称
objvcc_CourseSchoolRelationENT.CourseId = objvcc_CourseSchoolRelationENS.CourseId; //课程Id
objvcc_CourseSchoolRelationENT.CourseName = objvcc_CourseSchoolRelationENS.CourseName; //课程名称
objvcc_CourseSchoolRelationENT.OrderNum = objvcc_CourseSchoolRelationENS.OrderNum; //序号
objvcc_CourseSchoolRelationENT.UpdDate = objvcc_CourseSchoolRelationENS.UpdDate; //修改日期
objvcc_CourseSchoolRelationENT.UpdUser = objvcc_CourseSchoolRelationENS.UpdUser; //修改人
objvcc_CourseSchoolRelationENT.Memo = objvcc_CourseSchoolRelationENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_CourseSchoolRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseSchoolRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseSchoolRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseSchoolRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseSchoolRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseSchoolRelationEN.AttributeName)
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseSchoolRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseSchoolRelationWApi没有刷新缓存机制(clscc_CourseSchoolRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcc_CourseSchoolRelationObjLst_Cache == null)
//{
//arrvcc_CourseSchoolRelationObjLst_Cache = await clsvcc_CourseSchoolRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName_S);
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
public static List<clsvcc_CourseSchoolRelationEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseSchoolRelationEN._CurrTabName_S);
List<clsvcc_CourseSchoolRelationEN> arrvcc_CourseSchoolRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseSchoolRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseSchoolRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseSchoolRelation.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseSchoolRelation.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.SchoolNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseSchoolRelation.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseSchoolRelation.Memo, Type.GetType("System.String"));
foreach (clsvcc_CourseSchoolRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseSchoolRelation.mId] = objInFor[convcc_CourseSchoolRelation.mId];
objDR[convcc_CourseSchoolRelation.id_School] = objInFor[convcc_CourseSchoolRelation.id_School];
objDR[convcc_CourseSchoolRelation.SchoolId] = objInFor[convcc_CourseSchoolRelation.SchoolId];
objDR[convcc_CourseSchoolRelation.SchoolName] = objInFor[convcc_CourseSchoolRelation.SchoolName];
objDR[convcc_CourseSchoolRelation.SchoolNameA] = objInFor[convcc_CourseSchoolRelation.SchoolNameA];
objDR[convcc_CourseSchoolRelation.CourseId] = objInFor[convcc_CourseSchoolRelation.CourseId];
objDR[convcc_CourseSchoolRelation.CourseName] = objInFor[convcc_CourseSchoolRelation.CourseName];
objDR[convcc_CourseSchoolRelation.OrderNum] = objInFor[convcc_CourseSchoolRelation.OrderNum];
objDR[convcc_CourseSchoolRelation.UpdDate] = objInFor[convcc_CourseSchoolRelation.UpdDate];
objDR[convcc_CourseSchoolRelation.UpdUser] = objInFor[convcc_CourseSchoolRelation.UpdUser];
objDR[convcc_CourseSchoolRelation.Memo] = objInFor[convcc_CourseSchoolRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}