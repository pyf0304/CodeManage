﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentTypeBLEx
 表名:QxDepartmentType(01120925)
 生成代码版本:2021.08.17.1
 生成日期:2021/08/19 23:17:29
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
public static class clsQxDepartmentTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objQxDepartmentTypeENS">源对象</param>
 /// <returns>目标对象=>clsQxDepartmentTypeEN:objQxDepartmentTypeENT</returns>
 public static clsQxDepartmentTypeENEx CopyToEx(this clsQxDepartmentTypeEN objQxDepartmentTypeENS)
{
try
{
 clsQxDepartmentTypeENEx objQxDepartmentTypeENT = new clsQxDepartmentTypeENEx();
clsQxDepartmentTypeBL.QxDepartmentTypeDA.CopyTo(objQxDepartmentTypeENS, objQxDepartmentTypeENT);
 return objQxDepartmentTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objQxDepartmentTypeENS">源对象</param>
 /// <returns>目标对象=>clsQxDepartmentTypeEN:objQxDepartmentTypeENT</returns>
 public static clsQxDepartmentTypeEN CopyTo(this clsQxDepartmentTypeENEx objQxDepartmentTypeENS)
{
try
{
 clsQxDepartmentTypeEN objQxDepartmentTypeENT = new clsQxDepartmentTypeEN();
clsQxDepartmentTypeBL.CopyTo(objQxDepartmentTypeENS, objQxDepartmentTypeENT);
 return objQxDepartmentTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 部门类型(QxDepartmentType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsQxDepartmentTypeBLEx : clsQxDepartmentTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsQxDepartmentTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsQxDepartmentTypeDAEx QxDepartmentTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsQxDepartmentTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objQxDepartmentTypeENS">源对象</param>
 /// <returns>目标对象=>clsQxDepartmentTypeEN:objQxDepartmentTypeENT</returns>
 public static clsQxDepartmentTypeENEx CopyToEx(clsQxDepartmentTypeEN objQxDepartmentTypeENS)
{
try
{
 clsQxDepartmentTypeENEx objQxDepartmentTypeENT = new clsQxDepartmentTypeENEx();
clsQxDepartmentTypeBL.QxDepartmentTypeDA.CopyTo(objQxDepartmentTypeENS, objQxDepartmentTypeENT);
 return objQxDepartmentTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsQxDepartmentTypeENEx> GetObjExLst(string strCondition)
{
List <clsQxDepartmentTypeEN> arrObjLst = clsQxDepartmentTypeBL.GetObjLst(strCondition);
List <clsQxDepartmentTypeENEx> arrObjExLst = new List<clsQxDepartmentTypeENEx>();
foreach (clsQxDepartmentTypeEN objInFor in arrObjLst)
{
clsQxDepartmentTypeENEx objQxDepartmentTypeENEx = new clsQxDepartmentTypeENEx();
clsQxDepartmentTypeBL.CopyTo(objInFor, objQxDepartmentTypeENEx);
arrObjExLst.Add(objQxDepartmentTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strDepartmentTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsQxDepartmentTypeENEx GetObjExByDepartmentTypeId(string strDepartmentTypeId)
{
clsQxDepartmentTypeEN objQxDepartmentTypeEN = clsQxDepartmentTypeBL.GetObjByDepartmentTypeId(strDepartmentTypeId);
clsQxDepartmentTypeENEx objQxDepartmentTypeENEx = new clsQxDepartmentTypeENEx();
clsQxDepartmentTypeBL.CopyTo(objQxDepartmentTypeEN, objQxDepartmentTypeENEx);
return objQxDepartmentTypeENEx;
}
}
}