
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentBL
 表名:vStudent(01160065)
 生成代码版本:2022.04.24.1
 生成日期:2022/04/25 00:30:18
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
public static class clsvStudentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strid_stu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentEN GetObj(this K_id_stu_vStudent myKey)
{
clsvStudentEN objvStudentEN = clsvStudentBL.vStudentDA.GetObjByid_stu(myKey.Value);
return objvStudentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN Setid_stu(this clsvStudentEN objvStudentEN, string strid_stu, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strid_stu, 8, convStudent.id_stu);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strid_stu, 8, convStudent.id_stu);
}
objvStudentEN.id_stu = strid_stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.id_stu) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.id_stu, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.id_stu] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetStuID(this clsvStudentEN objvStudentEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuID, convStudent.StuID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convStudent.StuID);
}
objvStudentEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.StuID) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.StuID, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.StuID] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetStuName(this clsvStudentEN objvStudentEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convStudent.StuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convStudent.StuName);
}
objvStudentEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.StuName) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.StuName, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.StuName] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetAge(this clsvStudentEN objvStudentEN, int intAge, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAge, convStudent.Age);
objvStudentEN.Age = intAge; //Age
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.Age) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.Age, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.Age] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetCollegeId(this clsvStudentEN objvStudentEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, convStudent.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 6, convStudent.CollegeId);
}
objvStudentEN.CollegeId = strCollegeId; //学院Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.CollegeId) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.CollegeId, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.CollegeId] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetCollegeName(this clsvStudentEN objvStudentEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convStudent.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 30, convStudent.CollegeName);
}
objvStudentEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.CollegeName) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.CollegeName, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.CollegeName] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN Setid_Major(this clsvStudentEN objvStudentEN, string strid_Major, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strid_Major, 8, convStudent.id_Major);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strid_Major, 8, convStudent.id_Major);
}
objvStudentEN.id_Major = strid_Major; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.id_Major) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.id_Major, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.id_Major] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetMajorID(this clsvStudentEN objvStudentEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convStudent.MajorID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convStudent.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convStudent.MajorID);
}
objvStudentEN.MajorID = strMajorID; //MajorID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.MajorID) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.MajorID, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.MajorID] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetMajorName(this clsvStudentEN objvStudentEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convStudent.MajorName);
}
objvStudentEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.MajorName) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.MajorName, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.MajorName] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetMemo(this clsvStudentEN objvStudentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convStudent.Memo);
}
objvStudentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.Memo) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.Memo, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.Memo] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetOrderNum(this clsvStudentEN objvStudentEN, int intOrderNum, string strComparisonOp="")
	{
objvStudentEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.OrderNum) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.OrderNum, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.OrderNum] = strComparisonOp;
}
}
return objvStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentEN SetIsDelete(this clsvStudentEN objvStudentEN, bool bolIsDelete, string strComparisonOp="")
	{
objvStudentEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentEN.dicFldComparisonOp.ContainsKey(convStudent.IsDelete) == false)
{
objvStudentEN.dicFldComparisonOp.Add(convStudent.IsDelete, strComparisonOp);
}
else
{
objvStudentEN.dicFldComparisonOp[convStudent.IsDelete] = strComparisonOp;
}
}
return objvStudentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvStudentENS">源对象</param>
 /// <param name = "objvStudentENT">目标对象</param>
 public static void CopyTo(this clsvStudentEN objvStudentENS, clsvStudentEN objvStudentENT)
{
try
{
objvStudentENT.id_stu = objvStudentENS.id_stu; //学生流水号
objvStudentENT.StuID = objvStudentENS.StuID; //学号
objvStudentENT.StuName = objvStudentENS.StuName; //姓名
objvStudentENT.Age = objvStudentENS.Age; //Age
objvStudentENT.CollegeId = objvStudentENS.CollegeId; //学院Id
objvStudentENT.CollegeName = objvStudentENS.CollegeName; //学院名称
objvStudentENT.id_Major = objvStudentENS.id_Major; //专业流水号
objvStudentENT.MajorID = objvStudentENS.MajorID; //MajorID
objvStudentENT.MajorName = objvStudentENS.MajorName; //专业名称
objvStudentENT.Memo = objvStudentENS.Memo; //备注
objvStudentENT.OrderNum = objvStudentENS.OrderNum; //排序
objvStudentENT.IsDelete = objvStudentENS.IsDelete; //是否删除
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
 /// <param name = "objvStudentENS">源对象</param>
 /// <returns>目标对象=>clsvStudentEN:objvStudentENT</returns>
 public static clsvStudentEN CopyTo(this clsvStudentEN objvStudentENS)
{
try
{
 clsvStudentEN objvStudentENT = new clsvStudentEN()
{
id_stu = objvStudentENS.id_stu, //学生流水号
StuID = objvStudentENS.StuID, //学号
StuName = objvStudentENS.StuName, //姓名
Age = objvStudentENS.Age, //Age
CollegeId = objvStudentENS.CollegeId, //学院Id
CollegeName = objvStudentENS.CollegeName, //学院名称
id_Major = objvStudentENS.id_Major, //专业流水号
MajorID = objvStudentENS.MajorID, //MajorID
MajorName = objvStudentENS.MajorName, //专业名称
Memo = objvStudentENS.Memo, //备注
OrderNum = objvStudentENS.OrderNum, //排序
IsDelete = objvStudentENS.IsDelete, //是否删除
};
 return objvStudentENT;
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
public static void CheckProperty4Condition(this clsvStudentEN objvStudentEN)
{
 clsvStudentBL.vStudentDA.CheckProperty4Condition(objvStudentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvStudentEN objvStudent_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvStudent_Cond.IsUpdated(convStudent.id_stu) == true)
{
string strComparisonOp_id_stu = objvStudent_Cond.dicFldComparisonOp[convStudent.id_stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.id_stu, objvStudent_Cond.id_stu, strComparisonOp_id_stu);
}
if (objvStudent_Cond.IsUpdated(convStudent.StuID) == true)
{
string strComparisonOp_StuID = objvStudent_Cond.dicFldComparisonOp[convStudent.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.StuID, objvStudent_Cond.StuID, strComparisonOp_StuID);
}
if (objvStudent_Cond.IsUpdated(convStudent.StuName) == true)
{
string strComparisonOp_StuName = objvStudent_Cond.dicFldComparisonOp[convStudent.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.StuName, objvStudent_Cond.StuName, strComparisonOp_StuName);
}
if (objvStudent_Cond.IsUpdated(convStudent.Age) == true)
{
string strComparisonOp_Age = objvStudent_Cond.dicFldComparisonOp[convStudent.Age];
strWhereCond += string.Format(" And {0} {2} {1}", convStudent.Age, objvStudent_Cond.Age, strComparisonOp_Age);
}
if (objvStudent_Cond.IsUpdated(convStudent.CollegeId) == true)
{
string strComparisonOp_CollegeId = objvStudent_Cond.dicFldComparisonOp[convStudent.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.CollegeId, objvStudent_Cond.CollegeId, strComparisonOp_CollegeId);
}
if (objvStudent_Cond.IsUpdated(convStudent.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvStudent_Cond.dicFldComparisonOp[convStudent.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.CollegeName, objvStudent_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvStudent_Cond.IsUpdated(convStudent.id_Major) == true)
{
string strComparisonOp_id_Major = objvStudent_Cond.dicFldComparisonOp[convStudent.id_Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.id_Major, objvStudent_Cond.id_Major, strComparisonOp_id_Major);
}
if (objvStudent_Cond.IsUpdated(convStudent.MajorID) == true)
{
string strComparisonOp_MajorID = objvStudent_Cond.dicFldComparisonOp[convStudent.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.MajorID, objvStudent_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvStudent_Cond.IsUpdated(convStudent.MajorName) == true)
{
string strComparisonOp_MajorName = objvStudent_Cond.dicFldComparisonOp[convStudent.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.MajorName, objvStudent_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvStudent_Cond.IsUpdated(convStudent.Memo) == true)
{
string strComparisonOp_Memo = objvStudent_Cond.dicFldComparisonOp[convStudent.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudent.Memo, objvStudent_Cond.Memo, strComparisonOp_Memo);
}
if (objvStudent_Cond.IsUpdated(convStudent.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvStudent_Cond.dicFldComparisonOp[convStudent.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convStudent.OrderNum, objvStudent_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvStudent_Cond.IsUpdated(convStudent.IsDelete) == true)
{
if (objvStudent_Cond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudent.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudent.IsDelete);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vStudent
{
public virtual bool UpdRelaTabDate(string strid_stu, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vStudent(vStudent)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvStudentBL
{
public static RelatedActions_vStudent relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vStudentListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vStudentList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvStudentEN> arrvStudentObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvStudentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvStudentDA vStudentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvStudentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvStudentBL()
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
if (string.IsNullOrEmpty(clsvStudentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvStudentEN._ConnectString);
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
objDS = vStudentDA.GetDataSet(strWhereCond);
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
objDS = vStudentDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vStudentDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vStudent(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vStudentDA.GetDataTable_vStudent(strWhereCond);
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
objDT = vStudentDA.GetDataTable(strWhereCond);
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
objDT = vStudentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vStudentDA.GetDataTable(strWhereCond, bolIsCheckSQLAttack);
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
objDT = vStudentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vStudentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vStudentDA.GetDataTable(strWhereCond, strTabName, bolIsCheckSQLAttack);
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
objDT = vStudentDA.GetDataTable_Top(objTopPara);
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
objDT = vStudentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vStudentDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vStudentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vStudentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vStudentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vStudentDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vStudentDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vStudentDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrId_stuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvStudentEN> GetObjLstById_stuLst(List<string> arrId_stuLst)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrId_stuLst, true);
 string strWhereCond = string.Format("id_stu in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrId_stuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvStudentEN> GetObjLstById_stuLst_Cache(List<string> arrId_stuLst)
{
string strKey = string.Format("{0}", clsvStudentEN._CurrTabName_S);
List<clsvStudentEN> arrvStudentObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentEN> arrvStudentObjLst_Sel =
arrvStudentObjLst_Cache
.Where(x => arrId_stuLst.Contains(x.id_stu));
return arrvStudentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentEN> GetObjLst(string strWhereCond)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
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
public static List<clsvStudentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objvStudent_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvStudentEN> GetSubObjLst_Cache(clsvStudentEN objvStudent_Cond)
{
List<clsvStudentEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convStudent.AttributeName)
{
if (objvStudent_Cond.IsUpdated(strFldName) == false) continue;
if (objvStudent_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvStudent_Cond[strFldName].ToString());
}
else
{
if (objvStudent_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvStudent_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvStudent_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvStudent_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvStudent_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvStudent_Cond[strFldName]));
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
public static List<clsvStudentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
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
public static List<clsvStudentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
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
List<clsvStudentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvStudentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvStudentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
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
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
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
public static List<clsvStudentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvStudentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvStudentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
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
public static List<clsvStudentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
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
public static IEnumerable<clsvStudentEN> GetObjLstByPager_Cache(int intPageIndex, int intPageSize, clsvStudentEN objvStudent_Cond, string strOrderBy)
{
List<clsvStudentEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convStudent.AttributeName)
{
if (objvStudent_Cond.IsUpdated(strFldName) == false) continue;
if (objvStudent_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvStudent_Cond[strFldName].ToString());
}
else
{
if (objvStudent_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvStudent_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvStudent_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvStudent_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvStudent_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvStudent_Cond[strFldName]));
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
public static IEnumerable<clsvStudentEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
clsvStudentEN objvStudent_Cond = JsonConvert.DeserializeObject<clsvStudentEN>(objPagerPara.whereCond);
if (objvStudent_Cond.sf_FldComparisonOp == null)
{
objvStudent_Cond.dicFldComparisonOp = null;
}
else
{
objvStudent_Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvStudent_Cond.sf_FldComparisonOp);
}
clsvStudentBL.SetUpdFlag(objvStudent_Cond);
 try
{
CheckProperty4Condition(objvStudent_Cond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000150)在输入条件中含有{0},请检查!(clsvStudentBL:GetObjLstByPager_Cache)", objException.Message));
}
 return GetObjLstByPager_Cache(objPagerPara.pageIndex, objPagerPara.pageSize, objvStudent_Cond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvStudentEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
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
public static List<clsvStudentEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvStudentEN> arrObjLst = new List<clsvStudentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentEN objvStudentEN = new clsvStudentEN();
try
{
objvStudentEN.id_stu = objRow[convStudent.id_stu].ToString().Trim(); //学生流水号
objvStudentEN.StuID = objRow[convStudent.StuID].ToString().Trim(); //学号
objvStudentEN.StuName = objRow[convStudent.StuName].ToString().Trim(); //姓名
objvStudentEN.Age = Int32.Parse(objRow[convStudent.Age].ToString().Trim()); //Age
objvStudentEN.CollegeId = objRow[convStudent.CollegeId].ToString().Trim(); //学院Id
objvStudentEN.CollegeName = objRow[convStudent.CollegeName].ToString().Trim(); //学院名称
objvStudentEN.id_Major = objRow[convStudent.id_Major].ToString().Trim(); //专业流水号
objvStudentEN.MajorID = objRow[convStudent.MajorID].ToString().Trim(); //MajorID
objvStudentEN.MajorName = objRow[convStudent.MajorName].ToString().Trim(); //专业名称
objvStudentEN.Memo = objRow[convStudent.Memo].ToString().Trim(); //备注
objvStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convStudent.OrderNum].ToString().Trim()); //排序
objvStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convStudent.IsDelete].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvStudentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvStudent(ref clsvStudentEN objvStudentEN)
{
bool bolResult = vStudentDA.GetvStudent(ref objvStudentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strid_stu">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentEN GetObjByid_stu(string strid_stu)
{
if (strid_stu.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strid_stu]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strid_stu) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strid_stu]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvStudentEN objvStudentEN = vStudentDA.GetObjByid_stu(strid_stu);
return objvStudentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvStudentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvStudentEN objvStudentEN = vStudentDA.GetFirstObj(strWhereCond);
 return objvStudentEN;
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
public static clsvStudentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvStudentEN objvStudentEN = vStudentDA.GetObjByDataRow(objRow);
 return objvStudentEN;
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
public static clsvStudentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvStudentEN objvStudentEN = vStudentDA.GetObjByDataRow(objRow);
 return objvStudentEN;
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
 /// <param name = "strid_stu">所给的关键字</param>
 /// <param name = "lstvStudentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvStudentEN GetObjByid_stuFromList(string strid_stu, List<clsvStudentEN> lstvStudentObjLst)
{
foreach (clsvStudentEN objvStudentEN in lstvStudentObjLst)
{
if (objvStudentEN.id_stu == strid_stu)
{
return objvStudentEN;
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
 string strid_stu;
 try
 {
 strid_stu = new clsvStudentDA().GetFirstID(strWhereCond);
 return strid_stu;
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
 arrList = vStudentDA.GetID(strWhereCond);
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
bool bolIsExist = vStudentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strid_stu)
{
if (string.IsNullOrEmpty(strid_stu) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strid_stu]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vStudentDA.IsExist(strid_stu);
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
 bolIsExist = clsvStudentDA.IsExistTable();
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
 bolIsExist = vStudentDA.IsExistTable(strTabName);
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
 /// <param name = "objvStudentENS">源对象</param>
 /// <param name = "objvStudentENT">目标对象</param>
 public static void CopyTo(clsvStudentEN objvStudentENS, clsvStudentEN objvStudentENT)
{
try
{
objvStudentENT.id_stu = objvStudentENS.id_stu; //学生流水号
objvStudentENT.StuID = objvStudentENS.StuID; //学号
objvStudentENT.StuName = objvStudentENS.StuName; //姓名
objvStudentENT.Age = objvStudentENS.Age; //Age
objvStudentENT.CollegeId = objvStudentENS.CollegeId; //学院Id
objvStudentENT.CollegeName = objvStudentENS.CollegeName; //学院名称
objvStudentENT.id_Major = objvStudentENS.id_Major; //专业流水号
objvStudentENT.MajorID = objvStudentENS.MajorID; //MajorID
objvStudentENT.MajorName = objvStudentENS.MajorName; //专业名称
objvStudentENT.Memo = objvStudentENS.Memo; //备注
objvStudentENT.OrderNum = objvStudentENS.OrderNum; //排序
objvStudentENT.IsDelete = objvStudentENS.IsDelete; //是否删除
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
 /// <param name = "objvStudentEN">源简化对象</param>
 public static void SetUpdFlag(clsvStudentEN objvStudentEN)
{
try
{
objvStudentEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvStudentEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convStudent.id_stu, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.id_stu = objvStudentEN.id_stu; //学生流水号
}
if (arrFldSet.Contains(convStudent.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.StuID = objvStudentEN.StuID; //学号
}
if (arrFldSet.Contains(convStudent.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.StuName = objvStudentEN.StuName; //姓名
}
if (arrFldSet.Contains(convStudent.Age, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.Age = objvStudentEN.Age; //Age
}
if (arrFldSet.Contains(convStudent.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.CollegeId = objvStudentEN.CollegeId; //学院Id
}
if (arrFldSet.Contains(convStudent.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.CollegeName = objvStudentEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convStudent.id_Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.id_Major = objvStudentEN.id_Major; //专业流水号
}
if (arrFldSet.Contains(convStudent.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.MajorID = objvStudentEN.MajorID; //MajorID
}
if (arrFldSet.Contains(convStudent.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.MajorName = objvStudentEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convStudent.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.Memo = objvStudentEN.Memo; //备注
}
if (arrFldSet.Contains(convStudent.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.OrderNum = objvStudentEN.OrderNum; //排序
}
if (arrFldSet.Contains(convStudent.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentEN.IsDelete = objvStudentEN.IsDelete; //是否删除
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
public static void CheckProperty4Condition(clsvStudentEN objvStudentEN)
{
 vStudentDA.CheckProperty4Condition(objvStudentEN);
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
if (clsStudentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentBL没有刷新缓存机制(clsStudentBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_stu");
//if (arrvStudentObjLst_Cache == null)
//{
//arrvStudentObjLst_Cache = vStudentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_stu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvStudentEN GetObjByid_stu_Cache(string strid_stu)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvStudentEN._CurrTabName_S);
List<clsvStudentEN> arrvStudentObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentEN> arrvStudentObjLst_Sel =
arrvStudentObjLst_Cache
.Where(x => x.id_stu == strid_stu);
if (arrvStudentObjLst_Sel.Count() == 0)
{
   clsvStudentEN obj = clsvStudentBL.GetObjByid_stu(strid_stu);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return null;
 }
return null;
}
return arrvStudentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvStudentEN> GetAllvStudentObjLst_Cache()
{
//获取缓存中的对象列表
List<clsvStudentEN> arrvStudentObjLst_Cache = GetObjLst_Cache(); 
return arrvStudentObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvStudentEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvStudentEN._CurrTabName_S);
List<clsvStudentEN> arrvStudentObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvStudentObjLst_Cache;
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
string strKey = string.Format("{0}", clsvStudentEN._CurrTabName_S);
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
 /// <param name = "lstvStudentObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvStudentEN> lstvStudentObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvStudentObjLst, writer);
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
 /// <param name = "lstvStudentObjLst">[clsvStudentEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvStudentEN> lstvStudentObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvStudentBL.listXmlNode);
writer.WriteStartElement(clsvStudentBL.itemsXmlNode);
foreach (clsvStudentEN objvStudentEN in lstvStudentObjLst)
{
clsvStudentBL.SerializeXML(writer, objvStudentEN);
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
 /// <param name = "objvStudentEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvStudentEN objvStudentEN)
{
writer.WriteStartElement(clsvStudentBL.itemXmlNode);
 
if (objvStudentEN.id_stu != null)
{
writer.WriteElementString(convStudent.id_stu, objvStudentEN.id_stu.ToString(CultureInfo.InvariantCulture));
}
 
if (objvStudentEN.StuID != null)
{
writer.WriteElementString(convStudent.StuID, objvStudentEN.StuID.ToString(CultureInfo.InvariantCulture));
}
 
if (objvStudentEN.StuName != null)
{
writer.WriteElementString(convStudent.StuName, objvStudentEN.StuName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convStudent.Age, objvStudentEN.Age.ToString(CultureInfo.InvariantCulture));
 
if (objvStudentEN.CollegeId != null)
{
writer.WriteElementString(convStudent.CollegeId, objvStudentEN.CollegeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvStudentEN.CollegeName != null)
{
writer.WriteElementString(convStudent.CollegeName, objvStudentEN.CollegeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvStudentEN.id_Major != null)
{
writer.WriteElementString(convStudent.id_Major, objvStudentEN.id_Major.ToString(CultureInfo.InvariantCulture));
}
 
if (objvStudentEN.MajorID != null)
{
writer.WriteElementString(convStudent.MajorID, objvStudentEN.MajorID.ToString(CultureInfo.InvariantCulture));
}
 
if (objvStudentEN.MajorName != null)
{
writer.WriteElementString(convStudent.MajorName, objvStudentEN.MajorName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvStudentEN.Memo != null)
{
writer.WriteElementString(convStudent.Memo, objvStudentEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convStudent.OrderNum, objvStudentEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convStudent.IsDelete, objvStudentEN.IsDelete.ToString().ToLower(CultureInfo.InvariantCulture));
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
public static clsvStudentEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvStudentEN objvStudentEN = new clsvStudentEN();
reader.Read();
while (!(reader.Name == clsvStudentBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convStudent.id_stu))
{
objvStudentEN.id_stu = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.StuID))
{
objvStudentEN.StuID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.StuName))
{
objvStudentEN.StuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.Age))
{
objvStudentEN.Age = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convStudent.CollegeId))
{
objvStudentEN.CollegeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.CollegeName))
{
objvStudentEN.CollegeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.id_Major))
{
objvStudentEN.id_Major = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.MajorID))
{
objvStudentEN.MajorID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.MajorName))
{
objvStudentEN.MajorName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.Memo))
{
objvStudentEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convStudent.OrderNum))
{
objvStudentEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convStudent.IsDelete))
{
objvStudentEN.IsDelete = reader.ReadElementContentAsBoolean();
}
}
return objvStudentEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvStudentObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvStudentEN GetObjFromXmlStr(string strvStudentObjXmlStr)
{
clsvStudentEN objvStudentEN = new clsvStudentEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvStudentObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvStudentBL.itemXmlNode))
{
objvStudentEN = GetObjFromXml(reader);
return objvStudentEN;
}
}
return objvStudentEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvStudentEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvStudentEN objvStudentEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvStudentEN);
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
public static string Func(string strInFldName, string strOutFldName, string strid_stu)
{
if (strInFldName != convStudent.id_stu)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convStudent.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convStudent.AttributeName));
throw new Exception(strMsg);
}
var objvStudent = clsvStudentBL.GetObjByid_stu_Cache(strid_stu );
if (objvStudent == null) return "";
return objvStudent[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2022-04-25
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvStudentEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvStudentEN objvStudentEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvStudentEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvStudentEN[strField]);
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
 /// <param name = "lstvStudentObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvStudentEN> lstvStudentObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvStudentObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvStudentEN objvStudentEN in lstvStudentObjLst)
{
string strJSON_One = SerializeObjToJSON(objvStudentEN);
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
int intRecCount = clsvStudentDA.GetRecCount(strTabName);
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
int intRecCount = clsvStudentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvStudentDA.GetRecCount();
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
int intRecCount = clsvStudentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objvStudent_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsvStudentEN objvStudent_Cond)
{
List<clsvStudentEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convStudent.AttributeName)
{
if (objvStudent_Cond.IsUpdated(strFldName) == false) continue;
if (objvStudent_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvStudent_Cond[strFldName].ToString());
}
else
{
if (objvStudent_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvStudent_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvStudent_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvStudent_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvStudent_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvStudent_Cond[strFldName]));
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
 List<string> arrList = clsvStudentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vStudentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vStudentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}