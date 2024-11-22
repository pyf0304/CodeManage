
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseRelaInfoWApi
 表名:CaseRelaInfo(01120389)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:25
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN Setid_CaseRelaInfo(this clsCaseRelaInfoEN objCaseRelaInfoEN, long lngid_CaseRelaInfo, string strComparisonOp="")
	{
objCaseRelaInfoEN.id_CaseRelaInfo = lngid_CaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.id_CaseRelaInfo) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.id_CaseRelaInfo, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.id_CaseRelaInfo] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetFuncModuleId1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strFuncModuleId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId1, conCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldLen(strFuncModuleId1, 4, conCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId1, 4, conCaseRelaInfo.FuncModuleId1);
objCaseRelaInfoEN.FuncModuleId1 = strFuncModuleId1; //功能模块Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.FuncModuleId1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.FuncModuleId1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseId1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId1, conCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldLen(strCaseId1, 8, conCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldForeignKey(strCaseId1, 8, conCaseRelaInfo.CaseId1);
objCaseRelaInfoEN.CaseId1 = strCaseId1; //案例Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseId1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseId1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseId1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseName1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseName1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName1, conCaseRelaInfo.CaseName1);
clsCheckSql.CheckFieldLen(strCaseName1, 100, conCaseRelaInfo.CaseName1);
objCaseRelaInfoEN.CaseName1 = strCaseName1; //案例名称1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseName1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseName1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseName1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetOwnerId1(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strOwnerId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId1, 20, conCaseRelaInfo.OwnerId1);
objCaseRelaInfoEN.OwnerId1 = strOwnerId1; //拥有者Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.OwnerId1) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.OwnerId1, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.OwnerId1] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetFuncModuleId2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strFuncModuleId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId2, conCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldLen(strFuncModuleId2, 4, conCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId2, 4, conCaseRelaInfo.FuncModuleId2);
objCaseRelaInfoEN.FuncModuleId2 = strFuncModuleId2; //功能模块Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.FuncModuleId2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.FuncModuleId2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseId2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId2, conCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldLen(strCaseId2, 8, conCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldForeignKey(strCaseId2, 8, conCaseRelaInfo.CaseId2);
objCaseRelaInfoEN.CaseId2 = strCaseId2; //案例Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseId2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseId2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseId2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetCaseName2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strCaseName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName2, conCaseRelaInfo.CaseName2);
clsCheckSql.CheckFieldLen(strCaseName2, 100, conCaseRelaInfo.CaseName2);
objCaseRelaInfoEN.CaseName2 = strCaseName2; //案例名称2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.CaseName2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.CaseName2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.CaseName2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetOwnerId2(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strOwnerId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId2, 20, conCaseRelaInfo.OwnerId2);
objCaseRelaInfoEN.OwnerId2 = strOwnerId2; //拥有者Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.OwnerId2) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.OwnerId2, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.OwnerId2] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetRelationsDegree(this clsCaseRelaInfoEN objCaseRelaInfoEN, int intRelationsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRelationsDegree, conCaseRelaInfo.RelationsDegree);
objCaseRelaInfoEN.RelationsDegree = intRelationsDegree; //关系度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.RelationsDegree) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.RelationsDegree, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.RelationsDegree] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN Setid_CaseRelaInfoType(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strid_CaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CaseRelaInfoType, conCaseRelaInfo.id_CaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_CaseRelaInfoType, 4, conCaseRelaInfo.id_CaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_CaseRelaInfoType, 4, conCaseRelaInfo.id_CaseRelaInfoType);
objCaseRelaInfoEN.id_CaseRelaInfoType = strid_CaseRelaInfoType; //案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.id_CaseRelaInfoType) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.id_CaseRelaInfoType, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.id_CaseRelaInfoType] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetBrowseCount(this clsCaseRelaInfoEN objCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseRelaInfo.BrowseCount);
objCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.BrowseCount) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetUpdDate(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseRelaInfo.UpdDate);
objCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.UpdDate) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetUpdUserId(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseRelaInfo.UpdUserId);
objCaseRelaInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.UpdUserId) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.UpdUserId, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.UpdUserId] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseRelaInfoEN SetMemo(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseRelaInfo.Memo);
objCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conCaseRelaInfo.Memo) == false)
{
objCaseRelaInfoEN.dicFldComparisonOp.Add(conCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objCaseRelaInfoEN.dicFldComparisonOp[conCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseRelaInfoEN objCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.id_CaseRelaInfo) == true)
{
string strComparisonOp_id_CaseRelaInfo = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.id_CaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseRelaInfo.id_CaseRelaInfo, objCaseRelaInfo_Cond.id_CaseRelaInfo, strComparisonOp_id_CaseRelaInfo);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.FuncModuleId1) == true)
{
string strComparisonOp_FuncModuleId1 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.FuncModuleId1, objCaseRelaInfo_Cond.FuncModuleId1, strComparisonOp_FuncModuleId1);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.CaseId1) == true)
{
string strComparisonOp_CaseId1 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.CaseId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseId1, objCaseRelaInfo_Cond.CaseId1, strComparisonOp_CaseId1);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.CaseName1) == true)
{
string strComparisonOp_CaseName1 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.CaseName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseName1, objCaseRelaInfo_Cond.CaseName1, strComparisonOp_CaseName1);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.OwnerId1) == true)
{
string strComparisonOp_OwnerId1 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.OwnerId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.OwnerId1, objCaseRelaInfo_Cond.OwnerId1, strComparisonOp_OwnerId1);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.FuncModuleId2) == true)
{
string strComparisonOp_FuncModuleId2 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.FuncModuleId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.FuncModuleId2, objCaseRelaInfo_Cond.FuncModuleId2, strComparisonOp_FuncModuleId2);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.CaseId2) == true)
{
string strComparisonOp_CaseId2 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.CaseId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseId2, objCaseRelaInfo_Cond.CaseId2, strComparisonOp_CaseId2);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.CaseName2) == true)
{
string strComparisonOp_CaseName2 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.CaseName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.CaseName2, objCaseRelaInfo_Cond.CaseName2, strComparisonOp_CaseName2);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.OwnerId2) == true)
{
string strComparisonOp_OwnerId2 = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.OwnerId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.OwnerId2, objCaseRelaInfo_Cond.OwnerId2, strComparisonOp_OwnerId2);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.RelationsDegree) == true)
{
string strComparisonOp_RelationsDegree = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseRelaInfo.RelationsDegree, objCaseRelaInfo_Cond.RelationsDegree, strComparisonOp_RelationsDegree);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.id_CaseRelaInfoType) == true)
{
string strComparisonOp_id_CaseRelaInfoType = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.id_CaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.id_CaseRelaInfoType, objCaseRelaInfo_Cond.id_CaseRelaInfoType, strComparisonOp_id_CaseRelaInfoType);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseRelaInfo.BrowseCount, objCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.UpdDate, objCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.UpdUserId, objCaseRelaInfo_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCaseRelaInfo_Cond.IsUpdated(conCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objCaseRelaInfo_Cond.dicFldComparisonOp[conCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseRelaInfo.Memo, objCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 if (objCaseRelaInfoEN.id_CaseRelaInfo == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCaseRelaInfoEN.sf_UpdFldSetStr = objCaseRelaInfoEN.getsf_UpdFldSetStr();
clsCaseRelaInfoWApi.CheckPropertyNew(objCaseRelaInfoEN); 
bool bolResult = clsCaseRelaInfoWApi.UpdateRecord(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CaseRelaInfo(案例相关信息), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CaseId1_CaseId2_id_CaseRelaInfoType(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseRelaInfoEN == null) return "";
if (objCaseRelaInfoEN.id_CaseRelaInfo == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId1 = '{0}'", objCaseRelaInfoEN.CaseId1);
 sbCondition.AppendFormat(" and CaseId2 = '{0}'", objCaseRelaInfoEN.CaseId2);
 sbCondition.AppendFormat(" and id_CaseRelaInfoType = '{0}'", objCaseRelaInfoEN.id_CaseRelaInfoType);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_CaseRelaInfo !=  {0}", objCaseRelaInfoEN.id_CaseRelaInfo);
 sbCondition.AppendFormat(" and CaseId1 = '{0}'", objCaseRelaInfoEN.CaseId1);
 sbCondition.AppendFormat(" and CaseId2 = '{0}'", objCaseRelaInfoEN.CaseId2);
 sbCondition.AppendFormat(" and id_CaseRelaInfoType = '{0}'", objCaseRelaInfoEN.id_CaseRelaInfoType);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseRelaInfoEN objCaseRelaInfoEN)
{
try
{
clsCaseRelaInfoWApi.CheckPropertyNew(objCaseRelaInfoEN); 
bool bolResult = clsCaseRelaInfoWApi.AddNewRecord(objCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoWApi.ReFreshCache();
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
 /// <param name = "objCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseRelaInfoEN objCaseRelaInfoEN, string strWhereCond)
{
try
{
clsCaseRelaInfoWApi.CheckPropertyNew(objCaseRelaInfoEN); 
bool bolResult = clsCaseRelaInfoWApi.UpdateWithCondition(objCaseRelaInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoWApi.ReFreshCache();
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
 /// 案例相关信息(CaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "CaseRelaInfoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
if (!Object.Equals(null, objCaseRelaInfoEN.FuncModuleId1) && GetStrLen(objCaseRelaInfoEN.FuncModuleId1) > 4)
{
 throw new Exception("字段[功能模块Id1]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.CaseId1) && GetStrLen(objCaseRelaInfoEN.CaseId1) > 8)
{
 throw new Exception("字段[案例Id1]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.CaseName1) && GetStrLen(objCaseRelaInfoEN.CaseName1) > 100)
{
 throw new Exception("字段[案例名称1]的长度不能超过100!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.OwnerId1) && GetStrLen(objCaseRelaInfoEN.OwnerId1) > 20)
{
 throw new Exception("字段[拥有者Id1]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.FuncModuleId2) && GetStrLen(objCaseRelaInfoEN.FuncModuleId2) > 4)
{
 throw new Exception("字段[功能模块Id2]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.CaseId2) && GetStrLen(objCaseRelaInfoEN.CaseId2) > 8)
{
 throw new Exception("字段[案例Id2]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.CaseName2) && GetStrLen(objCaseRelaInfoEN.CaseName2) > 100)
{
 throw new Exception("字段[案例名称2]的长度不能超过100!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.OwnerId2) && GetStrLen(objCaseRelaInfoEN.OwnerId2) > 20)
{
 throw new Exception("字段[拥有者Id2]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.id_CaseRelaInfoType) && GetStrLen(objCaseRelaInfoEN.id_CaseRelaInfoType) > 4)
{
 throw new Exception("字段[案例相关信息类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.UpdDate) && GetStrLen(objCaseRelaInfoEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.UpdUserId) && GetStrLen(objCaseRelaInfoEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseRelaInfoEN.Memo) && GetStrLen(objCaseRelaInfoEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCaseRelaInfoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseRelaInfoEN GetObjByid_CaseRelaInfo(long lngid_CaseRelaInfo)
{
string strAction = "GetObjByid_CaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseRelaInfoEN objCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseRelaInfo"] = lngid_CaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseRelaInfoEN = JsonConvert.DeserializeObject<clsCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objCaseRelaInfoEN;
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
 /// <param name = "lngid_CaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseRelaInfoEN GetObjByid_CaseRelaInfo_WA_Cache(long lngid_CaseRelaInfo)
{
string strAction = "GetObjByid_CaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseRelaInfoEN objCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseRelaInfo"] = lngid_CaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseRelaInfoEN = JsonConvert.DeserializeObject<clsCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objCaseRelaInfoEN;
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
public static clsCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseRelaInfoEN objCaseRelaInfoEN = null;
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
objCaseRelaInfoEN = JsonConvert.DeserializeObject<clsCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objCaseRelaInfoEN;
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
 /// <param name = "lngid_CaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseRelaInfoEN GetObjByid_CaseRelaInfo_Cache(long lngid_CaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName_S);
List<clsCaseRelaInfoEN> arrCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseRelaInfoEN> arrCaseRelaInfoObjLst_Sel =
from objCaseRelaInfoEN in arrCaseRelaInfoObjLst_Cache
where objCaseRelaInfoEN.id_CaseRelaInfo == lngid_CaseRelaInfo
select objCaseRelaInfoEN;
if (arrCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsCaseRelaInfoEN obj = clsCaseRelaInfoWApi.GetObjByid_CaseRelaInfo(lngid_CaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseRelaInfoEN> GetObjLstById_CaseRelaInfoLst(List<long> arrId_CaseRelaInfo)
{
 List<clsCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCaseRelaInfoEN> GetObjLstById_CaseRelaInfoLst_Cache(List<long> arrId_CaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName_S);
List<clsCaseRelaInfoEN> arrCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseRelaInfoEN> arrCaseRelaInfoObjLst_Sel =
from objCaseRelaInfoEN in arrCaseRelaInfoObjLst_Cache
where arrId_CaseRelaInfo.Contains(objCaseRelaInfoEN.id_CaseRelaInfo)
select objCaseRelaInfoEN;
return arrCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLstById_CaseRelaInfoLst_WA_Cache(List<long> arrId_CaseRelaInfo)
{
 List<clsCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_CaseRelaInfo)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCaseRelaInfoEN objCaseRelaInfoEN = clsCaseRelaInfoWApi.GetObjByid_CaseRelaInfo(lngid_CaseRelaInfo);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_CaseRelaInfo.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseRelaInfoWApi.ReFreshCache();
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
public static int DelCaseRelaInfos(List<string> arrid_CaseRelaInfo)
{
string strAction = "DelCaseRelaInfos";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CaseRelaInfo);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseRelaInfoWApi.ReFreshCache();
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
public static int DelCaseRelaInfosByCond(string strWhereCond)
{
string strAction = "DelCaseRelaInfosByCond";
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
public static bool AddNewRecord(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseRelaInfoEN>(objCaseRelaInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoWApi.ReFreshCache();
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
 /// <param name = "objCaseRelaInfoEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseRelaInfoEN>(objCaseRelaInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseRelaInfoWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
if (string.IsNullOrEmpty(objCaseRelaInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseRelaInfoEN.id_CaseRelaInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseRelaInfoEN>(objCaseRelaInfoEN);
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
 /// <param name = "objCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCaseRelaInfoEN objCaseRelaInfoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCaseRelaInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseRelaInfoEN.id_CaseRelaInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseRelaInfoEN.id_CaseRelaInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseRelaInfoEN>(objCaseRelaInfoEN);
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
public static bool IsExist(long lngid_CaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseRelaInfo"] = lngid_CaseRelaInfo.ToString()
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
 /// <param name = "objCaseRelaInfoENS">源对象</param>
 /// <param name = "objCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsCaseRelaInfoEN objCaseRelaInfoENS, clsCaseRelaInfoEN objCaseRelaInfoENT)
{
try
{
objCaseRelaInfoENT.id_CaseRelaInfo = objCaseRelaInfoENS.id_CaseRelaInfo; //案例相关信息流水号
objCaseRelaInfoENT.FuncModuleId1 = objCaseRelaInfoENS.FuncModuleId1; //功能模块Id1
objCaseRelaInfoENT.CaseId1 = objCaseRelaInfoENS.CaseId1; //案例Id1
objCaseRelaInfoENT.CaseName1 = objCaseRelaInfoENS.CaseName1; //案例名称1
objCaseRelaInfoENT.OwnerId1 = objCaseRelaInfoENS.OwnerId1; //拥有者Id1
objCaseRelaInfoENT.FuncModuleId2 = objCaseRelaInfoENS.FuncModuleId2; //功能模块Id2
objCaseRelaInfoENT.CaseId2 = objCaseRelaInfoENS.CaseId2; //案例Id2
objCaseRelaInfoENT.CaseName2 = objCaseRelaInfoENS.CaseName2; //案例名称2
objCaseRelaInfoENT.OwnerId2 = objCaseRelaInfoENS.OwnerId2; //拥有者Id2
objCaseRelaInfoENT.RelationsDegree = objCaseRelaInfoENS.RelationsDegree; //关系度
objCaseRelaInfoENT.id_CaseRelaInfoType = objCaseRelaInfoENS.id_CaseRelaInfoType; //案例相关信息类型流水号
objCaseRelaInfoENT.BrowseCount = objCaseRelaInfoENS.BrowseCount; //浏览次数
objCaseRelaInfoENT.UpdDate = objCaseRelaInfoENS.UpdDate; //修改日期
objCaseRelaInfoENT.UpdUserId = objCaseRelaInfoENS.UpdUserId; //修改用户Id
objCaseRelaInfoENT.Memo = objCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCaseRelaInfoEN.AttributeName)
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
if (clsCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseRelaInfoWApi没有刷新缓存机制(clsCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CaseRelaInfo");
//if (arrCaseRelaInfoObjLst_Cache == null)
//{
//arrCaseRelaInfoObjLst_Cache = await clsCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName_S);
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
if (clsCaseRelaInfoWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCaseRelaInfoWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCaseRelaInfoEN._CurrTabName_S);
List<clsCaseRelaInfoEN> arrCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCaseRelaInfo.id_CaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(conCaseRelaInfo.FuncModuleId1, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.CaseId1, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.CaseName1, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.OwnerId1, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.FuncModuleId2, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.CaseId2, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.CaseName2, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.OwnerId2, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.RelationsDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseRelaInfo.id_CaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCaseRelaInfo.id_CaseRelaInfo] = objInFor[conCaseRelaInfo.id_CaseRelaInfo];
objDR[conCaseRelaInfo.FuncModuleId1] = objInFor[conCaseRelaInfo.FuncModuleId1];
objDR[conCaseRelaInfo.CaseId1] = objInFor[conCaseRelaInfo.CaseId1];
objDR[conCaseRelaInfo.CaseName1] = objInFor[conCaseRelaInfo.CaseName1];
objDR[conCaseRelaInfo.OwnerId1] = objInFor[conCaseRelaInfo.OwnerId1];
objDR[conCaseRelaInfo.FuncModuleId2] = objInFor[conCaseRelaInfo.FuncModuleId2];
objDR[conCaseRelaInfo.CaseId2] = objInFor[conCaseRelaInfo.CaseId2];
objDR[conCaseRelaInfo.CaseName2] = objInFor[conCaseRelaInfo.CaseName2];
objDR[conCaseRelaInfo.OwnerId2] = objInFor[conCaseRelaInfo.OwnerId2];
objDR[conCaseRelaInfo.RelationsDegree] = objInFor[conCaseRelaInfo.RelationsDegree];
objDR[conCaseRelaInfo.id_CaseRelaInfoType] = objInFor[conCaseRelaInfo.id_CaseRelaInfoType];
objDR[conCaseRelaInfo.BrowseCount] = objInFor[conCaseRelaInfo.BrowseCount];
objDR[conCaseRelaInfo.UpdDate] = objInFor[conCaseRelaInfo.UpdDate];
objDR[conCaseRelaInfo.UpdUserId] = objInFor[conCaseRelaInfo.UpdUserId];
objDR[conCaseRelaInfo.Memo] = objInFor[conCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例相关信息(CaseRelaInfo)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CaseRelaInfo : clsCommFun4BL
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
clsCaseRelaInfoWApi.ReFreshThisCache();
}
}

}