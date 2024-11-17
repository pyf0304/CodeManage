
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorBL
 表名:vXzMajor(01160064)
 生成代码版本:2022.04.24.1
 生成日期:2022/04/25 00:30:16
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsvXzMajorBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strid_Major">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorEN GetObj(this K_id_Major_vXzMajor myKey)
{
clsvXzMajorEN objvXzMajorEN = clsvXzMajorBL.vXzMajorDA.GetObjByid_Major(myKey.Value);
return objvXzMajorEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN Setid_Major(this clsvXzMajorEN objvXzMajorEN, string strid_Major, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strid_Major, 8, convXzMajor.id_Major);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strid_Major, 8, convXzMajor.id_Major);
}
objvXzMajorEN.id_Major = strid_Major; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.id_Major) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.id_Major, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.id_Major] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorID(this clsvXzMajorEN objvXzMajorEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convXzMajor.MajorID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzMajor.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzMajor.MajorID);
}
objvXzMajorEN.MajorID = strMajorID; //MajorID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorID) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorID, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorID] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorName(this clsvXzMajorEN objvXzMajorEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzMajor.MajorName);
}
objvXzMajorEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorName) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorName, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorName] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetIsMainMajor(this clsvXzMajorEN objvXzMajorEN, bool bolIsMainMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMainMajor, convXzMajor.IsMainMajor);
objvXzMajorEN.IsMainMajor = bolIsMainMajor; //是否重要专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IsMainMajor) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IsMainMajor, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IsMainMajor] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetCollegeId(this clsvXzMajorEN objvXzMajorEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, convXzMajor.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 6, convXzMajor.CollegeId);
}
objvXzMajorEN.CollegeId = strCollegeId; //学院Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.CollegeId) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.CollegeId, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.CollegeId] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetCollegeName(this clsvXzMajorEN objvXzMajorEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convXzMajor.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 30, convXzMajor.CollegeName);
}
objvXzMajorEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.CollegeName) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.CollegeName, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.CollegeName] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetOrderNum(this clsvXzMajorEN objvXzMajorEN, int intOrderNum, string strComparisonOp="")
	{
objvXzMajorEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.OrderNum) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.OrderNum, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.OrderNum] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetInUse(this clsvXzMajorEN objvXzMajorEN, bool bolInUse, string strComparisonOp="")
	{
objvXzMajorEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.InUse) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.InUse, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.InUse] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetUpdDate(this clsvXzMajorEN objvXzMajorEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convXzMajor.UpdDate);
}
objvXzMajorEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.UpdDate) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.UpdDate, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.UpdDate] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetUpdUser(this clsvXzMajorEN objvXzMajorEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convXzMajor.UpdUser);
}
objvXzMajorEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.UpdUser) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.UpdUser, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.UpdUser] = strComparisonOp;
}
}
return objvXzMajorEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <param name = "objvXzMajorENT">目标对象</param>
 public static void CopyTo(this clsvXzMajorEN objvXzMajorENS, clsvXzMajorEN objvXzMajorENT)
{
try
{
objvXzMajorENT.id_Major = objvXzMajorENS.id_Major; //专业流水号
objvXzMajorENT.MajorID = objvXzMajorENS.MajorID; //MajorID
objvXzMajorENT.MajorName = objvXzMajorENS.MajorName; //专业名称
objvXzMajorENT.IsMainMajor = objvXzMajorENS.IsMainMajor; //是否重要专业
objvXzMajorENT.CollegeId = objvXzMajorENS.CollegeId; //学院Id
objvXzMajorENT.CollegeName = objvXzMajorENS.CollegeName; //学院名称
objvXzMajorENT.OrderNum = objvXzMajorENS.OrderNum; //排序
objvXzMajorENT.InUse = objvXzMajorENS.InUse; //是否在用
objvXzMajorENT.UpdDate = objvXzMajorENS.UpdDate; //修改日期
objvXzMajorENT.UpdUser = objvXzMajorENS.UpdUser; //修改用户
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
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <returns>目标对象=>clsvXzMajorEN:objvXzMajorENT</returns>
 public static clsvXzMajorEN CopyTo(this clsvXzMajorEN objvXzMajorENS)
{
try
{
 clsvXzMajorEN objvXzMajorENT = new clsvXzMajorEN()
{
id_Major = objvXzMajorENS.id_Major, //专业流水号
MajorID = objvXzMajorENS.MajorID, //MajorID
MajorName = objvXzMajorENS.MajorName, //专业名称
IsMainMajor = objvXzMajorENS.IsMainMajor, //是否重要专业
CollegeId = objvXzMajorENS.CollegeId, //学院Id
CollegeName = objvXzMajorENS.CollegeName, //学院名称
OrderNum = objvXzMajorENS.OrderNum, //排序
InUse = objvXzMajorENS.InUse, //是否在用
UpdDate = objvXzMajorENS.UpdDate, //修改日期
UpdUser = objvXzMajorENS.UpdUser, //修改用户
};
 return objvXzMajorENT;
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
public static void CheckProperty4Condition(this clsvXzMajorEN objvXzMajorEN)
{
 clsvXzMajorBL.vXzMajorDA.CheckProperty4Condition(objvXzMajorEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzMajorEN objvXzMajor_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzMajor_Cond.IsUpdated(convXzMajor.id_Major) == true)
{
string strComparisonOp_id_Major = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.id_Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.id_Major, objvXzMajor_Cond.id_Major, strComparisonOp_id_Major);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorID) == true)
{
string strComparisonOp_MajorID = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorID, objvXzMajor_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorName) == true)
{
string strComparisonOp_MajorName = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorName, objvXzMajor_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.IsMainMajor) == true)
{
if (objvXzMajor_Cond.IsMainMajor == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsMainMajor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsMainMajor);
}
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.CollegeId) == true)
{
string strComparisonOp_CollegeId = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeId, objvXzMajor_Cond.CollegeId, strComparisonOp_CollegeId);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeName, objvXzMajor_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzMajor.OrderNum, objvXzMajor_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.InUse) == true)
{
if (objvXzMajor_Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.InUse);
}
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.UpdDate, objvXzMajor_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.UpdUser, objvXzMajor_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzMajor
{
public virtual bool UpdRelaTabDate(string strid_Major, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vXzMajor(vXzMajor)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzMajorBL
{
public static RelatedActions_vXzMajor relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vXzMajorListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vXzMajorList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzMajorDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzMajorDA vXzMajorDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzMajorDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzMajorBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvXzMajorEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzMajorEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vXzMajorDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vXzMajorDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vXzMajorDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vXzMajor(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTable_vXzMajor(strWhereCond);
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
objDT = vXzMajorDA.GetDataTable(strWhereCond);
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
objDT = vXzMajorDA.GetDataTable(strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTable(strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000008)获取表数据出错!(是否检查SQL攻击), {1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vXzMajorDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzMajorDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabNameWithCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTable(strWhereCond, strTabName, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000063)获取表数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vXzMajorDA.GetDataTable_Top(objTopPara);
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
objDT = vXzMajorDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vXzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrId_MajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstById_MajorLst(List<string> arrId_MajorLst)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrId_MajorLst, true);
 string strWhereCond = string.Format("id_Major in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrId_MajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzMajorEN> GetObjLstById_MajorLst_Cache(List<string> arrId_MajorLst)
{
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel =
arrvXzMajorObjLst_Cache
.Where(x => arrId_MajorLst.Contains(x.id_Major));
return arrvXzMajorObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLst(string strWhereCond)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objvXzMajor_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzMajorEN> GetSubObjLst_Cache(clsvXzMajorEN objvXzMajor_Cond)
{
List<clsvXzMajorEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convXzMajor.AttributeName)
{
if (objvXzMajor_Cond.IsUpdated(strFldName) == false) continue;
if (objvXzMajor_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvXzMajor_Cond[strFldName].ToString());
}
else
{
if (objvXzMajor_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzMajor_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvXzMajor_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzMajor_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzMajor_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzMajor_Cond[strFldName]));
}
}
}
return arrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
List<clsvXzMajorEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzMajorEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
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
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvXzMajorEN> GetObjLstByPager_Cache(int intPageIndex, int intPageSize, clsvXzMajorEN objvXzMajor_Cond, string strOrderBy)
{
List<clsvXzMajorEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convXzMajor.AttributeName)
{
if (objvXzMajor_Cond.IsUpdated(strFldName) == false) continue;
if (objvXzMajor_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvXzMajor_Cond[strFldName].ToString());
}
else
{
if (objvXzMajor_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzMajor_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvXzMajor_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzMajor_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzMajor_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzMajor_Cond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLst_Sel = arrObjLst_Sel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLst_Sel = arrObjLst_Sel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLst_Sel = arrObjLst_Sel.Skip(intSkip).Take(intPageSize);
return arrObjLst_Sel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvXzMajorEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
clsvXzMajorEN objvXzMajor_Cond = JsonConvert.DeserializeObject<clsvXzMajorEN>(objPagerPara.whereCond);
if (objvXzMajor_Cond.sf_FldComparisonOp == null)
{
objvXzMajor_Cond.dicFldComparisonOp = null;
}
else
{
objvXzMajor_Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvXzMajor_Cond.sf_FldComparisonOp);
}
clsvXzMajorBL.SetUpdFlag(objvXzMajor_Cond);
 try
{
CheckProperty4Condition(objvXzMajor_Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000150)在输入条件中含有{0},请检查!(clsvXzMajorBL:GetObjLstByPager_Cache)", objException.Message));
}
 return GetObjLstByPager_Cache(objPagerPara.pageIndex, objPagerPara.pageSize, objvXzMajor_Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.id_Major = objRow[convXzMajor.id_Major].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //MajorID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院Id
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convXzMajor.OrderNum].ToString().Trim()); //排序
objvXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.InUse].ToString().Trim()); //是否在用
objvXzMajorEN.UpdDate = objRow[convXzMajor.UpdDate].ToString().Trim(); //修改日期
objvXzMajorEN.UpdUser = objRow[convXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzMajorEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzMajor(ref clsvXzMajorEN objvXzMajorEN)
{
bool bolResult = vXzMajorDA.GetvXzMajor(ref objvXzMajorEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strid_Major">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorEN GetObjByid_Major(string strid_Major)
{
if (strid_Major.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strid_Major]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strid_Major) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strid_Major]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetObjByid_Major(strid_Major);
return objvXzMajorEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzMajorEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetFirstObj(strWhereCond);
 return objvXzMajorEN;
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
public static clsvXzMajorEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetObjByDataRow(objRow);
 return objvXzMajorEN;
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
public static clsvXzMajorEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetObjByDataRow(objRow);
 return objvXzMajorEN;
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
 /// <param name = "strid_Major">所给的关键字</param>
 /// <param name = "lstvXzMajorObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorEN GetObjByid_MajorFromList(string strid_Major, List<clsvXzMajorEN> lstvXzMajorObjLst)
{
foreach (clsvXzMajorEN objvXzMajorEN in lstvXzMajorObjLst)
{
if (objvXzMajorEN.id_Major == strid_Major)
{
return objvXzMajorEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strid_Major;
 try
 {
 strid_Major = new clsvXzMajorDA().GetFirstID(strWhereCond);
 return strid_Major;
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
 arrList = vXzMajorDA.GetID(strWhereCond);
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
bool bolIsExist = vXzMajorDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strid_Major">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strid_Major)
{
if (string.IsNullOrEmpty(strid_Major) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strid_Major]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzMajorDA.IsExist(strid_Major);
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
 bolIsExist = clsvXzMajorDA.IsExistTable();
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
 bolIsExist = vXzMajorDA.IsExistTable(strTabName);
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
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <param name = "objvXzMajorENT">目标对象</param>
 public static void CopyTo(clsvXzMajorEN objvXzMajorENS, clsvXzMajorEN objvXzMajorENT)
{
try
{
objvXzMajorENT.id_Major = objvXzMajorENS.id_Major; //专业流水号
objvXzMajorENT.MajorID = objvXzMajorENS.MajorID; //MajorID
objvXzMajorENT.MajorName = objvXzMajorENS.MajorName; //专业名称
objvXzMajorENT.IsMainMajor = objvXzMajorENS.IsMainMajor; //是否重要专业
objvXzMajorENT.CollegeId = objvXzMajorENS.CollegeId; //学院Id
objvXzMajorENT.CollegeName = objvXzMajorENS.CollegeName; //学院名称
objvXzMajorENT.OrderNum = objvXzMajorENS.OrderNum; //排序
objvXzMajorENT.InUse = objvXzMajorENS.InUse; //是否在用
objvXzMajorENT.UpdDate = objvXzMajorENS.UpdDate; //修改日期
objvXzMajorENT.UpdUser = objvXzMajorENS.UpdUser; //修改用户
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
 /// <param name = "objvXzMajorEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzMajorEN objvXzMajorEN)
{
try
{
objvXzMajorEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvXzMajorEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzMajor.id_Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.id_Major = objvXzMajorEN.id_Major; //专业流水号
}
if (arrFldSet.Contains(convXzMajor.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorID = objvXzMajorEN.MajorID; //MajorID
}
if (arrFldSet.Contains(convXzMajor.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorName = objvXzMajorEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convXzMajor.IsMainMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IsMainMajor = objvXzMajorEN.IsMainMajor; //是否重要专业
}
if (arrFldSet.Contains(convXzMajor.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.CollegeId = objvXzMajorEN.CollegeId; //学院Id
}
if (arrFldSet.Contains(convXzMajor.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.CollegeName = objvXzMajorEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convXzMajor.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.OrderNum = objvXzMajorEN.OrderNum; //排序
}
if (arrFldSet.Contains(convXzMajor.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.InUse = objvXzMajorEN.InUse; //是否在用
}
if (arrFldSet.Contains(convXzMajor.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.UpdDate = objvXzMajorEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convXzMajor.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.UpdUser = objvXzMajorEN.UpdUser; //修改用户
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvXzMajorEN objvXzMajorEN)
{
 vXzMajorDA.CheckProperty4Condition(objvXzMajorEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsCollegeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCollegeBL没有刷新缓存机制(clsCollegeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_Major");
//if (arrvXzMajorObjLst_Cache == null)
//{
//arrvXzMajorObjLst_Cache = vXzMajorDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_Major">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorEN GetObjByid_Major_Cache(string strid_Major)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel =
arrvXzMajorObjLst_Cache
.Where(x => x.id_Major == strid_Major);
if (arrvXzMajorObjLst_Sel.Count() == 0)
{
   clsvXzMajorEN obj = clsvXzMajorBL.GetObjByid_Major(strid_Major);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return null;
 }
return null;
}
return arrvXzMajorObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzMajorEN> GetAllvXzMajorObjLst_Cache()
{
//获取缓存中的对象列表
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = GetObjLst_Cache(); 
return arrvXzMajorObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzMajorEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzMajorObjLst_Cache;
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
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
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
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvXzMajorObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvXzMajorEN> lstvXzMajorObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvXzMajorObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvXzMajorObjLst">[clsvXzMajorEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvXzMajorEN> lstvXzMajorObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvXzMajorBL.listXmlNode);
writer.WriteStartElement(clsvXzMajorBL.itemsXmlNode);
foreach (clsvXzMajorEN objvXzMajorEN in lstvXzMajorObjLst)
{
clsvXzMajorBL.SerializeXML(writer, objvXzMajorEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvXzMajorEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvXzMajorEN objvXzMajorEN)
{
writer.WriteStartElement(clsvXzMajorBL.itemXmlNode);
 
if (objvXzMajorEN.id_Major != null)
{
writer.WriteElementString(convXzMajor.id_Major, objvXzMajorEN.id_Major.ToString(CultureInfo.InvariantCulture));
}
 
if (objvXzMajorEN.MajorID != null)
{
writer.WriteElementString(convXzMajor.MajorID, objvXzMajorEN.MajorID.ToString(CultureInfo.InvariantCulture));
}
 
if (objvXzMajorEN.MajorName != null)
{
writer.WriteElementString(convXzMajor.MajorName, objvXzMajorEN.MajorName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convXzMajor.IsMainMajor, objvXzMajorEN.IsMainMajor.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvXzMajorEN.CollegeId != null)
{
writer.WriteElementString(convXzMajor.CollegeId, objvXzMajorEN.CollegeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvXzMajorEN.CollegeName != null)
{
writer.WriteElementString(convXzMajor.CollegeName, objvXzMajorEN.CollegeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convXzMajor.OrderNum, objvXzMajorEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convXzMajor.InUse, objvXzMajorEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvXzMajorEN.UpdDate != null)
{
writer.WriteElementString(convXzMajor.UpdDate, objvXzMajorEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvXzMajorEN.UpdUser != null)
{
writer.WriteElementString(convXzMajor.UpdUser, objvXzMajorEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvXzMajorEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
reader.Read();
while (!(reader.Name == clsvXzMajorBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convXzMajor.id_Major))
{
objvXzMajorEN.id_Major = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convXzMajor.MajorID))
{
objvXzMajorEN.MajorID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convXzMajor.MajorName))
{
objvXzMajorEN.MajorName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convXzMajor.IsMainMajor))
{
objvXzMajorEN.IsMainMajor = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convXzMajor.CollegeId))
{
objvXzMajorEN.CollegeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convXzMajor.CollegeName))
{
objvXzMajorEN.CollegeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convXzMajor.OrderNum))
{
objvXzMajorEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convXzMajor.InUse))
{
objvXzMajorEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convXzMajor.UpdDate))
{
objvXzMajorEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convXzMajor.UpdUser))
{
objvXzMajorEN.UpdUser = reader.ReadElementContentAsString();
}
}
return objvXzMajorEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvXzMajorObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvXzMajorEN GetObjFromXmlStr(string strvXzMajorObjXmlStr)
{
clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvXzMajorObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvXzMajorBL.itemXmlNode))
{
objvXzMajorEN = GetObjFromXml(reader);
return objvXzMajorEN;
}
}
return objvXzMajorEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvXzMajorEN objvXzMajorEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvXzMajorEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strid_Major)
{
if (strInFldName != convXzMajor.id_Major)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzMajor.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzMajor.AttributeName));
throw new Exception(strMsg);
}
var objvXzMajor = clsvXzMajorBL.GetObjByid_Major_Cache(strid_Major );
if (objvXzMajor == null) return "";
return objvXzMajor[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvXzMajorEN objvXzMajorEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvXzMajorEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvXzMajorEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvXzMajorObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvXzMajorEN> lstvXzMajorObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvXzMajorObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvXzMajorEN objvXzMajorEN in lstvXzMajorObjLst)
{
string strJSON_One = SerializeObjToJSON(objvXzMajorEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvXzMajorDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzMajorDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzMajorDA.GetRecCount();
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
int intRecCount = clsvXzMajorDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objvXzMajor_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsvXzMajorEN objvXzMajor_Cond)
{
List<clsvXzMajorEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convXzMajor.AttributeName)
{
if (objvXzMajor_Cond.IsUpdated(strFldName) == false) continue;
if (objvXzMajor_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvXzMajor_Cond[strFldName].ToString());
}
else
{
if (objvXzMajor_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzMajor_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvXzMajor_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzMajor_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzMajor_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzMajor_Cond[strFldName]));
}
}
}
return arrObjLst_Sel.Count();
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
 List<string> arrList = clsvXzMajorDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzMajorDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzMajorDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}