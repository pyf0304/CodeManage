
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentInfoWApi
 表名:StudentInfo(01120131)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:37
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
public static class clsStudentInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_StudentInfo(this clsStudentInfoEN objStudentInfoEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, conStudentInfo.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, conStudentInfo.id_StudentInfo);
objStudentInfoEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_StudentInfo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_StudentInfo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_StudentInfo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetStuID(this clsStudentInfoEN objStudentInfoEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuID, conStudentInfo.StuID);
clsCheckSql.CheckFieldLen(strStuID, 20, conStudentInfo.StuID);
objStudentInfoEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.StuID) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.StuID, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.StuID] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetStuName(this clsStudentInfoEN objStudentInfoEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, conStudentInfo.StuName);
clsCheckSql.CheckFieldLen(strStuName, 50, conStudentInfo.StuName);
objStudentInfoEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.StuName) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.StuName, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.StuName] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_Politics(this clsStudentInfoEN objStudentInfoEN, string strid_Politics, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Politics, 4, conStudentInfo.id_Politics);
clsCheckSql.CheckFieldForeignKey(strid_Politics, 4, conStudentInfo.id_Politics);
objStudentInfoEN.id_Politics = strid_Politics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_Politics) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_Politics, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_Politics] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_Sex(this clsStudentInfoEN objStudentInfoEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Sex, 4, conStudentInfo.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, conStudentInfo.id_Sex);
objStudentInfoEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_Sex) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_Sex, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_Sex] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_Ethnic(this clsStudentInfoEN objStudentInfoEN, string strid_Ethnic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Ethnic, 4, conStudentInfo.id_Ethnic);
clsCheckSql.CheckFieldForeignKey(strid_Ethnic, 4, conStudentInfo.id_Ethnic);
objStudentInfoEN.id_Ethnic = strid_Ethnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_Ethnic) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_Ethnic, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_Ethnic] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_UniZone(this clsStudentInfoEN objStudentInfoEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, conStudentInfo.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, conStudentInfo.id_UniZone);
objStudentInfoEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_UniZone) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_UniZone, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_UniZone] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_StuType(this clsStudentInfoEN objStudentInfoEN, string strid_StuType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StuType, 4, conStudentInfo.id_StuType);
clsCheckSql.CheckFieldForeignKey(strid_StuType, 4, conStudentInfo.id_StuType);
objStudentInfoEN.id_StuType = strid_StuType; //学生类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_StuType) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_StuType, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_StuType] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_XzCollege(this clsStudentInfoEN objStudentInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conStudentInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conStudentInfo.id_XzCollege);
objStudentInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_XzCollege) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_XzCollege, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_XzCollege] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_XzMajor(this clsStudentInfoEN objStudentInfoEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conStudentInfo.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conStudentInfo.id_XzMajor);
objStudentInfoEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_XzMajor) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_XzMajor, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_XzMajor] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_GradeBase(this clsStudentInfoEN objStudentInfoEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, conStudentInfo.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, conStudentInfo.id_GradeBase);
objStudentInfoEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_GradeBase) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_GradeBase, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_GradeBase] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN Setid_AdminCls(this clsStudentInfoEN objStudentInfoEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, conStudentInfo.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, conStudentInfo.id_AdminCls);
objStudentInfoEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.id_AdminCls) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.id_AdminCls, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.id_AdminCls] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetBirthday(this clsStudentInfoEN objStudentInfoEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, conStudentInfo.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, conStudentInfo.Birthday);
objStudentInfoEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Birthday) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Birthday, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Birthday] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetNativePlace(this clsStudentInfoEN objStudentInfoEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, conStudentInfo.NativePlace);
objStudentInfoEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.NativePlace) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.NativePlace, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.NativePlace] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetDuty(this clsStudentInfoEN objStudentInfoEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, conStudentInfo.Duty);
objStudentInfoEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Duty) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Duty, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Duty] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetIDCardNo(this clsStudentInfoEN objStudentInfoEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, conStudentInfo.IDCardNo);
objStudentInfoEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IDCardNo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IDCardNo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IDCardNo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetStuCardNo(this clsStudentInfoEN objStudentInfoEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, conStudentInfo.StuCardNo);
objStudentInfoEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.StuCardNo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.StuCardNo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.StuCardNo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetLiveAddress(this clsStudentInfoEN objStudentInfoEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, conStudentInfo.LiveAddress);
objStudentInfoEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.LiveAddress) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.LiveAddress, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.LiveAddress] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetHomePhone(this clsStudentInfoEN objStudentInfoEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, conStudentInfo.HomePhone);
objStudentInfoEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.HomePhone) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.HomePhone, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.HomePhone] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetId_CardNo(this clsStudentInfoEN objStudentInfoEN, string strId_CardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CardNo, 20, conStudentInfo.Id_CardNo);
objStudentInfoEN.Id_CardNo = strId_CardNo; //内卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Id_CardNo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Id_CardNo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Id_CardNo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetCardNo(this clsStudentInfoEN objStudentInfoEN, string strCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardNo, 18, conStudentInfo.CardNo);
objStudentInfoEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.CardNo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.CardNo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.CardNo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetIsAvconClassUser(this clsStudentInfoEN objStudentInfoEN, bool bolIsAvconClassUser, string strComparisonOp="")
	{
objStudentInfoEN.IsAvconClassUser = bolIsAvconClassUser; //IsAvconClassUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsAvconClassUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsAvconClassUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsAvconClassUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetIsAvconUser(this clsStudentInfoEN objStudentInfoEN, bool bolIsAvconUser, string strComparisonOp="")
	{
objStudentInfoEN.IsAvconUser = bolIsAvconUser; //IsAvconUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsAvconUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsAvconUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsAvconUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetIsGpUser(this clsStudentInfoEN objStudentInfoEN, bool bolIsGpUser, string strComparisonOp="")
	{
objStudentInfoEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsGpUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsGpUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsGpUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetIsLocalUser(this clsStudentInfoEN objStudentInfoEN, bool bolIsLocalUser, string strComparisonOp="")
	{
objStudentInfoEN.IsLocalUser = bolIsLocalUser; //是否本地用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsLocalUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsLocalUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsLocalUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetIsLeaved(this clsStudentInfoEN objStudentInfoEN, bool bolIsLeaved, string strComparisonOp="")
	{
objStudentInfoEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsLeaved) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsLeaved, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsLeaved] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetUserId(this clsStudentInfoEN objStudentInfoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conStudentInfo.UserId);
objStudentInfoEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UserId) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UserId, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UserId] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetUserID4Avcon(this clsStudentInfoEN objStudentInfoEN, string strUserID4Avcon, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserID4Avcon, 20, conStudentInfo.UserID4Avcon);
objStudentInfoEN.UserID4Avcon = strUserID4Avcon; //UserID4Avcon
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UserID4Avcon) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UserID4Avcon, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UserID4Avcon] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetEnrollmentDate(this clsStudentInfoEN objStudentInfoEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, conStudentInfo.EnrollmentDate);
objStudentInfoEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.EnrollmentDate) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.EnrollmentDate, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.EnrollmentDate] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetPostCode(this clsStudentInfoEN objStudentInfoEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, conStudentInfo.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, conStudentInfo.PostCode);
objStudentInfoEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.PostCode) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.PostCode, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.PostCode] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetEmail(this clsStudentInfoEN objStudentInfoEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, conStudentInfo.Email);
objStudentInfoEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Email) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Email, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Email] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetIsMessage(this clsStudentInfoEN objStudentInfoEN, bool bolIsMessage, string strComparisonOp="")
	{
objStudentInfoEN.IsMessage = bolIsMessage; //IsMessage
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.IsMessage) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.IsMessage, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.IsMessage] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetMicroblog(this clsStudentInfoEN objStudentInfoEN, string strMicroblog, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroblog, 200, conStudentInfo.Microblog);
objStudentInfoEN.Microblog = strMicroblog; //Microblog
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Microblog) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Microblog, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Microblog] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetPhoneNumber(this clsStudentInfoEN objStudentInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conStudentInfo.PhoneNumber);
objStudentInfoEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.PhoneNumber) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.PhoneNumber, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.PhoneNumber] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetHeadphoto(this clsStudentInfoEN objStudentInfoEN, string strHeadphoto, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeadphoto, 500, conStudentInfo.Headphoto);
objStudentInfoEN.Headphoto = strHeadphoto; //Headphoto
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Headphoto) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Headphoto, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Headphoto] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetQQ(this clsStudentInfoEN objStudentInfoEN, string strQQ, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQQ, 100, conStudentInfo.QQ);
objStudentInfoEN.QQ = strQQ; //QQ
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.QQ) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.QQ, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.QQ] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetRegisterPassword(this clsStudentInfoEN objStudentInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, conStudentInfo.RegisterPassword);
objStudentInfoEN.RegisterPassword = strRegisterPassword; //RegisterPassword
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.RegisterPassword) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.RegisterPassword, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.RegisterPassword] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetUpdDate(this clsStudentInfoEN objStudentInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conStudentInfo.UpdDate);
objStudentInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UpdDate) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UpdDate, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UpdDate] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetUpdUser(this clsStudentInfoEN objStudentInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conStudentInfo.UpdUser);
objStudentInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.UpdUser) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.UpdUser, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.UpdUser] = strComparisonOp;
}
}
return objStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfoEN SetMemo(this clsStudentInfoEN objStudentInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conStudentInfo.Memo);
objStudentInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfoEN.dicFldComparisonOp.ContainsKey(conStudentInfo.Memo) == false)
{
objStudentInfoEN.dicFldComparisonOp.Add(conStudentInfo.Memo, strComparisonOp);
}
else
{
objStudentInfoEN.dicFldComparisonOp[conStudentInfo.Memo] = strComparisonOp;
}
}
return objStudentInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsStudentInfoEN objStudentInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_StudentInfo, objStudentInfo_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.StuID) == true)
{
string strComparisonOp_StuID = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.StuID, objStudentInfo_Cond.StuID, strComparisonOp_StuID);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.StuName) == true)
{
string strComparisonOp_StuName = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.StuName, objStudentInfo_Cond.StuName, strComparisonOp_StuName);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_Politics) == true)
{
string strComparisonOp_id_Politics = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_Politics];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_Politics, objStudentInfo_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_Sex) == true)
{
string strComparisonOp_id_Sex = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_Sex, objStudentInfo_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_Ethnic) == true)
{
string strComparisonOp_id_Ethnic = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_Ethnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_Ethnic, objStudentInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_UniZone, objStudentInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_StuType) == true)
{
string strComparisonOp_id_StuType = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_StuType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_StuType, objStudentInfo_Cond.id_StuType, strComparisonOp_id_StuType);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_XzCollege, objStudentInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_XzMajor, objStudentInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_GradeBase, objStudentInfo_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.id_AdminCls, objStudentInfo_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.Birthday) == true)
{
string strComparisonOp_Birthday = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Birthday, objStudentInfo_Cond.Birthday, strComparisonOp_Birthday);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.NativePlace) == true)
{
string strComparisonOp_NativePlace = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.NativePlace, objStudentInfo_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.Duty) == true)
{
string strComparisonOp_Duty = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Duty, objStudentInfo_Cond.Duty, strComparisonOp_Duty);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.IDCardNo, objStudentInfo_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.StuCardNo, objStudentInfo_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.LiveAddress, objStudentInfo_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.HomePhone) == true)
{
string strComparisonOp_HomePhone = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.HomePhone, objStudentInfo_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.Id_CardNo) == true)
{
string strComparisonOp_Id_CardNo = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.Id_CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Id_CardNo, objStudentInfo_Cond.Id_CardNo, strComparisonOp_Id_CardNo);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.CardNo) == true)
{
string strComparisonOp_CardNo = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.CardNo, objStudentInfo_Cond.CardNo, strComparisonOp_CardNo);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.IsAvconClassUser) == true)
{
if (objStudentInfo_Cond.IsAvconClassUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsAvconClassUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsAvconClassUser);
}
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.IsAvconUser) == true)
{
if (objStudentInfo_Cond.IsAvconUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsAvconUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsAvconUser);
}
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.IsGpUser) == true)
{
if (objStudentInfo_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsGpUser);
}
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.IsLocalUser) == true)
{
if (objStudentInfo_Cond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsLocalUser);
}
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.IsLeaved) == true)
{
if (objStudentInfo_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsLeaved);
}
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.UserId) == true)
{
string strComparisonOp_UserId = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UserId, objStudentInfo_Cond.UserId, strComparisonOp_UserId);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.UserID4Avcon) == true)
{
string strComparisonOp_UserID4Avcon = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.UserID4Avcon];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UserID4Avcon, objStudentInfo_Cond.UserID4Avcon, strComparisonOp_UserID4Avcon);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.EnrollmentDate, objStudentInfo_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.PostCode) == true)
{
string strComparisonOp_PostCode = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.PostCode, objStudentInfo_Cond.PostCode, strComparisonOp_PostCode);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.Email) == true)
{
string strComparisonOp_Email = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Email, objStudentInfo_Cond.Email, strComparisonOp_Email);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.IsMessage) == true)
{
if (objStudentInfo_Cond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conStudentInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conStudentInfo.IsMessage);
}
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.Microblog) == true)
{
string strComparisonOp_Microblog = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Microblog, objStudentInfo_Cond.Microblog, strComparisonOp_Microblog);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.PhoneNumber, objStudentInfo_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.Headphoto) == true)
{
string strComparisonOp_Headphoto = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.Headphoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Headphoto, objStudentInfo_Cond.Headphoto, strComparisonOp_Headphoto);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.QQ) == true)
{
string strComparisonOp_QQ = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.QQ, objStudentInfo_Cond.QQ, strComparisonOp_QQ);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.RegisterPassword) == true)
{
string strComparisonOp_RegisterPassword = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.RegisterPassword, objStudentInfo_Cond.RegisterPassword, strComparisonOp_RegisterPassword);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UpdDate, objStudentInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.UpdUser, objStudentInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objStudentInfo_Cond.IsUpdated(conStudentInfo.Memo) == true)
{
string strComparisonOp_Memo = objStudentInfo_Cond.dicFldComparisonOp[conStudentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo.Memo, objStudentInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsStudentInfoEN objStudentInfoEN)
{
 if (string.IsNullOrEmpty(objStudentInfoEN.id_StudentInfo) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objStudentInfoEN.sf_UpdFldSetStr = objStudentInfoEN.getsf_UpdFldSetStr();
clsStudentInfoWApi.CheckPropertyNew(objStudentInfoEN); 
bool bolResult = clsStudentInfoWApi.UpdateRecord(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--StudentInfo(学生), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objStudentInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_StuID(this clsStudentInfoEN objStudentInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objStudentInfoEN == null) return "";
if (objStudentInfoEN.id_StudentInfo == null || objStudentInfoEN.id_StudentInfo == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StuID = '{0}'", objStudentInfoEN.StuID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_StudentInfo !=  '{0}'", objStudentInfoEN.id_StudentInfo);
 sbCondition.AppendFormat(" and StuID = '{0}'", objStudentInfoEN.StuID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsStudentInfoEN objStudentInfoEN)
{
try
{
 if (string.IsNullOrEmpty(objStudentInfoEN.id_StudentInfo) == true || clsStudentInfoWApi.IsExist(objStudentInfoEN.id_StudentInfo) == true)
 {
     objStudentInfoEN.id_StudentInfo = clsStudentInfoWApi.GetMaxStrId();
 }
clsStudentInfoWApi.CheckPropertyNew(objStudentInfoEN); 
bool bolResult = clsStudentInfoWApi.AddNewRecord(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoWApi.ReFreshCache();
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsStudentInfoEN objStudentInfoEN)
{
try
{
clsStudentInfoWApi.CheckPropertyNew(objStudentInfoEN); 
string strid_StudentInfo = clsStudentInfoWApi.AddNewRecordWithMaxId(objStudentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoWApi.ReFreshCache();
return strid_StudentInfo;
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
 /// <param name = "objStudentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsStudentInfoEN objStudentInfoEN, string strWhereCond)
{
try
{
clsStudentInfoWApi.CheckPropertyNew(objStudentInfoEN); 
bool bolResult = clsStudentInfoWApi.UpdateWithCondition(objStudentInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoWApi.ReFreshCache();
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
 /// 学生(StudentInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsStudentInfoWApi
{
private static readonly string mstrApiControllerName = "StudentInfoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsStudentInfoWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsStudentInfoEN objStudentInfoEN)
{
if (!Object.Equals(null, objStudentInfoEN.id_StudentInfo) && GetStrLen(objStudentInfoEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objStudentInfoEN.StuID) && GetStrLen(objStudentInfoEN.StuID) > 20)
{
 throw new Exception("字段[学号]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.StuName) && GetStrLen(objStudentInfoEN.StuName) > 50)
{
 throw new Exception("字段[姓名]的长度不能超过50!");
}
if (!Object.Equals(null, objStudentInfoEN.id_Politics) && GetStrLen(objStudentInfoEN.id_Politics) > 4)
{
 throw new Exception("字段[政治面貌流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfoEN.id_Sex) && GetStrLen(objStudentInfoEN.id_Sex) > 4)
{
 throw new Exception("字段[性别流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfoEN.id_Ethnic) && GetStrLen(objStudentInfoEN.id_Ethnic) > 4)
{
 throw new Exception("字段[民族流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfoEN.id_UniZone) && GetStrLen(objStudentInfoEN.id_UniZone) > 4)
{
 throw new Exception("字段[校区流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfoEN.id_StuType) && GetStrLen(objStudentInfoEN.id_StuType) > 4)
{
 throw new Exception("字段[学生类别流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfoEN.id_XzCollege) && GetStrLen(objStudentInfoEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfoEN.id_XzMajor) && GetStrLen(objStudentInfoEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objStudentInfoEN.id_GradeBase) && GetStrLen(objStudentInfoEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfoEN.id_AdminCls) && GetStrLen(objStudentInfoEN.id_AdminCls) > 8)
{
 throw new Exception("字段[行政班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objStudentInfoEN.Birthday) && GetStrLen(objStudentInfoEN.Birthday) > 8)
{
 throw new Exception("字段[出生日期]的长度不能超过8!");
}
if (!Object.Equals(null, objStudentInfoEN.NativePlace) && GetStrLen(objStudentInfoEN.NativePlace) > 200)
{
 throw new Exception("字段[籍贯]的长度不能超过200!");
}
if (!Object.Equals(null, objStudentInfoEN.Duty) && GetStrLen(objStudentInfoEN.Duty) > 30)
{
 throw new Exception("字段[职位]的长度不能超过30!");
}
if (!Object.Equals(null, objStudentInfoEN.IDCardNo) && GetStrLen(objStudentInfoEN.IDCardNo) > 20)
{
 throw new Exception("字段[身份证号]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.StuCardNo) && GetStrLen(objStudentInfoEN.StuCardNo) > 20)
{
 throw new Exception("字段[学生证号]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.LiveAddress) && GetStrLen(objStudentInfoEN.LiveAddress) > 200)
{
 throw new Exception("字段[居住地址]的长度不能超过200!");
}
if (!Object.Equals(null, objStudentInfoEN.HomePhone) && GetStrLen(objStudentInfoEN.HomePhone) > 20)
{
 throw new Exception("字段[住宅电话]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.Id_CardNo) && GetStrLen(objStudentInfoEN.Id_CardNo) > 20)
{
 throw new Exception("字段[内卡号]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.CardNo) && GetStrLen(objStudentInfoEN.CardNo) > 18)
{
 throw new Exception("字段[卡号]的长度不能超过18!");
}
if (!Object.Equals(null, objStudentInfoEN.UserId) && GetStrLen(objStudentInfoEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.UserID4Avcon) && GetStrLen(objStudentInfoEN.UserID4Avcon) > 20)
{
 throw new Exception("字段[UserID4Avcon]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.EnrollmentDate) && GetStrLen(objStudentInfoEN.EnrollmentDate) > 8)
{
 throw new Exception("字段[入校日期]的长度不能超过8!");
}
if (!Object.Equals(null, objStudentInfoEN.PostCode) && GetStrLen(objStudentInfoEN.PostCode) > 6)
{
 throw new Exception("字段[邮编]的长度不能超过6!");
}
if (!Object.Equals(null, objStudentInfoEN.Email) && GetStrLen(objStudentInfoEN.Email) > 100)
{
 throw new Exception("字段[电子邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objStudentInfoEN.Microblog) && GetStrLen(objStudentInfoEN.Microblog) > 200)
{
 throw new Exception("字段[Microblog]的长度不能超过200!");
}
if (!Object.Equals(null, objStudentInfoEN.PhoneNumber) && GetStrLen(objStudentInfoEN.PhoneNumber) > 15)
{
 throw new Exception("字段[PhoneNumber]的长度不能超过15!");
}
if (!Object.Equals(null, objStudentInfoEN.Headphoto) && GetStrLen(objStudentInfoEN.Headphoto) > 500)
{
 throw new Exception("字段[Headphoto]的长度不能超过500!");
}
if (!Object.Equals(null, objStudentInfoEN.QQ) && GetStrLen(objStudentInfoEN.QQ) > 100)
{
 throw new Exception("字段[QQ]的长度不能超过100!");
}
if (!Object.Equals(null, objStudentInfoEN.RegisterPassword) && GetStrLen(objStudentInfoEN.RegisterPassword) > 30)
{
 throw new Exception("字段[RegisterPassword]的长度不能超过30!");
}
if (!Object.Equals(null, objStudentInfoEN.UpdDate) && GetStrLen(objStudentInfoEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.UpdUser) && GetStrLen(objStudentInfoEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfoEN.Memo) && GetStrLen(objStudentInfoEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objStudentInfoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentInfoEN GetObjByid_StudentInfo(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsStudentInfoEN objStudentInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objStudentInfoEN = JsonConvert.DeserializeObject<clsStudentInfoEN>((string)jobjReturn["ReturnObj"]);
return objStudentInfoEN;
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
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentInfoEN GetObjByid_StudentInfo_WA_Cache(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsStudentInfoEN objStudentInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objStudentInfoEN = JsonConvert.DeserializeObject<clsStudentInfoEN>((string)jobjReturn["ReturnObj"]);
return objStudentInfoEN;
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
public static clsStudentInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsStudentInfoEN objStudentInfoEN = null;
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
objStudentInfoEN = JsonConvert.DeserializeObject<clsStudentInfoEN>((string)jobjReturn["ReturnObj"]);
return objStudentInfoEN;
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsStudentInfoEN GetObjByid_StudentInfo_Cache(string strid_StudentInfo)
{
if (string.IsNullOrEmpty(strid_StudentInfo) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName_S);
List<clsStudentInfoEN> arrStudentInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentInfoEN> arrStudentInfoObjLst_Sel =
from objStudentInfoEN in arrStudentInfoObjLst_Cache
where objStudentInfoEN.id_StudentInfo == strid_StudentInfo
select objStudentInfoEN;
if (arrStudentInfoObjLst_Sel.Count() == 0)
{
   clsStudentInfoEN obj = clsStudentInfoWApi.GetObjByid_StudentInfo(strid_StudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrStudentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentInfoEN> GetObjLst(string strWhereCond)
{
 List<clsStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfoEN> GetObjLstById_StudentInfoLst(List<string> arrId_StudentInfo)
{
 List<clsStudentInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsStudentInfoEN> GetObjLstById_StudentInfoLst_Cache(List<string> arrId_StudentInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName_S);
List<clsStudentInfoEN> arrStudentInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentInfoEN> arrStudentInfoObjLst_Sel =
from objStudentInfoEN in arrStudentInfoObjLst_Cache
where arrId_StudentInfo.Contains(objStudentInfoEN.id_StudentInfo)
select objStudentInfoEN;
return arrStudentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentInfoEN> GetObjLstById_StudentInfoLst_WA_Cache(List<string> arrId_StudentInfo)
{
 List<clsStudentInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_StudentInfo)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsStudentInfoEN objStudentInfoEN = clsStudentInfoWApi.GetObjByid_StudentInfo(strid_StudentInfo);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_StudentInfo.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsStudentInfoWApi.ReFreshCache();
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
public static int DelStudentInfos(List<string> arrid_StudentInfo)
{
string strAction = "DelStudentInfos";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_StudentInfo);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsStudentInfoWApi.ReFreshCache();
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
public static int DelStudentInfosByCond(string strWhereCond)
{
string strAction = "DelStudentInfosByCond";
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
public static bool AddNewRecord(clsStudentInfoEN objStudentInfoEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfoEN>(objStudentInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsStudentInfoEN objStudentInfoEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfoEN>(objStudentInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfoWApi.ReFreshCache();
var strid_StudentInfo = (string)jobjReturn["ReturnStr"];
return strid_StudentInfo;
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
public static bool UpdateRecord(clsStudentInfoEN objStudentInfoEN)
{
if (string.IsNullOrEmpty(objStudentInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStudentInfoEN.id_StudentInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfoEN>(objStudentInfoEN);
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
 /// <param name = "objStudentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsStudentInfoEN objStudentInfoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objStudentInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStudentInfoEN.id_StudentInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStudentInfoEN.id_StudentInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfoEN>(objStudentInfoEN);
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
public static bool IsExist(string strid_StudentInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
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
 /// <param name = "objStudentInfoENS">源对象</param>
 /// <param name = "objStudentInfoENT">目标对象</param>
 public static void CopyTo(clsStudentInfoEN objStudentInfoENS, clsStudentInfoEN objStudentInfoENT)
{
try
{
objStudentInfoENT.id_StudentInfo = objStudentInfoENS.id_StudentInfo; //学生流水号
objStudentInfoENT.StuID = objStudentInfoENS.StuID; //学号
objStudentInfoENT.StuName = objStudentInfoENS.StuName; //姓名
objStudentInfoENT.id_Politics = objStudentInfoENS.id_Politics; //政治面貌流水号
objStudentInfoENT.id_Sex = objStudentInfoENS.id_Sex; //性别流水号
objStudentInfoENT.id_Ethnic = objStudentInfoENS.id_Ethnic; //民族流水号
objStudentInfoENT.id_UniZone = objStudentInfoENS.id_UniZone; //校区流水号
objStudentInfoENT.id_StuType = objStudentInfoENS.id_StuType; //学生类别流水号
objStudentInfoENT.id_XzCollege = objStudentInfoENS.id_XzCollege; //学院流水号
objStudentInfoENT.id_XzMajor = objStudentInfoENS.id_XzMajor; //专业流水号
objStudentInfoENT.id_GradeBase = objStudentInfoENS.id_GradeBase; //年级流水号
objStudentInfoENT.id_AdminCls = objStudentInfoENS.id_AdminCls; //行政班流水号
objStudentInfoENT.Birthday = objStudentInfoENS.Birthday; //出生日期
objStudentInfoENT.NativePlace = objStudentInfoENS.NativePlace; //籍贯
objStudentInfoENT.Duty = objStudentInfoENS.Duty; //职位
objStudentInfoENT.IDCardNo = objStudentInfoENS.IDCardNo; //身份证号
objStudentInfoENT.StuCardNo = objStudentInfoENS.StuCardNo; //学生证号
objStudentInfoENT.LiveAddress = objStudentInfoENS.LiveAddress; //居住地址
objStudentInfoENT.HomePhone = objStudentInfoENS.HomePhone; //住宅电话
objStudentInfoENT.Id_CardNo = objStudentInfoENS.Id_CardNo; //内卡号
objStudentInfoENT.CardNo = objStudentInfoENS.CardNo; //卡号
objStudentInfoENT.IsAvconClassUser = objStudentInfoENS.IsAvconClassUser; //IsAvconClassUser
objStudentInfoENT.IsAvconUser = objStudentInfoENS.IsAvconUser; //IsAvconUser
objStudentInfoENT.IsGpUser = objStudentInfoENS.IsGpUser; //是否Gp用户
objStudentInfoENT.IsLocalUser = objStudentInfoENS.IsLocalUser; //是否本地用户
objStudentInfoENT.IsLeaved = objStudentInfoENS.IsLeaved; //IsLeaved
objStudentInfoENT.UserId = objStudentInfoENS.UserId; //用户ID
objStudentInfoENT.UserID4Avcon = objStudentInfoENS.UserID4Avcon; //UserID4Avcon
objStudentInfoENT.EnrollmentDate = objStudentInfoENS.EnrollmentDate; //入校日期
objStudentInfoENT.PostCode = objStudentInfoENS.PostCode; //邮编
objStudentInfoENT.Email = objStudentInfoENS.Email; //电子邮箱
objStudentInfoENT.IsMessage = objStudentInfoENS.IsMessage; //IsMessage
objStudentInfoENT.Microblog = objStudentInfoENS.Microblog; //Microblog
objStudentInfoENT.PhoneNumber = objStudentInfoENS.PhoneNumber; //PhoneNumber
objStudentInfoENT.Headphoto = objStudentInfoENS.Headphoto; //Headphoto
objStudentInfoENT.QQ = objStudentInfoENS.QQ; //QQ
objStudentInfoENT.RegisterPassword = objStudentInfoENS.RegisterPassword; //RegisterPassword
objStudentInfoENT.UpdDate = objStudentInfoENS.UpdDate; //修改日期
objStudentInfoENT.UpdUser = objStudentInfoENS.UpdUser; //修改人
objStudentInfoENT.Memo = objStudentInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsStudentInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsStudentInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsStudentInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsStudentInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsStudentInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsStudentInfoEN.AttributeName)
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
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_StudentInfo");
//if (arrStudentInfoObjLst_Cache == null)
//{
//arrStudentInfoObjLst_Cache = await clsStudentInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName_S);
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
if (clsStudentInfoWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsStudentInfoWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsStudentInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsStudentInfoEN._CurrTabName_S);
List<clsStudentInfoEN> arrStudentInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrStudentInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsStudentInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conStudentInfo.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.StuID, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.StuName, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_Politics, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_Ethnic, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_StuType, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.Duty, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.Id_CardNo, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.CardNo, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.IsAvconClassUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conStudentInfo.IsAvconUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conStudentInfo.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conStudentInfo.IsLocalUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conStudentInfo.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(conStudentInfo.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.UserID4Avcon, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.Email, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.IsMessage, Type.GetType("System.Boolean"));
objDT.Columns.Add(conStudentInfo.Microblog, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.Headphoto, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.QQ, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.RegisterPassword, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo.Memo, Type.GetType("System.String"));
foreach (clsStudentInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conStudentInfo.id_StudentInfo] = objInFor[conStudentInfo.id_StudentInfo];
objDR[conStudentInfo.StuID] = objInFor[conStudentInfo.StuID];
objDR[conStudentInfo.StuName] = objInFor[conStudentInfo.StuName];
objDR[conStudentInfo.id_Politics] = objInFor[conStudentInfo.id_Politics];
objDR[conStudentInfo.id_Sex] = objInFor[conStudentInfo.id_Sex];
objDR[conStudentInfo.id_Ethnic] = objInFor[conStudentInfo.id_Ethnic];
objDR[conStudentInfo.id_UniZone] = objInFor[conStudentInfo.id_UniZone];
objDR[conStudentInfo.id_StuType] = objInFor[conStudentInfo.id_StuType];
objDR[conStudentInfo.id_XzCollege] = objInFor[conStudentInfo.id_XzCollege];
objDR[conStudentInfo.id_XzMajor] = objInFor[conStudentInfo.id_XzMajor];
objDR[conStudentInfo.id_GradeBase] = objInFor[conStudentInfo.id_GradeBase];
objDR[conStudentInfo.id_AdminCls] = objInFor[conStudentInfo.id_AdminCls];
objDR[conStudentInfo.Birthday] = objInFor[conStudentInfo.Birthday];
objDR[conStudentInfo.NativePlace] = objInFor[conStudentInfo.NativePlace];
objDR[conStudentInfo.Duty] = objInFor[conStudentInfo.Duty];
objDR[conStudentInfo.IDCardNo] = objInFor[conStudentInfo.IDCardNo];
objDR[conStudentInfo.StuCardNo] = objInFor[conStudentInfo.StuCardNo];
objDR[conStudentInfo.LiveAddress] = objInFor[conStudentInfo.LiveAddress];
objDR[conStudentInfo.HomePhone] = objInFor[conStudentInfo.HomePhone];
objDR[conStudentInfo.Id_CardNo] = objInFor[conStudentInfo.Id_CardNo];
objDR[conStudentInfo.CardNo] = objInFor[conStudentInfo.CardNo];
objDR[conStudentInfo.IsAvconClassUser] = objInFor[conStudentInfo.IsAvconClassUser];
objDR[conStudentInfo.IsAvconUser] = objInFor[conStudentInfo.IsAvconUser];
objDR[conStudentInfo.IsGpUser] = objInFor[conStudentInfo.IsGpUser];
objDR[conStudentInfo.IsLocalUser] = objInFor[conStudentInfo.IsLocalUser];
objDR[conStudentInfo.IsLeaved] = objInFor[conStudentInfo.IsLeaved];
objDR[conStudentInfo.UserId] = objInFor[conStudentInfo.UserId];
objDR[conStudentInfo.UserID4Avcon] = objInFor[conStudentInfo.UserID4Avcon];
objDR[conStudentInfo.EnrollmentDate] = objInFor[conStudentInfo.EnrollmentDate];
objDR[conStudentInfo.PostCode] = objInFor[conStudentInfo.PostCode];
objDR[conStudentInfo.Email] = objInFor[conStudentInfo.Email];
objDR[conStudentInfo.IsMessage] = objInFor[conStudentInfo.IsMessage];
objDR[conStudentInfo.Microblog] = objInFor[conStudentInfo.Microblog];
objDR[conStudentInfo.PhoneNumber] = objInFor[conStudentInfo.PhoneNumber];
objDR[conStudentInfo.Headphoto] = objInFor[conStudentInfo.Headphoto];
objDR[conStudentInfo.QQ] = objInFor[conStudentInfo.QQ];
objDR[conStudentInfo.RegisterPassword] = objInFor[conStudentInfo.RegisterPassword];
objDR[conStudentInfo.UpdDate] = objInFor[conStudentInfo.UpdDate];
objDR[conStudentInfo.UpdUser] = objInFor[conStudentInfo.UpdUser];
objDR[conStudentInfo.Memo] = objInFor[conStudentInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生(StudentInfo)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4StudentInfo : clsCommFun4BL
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
clsStudentInfoWApi.ReFreshThisCache();
clsvStudentInfoWApi.ReFreshThisCache();
}
}

}