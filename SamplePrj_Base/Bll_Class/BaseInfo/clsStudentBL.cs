﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentBL
 表名:Student(01160036)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:53
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
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
public static class clsStudentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strid_stu">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentEN GetObj(this K_id_stu_Student myKey)
{
clsStudentEN objStudentEN = clsStudentBL.StudentDA.GetObjByid_stu(myKey.Value);
return objStudentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsStudentEN objStudentEN)
{
if (CheckUniqueness_StuID(objStudentEN) == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentBL.AddNewRecord)", objStudentEN.StuID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true || clsStudentBL.IsExist(objStudentEN.id_stu) == true)
 {
     objStudentEN.id_stu = clsStudentBL.GetMaxStrId_S();
 }
bool bolResult = clsStudentBL.StudentDA.AddNewRecordBySQL2(objStudentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsStudentEN objStudentEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
//if (clsStudentBL.IsExist(objStudentEN.id_stu))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objStudentEN.CheckPropertyNew();
//因为是字符型自增主键，所以在添加时，自动获取主键值。
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true || clsStudentBL.IsExist(objStudentEN.id_stu) == true)
 {
     objStudentEN.id_stu = clsStudentBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objStudentEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsStudentEN objStudentEN)
{
if (CheckUniqueness_StuID(objStudentEN) == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentBL.AddNewRecordWithMaxId)", objStudentEN.StuID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true || clsStudentBL.IsExist(objStudentEN.id_stu) == true)
 {
     objStudentEN.id_stu = clsStudentBL.GetMaxStrId_S();
 }
string strid_stu = clsStudentBL.StudentDA.AddNewRecordBySQL2WithReturnKey(objStudentEN);
     objStudentEN.id_stu = strid_stu;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return strid_stu;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsStudentEN objStudentEN)
{
if (CheckUniqueness_StuID(objStudentEN) == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentBL.AddNewRecordWithReturnKey)", objStudentEN.StuID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true || clsStudentBL.IsExist(objStudentEN.id_stu) == true)
 {
     objStudentEN.id_stu = clsStudentBL.GetMaxStrId_S();
 }
string strKey = clsStudentBL.StudentDA.AddNewRecordBySQL2WithReturnKey(objStudentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN Setid_stu(this clsStudentEN objStudentEN, string strid_stu, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strid_stu, 8, conStudent.id_stu);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strid_stu, 8, conStudent.id_stu);
}
objStudentEN.id_stu = strid_stu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.id_stu) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.id_stu, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.id_stu] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetStuID(this clsStudentEN objStudentEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, conStudent.StuID);
}
objStudentEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.StuID) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.StuID, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.StuID] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetStuName(this clsStudentEN objStudentEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, conStudent.StuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, conStudent.StuName);
}
objStudentEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.StuName) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.StuName, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.StuName] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetAge(this clsStudentEN objStudentEN, int intAge, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAge, conStudent.Age);
objStudentEN.Age = intAge; //Age
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.Age) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.Age, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.Age] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetCollegeId(this clsStudentEN objStudentEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, conStudent.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 6, conStudent.CollegeId);
}
objStudentEN.CollegeId = strCollegeId; //学院Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.CollegeId) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.CollegeId, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.CollegeId] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN Setid_Major(this clsStudentEN objStudentEN, string strid_Major, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strid_Major, 8, conStudent.id_Major);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strid_Major, 8, conStudent.id_Major);
}
objStudentEN.id_Major = strid_Major; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.id_Major) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.id_Major, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.id_Major] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetMemo(this clsStudentEN objStudentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conStudent.Memo);
}
objStudentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.Memo) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.Memo, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.Memo] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetOrderNum(this clsStudentEN objStudentEN, int intOrderNum, string strComparisonOp="")
	{
objStudentEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.OrderNum) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.OrderNum, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.OrderNum] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetIsDelete(this clsStudentEN objStudentEN, bool bolIsDelete, string strComparisonOp="")
	{
objStudentEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.IsDelete) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.IsDelete, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.IsDelete] = strComparisonOp;
}
}
return objStudentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentEN SetSex(this clsStudentEN objStudentEN, string strSex, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSex, 10, conStudent.Sex);
}
objStudentEN.Sex = strSex; //Sex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentEN.dicFldComparisonOp.ContainsKey(conStudent.Sex) == false)
{
objStudentEN.dicFldComparisonOp.Add(conStudent.Sex, strComparisonOp);
}
else
{
objStudentEN.dicFldComparisonOp[conStudent.Sex] = strComparisonOp;
}
}
return objStudentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objStudentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsStudentEN objStudentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objStudentEN.CheckPropertyNew();
clsStudentEN objStudent_Cond = new clsStudentEN();
string strCondition = objStudent_Cond
.Setid_stu(objStudentEN.id_stu, "<>")
.SetStuID(objStudentEN.StuID, "=")
.GetCombineCondition();
objStudentEN._IsCheckProperty = true;
bool bolIsExist = clsStudentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(StuID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objStudentEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objStudent">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsStudentEN objStudent)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsStudentEN objStudent_Cond = new clsStudentEN();
string strCondition = objStudent_Cond
.SetStuID(objStudent.StuID, "=")
.GetCombineCondition();
objStudent._IsCheckProperty = true;
bool bolIsExist = clsStudentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objStudent.id_stu = clsStudentBL.GetFirstID_S(strCondition);
objStudent.UpdateWithCondition(strCondition);
}
else
{
objStudent.id_stu = clsStudentBL.GetMaxStrId_S();
objStudent.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsStudentEN objStudentEN)
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsStudentBL.StudentDA.UpdateBySql2(objStudentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsStudentEN objStudentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsStudentBL.StudentDA.UpdateBySql2(objStudentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objStudentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsStudentEN objStudentEN, string strWhereCond)
{
try
{
bool bolResult = clsStudentBL.StudentDA.UpdateBySqlWithCondition(objStudentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objStudentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsStudentEN objStudentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsStudentBL.StudentDA.UpdateBySqlWithConditionTransaction(objStudentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsStudentEN objStudentEN)
{
try
{
int intRecNum = clsStudentBL.StudentDA.DelRecord(objStudentEN.id_stu);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objStudentENS">源对象</param>
 /// <param name = "objStudentENT">目标对象</param>
 public static void CopyTo(this clsStudentEN objStudentENS, clsStudentEN objStudentENT)
{
try
{
objStudentENT.id_stu = objStudentENS.id_stu; //学生流水号
objStudentENT.StuID = objStudentENS.StuID; //学号
objStudentENT.StuName = objStudentENS.StuName; //姓名
objStudentENT.Age = objStudentENS.Age; //Age
objStudentENT.CollegeId = objStudentENS.CollegeId; //学院Id
objStudentENT.id_Major = objStudentENS.id_Major; //专业流水号
objStudentENT.Memo = objStudentENS.Memo; //备注
objStudentENT.OrderNum = objStudentENS.OrderNum; //排序
objStudentENT.IsDelete = objStudentENS.IsDelete; //是否删除
objStudentENT.Sex = objStudentENS.Sex; //Sex
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
 /// <param name = "objStudentENS">源对象</param>
 /// <returns>目标对象=>clsStudentEN:objStudentENT</returns>
 public static clsStudentEN CopyTo(this clsStudentEN objStudentENS)
{
try
{
 clsStudentEN objStudentENT = new clsStudentEN()
{
id_stu = objStudentENS.id_stu, //学生流水号
StuID = objStudentENS.StuID, //学号
StuName = objStudentENS.StuName, //姓名
Age = objStudentENS.Age, //Age
CollegeId = objStudentENS.CollegeId, //学院Id
id_Major = objStudentENS.id_Major, //专业流水号
Memo = objStudentENS.Memo, //备注
OrderNum = objStudentENS.OrderNum, //排序
IsDelete = objStudentENS.IsDelete, //是否删除
Sex = objStudentENS.Sex, //Sex
};
 return objStudentENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsStudentEN objStudentEN)
{
 clsStudentBL.StudentDA.CheckPropertyNew(objStudentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsStudentEN objStudentEN)
{
 clsStudentBL.StudentDA.CheckProperty4Condition(objStudentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsStudentEN objStudent_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objStudent_Cond.IsUpdated(conStudent.id_stu) == true)
{
string strComparisonOp_id_stu = objStudent_Cond.dicFldComparisonOp[conStudent.id_stu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudent.id_stu, objStudent_Cond.id_stu, strComparisonOp_id_stu);
}
if (objStudent_Cond.IsUpdated(conStudent.StuID) == true)
{
string strComparisonOp_StuID = objStudent_Cond.dicFldComparisonOp[conStudent.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudent.StuID, objStudent_Cond.StuID, strComparisonOp_StuID);
}
if (objStudent_Cond.IsUpdated(conStudent.StuName) == true)
{
string strComparisonOp_StuName = objStudent_Cond.dicFldComparisonOp[conStudent.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudent.StuName, objStudent_Cond.StuName, strComparisonOp_StuName);
}
if (objStudent_Cond.IsUpdated(conStudent.Age) == true)
{
string strComparisonOp_Age = objStudent_Cond.dicFldComparisonOp[conStudent.Age];
strWhereCond += string.Format(" And {0} {2} {1}", conStudent.Age, objStudent_Cond.Age, strComparisonOp_Age);
}
if (objStudent_Cond.IsUpdated(conStudent.CollegeId) == true)
{
string strComparisonOp_CollegeId = objStudent_Cond.dicFldComparisonOp[conStudent.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudent.CollegeId, objStudent_Cond.CollegeId, strComparisonOp_CollegeId);
}
if (objStudent_Cond.IsUpdated(conStudent.id_Major) == true)
{
string strComparisonOp_id_Major = objStudent_Cond.dicFldComparisonOp[conStudent.id_Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudent.id_Major, objStudent_Cond.id_Major, strComparisonOp_id_Major);
}
if (objStudent_Cond.IsUpdated(conStudent.Memo) == true)
{
string strComparisonOp_Memo = objStudent_Cond.dicFldComparisonOp[conStudent.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudent.Memo, objStudent_Cond.Memo, strComparisonOp_Memo);
}
if (objStudent_Cond.IsUpdated(conStudent.OrderNum) == true)
{
string strComparisonOp_OrderNum = objStudent_Cond.dicFldComparisonOp[conStudent.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conStudent.OrderNum, objStudent_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objStudent_Cond.IsUpdated(conStudent.IsDelete) == true)
{
if (objStudent_Cond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudent.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudent.IsDelete);
}
}
if (objStudent_Cond.IsUpdated(conStudent.Sex) == true)
{
string strComparisonOp_Sex = objStudent_Cond.dicFldComparisonOp[conStudent.Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudent.Sex, objStudent_Cond.Sex, strComparisonOp_Sex);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Student(学生), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objStudentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckStudentUniqueness(this clsStudentEN objStudentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objStudentEN == null) return true;
if (objStudentEN.id_stu == null || objStudentEN.id_stu == "")
{
bolIsUniqueness = clsStudentBL.StudentDA.CheckStudentUniqueness();
}
else
{
bolIsUniqueness = clsStudentBL.StudentDA.CheckStudentUniqueness(objStudentEN.id_stu);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Student(学生), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objStudentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_StuID(this clsStudentEN objStudentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objStudentEN == null) return true;
if (objStudentEN.id_stu == null || objStudentEN.id_stu == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objStudentEN.StuID == null)
{
 sbCondition.AppendFormat(" and StuID is null", objStudentEN.StuID);
}
else
{
 sbCondition.AppendFormat(" and StuID = '{0}'", objStudentEN.StuID);
}
if (clsStudentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("id_stu !=  '{0}'", objStudentEN.id_stu);
 sbCondition.AppendFormat(" and StuID = '{0}'", objStudentEN.StuID);
if (clsStudentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Student(学生), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objStudentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_StuID(this clsStudentEN objStudentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objStudentEN == null) return "";
if (objStudentEN.id_stu == null || objStudentEN.id_stu == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objStudentEN.StuID == null)
{
 sbCondition.AppendFormat(" and StuID is null", objStudentEN.StuID);
}
else
{
 sbCondition.AppendFormat(" and StuID = '{0}'", objStudentEN.StuID);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_stu !=  '{0}'", objStudentEN.id_stu);
 sbCondition.AppendFormat(" and StuID = '{0}'", objStudentEN.StuID);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Student
{
public virtual bool UpdRelaTabDate(string strid_stu, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生(Student)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsStudentBL
{
public static RelatedActions_Student relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsStudentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsStudentDA StudentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsStudentDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsStudentBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsStudentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsStudentEN._ConnectString);
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
public static DataTable GetDataTable_Student(string strWhereCond)
{
DataTable objDT;
try
{
objDT = StudentDA.GetDataTable_Student(strWhereCond);
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
objDT = StudentDA.GetDataTable(strWhereCond);
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
objDT = StudentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = StudentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = StudentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = StudentDA.GetDataTable_Top(objTopPara);
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
objDT = StudentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = StudentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = StudentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrId_stuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsStudentEN> GetObjLstById_stuLst(List<string> arrId_stuLst)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
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
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrId_stuLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsStudentEN> GetObjLstById_stuLst_Cache(List<string> arrId_stuLst)
{
string strKey = string.Format("{0}", clsStudentEN._CurrTabName_S);
List<clsStudentEN> arrStudentObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentEN> arrStudentObjLst_Sel =
arrStudentObjLst_Cache
.Where(x => arrId_stuLst.Contains(x.id_stu));
return arrStudentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentEN> GetObjLst(string strWhereCond)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
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
public static List<clsStudentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objStudent_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsStudentEN> GetSubObjLst_Cache(clsStudentEN objStudent_Cond)
{
List<clsStudentEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conStudent.AttributeName)
{
if (objStudent_Cond.IsUpdated(strFldName) == false) continue;
if (objStudent_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objStudent_Cond[strFldName].ToString());
}
else
{
if (objStudent_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objStudent_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objStudent_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objStudent_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objStudent_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objStudent_Cond[strFldName]));
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
public static List<clsStudentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
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
public static List<clsStudentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
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
List<clsStudentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsStudentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsStudentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
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
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
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
public static List<clsStudentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsStudentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsStudentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
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
public static List<clsStudentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsStudentEN> arrObjLst = new List<clsStudentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
try
{
objStudentEN.id_stu = objRow[conStudent.id_stu].ToString().Trim(); //学生流水号
objStudentEN.StuID = objRow[conStudent.StuID] == DBNull.Value ? null : objRow[conStudent.StuID].ToString().Trim(); //学号
objStudentEN.StuName = objRow[conStudent.StuName].ToString().Trim(); //姓名
objStudentEN.Age = Int32.Parse(objRow[conStudent.Age].ToString().Trim()); //Age
objStudentEN.CollegeId = objRow[conStudent.CollegeId].ToString().Trim(); //学院Id
objStudentEN.id_Major = objRow[conStudent.id_Major] == DBNull.Value ? null : objRow[conStudent.id_Major].ToString().Trim(); //专业流水号
objStudentEN.Memo = objRow[conStudent.Memo] == DBNull.Value ? null : objRow[conStudent.Memo].ToString().Trim(); //备注
objStudentEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conStudent.OrderNum] == DBNull.Value ? null : objRow[conStudent.OrderNum].ToString().Trim()); //排序
objStudentEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conStudent.IsDelete] == DBNull.Value ? null : objRow[conStudent.IsDelete].ToString().Trim()); //是否删除
objStudentEN.Sex = objRow[conStudent.Sex] == DBNull.Value ? null : objRow[conStudent.Sex].ToString().Trim(); //Sex
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objStudentEN.id_stu, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objStudentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objStudentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetStudent(ref clsStudentEN objStudentEN)
{
bool bolResult = StudentDA.GetStudent(ref objStudentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strid_stu">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentEN GetObjByid_stu(string strid_stu)
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
clsStudentEN objStudentEN = StudentDA.GetObjByid_stu(strid_stu);
return objStudentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsStudentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsStudentEN objStudentEN = StudentDA.GetFirstObj(strWhereCond);
 return objStudentEN;
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
public static clsStudentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsStudentEN objStudentEN = StudentDA.GetObjByDataRow(objRow);
 return objStudentEN;
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
public static clsStudentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsStudentEN objStudentEN = StudentDA.GetObjByDataRow(objRow);
 return objStudentEN;
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
 /// <param name = "lstStudentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsStudentEN GetObjByid_stuFromList(string strid_stu, List<clsStudentEN> lstStudentObjLst)
{
foreach (clsStudentEN objStudentEN in lstStudentObjLst)
{
if (objStudentEN.id_stu == strid_stu)
{
return objStudentEN;
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
 string strMaxId_stu;
 try
 {
 strMaxId_stu = clsStudentDA.GetMaxStrId();
 return strMaxId_stu;
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
 string strid_stu;
 try
 {
 strid_stu = new clsStudentDA().GetFirstID(strWhereCond);
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
 arrList = StudentDA.GetID(strWhereCond);
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
bool bolIsExist = StudentDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = StudentDA.IsExist(strid_stu);
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
 bolIsExist = clsStudentDA.IsExistTable();
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
 bolIsExist = StudentDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsStudentEN objStudentEN)
{
if (objStudentEN.CheckUniqueness_StuID() == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentBL.AddNewRecordBySql2)", objStudentEN.StuID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true || clsStudentBL.IsExist(objStudentEN.id_stu) == true)
 {
     objStudentEN.id_stu = clsStudentBL.GetMaxStrId_S();
 }
bool bolResult = StudentDA.AddNewRecordBySQL2(objStudentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsStudentEN objStudentEN)
{
if (objStudentEN.CheckUniqueness_StuID() == false)
{
var strMsg = string.Format("记录已经存在!学号 = [{0}]的数据已经存在!(in clsStudentBL.AddNewRecordBySql2WithReturnKey)", objStudentEN.StuID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true || clsStudentBL.IsExist(objStudentEN.id_stu) == true)
 {
     objStudentEN.id_stu = clsStudentBL.GetMaxStrId_S();
 }
string strKey = StudentDA.AddNewRecordBySQL2WithReturnKey(objStudentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsStudentEN objStudentEN)
{
try
{
bool bolResult = StudentDA.Update(objStudentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objStudentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsStudentEN objStudentEN)
{
 if (string.IsNullOrEmpty(objStudentEN.id_stu) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = StudentDA.UpdateBySql2(objStudentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentBL.ReFreshCache();

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strid_stu)
{
try
{
 clsStudentEN objStudentEN = clsStudentBL.GetObjByid_stu(strid_stu);

if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudentEN.id_stu, "SetUpdDate");
}
if (objStudentEN != null)
{
int intRecNum = StudentDA.DelRecord(strid_stu);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strid_stu">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strid_stu )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsStudentDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[Student]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_stu,
//strid_stu);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsStudentBL.DelRecord(strid_stu, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsStudentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strid_stu, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strid_stu">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strid_stu, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(strid_stu, "UpdRelaTabDate");
}
bool bolResult = StudentDA.DelRecord(strid_stu,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrid_stuLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelStudents(List<string> arrid_stuLst)
{
if (arrid_stuLst.Count == 0) return 0;
try
{
if (clsStudentBL.relatedActions != null)
{
foreach (var strid_stu in arrid_stuLst)
{
clsStudentBL.relatedActions.UpdRelaTabDate(strid_stu, "UpdRelaTabDate");
}
}
int intDelRecNum = StudentDA.DelStudent(arrid_stuLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelStudentsByCond(string strWhereCond)
{
try
{
if (clsStudentBL.relatedActions != null)
{
List<string> arrid_stu = GetPrimaryKeyID_S(strWhereCond);
foreach (var strid_stu in arrid_stu)
{
clsStudentBL.relatedActions.UpdRelaTabDate(strid_stu, "UpdRelaTabDate");
}
}
int intRecNum = StudentDA.DelStudent(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[Student]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strid_stu">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strid_stu)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsStudentDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[Student]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsStudentBL.DelRecord(strid_stu, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsStudentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strid_stu, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objStudentENS">源对象</param>
 /// <param name = "objStudentENT">目标对象</param>
 public static void CopyTo(clsStudentEN objStudentENS, clsStudentEN objStudentENT)
{
try
{
objStudentENT.id_stu = objStudentENS.id_stu; //学生流水号
objStudentENT.StuID = objStudentENS.StuID; //学号
objStudentENT.StuName = objStudentENS.StuName; //姓名
objStudentENT.Age = objStudentENS.Age; //Age
objStudentENT.CollegeId = objStudentENS.CollegeId; //学院Id
objStudentENT.id_Major = objStudentENS.id_Major; //专业流水号
objStudentENT.Memo = objStudentENS.Memo; //备注
objStudentENT.OrderNum = objStudentENS.OrderNum; //排序
objStudentENT.IsDelete = objStudentENS.IsDelete; //是否删除
objStudentENT.Sex = objStudentENS.Sex; //Sex
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
 /// <param name = "objStudentEN">源简化对象</param>
 public static void SetUpdFlag(clsStudentEN objStudentEN)
{
try
{
objStudentEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objStudentEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conStudent.id_stu, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.id_stu = objStudentEN.id_stu; //学生流水号
}
if (arrFldSet.Contains(conStudent.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.StuID = objStudentEN.StuID == "[null]" ? null :  objStudentEN.StuID; //学号
}
if (arrFldSet.Contains(conStudent.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.StuName = objStudentEN.StuName; //姓名
}
if (arrFldSet.Contains(conStudent.Age, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.Age = objStudentEN.Age; //Age
}
if (arrFldSet.Contains(conStudent.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.CollegeId = objStudentEN.CollegeId; //学院Id
}
if (arrFldSet.Contains(conStudent.id_Major, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.id_Major = objStudentEN.id_Major == "[null]" ? null :  objStudentEN.id_Major; //专业流水号
}
if (arrFldSet.Contains(conStudent.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.Memo = objStudentEN.Memo == "[null]" ? null :  objStudentEN.Memo; //备注
}
if (arrFldSet.Contains(conStudent.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.OrderNum = objStudentEN.OrderNum; //排序
}
if (arrFldSet.Contains(conStudent.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.IsDelete = objStudentEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(conStudent.Sex, new clsStrCompareIgnoreCase())  ==  true)
{
objStudentEN.Sex = objStudentEN.Sex == "[null]" ? null :  objStudentEN.Sex; //Sex
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

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objStudentEN">源简化对象</param>
 public static void AccessFldValueNull(clsStudentEN objStudentEN)
{
try
{
if (objStudentEN.StuID == "[null]") objStudentEN.StuID = null; //学号
if (objStudentEN.id_Major == "[null]") objStudentEN.id_Major = null; //专业流水号
if (objStudentEN.Memo == "[null]") objStudentEN.Memo = null; //备注
if (objStudentEN.Sex == "[null]") objStudentEN.Sex = null; //Sex
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsStudentEN objStudentEN)
{
 StudentDA.CheckPropertyNew(objStudentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsStudentEN objStudentEN)
{
 StudentDA.CheckProperty4Condition(objStudentEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_stu(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conStudent.id_stu); 
List<clsStudentEN> arrObjLst = clsStudentBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsStudentEN objStudentEN = new clsStudentEN()
{
id_stu = "0",
StuName = "选[学生]..."
};
arrObjLst.Insert(0, objStudentEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conStudent.id_stu;
objComboBox.DisplayMember = conStudent.StuName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_stu(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学生]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conStudent.id_stu); 
IEnumerable<clsStudentEN> arrObjLst = clsStudentBL.GetObjLst(strCondition);
objDDL.DataValueField = conStudent.id_stu;
objDDL.DataTextField = conStudent.StuName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunction_Cache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_stu_Cache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学生]...","0");
List<clsStudentEN> arrStudentObjLst = GetAllStudentObjLst_Cache(); 
arrStudentObjLst = arrStudentObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conStudent.id_stu;
objDDL.DataTextField = conStudent.StuName;
objDDL.DataSource = arrStudentObjLst;
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
if (clsStudentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentBL没有刷新缓存机制(clsStudentBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_stu");
//if (arrStudentObjLst_Cache == null)
//{
//arrStudentObjLst_Cache = StudentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_stu">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsStudentEN GetObjByid_stu_Cache(string strid_stu)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsStudentEN._CurrTabName_S);
List<clsStudentEN> arrStudentObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentEN> arrStudentObjLst_Sel =
arrStudentObjLst_Cache
.Where(x=> x.id_stu == strid_stu 
);
if (arrStudentObjLst_Sel.Count() == 0)
{
   clsStudentEN obj = clsStudentBL.GetObjByid_stu(strid_stu);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrStudentObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_stu">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetStuNameByid_stu_Cache(string strid_stu)
{
if (string.IsNullOrEmpty(strid_stu) == true) return "";
//获取缓存中的对象列表
clsStudentEN objStudent = GetObjByid_stu_Cache(strid_stu);
if (objStudent == null) return "";
return objStudent.StuName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_stu">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_stu_Cache(string strid_stu)
{
if (string.IsNullOrEmpty(strid_stu) == true) return "";
//获取缓存中的对象列表
clsStudentEN objStudent = GetObjByid_stu_Cache(strid_stu);
if (objStudent == null) return "";
return objStudent.StuName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsStudentEN> GetAllStudentObjLst_Cache()
{
//获取缓存中的对象列表
List<clsStudentEN> arrStudentObjLst_Cache = GetObjLst_Cache(); 
return arrStudentObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsStudentEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsStudentEN._CurrTabName_S);
List<clsStudentEN> arrStudentObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrStudentObjLst_Cache;
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
string strKey = string.Format("{0}", clsStudentEN._CurrTabName_S);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsStudentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsStudentEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsStudentBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--Student(学生), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objStudentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckStudentUniqueness(clsStudentEN objStudentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objStudentEN == null) return true;
if (objStudentEN.id_stu == null || objStudentEN.id_stu == "")
{
bolIsUniqueness = StudentDA.CheckStudentUniqueness();
}
else
{
bolIsUniqueness = StudentDA.CheckStudentUniqueness(objStudentEN.id_stu);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Student(学生)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objStudentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_StuID(clsStudentEN objStudentEN)
{
//检测记录是否存在
string strResult = StudentDA.GetUniCondStr_StuID(objStudentEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-03-11
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strid_stu)
{
if (strInFldName != conStudent.id_stu)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conStudent.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conStudent.AttributeName));
throw new Exception(strMsg);
}
var objStudent = clsStudentBL.GetObjByid_stu_Cache(strid_stu);
if (objStudent == null) return "";
return objStudent[strOutFldName].ToString();
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
int intRecCount = clsStudentDA.GetRecCount(strTabName);
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
int intRecCount = clsStudentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsStudentDA.GetRecCount();
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
int intRecCount = clsStudentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objStudent_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsStudentEN objStudent_Cond)
{
List<clsStudentEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conStudent.AttributeName)
{
if (objStudent_Cond.IsUpdated(strFldName) == false) continue;
if (objStudent_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objStudent_Cond[strFldName].ToString());
}
else
{
if (objStudent_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objStudent_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objStudent_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objStudent_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objStudent_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objStudent_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objStudent_Cond[strFldName]));
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
 List<string> arrList = clsStudentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = StudentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = StudentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = StudentDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsStudentDA.SetFldValue(clsStudentEN._CurrTabName_S, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = StudentDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsStudentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsStudentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsStudentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[Student] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" id_stu char(8) primary key, "); 
 // /**学号*/ 
 strCreateTabCode.Append(" StuID varchar(20) Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) not Null, "); 
 // /**Age*/ 
 strCreateTabCode.Append(" Age int not Null, "); 
 // /**学院Id*/ 
 strCreateTabCode.Append(" CollegeId varchar(6) not Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" id_Major char(8) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**排序*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDelete bit Null, "); 
 // /**Sex*/ 
 strCreateTabCode.Append(" Sex varchar(10) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conStudent.OrderNum); 
List<clsStudentEN> arrStudentObjList = new clsStudentDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsStudentEN objStudent in arrStudentObjList)
{
objStudent.OrderNum = intIndex;
UpdateBySql2(objStudent);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strid_stu">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strid_stu)
{
try
{
//操作步骤：
//1、根据所给定的关键字[id_stu]，获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//   3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	   即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字id_stu
//5、把当前关键字id_stu所对应记录的序号加(减)1
//6、把下(上)一个序号关键字id_stu所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevid_stu = "";    //上一条序号的关键字id_stu
string strNextid_stu = "";    //下一条序号的关键字id_stu
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[id_stu]，获取相应的序号[OrderNum]。

clsStudentEN objStudent = clsStudentBL.GetObjByid_stu(strid_stu);

intOrderNum = objStudent.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号，
//		3.1 如果是末端序号，就退出，

intTabRecNum = clsStudentBL.GetRecCountByCond(clsStudentEN._CurrTabName_S, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号，就退出；
//  3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	     即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录，不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
//		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//		    如果是向上移动，就判断当前序号是否“大于”1，
//		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conStudent.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字id_stu
strPrevid_stu = clsStudentBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevid_stu) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字id_stu所对应记录的序号减1
//6、把下(上)一个序号关键字id_stu所对应的记录序号加1
clsStudentBL.SetFldValue(clsStudentEN._CurrTabName_S, conStudent.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conStudent.id_stu, strid_stu));
clsStudentBL.SetFldValue(clsStudentEN._CurrTabName_S, conStudent.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conStudent.id_stu, strPrevid_stu));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录，不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字id_stu
strCondition.AppendFormat(" {0} = {1}", conStudent.OrderNum, intOrderNum + 1);

strNextid_stu = clsStudentBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextid_stu) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字id_stu所对应记录的序号加1
//6、把下(上)一个序号关键字id_stu所对应的记录序号减1
clsStudentBL.SetFldValue(clsStudentEN._CurrTabName_S, conStudent.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conStudent.id_stu, strid_stu));
clsStudentBL.SetFldValue(clsStudentEN._CurrTabName_S, conStudent.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conStudent.id_stu, strNextid_stu));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsStudentBL.ReFreshCache();
if (clsStudentBL.relatedActions != null)
{
clsStudentBL.relatedActions.UpdRelaTabDate(objStudent.id_stu, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错！错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conStudent.id_stu, strKeyList);
List<clsStudentEN> arrStudentLst = GetObjLst(strCondition);
foreach (clsStudentEN objStudent in arrStudentLst)
{
objStudent.OrderNum = objStudent.OrderNum + 10000;
UpdateBySql2(objStudent);
}
strCondition = string.Format("1 = 1 order by {0} ", conStudent.OrderNum); 
List<clsStudentEN> arrStudentObjList = new clsStudentDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsStudentEN objStudent in arrStudentObjList)
{
objStudent.OrderNum = intIndex;
UpdateBySql2(objStudent);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conStudent.id_stu, strKeyList);
List<clsStudentEN> arrStudentLst = GetObjLst(strCondition);
foreach (clsStudentEN objStudent in arrStudentLst)
{
objStudent.OrderNum = objStudent.OrderNum - 10000;
UpdateBySql2(objStudent);
}
strCondition = string.Format("1 = 1 order by {0} ", conStudent.OrderNum); 
List<clsStudentEN> arrStudentObjList = new clsStudentDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsStudentEN objStudent in arrStudentObjList)
{
objStudent.OrderNum = intIndex;
UpdateBySql2(objStudent);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错！错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 学生(Student)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4Student : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
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
clsStudentBL.ReFreshThisCache();
}
}

}